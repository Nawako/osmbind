using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/MapQuestRoadManager", DoNotGenerateAcw=true)]
	public partial class MapQuestRoadManager : global::Osmdroid.Bonuspack.Routing.RoadManager {


		static IntPtr mApiKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/field[@name='mApiKey']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/MapQuestRoadManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapQuestRoadManager); }
		}

		protected MapQuestRoadManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/constructor[@name='MapQuestRoadManager' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public MapQuestRoadManager (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (MapQuestRoadManager)) {
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

		static Delegate cb_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetFinalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == null)
				cb_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FinalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_);
			return cb_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		}

		static IntPtr n_FinalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Osmdroid.Bonuspack.Routing.RoadNode> p0 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Osmdroid.Bonuspack.Routing.RoadLink> p1 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadLink>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p2 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.ToLocalJniHandle (__this.FinalizeNodes (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/method[@name='finalizeNodes' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='java.util.ArrayList'] and parameter[3][@type='java.util.ArrayList']]"
		[Register ("finalizeNodes", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;", "GetFinalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_Handler")]
		protected virtual global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadNode> FinalizeNodes (global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadNode> p0, global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadLink> p1, global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p2)
		{
			if (id_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "finalizeNodes", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadLink>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p2);

			global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadNode> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_finalizeNodes_Ljava_util_ArrayList_Ljava_util_ArrayList_Ljava_util_ArrayList_, new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizeNodes", "(Ljava/util/ArrayList;Ljava/util/ArrayList;Ljava/util/ArrayList;)Ljava/util/ArrayList;"), new JValue (native_p0), new JValue (native_p1), new JValue (native_p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetFinalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_Handler ()
		{
			if (cb_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_ == null)
				cb_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FinalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_);
			return cb_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_;
		}

		static IntPtr n_FinalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Routing.Road p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Osmdroid.Bonuspack.Routing.RoadLink> p1 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadLink>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (__this.FinalizeRoadShape (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/method[@name='finalizeRoadShape' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.routing.Road'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("finalizeRoadShape", "(Lorg/osmdroid/bonuspack/routing/Road;Ljava/util/ArrayList;)Ljava/util/ArrayList;", "GetFinalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> FinalizeRoadShape (global::Osmdroid.Bonuspack.Routing.Road p0, global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadLink> p1)
		{
			if (id_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "finalizeRoadShape", "(Lorg/osmdroid/bonuspack/routing/Road;Ljava/util/ArrayList;)Ljava/util/ArrayList;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadLink>.ToLocalJniHandle (p1);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_finalizeRoadShape_Lorg_osmdroid_bonuspack_routing_Road_Ljava_util_ArrayList_, new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finalizeRoadShape", "(Lorg/osmdroid/bonuspack/routing/Road;Ljava/util/ArrayList;)Ljava/util/ArrayList;"), new JValue (p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoad (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoad_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/method[@name='getRoad' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
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

		static Delegate cb_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_Handler ()
		{
			if (cb_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_ == null)
				cb_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_);
			return cb_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_;
		}

		static IntPtr n_GetRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p1 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRoadXML (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/method[@name='getRoadXML' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.util.ArrayList']]"
		[Register ("getRoadXML", "(Ljava/io/InputStream;Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;", "GetGetRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_Handler")]
		protected virtual global::Osmdroid.Bonuspack.Routing.Road GetRoadXML (global::System.IO.Stream p0, global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p1)
		{
			if (id_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "getRoadXML", "(Ljava/io/InputStream;Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p1);

			global::Osmdroid.Bonuspack.Routing.Road __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallObjectMethod  (Handle, id_getRoadXML_Ljava_io_InputStream_Ljava_util_ArrayList_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoadXML", "(Ljava/io/InputStream;Ljava/util/ArrayList;)Lorg/osmdroid/bonuspack/routing/Road;"), new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.MapQuestRoadManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='MapQuestRoadManager']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
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
