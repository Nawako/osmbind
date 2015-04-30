using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/MyLocationOverlay", DoNotGenerateAcw=true)]
	public partial class MyLocationOverlay : global::Osmdroid.Views.Overlay.Overlay, global::Android.Hardware.ISensorEventListener, global::Android.Locations.ILocationListener, global::Osmdroid.Api.IMyLocationOverlay, global::Osmdroid.Views.Overlay.IOverlayMenuProvider, global::Osmdroid.Views.Overlay.Overlay.ISnappable {


		static IntPtr COMPASS_FRAME_CENTER_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='COMPASS_FRAME_CENTER_X']"
		[Register ("COMPASS_FRAME_CENTER_X")]
		protected float CompassFrameCenterX {
			get {
				if (COMPASS_FRAME_CENTER_X_jfieldId == IntPtr.Zero)
					COMPASS_FRAME_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_FRAME_CENTER_X", "F");
				return JNIEnv.GetFloatField (Handle, COMPASS_FRAME_CENTER_X_jfieldId);
			}
			set {
				if (COMPASS_FRAME_CENTER_X_jfieldId == IntPtr.Zero)
					COMPASS_FRAME_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_FRAME_CENTER_X", "F");
				JNIEnv.SetField (Handle, COMPASS_FRAME_CENTER_X_jfieldId, value);
			}
		}

		static IntPtr COMPASS_FRAME_CENTER_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='COMPASS_FRAME_CENTER_Y']"
		[Register ("COMPASS_FRAME_CENTER_Y")]
		protected float CompassFrameCenterY {
			get {
				if (COMPASS_FRAME_CENTER_Y_jfieldId == IntPtr.Zero)
					COMPASS_FRAME_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_FRAME_CENTER_Y", "F");
				return JNIEnv.GetFloatField (Handle, COMPASS_FRAME_CENTER_Y_jfieldId);
			}
			set {
				if (COMPASS_FRAME_CENTER_Y_jfieldId == IntPtr.Zero)
					COMPASS_FRAME_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_FRAME_CENTER_Y", "F");
				JNIEnv.SetField (Handle, COMPASS_FRAME_CENTER_Y_jfieldId, value);
			}
		}

		static IntPtr COMPASS_ROSE_CENTER_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='COMPASS_ROSE_CENTER_X']"
		[Register ("COMPASS_ROSE_CENTER_X")]
		protected float CompassRoseCenterX {
			get {
				if (COMPASS_ROSE_CENTER_X_jfieldId == IntPtr.Zero)
					COMPASS_ROSE_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_ROSE_CENTER_X", "F");
				return JNIEnv.GetFloatField (Handle, COMPASS_ROSE_CENTER_X_jfieldId);
			}
			set {
				if (COMPASS_ROSE_CENTER_X_jfieldId == IntPtr.Zero)
					COMPASS_ROSE_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_ROSE_CENTER_X", "F");
				JNIEnv.SetField (Handle, COMPASS_ROSE_CENTER_X_jfieldId, value);
			}
		}

		static IntPtr COMPASS_ROSE_CENTER_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='COMPASS_ROSE_CENTER_Y']"
		[Register ("COMPASS_ROSE_CENTER_Y")]
		protected float CompassRoseCenterY {
			get {
				if (COMPASS_ROSE_CENTER_Y_jfieldId == IntPtr.Zero)
					COMPASS_ROSE_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_ROSE_CENTER_Y", "F");
				return JNIEnv.GetFloatField (Handle, COMPASS_ROSE_CENTER_Y_jfieldId);
			}
			set {
				if (COMPASS_ROSE_CENTER_Y_jfieldId == IntPtr.Zero)
					COMPASS_ROSE_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "COMPASS_ROSE_CENTER_Y", "F");
				JNIEnv.SetField (Handle, COMPASS_ROSE_CENTER_Y_jfieldId, value);
			}
		}

		static IntPtr DIRECTION_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='DIRECTION_ARROW']"
		[Register ("DIRECTION_ARROW")]
		protected global::Android.Graphics.Bitmap DirectionArrow {
			get {
				if (DIRECTION_ARROW_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, DIRECTION_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIRECTION_ARROW_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, DIRECTION_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DIRECTION_ARROW_CENTER_X_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='DIRECTION_ARROW_CENTER_X']"
		[Register ("DIRECTION_ARROW_CENTER_X")]
		protected float DirectionArrowCenterX {
			get {
				if (DIRECTION_ARROW_CENTER_X_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW_CENTER_X", "F");
				return JNIEnv.GetFloatField (Handle, DIRECTION_ARROW_CENTER_X_jfieldId);
			}
			set {
				if (DIRECTION_ARROW_CENTER_X_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_CENTER_X_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW_CENTER_X", "F");
				JNIEnv.SetField (Handle, DIRECTION_ARROW_CENTER_X_jfieldId, value);
			}
		}

		static IntPtr DIRECTION_ARROW_CENTER_Y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='DIRECTION_ARROW_CENTER_Y']"
		[Register ("DIRECTION_ARROW_CENTER_Y")]
		protected float DirectionArrowCenterY {
			get {
				if (DIRECTION_ARROW_CENTER_Y_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW_CENTER_Y", "F");
				return JNIEnv.GetFloatField (Handle, DIRECTION_ARROW_CENTER_Y_jfieldId);
			}
			set {
				if (DIRECTION_ARROW_CENTER_Y_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_CENTER_Y_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW_CENTER_Y", "F");
				JNIEnv.SetField (Handle, DIRECTION_ARROW_CENTER_Y_jfieldId, value);
			}
		}

		static IntPtr MENU_COMPASS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='MENU_COMPASS']"
		[Register ("MENU_COMPASS")]
		public static int MenuCompass {
			get {
				if (MENU_COMPASS_jfieldId == IntPtr.Zero)
					MENU_COMPASS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_COMPASS", "I");
				return JNIEnv.GetStaticIntField (class_ref, MENU_COMPASS_jfieldId);
			}
			set {
				if (MENU_COMPASS_jfieldId == IntPtr.Zero)
					MENU_COMPASS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_COMPASS", "I");
				JNIEnv.SetStaticField (class_ref, MENU_COMPASS_jfieldId, value);
			}
		}

		static IntPtr MENU_MY_LOCATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='MENU_MY_LOCATION']"
		[Register ("MENU_MY_LOCATION")]
		public static int MenuMyLocation {
			get {
				if (MENU_MY_LOCATION_jfieldId == IntPtr.Zero)
					MENU_MY_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_MY_LOCATION", "I");
				return JNIEnv.GetStaticIntField (class_ref, MENU_MY_LOCATION_jfieldId);
			}
			set {
				if (MENU_MY_LOCATION_jfieldId == IntPtr.Zero)
					MENU_MY_LOCATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_MY_LOCATION", "I");
				JNIEnv.SetStaticField (class_ref, MENU_MY_LOCATION_jfieldId, value);
			}
		}

		static IntPtr PERSON_HOTSPOT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='PERSON_HOTSPOT']"
		[Register ("PERSON_HOTSPOT")]
		protected global::Android.Graphics.PointF PersonHotspot {
			get {
				if (PERSON_HOTSPOT_jfieldId == IntPtr.Zero)
					PERSON_HOTSPOT_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_HOTSPOT", "Landroid/graphics/PointF;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, PERSON_HOTSPOT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERSON_HOTSPOT_jfieldId == IntPtr.Zero)
					PERSON_HOTSPOT_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_HOTSPOT", "Landroid/graphics/PointF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, PERSON_HOTSPOT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PERSON_ICON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='PERSON_ICON']"
		[Register ("PERSON_ICON")]
		protected global::Android.Graphics.Bitmap PersonIcon {
			get {
				if (PERSON_ICON_jfieldId == IntPtr.Zero)
					PERSON_ICON_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_ICON", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, PERSON_ICON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERSON_ICON_jfieldId == IntPtr.Zero)
					PERSON_ICON_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_ICON", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, PERSON_ICON_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCirclePaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mCirclePaint']"
		[Register ("mCirclePaint")]
		protected global::Android.Graphics.Paint MCirclePaint {
			get {
				if (mCirclePaint_jfieldId == IntPtr.Zero)
					mCirclePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mCirclePaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCirclePaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCirclePaint_jfieldId == IntPtr.Zero)
					mCirclePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mCirclePaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCirclePaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCompassFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mCompassFrame']"
		[Register ("mCompassFrame")]
		protected global::Android.Graphics.Picture MCompassFrame {
			get {
				if (mCompassFrame_jfieldId == IntPtr.Zero)
					mCompassFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrame", "Landroid/graphics/Picture;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCompassFrame_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Picture> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCompassFrame_jfieldId == IntPtr.Zero)
					mCompassFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrame", "Landroid/graphics/Picture;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCompassFrame_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCompassRose_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mCompassRose']"
		[Register ("mCompassRose")]
		protected global::Android.Graphics.Picture MCompassRose {
			get {
				if (mCompassRose_jfieldId == IntPtr.Zero)
					mCompassRose_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRose", "Landroid/graphics/Picture;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCompassRose_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Picture> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCompassRose_jfieldId == IntPtr.Zero)
					mCompassRose_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRose", "Landroid/graphics/Picture;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCompassRose_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDrawAccuracyEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mDrawAccuracyEnabled']"
		[Register ("mDrawAccuracyEnabled")]
		protected bool MDrawAccuracyEnabled {
			get {
				if (mDrawAccuracyEnabled_jfieldId == IntPtr.Zero)
					mDrawAccuracyEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawAccuracyEnabled", "Z");
				return JNIEnv.GetBooleanField (Handle, mDrawAccuracyEnabled_jfieldId);
			}
			set {
				if (mDrawAccuracyEnabled_jfieldId == IntPtr.Zero)
					mDrawAccuracyEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawAccuracyEnabled", "Z");
				JNIEnv.SetField (Handle, mDrawAccuracyEnabled_jfieldId, value);
			}
		}

		static IntPtr mFollow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mFollow']"
		[Register ("mFollow")]
		protected bool MFollow {
			get {
				if (mFollow_jfieldId == IntPtr.Zero)
					mFollow_jfieldId = JNIEnv.GetFieldID (class_ref, "mFollow", "Z");
				return JNIEnv.GetBooleanField (Handle, mFollow_jfieldId);
			}
			set {
				if (mFollow_jfieldId == IntPtr.Zero)
					mFollow_jfieldId = JNIEnv.GetFieldID (class_ref, "mFollow", "Z");
				JNIEnv.SetField (Handle, mFollow_jfieldId, value);
			}
		}

		static IntPtr mLocationListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mLocationListener']"
		[Register ("mLocationListener")]
		public global::Osmdroid.LocationListenerProxy MLocationListener {
			get {
				if (mLocationListener_jfieldId == IntPtr.Zero)
					mLocationListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocationListener", "Lorg/osmdroid/LocationListenerProxy;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocationListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocationListener_jfieldId == IntPtr.Zero)
					mLocationListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocationListener", "Lorg/osmdroid/LocationListenerProxy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLocationListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mMapView']"
		[Register ("mMapView")]
		protected global::Osmdroid.Views.MapView MMapView {
			get {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMapView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMapView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mPaint']"
		[Register ("mPaint")]
		protected global::Android.Graphics.Paint MPaint {
			get {
				if (mPaint_jfieldId == IntPtr.Zero)
					mPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPaint_jfieldId == IntPtr.Zero)
					mPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSensorListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/field[@name='mSensorListener']"
		[Register ("mSensorListener")]
		public global::Osmdroid.SensorEventListenerProxy MSensorListener {
			get {
				if (mSensorListener_jfieldId == IntPtr.Zero)
					mSensorListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSensorListener", "Lorg/osmdroid/SensorEventListenerProxy;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSensorListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.SensorEventListenerProxy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSensorListener_jfieldId == IntPtr.Zero)
					mSensorListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mSensorListener", "Lorg/osmdroid/SensorEventListenerProxy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSensorListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/MyLocationOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyLocationOverlay); }
		}

		protected MyLocationOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/constructor[@name='MyLocationOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", "")]
		public MyLocationOverlay (global::Android.Content.Context ctx, global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MyLocationOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", new JValue (ctx), new JValue (mapView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", new JValue (ctx), new JValue (mapView));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_, new JValue (ctx), new JValue (mapView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_, new JValue (ctx), new JValue (mapView));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/constructor[@name='MyLocationOverlay' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", "")]
		public MyLocationOverlay (global::Android.Content.Context ctx, global::Osmdroid.Views.MapView mapView, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MyLocationOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (ctx), new JValue (mapView), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (ctx), new JValue (mapView), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (ctx), new JValue (mapView), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (ctx), new JValue (mapView), new JValue (pResourceProxy));
		}

		static Delegate cb_isDrawAccuracyEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawAccuracyEnabledHandler ()
		{
			if (cb_isDrawAccuracyEnabled == null)
				cb_isDrawAccuracyEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawAccuracyEnabled);
			return cb_isDrawAccuracyEnabled;
		}

		static bool n_IsDrawAccuracyEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawAccuracyEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDrawAccuracyEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawAccuracyEnabled_ZHandler ()
		{
			if (cb_setDrawAccuracyEnabled_Z == null)
				cb_setDrawAccuracyEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawAccuracyEnabled_Z);
			return cb_setDrawAccuracyEnabled_Z;
		}

		static void n_SetDrawAccuracyEnabled_Z (IntPtr jnienv, IntPtr native__this, bool drawAccuracyEnabled)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawAccuracyEnabled = drawAccuracyEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isDrawAccuracyEnabled;
		static IntPtr id_setDrawAccuracyEnabled_Z;
		public virtual bool DrawAccuracyEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='isDrawAccuracyEnabled' and count(parameter)=0]"
			[Register ("isDrawAccuracyEnabled", "()Z", "GetIsDrawAccuracyEnabledHandler")]
			get {
				if (id_isDrawAccuracyEnabled == IntPtr.Zero)
					id_isDrawAccuracyEnabled = JNIEnv.GetMethodID (class_ref, "isDrawAccuracyEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDrawAccuracyEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawAccuracyEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='setDrawAccuracyEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDrawAccuracyEnabled", "(Z)V", "GetSetDrawAccuracyEnabled_ZHandler")]
			set {
				if (id_setDrawAccuracyEnabled_Z == IntPtr.Zero)
					id_setDrawAccuracyEnabled_Z = JNIEnv.GetMethodID (class_ref, "setDrawAccuracyEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDrawAccuracyEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawAccuracyEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isCompassEnabled;
#pragma warning disable 0169
		static Delegate GetIsCompassEnabledHandler ()
		{
			if (cb_isCompassEnabled == null)
				cb_isCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompassEnabled);
			return cb_isCompassEnabled;
		}

		static bool n_IsCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompassEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isCompassEnabled;
		public virtual bool IsCompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler")]
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isCompassEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCompassEnabled", "()Z"));
			}
		}

		static Delegate cb_isFollowLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsFollowLocationEnabledHandler ()
		{
			if (cb_isFollowLocationEnabled == null)
				cb_isFollowLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFollowLocationEnabled);
			return cb_isFollowLocationEnabled;
		}

		static bool n_IsFollowLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFollowLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isFollowLocationEnabled;
		public virtual bool IsFollowLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='isFollowLocationEnabled' and count(parameter)=0]"
			[Register ("isFollowLocationEnabled", "()Z", "GetIsFollowLocationEnabledHandler")]
			get {
				if (id_isFollowLocationEnabled == IntPtr.Zero)
					id_isFollowLocationEnabled = JNIEnv.GetMethodID (class_ref, "isFollowLocationEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFollowLocationEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFollowLocationEnabled", "()Z"));
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
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMyLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isMyLocationEnabled;
		public virtual bool IsMyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isMyLocationEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMyLocationEnabled", "()Z"));
			}
		}

		static Delegate cb_getLastFix;
#pragma warning disable 0169
		static Delegate GetGetLastFixHandler ()
		{
			if (cb_getLastFix == null)
				cb_getLastFix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastFix);
			return cb_getLastFix;
		}

		static IntPtr n_GetLastFix (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastFix);
		}
#pragma warning restore 0169

		static IntPtr id_getLastFix;
		public virtual global::Android.Locations.Location LastFix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getLastFix' and count(parameter)=0]"
			[Register ("getLastFix", "()Landroid/location/Location;", "GetGetLastFixHandler")]
			get {
				if (id_getLastFix == IntPtr.Zero)
					id_getLastFix = JNIEnv.GetMethodID (class_ref, "getLastFix", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLastFix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastFix", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocationUpdateMinDistance;
#pragma warning disable 0169
		static Delegate GetGetLocationUpdateMinDistanceHandler ()
		{
			if (cb_getLocationUpdateMinDistance == null)
				cb_getLocationUpdateMinDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLocationUpdateMinDistance);
			return cb_getLocationUpdateMinDistance;
		}

		static float n_GetLocationUpdateMinDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationUpdateMinDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationUpdateMinDistance_F;
#pragma warning disable 0169
		static Delegate GetSetLocationUpdateMinDistance_FHandler ()
		{
			if (cb_setLocationUpdateMinDistance_F == null)
				cb_setLocationUpdateMinDistance_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLocationUpdateMinDistance_F);
			return cb_setLocationUpdateMinDistance_F;
		}

		static void n_SetLocationUpdateMinDistance_F (IntPtr jnienv, IntPtr native__this, float meters)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationUpdateMinDistance = meters;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationUpdateMinDistance;
		static IntPtr id_setLocationUpdateMinDistance_F;
		public virtual float LocationUpdateMinDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getLocationUpdateMinDistance' and count(parameter)=0]"
			[Register ("getLocationUpdateMinDistance", "()F", "GetGetLocationUpdateMinDistanceHandler")]
			get {
				if (id_getLocationUpdateMinDistance == IntPtr.Zero)
					id_getLocationUpdateMinDistance = JNIEnv.GetMethodID (class_ref, "getLocationUpdateMinDistance", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLocationUpdateMinDistance);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationUpdateMinDistance", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='setLocationUpdateMinDistance' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLocationUpdateMinDistance", "(F)V", "GetSetLocationUpdateMinDistance_FHandler")]
			set {
				if (id_setLocationUpdateMinDistance_F == IntPtr.Zero)
					id_setLocationUpdateMinDistance_F = JNIEnv.GetMethodID (class_ref, "setLocationUpdateMinDistance", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationUpdateMinDistance_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationUpdateMinDistance", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getLocationUpdateMinTime;
#pragma warning disable 0169
		static Delegate GetGetLocationUpdateMinTimeHandler ()
		{
			if (cb_getLocationUpdateMinTime == null)
				cb_getLocationUpdateMinTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLocationUpdateMinTime);
			return cb_getLocationUpdateMinTime;
		}

		static long n_GetLocationUpdateMinTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationUpdateMinTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationUpdateMinTime_J;
#pragma warning disable 0169
		static Delegate GetSetLocationUpdateMinTime_JHandler ()
		{
			if (cb_setLocationUpdateMinTime_J == null)
				cb_setLocationUpdateMinTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLocationUpdateMinTime_J);
			return cb_setLocationUpdateMinTime_J;
		}

		static void n_SetLocationUpdateMinTime_J (IntPtr jnienv, IntPtr native__this, long milliSeconds)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationUpdateMinTime = milliSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationUpdateMinTime;
		static IntPtr id_setLocationUpdateMinTime_J;
		public virtual long LocationUpdateMinTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getLocationUpdateMinTime' and count(parameter)=0]"
			[Register ("getLocationUpdateMinTime", "()J", "GetGetLocationUpdateMinTimeHandler")]
			get {
				if (id_getLocationUpdateMinTime == IntPtr.Zero)
					id_getLocationUpdateMinTime = JNIEnv.GetMethodID (class_ref, "getLocationUpdateMinTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getLocationUpdateMinTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationUpdateMinTime", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='setLocationUpdateMinTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLocationUpdateMinTime", "(J)V", "GetSetLocationUpdateMinTime_JHandler")]
			set {
				if (id_setLocationUpdateMinTime_J == IntPtr.Zero)
					id_setLocationUpdateMinTime_J = JNIEnv.GetMethodID (class_ref, "setLocationUpdateMinTime", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationUpdateMinTime_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationUpdateMinTime", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_getMyLocation;
#pragma warning disable 0169
		static Delegate GetGetMyLocationHandler ()
		{
			if (cb_getMyLocation == null)
				cb_getMyLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyLocation);
			return cb_getMyLocation;
		}

		static IntPtr n_GetMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocation;
		public virtual global::Org.Osmdroid.Util.GeoPoint MyLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getMyLocation' and count(parameter)=0]"
			[Register ("getMyLocation", "()Lorg/osmdroid/util/GeoPoint;", "GetGetMyLocationHandler")]
			get {
				if (id_getMyLocation == IntPtr.Zero)
					id_getMyLocation = JNIEnv.GetMethodID (class_ref, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isOptionsMenuEnabled;
#pragma warning disable 0169
		static Delegate GetIsOptionsMenuEnabledHandler ()
		{
			if (cb_isOptionsMenuEnabled == null)
				cb_isOptionsMenuEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOptionsMenuEnabled);
			return cb_isOptionsMenuEnabled;
		}

		static bool n_IsOptionsMenuEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OptionsMenuEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setOptionsMenuEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetOptionsMenuEnabled_ZHandler ()
		{
			if (cb_setOptionsMenuEnabled_Z == null)
				cb_setOptionsMenuEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOptionsMenuEnabled_Z);
			return cb_setOptionsMenuEnabled_Z;
		}

		static void n_SetOptionsMenuEnabled_Z (IntPtr jnienv, IntPtr native__this, bool pOptionsMenuEnabled)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptionsMenuEnabled = pOptionsMenuEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isOptionsMenuEnabled;
		static IntPtr id_setOptionsMenuEnabled_Z;
		public virtual bool OptionsMenuEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='isOptionsMenuEnabled' and count(parameter)=0]"
			[Register ("isOptionsMenuEnabled", "()Z", "GetIsOptionsMenuEnabledHandler")]
			get {
				if (id_isOptionsMenuEnabled == IntPtr.Zero)
					id_isOptionsMenuEnabled = JNIEnv.GetMethodID (class_ref, "isOptionsMenuEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOptionsMenuEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptionsMenuEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='setOptionsMenuEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOptionsMenuEnabled", "(Z)V", "GetSetOptionsMenuEnabled_ZHandler")]
			set {
				if (id_setOptionsMenuEnabled_Z == IntPtr.Zero)
					id_setOptionsMenuEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOptionsMenuEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOptionsMenuEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionsMenuEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOrientation);
			return cb_getOrientation;
		}

		static float n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		public virtual float Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()F", "GetGetOrientationHandler")]
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getOrientation);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientation", "()F"));
			}
		}

		static Delegate cb_disableCompass;
#pragma warning disable 0169
		static Delegate GetDisableCompassHandler ()
		{
			if (cb_disableCompass == null)
				cb_disableCompass = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableCompass);
			return cb_disableCompass;
		}

		static void n_DisableCompass (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableCompass ();
		}
#pragma warning restore 0169

		static IntPtr id_disableCompass;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='disableCompass' and count(parameter)=0]"
		[Register ("disableCompass", "()V", "GetDisableCompassHandler")]
		public virtual void DisableCompass ()
		{
			if (id_disableCompass == IntPtr.Zero)
				id_disableCompass = JNIEnv.GetMethodID (class_ref, "disableCompass", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableCompass);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableCompass", "()V"));
		}

		static Delegate cb_disableFollowLocation;
#pragma warning disable 0169
		static Delegate GetDisableFollowLocationHandler ()
		{
			if (cb_disableFollowLocation == null)
				cb_disableFollowLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableFollowLocation);
			return cb_disableFollowLocation;
		}

		static void n_DisableFollowLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableFollowLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_disableFollowLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='disableFollowLocation' and count(parameter)=0]"
		[Register ("disableFollowLocation", "()V", "GetDisableFollowLocationHandler")]
		public virtual void DisableFollowLocation ()
		{
			if (id_disableFollowLocation == IntPtr.Zero)
				id_disableFollowLocation = JNIEnv.GetMethodID (class_ref, "disableFollowLocation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableFollowLocation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableFollowLocation", "()V"));
		}

		static Delegate cb_disableMyLocation;
#pragma warning disable 0169
		static Delegate GetDisableMyLocationHandler ()
		{
			if (cb_disableMyLocation == null)
				cb_disableMyLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableMyLocation);
			return cb_disableMyLocation;
		}

		static void n_DisableMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableMyLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_disableMyLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='disableMyLocation' and count(parameter)=0]"
		[Register ("disableMyLocation", "()V", "GetDisableMyLocationHandler")]
		public virtual void DisableMyLocation ()
		{
			if (id_disableMyLocation == IntPtr.Zero)
				id_disableMyLocation = JNIEnv.GetMethodID (class_ref, "disableMyLocation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableMyLocation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableMyLocation", "()V"));
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_mapView, bool shadow)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas canvas, global::Osmdroid.Views.MapView mapView, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (canvas), new JValue (mapView), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (canvas), new JValue (mapView), new JValue (shadow));
		}

		static Delegate cb_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetDrawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_Handler ()
		{
			if (cb_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_ == null)
				cb_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_DrawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_);
			return cb_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_;
		}

		static void n_DrawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, float bearing, IntPtr native_screenRect)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect screenRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_screenRect, JniHandleOwnership.DoNotTransfer);
			__this.DrawCompass (canvas, bearing, screenRect);
		}
#pragma warning restore 0169

		static IntPtr id_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='drawCompass' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("drawCompass", "(Landroid/graphics/Canvas;FLandroid/graphics/Rect;)V", "GetDrawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_Handler")]
		protected virtual void DrawCompass (global::Android.Graphics.Canvas canvas, float bearing, global::Android.Graphics.Rect screenRect)
		{
			if (id_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_ == IntPtr.Zero)
				id_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "drawCompass", "(Landroid/graphics/Canvas;FLandroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_, new JValue (canvas), new JValue (bearing), new JValue (screenRect));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawCompass", "(Landroid/graphics/Canvas;FLandroid/graphics/Rect;)V"), new JValue (canvas), new JValue (bearing), new JValue (screenRect));
		}

		static Delegate cb_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetDrawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_Handler ()
		{
			if (cb_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_ == null)
				cb_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_);
			return cb_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_;
		}

		static void n_DrawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_mapView, IntPtr native_lastFix)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location lastFix = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_lastFix, JniHandleOwnership.DoNotTransfer);
			__this.DrawMyLocation (canvas, mapView, lastFix);
		}
#pragma warning restore 0169

		static IntPtr id_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='drawMyLocation' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='android.location.Location']]"
		[Register ("drawMyLocation", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Landroid/location/Location;)V", "GetDrawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_Handler")]
		protected virtual void DrawMyLocation (global::Android.Graphics.Canvas canvas, global::Osmdroid.Views.MapView mapView, global::Android.Locations.Location lastFix)
		{
			if (id_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_ == IntPtr.Zero)
				id_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "drawMyLocation", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_, new JValue (canvas), new JValue (mapView), new JValue (lastFix));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawMyLocation", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Landroid/location/Location;)V"), new JValue (canvas), new JValue (mapView), new JValue (lastFix));
		}

		static Delegate cb_enableCompass;
#pragma warning disable 0169
		static Delegate GetEnableCompassHandler ()
		{
			if (cb_enableCompass == null)
				cb_enableCompass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableCompass);
			return cb_enableCompass;
		}

		static bool n_EnableCompass (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCompass ();
		}
#pragma warning restore 0169

		static IntPtr id_enableCompass;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='enableCompass' and count(parameter)=0]"
		[Register ("enableCompass", "()Z", "GetEnableCompassHandler")]
		public virtual bool EnableCompass ()
		{
			if (id_enableCompass == IntPtr.Zero)
				id_enableCompass = JNIEnv.GetMethodID (class_ref, "enableCompass", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_enableCompass);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableCompass", "()Z"));
		}

		static Delegate cb_enableFollowLocation;
#pragma warning disable 0169
		static Delegate GetEnableFollowLocationHandler ()
		{
			if (cb_enableFollowLocation == null)
				cb_enableFollowLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableFollowLocation);
			return cb_enableFollowLocation;
		}

		static void n_EnableFollowLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableFollowLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_enableFollowLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='enableFollowLocation' and count(parameter)=0]"
		[Register ("enableFollowLocation", "()V", "GetEnableFollowLocationHandler")]
		public virtual void EnableFollowLocation ()
		{
			if (id_enableFollowLocation == IntPtr.Zero)
				id_enableFollowLocation = JNIEnv.GetMethodID (class_ref, "enableFollowLocation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableFollowLocation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableFollowLocation", "()V"));
		}

		static Delegate cb_enableMyLocation;
#pragma warning disable 0169
		static Delegate GetEnableMyLocationHandler ()
		{
			if (cb_enableMyLocation == null)
				cb_enableMyLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableMyLocation);
			return cb_enableMyLocation;
		}

		static bool n_EnableMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableMyLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_enableMyLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='enableMyLocation' and count(parameter)=0]"
		[Register ("enableMyLocation", "()Z", "GetEnableMyLocationHandler")]
		public virtual bool EnableMyLocation ()
		{
			if (id_enableMyLocation == IntPtr.Zero)
				id_enableMyLocation = JNIEnv.GetMethodID (class_ref, "enableMyLocation", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_enableMyLocation);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableMyLocation", "()Z"));
		}

		static Delegate cb_followLocation_Z;
#pragma warning disable 0169
		static Delegate GetFollowLocation_ZHandler ()
		{
			if (cb_followLocation_Z == null)
				cb_followLocation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_FollowLocation_Z);
			return cb_followLocation_Z;
		}

		static void n_FollowLocation_Z (IntPtr jnienv, IntPtr native__this, bool follow)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FollowLocation (follow);
		}
#pragma warning restore 0169

		static IntPtr id_followLocation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='followLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("followLocation", "(Z)V", "GetFollowLocation_ZHandler")]
		public virtual void FollowLocation (bool follow)
		{
			if (id_followLocation_Z == IntPtr.Zero)
				id_followLocation_Z = JNIEnv.GetMethodID (class_ref, "followLocation", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_followLocation_Z, new JValue (follow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "followLocation", "(Z)V"), new JValue (follow));
		}

		static Delegate cb_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_ == null)
				cb_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_);
			return cb_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_;
		}

		static IntPtr n_GetMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, int zoomLevel, IntPtr native_lastFix, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location lastFix = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_lastFix, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMyLocationDrawingBounds (zoomLevel, lastFix, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='getMyLocationDrawingBounds' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.location.Location'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("getMyLocationDrawingBounds", "(ILandroid/location/Location;Landroid/graphics/Rect;)Landroid/graphics/Rect;", "GetGetMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_Handler")]
		protected virtual global::Android.Graphics.Rect GetMyLocationDrawingBounds (int zoomLevel, global::Android.Locations.Location lastFix, global::Android.Graphics.Rect reuse)
		{
			if (id_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "getMyLocationDrawingBounds", "(ILandroid/location/Location;Landroid/graphics/Rect;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_, new JValue (zoomLevel), new JValue (lastFix), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyLocationDrawingBounds", "(ILandroid/location/Location;Landroid/graphics/Rect;)Landroid/graphics/Rect;"), new JValue (zoomLevel), new JValue (lastFix), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0, int native_arg1)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor arg0 = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_arg0, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus arg1 = (global::Android.Hardware.SensorStatus) native_arg1;
			__this.OnAccuracyChanged (arg0, arg1);
		}
#pragma warning restore 0169

		static IntPtr id_onAccuracyChanged_Landroid_hardware_Sensor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual void OnAccuracyChanged (global::Android.Hardware.Sensor arg0, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus arg1)
		{
			if (id_onAccuracyChanged_Landroid_hardware_Sensor_I == IntPtr.Zero)
				id_onAccuracyChanged_Landroid_hardware_Sensor_I = JNIEnv.GetMethodID (class_ref, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAccuracyChanged_Landroid_hardware_Sensor_I, new JValue (arg0), new JValue ((int) arg1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V"), new JValue (arg0), new JValue ((int) arg1));
		}

		static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == null)
				cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_);
			return cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		}

		static bool n_OnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pMenu, int pMenuIdOffset, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnCreateOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z"), new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (location);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual void OnLocationChanged (global::Android.Locations.Location location)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (location));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), new JValue (location));
		}

		static Delegate cb_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ == null)
				cb_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_);
			return cb_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		}

		static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pItem, int pMenuIdOffset, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem pItem = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_pItem, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (pItem, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnOptionsItemSelected (global::Android.Views.IMenuItem pItem, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_, new JValue (pItem), new JValue (pMenuIdOffset), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z"), new JValue (pItem), new JValue (pMenuIdOffset), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == null)
				cb_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_);
			return cb_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		}

		static bool n_OnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pMenu, int pMenuIdOffset, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnPrepareOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z"), new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderDisabled_Ljava_lang_String_ == null)
				cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
			return cb_onProviderDisabled_Ljava_lang_String_;
		}

		static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderDisabled (provider);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderDisabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onProviderDisabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderDisabled (string provider)
		{
			if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderDisabled_Ljava_lang_String_, new JValue (native_provider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderDisabled", "(Ljava/lang/String;)V"), new JValue (native_provider));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderEnabled_Ljava_lang_String_ == null)
				cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
			return cb_onProviderEnabled_Ljava_lang_String_;
		}

		static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderEnabled (provider);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onProviderEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderEnabled (string provider)
		{
			if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderEnabled_Ljava_lang_String_, new JValue (native_provider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderEnabled", "(Ljava/lang/String;)V"), new JValue (native_provider));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent e = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (e);
		}
#pragma warning restore 0169

		static IntPtr id_onSensorChanged_Landroid_hardware_SensorEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			if (id_onSensorChanged_Landroid_hardware_SensorEvent_ == IntPtr.Zero)
				id_onSensorChanged_Landroid_hardware_SensorEvent_ = JNIEnv.GetMethodID (class_ref, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSensorChanged_Landroid_hardware_SensorEvent_, new JValue (e));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V"), new JValue (e));
		}

		static Delegate cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
#pragma warning disable 0169
		static Delegate GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler ()
		{
			if (cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == null)
				cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, bool>) n_OnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_);
			return cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		}

		static bool n_OnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_snapPoint, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point snapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_snapPoint, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IMapView mapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSnapToItem (x, y, snapPoint, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
		[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler")]
		public virtual bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView mapView)
		{
			if (id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == IntPtr.Zero)
				id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNIEnv.GetMethodID (class_ref, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_, new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z"), new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider, int native_status, IntPtr native_extras)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability status = (global::Android.Locations.Availability) native_status;
			global::Android.OS.Bundle extras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_extras, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (provider, status, extras);
		}
#pragma warning restore 0169

		static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual void OnStatusChanged (string provider, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability status, global::Android.OS.Bundle extras)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_provider), new JValue ((int) status), new JValue (extras));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"), new JValue (native_provider), new JValue ((int) status), new JValue (extras));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_runOnFirstFix_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnFirstFix_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnFirstFix_Ljava_lang_Runnable_ == null)
				cb_runOnFirstFix_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RunOnFirstFix_Ljava_lang_Runnable_);
			return cb_runOnFirstFix_Ljava_lang_Runnable_;
		}

		static bool n_RunOnFirstFix_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RunOnFirstFix (runnable);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_runOnFirstFix_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='runOnFirstFix' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnFirstFix", "(Ljava/lang/Runnable;)Z", "GetRunOnFirstFix_Ljava_lang_Runnable_Handler")]
		public virtual bool RunOnFirstFix (global::Java.Lang.IRunnable runnable)
		{
			if (id_runOnFirstFix_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnFirstFix_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnFirstFix", "(Ljava/lang/Runnable;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_runOnFirstFix_Ljava_lang_Runnable_, new JValue (runnable));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnFirstFix", "(Ljava/lang/Runnable;)Z"), new JValue (runnable));
			return __ret;
		}

		static Delegate cb_setCompassCenter_FF;
#pragma warning disable 0169
		static Delegate GetSetCompassCenter_FFHandler ()
		{
			if (cb_setCompassCenter_FF == null)
				cb_setCompassCenter_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetCompassCenter_FF);
			return cb_setCompassCenter_FF;
		}

		static void n_SetCompassCenter_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::Osmdroid.Views.Overlay.MyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCompassCenter (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_setCompassCenter_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MyLocationOverlay']/method[@name='setCompassCenter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setCompassCenter", "(FF)V", "GetSetCompassCenter_FFHandler")]
		public virtual void SetCompassCenter (float x, float y)
		{
			if (id_setCompassCenter_FF == IntPtr.Zero)
				id_setCompassCenter_FF = JNIEnv.GetMethodID (class_ref, "setCompassCenter", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCompassCenter_FF, new JValue (x), new JValue (y));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompassCenter", "(FF)V"), new JValue (x), new JValue (y));
		}

	}
}
