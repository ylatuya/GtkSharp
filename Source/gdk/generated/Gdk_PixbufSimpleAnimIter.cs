// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufSimpleAnimIter : GLib.Opaque {

		[DllImport("gdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_simple_anim_iter_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_simple_anim_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public PixbufSimpleAnimIter(IntPtr raw) : base(raw) {}

		protected PixbufSimpleAnimIter() : base() {}


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
