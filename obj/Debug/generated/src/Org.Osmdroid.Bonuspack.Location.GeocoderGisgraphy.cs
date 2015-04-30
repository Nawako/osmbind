using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/GeocoderGisgraphy", DoNotGenerateAcw=true)]
	public partial class GeocoderGisgraphy : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/field[@name='GISGRAPHY_SERVICE_URL']"
		[Register ("GISGRAPHY_SERVICE_URL")]
		public const string GisgraphyServiceUrl = (string) "http://services.gisgraphy.com/";

		static IntPtr mLocale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/field[@name='mLocale']"
		[Register ("mLocale")]
		protected global::Java.Util.Locale MLocale {
			get {
				if (mLocale_jfieldId == IntPtr.Zero)
					mLocale_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocale", "Ljava/util/Locale;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocale_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocale_jfieldId == IntPtr.Zero)
					mLocale_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocale", "Ljava/util/Locale;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLocale_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mServiceUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/field[@name='mServiceUrl']"
		[Register ("mServiceUrl")]
		protected string MServiceUrl {
			get {
				if (mServiceUrl_jfieldId == IntPtr.Zero)
					mServiceUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mServiceUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mServiceUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mServiceUrl_jfieldId == IntPtr.Zero)
					mServiceUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mServiceUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mServiceUrl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/GeocoderGisgraphy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeocoderGisgraphy); }
		}

		protected GeocoderGisgraphy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/constructor[@name='GeocoderGisgraphy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GeocoderGisgraphy (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeocoderGisgraphy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_Locale_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/constructor[@name='GeocoderGisgraphy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Locale']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/Locale;)V", "")]
		public GeocoderGisgraphy (global::Android.Content.Context p0, global::Java.Util.Locale p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeocoderGisgraphy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/Locale;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/Locale;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_util_Locale_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_util_Locale_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/Locale;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_Locale_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_Locale_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_isPresent;
		public static bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/method[@name='isPresent' and count(parameter)=0]"
			[Register ("isPresent", "()Z", "GetIsPresentHandler")]
			get {
				if (id_isPresent == IntPtr.Zero)
					id_isPresent = JNIEnv.GetStaticMethodID (class_ref, "isPresent", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPresent);
			}
		}

		static Delegate cb_buildAndroidAddress_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetBuildAndroidAddress_Lorg_json_JSONObject_Handler ()
		{
			if (cb_buildAndroidAddress_Lorg_json_JSONObject_ == null)
				cb_buildAndroidAddress_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildAndroidAddress_Lorg_json_JSONObject_);
			return cb_buildAndroidAddress_Lorg_json_JSONObject_;
		}

		static IntPtr n_BuildAndroidAddress_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildAndroidAddress (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildAndroidAddress_Lorg_json_JSONObject_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/method[@name='buildAndroidAddress' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("buildAndroidAddress", "(Lorg/json/JSONObject;)Landroid/location/Address;", "GetBuildAndroidAddress_Lorg_json_JSONObject_Handler")]
		protected virtual global::Android.Locations.Address BuildAndroidAddress (global::Org.Json.JSONObject p0)
		{
			if (id_buildAndroidAddress_Lorg_json_JSONObject_ == IntPtr.Zero)
				id_buildAndroidAddress_Lorg_json_JSONObject_ = JNIEnv.GetMethodID (class_ref, "buildAndroidAddress", "(Lorg/json/JSONObject;)Landroid/location/Address;");

			global::Android.Locations.Address __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Address> (JNIEnv.CallObjectMethod  (Handle, id_buildAndroidAddress_Lorg_json_JSONObject_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Address> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildAndroidAddress", "(Lorg/json/JSONObject;)Landroid/location/Address;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getFromLocationName_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetFromLocationName_Ljava_lang_String_IHandler ()
		{
			if (cb_getFromLocationName_Ljava_lang_String_I == null)
				cb_getFromLocationName_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetFromLocationName_Ljava_lang_String_I);
			return cb_getFromLocationName_Ljava_lang_String_I;
		}

		static IntPtr n_GetFromLocationName_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.ToLocalJniHandle (__this.GetFromLocationName (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFromLocationName_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/method[@name='getFromLocationName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;", "GetGetFromLocationName_Ljava_lang_String_IHandler")]
		public virtual global::System.Collections.Generic.IList<global::Android.Locations.Address> GetFromLocationName (string p0, int p1)
		{
			if (id_getFromLocationName_Ljava_lang_String_I == IntPtr.Zero)
				id_getFromLocationName_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.Generic.IList<global::Android.Locations.Address> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getFromLocationName_Ljava_lang_String_I, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Android.Locations.Address>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromLocationName", "(Ljava/lang/String;I)Ljava/util/List;"), new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetService_Ljava_lang_String_Handler ()
		{
			if (cb_setService_Ljava_lang_String_ == null)
				cb_setService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetService_Ljava_lang_String_);
			return cb_setService_Ljava_lang_String_;
		}

		static void n_SetService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeocoderGisgraphy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeocoderGisgraphy']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setService", "(Ljava/lang/String;)V", "GetSetService_Ljava_lang_String_Handler")]
		public virtual void SetService (string p0)
		{
			if (id_setService_Ljava_lang_String_ == IntPtr.Zero)
				id_setService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setService", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setService_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setService", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
