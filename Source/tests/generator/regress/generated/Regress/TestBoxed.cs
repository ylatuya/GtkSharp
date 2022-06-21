// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TestBoxed : IEquatable<TestBoxed> {

		public sbyte SomeInt8;
		public Regress.TestSimpleBoxedA NestedA;
		private IntPtr _priv;

		public static Regress.TestBoxed Zero = new Regress.TestBoxed ();

		public static Regress.TestBoxed New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.TestBoxed.Zero;
			return (Regress.TestBoxed) Marshal.PtrToStructure (raw, typeof (Regress.TestBoxed));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_boxed_new();

		public static TestBoxed New()
		{
			TestBoxed result = TestBoxed.New (regress_test_boxed_new());
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_boxed_new_alternative_constructor1(int i);

		public static TestBoxed NewAlternativeConstructor1(int i)
		{
			TestBoxed result = TestBoxed.New (regress_test_boxed_new_alternative_constructor1(i));
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_boxed_new_alternative_constructor2(int i, int j);

		public static TestBoxed NewAlternativeConstructor2(int i, int j)
		{
			TestBoxed result = TestBoxed.New (regress_test_boxed_new_alternative_constructor2(i, j));
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_boxed_new_alternative_constructor3(IntPtr s);

		public static TestBoxed NewAlternativeConstructor3(string s)
		{
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup (s);
			TestBoxed result = TestBoxed.New (regress_test_boxed_new_alternative_constructor3(native_s));
			GLib.Marshaller.Free (native_s);
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_boxed_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_test_boxed_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_boxeds_not_a_method(IntPtr raw);

		public void _notNotAMethod() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			regress_test_boxeds_not_a_method(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool regress_test_boxed_equals(IntPtr raw, IntPtr other);

		public bool Equals(Regress.TestBoxed other) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_other = GLib.Marshaller.StructureToPtrAlloc (other);
			bool raw_ret = regress_test_boxed_equals(this_as_native, native_other);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_other);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Regress.TestBoxed target)
		{
			target = New (native);
		}

		public bool Equals (TestBoxed other)
		{
			return true && SomeInt8.Equals (other.SomeInt8) && NestedA.Equals (other.NestedA) && _priv.Equals (other._priv);
		}

		public override bool Equals (object other)
		{
			return other is TestBoxed && Equals ((TestBoxed) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ SomeInt8.GetHashCode () ^ NestedA.GetHashCode () ^ _priv.GetHashCode ();
		}

		public static explicit operator GLib.Value (Regress.TestBoxed boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Regress.TestBoxed.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Regress.TestBoxed (GLib.Value val)
		{
			return (Regress.TestBoxed) val.Val;
		}
#endregion
	}
}
