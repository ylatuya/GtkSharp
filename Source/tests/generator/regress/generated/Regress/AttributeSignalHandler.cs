// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void AttributeSignalHandler(object o, AttributeSignalArgs args);

	public class AttributeSignalArgs : GLib.SignalArgs {
		public string Arg1{
			get {
				return (string) Args [0];
			}
		}

		public string Arg2{
			get {
				return (string) Args [1];
			}
		}

	}
}
