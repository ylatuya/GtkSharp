// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void MapEventHandler(object o, MapEventArgs args);

	public class MapEventArgs : GLib.SignalArgs {
		public Gdk.Event Event{
			get {
				return (Gdk.Event) Args [0];
			}
		}

	}
}