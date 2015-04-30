using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/NominatimPOIProvider", DoNotGenerateAcw=true)]
	public partial class NominatimPOIProvider : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/field[@name='MAPQUEST_POI_SERVICE']"
		[Register ("MAPQUEST_POI_SERVICE")]
		public const string MapquestPoiService = (string) "http://open.mapquestapi.com/nominatim/v1/";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/field[@name='NOMINATIM_POI_SERVICE']"
		[Register ("NOMINATIM_POI_SERVICE")]
		public const string NominatimPoiService = (string) "http://nominatim.openstreetmap.org/";

		static IntPtr mService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/field[@name='mService']"
		[Register ("mService")]
		protected string MService {
			get {
				if (mService_jfieldId == IntPtr.Zero)
					mService_jfieldId = JNIEnv.GetFieldID (class_ref, "mService", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mService_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mService_jfieldId == IntPtr.Zero)
					mService_jfieldId = JNIEnv.GetFieldID (class_ref, "mService", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mService_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/NominatimPOIProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NominatimPOIProvider); }
		}

		protected NominatimPOIProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/constructor[@name='NominatimPOIProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NominatimPOIProvider () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NominatimPOIProvider)) {
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

		static Delegate cb_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID;
#pragma warning disable 0169
		static Delegate GetGetPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_IDHandler ()
		{
			if (cb_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID == null)
				cb_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, double, IntPtr>) n_GetPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID);
			return cb_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID;
		}

		static IntPtr n_GetPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, double p3)
		{
			global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOIAlong (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/method[@name='getPOIAlong' and count(parameter)=4 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("getPOIAlong", "(Ljava/util/ArrayList;Ljava/lang/String;ID)Ljava/util/ArrayList;", "GetGetPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_IDHandler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetPOIAlong (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0, string p1, int p2, double p3)
		{
			if (id_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID == IntPtr.Zero)
				id_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID = JNIEnv.GetMethodID (class_ref, "getPOIAlong", "(Ljava/util/ArrayList;Ljava/lang/String;ID)Ljava/util/ArrayList;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPOIAlong_Ljava_util_ArrayList_Ljava_lang_String_ID, new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPOIAlong", "(Ljava/util/ArrayList;Ljava/lang/String;ID)Ljava/util/ArrayList;"), new JValue (native_p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID;
#pragma warning disable 0169
		static Delegate GetGetPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_IDHandler ()
		{
			if (cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID == null)
				cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, double, IntPtr>) n_GetPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID);
			return cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID;
		}

		static IntPtr n_GetPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, double p3)
		{
			global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOICloseTo (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/method[@name='getPOICloseTo' and count(parameter)=4 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='double']]"
		[Register ("getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;Ljava/lang/String;ID)Ljava/util/ArrayList;", "GetGetPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_IDHandler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetPOICloseTo (global::Org.Osmdroid.Util.GeoPoint p0, string p1, int p2, double p3)
		{
			if (id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID == IntPtr.Zero)
				id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID = JNIEnv.GetMethodID (class_ref, "getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;Ljava/lang/String;ID)Ljava/util/ArrayList;");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_Ljava_lang_String_ID, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;Ljava/lang/String;ID)Ljava/util/ArrayList;"), new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_IHandler ()
		{
			if (cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I == null)
				cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I);
			return cb_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I;
		}

		static IntPtr n_GetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOIInside (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/method[@name='getPOIInside' and count(parameter)=3 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;Ljava/lang/String;I)Ljava/util/ArrayList;", "GetGetPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_IHandler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetPOIInside (global::Org.Osmdroid.Util.BoundingBoxE6 p0, string p1, int p2)
		{
			if (id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I == IntPtr.Zero)
				id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;Ljava/lang/String;I)Ljava/util/ArrayList;");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_Ljava_lang_String_I, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPOIInside", "(Lorg/osmdroid/util/BoundingBoxE6;Ljava/lang/String;I)Ljava/util/ArrayList;"), new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetThem (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getThem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/method[@name='getThem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.NominatimPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='NominatimPOIProvider']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
