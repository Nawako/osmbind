using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='Util']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/util/Util", DoNotGenerateAcw=true)]
	public partial class Util : global::Java.Lang.Object {


		static IntPtr UTCSimpleDateFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='Util']/field[@name='UTCSimpleDateFormat']"
		[Register ("UTCSimpleDateFormat")]
		public static global::Java.Text.SimpleDateFormat UTCSimpleDateFormat {
			get {
				if (UTCSimpleDateFormat_jfieldId == IntPtr.Zero)
					UTCSimpleDateFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTCSimpleDateFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UTCSimpleDateFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UTCSimpleDateFormat_jfieldId == IntPtr.Zero)
					UTCSimpleDateFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UTCSimpleDateFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, UTCSimpleDateFormat_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/contributor/util/Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Util); }
		}

		protected Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_convertTimestampToUTCString_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='Util']/method[@name='convertTimestampToUTCString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("convertTimestampToUTCString", "(J)Ljava/lang/String;", "")]
		public static string ConvertTimestampToUTCString (long aTimestamp)
		{
			if (id_convertTimestampToUTCString_J == IntPtr.Zero)
				id_convertTimestampToUTCString_J = JNIEnv.GetStaticMethodID (class_ref, "convertTimestampToUTCString", "(J)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertTimestampToUTCString_J, new JValue (aTimestamp)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_isSufficienDataForUpload_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='Util']/method[@name='isSufficienDataForUpload' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("isSufficienDataForUpload", "(Ljava/util/ArrayList;)Z", "")]
		public static bool IsSufficienDataForUpload (global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p0)
		{
			if (id_isSufficienDataForUpload_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_isSufficienDataForUpload_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "isSufficienDataForUpload", "(Ljava/util/ArrayList;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p0);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSufficienDataForUpload_Ljava_util_ArrayList_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
