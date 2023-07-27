// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool FooCallbackNative(IntPtr regress_foo, bool b, IntPtr data);

	internal class FooCallbackInvoker {

		FooCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FooCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FooCallbackInvoker (FooCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FooCallbackInvoker (FooCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FooCallbackInvoker (FooCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.FooCallback Handler {
			get {
				return new Regress.FooCallback(InvokeNative);
			}
		}

		bool InvokeNative (Regress.FooObject regress_foo, bool b, IntPtr data)
		{
			bool __result = native_cb (regress_foo == null ? IntPtr.Zero : regress_foo.Handle, b, __data);
			return __result;
		}
	}

	internal class FooCallbackWrapper {

		public bool NativeCallback (IntPtr regress_foo, bool b, IntPtr data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(regress_foo) as Regress.FooObject, b, data);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FooCallbackNative NativeDelegate;
		Regress.FooCallback managed;

		public FooCallbackWrapper (Regress.FooCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FooCallbackNative (NativeCallback);
		}

		public static Regress.FooCallback GetManagedDelegate (FooCallbackNative native)
		{
			if (native == null)
				return null;
			FooCallbackWrapper wrapper = (FooCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
