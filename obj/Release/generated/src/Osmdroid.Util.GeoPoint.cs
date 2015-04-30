using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']"
	[global::Android.Runtime.Register ("org/osmdroid/util/GeoPoint", DoNotGenerateAcw=true)]
	public partial class GeoPoint : global::Java.Lang.Object, global::Android.OS.IParcelable, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Osmdroid.Api.IGeoPoint {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/field[@name='CREATOR']"
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

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.util.constants.GeoConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='EQUATORCIRCUMFENCE']"
			[Register ("EQUATORCIRCUMFENCE")]
			public const int Equatorcircumfence = (int) 40075016;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='FEET_PER_METER']"
			[Register ("FEET_PER_METER")]
			public const double FeetPerMeter = (double) 3.280839900000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_NAUTICAL_MILE']"
			[Register ("METERS_PER_NAUTICAL_MILE")]
			public const double MetersPerNauticalMile = (double) 1852.000000000000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_STATUTE_MILE']"
			[Register ("METERS_PER_STATUTE_MILE")]
			public const double MetersPerStatuteMile = (double) 1609.344000000000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='RADIUS_EARTH_METERS']"
			[Register ("RADIUS_EARTH_METERS")]
			public const int RadiusEarthMeters = (int) 6378137;

			// The following are fields from: org.osmdroid.views.util.constants.MathConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='DEG2RAD']"
			[Register ("DEG2RAD")]
			public const float Deg2rad = (float) 0.017453;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI']"
			[Register ("PI")]
			public const float Pi = (float) 3.141593;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_2']"
			[Register ("PI_2")]
			public const float Pi2 = (float) 1.570796;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_4']"
			[Register ("PI_4")]
			public const float Pi4 = (float) 0.785398;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='RAD2DEG']"
			[Register ("RAD2DEG")]
			public const float Rad2deg = (float) 57.295780;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/GeoPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoPoint); }
		}

		protected GeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register (".ctor", "(Lorg/osmdroid/util/GeoPoint;)V", "")]
		public GeoPoint (global::Osmdroid.Util.GeoPoint aGeopoint) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/util/GeoPoint;)V", new JValue (aGeopoint)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/util/GeoPoint;)V", new JValue (aGeopoint));
				return;
			}

			if (id_ctor_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/util/GeoPoint;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_util_GeoPoint_, new JValue (aGeopoint)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_util_GeoPoint_, new JValue (aGeopoint));
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public GeoPoint (int aLatitudeE6, int aLongitudeE6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (aLatitudeE6), new JValue (aLongitudeE6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (aLatitudeE6), new JValue (aLongitudeE6));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6));
		}

		static IntPtr id_ctor_DDD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register (".ctor", "(DDD)V", "")]
		public GeoPoint (double aLatitude, double aLongitude, double aAltitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DDD)V", new JValue (aLatitude), new JValue (aLongitude), new JValue (aAltitude)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DDD)V", new JValue (aLatitude), new JValue (aLongitude), new JValue (aAltitude));
				return;
			}

			if (id_ctor_DDD == IntPtr.Zero)
				id_ctor_DDD = JNIEnv.GetMethodID (class_ref, "<init>", "(DDD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DDD, new JValue (aLatitude), new JValue (aLongitude), new JValue (aAltitude)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DDD, new JValue (aLatitude), new JValue (aLongitude), new JValue (aAltitude));
		}

		static IntPtr id_ctor_Landroid_location_Location_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register (".ctor", "(Landroid/location/Location;)V", "")]
		public GeoPoint (global::Android.Locations.Location aLocation) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/location/Location;)V", new JValue (aLocation)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/location/Location;)V", new JValue (aLocation));
				return;
			}

			if (id_ctor_Landroid_location_Location_ == IntPtr.Zero)
				id_ctor_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/location/Location;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_location_Location_, new JValue (aLocation)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_location_Location_, new JValue (aLocation));
		}

		static IntPtr id_ctor_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public GeoPoint (int aLatitudeE6, int aLongitudeE6, int aAltitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(III)V", new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAltitude)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(III)V", new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAltitude));
				return;
			}

			if (id_ctor_III == IntPtr.Zero)
				id_ctor_III = JNIEnv.GetMethodID (class_ref, "<init>", "(III)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_III, new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAltitude)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_III, new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAltitude));
		}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/constructor[@name='GeoPoint' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public GeoPoint (double aLatitude, double aLongitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (aLatitude), new JValue (aLongitude)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (aLatitude), new JValue (aLongitude));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude));
		}

		static Delegate cb_getAltitude;
#pragma warning disable 0169
		static Delegate GetGetAltitudeHandler ()
		{
			if (cb_getAltitude == null)
				cb_getAltitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAltitude);
			return cb_getAltitude;
		}

		static int n_GetAltitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Altitude;
		}
#pragma warning restore 0169

		static Delegate cb_setAltitude_I;
#pragma warning disable 0169
		static Delegate GetSetAltitude_IHandler ()
		{
			if (cb_setAltitude_I == null)
				cb_setAltitude_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAltitude_I);
			return cb_setAltitude_I;
		}

		static void n_SetAltitude_I (IntPtr jnienv, IntPtr native__this, int aAltitude)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Altitude = aAltitude;
		}
#pragma warning restore 0169

		static IntPtr id_getAltitude;
		static IntPtr id_setAltitude_I;
		public virtual int Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()I", "GetGetAltitudeHandler")]
			get {
				if (id_getAltitude == IntPtr.Zero)
					id_getAltitude = JNIEnv.GetMethodID (class_ref, "getAltitude", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getAltitude);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAltitude", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='setAltitude' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAltitude", "(I)V", "GetSetAltitude_IHandler")]
			set {
				if (id_setAltitude_I == IntPtr.Zero)
					id_setAltitude_I = JNIEnv.GetMethodID (class_ref, "setAltitude", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAltitude_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAltitude", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		public virtual double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitude", "()D"));
			}
		}

		static Delegate cb_getLatitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeE6Handler ()
		{
			if (cb_getLatitudeE6 == null)
				cb_getLatitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeE6);
			return cb_getLatitudeE6;
		}

		static int n_GetLatitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitudeE6_I;
#pragma warning disable 0169
		static Delegate GetSetLatitudeE6_IHandler ()
		{
			if (cb_setLatitudeE6_I == null)
				cb_setLatitudeE6_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLatitudeE6_I);
			return cb_setLatitudeE6_I;
		}

		static void n_SetLatitudeE6_I (IntPtr jnienv, IntPtr native__this, int aLatitudeE6)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LatitudeE6 = aLatitudeE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeE6;
		static IntPtr id_setLatitudeE6_I;
		public virtual int LatitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='getLatitudeE6' and count(parameter)=0]"
			[Register ("getLatitudeE6", "()I", "GetGetLatitudeE6Handler")]
			get {
				if (id_getLatitudeE6 == IntPtr.Zero)
					id_getLatitudeE6 = JNIEnv.GetMethodID (class_ref, "getLatitudeE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatitudeE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeE6", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='setLatitudeE6' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLatitudeE6", "(I)V", "GetSetLatitudeE6_IHandler")]
			set {
				if (id_setLatitudeE6_I == IntPtr.Zero)
					id_setLatitudeE6_I = JNIEnv.GetMethodID (class_ref, "setLatitudeE6", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLatitudeE6_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatitudeE6", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		public virtual double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitude", "()D"));
			}
		}

		static Delegate cb_getLongitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeE6Handler ()
		{
			if (cb_getLongitudeE6 == null)
				cb_getLongitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeE6);
			return cb_getLongitudeE6;
		}

		static int n_GetLongitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeE6;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitudeE6_I;
#pragma warning disable 0169
		static Delegate GetSetLongitudeE6_IHandler ()
		{
			if (cb_setLongitudeE6_I == null)
				cb_setLongitudeE6_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLongitudeE6_I);
			return cb_setLongitudeE6_I;
		}

		static void n_SetLongitudeE6_I (IntPtr jnienv, IntPtr native__this, int aLongitudeE6)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LongitudeE6 = aLongitudeE6;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeE6;
		static IntPtr id_setLongitudeE6_I;
		public virtual int LongitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='getLongitudeE6' and count(parameter)=0]"
			[Register ("getLongitudeE6", "()I", "GetGetLongitudeE6Handler")]
			get {
				if (id_getLongitudeE6 == IntPtr.Zero)
					id_getLongitudeE6 = JNIEnv.GetMethodID (class_ref, "getLongitudeE6", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLongitudeE6);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeE6", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='setLongitudeE6' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLongitudeE6", "(I)V", "GetSetLongitudeE6_IHandler")]
			set {
				if (id_setLongitudeE6_I == IntPtr.Zero)
					id_setLongitudeE6_I = JNIEnv.GetMethodID (class_ref, "setLongitudeE6", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLongitudeE6_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongitudeE6", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_bearingTo_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetBearingTo_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_bearingTo_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_bearingTo_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, double>) n_BearingTo_Lorg_osmdroid_api_IGeoPoint_);
			return cb_bearingTo_Lorg_osmdroid_api_IGeoPoint_;
		}

		static double n_BearingTo_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint other = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_other, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.BearingTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bearingTo_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='bearingTo' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("bearingTo", "(Lorg/osmdroid/api/IGeoPoint;)D", "GetBearingTo_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual double BearingTo (global::Osmdroid.Api.IGeoPoint other)
		{
			if (id_bearingTo_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_bearingTo_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "bearingTo", "(Lorg/osmdroid/api/IGeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_bearingTo_Lorg_osmdroid_api_IGeoPoint_, new JValue (other));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bearingTo", "(Lorg/osmdroid/api/IGeoPoint;)D"), new JValue (other));
			return __ret;
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		static IntPtr id_clone;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lorg/osmdroid/util/GeoPoint;", "GetCloneHandler")]
		public virtual global::Osmdroid.Util.GeoPoint Clone ()
		{
			if (id_clone == IntPtr.Zero)
				id_clone = JNIEnv.GetMethodID (class_ref, "clone", "()Lorg/osmdroid/util/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_clone), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clone", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_destinationPoint_DF;
#pragma warning disable 0169
		static Delegate GetDestinationPoint_DFHandler ()
		{
			if (cb_destinationPoint_DF == null)
				cb_destinationPoint_DF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, float, IntPtr>) n_DestinationPoint_DF);
			return cb_destinationPoint_DF;
		}

		static IntPtr n_DestinationPoint_DF (IntPtr jnienv, IntPtr native__this, double aDistanceInMeters, float aBearingInDegrees)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DestinationPoint (aDistanceInMeters, aBearingInDegrees));
		}
#pragma warning restore 0169

		static IntPtr id_destinationPoint_DF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='destinationPoint' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='float']]"
		[Register ("destinationPoint", "(DF)Lorg/osmdroid/util/GeoPoint;", "GetDestinationPoint_DFHandler")]
		public virtual global::Osmdroid.Util.GeoPoint DestinationPoint (double aDistanceInMeters, float aBearingInDegrees)
		{
			if (id_destinationPoint_DF == IntPtr.Zero)
				id_destinationPoint_DF = JNIEnv.GetMethodID (class_ref, "destinationPoint", "(DF)Lorg/osmdroid/util/GeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_destinationPoint_DF, new JValue (aDistanceInMeters), new JValue (aBearingInDegrees)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destinationPoint", "(DF)Lorg/osmdroid/util/GeoPoint;"), new JValue (aDistanceInMeters), new JValue (aBearingInDegrees)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_distanceTo_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceTo_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_distanceTo_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_distanceTo_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DistanceTo_Lorg_osmdroid_api_IGeoPoint_);
			return cb_distanceTo_Lorg_osmdroid_api_IGeoPoint_;
		}

		static int n_DistanceTo_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint other = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_other, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DistanceTo (other);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceTo_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='distanceTo' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("distanceTo", "(Lorg/osmdroid/api/IGeoPoint;)I", "GetDistanceTo_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual int DistanceTo (global::Osmdroid.Api.IGeoPoint other)
		{
			if (id_distanceTo_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_distanceTo_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceTo", "(Lorg/osmdroid/api/IGeoPoint;)I");

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_distanceTo_Lorg_osmdroid_api_IGeoPoint_, new JValue (other));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceTo", "(Lorg/osmdroid/api/IGeoPoint;)I"), new JValue (other));
			return __ret;
		}

		static IntPtr id_fromCenterBetween_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='fromCenterBetween' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("fromCenterBetween", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Osmdroid.Util.GeoPoint FromCenterBetween (global::Osmdroid.Util.GeoPoint geoPointA, global::Osmdroid.Util.GeoPoint geoPointB)
		{
			if (id_fromCenterBetween_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_fromCenterBetween_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetStaticMethodID (class_ref, "fromCenterBetween", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/util/GeoPoint;");
			global::Osmdroid.Util.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromCenterBetween_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_, new JValue (geoPointA), new JValue (geoPointB)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_fromDoubleString_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='fromDoubleString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("fromDoubleString", "(Ljava/lang/String;C)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Osmdroid.Util.GeoPoint FromDoubleString (string s, char spacer)
		{
			if (id_fromDoubleString_Ljava_lang_String_C == IntPtr.Zero)
				id_fromDoubleString_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "fromDoubleString", "(Ljava/lang/String;C)Lorg/osmdroid/util/GeoPoint;");
			IntPtr native_s = JNIEnv.NewString (s);
			global::Osmdroid.Util.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromDoubleString_Ljava_lang_String_C, new JValue (native_s), new JValue (spacer)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_s);
			return __ret;
		}

		static IntPtr id_fromIntString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='fromIntString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromIntString", "(Ljava/lang/String;)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Osmdroid.Util.GeoPoint FromIntString (string s)
		{
			if (id_fromIntString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromIntString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromIntString", "(Ljava/lang/String;)Lorg/osmdroid/util/GeoPoint;");
			IntPtr native_s = JNIEnv.NewString (s);
			global::Osmdroid.Util.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromIntString_Ljava_lang_String_, new JValue (native_s)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_s);
			return __ret;
		}

		static IntPtr id_fromInvertedDoubleString_Ljava_lang_String_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='fromInvertedDoubleString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='char']]"
		[Register ("fromInvertedDoubleString", "(Ljava/lang/String;C)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Osmdroid.Util.GeoPoint FromInvertedDoubleString (string s, char spacer)
		{
			if (id_fromInvertedDoubleString_Ljava_lang_String_C == IntPtr.Zero)
				id_fromInvertedDoubleString_Ljava_lang_String_C = JNIEnv.GetStaticMethodID (class_ref, "fromInvertedDoubleString", "(Ljava/lang/String;C)Lorg/osmdroid/util/GeoPoint;");
			IntPtr native_s = JNIEnv.NewString (s);
			global::Osmdroid.Util.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInvertedDoubleString_Ljava_lang_String_C, new JValue (native_s), new JValue (spacer)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_s);
			return __ret;
		}

		static Delegate cb_setCoordsE6_II;
#pragma warning disable 0169
		static Delegate GetSetCoordsE6_IIHandler ()
		{
			if (cb_setCoordsE6_II == null)
				cb_setCoordsE6_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetCoordsE6_II);
			return cb_setCoordsE6_II;
		}

		static void n_SetCoordsE6_II (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCoordsE6 (aLatitudeE6, aLongitudeE6);
		}
#pragma warning restore 0169

		static IntPtr id_setCoordsE6_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='setCoordsE6' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCoordsE6", "(II)V", "GetSetCoordsE6_IIHandler")]
		public virtual void SetCoordsE6 (int aLatitudeE6, int aLongitudeE6)
		{
			if (id_setCoordsE6_II == IntPtr.Zero)
				id_setCoordsE6_II = JNIEnv.GetMethodID (class_ref, "setCoordsE6", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCoordsE6_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCoordsE6", "(II)V"), new JValue (aLatitudeE6), new JValue (aLongitudeE6));
		}

		static Delegate cb_toDoubleString;
#pragma warning disable 0169
		static Delegate GetToDoubleStringHandler ()
		{
			if (cb_toDoubleString == null)
				cb_toDoubleString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToDoubleString);
			return cb_toDoubleString;
		}

		static IntPtr n_ToDoubleString (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToDoubleString ());
		}
#pragma warning restore 0169

		static IntPtr id_toDoubleString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='toDoubleString' and count(parameter)=0]"
		[Register ("toDoubleString", "()Ljava/lang/String;", "GetToDoubleStringHandler")]
		public virtual string ToDoubleString ()
		{
			if (id_toDoubleString == IntPtr.Zero)
				id_toDoubleString = JNIEnv.GetMethodID (class_ref, "toDoubleString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toDoubleString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toDoubleString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_toInvertedDoubleString;
#pragma warning disable 0169
		static Delegate GetToInvertedDoubleStringHandler ()
		{
			if (cb_toInvertedDoubleString == null)
				cb_toInvertedDoubleString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToInvertedDoubleString);
			return cb_toInvertedDoubleString;
		}

		static IntPtr n_ToInvertedDoubleString (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToInvertedDoubleString ());
		}
#pragma warning restore 0169

		static IntPtr id_toInvertedDoubleString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='toInvertedDoubleString' and count(parameter)=0]"
		[Register ("toInvertedDoubleString", "()Ljava/lang/String;", "GetToInvertedDoubleStringHandler")]
		public virtual string ToInvertedDoubleString ()
		{
			if (id_toInvertedDoubleString == IntPtr.Zero)
				id_toInvertedDoubleString = JNIEnv.GetMethodID (class_ref, "toInvertedDoubleString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toInvertedDoubleString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toInvertedDoubleString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			global::Osmdroid.Util.GeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @out = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__out, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (@out, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeoPoint']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel @out, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (@out), new JValue ((int) flags));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (@out), new JValue ((int) flags));
		}

	}
}
