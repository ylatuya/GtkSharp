// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void ActionChangedHandler(object o, ActionChangedArgs args);

	public class ActionChangedArgs : GLib.SignalArgs {
		public Gdk.DragAction Action{
			get {
				return (Gdk.DragAction) Args [0];
			}
		}

	}
}