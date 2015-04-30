using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/Overlay", DoNotGenerateAcw=true)]
	public abstract partial class Overlay : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/field[@name='SHADOW_X_SKEW']"
		[Register ("SHADOW_X_SKEW")]
		protected const float ShadowXSkew = (float) -0.900000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/field[@name='SHADOW_Y_SCALE']"
		[Register ("SHADOW_Y_SCALE")]
		protected const float ShadowYScale = (float) 0.500000;

		static IntPtr mResourceProxy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/field[@name='mResourceProxy']"
		[Register ("mResourceProxy")]
		protected global::Osmdroid.IResourceProxy MResourceProxy {
			get {
				if (mResourceProxy_jfieldId == IntPtr.Zero)
					mResourceProxy_jfieldId = JNIEnv.GetFieldID (class_ref, "mResourceProxy", "Lorg/osmdroid/ResourceProxy;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mResourceProxy_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mResourceProxy_jfieldId == IntPtr.Zero)
					mResourceProxy_jfieldId = JNIEnv.GetFieldID (class_ref, "mResourceProxy", "Lorg/osmdroid/ResourceProxy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mResourceProxy_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/field[@name='mScale']"
		[Register ("mScale")]
		protected float MScale {
			get {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				return JNIEnv.GetFloatField (Handle, mScale_jfieldId);
			}
			set {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				JNIEnv.SetField (Handle, mScale_jfieldId, value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.OverlayConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='DEFAULT_ZOOMLEVEL_MINIMAP_DIFFERENCE']"
			[Register ("DEFAULT_ZOOMLEVEL_MINIMAP_DIFFERENCE")]
			public const int DefaultZoomlevelMinimapDifference = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='Overlay.Snappable']"
		[Register ("org/osmdroid/views/overlay/Overlay$Snappable", "", "Osmdroid.Views.Overlay.Overlay/ISnappableInvoker")]
		public partial interface ISnappable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='Overlay.Snappable']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
			[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler:Osmdroid.Views.Overlay.Overlay/ISnappableInvoker, OsmdroidAndroidBinding")]
			bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView mapView);

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/Overlay$Snappable", DoNotGenerateAcw=true)]
		internal class ISnappableInvoker : global::Java.Lang.Object, ISnappable {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/Overlay$Snappable");
			IntPtr class_ref;

			public static ISnappable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISnappable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.Overlay.Snappable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISnappableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ISnappableInvoker); }
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
				global::Osmdroid.Views.Overlay.Overlay.ISnappable __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay.ISnappable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Point snapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_snapPoint, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Api.IMapView mapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSnapToItem (x, y, snapPoint, mapView);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
			public bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView mapView)
			{
				if (id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == IntPtr.Zero)
					id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNIEnv.GetMethodID (class_ref, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_, new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (mapView));
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/Overlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Overlay); }
		}

		protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public Overlay (global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Overlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (ctx)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (ctx));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (ctx)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (ctx));
		}

		static IntPtr id_ctor_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/ResourceProxy;)V", "")]
		public Overlay (global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Overlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/ResourceProxy;)V", new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/ResourceProxy;)V", new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_ResourceProxy_, new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_ResourceProxy_, new JValue (pResourceProxy));
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool pEnabled)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = pEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		static IntPtr id_setEnabled_Z;
		public virtual bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				if (id_setEnabled_Z == IntPtr.Zero)
					id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), new JValue (value));
			}
		}

		static IntPtr id_getSafeMenuId;
		protected static int SafeMenuId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='getSafeMenuId' and count(parameter)=0]"
			[Register ("getSafeMenuId", "()I", "GetGetSafeMenuIdHandler")]
			get {
				if (id_getSafeMenuId == IntPtr.Zero)
					id_getSafeMenuId = JNIEnv.GetStaticMethodID (class_ref, "getSafeMenuId", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getSafeMenuId);
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_osmv, bool shadow)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, osmv, shadow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public abstract void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow);

		static IntPtr id_drawAt_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_IIZF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='drawAt' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='float']]"
		[Register ("drawAt", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;IIZF)V", "")]
		protected static void DrawAt (global::Android.Graphics.Canvas canvas, global::Android.Graphics.Drawables.Drawable drawable, int x, int y, bool shadow, float aMapOrientation)
		{
			if (id_drawAt_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_IIZF == IntPtr.Zero)
				id_drawAt_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_IIZF = JNIEnv.GetStaticMethodID (class_ref, "drawAt", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;IIZF)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_drawAt_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_IIZF, new JValue (canvas), new JValue (drawable), new JValue (x), new JValue (y), new JValue (shadow), new JValue (aMapOrientation));
		}

		static IntPtr id_getSafeMenuIdSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='getSafeMenuIdSequence' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSafeMenuIdSequence", "(I)I", "")]
		protected static int GetSafeMenuIdSequence (int count)
		{
			if (id_getSafeMenuIdSequence_I == IntPtr.Zero)
				id_getSafeMenuIdSequence_I = JNIEnv.GetStaticMethodID (class_ref, "getSafeMenuIdSequence", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_getSafeMenuIdSequence_I, new JValue (count));
		}

		static Delegate cb_onDetach_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDetach_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDetach_Lorg_osmdroid_views_MapView_ == null)
				cb_onDetach_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDetach_Lorg_osmdroid_views_MapView_);
			return cb_onDetach_Lorg_osmdroid_views_MapView_;
		}

		static void n_OnDetach_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach (mapView);
		}
#pragma warning restore 0169

		static IntPtr id_onDetach_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onDetach' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("onDetach", "(Lorg/osmdroid/views/MapView;)V", "GetOnDetach_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void OnDetach (global::Osmdroid.Views.MapView mapView)
		{
			if (id_onDetach_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDetach_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDetach", "(Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDetach_Lorg_osmdroid_views_MapView_, new JValue (mapView));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetach", "(Lorg/osmdroid/views/MapView;)V"), new JValue (mapView));
		}

		static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTap (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onDoubleTap' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDoubleTap (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTapEvent (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onDoubleTapEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDoubleTapEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDown (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onDown' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDown (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ == null)
				cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_);
			return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		}

		static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent1, IntPtr native_pEvent2, float pVelocityX, float pVelocityY, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent2, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnFling (pEvent1, pEvent2, pVelocityX, pVelocityY, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onFling' and count(parameter)=5 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='org.osmdroid.views.MapView']]"
		[Register ("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z", "GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnFling (global::Android.Views.MotionEvent pEvent1, global::Android.Views.MotionEvent pEvent2, float pVelocityX, float pVelocityY, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_, new JValue (pEvent1), new JValue (pEvent2), new JValue (pVelocityX), new JValue (pVelocityY), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z"), new JValue (pEvent1), new JValue (pEvent2), new JValue (pVelocityX), new JValue (pVelocityY), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_);
			return cb_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyDown (keyCode, e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onKeyDown' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnKeyDown (int keyCode, global::Android.Views.KeyEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_, new JValue (keyCode), new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (keyCode), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_);
			return cb_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyUp (keyCode, e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onKeyUp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnKeyUp (int keyCode, global::Android.Views.KeyEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_, new JValue (keyCode), new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (keyCode), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongPress (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onLongPress' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnLongPress (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ == null)
				cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_);
			return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		}

		static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent1, IntPtr native_pEvent2, float pDistanceX, float pDistanceY, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent2, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (pEvent1, pEvent2, pDistanceX, pDistanceY, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onScroll' and count(parameter)=5 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='org.osmdroid.views.MapView']]"
		[Register ("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z", "GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnScroll (global::Android.Views.MotionEvent pEvent1, global::Android.Views.MotionEvent pEvent2, float pDistanceX, float pDistanceY, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_, new JValue (pEvent1), new JValue (pEvent2), new JValue (pDistanceX), new JValue (pDistanceY), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FFLorg/osmdroid/views/MapView;)Z"), new JValue (pEvent1), new JValue (pEvent2), new JValue (pDistanceX), new JValue (pDistanceY), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static void n_OnShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			__this.OnShowPress (pEvent, pMapView);
		}
#pragma warning restore 0169

		static IntPtr id_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onShowPress' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onShowPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V", "GetOnShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void OnShowPress (global::Android.Views.MotionEvent pEvent, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onShowPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (pEvent), new JValue (pMapView));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onShowPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V"), new JValue (pEvent), new JValue (pMapView));
		}

		static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapConfirmed (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onSingleTapConfirmed' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnSingleTapConfirmed (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUp (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onSingleTapUp' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnSingleTapUp (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnTouchEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.Overlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTrackballEvent (e, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='onTrackballEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnTrackballEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (mapView));
			return __ret;
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/Overlay", DoNotGenerateAcw=true)]
	internal partial class OverlayInvoker : Overlay {

		public OverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayInvoker); }
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='Overlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
		}

	}

}
