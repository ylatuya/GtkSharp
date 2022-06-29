// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooDBusData : IEquatable<FooDBusData> {


		public static Regress.FooDBusData Zero = new Regress.FooDBusData ();

		public static Regress.FooDBusData New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooDBusData.Zero;
			return (Regress.FooDBusData) Marshal.PtrToStructure (raw, typeof (Regress.FooDBusData));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_dbus_data_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_foo_dbus_data_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_foo_dbus_data_method(IntPtr raw);

		public void Method() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			regress_foo_dbus_data_method(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Regress.FooDBusData target)
		{
			target = New (native);
		}

		public bool Equals (FooDBusData other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is FooDBusData && Equals ((FooDBusData) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Regress.FooDBusData boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Regress.FooDBusData.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Regress.FooDBusData (GLib.Value val)
		{
			return (Regress.FooDBusData) val.Val;
		}
#endregion
	}
}