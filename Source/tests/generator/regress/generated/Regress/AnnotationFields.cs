// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AnnotationFields : IEquatable<AnnotationFields> {

		public int Field1;
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
		public byte[] Arr;
		private UIntPtr len;
		public ulong Len {
			get {
				return (ulong)len;
			}
			set {
				len = new UIntPtr(value);
			}
		}
		public uint Field4;

		public static Regress.AnnotationFields Zero = new Regress.AnnotationFields();

		public static Regress.AnnotationFields New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.AnnotationFields.Zero;
			return (Regress.AnnotationFields)Marshal.PtrToStructure(raw, typeof(Regress.AnnotationFields));
		}

		public bool Equals(AnnotationFields other) {
			return true && Field1.Equals(other.Field1) && Arr.Equals(other.Arr) && Len.Equals(other.Len) && Field4.Equals(other.Field4);
		}

		public override bool Equals(object other) {
			return other is AnnotationFields && Equals((AnnotationFields)other);
		}

		public override int GetHashCode() {
			return this.GetType().FullName.GetHashCode() ^ Field1.GetHashCode() ^ Arr.GetHashCode() ^ Len.GetHashCode() ^ Field4.GetHashCode();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
		#endregion
	}
}