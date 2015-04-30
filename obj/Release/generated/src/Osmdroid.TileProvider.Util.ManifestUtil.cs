using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='ManifestUtil']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/util/ManifestUtil", DoNotGenerateAcw=true)]
	public partial class ManifestUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/util/ManifestUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ManifestUtil); }
		}

		protected ManifestUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='ManifestUtil']/constructor[@name='ManifestUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ManifestUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ManifestUtil)) {
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

		static IntPtr id_retrieveKey_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='ManifestUtil']/method[@name='retrieveKey' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("retrieveKey", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string RetrieveKey (global::Android.Content.Context aContext, string aKey)
		{
			if (id_retrieveKey_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_retrieveKey_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveKey", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_aKey = JNIEnv.NewString (aKey);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_retrieveKey_Landroid_content_Context_Ljava_lang_String_, new JValue (aContext), new JValue (native_aKey)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aKey);
			return __ret;
		}

	}
}
