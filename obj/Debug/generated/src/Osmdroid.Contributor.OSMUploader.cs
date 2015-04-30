using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/OSMUploader", DoNotGenerateAcw=true)]
	public partial class OSMUploader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/field[@name='API_VERSION']"
		[Register ("API_VERSION")]
		public const string ApiVersion = (string) "0.5";

		static IntPtr pseudoFileNameFormat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/field[@name='pseudoFileNameFormat']"
		[Register ("pseudoFileNameFormat")]
		public static global::Java.Text.SimpleDateFormat PseudoFileNameFormat {
			get {
				if (pseudoFileNameFormat_jfieldId == IntPtr.Zero)
					pseudoFileNameFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pseudoFileNameFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, pseudoFileNameFormat_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Text.SimpleDateFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pseudoFileNameFormat_jfieldId == IntPtr.Zero)
					pseudoFileNameFormat_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "pseudoFileNameFormat", "Ljava/text/SimpleDateFormat;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, pseudoFileNameFormat_jfieldId, native_value);
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
				return JNIEnv.FindClass ("org/osmdroid/contributor/OSMUploader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OSMUploader); }
		}

		protected OSMUploader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_upload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/method[@name='upload' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.ArrayList'] and parameter[7][@type='java.lang.String']]"
		[Register ("upload", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;Ljava/lang/String;)V", "")]
		public static void Upload (string p0, string p1, string p2, string p3, bool p4, global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p5, string p6)
		{
			if (id_upload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_upload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "upload", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_upload_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static IntPtr id_uploadAsync_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/method[@name='uploadAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='java.util.ArrayList']]"
		[Register ("uploadAsync", "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;)V", "")]
		public static void UploadAsync (string p0, string p1, bool p2, global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p3)
		{
			if (id_uploadAsync_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_ == IntPtr.Zero)
				id_uploadAsync_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "uploadAsync", "(Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p3);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_uploadAsync_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (native_p3));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static IntPtr id_uploadAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/method[@name='uploadAsync' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.ArrayList'] and parameter[7][@type='java.lang.String']]"
		[Register ("uploadAsync", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;Ljava/lang/String;)V", "")]
		public static void UploadAsync (string p0, string p1, string p2, string p3, bool p4, global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p5, string p6)
		{
			if (id_uploadAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_ == IntPtr.Zero)
				id_uploadAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "uploadAsync", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLjava/util/ArrayList;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_uploadAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLjava_util_ArrayList_Ljava_lang_String_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2), new JValue (native_p3), new JValue (p4), new JValue (native_p5), new JValue (native_p6));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			JNIEnv.DeleteLocalRef (native_p5);
			JNIEnv.DeleteLocalRef (native_p6);
		}

		static IntPtr id_uploadAsync_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='OSMUploader']/method[@name='uploadAsync' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("uploadAsync", "(Ljava/util/ArrayList;)V", "")]
		public static void UploadAsync (global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> p0)
		{
			if (id_uploadAsync_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_uploadAsync_Ljava_util_ArrayList_ = JNIEnv.GetStaticMethodID (class_ref, "uploadAsync", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (p0);
			JNIEnv.CallStaticVoidMethod  (class_ref, id_uploadAsync_Ljava_util_ArrayList_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
