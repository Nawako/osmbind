using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']"
	[Register ("org/osmdroid/api/IMap", "", "Osmdroid.Api.IMapInvoker")]
	public partial interface IMap : IJavaObject {

		float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] set;
		}

		global::Osmdroid.Api.IGeoPoint Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetCenterHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] get;
		}

		bool MyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] set;
		}

		global::Osmdroid.Api.IProjection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lorg/osmdroid/api/IProjection;", "GetGetProjectionHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] get;
		}

		float ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()F", "GetGetZoomLevelHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.Marker']]"
		[Register ("addMarker", "(Lorg/osmdroid/api/Marker;)V", "GetAddMarker_Lorg_osmdroid_api_Marker_Handler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void AddMarker (global::Osmdroid.Api.Marker marker);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='addPointsToPolyline' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.api.IGeoPoint...']]"
		[Register ("addPointsToPolyline", "(I[Lorg/osmdroid/api/IGeoPoint;)V", "GetAddPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_Handler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void AddPointsToPolyline (int id, params global:: Osmdroid.Api.IGeoPoint[] points);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.Polyline']]"
		[Register ("addPolyline", "(Lorg/osmdroid/api/Polyline;)I", "GetAddPolyline_Lorg_osmdroid_api_Polyline_Handler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		int AddPolyline (global::Osmdroid.Api.Polyline polyline);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='clearPolyline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clearPolyline", "(I)V", "GetClearPolyline_IHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void ClearPolyline (int id);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setCenter' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("setCenter", "(DD)V", "GetSetCenter_DDHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void SetCenter (double latitude, double longitude);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setOnCameraChangeListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.OnCameraChangeListener']]"
		[Register ("setOnCameraChangeListener", "(Lorg/osmdroid/api/OnCameraChangeListener;)V", "GetSetOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_Handler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void SetOnCameraChangeListener (global::Osmdroid.Api.IOnCameraChangeListener listener);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IPosition']]"
		[Register ("setPosition", "(Lorg/osmdroid/api/IPosition;)V", "GetSetPosition_Lorg_osmdroid_api_IPosition_Handler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void SetPosition (global::Osmdroid.Api.IPosition position);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setZoom", "(F)V", "GetSetZoom_FHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		void SetZoom (float zoomLevel);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Z", "GetZoomInHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		bool ZoomIn ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMap']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Z", "GetZoomOutHandler:Osmdroid.Api.IMapInvoker, OsmdroidAndroidBinding")]
		bool ZoomOut ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IMap", DoNotGenerateAcw=true)]
	internal class IMapInvoker : global::Java.Lang.Object, IMap {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IMap");
		IntPtr class_ref;

		public static IMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IMap"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapInvoker); }
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
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		static Delegate cb_setBearing_F;
#pragma warning disable 0169
		static Delegate GetSetBearing_FHandler ()
		{
			if (cb_setBearing_F == null)
				cb_setBearing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBearing_F);
			return cb_setBearing_F;
		}

		static void n_SetBearing_F (IntPtr jnienv, IntPtr native__this, float bearing)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bearing = bearing;
		}
#pragma warning restore 0169

		IntPtr id_getBearing;
		IntPtr id_setBearing_F;
		public float Bearing {
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getBearing);
			}
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");
				JNIEnv.CallVoidMethod (Handle, id_setBearing_F, new JValue (value));
			}
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		IntPtr id_getCenter;
		public global::Osmdroid.Api.IGeoPoint Center {
			get {
				if (id_getCenter == IntPtr.Zero)
					id_getCenter = JNIEnv.GetMethodID (class_ref, "getCenter", "()Lorg/osmdroid/api/IGeoPoint;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod (Handle, id_getCenter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isMyLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsMyLocationEnabledHandler ()
		{
			if (cb_isMyLocationEnabled == null)
				cb_isMyLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationEnabled);
			return cb_isMyLocationEnabled;
		}

		static bool n_IsMyLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MyLocationEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setMyLocationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetMyLocationEnabled_ZHandler ()
		{
			if (cb_setMyLocationEnabled_Z == null)
				cb_setMyLocationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMyLocationEnabled_Z);
			return cb_setMyLocationEnabled_Z;
		}

		static void n_SetMyLocationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MyLocationEnabled = enabled;
		}
#pragma warning restore 0169

		IntPtr id_isMyLocationEnabled;
		IntPtr id_setMyLocationEnabled_Z;
		public bool MyLocationEnabled {
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isMyLocationEnabled);
			}
			set {
				if (id_setMyLocationEnabled_Z == IntPtr.Zero)
					id_setMyLocationEnabled_Z = JNIEnv.GetMethodID (class_ref, "setMyLocationEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setMyLocationEnabled_Z, new JValue (value));
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
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static float n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_addMarker_Lorg_osmdroid_api_Marker_;
#pragma warning disable 0169
		static Delegate GetAddMarker_Lorg_osmdroid_api_Marker_Handler ()
		{
			if (cb_addMarker_Lorg_osmdroid_api_Marker_ == null)
				cb_addMarker_Lorg_osmdroid_api_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMarker_Lorg_osmdroid_api_Marker_);
			return cb_addMarker_Lorg_osmdroid_api_Marker_;
		}

		static void n_AddMarker_Lorg_osmdroid_api_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.Marker marker = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.AddMarker (marker);
		}
#pragma warning restore 0169

		IntPtr id_addMarker_Lorg_osmdroid_api_Marker_;
		public void AddMarker (global::Osmdroid.Api.Marker marker)
		{
			if (id_addMarker_Lorg_osmdroid_api_Marker_ == IntPtr.Zero)
				id_addMarker_Lorg_osmdroid_api_Marker_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Lorg/osmdroid/api/Marker;)V");
			JNIEnv.CallVoidMethod (Handle, id_addMarker_Lorg_osmdroid_api_Marker_, new JValue (marker));
		}

		static Delegate cb_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetAddPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_ == null)
				cb_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_);
			return cb_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_;
		}

		static void n_AddPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native_points)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint[] points = (global::Osmdroid.Api.IGeoPoint[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (global::Osmdroid.Api.IGeoPoint));
			__this.AddPointsToPolyline (id, points);
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
		}
#pragma warning restore 0169

		IntPtr id_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_;
		public void AddPointsToPolyline (int id, params global:: Osmdroid.Api.IGeoPoint[] points)
		{
			if (id_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "addPointsToPolyline", "(I[Lorg/osmdroid/api/IGeoPoint;)V");
			IntPtr native_points = JNIEnv.NewArray (points);
			JNIEnv.CallVoidMethod (Handle, id_addPointsToPolyline_IarrayLorg_osmdroid_api_IGeoPoint_, new JValue (id), new JValue (native_points));
			if (points != null) {
				JNIEnv.CopyArray (native_points, points);
				JNIEnv.DeleteLocalRef (native_points);
			}
		}

		static Delegate cb_addPolyline_Lorg_osmdroid_api_Polyline_;
#pragma warning disable 0169
		static Delegate GetAddPolyline_Lorg_osmdroid_api_Polyline_Handler ()
		{
			if (cb_addPolyline_Lorg_osmdroid_api_Polyline_ == null)
				cb_addPolyline_Lorg_osmdroid_api_Polyline_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_AddPolyline_Lorg_osmdroid_api_Polyline_);
			return cb_addPolyline_Lorg_osmdroid_api_Polyline_;
		}

		static int n_AddPolyline_Lorg_osmdroid_api_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_polyline)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.Polyline polyline = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (native_polyline, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AddPolyline (polyline);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addPolyline_Lorg_osmdroid_api_Polyline_;
		public int AddPolyline (global::Osmdroid.Api.Polyline polyline)
		{
			if (id_addPolyline_Lorg_osmdroid_api_Polyline_ == IntPtr.Zero)
				id_addPolyline_Lorg_osmdroid_api_Polyline_ = JNIEnv.GetMethodID (class_ref, "addPolyline", "(Lorg/osmdroid/api/Polyline;)I");
			int __ret = JNIEnv.CallIntMethod (Handle, id_addPolyline_Lorg_osmdroid_api_Polyline_, new JValue (polyline));
			return __ret;
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (Handle, id_clear);
		}

		static Delegate cb_clearPolyline_I;
#pragma warning disable 0169
		static Delegate GetClearPolyline_IHandler ()
		{
			if (cb_clearPolyline_I == null)
				cb_clearPolyline_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_ClearPolyline_I);
			return cb_clearPolyline_I;
		}

		static void n_ClearPolyline_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPolyline (id);
		}
#pragma warning restore 0169

		IntPtr id_clearPolyline_I;
		public void ClearPolyline (int id)
		{
			if (id_clearPolyline_I == IntPtr.Zero)
				id_clearPolyline_I = JNIEnv.GetMethodID (class_ref, "clearPolyline", "(I)V");
			JNIEnv.CallVoidMethod (Handle, id_clearPolyline_I, new JValue (id));
		}

		static Delegate cb_setCenter_DD;
#pragma warning disable 0169
		static Delegate GetSetCenter_DDHandler ()
		{
			if (cb_setCenter_DD == null)
				cb_setCenter_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_SetCenter_DD);
			return cb_setCenter_DD;
		}

		static void n_SetCenter_DD (IntPtr jnienv, IntPtr native__this, double latitude, double longitude)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (latitude, longitude);
		}
#pragma warning restore 0169

		IntPtr id_setCenter_DD;
		public void SetCenter (double latitude, double longitude)
		{
			if (id_setCenter_DD == IntPtr.Zero)
				id_setCenter_DD = JNIEnv.GetMethodID (class_ref, "setCenter", "(DD)V");
			JNIEnv.CallVoidMethod (Handle, id_setCenter_DD, new JValue (latitude), new JValue (longitude));
		}

		static Delegate cb_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_Handler ()
		{
			if (cb_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_ == null)
				cb_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_);
			return cb_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_;
		}

		static void n_SetOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IOnCameraChangeListener listener = (global::Osmdroid.Api.IOnCameraChangeListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IOnCameraChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnCameraChangeListener (listener);
		}
#pragma warning restore 0169

		IntPtr id_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_;
		public void SetOnCameraChangeListener (global::Osmdroid.Api.IOnCameraChangeListener listener)
		{
			if (id_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_ == IntPtr.Zero)
				id_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnCameraChangeListener", "(Lorg/osmdroid/api/OnCameraChangeListener;)V");
			JNIEnv.CallVoidMethod (Handle, id_setOnCameraChangeListener_Lorg_osmdroid_api_OnCameraChangeListener_, new JValue (listener));
		}

		static Delegate cb_setPosition_Lorg_osmdroid_api_IPosition_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lorg_osmdroid_api_IPosition_Handler ()
		{
			if (cb_setPosition_Lorg_osmdroid_api_IPosition_ == null)
				cb_setPosition_Lorg_osmdroid_api_IPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lorg_osmdroid_api_IPosition_);
			return cb_setPosition_Lorg_osmdroid_api_IPosition_;
		}

		static void n_SetPosition_Lorg_osmdroid_api_IPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IPosition position = (global::Osmdroid.Api.IPosition)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (position);
		}
#pragma warning restore 0169

		IntPtr id_setPosition_Lorg_osmdroid_api_IPosition_;
		public void SetPosition (global::Osmdroid.Api.IPosition position)
		{
			if (id_setPosition_Lorg_osmdroid_api_IPosition_ == IntPtr.Zero)
				id_setPosition_Lorg_osmdroid_api_IPosition_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lorg/osmdroid/api/IPosition;)V");
			JNIEnv.CallVoidMethod (Handle, id_setPosition_Lorg_osmdroid_api_IPosition_, new JValue (position));
		}

		static Delegate cb_setZoom_F;
#pragma warning disable 0169
		static Delegate GetSetZoom_FHandler ()
		{
			if (cb_setZoom_F == null)
				cb_setZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoom_F);
			return cb_setZoom_F;
		}

		static void n_SetZoom_F (IntPtr jnienv, IntPtr native__this, float zoomLevel)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (zoomLevel);
		}
#pragma warning restore 0169

		IntPtr id_setZoom_F;
		public void SetZoom (float zoomLevel)
		{
			if (id_setZoom_F == IntPtr.Zero)
				id_setZoom_F = JNIEnv.GetMethodID (class_ref, "setZoom", "(F)V");
			JNIEnv.CallVoidMethod (Handle, id_setZoom_F, new JValue (zoomLevel));
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomIn);
			return cb_zoomIn;
		}

		static bool n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomIn ();
		}
#pragma warning restore 0169

		IntPtr id_zoomIn;
		public bool ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomIn);
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomOut);
			return cb_zoomOut;
		}

		static bool n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMap __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOut ();
		}
#pragma warning restore 0169

		IntPtr id_zoomOut;
		public bool ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomOut);
		}

	}

}
