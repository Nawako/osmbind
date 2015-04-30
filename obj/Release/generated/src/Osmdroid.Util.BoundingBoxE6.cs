using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']"
	[global::Android.Runtime.Register ("org/osmdroid/util/BoundingBoxE6", DoNotGenerateAcw=true)]
	public partial class BoundingBoxE6 : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.IO.ISerializable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLatNorthE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/field[@name='mLatNorthE6']"
		[Register ("mLatNorthE6")]
		protected int MLatNorthE6 {
			get {
				if (mLatNorthE6_jfieldId == IntPtr.Zero)
					mLatNorthE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatNorthE6", "I");
				return JNIEnv.GetIntField (Handle, mLatNorthE6_jfieldId);
			}
			set {
				if (mLatNorthE6_jfieldId == IntPtr.Zero)
					mLatNorthE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatNorthE6", "I");
				JNIEnv.SetField (Handle, mLatNorthE6_jfieldId, value);
			}
		}

		static IntPtr mLatSouthE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/field[@name='mLatSouthE6']"
		[Register ("mLatSouthE6")]
		protected int MLatSouthE6 {
			get {
				if (mLatSouthE6_jfieldId == IntPtr.Zero)
					mLatSouthE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatSouthE6", "I");
				return JNIEnv.GetIntField (Handle, mLatSouthE6_jfieldId);
			}
			set {
				if (mLatSouthE6_jfieldId == IntPtr.Zero)
					mLatSouthE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLatSouthE6", "I");
				JNIEnv.SetField (Handle, mLatSouthE6_jfieldId, value);
			}
		}

		static IntPtr mLonEastE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/field[@name='mLonEastE6']"
		[Register ("mLonEastE6")]
		protected int MLonEastE6 {
			get {
				if (mLonEastE6_jfieldId == IntPtr.Zero)
					mLonEastE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLonEastE6", "I");
				return JNIEnv.GetIntField (Handle, mLonEastE6_jfieldId);
			}
			set {
				if (mLonEastE6_jfieldId == IntPtr.Zero)
					mLonEastE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLonEastE6", "I");
				JNIEnv.SetField (Handle, mLonEastE6_jfieldId, value);
			}
		}

		static IntPtr mLonWestE6_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/field[@name='mLonWestE6']"
		[Register ("mLonWestE6")]
		protected int MLonWestE6 {
			get {
				if (mLonWestE6_jfieldId == IntPtr.Zero)
					mLonWestE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLonWestE6", "I");
				return JNIEnv.GetIntField (Handle, mLonWestE6_jfieldId);
			}
			set {
				if (mLonWestE6_jfieldId == IntPtr.Zero)
					mLonWestE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mLonWestE6", "I");
				JNIEnv.SetField (Handle, mLonWestE6_jfieldId, value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.MapViewConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_DEFAULT']"
			[Register ("ANIMATION_DURATION_DEFAULT")]
			public const int AnimationDurationDefault = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_LONG']"
			[Register ("ANIMATION_DURATION_LONG")]
			public const int AnimationDurationLong = (int) 2000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_SHORT']"
			[Register ("ANIMATION_DURATION_SHORT")]
			public const int AnimationDurationShort = (int) 500;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_DEFAULT']"
			[Register ("ANIMATION_SMOOTHNESS_DEFAULT")]
			public const int AnimationSmoothnessDefault = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_HIGH']"
			[Register ("ANIMATION_SMOOTHNESS_HIGH")]
			public const int AnimationSmoothnessHigh = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_LOW']"
			[Register ("ANIMATION_SMOOTHNESS_LOW")]
			public const int AnimationSmoothnessLow = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MAXIMUM_ZOOMLEVEL']"
			[Register ("MAXIMUM_ZOOMLEVEL")]
			public const int MaximumZoomlevel = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MINIMUM_ZOOMLEVEL']"
			[Register ("MINIMUM_ZOOMLEVEL")]
			public const int MinimumZoomlevel = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/BoundingBoxE6", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BoundingBoxE6); }
		}

		protected BoundingBoxE6 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/constructor[@name='BoundingBoxE6' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public BoundingBoxE6 (int northE6, int eastE6, int southE6, int westE6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BoundingBoxE6)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIII)V", new JValue (northE6), new JValue (eastE6), new JValue (southE6), new JValue (westE6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIII)V", new JValue (northE6), new JValue (eastE6), new JValue (southE6), new JValue (westE6));
				return;
			}

			if (id_ctor_IIII == IntPtr.Zero)
				id_ctor_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(IIII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIII, new JValue (northE6), new JValue (eastE6), new JValue (southE6), new JValue (westE6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIII, new JValue (northE6), new JValue (eastE6), new JValue (southE6), new JValue (westE6));
		}

		static IntPtr id_ctor_DDDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/constructor[@name='BoundingBoxE6' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register (".ctor", "(DDDD)V", "")]
		public BoundingBoxE6 (double north, double east, double south, double west) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BoundingBoxE6)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDDD)V", new JValue (north), new JValue (east), new JValue (south), new JValue (west)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DDDD)V", new JValue (north), new JValue (east), new JValue (south), new JValue (west));
				return;
			}

			if (id_ctor_DDDD == IntPtr.Zero)
				id_ctor_DDDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDDD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDDD, new JValue (north), new JValue (east), new JValue (south), new JValue (west)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DDDD, new JValue (north), new JValue (east), new JValue (south), new JValue (west));
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		static IntPtr id_getCenter;
		public virtual global::Osmdroid.Util.GeoPoint Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lorg/osmdroid/util/GeoPoint;", "GetGetCenterHandler")]
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCenter", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDiagonalLengthInMeters;
#pragma warning disable 0169
		static Delegate GetGetDiagonalLengthInMetersHandler ()
		{
			if (cb_getDiagonalLengthInMeters == null)
				cb_getDiagonalLengthInMeters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDiagonalLengthInMeters);
			return cb_getDiagonalLengthInMeters;
		}

		static int n_GetDiagonalLengthInMeters (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DiagonalLengthInMeters;
		}
#pragma warning restore 0169

		static IntPtr id_getDiagonalLengthInMeters;
		public virtual int DiagonalLengthInMeters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getDiagonalLengthInMeters' and count(parameter)=0]"
			[Register ("getDiagonalLengthInMeters", "()I", "GetGetDiagonalLengthInMetersHandler")]
			get {
				if (id_getDiagonalLengthInMeters == IntPtr.Zero)
					id_getDiagonalLengthInMeters = JNIEnv.GetMethodID (class_ref, "getDiagonalLengthInMeters", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDiagonalLengthInMeters);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDiagonalLengthInMeters", "()I"));
			}
		}

		static Delegate cb_getLatNorthE6;
#pragma warning disable 0169
		static Delegate GetGetLatNorthE6Handler ()
		{
			if (cb_getLatNorthE6 == null)
				cb_getLatNorthE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatNorthE6);
			return cb_getLatNorthE6;
		}

		static int n_GetLatNorthE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatNorthE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLatNorthE6;
		public virtual int LatNorthE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLatNorthE6' and count(parameter)=0]"
			[Register ("getLatNorthE6", "()I", "GetGetLatNorthE6Handler")]
			get {
				if (id_getLatNorthE6 == IntPtr.Zero)
					id_getLatNorthE6 = JNIEnv.GetMethodID (class_ref, "getLatNorthE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatNorthE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatNorthE6", "()I"));
			}
		}

		static Delegate cb_getLatSouthE6;
#pragma warning disable 0169
		static Delegate GetGetLatSouthE6Handler ()
		{
			if (cb_getLatSouthE6 == null)
				cb_getLatSouthE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatSouthE6);
			return cb_getLatSouthE6;
		}

		static int n_GetLatSouthE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatSouthE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLatSouthE6;
		public virtual int LatSouthE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLatSouthE6' and count(parameter)=0]"
			[Register ("getLatSouthE6", "()I", "GetGetLatSouthE6Handler")]
			get {
				if (id_getLatSouthE6 == IntPtr.Zero)
					id_getLatSouthE6 = JNIEnv.GetMethodID (class_ref, "getLatSouthE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatSouthE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatSouthE6", "()I"));
			}
		}

		static Delegate cb_getLatitudeSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanE6Handler ()
		{
			if (cb_getLatitudeSpanE6 == null)
				cb_getLatitudeSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeSpanE6);
			return cb_getLatitudeSpanE6;
		}

		static int n_GetLatitudeSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpanE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeSpanE6;
		public virtual int LatitudeSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLatitudeSpanE6' and count(parameter)=0]"
			[Register ("getLatitudeSpanE6", "()I", "GetGetLatitudeSpanE6Handler")]
			get {
				if (id_getLatitudeSpanE6 == IntPtr.Zero)
					id_getLatitudeSpanE6 = JNIEnv.GetMethodID (class_ref, "getLatitudeSpanE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatitudeSpanE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeSpanE6", "()I"));
			}
		}

		static Delegate cb_getLonEastE6;
#pragma warning disable 0169
		static Delegate GetGetLonEastE6Handler ()
		{
			if (cb_getLonEastE6 == null)
				cb_getLonEastE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLonEastE6);
			return cb_getLonEastE6;
		}

		static int n_GetLonEastE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonEastE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLonEastE6;
		public virtual int LonEastE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLonEastE6' and count(parameter)=0]"
			[Register ("getLonEastE6", "()I", "GetGetLonEastE6Handler")]
			get {
				if (id_getLonEastE6 == IntPtr.Zero)
					id_getLonEastE6 = JNIEnv.GetMethodID (class_ref, "getLonEastE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLonEastE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLonEastE6", "()I"));
			}
		}

		static Delegate cb_getLonWestE6;
#pragma warning disable 0169
		static Delegate GetGetLonWestE6Handler ()
		{
			if (cb_getLonWestE6 == null)
				cb_getLonWestE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLonWestE6);
			return cb_getLonWestE6;
		}

		static int n_GetLonWestE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LonWestE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLonWestE6;
		public virtual int LonWestE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLonWestE6' and count(parameter)=0]"
			[Register ("getLonWestE6", "()I", "GetGetLonWestE6Handler")]
			get {
				if (id_getLonWestE6 == IntPtr.Zero)
					id_getLonWestE6 = JNIEnv.GetMethodID (class_ref, "getLonWestE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLonWestE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLonWestE6", "()I"));
			}
		}

		static Delegate cb_getLongitudeSpanE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanE6Handler ()
		{
			if (cb_getLongitudeSpanE6 == null)
				cb_getLongitudeSpanE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeSpanE6);
			return cb_getLongitudeSpanE6;
		}

		static int n_GetLongitudeSpanE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpanE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeSpanE6;
		public virtual int LongitudeSpanE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getLongitudeSpanE6' and count(parameter)=0]"
			[Register ("getLongitudeSpanE6", "()I", "GetGetLongitudeSpanE6Handler")]
			get {
				if (id_getLongitudeSpanE6 == IntPtr.Zero)
					id_getLongitudeSpanE6 = JNIEnv.GetMethodID (class_ref, "getLongitudeSpanE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLongitudeSpanE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeSpanE6", "()I"));
			}
		}

		static Delegate cb_bringToBoundingBox_II;
#pragma warning disable 0169
		static Delegate GetBringToBoundingBox_IIHandler ()
		{
			if (cb_bringToBoundingBox_II == null)
				cb_bringToBoundingBox_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_BringToBoundingBox_II);
			return cb_bringToBoundingBox_II;
		}

		static IntPtr n_BringToBoundingBox_II (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BringToBoundingBox (aLatitudeE6, aLongitudeE6));
		}
#pragma warning restore 0169

		static IntPtr id_bringToBoundingBox_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='bringToBoundingBox' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("bringToBoundingBox", "(II)Lorg/osmdroid/util/GeoPoint;", "GetBringToBoundingBox_IIHandler")]
		public virtual global::Osmdroid.Util.GeoPoint BringToBoundingBox (int aLatitudeE6, int aLongitudeE6)
		{
			if (id_bringToBoundingBox_II == IntPtr.Zero)
				id_bringToBoundingBox_II = JNIEnv.GetMethodID (class_ref, "bringToBoundingBox", "(II)Lorg/osmdroid/util/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_bringToBoundingBox_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bringToBoundingBox", "(II)Lorg/osmdroid/util/GeoPoint;"), new JValue (aLatitudeE6), new JValue (aLongitudeE6)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_contains_II;
#pragma warning disable 0169
		static Delegate GetContains_IIHandler ()
		{
			if (cb_contains_II == null)
				cb_contains_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_Contains_II);
			return cb_contains_II;
		}

		static bool n_Contains_II (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Contains (aLatitudeE6, aLongitudeE6);
		}
#pragma warning restore 0169

		static IntPtr id_contains_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("contains", "(II)Z", "GetContains_IIHandler")]
		public virtual bool Contains (int aLatitudeE6, int aLongitudeE6)
		{
			if (id_contains_II == IntPtr.Zero)
				id_contains_II = JNIEnv.GetMethodID (class_ref, "contains", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_contains_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(II)Z"), new JValue (aLatitudeE6), new JValue (aLongitudeE6));
		}

		static Delegate cb_contains_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetContains_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_contains_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_contains_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lorg_osmdroid_api_IGeoPoint_);
			return cb_contains_Lorg_osmdroid_api_IGeoPoint_;
		}

		static bool n_Contains_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pGeoPoint)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint pGeoPoint = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_pGeoPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (pGeoPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("contains", "(Lorg/osmdroid/api/IGeoPoint;)Z", "GetContains_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual bool Contains (global::Osmdroid.Api.IGeoPoint pGeoPoint)
		{
			if (id_contains_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_contains_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lorg/osmdroid/api/IGeoPoint;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Lorg_osmdroid_api_IGeoPoint_, new JValue (pGeoPoint));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Lorg/osmdroid/api/IGeoPoint;)Z"), new JValue (pGeoPoint));
			return __ret;
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static IntPtr id_fromGeoPoints_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='fromGeoPoints' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("fromGeoPoints", "(Ljava/util/ArrayList;)Lorg/osmdroid/util/BoundingBoxE6;", "")]
		public static global::Osmdroid.Util.BoundingBoxE6 FromGeoPoints (global::System.Collections.Generic.IList<global::Osmdroid.Util.GeoPoint> p0)
		{
			if (id_fromGeoPoints_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_fromGeoPoints_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "fromGeoPoints", "(Ljava/util/ArrayList;)Lorg/osmdroid/util/BoundingBoxE6;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);
			global::Osmdroid.Util.BoundingBoxE6 __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromGeoPoints_Ljava_util_ArrayList_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF;
#pragma warning disable 0169
		static Delegate GetGetGeoPointOfRelativePositionWithExactGudermannInterpolation_FFHandler ()
		{
			if (cb_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF == null)
				cb_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetGeoPointOfRelativePositionWithExactGudermannInterpolation_FF);
			return cb_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF;
		}

		static IntPtr n_GetGeoPointOfRelativePositionWithExactGudermannInterpolation_FF (IntPtr jnienv, IntPtr native__this, float relX, float relY)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGeoPointOfRelativePositionWithExactGudermannInterpolation (relX, relY));
		}
#pragma warning restore 0169

		static IntPtr id_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getGeoPointOfRelativePositionWithExactGudermannInterpolation' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getGeoPointOfRelativePositionWithExactGudermannInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;", "GetGetGeoPointOfRelativePositionWithExactGudermannInterpolation_FFHandler")]
		public virtual global::Osmdroid.Util.GeoPoint GetGeoPointOfRelativePositionWithExactGudermannInterpolation (float relX, float relY)
		{
			if (id_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF == IntPtr.Zero)
				id_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF = JNIEnv.GetMethodID (class_ref, "getGeoPointOfRelativePositionWithExactGudermannInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getGeoPointOfRelativePositionWithExactGudermannInterpolation_FF, new JValue (relX), new JValue (relY)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoPointOfRelativePositionWithExactGudermannInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;"), new JValue (relX), new JValue (relY)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getGeoPointOfRelativePositionWithLinearInterpolation_FF;
#pragma warning disable 0169
		static Delegate GetGetGeoPointOfRelativePositionWithLinearInterpolation_FFHandler ()
		{
			if (cb_getGeoPointOfRelativePositionWithLinearInterpolation_FF == null)
				cb_getGeoPointOfRelativePositionWithLinearInterpolation_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetGeoPointOfRelativePositionWithLinearInterpolation_FF);
			return cb_getGeoPointOfRelativePositionWithLinearInterpolation_FF;
		}

		static IntPtr n_GetGeoPointOfRelativePositionWithLinearInterpolation_FF (IntPtr jnienv, IntPtr native__this, float relX, float relY)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGeoPointOfRelativePositionWithLinearInterpolation (relX, relY));
		}
#pragma warning restore 0169

		static IntPtr id_getGeoPointOfRelativePositionWithLinearInterpolation_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getGeoPointOfRelativePositionWithLinearInterpolation' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getGeoPointOfRelativePositionWithLinearInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;", "GetGetGeoPointOfRelativePositionWithLinearInterpolation_FFHandler")]
		public virtual global::Osmdroid.Util.GeoPoint GetGeoPointOfRelativePositionWithLinearInterpolation (float relX, float relY)
		{
			if (id_getGeoPointOfRelativePositionWithLinearInterpolation_FF == IntPtr.Zero)
				id_getGeoPointOfRelativePositionWithLinearInterpolation_FF = JNIEnv.GetMethodID (class_ref, "getGeoPointOfRelativePositionWithLinearInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getGeoPointOfRelativePositionWithLinearInterpolation_FF, new JValue (relX), new JValue (relY)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeoPointOfRelativePositionWithLinearInterpolation", "(FF)Lorg/osmdroid/util/GeoPoint;"), new JValue (relX), new JValue (relY)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetGetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_Handler ()
		{
			if (cb_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_ == null)
				cb_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_);
			return cb_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_;
		}

		static IntPtr n_GetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6, IntPtr native_reuse)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation (aLatitudeE6, aLongitudeE6, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.PointF']]"
		[Register ("getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;", "GetGetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_Handler")]
		public virtual global::Android.Graphics.PointF GetRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation (int aLatitudeE6, int aLongitudeE6, global::Android.Graphics.PointF reuse)
		{
			if (id_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_ == IntPtr.Zero)
				id_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;");

			global::Android.Graphics.PointF __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod  (Handle, id_getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation_IILandroid_graphics_PointF_, new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativePositionOfGeoPointInBoundingBoxWithExactGudermannInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;"), new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetGetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_Handler ()
		{
			if (cb_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_ == null)
				cb_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_GetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_);
			return cb_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_;
		}

		static IntPtr n_GetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, int aLatitude, int aLongitude, IntPtr native_reuse)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation (aLatitude, aLongitude, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.PointF']]"
		[Register ("getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;", "GetGetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_Handler")]
		public virtual global::Android.Graphics.PointF GetRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation (int aLatitude, int aLongitude, global::Android.Graphics.PointF reuse)
		{
			if (id_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_ == IntPtr.Zero)
				id_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;");

			global::Android.Graphics.PointF __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod  (Handle, id_getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation_IILandroid_graphics_PointF_, new JValue (aLatitude), new JValue (aLongitude), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelativePositionOfGeoPointInBoundingBoxWithLinearInterpolation", "(IILandroid/graphics/PointF;)Landroid/graphics/PointF;"), new JValue (aLatitude), new JValue (aLongitude), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_increaseByScale_F;
#pragma warning disable 0169
		static Delegate GetIncreaseByScale_FHandler ()
		{
			if (cb_increaseByScale_F == null)
				cb_increaseByScale_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_IncreaseByScale_F);
			return cb_increaseByScale_F;
		}

		static IntPtr n_IncreaseByScale_F (IntPtr jnienv, IntPtr native__this, float pBoundingboxPaddingRelativeScale)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IncreaseByScale (pBoundingboxPaddingRelativeScale));
		}
#pragma warning restore 0169

		static IntPtr id_increaseByScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='increaseByScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("increaseByScale", "(F)Lorg/osmdroid/util/BoundingBoxE6;", "GetIncreaseByScale_FHandler")]
		public virtual global::Osmdroid.Util.BoundingBoxE6 IncreaseByScale (float pBoundingboxPaddingRelativeScale)
		{
			if (id_increaseByScale_F == IntPtr.Zero)
				id_increaseByScale_F = JNIEnv.GetMethodID (class_ref, "increaseByScale", "(F)Lorg/osmdroid/util/BoundingBoxE6;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallObjectMethod  (Handle, id_increaseByScale_F, new JValue (pBoundingboxPaddingRelativeScale)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increaseByScale", "(F)Lorg/osmdroid/util/BoundingBoxE6;"), new JValue (pBoundingboxPaddingRelativeScale)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_arg1)
		{
			global::Osmdroid.Util.BoundingBoxE6 __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags arg1 = (global::Android.OS.ParcelableWriteFlags) native_arg1;
			__this.WriteToParcel (@out, arg1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='BoundingBoxE6']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags arg1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (@out), new JValue ((int) arg1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (@out), new JValue ((int) arg1));
		}

	}
}
