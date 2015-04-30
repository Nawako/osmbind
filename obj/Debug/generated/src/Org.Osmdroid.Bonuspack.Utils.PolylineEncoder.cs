using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='PolylineEncoder']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/utils/PolylineEncoder", DoNotGenerateAcw=true)]
	public partial class PolylineEncoder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/utils/PolylineEncoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PolylineEncoder); }
		}

		protected PolylineEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='PolylineEncoder']/constructor[@name='PolylineEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PolylineEncoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PolylineEncoder)) {
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

		static IntPtr id_decode_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='PolylineEncoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("decode", "(Ljava/lang/String;I)Ljava/util/ArrayList;", "")]
		public static global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_encode_Ljava_util_ArrayList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='PolylineEncoder']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='int']]"
		[Register ("encode", "(Ljava/util/ArrayList;I)Ljava/lang/String;", "")]
		public static string Encode (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0, int p1)
		{
			if (id_encode_Ljava_util_ArrayList_I == IntPtr.Zero)
				id_encode_Ljava_util_ArrayList_I = JNIEnv.GetStaticMethodID (class_ref, "encode", "(Ljava/util/ArrayList;I)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_Ljava_util_ArrayList_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
