// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CssSection : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_css_section_get_end_line(IntPtr raw);

		public uint EndLine { 
			get {
				uint raw_ret = gtk_css_section_get_end_line(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_css_section_get_end_position(IntPtr raw);

		public uint EndPosition { 
			get {
				uint raw_ret = gtk_css_section_get_end_position(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_css_section_get_file(IntPtr raw);

		public GLib.IFile File { 
			get {
				IntPtr raw_ret = gtk_css_section_get_file(Handle);
				GLib.IFile ret = GLib.FileAdapter.GetObject (raw_ret, false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_css_section_get_parent(IntPtr raw);

		public Gtk.CssSection Parent { 
			get {
				IntPtr raw_ret = gtk_css_section_get_parent(Handle);
				Gtk.CssSection ret = raw_ret == IntPtr.Zero ? null : (Gtk.CssSection) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.CssSection), false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_css_section_get_section_type(IntPtr raw);

		public Gtk.CssSectionType SectionType { 
			get {
				int raw_ret = gtk_css_section_get_section_type(Handle);
				Gtk.CssSectionType ret = (Gtk.CssSectionType) raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_css_section_get_start_line(IntPtr raw);

		public uint StartLine { 
			get {
				uint raw_ret = gtk_css_section_get_start_line(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_css_section_get_start_position(IntPtr raw);

		public uint StartPosition { 
			get {
				uint raw_ret = gtk_css_section_get_start_position(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_css_section_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_css_section_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public CssSection(IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_css_section_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtk_css_section_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_css_section_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtk_css_section_unref (raw);
				Owned = false;
			}
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gtk_css_section_unref (handle);
				return false;
			}
		}

		~CssSection ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}