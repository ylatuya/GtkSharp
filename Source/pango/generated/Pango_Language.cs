// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Language : GLib.Opaque {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_language_from_string(IntPtr language);

		public static Pango.Language FromString(string language) {
			IntPtr native_language = GLib.Marshaller.StringToPtrGStrdup (language);
			IntPtr raw_ret = pango_language_from_string(native_language);
			Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
			GLib.Marshaller.Free (native_language);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_language_get_default();

		public static Pango.Language Default { 
			get {
				IntPtr raw_ret = pango_language_get_default();
				Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_language_get_sample_string(IntPtr raw);

		public string SampleString { 
			get {
				IntPtr raw_ret = pango_language_get_sample_string(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_language_get_scripts(IntPtr raw, out int num_scripts);

		public Pango.Script GetScripts(out int num_scripts) {
			int raw_ret = pango_language_get_scripts(Handle, out num_scripts);
			Pango.Script ret = (Pango.Script) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_language_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_language_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_language_includes_script(IntPtr raw, int script);

		public bool IncludesScript(Pango.Script script) {
			bool raw_ret = pango_language_includes_script(Handle, (int) script);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_language_matches(IntPtr raw, IntPtr range_list);

		public bool Matches(string range_list) {
			IntPtr native_range_list = GLib.Marshaller.StringToPtrGStrdup (range_list);
			bool raw_ret = pango_language_matches(Handle, native_range_list);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_range_list);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_language_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = pango_language_to_string(Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		public Language(IntPtr raw) : base(raw) {}

		protected Language() : base() {}


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
