using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='GpxToPHPUploader']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/GpxToPHPUploader", DoNotGenerateAcw=true)]
	public partial class GpxToPHPUploader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='GpxToPHPUploader']/field[@name='UPLOADSCRIPT_URL']"
		[Register ("UPLOADSCRIPT_URL")]
		protected const string UploadscriptUrl = (string) "http://www.PLACEYOURDOMAINHERE.com/anyfolder/gpxuploader/upload.php";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/contributor/GpxToPHPUploader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GpxToPHPUploader); }
		}

		protected GpxToPHPUploader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_uploadAsync_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='GpxToPHPUploader']/method[@name='uploadAsync' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
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
