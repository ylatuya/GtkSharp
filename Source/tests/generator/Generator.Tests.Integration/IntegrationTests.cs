using GtkSharp.Generation;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Generator.Tests
{
    public class IntegrationTests
    {
        string testDir = ".";
        string tempDir = ".";

        [SetUp]
        public void Setup()
        {
            testDir = TestContext.CurrentContext.TestDirectory;
            tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(tempDir);
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                Directory.Delete(tempDir, true);
            }
            catch { }
        }

        [Test]
        public void GenerateCode_Regress_CodeIsGeneratedCorrectly()
        {
            int res = GenerateCode();
            Assert.That(res, Is.EqualTo(0));
            Assert.That(Statistics.EnumCount, Is.EqualTo(22));
            Assert.That(Statistics.StructCount, Is.EqualTo(20));
            Assert.That(Statistics.BoxedCount, Is.EqualTo(9));
            Assert.That(Statistics.OpaqueCount, Is.EqualTo(5));
            Assert.That(Statistics.IFaceCount, Is.EqualTo(3));
            Assert.That(Statistics.ObjectCount, Is.EqualTo(12));
            Assert.That(Statistics.CBCount, Is.EqualTo(20));
            Assert.That(Statistics.PropCount, Is.EqualTo(21));
            Assert.That(Statistics.SignalCount, Is.EqualTo(17));
            Assert.That(Statistics.MethodCount, Is.EqualTo(299));
            Assert.That(Statistics.CtorCount, Is.EqualTo(25));
            Assert.That(Statistics.ThrottledCount, Is.EqualTo(20));
        }


        [Test]
        public void GenerateCode_Regress_CodeCanBeCompiled()
        {
            int res = GenerateCode();
            Assert.That(res, Is.EqualTo(0));
            Compile(tempDir);
        }

        private int GenerateCode()
        {
            Statistics.Reset();
            return CodeGenerator.GenerateCode(
                dir: tempDir,
                assembly_name: "regress-sharp",
                gapidir: testDir,
                abi_cs_usings: "GLib,Regress",
                abi_cs_file: "regress-sharp-abi.cs",
                abi_c_file: "regress-sharp-abi.c",
                glue_filename: "regress-sharp-glue.c",
                glue_includes: "regress.h",
                gluelib_name: "regress-sharp-glue",
                schema_name: null,
                filenames: new List<string> { "regress-sharp-api.xml" },
                includes: new List<string> { }
                );
        }

        void Compile(string sourcesDir)
        {
            DirectoryInfo d = new DirectoryInfo(sourcesDir);
            string[] sourceFiles = d.EnumerateFiles("*.cs", SearchOption.AllDirectories)
                .Select(a => a.FullName).ToArray();

            List<SyntaxTree> trees = new List<SyntaxTree>();
            foreach (string file in sourceFiles)
            {
                string code = File.ReadAllText(file);
                SyntaxTree tree = CSharpSyntaxTree.ParseText(code, path: file);
                trees.Add(tree);
            }

            // Reference Microsoft.NETCore.App
            var netCoreDir = new DirectoryInfo(Path.GetDirectoryName(typeof(object).Assembly.Location)!);
            List<PortableExecutableReference> references = netCoreDir.EnumerateFiles("*.dll", SearchOption.AllDirectories)
                .Where(f => f.Name.StartsWith("System"))
                .Where(f => !f.Name.EndsWith("Native.dll"))
                .Select(f => MetadataReference.CreateFromFile(f.FullName)).ToList();

            // Reference glib-sharp
            references.Add(MetadataReference.CreateFromFile(typeof(GLib.AbiField).Assembly.Location));
            // Reference gio-sharp
            references.Add(MetadataReference.CreateFromFile(typeof(GLib.GioStream).Assembly.Location));

            var compilation = CSharpCompilation.Create("regress-sharp.dll",
                   trees,
                   references,
                   new CSharpCompilationOptions(
                       OutputKind.DynamicallyLinkedLibrary,
                       allowUnsafe: true));
            var result = compilation.Emit(Path.Combine(tempDir, "regress-sharp.dll"));
            var errors = result.Diagnostics
                .Where(d => d.Severity == DiagnosticSeverity.Error);
            var warnings = result.Diagnostics
                .Where(d => d.Severity == DiagnosticSeverity.Warning)
                .Where(d => d.Id != "CS1701");
            foreach (var diag in errors)
            {
                Console.WriteLine(diag);
            }
            foreach (var diag in warnings)
            {
                Console.WriteLine(diag);
            }
            Assert.That(errors.Count(), Is.EqualTo(0));
            Assert.That(warnings.Count(), Is.EqualTo(4));
        }
    }
}