// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class AnnotationObject {

		public AnnotationObject (IntPtr raw) : base(raw) {}

		protected AnnotationObject() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("function-property")]
		public Regress.AnnotationCallback FunctionProperty {
			get {
				GLib.Value val = GetProperty ("function-property");
				Regress.AnnotationCallback ret = (Regress.AnnotationCallback) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("function-property", val);
				val.Dispose ();
			}
		}

		[Obsolete]
		[GLib.Property ("string-property")]
		public string StringProperty {
			get {
				GLib.Value val = GetProperty ("string-property");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("string-property", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("tab-property")]
		public string TabProperty {
			get {
				GLib.Value val = GetProperty ("tab-property");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("tab-property", val);
				val.Dispose ();
			}
		}

		[GLib.Signal("list-signal")]
		public event Regress.ListSignalHandler ListSignal {
			add {
				this.AddSignalHandler ("list-signal", value, typeof (Regress.ListSignalArgs));
			}
			remove {
				this.RemoveSignalHandler ("list-signal", value);
			}
		}

		[GLib.Signal("string-signal")]
		public event Regress.StringSignalHandler StringSignal {
			add {
				this.AddSignalHandler ("string-signal", value, typeof (Regress.StringSignalArgs));
			}
			remove {
				this.RemoveSignalHandler ("string-signal", value);
			}
		}

		[GLib.Signal("doc-empty-arg-parsing")]
		public event Regress.DocEmptyArgParsingHandler DocEmptyArgParsing {
			add {
				this.AddSignalHandler ("doc-empty-arg-parsing", value, typeof (Regress.DocEmptyArgParsingArgs));
			}
			remove {
				this.RemoveSignalHandler ("doc-empty-arg-parsing", value);
			}
		}

		[GLib.Signal("attribute-signal")]
		public event Regress.AttributeSignalHandler AttributeSignal {
			add {
				this.AddSignalHandler ("attribute-signal", value, typeof (Regress.AttributeSignalArgs));
			}
			remove {
				this.RemoveSignalHandler ("attribute-signal", value);
			}
		}

		static AttributeSignalNativeDelegate AttributeSignal_cb_delegate;
		static AttributeSignalNativeDelegate AttributeSignalVMCallback {
			get {
				if (AttributeSignal_cb_delegate == null)
					AttributeSignal_cb_delegate = new AttributeSignalNativeDelegate (AttributeSignal_cb);
				return AttributeSignal_cb_delegate;
			}
		}

		static void OverrideAttributeSignal (GLib.GType gtype)
		{
			OverrideAttributeSignal (gtype, AttributeSignalVMCallback);
		}

		static void OverrideAttributeSignal (GLib.GType gtype, AttributeSignalNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "attribute-signal", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr AttributeSignalNativeDelegate (IntPtr inst, IntPtr arg1, IntPtr arg2);

		static IntPtr AttributeSignal_cb (IntPtr inst, IntPtr arg1, IntPtr arg2)
		{
			try {
				AnnotationObject __obj = GLib.Object.GetObject (inst, false) as AnnotationObject;
				string __result;
				__result = __obj.OnAttributeSignal (GLib.Marshaller.Utf8PtrToString (arg1), GLib.Marshaller.Utf8PtrToString (arg2));
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.AnnotationObject), ConnectionMethod="OverrideAttributeSignal")]
		protected virtual string OnAttributeSignal (string arg1, string arg2)
		{
			return InternalAttributeSignal (arg1, arg2);
		}

		private string InternalAttributeSignal (string arg1, string arg2)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.String);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (arg1);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (arg2);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			string result = (string) ret;
			ret.Dispose ();
			return result;
		}

		static DocEmptyArgParsingNativeDelegate DocEmptyArgParsing_cb_delegate;
		static DocEmptyArgParsingNativeDelegate DocEmptyArgParsingVMCallback {
			get {
				if (DocEmptyArgParsing_cb_delegate == null)
					DocEmptyArgParsing_cb_delegate = new DocEmptyArgParsingNativeDelegate (DocEmptyArgParsing_cb);
				return DocEmptyArgParsing_cb_delegate;
			}
		}

		static void OverrideDocEmptyArgParsing (GLib.GType gtype)
		{
			OverrideDocEmptyArgParsing (gtype, DocEmptyArgParsingVMCallback);
		}

		static void OverrideDocEmptyArgParsing (GLib.GType gtype, DocEmptyArgParsingNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "doc-empty-arg-parsing", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DocEmptyArgParsingNativeDelegate (IntPtr inst, IntPtr arg1);

		static void DocEmptyArgParsing_cb (IntPtr inst, IntPtr arg1)
		{
			try {
				AnnotationObject __obj = GLib.Object.GetObject (inst, false) as AnnotationObject;
				__obj.OnDocEmptyArgParsing (arg1);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.AnnotationObject), ConnectionMethod="OverrideDocEmptyArgParsing")]
		protected virtual void OnDocEmptyArgParsing (IntPtr arg1)
		{
			InternalDocEmptyArgParsing (arg1);
		}

		private void InternalDocEmptyArgParsing (IntPtr arg1)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (arg1);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static ListSignalNativeDelegate ListSignal_cb_delegate;
		static ListSignalNativeDelegate ListSignalVMCallback {
			get {
				if (ListSignal_cb_delegate == null)
					ListSignal_cb_delegate = new ListSignalNativeDelegate (ListSignal_cb);
				return ListSignal_cb_delegate;
			}
		}

		static void OverrideListSignal (GLib.GType gtype)
		{
			OverrideListSignal (gtype, ListSignalVMCallback);
		}

		static void OverrideListSignal (GLib.GType gtype, ListSignalNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "list-signal", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ListSignalNativeDelegate (IntPtr inst, IntPtr list);

		static void ListSignal_cb (IntPtr inst, IntPtr list)
		{
			try {
				AnnotationObject __obj = GLib.Object.GetObject (inst, false) as AnnotationObject;
				__obj.OnListSignal (list);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.AnnotationObject), ConnectionMethod="OverrideListSignal")]
		protected virtual void OnListSignal (IntPtr list)
		{
			InternalListSignal (list);
		}

		private void InternalListSignal (IntPtr list)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (list);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static StringSignalNativeDelegate StringSignal_cb_delegate;
		static StringSignalNativeDelegate StringSignalVMCallback {
			get {
				if (StringSignal_cb_delegate == null)
					StringSignal_cb_delegate = new StringSignalNativeDelegate (StringSignal_cb);
				return StringSignal_cb_delegate;
			}
		}

		static void OverrideStringSignal (GLib.GType gtype)
		{
			OverrideStringSignal (gtype, StringSignalVMCallback);
		}

		static void OverrideStringSignal (GLib.GType gtype, StringSignalNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "string-signal", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StringSignalNativeDelegate (IntPtr inst, IntPtr str1ng);

		static void StringSignal_cb (IntPtr inst, IntPtr str1ng)
		{
			try {
				AnnotationObject __obj = GLib.Object.GetObject (inst, false) as AnnotationObject;
				__obj.OnStringSignal (GLib.Marshaller.Utf8PtrToString (str1ng));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Regress.AnnotationObject), ConnectionMethod="OverrideStringSignal")]
		protected virtual void OnStringSignal (string str1ng)
		{
			InternalStringSignal (str1ng);
		}

		private void InternalStringSignal (string str1ng)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (str1ng);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_annotation_object_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = regress_annotation_object_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_compute_sum(IntPtr raw, int[] nums);

		public void ComputeSum(int[] nums) {
			regress_annotation_object_compute_sum(Handle, nums);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_compute_sum_n(IntPtr raw, int[] nums, int n_nums);

		public void ComputeSumN(int[] nums) {
			regress_annotation_object_compute_sum_n(Handle, nums, (nums == null ? 0 : nums.Length));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_compute_sum_nz(IntPtr raw, int[] nums, int n_nums);

		public void ComputeSumNz(int[] nums) {
			regress_annotation_object_compute_sum_nz(Handle, nums, (nums == null ? 0 : nums.Length));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_extra_annos(IntPtr raw);

		public void ExtraAnnos() {
			regress_annotation_object_extra_annos(Handle);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_foreach(IntPtr raw, RegressSharp.AnnotationForeachFuncNative func, IntPtr user_data);

		public void Foreach(Regress.AnnotationForeachFunc func) {
			RegressSharp.AnnotationForeachFuncWrapper func_wrapper = new RegressSharp.AnnotationForeachFuncWrapper (func);
			regress_annotation_object_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern System.IntPtr regress_annotation_object_get_hash(IntPtr raw);

		public string[] Hash { 
			get {
				System.IntPtr raw_ret = regress_annotation_object_get_hash(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(System.IntPtr), true, true, typeof(string));
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_annotation_object_get_objects(IntPtr raw);

		public Regress.AnnotationObject[] Objects { 
			get {
				IntPtr raw_ret = regress_annotation_object_get_objects(Handle);
				Regress.AnnotationObject[] ret = (Regress.AnnotationObject[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.SList), false, true, typeof(Regress.AnnotationObject));
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_annotation_object_get_strings(IntPtr raw);

		public string[] Strings { 
			get {
				IntPtr raw_ret = regress_annotation_object_get_strings(Handle);
				string[] ret = (string[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, true, typeof(string));
				return ret;
			}
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_hidden_self(IntPtr raw);

		public void HiddenSelf() {
			regress_annotation_object_hidden_self(Handle);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_in(IntPtr raw, int inarg);

		public int In(int inarg) {
			int raw_ret = regress_annotation_object_in(Handle, inarg);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_inout(IntPtr raw, ref int inoutarg);

		public int Inout(ref int inoutarg) {
			int raw_ret = regress_annotation_object_inout(Handle, ref inoutarg);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_inout2(IntPtr raw, ref int inoutarg);

		public int Inout2(ref int inoutarg) {
			int raw_ret = regress_annotation_object_inout2(Handle, ref inoutarg);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_inout3(IntPtr raw, ref int inoutarg);

		public int Inout3(ref int inoutarg) {
			int raw_ret = regress_annotation_object_inout3(Handle, ref inoutarg);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_method(IntPtr raw);

		public int Method() {
			int raw_ret = regress_annotation_object_method(Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern int regress_annotation_object_out(IntPtr raw, out int outarg);

		public int Out(out int outarg) {
			int raw_ret = regress_annotation_object_out(Handle, out outarg);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_parse_args(IntPtr raw, ref int argc, ref IntPtr[] argv);

		public void ParseArgs(ref int argc, ref string[] argv) {
			int cnt_argv = argv == null ? 0 : argv.Length;
			IntPtr[] native_argv = new IntPtr [cnt_argv];
			for (int i = 0; i < cnt_argv; i++)
				native_argv [i] = GLib.Marshaller.StringToPtrGStrdup(argv[i]);
			regress_annotation_object_parse_args(Handle, ref argc, native_argv);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_set_data(IntPtr raw, byte[] data, UIntPtr length);

		public void SetData(byte[] data, ulong length) {
			regress_annotation_object_set_data(Handle, data, new UIntPtr (length));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_set_data2(IntPtr raw, IntPtr[] data, UIntPtr length);

		public void SetData2(string[] data, ulong length) {
			int cnt_data = data == null ? 0 : data.Length;
			IntPtr[] native_data = new IntPtr [cnt_data];
			for (int i = 0; i < cnt_data; i++)
				native_data [i] = GLib.Marshaller.StringToPtrGStrdup(data[i]);
			regress_annotation_object_set_data2(Handle, native_data, new UIntPtr (length));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_set_data3(IntPtr raw, IntPtr[] data, UIntPtr length);

		public void SetData3(IntPtr[] data, ulong length) {
			regress_annotation_object_set_data3(Handle, data, new UIntPtr (length));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern bool regress_annotation_object_string_out(IntPtr raw, out IntPtr str_out);

		public bool StringOut(out string str_out) {
			IntPtr native_str_out;
			bool raw_ret = regress_annotation_object_string_out(Handle, out native_str_out);
			bool ret = raw_ret;
			str_out = GLib.Marshaller.PtrToStringGFree(native_str_out);
			return ret;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_use_buffer(IntPtr raw, byte bytes);

		public void UseBuffer(byte bytes) {
			regress_annotation_object_use_buffer(Handle, bytes);
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern void regress_annotation_object_with_voidp(IntPtr raw, IntPtr data);

		public void WithVoidp(IntPtr data) {
			regress_annotation_object_with_voidp(Handle, data);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
