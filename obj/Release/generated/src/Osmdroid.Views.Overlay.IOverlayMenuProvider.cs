using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']"
	[Register ("org/osmdroid/views/overlay/IOverlayMenuProvider", "", "Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker")]
	public partial interface IOverlayMenuProvider : IJavaObject {

		bool OptionsMenuEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']/method[@name='isOptionsMenuEnabled' and count(parameter)=0]"
			[Register ("isOptionsMenuEnabled", "()Z", "GetIsOptionsMenuEnabledHandler:Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker, OsmdroidAndroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']/method[@name='setOptionsMenuEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOptionsMenuEnabled", "(Z)V", "GetSetOptionsMenuEnabled_ZHandler:Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker, OsmdroidAndroidBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler:Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker, OsmdroidAndroidBinding")]
		bool OnCreateOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z", "GetOnOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_Handler:Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker, OsmdroidAndroidBinding")]
		bool OnOptionsItemSelected (global::Android.Views.IMenuItem pItem, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='IOverlayMenuProvider']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z", "GetOnPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_Handler:Osmdroid.Views.Overlay.IOverlayMenuProviderInvoker, OsmdroidAndroidBinding")]
		bool OnPrepareOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView);

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/IOverlayMenuProvider", DoNotGenerateAcw=true)]
	internal class IOverlayMenuProviderInvoker : global::Java.Lang.Object, IOverlayMenuProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/IOverlayMenuProvider");
		IntPtr class_ref;

		public static IOverlayMenuProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOverlayMenuProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.IOverlayMenuProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOverlayMenuProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOverlayMenuProviderInvoker); }
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
			global::Osmdroid.Views.Overlay.IOverlayMenuProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.IOverlayMenuProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Views.Overlay.IOverlayMenuProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.IOverlayMenuProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptionsMenuEnabled = pOptionsMenuEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isOptionsMenuEnabled;
		IntPtr id_setOptionsMenuEnabled_Z;
		public bool OptionsMenuEnabled {
			get {
				if (id_isOptionsMenuEnabled == IntPtr.Zero)
					id_isOptionsMenuEnabled = JNIEnv.GetMethodID (class_ref, "isOptionsMenuEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isOptionsMenuEnabled);
			}
			set {
				if (id_setOptionsMenuEnabled_Z == IntPtr.Zero)
					id_setOptionsMenuEnabled_Z = JNIEnv.GetMethodID (class_ref, "setOptionsMenuEnabled", "(Z)V");
				JNIEnv.CallVoidMethod (Handle, id_setOptionsMenuEnabled_Z, new JValue (value));
			}
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
			global::Osmdroid.Views.Overlay.IOverlayMenuProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.IOverlayMenuProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		public bool OnCreateOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onCreateOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
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
			global::Osmdroid.Views.Overlay.IOverlayMenuProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.IOverlayMenuProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem pItem = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_pItem, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (pItem, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		public bool OnOptionsItemSelected (global::Android.Views.IMenuItem pItem, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onOptionsItemSelected", "(Landroid/view/MenuItem;ILorg/osmdroid/views/MapView;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_, new JValue (pItem), new JValue (pMenuIdOffset), new JValue (pMapView));
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
			global::Osmdroid.Views.Overlay.IOverlayMenuProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.IOverlayMenuProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		public bool OnPrepareOptionsMenu (global::Android.Views.IMenu pMenu, int pMenuIdOffset, global::Osmdroid.Views.MapView pMapView)
		{
			if (id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onPrepareOptionsMenu", "(Landroid/view/Menu;ILorg/osmdroid/views/MapView;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_, new JValue (pMenu), new JValue (pMenuIdOffset), new JValue (pMapView));
			return __ret;
		}

	}

}
