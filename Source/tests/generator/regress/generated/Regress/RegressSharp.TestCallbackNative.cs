// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate int TestCallbackNative();

	internal class TestCallbackInvoker {

		TestCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~TestCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal TestCallbackInvoker (TestCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal TestCallbackInvoker (TestCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal TestCallbackInvoker (TestCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.TestCallback Handler {
			get {
				return new Regress.TestCallback(InvokeNative);
			}
		}

		int InvokeNative ()
		{
			int __result = native_cb ();
			return __result;
		}
	}

	internal class TestCallbackWrapper {

		public int NativeCallback ()
		{
			try {
				int __ret = managed ();
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal TestCallbackNative NativeDelegate;
		Regress.TestCallback managed;

		public TestCallbackWrapper (Regress.TestCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new TestCallbackNative (NativeCallback);
		}

		public static Regress.TestCallback GetManagedDelegate (TestCallbackNative native)
		{
			if (native == null)
				return null;
			TestCallbackWrapper wrapper = (TestCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
