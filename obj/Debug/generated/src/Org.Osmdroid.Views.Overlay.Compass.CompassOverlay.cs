using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Overlay.Compass {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/compass/CompassOverlay", DoNotGenerateAcw=true)]
	public partial class CompassOverlay : global::Osmdroid.Views.Overlay.Overlay, global::Osmdroid.Views.Overlay.IOverlayMenuProvider, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer {


		static IntPtr MENU_COMPASS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='MENU_COMPASS']"
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

		static IntPtr mCompassFrameBitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassFrameBitmap']"
		[Register ("mCompassFrameBitmap")]
		protected global::Android.Graphics.Bitmap MCompassFrameBitmap {
			get {
				if (mCompassFrameBitmap_jfieldId == IntPtr.Zero)
					mCompassFrameBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameBitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCompassFrameBitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCompassFrameBitmap_jfieldId == IntPtr.Zero)
					mCompassFrameBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameBitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCompassFrameBitmap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCompassFrameCenterX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassFrameCenterX']"
		[Register ("mCompassFrameCenterX")]
		protected float MCompassFrameCenterX {
			get {
				if (mCompassFrameCenterX_jfieldId == IntPtr.Zero)
					mCompassFrameCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameCenterX", "F");
				return JNIEnv.GetFloatField (Handle, mCompassFrameCenterX_jfieldId);
			}
			set {
				if (mCompassFrameCenterX_jfieldId == IntPtr.Zero)
					mCompassFrameCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameCenterX", "F");
				JNIEnv.SetField (Handle, mCompassFrameCenterX_jfieldId, value);
			}
		}

		static IntPtr mCompassFrameCenterY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassFrameCenterY']"
		[Register ("mCompassFrameCenterY")]
		protected float MCompassFrameCenterY {
			get {
				if (mCompassFrameCenterY_jfieldId == IntPtr.Zero)
					mCompassFrameCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameCenterY", "F");
				return JNIEnv.GetFloatField (Handle, mCompassFrameCenterY_jfieldId);
			}
			set {
				if (mCompassFrameCenterY_jfieldId == IntPtr.Zero)
					mCompassFrameCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassFrameCenterY", "F");
				JNIEnv.SetField (Handle, mCompassFrameCenterY_jfieldId, value);
			}
		}

		static IntPtr mCompassRoseBitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassRoseBitmap']"
		[Register ("mCompassRoseBitmap")]
		protected global::Android.Graphics.Bitmap MCompassRoseBitmap {
			get {
				if (mCompassRoseBitmap_jfieldId == IntPtr.Zero)
					mCompassRoseBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseBitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCompassRoseBitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCompassRoseBitmap_jfieldId == IntPtr.Zero)
					mCompassRoseBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseBitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCompassRoseBitmap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCompassRoseCenterX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassRoseCenterX']"
		[Register ("mCompassRoseCenterX")]
		protected float MCompassRoseCenterX {
			get {
				if (mCompassRoseCenterX_jfieldId == IntPtr.Zero)
					mCompassRoseCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseCenterX", "F");
				return JNIEnv.GetFloatField (Handle, mCompassRoseCenterX_jfieldId);
			}
			set {
				if (mCompassRoseCenterX_jfieldId == IntPtr.Zero)
					mCompassRoseCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseCenterX", "F");
				JNIEnv.SetField (Handle, mCompassRoseCenterX_jfieldId, value);
			}
		}

		static IntPtr mCompassRoseCenterY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mCompassRoseCenterY']"
		[Register ("mCompassRoseCenterY")]
		protected float MCompassRoseCenterY {
			get {
				if (mCompassRoseCenterY_jfieldId == IntPtr.Zero)
					mCompassRoseCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseCenterY", "F");
				return JNIEnv.GetFloatField (Handle, mCompassRoseCenterY_jfieldId);
			}
			set {
				if (mCompassRoseCenterY_jfieldId == IntPtr.Zero)
					mCompassRoseCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mCompassRoseCenterY", "F");
				JNIEnv.SetField (Handle, mCompassRoseCenterY_jfieldId, value);
			}
		}

		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mMapView']"
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

		static IntPtr mOrientationProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mOrientationProvider']"
		[Register ("mOrientationProvider")]
		public global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider MOrientationProvider {
			get {
				if (mOrientationProvider_jfieldId == IntPtr.Zero)
					mOrientationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mOrientationProvider", "Lorg/osmdroid/views/overlay/compass/IOrientationProvider;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOrientationProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOrientationProvider_jfieldId == IntPtr.Zero)
					mOrientationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mOrientationProvider", "Lorg/osmdroid/views/overlay/compass/IOrientationProvider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOrientationProvider_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/field[@name='mPaint']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/compass/CompassOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompassOverlay); }
		}

		protected CompassOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/constructor[@name='CompassOverlay' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.overlay.compass.IOrientationProvider'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;)V", "")]
		public CompassOverlay (global::Android.Content.Context context, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider, global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CompassOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (orientationProvider), new JValue (mapView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (orientationProvider), new JValue (mapView));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (orientationProvider), new JValue (mapView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (orientationProvider), new JValue (mapView));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/constructor[@name='CompassOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", "")]
		public CompassOverlay (global::Android.Content.Context context, global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CompassOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (mapView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (mapView));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (mapView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (mapView));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/constructor[@name='CompassOverlay' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.overlay.compass.IOrientationProvider'] and parameter[3][@type='org.osmdroid.views.MapView'] and parameter[4][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", "")]
		public CompassOverlay (global::Android.Content.Context context, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider, global::Osmdroid.Views.MapView mapView, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CompassOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (orientationProvider), new JValue (mapView), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (orientationProvider), new JValue (mapView), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/compass/IOrientationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (orientationProvider), new JValue (mapView), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (orientationProvider), new JValue (mapView), new JValue (pResourceProxy));
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompassEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isCompassEnabled;
		public virtual bool IsCompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='isCompassEnabled' and count(parameter)=0]"
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptionsMenuEnabled = pOptionsMenuEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isOptionsMenuEnabled;
		static IntPtr id_setOptionsMenuEnabled_Z;
		public virtual bool OptionsMenuEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='isOptionsMenuEnabled' and count(parameter)=0]"
			[Register ("isOptionsMenuEnabled", "()Z", "GetIsOptionsMenuEnabledHandler")]
			get {
				if (id_isOptionsMenuEnabled == IntPtr.Zero)
					id_isOptionsMenuEnabled = JNIEnv.GetMethodID (class_ref, "isOptionsMenuEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOptionsMenuEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptionsMenuEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='setOptionsMenuEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		static IntPtr id_getOrientation;
		public virtual float Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='getOrientation' and count(parameter)=0]"
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

		static Delegate cb_getOrientationProvider;
#pragma warning disable 0169
		static Delegate GetGetOrientationProviderHandler ()
		{
			if (cb_getOrientationProvider == null)
				cb_getOrientationProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientationProvider);
			return cb_getOrientationProvider;
		}

		static IntPtr n_GetOrientationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrientationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getOrientationProvider;
		public virtual global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider OrientationProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='getOrientationProvider' and count(parameter)=0]"
			[Register ("getOrientationProvider", "()Lorg/osmdroid/views/overlay/compass/IOrientationProvider;", "GetGetOrientationProviderHandler")]
			get {
				if (id_getOrientationProvider == IntPtr.Zero)
					id_getOrientationProvider = JNIEnv.GetMethodID (class_ref, "getOrientationProvider", "()Lorg/osmdroid/views/overlay/compass/IOrientationProvider;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (JNIEnv.CallObjectMethod  (Handle, id_getOrientationProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrientationProvider", "()Lorg/osmdroid/views/overlay/compass/IOrientationProvider;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableCompass ();
		}
#pragma warning restore 0169

		static IntPtr id_disableCompass;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='disableCompass' and count(parameter)=0]"
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

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_mapView, bool shadow)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView mapView, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (mapView), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (mapView), new JValue (shadow));
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect screenRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_screenRect, JniHandleOwnership.DoNotTransfer);
			__this.DrawCompass (canvas, bearing, screenRect);
		}
#pragma warning restore 0169

		static IntPtr id_drawCompass_Landroid_graphics_Canvas_FLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='drawCompass' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Rect']]"
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCompass ();
		}
#pragma warning restore 0169

		static IntPtr id_enableCompass;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='enableCompass' and count(parameter)=0]"
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

		static Delegate cb_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
#pragma warning disable 0169
		static Delegate GetEnableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler ()
		{
			if (cb_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ == null)
				cb_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EnableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_);
			return cb_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		}

		static bool n_EnableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orientationProvider)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider = (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (native_orientationProvider, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableCompass (orientationProvider);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='enableCompass' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.compass.IOrientationProvider']]"
		[Register ("enableCompass", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)Z", "GetEnableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler")]
		public virtual bool EnableCompass (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider)
		{
			if (id_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ == IntPtr.Zero)
				id_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNIEnv.GetMethodID (class_ref, "enableCompass", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_enableCompass_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_, new JValue (orientationProvider));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableCompass", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)Z"), new JValue (orientationProvider));
			return __ret;
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem pItem = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_pItem, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (pItem, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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

		static Delegate cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
#pragma warning disable 0169
		static Delegate GetOnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler ()
		{
			if (cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ == null)
				cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_OnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_);
			return cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		}

		static void n_OnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ (IntPtr jnienv, IntPtr native__this, float orientation, IntPtr native_source)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider source = (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationChanged (orientation, source);
		}
#pragma warning restore 0169

		static IntPtr id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='onOrientationChanged' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='org.osmdroid.views.overlay.compass.IOrientationProvider']]"
		[Register ("onOrientationChanged", "(FLorg/osmdroid/views/overlay/compass/IOrientationProvider;)V", "GetOnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler")]
		public virtual void OnOrientationChanged (float orientation, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider source)
		{
			if (id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ == IntPtr.Zero)
				id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNIEnv.GetMethodID (class_ref, "onOrientationChanged", "(FLorg/osmdroid/views/overlay/compass/IOrientationProvider;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_, new JValue (orientation), new JValue (source));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOrientationChanged", "(FLorg/osmdroid/views/overlay/compass/IOrientationProvider;)V"), new JValue (orientation), new JValue (source));
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCompassCenter (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_setCompassCenter_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='setCompassCenter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
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

		static Delegate cb_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
#pragma warning disable 0169
		static Delegate GetSetOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler ()
		{
			if (cb_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ == null)
				cb_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_);
			return cb_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		}

		static void n_SetOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orientationProvider)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.CompassOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider = (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (native_orientationProvider, JniHandleOwnership.DoNotTransfer);
			__this.SetOrientationProvider (orientationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='CompassOverlay']/method[@name='setOrientationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.compass.IOrientationProvider']]"
		[Register ("setOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)V", "GetSetOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler")]
		protected virtual void SetOrientationProvider (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider orientationProvider)
		{
			if (id_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ == IntPtr.Zero)
				id_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNIEnv.GetMethodID (class_ref, "setOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationProvider_, new JValue (orientationProvider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationProvider;)V"), new JValue (orientationProvider));
		}

	}
}
