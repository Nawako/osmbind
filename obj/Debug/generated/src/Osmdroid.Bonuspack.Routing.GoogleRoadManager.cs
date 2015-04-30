using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='GoogleRoadManager']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/GoogleRoadManager", DoNotGenerateAcw=true)]
	public partial class GoogleRoadManager : global::Osmdroid.Bonuspack.Routing.RoadManager {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/GoogleRoadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GoogleRoadManager); }
		}

		protected GoogleRoadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='GoogleRoadManager']/constructor[@name='GoogleRoadManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GoogleRoadManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GoogleRoadManager)) {
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
			global::Osmdroid.Bonuspack.Routing.GoogleRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.GoogleRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoad (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoad_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='GoogleRoadManager']/method[@name='getRoad' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
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

		static Delegate cb_getRoadXML_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetGetRoadXML_Ljava_io_InputStream_Handler ()
		{
			if (cb_getRoadXML_Ljava_io_InputStream_ == null)
				cb_getRoadXML_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRoadXML_Ljava_io_InputStream_);
			return cb_getRoadXML_Ljava_io_InputStream_;
		}

		static IntPtr n_GetRoadXML_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.GoogleRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.GoogleRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoadXML (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoadXML_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='GoogleRoadManager']/method[@name='getRoadXML' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("getRoadXML", "(Ljava/io/InputStream;)Lorg/osmdroid/bonuspack/routing/Road;", "GetGetRoadXML_Ljava_io_InputStream_Handler")]
		protected virtual global::Osmdroid.Bonuspack.Routing.Road GetRoadXML (global::System.IO.Stream p0)
		{
			if (id_getRoadXML_Ljava_io_InputStream_ == IntPtr.Zero)
				id_getRoadXML_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "getRoadXML", "(Ljava/io/InputStream;)Lorg/osmdroid/bonuspack/routing/Road;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			global::Osmdroid.Bonuspack.Routing.Road __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallObjectMethod  (Handle, id_getRoadXML_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoadXML", "(Ljava/io/InputStream;)Lorg/osmdroid/bonuspack/routing/Road;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Bonuspack.Routing.GoogleRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.GoogleRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='GoogleRoadManager']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
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

	}
}
