// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FileAttributeMatcher : GLib.Opaque {

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_attribute_matcher_enumerate_namespace(IntPtr raw, IntPtr ns);

		public bool EnumerateNamespace(string ns) {
			IntPtr native_ns = GLib.Marshaller.StringToPtrGStrdup (ns);
			bool raw_ret = g_file_attribute_matcher_enumerate_namespace(Handle, native_ns);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_ns);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_enumerate_next(IntPtr raw);

		public string EnumerateNext() {
			IntPtr raw_ret = g_file_attribute_matcher_enumerate_next(Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_attribute_matcher_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_attribute_matcher_matches(IntPtr raw, IntPtr attribute);

		public bool Matches(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			bool raw_ret = g_file_attribute_matcher_matches(Handle, native_attribute);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_file_attribute_matcher_matches_only(IntPtr raw, IntPtr attribute);

		public bool MatchesOnly(string attribute) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			bool raw_ret = g_file_attribute_matcher_matches_only(Handle, native_attribute);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_subtract(IntPtr raw, IntPtr subtract);

		public GLib.FileAttributeMatcher Subtract(GLib.FileAttributeMatcher subtract) {
			IntPtr raw_ret = g_file_attribute_matcher_subtract(Handle, subtract == null ? IntPtr.Zero : subtract.Handle);
			GLib.FileAttributeMatcher ret = raw_ret == IntPtr.Zero ? null : (GLib.FileAttributeMatcher) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.FileAttributeMatcher), false);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = g_file_attribute_matcher_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_new(IntPtr attributes);

		public FileAttributeMatcher (string attributes) 
		{
			IntPtr native_attributes = GLib.Marshaller.StringToPtrGStrdup (attributes);
			Raw = g_file_attribute_matcher_new(native_attributes);
			GLib.Marshaller.Free (native_attributes);
		}

		public FileAttributeMatcher(IntPtr raw) : base(raw) {}

		protected FileAttributeMatcher() : base() {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_matcher_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				g_file_attribute_matcher_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_attribute_matcher_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				g_file_attribute_matcher_unref (raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return g_file_attribute_matcher_unref;
			}
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
