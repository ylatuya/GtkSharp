// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void WritableChangedHandler(object o, WritableChangedArgs args);

	public class WritableChangedArgs : GLib.SignalArgs {
		public string Key{
			get {
				return (string) Args [0];
			}
		}

	}
}