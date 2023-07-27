// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Coverage : GLib.Opaque {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_coverage_copy(IntPtr raw);

		public Pango.Coverage Copy() {
			IntPtr raw_ret = pango_coverage_copy(Handle);
			Pango.Coverage ret = raw_ret == IntPtr.Zero ? null : (Pango.Coverage) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Coverage), true);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_coverage_from_bytes(out byte bytes, int n_bytes);

		public static Pango.Coverage FromBytes(out byte bytes, int n_bytes) {
			IntPtr raw_ret = pango_coverage_from_bytes(out bytes, n_bytes);
			Pango.Coverage ret = raw_ret == IntPtr.Zero ? null : (Pango.Coverage) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Coverage), false);
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_coverage_get(IntPtr raw, int index_);

		public Pango.CoverageLevel Get(int index_) {
			int raw_ret = pango_coverage_get(Handle, index_);
			Pango.CoverageLevel ret = (Pango.CoverageLevel) raw_ret;
			return ret;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_coverage_max(IntPtr raw, IntPtr other);

		public void Max(Pango.Coverage other) {
			pango_coverage_max(Handle, other == null ? IntPtr.Zero : other.Handle);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_coverage_set(IntPtr raw, int index_, int level);

		public void Set(int index_, Pango.CoverageLevel level) {
			pango_coverage_set(Handle, index_, (int) level);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_coverage_new();

		public Coverage () 
		{
			Raw = pango_coverage_new();
		}

		public Coverage(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_coverage_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				pango_coverage_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Pango.Coverage is now refcounted automatically")]
		public Coverage Ref () { return this; }

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_coverage_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				pango_coverage_unref (raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return pango_coverage_unref;
			}
		}

		[Obsolete("Pango.Coverage is now refcounted automatically")]
		public void Unref () {}


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
