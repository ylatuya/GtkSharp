// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TextAppearance : GLib.Opaque {

		public TextAppearance(IntPtr raw) : base(raw) {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("bg_color"
							, 0
							, (uint) Marshal.SizeOf(typeof(Gdk.Color)) // bg_color
							, null
							, "fg_color"
							, (long) Marshal.OffsetOf(typeof(GtkTextAppearance_bg_colorAlign), "bg_color")
							, 0
							),
						new GLib.AbiField("fg_color"
							, -1
							, (uint) Marshal.SizeOf(typeof(Gdk.Color)) // fg_color
							, "bg_color"
							, "rise"
							, (long) Marshal.OffsetOf(typeof(GtkTextAppearance_fg_colorAlign), "fg_color")
							, 0
							),
						new GLib.AbiField("rise"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // rise
							, "fg_color"
							, "underline"
							, (long) Marshal.OffsetOf(typeof(GtkTextAppearance_riseAlign), "rise")
							, 0
							),
						new GLib.AbiField("underline"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Pango.Underline))) // underline
							, "rise"
							, "strikethrough"
							, 1
							, 4
							),
						new GLib.AbiField("strikethrough"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // strikethrough
							, "underline"
							, "draw_bg"
							, 1
							, 1
							),
						new GLib.AbiField("draw_bg"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // draw_bg
							, "strikethrough"
							, "inside_selection"
							, 1
							, 1
							),
						new GLib.AbiField("inside_selection"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // inside_selection
							, "draw_bg"
							, "is_text"
							, 1
							, 1
							),
						new GLib.AbiField("is_text"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // is_text
							, "inside_selection"
							, "rgba"
							, 1
							, 1
							),
						new GLib.AbiField("rgba"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 2 // rgba
							, "is_text"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAppearance_bg_colorAlign
		{
			sbyte f1;
			private Gdk.Color bg_color;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAppearance_fg_colorAlign
		{
			sbyte f1;
			private Gdk.Color fg_color;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GtkTextAppearance_riseAlign
		{
			sbyte f1;
			private int rise;
		}


		// End of the ABI representation.

#endregion
	}
}