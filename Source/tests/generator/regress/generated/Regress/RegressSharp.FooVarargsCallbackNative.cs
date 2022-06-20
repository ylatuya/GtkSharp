// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace RegressSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void FooVarargsCallbackNative(IntPtr param, IntPtr _va_list);

	internal class FooVarargsCallbackInvoker {

		FooVarargsCallbackNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~FooVarargsCallbackInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal FooVarargsCallbackInvoker (FooVarargsCallbackNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal FooVarargsCallbackInvoker (FooVarargsCallbackNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal FooVarargsCallbackInvoker (FooVarargsCallbackNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Regress.FooVarargsCallback Handler {
			get {
				return new Regress.FooVarargsCallback(InvokeNative);
			}
		}

		void InvokeNative (string param, IntPtr _va_list)
		{
			IntPtr native_param = GLib.Marshaller.StringToPtrGStrdup (param);
			native_cb (native_param, _va_list);
			GLib.Marshaller.Free (native_param);
		}
	}

	internal class FooVarargsCallbackWrapper {

		public void NativeCallback (IntPtr param, IntPtr _va_list)
		{
			try {
				managed (GLib.Marshaller.Utf8PtrToString (param), _va_list);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal FooVarargsCallbackNative NativeDelegate;
		Regress.FooVarargsCallback managed;

		public FooVarargsCallbackWrapper (Regress.FooVarargsCallback managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new FooVarargsCallbackNative (NativeCallback);
		}

		public static Regress.FooVarargsCallback GetManagedDelegate (FooVarargsCallbackNative native)
		{
			if (native == null)
				return null;
			FooVarargsCallbackWrapper wrapper = (FooVarargsCallbackWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
