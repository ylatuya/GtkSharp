// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TestWi8021x : GLib.Object {

		public TestWi8021x (IntPtr raw) : base(raw) {}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_wi_802_1x_new();

		public TestWi8021x () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TestWi8021x)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = regress_test_wi_802_1x_new();
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool regress_test_wi_802_1x_get_testbool(IntPtr raw);

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_test_wi_802_1x_set_testbool(IntPtr raw, bool v);

		[GLib.Property ("testbool")]
		public bool Testbool {
			get  {
				bool raw_ret = regress_test_wi_802_1x_get_testbool(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				regress_test_wi_802_1x_set_testbool(Handle, value);
			}
		}

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_testwi8021x_get_parent_instance_offset ();

		static uint parent_instance_offset = regresssharp_regress_testwi8021x_get_parent_instance_offset ();
		public GLib.Object ParentInstance {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + parent_instance_offset);
					return GLib.Object.GetObject ((*raw_ptr));
				}
			}
		}

		public bool TestboolField {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("testbool"));
					return (*raw_ptr);
				}
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (GLib.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_wi_802_1x_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_test_wi_802_1x_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_test_wi_802_1x_static_method(int x);

		public static int StaticMethod(int x) {
			int raw_ret = regress_test_wi_802_1x_static_method(x);
			int ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("testbool"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // testbool
							, null
							, null
							, (long) Marshal.OffsetOf(typeof(RegressTestWi8021x_testboolAlign), "testbool")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RegressTestWi8021x_testboolAlign
		{
			sbyte f1;
			private bool testbool;
		}


		// End of the ABI representation.

#endregion
	}
}
