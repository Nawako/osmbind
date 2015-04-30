using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/OSRMRoadManager", DoNotGenerateAcw=true)]
	public partial class OSRMRoadManager : global::Osmdroid.Bonuspack.Routing.RoadManager {


		static IntPtr mServiceUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/field[@name='mServiceUrl']"
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

		static IntPtr mUserAgent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/field[@name='mUserAgent']"
		[Register ("mUserAgent")]
		protected string MUserAgent {
			get {
				if (mUserAgent_jfieldId == IntPtr.Zero)
					mUserAgent_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserAgent", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUserAgent_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUserAgent_jfieldId == IntPtr.Zero)
					mUserAgent_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserAgent", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mUserAgent_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/OSRMRoadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OSRMRoadManager); }
		}

		protected OSRMRoadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/constructor[@name='OSRMRoadManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public OSRMRoadManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OSRMRoadManager)) {
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

		static Delegate cb_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_;
#pragma warning disable 0169
		static Delegate GetBuildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_Handler ()
		{
			if (cb_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ == null)
				cb_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_);
			return cb_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_;
		}

		static IntPtr n_BuildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IDictionary<string, string> p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.BuildInstructions (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='buildInstructions' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.HashMap']]"
		[Register ("buildInstructions", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)Ljava/lang/String;", "GetBuildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_Handler")]
		protected virtual string BuildInstructions (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ == IntPtr.Zero)
				id_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "buildInstructions", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_buildInstructions_Ljava_lang_String_Ljava_lang_String_Ljava_util_HashMap_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildInstructions", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/HashMap;)Ljava/lang/String;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_getManeuverCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetManeuverCode_Ljava_lang_String_Handler ()
		{
			if (cb_getManeuverCode_Ljava_lang_String_ == null)
				cb_getManeuverCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetManeuverCode_Ljava_lang_String_);
			return cb_getManeuverCode_Ljava_lang_String_;
		}

		static int n_GetManeuverCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetManeuverCode (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getManeuverCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='getManeuverCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getManeuverCode", "(Ljava/lang/String;)I", "GetGetManeuverCode_Ljava_lang_String_Handler")]
		protected virtual int GetManeuverCode (string p0)
		{
			if (id_getManeuverCode_Ljava_lang_String_ == IntPtr.Zero)
				id_getManeuverCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getManeuverCode", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_getManeuverCode_Ljava_lang_String_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getManeuverCode", "(Ljava/lang/String;)I"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getRoad_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetRoad_Ljava_util_ArrayList_Handler ()
		{
			if (cb_getRoad_Ljava_util_ArrayList_ == null)
				cb_getRoad_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRoad_Ljava_util_ArrayList_);
			return cb_getRoad_Ljava_util_ArrayList_;
		}

		static IntPtr n_GetRoad_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoad (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoad_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='getRoad' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;", "GetGetRoad_Ljava_util_ArrayList_Handler")]
		public override global::Osmdroid.Bonuspack.Routing.Road GetRoad (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0)
		{
			if (id_getRoad_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_getRoad_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);

			global::Osmdroid.Bonuspack.Routing.Road __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallObjectMethod  (Handle, id_getRoad_Ljava_util_ArrayList_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getUrl_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetUrl_Ljava_util_ArrayList_Handler ()
		{
			if (cb_getUrl_Ljava_util_ArrayList_ == null)
				cb_getUrl_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUrl_Ljava_util_ArrayList_);
			return cb_getUrl_Ljava_util_ArrayList_;
		}

		static IntPtr n_GetUrl_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("getUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;", "GetGetUrl_Ljava_util_ArrayList_Handler")]
		protected virtual string GetUrl (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0)
		{
			if (id_getUrl_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_getUrl_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "getUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl_Ljava_util_ArrayList_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "(Ljava/util/ArrayList;)Ljava/lang/String;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgent_Ljava_lang_String_ == null)
				cb_setUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgent_Ljava_lang_String_);
			return cb_setUserAgent_Ljava_lang_String_;
		}

		static void n_SetUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.OSRMRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.OSRMRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserAgent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='OSRMRoadManager']/method[@name='setUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserAgent", "(Ljava/lang/String;)V", "GetSetUserAgent_Ljava_lang_String_Handler")]
		public virtual void SetUserAgent (string p0)
		{
			if (id_setUserAgent_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserAgent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserAgent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUserAgent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAgent", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
