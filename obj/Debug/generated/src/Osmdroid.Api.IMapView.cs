using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']"
	[Register ("org/osmdroid/api/IMapView", "", "Osmdroid.Api.IMapViewInvoker")]
	public partial interface IMapView : IJavaObject {

		global::Osmdroid.Api.IMapController Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lorg/osmdroid/api/IMapController;", "GetGetControllerHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()I", "GetGetLatitudeSpanHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()I", "GetGetLongitudeSpanHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		global::Osmdroid.Api.IGeoPoint MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getMapCenter' and count(parameter)=0]"
			[Register ("getMapCenter", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetMapCenterHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		int MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()I", "GetGetMaxZoomLevelHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		global::Osmdroid.Api.IProjection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lorg/osmdroid/api/IProjection;", "GetGetProjectionHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapView']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler:Osmdroid.Api.IMapViewInvoker, OsmdroidAndroidBinding")]
		void SetBackgroundColor ([global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Color color);

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IMapView", DoNotGenerateAcw=true)]
	internal class IMapViewInvoker : global::Java.Lang.Object, IMapView {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IMapView");
		IntPtr class_ref;

		public static IMapView GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapView> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IMapView"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapViewInvoker); }
		}

		static Delegate cb_getController;
#pragma warning disable 0169
		static Delegate GetGetControllerHandler ()
		{
			if (cb_getController == null)
				cb_getController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetController);
			return cb_getController;
		}

		static IntPtr n_GetController (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Controller);
		}
#pragma warning restore 0169

		IntPtr id_getController;
		public global::Osmdroid.Api.IMapController Controller {
			get {
				if (id_getController == IntPtr.Zero)
					id_getController = JNIEnv.GetMethodID (class_ref, "getController", "()Lorg/osmdroid/api/IMapController;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (JNIEnv.CallObjectMethod (Handle, id_getController), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static int n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		IntPtr id_getLatitudeSpan;
		public int LatitudeSpan {
			get {
				if (id_getLatitudeSpan == IntPtr.Zero)
					id_getLatitudeSpan = JNIEnv.GetMethodID (class_ref, "getLatitudeSpan", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLatitudeSpan);
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static int n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		IntPtr id_getLongitudeSpan;
		public int LongitudeSpan {
			get {
				if (id_getLongitudeSpan == IntPtr.Zero)
					id_getLongitudeSpan = JNIEnv.GetMethodID (class_ref, "getLongitudeSpan", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getLongitudeSpan);
			}
		}

		static Delegate cb_getMapCenter;
#pragma warning disable 0169
		static Delegate GetGetMapCenterHandler ()
		{
			if (cb_getMapCenter == null)
				cb_getMapCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapCenter);
			return cb_getMapCenter;
		}

		static IntPtr n_GetMapCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		IntPtr id_getMapCenter;
		public global::Osmdroid.Api.IGeoPoint MapCenter {
			get {
				if (id_getMapCenter == IntPtr.Zero)
					id_getMapCenter = JNIEnv.GetMethodID (class_ref, "getMapCenter", "()Lorg/osmdroid/api/IGeoPoint;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod (Handle, id_getMapCenter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMaxZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomLevelHandler ()
		{
			if (cb_getMaxZoomLevel == null)
				cb_getMaxZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxZoomLevel);
			return cb_getMaxZoomLevel;
		}

		static int n_GetMaxZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMaxZoomLevel;
		public int MaxZoomLevel {
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMaxZoomLevel);
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		IntPtr id_getProjection;
		public global::Osmdroid.Api.IProjection Projection {
			get {
				if (id_getProjection == IntPtr.Zero)
					id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()Lorg/osmdroid/api/IProjection;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (JNIEnv.CallObjectMethod (Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getZoomLevel;
		public int ZoomLevel {
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getZoomLevel);
			}
		}

		static Delegate cb_setBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IHandler ()
		{
			if (cb_setBackgroundColor_I == null)
				cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundColor_I);
			return cb_setBackgroundColor_I;
		}

		static void n_SetBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int native_color)
		{
			global::Osmdroid.Api.IMapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Color color = new global::Android.Graphics.Color (native_color);
			__this.SetBackgroundColor (color);
		}
#pragma warning restore 0169

		IntPtr id_setBackgroundColor_I;
		public void SetBackgroundColor ([global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Color color)
		{
			if (id_setBackgroundColor_I == IntPtr.Zero)
				id_setBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setBackgroundColor", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_setBackgroundColor_I, new JValue (color.ToArgb ()));
		}

	}

}
