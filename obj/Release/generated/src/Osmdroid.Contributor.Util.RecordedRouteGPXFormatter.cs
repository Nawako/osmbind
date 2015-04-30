using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/util/RecordedRouteGPXFormatter", DoNotGenerateAcw=true)]
	public partial class RecordedRouteGPXFormatter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/field[@name='GPX_TAG_TRACK_SEGMENT_POINT']"
		[Register ("GPX_TAG_TRACK_SEGMENT_POINT")]
		public const string GpxTagTrackSegmentPoint = (string) "<trkpt lat=\"%f\" lon=\"%f\">";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/field[@name='GPX_TAG_TRACK_SEGMENT_POINT_CLOSE']"
		[Register ("GPX_TAG_TRACK_SEGMENT_POINT_CLOSE")]
		public const string GpxTagTrackSegmentPointClose = (string) "</trkpt>";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/field[@name='GPX_TAG_TRACK_SEGMENT_POINT_ELE']"
		[Register ("GPX_TAG_TRACK_SEGMENT_POINT_ELE")]
		public const string GpxTagTrackSegmentPointEle = (string) "<ele>%d</ele>";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/field[@name='GPX_TAG_TRACK_SEGMENT_POINT_SAT']"
		[Register ("GPX_TAG_TRACK_SEGMENT_POINT_SAT")]
		public const string GpxTagTrackSegmentPointSat = (string) "<sat>%d</sat>";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/field[@name='GPX_TAG_TRACK_SEGMENT_POINT_TIME']"
		[Register ("GPX_TAG_TRACK_SEGMENT_POINT_TIME")]
		public const string GpxTagTrackSegmentPointTime = (string) "<time>%s</time>";

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
				return JNIEnv.FindClass ("org/osmdroid/contributor/util/RecordedRouteGPXFormatter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecordedRouteGPXFormatter); }
		}

		protected RecordedRouteGPXFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/constructor[@name='RecordedRouteGPXFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RecordedRouteGPXFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RecordedRouteGPXFormatter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_create_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor.util']/class[@name='RecordedRouteGPXFormatter']/method[@name='create' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("create", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static string Create (global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p0)
		{
			if (id_create_Ljava_util_List_ == IntPtr.Zero)
				id_create_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "create", "(Ljava/util/List;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
