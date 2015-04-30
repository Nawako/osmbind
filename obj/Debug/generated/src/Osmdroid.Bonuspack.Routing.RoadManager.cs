using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/RoadManager", DoNotGenerateAcw=true)]
	public abstract partial class RoadManager : global::Java.Lang.Object {


		static IntPtr mOptions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/field[@name='mOptions']"
		[Register ("mOptions")]
		protected string MOptions {
			get {
				if (mOptions_jfieldId == IntPtr.Zero)
					mOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "mOptions", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOptions_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOptions_jfieldId == IntPtr.Zero)
					mOptions_jfieldId = JNIEnv.GetFieldID (class_ref, "mOptions", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mOptions_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/RoadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoadManager); }
		}

		protected RoadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/constructor[@name='RoadManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RoadManager () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RoadManager)) {
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

		static Delegate cb_addRequestOption_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddRequestOption_Ljava_lang_String_Handler ()
		{
			if (cb_addRequestOption_Ljava_lang_String_ == null)
				cb_addRequestOption_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRequestOption_Ljava_lang_String_);
			return cb_addRequestOption_Ljava_lang_String_;
		}

		static void n_AddRequestOption_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.RoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.RoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddRequestOption (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addRequestOption_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='addRequestOption' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addRequestOption", "(Ljava/lang/String;)V", "GetAddRequestOption_Ljava_lang_String_Handler")]
		public virtual void AddRequestOption (string p0)
		{
			if (id_addRequestOption_Ljava_lang_String_ == IntPtr.Zero)
				id_addRequestOption_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addRequestOption", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addRequestOption_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addRequestOption", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='buildRoadOverlay' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.routing.Road'] and parameter[2][@type='android.content.Context']]"
		[Register ("buildRoadOverlay", "(Lorg/osmdroid/bonuspack/routing/Road;Landroid/content/Context;)Lorg/osmdroid/bonuspack/overlays/Polyline;", "")]
		public static global::Osmdroid.Bonuspack.Overlays.Polyline BuildRoadOverlay (global::Osmdroid.Bonuspack.Routing.Road p0, global::Android.Content.Context p1)
		{
			if (id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_Landroid_content_Context_ == IntPtr.Zero)
				id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildRoadOverlay", "(Lorg/osmdroid/bonuspack/routing/Road;Landroid/content/Context;)Lorg/osmdroid/bonuspack/overlays/Polyline;");
			global::Osmdroid.Bonuspack.Overlays.Polyline __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_Landroid_content_Context_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_IFLandroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='buildRoadOverlay' and count(parameter)=4 and parameter[1][@type='org.osmdroid.bonuspack.routing.Road'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='android.content.Context']]"
		[Register ("buildRoadOverlay", "(Lorg/osmdroid/bonuspack/routing/Road;IFLandroid/content/Context;)Lorg/osmdroid/bonuspack/overlays/Polyline;", "")]
		public static global::Osmdroid.Bonuspack.Overlays.Polyline BuildRoadOverlay (global::Osmdroid.Bonuspack.Routing.Road p0, int p1, float p2, global::Android.Content.Context p3)
		{
			if (id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_IFLandroid_content_Context_ == IntPtr.Zero)
				id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_IFLandroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "buildRoadOverlay", "(Lorg/osmdroid/bonuspack/routing/Road;IFLandroid/content/Context;)Lorg/osmdroid/bonuspack/overlays/Polyline;");
			global::Osmdroid.Bonuspack.Overlays.Polyline __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRoadOverlay_Lorg_osmdroid_bonuspack_routing_Road_IFLandroid_content_Context_, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_geoPointAsString_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetGeoPointAsString_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_geoPointAsString_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_geoPointAsString_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GeoPointAsString_Lorg_osmdroid_util_GeoPoint_);
			return cb_geoPointAsString_Lorg_osmdroid_util_GeoPoint_;
		}

		static IntPtr n_GeoPointAsString_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.RoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.RoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GeoPointAsString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_geoPointAsString_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='geoPointAsString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("geoPointAsString", "(Lorg/osmdroid/util/GeoPoint;)Ljava/lang/String;", "GetGeoPointAsString_Lorg_osmdroid_util_GeoPoint_Handler")]
		protected virtual string GeoPointAsString (global::Org.Osmdroid.Util.GeoPoint p0)
		{
			if (id_geoPointAsString_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_geoPointAsString_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "geoPointAsString", "(Lorg/osmdroid/util/GeoPoint;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_geoPointAsString_Lorg_osmdroid_util_GeoPoint_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "geoPointAsString", "(Lorg/osmdroid/util/GeoPoint;)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Bonuspack.Routing.RoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.RoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoad (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='getRoad' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;", "GetGetRoad_Ljava_util_ArrayList_Handler")]
		public abstract global::Osmdroid.Bonuspack.Routing.Road GetRoad (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0);

	}

	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/RoadManager", DoNotGenerateAcw=true)]
	internal partial class RoadManagerInvoker : RoadManager {

		public RoadManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoadManagerInvoker); }
		}

		static IntPtr id_getRoad_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadManager']/method[@name='getRoad' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;", "GetGetRoad_Ljava_util_ArrayList_Handler")]
		public override global::Osmdroid.Bonuspack.Routing.Road GetRoad (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0)
		{
			if (id_getRoad_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_getRoad_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "getRoad", "(Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);
			global::Osmdroid.Bonuspack.Routing.Road __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallObjectMethod  (Handle, id_getRoad_Ljava_util_ArrayList_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
