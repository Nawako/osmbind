using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/util/RecordedGeoPoint", DoNotGenerateAcw=true)]
	public partial class RecordedGeoPoint : global::Org.Osmdroid.Util.GeoPoint {


		static IntPtr mNumSatellites_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/field[@name='mNumSatellites']"
		[Register ("mNumSatellites")]
		protected int MNumSatellites {
			get {
				if (mNumSatellites_jfieldId == IntPtr.Zero)
					mNumSatellites_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumSatellites", "I");
				return JNIEnv.GetIntField (Handle, mNumSatellites_jfieldId);
			}
			set {
				if (mNumSatellites_jfieldId == IntPtr.Zero)
					mNumSatellites_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumSatellites", "I");
				JNIEnv.SetField (Handle, mNumSatellites_jfieldId, value);
			}
		}

		static IntPtr mTimeStamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/field[@name='mTimeStamp']"
		[Register ("mTimeStamp")]
		protected long MTimeStamp {
			get {
				if (mTimeStamp_jfieldId == IntPtr.Zero)
					mTimeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimeStamp", "J");
				return JNIEnv.GetLongField (Handle, mTimeStamp_jfieldId);
			}
			set {
				if (mTimeStamp_jfieldId == IntPtr.Zero)
					mTimeStamp_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimeStamp", "J");
				JNIEnv.SetField (Handle, mTimeStamp_jfieldId, value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.contributor.util.constants.OpenStreetMapContributorConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='MINDIAGONALMETERS_FOR_OSM_CONTRIBUTION']"
			[Register ("MINDIAGONALMETERS_FOR_OSM_CONTRIBUTION")]
			public const int MindiagonalmetersForOsmContribution = (int) 300;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='MINGEOPOINTS_FOR_OSM_CONTRIBUTION']"
			[Register ("MINGEOPOINTS_FOR_OSM_CONTRIBUTION")]
			public const int MingeopointsForOsmContribution = (int) 100;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_CREATOR_INFO']"
			[Register ("OSM_CREATOR_INFO")]
			public const string OsmCreatorInfo = (string) "AndNav - http://www.andnav.org - Android Navigation System";

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_PASSWORD']"
			[Register ("OSM_PASSWORD")]
			public const string OsmPassword = (string) "PUT_YOUR_PASSWORD_HERE";

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_USERNAME']"
			[Register ("OSM_USERNAME")]
			public const string OsmUsername = (string) "PUT_YOUR_USERNAME_HERE";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/contributor/util/RecordedGeoPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecordedGeoPoint); }
		}

		protected RecordedGeoPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIJI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/constructor[@name='RecordedGeoPoint' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIJI)V", "")]
		public RecordedGeoPoint (int latitudeE6, int longitudeE6, long aTimeStamp, int aNumSatellites) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RecordedGeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJI)V", new JValue (latitudeE6), new JValue (longitudeE6), new JValue (aTimeStamp), new JValue (aNumSatellites)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJI)V", new JValue (latitudeE6), new JValue (longitudeE6), new JValue (aTimeStamp), new JValue (aNumSatellites));
				return;
			}

			if (id_ctor_IIJI == IntPtr.Zero)
				id_ctor_IIJI = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJI, new JValue (latitudeE6), new JValue (longitudeE6), new JValue (aTimeStamp), new JValue (aNumSatellites)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJI, new JValue (latitudeE6), new JValue (longitudeE6), new JValue (aTimeStamp), new JValue (aNumSatellites));
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/constructor[@name='RecordedGeoPoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public RecordedGeoPoint (int latitudeE6, int longitudeE6) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RecordedGeoPoint)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (latitudeE6), new JValue (longitudeE6)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (latitudeE6), new JValue (longitudeE6));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (latitudeE6), new JValue (longitudeE6)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (latitudeE6), new JValue (longitudeE6));
		}

		static Delegate cb_getLatitudeAsDouble;
#pragma warning disable 0169
		static Delegate GetGetLatitudeAsDoubleHandler ()
		{
			if (cb_getLatitudeAsDouble == null)
				cb_getLatitudeAsDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitudeAsDouble);
			return cb_getLatitudeAsDouble;
		}

		static double n_GetLatitudeAsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Contributor.Util.RecordedGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.Util.RecordedGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeAsDouble;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeAsDouble;
		public virtual double LatitudeAsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/method[@name='getLatitudeAsDouble' and count(parameter)=0]"
			[Register ("getLatitudeAsDouble", "()D", "GetGetLatitudeAsDoubleHandler")]
			get {
				if (id_getLatitudeAsDouble == IntPtr.Zero)
					id_getLatitudeAsDouble = JNIEnv.GetMethodID (class_ref, "getLatitudeAsDouble", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitudeAsDouble);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeAsDouble", "()D"));
			}
		}

		static Delegate cb_getLongitudeAsDouble;
#pragma warning disable 0169
		static Delegate GetGetLongitudeAsDoubleHandler ()
		{
			if (cb_getLongitudeAsDouble == null)
				cb_getLongitudeAsDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitudeAsDouble);
			return cb_getLongitudeAsDouble;
		}

		static double n_GetLongitudeAsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Contributor.Util.RecordedGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.Util.RecordedGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeAsDouble;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeAsDouble;
		public virtual double LongitudeAsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/method[@name='getLongitudeAsDouble' and count(parameter)=0]"
			[Register ("getLongitudeAsDouble", "()D", "GetGetLongitudeAsDoubleHandler")]
			get {
				if (id_getLongitudeAsDouble == IntPtr.Zero)
					id_getLongitudeAsDouble = JNIEnv.GetMethodID (class_ref, "getLongitudeAsDouble", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitudeAsDouble);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeAsDouble", "()D"));
			}
		}

		static Delegate cb_getNumSatellites;
#pragma warning disable 0169
		static Delegate GetGetNumSatellitesHandler ()
		{
			if (cb_getNumSatellites == null)
				cb_getNumSatellites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumSatellites);
			return cb_getNumSatellites;
		}

		static int n_GetNumSatellites (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Contributor.Util.RecordedGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.Util.RecordedGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumSatellites;
		}
#pragma warning restore 0169

		static IntPtr id_getNumSatellites;
		public virtual int NumSatellites {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/method[@name='getNumSatellites' and count(parameter)=0]"
			[Register ("getNumSatellites", "()I", "GetGetNumSatellitesHandler")]
			get {
				if (id_getNumSatellites == IntPtr.Zero)
					id_getNumSatellites = JNIEnv.GetMethodID (class_ref, "getNumSatellites", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNumSatellites);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumSatellites", "()I"));
			}
		}

		static Delegate cb_getTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetTimeStampHandler ()
		{
			if (cb_getTimeStamp == null)
				cb_getTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimeStamp);
			return cb_getTimeStamp;
		}

		static long n_GetTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Contributor.Util.RecordedGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.Util.RecordedGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeStamp;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeStamp;
		public virtual long TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedGeoPoint']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()J", "GetGetTimeStampHandler")]
			get {
				if (id_getTimeStamp == IntPtr.Zero)
					id_getTimeStamp = JNIEnv.GetMethodID (class_ref, "getTimeStamp", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getTimeStamp);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeStamp", "()J"));
			}
		}

	}
}
