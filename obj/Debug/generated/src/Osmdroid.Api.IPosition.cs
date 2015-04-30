using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']"
	[Register ("org/osmdroid/api/IPosition", "", "Osmdroid.Api.IPositionInvoker")]
	public partial interface IPosition : IJavaObject {

		float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

		bool HasBearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='hasBearing' and count(parameter)=0]"
			[Register ("hasBearing", "()Z", "GetHasBearingHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

		bool HasZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='hasZoomLevel' and count(parameter)=0]"
			[Register ("hasZoomLevel", "()Z", "GetHasZoomLevelHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

		double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

		double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

		float ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IPosition']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()F", "GetGetZoomLevelHandler:Osmdroid.Api.IPositionInvoker, OsmdroidAndroidBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IPosition", DoNotGenerateAcw=true)]
	internal class IPositionInvoker : global::Java.Lang.Object, IPosition {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IPosition");
		IntPtr class_ref;

		public static IPosition GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPosition> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IPosition"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPositionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IPositionInvoker); }
		}

		static Delegate cb_getBearing;
#pragma warning disable 0169
		static Delegate GetGetBearingHandler ()
		{
			if (cb_getBearing == null)
				cb_getBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBearing);
			return cb_getBearing;
		}

		static float n_GetBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		IntPtr id_getBearing;
		public float Bearing {
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getBearing);
			}
		}

		static Delegate cb_hasBearing;
#pragma warning disable 0169
		static Delegate GetHasBearingHandler ()
		{
			if (cb_hasBearing == null)
				cb_hasBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBearing);
			return cb_hasBearing;
		}

		static bool n_HasBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBearing;
		}
#pragma warning restore 0169

		IntPtr id_hasBearing;
		public bool HasBearing {
			get {
				if (id_hasBearing == IntPtr.Zero)
					id_hasBearing = JNIEnv.GetMethodID (class_ref, "hasBearing", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasBearing);
			}
		}

		static Delegate cb_hasZoomLevel;
#pragma warning disable 0169
		static Delegate GetHasZoomLevelHandler ()
		{
			if (cb_hasZoomLevel == null)
				cb_hasZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasZoomLevel);
			return cb_hasZoomLevel;
		}

		static bool n_HasZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_hasZoomLevel;
		public bool HasZoomLevel {
			get {
				if (id_hasZoomLevel == IntPtr.Zero)
					id_hasZoomLevel = JNIEnv.GetMethodID (class_ref, "hasZoomLevel", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_hasZoomLevel);
			}
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
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static float n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IPosition __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getZoomLevel;
		public float ZoomLevel {
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getZoomLevel);
			}
		}

	}

}
