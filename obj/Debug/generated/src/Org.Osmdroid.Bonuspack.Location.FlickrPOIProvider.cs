using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='FlickrPOIProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/FlickrPOIProvider", DoNotGenerateAcw=true)]
	public partial class FlickrPOIProvider : global::Java.Lang.Object {


		static IntPtr mApiKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='FlickrPOIProvider']/field[@name='mApiKey']"
		[Register ("mApiKey")]
		protected string MApiKey {
			get {
				if (mApiKey_jfieldId == IntPtr.Zero)
					mApiKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mApiKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mApiKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mApiKey_jfieldId == IntPtr.Zero)
					mApiKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mApiKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mApiKey_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/FlickrPOIProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlickrPOIProvider); }
		}

		protected FlickrPOIProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='FlickrPOIProvider']/constructor[@name='FlickrPOIProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public FlickrPOIProvider (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (FlickrPOIProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I;
#pragma warning disable 0169
		static Delegate GetGetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_IHandler ()
		{
			if (cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I == null)
				cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I);
			return cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I;
		}

		static IntPtr n_GetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Osmdroid.Bonuspack.Location.FlickrPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.FlickrPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOIInside (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='FlickrPOIProvider']/method[@name='getPOIInside' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6'] and parameter[2][@type='int']]"
		[Register ("getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;I)Ljava/util/ArrayList;", "GetGetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_IHandler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetPOIInside (global::Org.Osmdroid.Util.BoundingBoxE6 p0, int p1)
		{
			if (id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I == IntPtr.Zero)
				id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I = JNIEnv.GetMethodID (class_ref, "getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;I)Ljava/util/ArrayList;");

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;I)Ljava/util/ArrayList;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getThem_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetThem_Ljava_lang_String_Handler ()
		{
			if (cb_getThem_Ljava_lang_String_ == null)
				cb_getThem_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetThem_Ljava_lang_String_);
			return cb_getThem_Ljava_lang_String_;
		}

		static IntPtr n_GetThem_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Location.FlickrPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.FlickrPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetThem (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getThem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='FlickrPOIProvider']/method[@name='getThem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getThem", "(Ljava/lang/String;)Ljava/util/ArrayList;", "GetGetThem_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetThem (string p0)
		{
			if (id_getThem_Ljava_lang_String_ == IntPtr.Zero)
				id_getThem_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getThem", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getThem_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThem", "(Ljava/lang/String;)Ljava/util/ArrayList;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
