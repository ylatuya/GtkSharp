// GtkSharp.Generation.ObjectGen.cs - The Object Generatable.
//
// Author: Mike Kestner <mkestner@ximian.com>
//
// Copyright (c) 2001-2003 Mike Kestner
// Copyright (c) 2003-2004 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the GNU General Public
// License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GtkSharp.Generation
{

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml;

    public class ObjectGen : ObjectBase
    {

        private IList<string> custom_attrs = new List<string>();
        private IList<XmlElement> strings = new List<XmlElement>();
        private IDictionary<string, ChildProperty> childprops = new Dictionary<string, ChildProperty>();
        private static IDictionary<string, DirectoryInfo> dirs = new Dictionary<string, DirectoryInfo>();

        public ObjectGen(XmlElement ns, XmlElement elem) : base(ns, elem, false)
        {
            foreach (XmlNode node in elem.ChildNodes)
            {
                XmlElement member = node as XmlElement;
                if (member == null)
                {
                    continue;
                }

                if (member.GetAttributeAsBoolean("hidden"))
                    continue;

                switch (node.Name)
                {
                    case "callback":
                        Statistics.IgnoreCount++;
                        break;

                    case "custom-attribute":
                        custom_attrs.Add(member.InnerXml);
                        break;

                    case "static-string":
                        strings.Add(member);
                        break;

                    case "childprop":
                        string name = member.GetAttribute("name");
                        while (childprops.ContainsKey(name))
                            name += "mangled";
                        childprops.Add(name, new ChildProperty(member, this));
                        break;

                    default:
                        if (!IsNodeNameHandled(node.Name))
                            Console.WriteLine("Unexpected node " + node.Name + " in " + CName);
                        break;
                }
            }
        }

        public override string CallByName(string var, bool owned)
        {
            return String.Format("{0} == null ? IntPtr.Zero : {0}.{1}", var, owned ? "OwnedHandle" : "Handle");
        }

        public override bool Validate()
        {
            LogWriter log = new LogWriter(QualifiedName);

            var invalids = new List<string>();

            foreach (string prop_name in childprops.Keys)
            {
                if (!childprops[prop_name].Validate(log))
                    invalids.Add(prop_name);
            }
            foreach (string prop_name in invalids)
                childprops.Remove(prop_name);

            return base.Validate();
        }

        private bool DisableVoidCtor
        {
            get
            {
                return Elem.GetAttributeAsBoolean("disable_void_ctor");
            }
        }

        private class DirectoryInfo
        {
            public string assembly_name;
            public IDictionary<string, string> objects;

            public DirectoryInfo(string assembly_name)
            {
                this.assembly_name = assembly_name;
                objects = new Dictionary<string, string>();
            }
        }

        private static DirectoryInfo GetDirectoryInfo(string dir, string assembly_name)
        {
            DirectoryInfo result;

            if (dirs.ContainsKey(dir))
            {
                result = dirs[dir];
                if (result.assembly_name != assembly_name)
                {
                    Console.WriteLine("Can't put multiple assemblies in one directory.");
                    return null;
                }

                return result;
            }

            result = new DirectoryInfo(assembly_name);
            dirs.Add(dir, result);

            return result;
        }

        public override void Generate(GenerationInfo gen_info)
        {
            gen_info.CurrentType = QualifiedName;

            string asm_name = gen_info.AssemblyName.Length == 0 ? NS.ToLower() + "-sharp" : gen_info.AssemblyName;
            DirectoryInfo di = GetDirectoryInfo(gen_info.Dir, asm_name);

            StreamWriter sw = gen_info.Writer = gen_info.OpenStream(Name, NS);

            sw.WriteLine("namespace " + NS + " {");
            sw.WriteLine();
            sw.WriteLine("\tusing System;");
            sw.WriteLine("\tusing System.Collections;");
            sw.WriteLine("\tusing System.Collections.Generic;");
            sw.WriteLine("\tusing System.Runtime.InteropServices;");
            sw.WriteLine();

            SymbolTable table = SymbolTable.Table;

            sw.WriteLine("#region Autogenerated code");
            if (IsDeprecated)
                sw.WriteLine("\t[Obsolete]");
            foreach (string attr in custom_attrs)
                sw.WriteLine("\t" + attr);
            sw.Write("\t{0} {1}partial class " + Name, IsInternal ? "internal" : "public", IsAbstract ? "abstract " : "");
            string cs_parent = table.GetCSType(Elem.GetAttribute("parent"));
            if (cs_parent != "")
            {
                di.objects.Add(CName, QualifiedName);
                sw.Write(" : " + cs_parent);
            }
            foreach (string iface in interfaces)
            {
                if (Parent != null && Parent.Implements(iface))
                    continue;
                sw.Write(", " + table.GetCSType(iface));
            }
            foreach (string iface in managed_interfaces)
            {
                if (Parent != null && Parent.Implements(iface))
                    continue;
                sw.Write(", " + iface);
            }
            sw.WriteLine(" {");
            sw.WriteLine();

            GenCtors(gen_info);
            GenProperties(gen_info, null);
            GenFields(gen_info);
            GenChildProperties(gen_info);

            bool has_sigs = (sigs != null && sigs.Count > 0);
            if (!has_sigs)
            {
                foreach (string iface in interfaces)
                {
                    InterfaceGen igen = table.GetClassGen(iface) as InterfaceGen;
                    if (igen != null && igen.Signals != null)
                    {
                        has_sigs = true;
                        break;
                    }
                }
            }

            if (has_sigs && Elem.HasAttribute("parent"))
            {
                GenSignals(gen_info, null);
            }

            GenConstants(gen_info);
            GenClassMembers(gen_info, cs_parent);
            GenMethods(gen_info, null, null);

            if (interfaces.Count != 0)
            {
                var all_methods = new Dictionary<string, Method>();
                foreach (Method m in Methods.Values)
                {
                    all_methods[m.Name] = m;
                }
                var collisions = new Dictionary<string, bool>();
                foreach (string iface in interfaces)
                {
                    ClassBase igen = table.GetClassGen(iface);
                    foreach (Method m in igen.Methods.Values)
                    {
                        if (m.Name.StartsWith("Get") || m.Name.StartsWith("Set"))
                        {
                            if (GetProperty(m.Name.Substring(3)) != null)
                            {
                                collisions[m.Name] = true;
                                continue;
                            }
                        }
                        Method collision = null;
                        all_methods.TryGetValue(m.Name, out collision);
                        if (collision != null && collision.Signature.Types == m.Signature.Types)
                            collisions[m.Name] = true;
                        else
                            all_methods[m.Name] = m;
                    }
                }

                foreach (string iface in interfaces)
                {
                    if (Parent != null && Parent.Implements(iface))
                        continue;
                    InterfaceGen igen = table.GetClassGen(iface) as InterfaceGen;
                    igen.GenMethods(gen_info, collisions, this);
                    igen.GenProperties(gen_info, this);
                    igen.GenSignals(gen_info, this);
                    igen.GenVirtualMethods(gen_info, this);
                }
            }

            foreach (XmlElement str in strings)
            {
                sw.Write("\t\tpublic static string " + str.GetAttribute("name"));
                sw.WriteLine(" {\n\t\t\t get { return \"" + str.GetAttribute("value") + "\"; }\n\t\t}");
            }

            if (cs_parent != String.Empty && GetExpected(CName) != QualifiedName)
            {
                sw.WriteLine();
                sw.WriteLine("\t\tstatic " + Name + " ()");
                sw.WriteLine("\t\t{");
                sw.WriteLine("\t\t\tGtkSharp." + Studlify(asm_name) + ".ObjectManager.Initialize ();");
                sw.WriteLine("\t\t}");
            }

            GenerateStructureABI(gen_info);
            sw.WriteLine("#endregion");

            sw.WriteLine("\t}");
            sw.WriteLine("}");

            sw.Close();
            gen_info.Writer = null;
            Statistics.ObjectCount++;
        }

        protected override void GenCtors(GenerationInfo gen_info)
        {
            if (!Elem.HasAttribute("parent"))
                return;
            string defaultconstructoraccess = Elem.HasAttribute("defaultconstructoraccess") ? Elem.GetAttribute("defaultconstructoraccess") : "public";

            gen_info.Writer.WriteLine("\t\t" + defaultconstructoraccess + " " + Name + " (IntPtr raw) : base(raw) {}");
            if (ctors.Count == 0 && !DisableVoidCtor)
            {
                gen_info.Writer.WriteLine();
                gen_info.Writer.WriteLine("\t\tprotected " + Name + "() : base(IntPtr.Zero)");
                gen_info.Writer.WriteLine("\t\t{");
                gen_info.Writer.WriteLine("\t\t\tCreateNativeObject (new string [0], new GLib.Value [0]);");
                gen_info.Writer.WriteLine("\t\t}");
            }
            gen_info.Writer.WriteLine();

            base.GenCtors(gen_info);
        }

        protected void GenChildProperties(GenerationInfo gen_info)
        {
            if (childprops.Count == 0)
                return;

            StreamWriter sw = gen_info.Writer;

            ObjectGen child_ancestor = Parent as ObjectGen;
            while (child_ancestor.CName != "GtkContainer" &&
                   child_ancestor.childprops.Count == 0)
                child_ancestor = child_ancestor.Parent as ObjectGen;

            sw.WriteLine("\t\tpublic class " + Name + "Child : " + child_ancestor.NS + "." + child_ancestor.Name + "." + child_ancestor.Name + "Child {");
            sw.WriteLine("\t\t\tprotected internal " + Name + "Child (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}");
            sw.WriteLine("");

            foreach (ChildProperty prop in childprops.Values)
                prop.Generate(gen_info, "\t\t\t", null);

            sw.WriteLine("\t\t}");
            sw.WriteLine("");

            sw.WriteLine("\t\tpublic override Gtk.Container.ContainerChild this [Gtk.Widget child] {");
            sw.WriteLine("\t\t\tget {");
            sw.WriteLine("\t\t\t\treturn new " + Name + "Child (this, child);");
            sw.WriteLine("\t\t\t}");
            sw.WriteLine("\t\t}");
            sw.WriteLine("");

        }

        void GenClassMembers(GenerationInfo gen_info, string cs_parent)
        {
            GenVirtualMethods(gen_info, null);
            GenerateStructureABI(gen_info, abi_class_members, "class_abi", ClassStructName);
        }

        /* Keep this in sync with the one in glib/GType.cs */
        private static string GetExpected(string cname)
        {
            for (int i = 1; i < cname.Length; i++)
            {
                if (Char.IsUpper(cname[i]))
                {
                    if (i == 1 && cname[0] == 'G')
                        return "GLib." + cname.Substring(1);
                    else
                        return cname.Substring(0, i) + "." + cname.Substring(i);
                }
            }

            throw new ArgumentException("cname doesn't follow the NamespaceType capitalization style: " + cname);
        }

        private static bool NeedsMap(IDictionary<string, string> objs, string assembly_name)
        {
            foreach (string key in objs.Keys)
            {
                if (GetExpected(key) != objs[key])
                {
                    return true;
                }
            }

            return false;
        }

        private static string Studlify(string name)
        {
            string result = "";

            string[] subs = name.Split('-');
            foreach (string sub in subs)
                result += Char.ToUpper(sub[0]) + sub.Substring(1);

            return result;
        }

        public static void GenerateMappers()
        {
            foreach (string dir in dirs.Keys)
            {

                DirectoryInfo di = dirs[dir];

                if (!NeedsMap(di.objects, di.assembly_name))
                    continue;

                GenerationInfo gen_info = new GenerationInfo(dir, di.assembly_name);

                GenerateMapper(di, gen_info);
            }
        }

        private static void GenerateMapper(DirectoryInfo dir_info, GenerationInfo gen_info)
        {
            StreamWriter sw = gen_info.OpenStream("ObjectManager", "GtkSharp");

            sw.WriteLine("namespace GtkSharp." + Studlify(dir_info.assembly_name) + " {");
            sw.WriteLine();
            sw.WriteLine("\tpublic class ObjectManager {");
            sw.WriteLine();
            sw.WriteLine("\t\tstatic bool initialized = false;");
            sw.WriteLine("\t\t// Call this method from the appropriate module init function.");
            sw.WriteLine("\t\tpublic static void Initialize ()");
            sw.WriteLine("\t\t{");
            sw.WriteLine("\t\t\tif (initialized)");
            sw.WriteLine("\t\t\t\treturn;");
            sw.WriteLine("");
            sw.WriteLine("\t\t\tinitialized = true;");

            foreach (string key in dir_info.objects.Keys)
            {
                if (GetExpected(key) != dir_info.objects[key])
                {
                    sw.WriteLine("\t\t\tGLib.GType.Register ({0}.GType, typeof ({0}));", dir_info.objects[key]);
                }
            }

            sw.WriteLine("\t\t}");
            sw.WriteLine("\t}");
            sw.WriteLine("}");
            sw.Close();
        }
    }

}

