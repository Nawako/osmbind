using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/OverlayManager", DoNotGenerateAcw=true)]
	public partial class OverlayManager : global::Java.Util.AbstractList {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/OverlayManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayManager); }
		}

		protected OverlayManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_overlay_TilesOverlay_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/constructor[@name='OverlayManager' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.TilesOverlay']]"
		[Register (".ctor", "(Lorg/osmdroid/views/overlay/TilesOverlay;)V", "")]
		public OverlayManager (global::Osmdroid.Views.Overlay.TilesOverlay tilesOverlay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OverlayManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/overlay/TilesOverlay;)V", new JValue (tilesOverlay)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/overlay/TilesOverlay;)V", new JValue (tilesOverlay));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_overlay_TilesOverlay_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_overlay_TilesOverlay_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/overlay/TilesOverlay;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_overlay_TilesOverlay_, new JValue (tilesOverlay)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_overlay_TilesOverlay_, new JValue (tilesOverlay));
		}

		static Delegate cb_getTilesOverlay;
#pragma warning disable 0169
		static Delegate GetGetTilesOverlayHandler ()
		{
			if (cb_getTilesOverlay == null)
				cb_getTilesOverlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTilesOverlay);
			return cb_getTilesOverlay;
		}

		static IntPtr n_GetTilesOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TilesOverlay);
		}
#pragma warning restore 0169

		static Delegate cb_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_;
#pragma warning disable 0169
		static Delegate GetSetTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_Handler ()
		{
			if (cb_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_ == null)
				cb_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_);
			return cb_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_;
		}

		static void n_SetTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tilesOverlay)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.TilesOverlay tilesOverlay = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (native_tilesOverlay, JniHandleOwnership.DoNotTransfer);
			__this.TilesOverlay = tilesOverlay;
		}
#pragma warning restore 0169

		static IntPtr id_getTilesOverlay;
		static IntPtr id_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_;
		public virtual global::Osmdroid.Views.Overlay.TilesOverlay TilesOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='getTilesOverlay' and count(parameter)=0]"
			[Register ("getTilesOverlay", "()Lorg/osmdroid/views/overlay/TilesOverlay;", "GetGetTilesOverlayHandler")]
			get {
				if (id_getTilesOverlay == IntPtr.Zero)
					id_getTilesOverlay = JNIEnv.GetMethodID (class_ref, "getTilesOverlay", "()Lorg/osmdroid/views/overlay/TilesOverlay;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (JNIEnv.CallObjectMethod  (Handle, id_getTilesOverlay), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTilesOverlay", "()Lorg/osmdroid/views/overlay/TilesOverlay;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='setTilesOverlay' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.TilesOverlay']]"
			[Register ("setTilesOverlay", "(Lorg/osmdroid/views/overlay/TilesOverlay;)V", "GetSetTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_Handler")]
			set {
				if (id_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_ == IntPtr.Zero)
					id_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_ = JNIEnv.GetMethodID (class_ref, "setTilesOverlay", "(Lorg/osmdroid/views/overlay/TilesOverlay;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTilesOverlay_Lorg_osmdroid_views_overlay_TilesOverlay_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTilesOverlay", "(Lorg/osmdroid/views/overlay/TilesOverlay;)V"), new JValue (value));
			}
		}

		static Delegate cb_add_ILorg_osmdroid_views_overlay_Overlay_;
#pragma warning disable 0169
		static Delegate GetAdd_ILorg_osmdroid_views_overlay_Overlay_Handler ()
		{
			if (cb_add_ILorg_osmdroid_views_overlay_Overlay_ == null)
				cb_add_ILorg_osmdroid_views_overlay_Overlay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_ILorg_osmdroid_views_overlay_Overlay_);
			return cb_add_ILorg_osmdroid_views_overlay_Overlay_;
		}

		static void n_Add_ILorg_osmdroid_views_overlay_Overlay_ (IntPtr jnienv, IntPtr native__this, int pIndex, IntPtr native_pElement)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.Overlay pElement = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (native_pElement, JniHandleOwnership.DoNotTransfer);
			__this.Add (pIndex, pElement);
		}
#pragma warning restore 0169

		static IntPtr id_add_ILorg_osmdroid_views_overlay_Overlay_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='add' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.overlay.Overlay']]"
		[Register ("add", "(ILorg/osmdroid/views/overlay/Overlay;)V", "GetAdd_ILorg_osmdroid_views_overlay_Overlay_Handler")]
		public virtual void Add (int pIndex, global::Osmdroid.Views.Overlay.Overlay pElement)
		{
			if (id_add_ILorg_osmdroid_views_overlay_Overlay_ == IntPtr.Zero)
				id_add_ILorg_osmdroid_views_overlay_Overlay_ = JNIEnv.GetMethodID (class_ref, "add", "(ILorg/osmdroid/views/overlay/Overlay;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_ILorg_osmdroid_views_overlay_Overlay_, new JValue (pIndex), new JValue (pElement));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(ILorg/osmdroid/views/overlay/Overlay;)V"), new JValue (pIndex), new JValue (pElement));
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int pIndex)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (pIndex));
		}
#pragma warning restore 0169

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lorg/osmdroid/views/overlay/Overlay;", "GetGet_IHandler")]
		public override global::Java.Lang.Object Get (int pIndex)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lorg/osmdroid/views/overlay/Overlay;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_get_I, new JValue (pIndex)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "(I)Lorg/osmdroid/views/overlay/Overlay;"), new JValue (pIndex)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == null)
				cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_OnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_);
			return cb_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		}

		static bool n_OnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pMenu, int menuIdOffset, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, menuIdOffset, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnCreateOptionsMenu (global::Android.Views.IMenu pMenu, int menuIdOffset, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (menuIdOffset), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z"), new JValue (pMenu), new JValue (menuIdOffset), new JValue (mapView));
			return __ret;
		}

		static Delegate cb_onDetach_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDetach_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDetach_Lorg_osmdroid_views_MapView_ == null)
				cb_onDetach_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDetach_Lorg_osmdroid_views_MapView_);
			return cb_onDetach_Lorg_osmdroid_views_MapView_;
		}

		static void n_OnDetach_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach (pMapView);
		}
#pragma warning restore 0169

		static IntPtr id_onDetach_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onDetach' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("onDetach", "(Lorg/osmdroid/views/MapView;)V", "GetOnDetach_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void OnDetach (global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onDetach_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDetach_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDetach", "(Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDetach_Lorg_osmdroid_views_MapView_, new JValue (pMapView));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetach", "(Lorg/osmdroid/views/MapView;)V"), new JValue (pMapView));
		}

		static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTap (e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onDoubleTap' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDoubleTap (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTap_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTap", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (pMapView));
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

		static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDoubleTapEvent (e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onDoubleTapEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDoubleTapEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (pMapView));
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

		static bool n_OnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDown (pEvent, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onDown' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnDown (global::Android.Views.MotionEvent pEvent, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDown_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (pEvent), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDown", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (pEvent), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ == null)
				cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_);
			return cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (c, pMapView);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onDraw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V", "GetOnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void OnDraw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_, new JValue (c), new JValue (pMapView));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V"), new JValue (c), new JValue (pMapView));
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
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent2, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnFling (pEvent1, pEvent2, pVelocityX, pVelocityY, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onFling' and count(parameter)=5 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='org.osmdroid.views.MapView']]"
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

		static bool n_OnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyDown (keyCode, e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onKeyDown' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnKeyDown (int keyCode, global::Android.Views.KeyEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyDown_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_, new JValue (keyCode), new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyDown", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (keyCode), new JValue (e), new JValue (pMapView));
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

		static bool n_OnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.KeyEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.KeyEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnKeyUp (keyCode, e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onKeyUp' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.KeyEvent'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnKeyUp (int keyCode, global::Android.Views.KeyEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onKeyUp_ILandroid_view_KeyEvent_Lorg_osmdroid_views_MapView_, new JValue (keyCode), new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onKeyUp", "(ILandroid/view/KeyEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (keyCode), new JValue (e), new JValue (pMapView));
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

		static bool n_OnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongPress (pEvent, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onLongPress' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnLongPress (global::Android.Views.MotionEvent pEvent, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onLongPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (pEvent), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (pEvent), new JValue (pMapView));
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

		static bool n_OnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item, int menuIdOffset, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem item = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_item, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (item, menuIdOffset, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnOptionsItemSelected (global::Android.Views.IMenuItem item, int menuIdOffset, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_, new JValue (item), new JValue (menuIdOffset), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z"), new JValue (item), new JValue (menuIdOffset), new JValue (mapView));
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

		static bool n_OnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pMenu, int menuIdOffset, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, menuIdOffset, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnPrepareOptionsMenu (global::Android.Views.IMenu pMenu, int menuIdOffset, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (menuIdOffset), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z"), new JValue (pMenu), new JValue (menuIdOffset), new JValue (mapView));
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
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent1, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent2 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent2, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (pEvent1, pEvent2, pDistanceX, pDistanceY, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFLorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onScroll' and count(parameter)=5 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='org.osmdroid.views.MapView']]"
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
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			__this.OnShowPress (pEvent, pMapView);
		}
#pragma warning restore 0169

		static IntPtr id_onShowPress_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onShowPress' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
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

		static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapConfirmed (e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onSingleTapConfirmed' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnSingleTapConfirmed (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (pMapView));
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

		static bool n_OnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUp (pEvent, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onSingleTapUp' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnSingleTapUp (global::Android.Views.MotionEvent pEvent, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapUp_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (pEvent), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUp", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (pEvent), new JValue (pMapView));
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

		static bool n_OnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_snapPoint, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point snapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_snapPoint, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IMapView pMapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSnapToItem (x, y, snapPoint, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
		[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler")]
		public virtual bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView pMapView)
		{
			if (id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == IntPtr.Zero)
				id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNIEnv.GetMethodID (class_ref, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_, new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z"), new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (pMapView));
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

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnTouchEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (pMapView));
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

		static bool n_OnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTrackballEvent (e, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='onTrackballEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetOnTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool OnTrackballEvent (global::Android.Views.MotionEvent e, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTrackballEvent_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (e), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTrackballEvent", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (e), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_overlaysReversed;
#pragma warning disable 0169
		static Delegate GetOverlaysReversedHandler ()
		{
			if (cb_overlaysReversed == null)
				cb_overlaysReversed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OverlaysReversed);
			return cb_overlaysReversed;
		}

		static IntPtr n_OverlaysReversed (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OverlaysReversed ());
		}
#pragma warning restore 0169

		static IntPtr id_overlaysReversed;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='overlaysReversed' and count(parameter)=0]"
		[Register ("overlaysReversed", "()Ljava/lang/Iterable;", "GetOverlaysReversedHandler")]
		public virtual global::Java.Lang.IIterable OverlaysReversed ()
		{
			if (id_overlaysReversed == IntPtr.Zero)
				id_overlaysReversed = JNIEnv.GetMethodID (class_ref, "overlaysReversed", "()Ljava/lang/Iterable;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallObjectMethod  (Handle, id_overlaysReversed), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IIterable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "overlaysReversed", "()Ljava/lang/Iterable;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_set_ILorg_osmdroid_views_overlay_Overlay_;
#pragma warning disable 0169
		static Delegate GetSet_ILorg_osmdroid_views_overlay_Overlay_Handler ()
		{
			if (cb_set_ILorg_osmdroid_views_overlay_Overlay_ == null)
				cb_set_ILorg_osmdroid_views_overlay_Overlay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Set_ILorg_osmdroid_views_overlay_Overlay_);
			return cb_set_ILorg_osmdroid_views_overlay_Overlay_;
		}

		static IntPtr n_Set_ILorg_osmdroid_views_overlay_Overlay_ (IntPtr jnienv, IntPtr native__this, int pIndex, IntPtr native_pElement)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.Overlay pElement = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (native_pElement, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (pIndex, pElement));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_ILorg_osmdroid_views_overlay_Overlay_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.overlay.Overlay']]"
		[Register ("set", "(ILorg/osmdroid/views/overlay/Overlay;)Lorg/osmdroid/views/overlay/Overlay;", "GetSet_ILorg_osmdroid_views_overlay_Overlay_Handler")]
		public virtual global::Osmdroid.Views.Overlay.Overlay Set (int pIndex, global::Osmdroid.Views.Overlay.Overlay pElement)
		{
			if (id_set_ILorg_osmdroid_views_overlay_Overlay_ == IntPtr.Zero)
				id_set_ILorg_osmdroid_views_overlay_Overlay_ = JNIEnv.GetMethodID (class_ref, "set", "(ILorg/osmdroid/views/overlay/Overlay;)Lorg/osmdroid/views/overlay/Overlay;");

			global::Osmdroid.Views.Overlay.Overlay __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (JNIEnv.CallObjectMethod  (Handle, id_set_ILorg_osmdroid_views_overlay_Overlay_, new JValue (pIndex), new JValue (pElement)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Overlay> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILorg/osmdroid/views/overlay/Overlay;)Lorg/osmdroid/views/overlay/Overlay;"), new JValue (pIndex), new JValue (pElement)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setOptionsMenusEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetOptionsMenusEnabled_ZHandler ()
		{
			if (cb_setOptionsMenusEnabled_Z == null)
				cb_setOptionsMenusEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOptionsMenusEnabled_Z);
			return cb_setOptionsMenusEnabled_Z;
		}

		static void n_SetOptionsMenusEnabled_Z (IntPtr jnienv, IntPtr native__this, bool pEnabled)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOptionsMenusEnabled (pEnabled);
		}
#pragma warning restore 0169

		static IntPtr id_setOptionsMenusEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='setOptionsMenusEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOptionsMenusEnabled", "(Z)V", "GetSetOptionsMenusEnabled_ZHandler")]
		public virtual void SetOptionsMenusEnabled (bool pEnabled)
		{
			if (id_setOptionsMenusEnabled_Z == IntPtr.Zero)
				id_setOptionsMenusEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOptionsMenusEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOptionsMenusEnabled_Z, new JValue (pEnabled));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionsMenusEnabled", "(Z)V"), new JValue (pEnabled));
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayManager __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayManager']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
		}

	}
}
