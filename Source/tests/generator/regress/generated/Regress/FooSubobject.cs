// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FooSubobject : Regress.FooObject {

		protected FooSubobject (IntPtr raw) : base(raw) {}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_subobject_new();

		public FooSubobject () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FooSubobject)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = regress_foo_subobject_new();
		}

		[DllImport ("regress-sharp-glue")]
		extern static uint regresssharp_regress_foosubobject_get_parent_instance_offset ();

		static uint parent_instance_offset = regresssharp_regress_foosubobject_get_parent_instance_offset ();
		public Regress.FooObject ParentInstance {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + parent_instance_offset);
					return GLib.Object.GetObject((*raw_ptr)) as Regress.FooObject;
				}
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Regress.FooObject.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_subobject_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_foo_subobject_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Regress.FooObject.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
