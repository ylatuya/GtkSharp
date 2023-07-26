// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	#region Autogenerated code
	public partial class Date : GLib.Opaque {

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_date_get_type();

		public static GLib.GType GType {
			get {
				IntPtr raw_ret = g_date_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_add_days(IntPtr raw, uint n_days);

		public void AddDays(uint n_days) {
			g_date_add_days(Handle, n_days);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_add_months(IntPtr raw, uint n_months);

		public void AddMonths(uint n_months) {
			g_date_add_months(Handle, n_months);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_add_years(IntPtr raw, uint n_years);

		public void AddYears(uint n_years) {
			g_date_add_years(Handle, n_years);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_clamp(IntPtr raw, IntPtr min_date, IntPtr max_date);

		public void Clamp(GLib.Date min_date, GLib.Date max_date) {
			g_date_clamp(Handle, min_date == null ? IntPtr.Zero : min_date.Handle, max_date == null ? IntPtr.Zero : max_date.Handle);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_clear(IntPtr raw, uint n_dates);

		public void Clear(uint n_dates) {
			g_date_clear(Handle, n_dates);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_date_compare(IntPtr raw, IntPtr rhs);

		public int Compare(GLib.Date rhs) {
			int raw_ret = g_date_compare(Handle, rhs == null ? IntPtr.Zero : rhs.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_date_days_between(IntPtr raw, IntPtr date2);

		public int DaysBetween(GLib.Date date2) {
			int raw_ret = g_date_days_between(Handle, date2 == null ? IntPtr.Zero : date2.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_date_get_day(IntPtr raw);

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_day(IntPtr raw, byte day);

		public byte Day {
			get {
				byte raw_ret = g_date_get_day(Handle);
				byte ret = raw_ret;
				return ret;
			}
			set {
				g_date_set_day(Handle, value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_date_get_day_of_year(IntPtr raw);

		public uint DayOfYear {
			get {
				uint raw_ret = g_date_get_day_of_year(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_date_get_iso8601_week_of_year(IntPtr raw);

		public uint Iso8601WeekOfYear {
			get {
				uint raw_ret = g_date_get_iso8601_week_of_year(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_date_get_julian(IntPtr raw);

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_julian(IntPtr raw, uint julian_date);

		public uint Julian {
			get {
				uint raw_ret = g_date_get_julian(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set {
				g_date_set_julian(Handle, value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_date_get_monday_week_of_year(IntPtr raw);

		public uint MondayWeekOfYear {
			get {
				uint raw_ret = g_date_get_monday_week_of_year(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_date_get_month(IntPtr raw);

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_month(IntPtr raw, int month);

		public int Month {
			get {
				int raw_ret = g_date_get_month(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				g_date_set_month(Handle, value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_date_get_sunday_week_of_year(IntPtr raw);

		public uint SundayWeekOfYear {
			get {
				uint raw_ret = g_date_get_sunday_week_of_year(Handle);
				uint ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern int g_date_get_weekday(IntPtr raw);

		public int Weekday {
			get {
				int raw_ret = g_date_get_weekday(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern ushort g_date_get_year(IntPtr raw);

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_year(IntPtr raw, ushort year);

		public ushort Year {
			get {
				ushort raw_ret = g_date_get_year(Handle);
				ushort ret = raw_ret;
				return ret;
			}
			set {
				g_date_set_year(Handle, value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_is_first_of_month(IntPtr raw);

		public bool IsFirstOfMonth {
			get {
				bool raw_ret = g_date_is_first_of_month(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_is_last_of_month(IntPtr raw);

		public bool IsLastOfMonth {
			get {
				bool raw_ret = g_date_is_last_of_month(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_order(IntPtr raw, IntPtr date2);

		public void Order(GLib.Date date2) {
			g_date_order(Handle, date2 == null ? IntPtr.Zero : date2.Handle);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_dmy(IntPtr raw, byte day, int month, ushort y);

		public void SetDmy(byte day, int month, ushort y) {
			g_date_set_dmy(Handle, day, month, y);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_parse(IntPtr raw, IntPtr str);

		public string Parse {
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup(value);
				g_date_set_parse(Handle, native_value);
				GLib.Marshaller.Free(native_value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_time(IntPtr raw, int time_);

		[Obsolete]
		public int Time {
			set {
				g_date_set_time(Handle, value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_time_t(IntPtr raw, IntPtr timet);

		public long TimeT {
			set {
				g_date_set_time_t(Handle, new IntPtr(value));
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_set_time_val(IntPtr raw, IntPtr value);

		public GLib.TimeVal TimeVal {
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc(value);
				g_date_set_time_val(Handle, native_value);
				value = GLib.TimeVal.New(native_value);
				Marshal.FreeHGlobal(native_value);
			}
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_subtract_days(IntPtr raw, uint n_days);

		public void SubtractDays(uint n_days) {
			g_date_subtract_days(Handle, n_days);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_subtract_months(IntPtr raw, uint n_months);

		public void SubtractMonths(uint n_months) {
			g_date_subtract_months(Handle, n_months);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_subtract_years(IntPtr raw, uint n_years);

		public void SubtractYears(uint n_years) {
			g_date_subtract_years(Handle, n_years);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_to_struct_tm(IntPtr raw, IntPtr tm);

		public void ToStructTm(IntPtr tm) {
			g_date_to_struct_tm(Handle, tm);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid(IntPtr raw);

		public bool Valid() {
			bool raw_ret = g_date_valid(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_date_get_days_in_month(int month, ushort year);

		public static byte GetDaysInMonth(int month, ushort year) {
			byte raw_ret = g_date_get_days_in_month(month, year);
			byte ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_date_get_monday_weeks_in_year(ushort year);

		public static byte GetMondayWeeksInYear(ushort year) {
			byte raw_ret = g_date_get_monday_weeks_in_year(year);
			byte ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern byte g_date_get_sunday_weeks_in_year(ushort year);

		public static byte GetSundayWeeksInYear(ushort year) {
			byte raw_ret = g_date_get_sunday_weeks_in_year(year);
			byte ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_is_leap_year(ushort year);

		public static bool IsLeapYear(ushort year) {
			bool raw_ret = g_date_is_leap_year(year);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr g_date_strftime(IntPtr s, UIntPtr slen, IntPtr format, IntPtr date);

		public static ulong Strftime(string s, string format, GLib.Date date) {
			IntPtr native_s = GLib.Marshaller.StringToPtrGStrdup(s);
			IntPtr native_format = GLib.Marshaller.StringToPtrGStrdup(format);
			UIntPtr raw_ret = g_date_strftime(native_s, new UIntPtr((ulong)System.Text.Encoding.UTF8.GetByteCount(s)), native_format, date == null ? IntPtr.Zero : date.Handle);
			ulong ret = (ulong)raw_ret;
			GLib.Marshaller.Free(native_s);
			GLib.Marshaller.Free(native_format);
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_day(byte day);

		public static bool ValidDay(byte day) {
			bool raw_ret = g_date_valid_day(day);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_dmy(byte day, int month, ushort year);

		public static bool ValidDmy(byte day, int month, ushort year) {
			bool raw_ret = g_date_valid_dmy(day, month, year);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_julian(uint julian_date);

		public static bool ValidJulian(uint julian_date) {
			bool raw_ret = g_date_valid_julian(julian_date);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_month(int month);

		public static bool ValidMonth(int month) {
			bool raw_ret = g_date_valid_month(month);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_weekday(int weekday);

		public static bool ValidWeekday(int weekday) {
			bool raw_ret = g_date_valid_weekday(weekday);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_date_valid_year(ushort year);

		public static bool ValidYear(ushort year) {
			bool raw_ret = g_date_valid_year(year);
			bool ret = raw_ret;
			return ret;
		}

		public Date(IntPtr raw) : base(raw) { }

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_date_new();

		public Date() {
			Raw = g_date_new();
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_date_new_dmy(byte day, int month, ushort year);

		public Date(byte day, int month, ushort year) {
			Raw = g_date_new_dmy(day, month, year);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_date_new_julian(uint julian_day);

		public Date(uint julian_day) {
			Raw = g_date_new_julian(julian_day);
		}

		[DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
		static extern void g_date_free(IntPtr raw);

		protected override void Free(IntPtr raw) {
			g_date_free(raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo(IntPtr handle) {
				this.handle = handle;
			}

			public bool Handler() {
				g_date_free(handle);
				return false;
			}
		}

		~Date() {
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo(Handle);
			GLib.Timeout.Add(50, new GLib.TimeoutHandler(info.Handler));
		}

		#endregion
	}
}