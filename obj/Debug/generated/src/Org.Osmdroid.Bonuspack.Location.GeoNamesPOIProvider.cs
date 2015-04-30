using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/GeoNamesPOIProvider", DoNotGenerateAcw=true)]
	public partial class GeoNamesPOIProvider : global::Java.Lang.Object {


		static IntPtr mUserName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/field[@name='mUserName']"
		[Register ("mUserName")]
		protected string MUserName {
			get {
				if (mUserName_jfieldId == IntPtr.Zero)
					mUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUserName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUserName_jfieldId == IntPtr.Zero)
					mUserName_jfieldId = JNIEnv.GetFieldID (class_ref, "mUserName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mUserName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/GeoNamesPOIProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeoNamesPOIProvider); }
		}

		protected GeoNamesPOIProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/constructor[@name='GeoNamesPOIProvider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public GeoNamesPOIProvider (string p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			if (GetType () != typeof (GeoNamesPOIProvider)) {
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

		static Delegate cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID;
#pragma warning disable 0169
		static Delegate GetGetPOICloseTo_Lorg_osmdroid_util_GeoPoint_IDHandler ()
		{
			if (cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID == null)
				cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, double, IntPtr>) n_GetPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID);
			return cb_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID;
		}

		static IntPtr n_GetPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, double p2)
		{
			global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOICloseTo (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/method[@name='getPOICloseTo' and count(parameter)=3 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;ID)Ljava/util/ArrayList;", "GetGetPOICloseTo_Lorg_osmdroid_util_GeoPoint_IDHandler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetPOICloseTo (global::Org.Osmdroid.Util.GeoPoint p0, int p1, double p2)
		{
			if (id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID == IntPtr.Zero)
				id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID = JNIEnv.GetMethodID (class_ref, "getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;ID)Ljava/util/ArrayList;");

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPOICloseTo_Lorg_osmdroid_util_GeoPoint_ID, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPOICloseTo", "(Lorg/osmdroid/util/GeoPoint;ID)Ljava/util/ArrayList;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetPOIInside (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPOIInside_Lorg_osmdroid_util_BoundingBoxE6_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/method[@name='getPOIInside' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6'] and parameter[2][@type='int']]"
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
			global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetThem (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getThem_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/method[@name='getThem' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getThemXML_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetThemXML_Ljava_lang_String_Handler ()
		{
			if (cb_getThemXML_Ljava_lang_String_ == null)
				cb_getThemXML_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetThemXML_Ljava_lang_String_);
			return cb_getThemXML_Ljava_lang_String_;
		}

		static IntPtr n_GetThemXML_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.GeoNamesPOIProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.ToLocalJniHandle (__this.GetThemXML (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getThemXML_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='GeoNamesPOIProvider']/method[@name='getThemXML' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getThemXML", "(Ljava/lang/String;)Ljava/util/ArrayList;", "GetGetThemXML_Ljava_lang_String_Handler")]
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> GetThemXML (string p0)
		{
			if (id_getThemXML_Ljava_lang_String_ == IntPtr.Zero)
				id_getThemXML_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getThemXML", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Location.POI> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getThemXML_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Location.POI>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThemXML", "(Ljava/lang/String;)Ljava/util/ArrayList;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
