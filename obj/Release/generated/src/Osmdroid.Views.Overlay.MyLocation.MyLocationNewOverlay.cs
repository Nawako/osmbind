using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay.MyLocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/mylocation/MyLocationNewOverlay", DoNotGenerateAcw=true)]
	public partial class MyLocationNewOverlay : global::Osmdroid.Views.Overlay.Overlay, global::Osmdroid.Views.Overlay.IOverlayMenuProvider, global::Osmdroid.Views.Overlay.Overlay.ISnappable, global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer {


		static IntPtr MENU_MY_LOCATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='MENU_MY_LOCATION']"
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

		static IntPtr mCirclePaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mCirclePaint']"
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

		static IntPtr mDirectionArrowBitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mDirectionArrowBitmap']"
		[Register ("mDirectionArrowBitmap")]
		protected global::Android.Graphics.Bitmap MDirectionArrowBitmap {
			get {
				if (mDirectionArrowBitmap_jfieldId == IntPtr.Zero)
					mDirectionArrowBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowBitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDirectionArrowBitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDirectionArrowBitmap_jfieldId == IntPtr.Zero)
					mDirectionArrowBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowBitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDirectionArrowBitmap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDirectionArrowCenterX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mDirectionArrowCenterX']"
		[Register ("mDirectionArrowCenterX")]
		protected float MDirectionArrowCenterX {
			get {
				if (mDirectionArrowCenterX_jfieldId == IntPtr.Zero)
					mDirectionArrowCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowCenterX", "F");
				return JNIEnv.GetFloatField (Handle, mDirectionArrowCenterX_jfieldId);
			}
			set {
				if (mDirectionArrowCenterX_jfieldId == IntPtr.Zero)
					mDirectionArrowCenterX_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowCenterX", "F");
				JNIEnv.SetField (Handle, mDirectionArrowCenterX_jfieldId, value);
			}
		}

		static IntPtr mDirectionArrowCenterY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mDirectionArrowCenterY']"
		[Register ("mDirectionArrowCenterY")]
		protected float MDirectionArrowCenterY {
			get {
				if (mDirectionArrowCenterY_jfieldId == IntPtr.Zero)
					mDirectionArrowCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowCenterY", "F");
				return JNIEnv.GetFloatField (Handle, mDirectionArrowCenterY_jfieldId);
			}
			set {
				if (mDirectionArrowCenterY_jfieldId == IntPtr.Zero)
					mDirectionArrowCenterY_jfieldId = JNIEnv.GetFieldID (class_ref, "mDirectionArrowCenterY", "F");
				JNIEnv.SetField (Handle, mDirectionArrowCenterY_jfieldId, value);
			}
		}

		static IntPtr mDrawAccuracyEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mDrawAccuracyEnabled']"
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

		static IntPtr mIsFollowing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mIsFollowing']"
		[Register ("mIsFollowing")]
		protected bool MIsFollowing {
			get {
				if (mIsFollowing_jfieldId == IntPtr.Zero)
					mIsFollowing_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFollowing", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsFollowing_jfieldId);
			}
			set {
				if (mIsFollowing_jfieldId == IntPtr.Zero)
					mIsFollowing_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFollowing", "Z");
				JNIEnv.SetField (Handle, mIsFollowing_jfieldId, value);
			}
		}

		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mMapView']"
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

		static IntPtr mMyLocationProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mMyLocationProvider']"
		[Register ("mMyLocationProvider")]
		public global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider MMyLocationProvider {
			get {
				if (mMyLocationProvider_jfieldId == IntPtr.Zero)
					mMyLocationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mMyLocationProvider", "Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMyLocationProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMyLocationProvider_jfieldId == IntPtr.Zero)
					mMyLocationProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mMyLocationProvider", "Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMyLocationProvider_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mPaint']"
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

		static IntPtr mPersonBitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mPersonBitmap']"
		[Register ("mPersonBitmap")]
		protected global::Android.Graphics.Bitmap MPersonBitmap {
			get {
				if (mPersonBitmap_jfieldId == IntPtr.Zero)
					mPersonBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mPersonBitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPersonBitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPersonBitmap_jfieldId == IntPtr.Zero)
					mPersonBitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "mPersonBitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPersonBitmap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPersonHotspot_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/field[@name='mPersonHotspot']"
		[Register ("mPersonHotspot")]
		protected global::Android.Graphics.PointF MPersonHotspot {
			get {
				if (mPersonHotspot_jfieldId == IntPtr.Zero)
					mPersonHotspot_jfieldId = JNIEnv.GetFieldID (class_ref, "mPersonHotspot", "Landroid/graphics/PointF;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPersonHotspot_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPersonHotspot_jfieldId == IntPtr.Zero)
					mPersonHotspot_jfieldId = JNIEnv.GetFieldID (class_ref, "mPersonHotspot", "Landroid/graphics/PointF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPersonHotspot_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/mylocation/MyLocationNewOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyLocationNewOverlay); }
		}

		protected MyLocationNewOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/constructor[@name='MyLocationNewOverlay' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;)V", "")]
		public MyLocationNewOverlay (global::Android.Content.Context context, global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider, global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MyLocationNewOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (myLocationProvider), new JValue (mapView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;)V", new JValue (context), new JValue (myLocationProvider), new JValue (mapView));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (myLocationProvider), new JValue (mapView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_, new JValue (context), new JValue (myLocationProvider), new JValue (mapView));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/constructor[@name='MyLocationNewOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/views/MapView;)V", "")]
		public MyLocationNewOverlay (global::Android.Content.Context context, global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MyLocationNewOverlay)) {
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

		static IntPtr id_ctor_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/constructor[@name='MyLocationNewOverlay' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", "")]
		public MyLocationNewOverlay (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider, global::Osmdroid.Views.MapView mapView, global::Osmdroid.IResourceProxy resourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MyLocationNewOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (myLocationProvider), new JValue (mapView), new JValue (resourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (myLocationProvider), new JValue (mapView), new JValue (resourceProxy));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (myLocationProvider), new JValue (mapView), new JValue (resourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (myLocationProvider), new JValue (mapView), new JValue (resourceProxy));
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawAccuracyEnabled = drawAccuracyEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isDrawAccuracyEnabled;
		static IntPtr id_setDrawAccuracyEnabled_Z;
		public virtual bool DrawAccuracyEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='isDrawAccuracyEnabled' and count(parameter)=0]"
			[Register ("isDrawAccuracyEnabled", "()Z", "GetIsDrawAccuracyEnabledHandler")]
			get {
				if (id_isDrawAccuracyEnabled == IntPtr.Zero)
					id_isDrawAccuracyEnabled = JNIEnv.GetMethodID (class_ref, "isDrawAccuracyEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDrawAccuracyEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawAccuracyEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='setDrawAccuracyEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFollowLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isFollowLocationEnabled;
		public virtual bool IsFollowLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='isFollowLocationEnabled' and count(parameter)=0]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMyLocationEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isMyLocationEnabled;
		public virtual bool IsMyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastFix);
		}
#pragma warning restore 0169

		static IntPtr id_getLastFix;
		public virtual global::Android.Locations.Location LastFix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='getLastFix' and count(parameter)=0]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocation;
		public virtual global::Osmdroid.Util.GeoPoint MyLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='getMyLocation' and count(parameter)=0]"
			[Register ("getMyLocation", "()Lorg/osmdroid/util/GeoPoint;", "GetGetMyLocationHandler")]
			get {
				if (id_getMyLocation == IntPtr.Zero)
					id_getMyLocation = JNIEnv.GetMethodID (class_ref, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMyLocationProvider;
#pragma warning disable 0169
		static Delegate GetGetMyLocationProviderHandler ()
		{
			if (cb_getMyLocationProvider == null)
				cb_getMyLocationProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyLocationProvider);
			return cb_getMyLocationProvider;
		}

		static IntPtr n_GetMyLocationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocationProvider;
		public virtual global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider MyLocationProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='getMyLocationProvider' and count(parameter)=0]"
			[Register ("getMyLocationProvider", "()Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;", "GetGetMyLocationProviderHandler")]
			get {
				if (id_getMyLocationProvider == IntPtr.Zero)
					id_getMyLocationProvider = JNIEnv.GetMethodID (class_ref, "getMyLocationProvider", "()Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocationProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyLocationProvider", "()Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptionsMenuEnabled = pOptionsMenuEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isOptionsMenuEnabled;
		static IntPtr id_setOptionsMenuEnabled_Z;
		public virtual bool OptionsMenuEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='isOptionsMenuEnabled' and count(parameter)=0]"
			[Register ("isOptionsMenuEnabled", "()Z", "GetIsOptionsMenuEnabledHandler")]
			get {
				if (id_isOptionsMenuEnabled == IntPtr.Zero)
					id_isOptionsMenuEnabled = JNIEnv.GetMethodID (class_ref, "isOptionsMenuEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOptionsMenuEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptionsMenuEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='setOptionsMenuEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableFollowLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_disableFollowLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='disableFollowLocation' and count(parameter)=0]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableMyLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_disableMyLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='disableMyLocation' and count(parameter)=0]"
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

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_mapView, bool shadow)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location lastFix = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_lastFix, JniHandleOwnership.DoNotTransfer);
			__this.DrawMyLocation (canvas, mapView, lastFix);
		}
#pragma warning restore 0169

		static IntPtr id_drawMyLocation_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='drawMyLocation' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='android.location.Location']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableFollowLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_enableFollowLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='enableFollowLocation' and count(parameter)=0]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableMyLocation ();
		}
#pragma warning restore 0169

		static IntPtr id_enableMyLocation;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='enableMyLocation' and count(parameter)=0]"
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

		static Delegate cb_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
#pragma warning disable 0169
		static Delegate GetEnableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler ()
		{
			if (cb_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == null)
				cb_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EnableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_);
			return cb_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		}

		static bool n_EnableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_myLocationProvider)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider = (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (native_myLocationProvider, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EnableMyLocation (myLocationProvider);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='enableMyLocation' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider']]"
		[Register ("enableMyLocation", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)Z", "GetEnableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler")]
		public virtual bool EnableMyLocation (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider)
		{
			if (id_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == IntPtr.Zero)
				id_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNIEnv.GetMethodID (class_ref, "enableMyLocation", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_enableMyLocation_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_, new JValue (myLocationProvider));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableMyLocation", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)Z"), new JValue (myLocationProvider));
			return __ret;
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location lastFix = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_lastFix, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMyLocationDrawingBounds (zoomLevel, lastFix, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocationDrawingBounds_ILandroid_location_Location_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='getMyLocationDrawingBounds' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.location.Location'] and parameter[3][@type='android.graphics.Rect']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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

		static Delegate cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == null)
				cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_);
			return cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location, IntPtr native_source)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider source = (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (location, source);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='onLocationChanged' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V", "GetOnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler")]
		public virtual void OnLocationChanged (global::Android.Locations.Location location, global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider source)
		{
			if (id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_, new JValue (location), new JValue (source));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V"), new JValue (location), new JValue (source));
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem pItem = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_pItem, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (pItem, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point snapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_snapPoint, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IMapView mapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSnapToItem (x, y, snapPoint, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
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
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RunOnFirstFix (runnable);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_runOnFirstFix_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='runOnFirstFix' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
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

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (location);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
		protected virtual void SetLocation (global::Android.Locations.Location location)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLocation_Landroid_location_Location_, new JValue (location));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), new JValue (location));
		}

		static Delegate cb_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
#pragma warning disable 0169
		static Delegate GetSetMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler ()
		{
			if (cb_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == null)
				cb_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_);
			return cb_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		}

		static void n_SetMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_myLocationProvider)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider = (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (native_myLocationProvider, JniHandleOwnership.DoNotTransfer);
			__this.SetMyLocationProvider (myLocationProvider);
		}
#pragma warning restore 0169

		static IntPtr id_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='setMyLocationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider']]"
		[Register ("setMyLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V", "GetSetMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler")]
		protected virtual void SetMyLocationProvider (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider myLocationProvider)
		{
			if (id_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == IntPtr.Zero)
				id_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNIEnv.GetMethodID (class_ref, "setMyLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMyLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_, new JValue (myLocationProvider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMyLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V"), new JValue (myLocationProvider));
		}

		static Delegate cb_setPersonHotspot_FF;
#pragma warning disable 0169
		static Delegate GetSetPersonHotspot_FFHandler ()
		{
			if (cb_setPersonHotspot_FF == null)
				cb_setPersonHotspot_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetPersonHotspot_FF);
			return cb_setPersonHotspot_FF;
		}

		static void n_SetPersonHotspot_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPersonHotspot (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_setPersonHotspot_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='MyLocationNewOverlay']/method[@name='setPersonHotspot' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setPersonHotspot", "(FF)V", "GetSetPersonHotspot_FFHandler")]
		public virtual void SetPersonHotspot (float x, float y)
		{
			if (id_setPersonHotspot_FF == IntPtr.Zero)
				id_setPersonHotspot_FF = JNIEnv.GetMethodID (class_ref, "setPersonHotspot", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPersonHotspot_FF, new JValue (x), new JValue (y));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPersonHotspot", "(FF)V"), new JValue (x), new JValue (y));
		}

	}
}
