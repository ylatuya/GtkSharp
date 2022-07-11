// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TestFundamentalSubObject : Regress.TestFundamentalObject {

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_testfundamentalsubobject_get_fundamental_object_offset ();

		static uint fundamental_object_offset = regresssharp_regress_testfundamentalsubobject_get_fundamental_object_offset ();
		public Regress.TestFundamentalObject FundamentalObject {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + fundamental_object_offset);
					return (*raw_ptr) == IntPtr.Zero ? null : (Regress.TestFundamentalObject) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Regress.TestFundamentalObject), false);
				}
			}
		}

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_testfundamentalsubobject_get_data_offset ();

		static uint data_offset = regresssharp_regress_testfundamentalsubobject_get_data_offset ();
		public string Data {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + data_offset);
					return GLib.Marshaller.Utf8PtrToString ((*raw_ptr));
				}
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_sub_object_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_test_fundamental_sub_object_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		public TestFundamentalSubObject(IntPtr raw) : base(raw) {}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_fundamental_sub_object_new(IntPtr data);

		public static TestFundamentalSubObject New(string data)
		{
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			TestFundamentalSubObject result = new TestFundamentalSubObject (regress_test_fundamental_sub_object_new(native_data));
			GLib.Marshaller.Free (native_data);
			return result;
		}

#endregion
	}
}
