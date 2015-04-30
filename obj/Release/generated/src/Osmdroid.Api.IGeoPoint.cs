using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IGeoPoint']"
	[Register ("org/osmdroid/api/IGeoPoint", "", "Osmdroid.Api.IGeoPointInvoker")]
	public partial interface IGeoPoint : IJavaObject {

		double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IGeoPoint']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Osmdroid.Api.IGeoPointInvoker, OsmdroidAndroidBinding")] get;
		}

		int LatitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IGeoPoint']/method[@name='getLatitudeE6' and count(parameter)=0]"
			[Register ("getLatitudeE6", "()I", "GetGetLatitudeE6Handler:Osmdroid.Api.IGeoPointInvoker, OsmdroidAndroidBinding")] get;
		}

		double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IGeoPoint']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Osmdroid.Api.IGeoPointInvoker, OsmdroidAndroidBinding")] get;
		}

		int LongitudeE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IGeoPoint']/method[@name='getLongitudeE6' and count(parameter)=0]"
			[Register ("getLongitudeE6", "()I", "GetGetLongitudeE6Handler:Osmdroid.Api.IGeoPointInvoker, OsmdroidAndroidBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IGeoPoint", DoNotGenerateAcw=true)]
	internal class IGeoPointInvoker : global::Java.Lang.Object, IGeoPoint {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IGeoPoint");
		IntPtr class_ref;

		public static IGeoPoint GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGeoPoint> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IGeoPoint"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGeoPointInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IGeoPointInvoker); }
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		IntPtr id_getLatitude;
		public double Latitude {
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLatitude);
			}
		}

		static Delegate cb_getLatitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLatitudeE6Handler ()
		{
			if (cb_getLatitudeE6 == null)
				cb_getLatitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeE6);
			return cb_getLatitudeE6;
		}

		static int n_GetLatitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeE6;
		}
#pragma warning restore 0169

		IntPtr id_getLatitudeE6;
		public int LatitudeE6 {
			get {
				if (id_getLatitudeE6 == IntPtr.Zero)
					id_getLatitudeE6 = JNIEnv.GetMethodID (class_ref, "getLatitudeE6", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLatitudeE6);
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		IntPtr id_getLongitude;
		public double Longitude {
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				return JNIEnv.CallDoubleMethod (Handle, id_getLongitude);
			}
		}

		static Delegate cb_getLongitudeE6;
#pragma warning disable 0169
		static Delegate GetGetLongitudeE6Handler ()
		{
			if (cb_getLongitudeE6 == null)
				cb_getLongitudeE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeE6);
			return cb_getLongitudeE6;
		}

		static int n_GetLongitudeE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IGeoPoint __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeE6;
		}
#pragma warning restore 0169

		IntPtr id_getLongitudeE6;
		public int LongitudeE6 {
			get {
				if (id_getLongitudeE6 == IntPtr.Zero)
					id_getLongitudeE6 = JNIEnv.GetMethodID (class_ref, "getLongitudeE6", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLongitudeE6);
			}
		}

	}

}
