// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AttrFontFeatures : GLib.Opaque {

		[DllImport ("pango-sharp-glue")]
		extern static uint pangosharp_pango_attrfontfeatures_get_features_offset ();

		static uint features_offset = pangosharp_pango_attrfontfeatures_get_features_offset ();
		public string Features {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + features_offset);
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + features_offset);
					*raw_ptr = GLib.Marshaller.StringToPtrGStrdup (value);
				}
			}
		}

		public AttrFontFeatures(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_font_features_new(IntPtr features);

		public AttrFontFeatures (string features) 
		{
			IntPtr native_features = GLib.Marshaller.StringToPtrGStrdup (features);
			Raw = pango_attr_font_features_new(native_features);
			GLib.Marshaller.Free (native_features);
		}

#endregion
	}
}
