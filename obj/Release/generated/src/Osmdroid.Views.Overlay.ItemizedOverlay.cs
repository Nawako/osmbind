using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlay", DoNotGenerateAcw=true)]
	public abstract partial class ItemizedOverlay : global::Osmdroid.Views.Overlay.Overlay, global::Osmdroid.Views.Overlay.Overlay.ISnappable {


		static IntPtr mDefaultMarker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/field[@name='mDefaultMarker']"
		[Register ("mDefaultMarker")]
		protected global::Android.Graphics.Drawables.Drawable MDefaultMarker {
			get {
				if (mDefaultMarker_jfieldId == IntPtr.Zero)
					mDefaultMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultMarker", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDefaultMarker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDefaultMarker_jfieldId == IntPtr.Zero)
					mDefaultMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mDefaultMarker", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDefaultMarker_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDrawFocusedItem_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/field[@name='mDrawFocusedItem']"
		[Register ("mDrawFocusedItem")]
		protected bool MDrawFocusedItem {
			get {
				if (mDrawFocusedItem_jfieldId == IntPtr.Zero)
					mDrawFocusedItem_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawFocusedItem", "Z");
				return JNIEnv.GetBooleanField (Handle, mDrawFocusedItem_jfieldId);
			}
			set {
				if (mDrawFocusedItem_jfieldId == IntPtr.Zero)
					mDrawFocusedItem_jfieldId = JNIEnv.GetFieldID (class_ref, "mDrawFocusedItem", "Z");
				JNIEnv.SetField (Handle, mDrawFocusedItem_jfieldId, value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlay.OnFocusChangeListener']"
		[Register ("org/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener", "", "Osmdroid.Views.Overlay.ItemizedOverlay/IOnFocusChangeListenerInvoker")]
		public partial interface IOnFocusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlay.OnFocusChangeListener']/method[@name='onFocusChanged' and count(parameter)=2 and parameter[1][@type='org.osmdroid.views.overlay.ItemizedOverlay'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem']]"
			[Register ("onFocusChanged", "(Lorg/osmdroid/views/overlay/ItemizedOverlay;Lorg/osmdroid/views/overlay/OverlayItem;)V", "GetOnFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_Handler:Osmdroid.Views.Overlay.ItemizedOverlay/IOnFocusChangeListenerInvoker, OsmdroidAndroidBinding")]
			void OnFocusChanged (global::Osmdroid.Views.Overlay.ItemizedOverlay p0, global::Osmdroid.Views.Overlay.OverlayItem p1);

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener", DoNotGenerateAcw=true)]
		internal class IOnFocusChangeListenerInvoker : global::Java.Lang.Object, IOnFocusChangeListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener");
			IntPtr class_ref;

			public static IOnFocusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFocusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.ItemizedOverlay.OnFocusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFocusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnFocusChangeListenerInvoker); }
			}

			static Delegate cb_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
			static Delegate GetOnFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_Handler ()
			{
				if (cb_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_ == null)
					cb_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_);
				return cb_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_;
			}

			static void n_OnFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Views.Overlay.ItemizedOverlay p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Views.Overlay.OverlayItem p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFocusChanged (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_;
			public void OnFocusChanged (global::Osmdroid.Views.Overlay.ItemizedOverlay p0, global::Osmdroid.Views.Overlay.OverlayItem p1)
			{
				if (id_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
					id_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "onFocusChanged", "(Lorg/osmdroid/views/overlay/ItemizedOverlay;Lorg/osmdroid/views/overlay/OverlayItem;)V");
				JNIEnv.CallVoidMethod (Handle, id_onFocusChanged_Lorg_osmdroid_views_overlay_ItemizedOverlay_Lorg_osmdroid_views_overlay_OverlayItem_, new JValue (p0), new JValue (p1));
			}

		}

		public partial class FocusChangeEventArgs : global::System.EventArgs {

			public FocusChangeEventArgs (global::Osmdroid.Views.Overlay.ItemizedOverlay p0, global::Osmdroid.Views.Overlay.OverlayItem p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Osmdroid.Views.Overlay.ItemizedOverlay p0;
			public global::Osmdroid.Views.Overlay.ItemizedOverlay P0 {
				get { return p0; }
			}

			global::Osmdroid.Views.Overlay.OverlayItem p1;
			public global::Osmdroid.Views.Overlay.OverlayItem P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/views/overlay/ItemizedOverlay_OnFocusChangeListenerImplementor")]
		internal sealed class IOnFocusChangeListenerImplementor : global::Java.Lang.Object, IOnFocusChangeListener {

			object sender;

			public IOnFocusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/views/overlay/ItemizedOverlay_OnFocusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FocusChangeEventArgs> Handler;
#pragma warning restore 0649

			public void OnFocusChanged (global::Osmdroid.Views.Overlay.ItemizedOverlay p0, global::Osmdroid.Views.Overlay.OverlayItem p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FocusChangeEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnFocusChangeListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlay); }
		}

		protected ItemizedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedOverlay (global::Android.Graphics.Drawables.Drawable pDefaultMarker, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemizedOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/ResourceProxy;)V", new JValue (pDefaultMarker), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/ResourceProxy;)V", new JValue (pDefaultMarker), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_ResourceProxy_, new JValue (pDefaultMarker), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_ResourceProxy_, new JValue (pDefaultMarker), new JValue (pResourceProxy));
		}

		static Delegate cb_getFocus;
#pragma warning disable 0169
		static Delegate GetGetFocusHandler ()
		{
			if (cb_getFocus == null)
				cb_getFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocus);
			return cb_getFocus;
		}

		static IntPtr n_GetFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Focus);
		}
#pragma warning restore 0169

		static Delegate cb_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetSetFocus_Lorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocus_Lorg_osmdroid_views_overlay_OverlayItem_);
			return cb_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_;
		}

		static void n_SetFocus_Lorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			__this.Focus = item;
		}
#pragma warning restore 0169

		static IntPtr id_getFocus;
		static IntPtr id_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_;
		public virtual global::Java.Lang.Object Focus {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='getFocus' and count(parameter)=0]"
			[Register ("getFocus", "()Lorg/osmdroid/views/overlay/OverlayItem;", "GetGetFocusHandler")]
			get {
				if (id_getFocus == IntPtr.Zero)
					id_getFocus = JNIEnv.GetMethodID (class_ref, "getFocus", "()Lorg/osmdroid/views/overlay/OverlayItem;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFocus), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFocus", "()Lorg/osmdroid/views/overlay/OverlayItem;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='setFocus' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem']]"
			[Register ("setFocus", "(Lorg/osmdroid/views/overlay/OverlayItem;)V", "GetSetFocus_Lorg_osmdroid_views_overlay_OverlayItem_Handler")]
			set {
				if (id_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
					id_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "setFocus", "(Lorg/osmdroid/views/overlay/OverlayItem;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFocus_Lorg_osmdroid_views_overlay_OverlayItem_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocus", "(Lorg/osmdroid/views/overlay/OverlayItem;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
#pragma warning disable 0169
		static Delegate GetBoundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_Handler ()
		{
			if (cb_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ == null)
				cb_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BoundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_);
			return cb_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
		}

		static IntPtr n_BoundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker, IntPtr native_hotspot)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable marker = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_marker, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace hotspot = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (native_hotspot, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BoundToHotspot (marker, hotspot));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='boundToHotspot' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem.HotspotPlace']]"
		[Register ("boundToHotspot", "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)Landroid/graphics/drawable/Drawable;", "GetBoundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_Handler")]
		protected virtual global::Android.Graphics.Drawables.Drawable BoundToHotspot (global::Android.Graphics.Drawables.Drawable marker, global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace hotspot)
		{
			if (id_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ == IntPtr.Zero)
				id_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ = JNIEnv.GetMethodID (class_ref, "boundToHotspot", "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)Landroid/graphics/drawable/Drawable;");

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_boundToHotspot_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_, new JValue (marker), new JValue (hotspot)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "boundToHotspot", "(Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)Landroid/graphics/drawable/Drawable;"), new JValue (marker), new JValue (hotspot)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_createItem_I;
#pragma warning disable 0169
		static Delegate GetCreateItem_IHandler ()
		{
			if (cb_createItem_I == null)
				cb_createItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateItem_I);
			return cb_createItem_I;
		}

		static IntPtr n_CreateItem_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItem (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;", "GetCreateItem_IHandler")]
		protected abstract global::Java.Lang.Object CreateItem (int i);

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
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
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

		static Delegate cb_getDefaultMarker_I;
#pragma warning disable 0169
		static Delegate GetGetDefaultMarker_IHandler ()
		{
			if (cb_getDefaultMarker_I == null)
				cb_getDefaultMarker_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDefaultMarker_I);
			return cb_getDefaultMarker_I;
		}

		static IntPtr n_GetDefaultMarker_I (IntPtr jnienv, IntPtr native__this, int state)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDefaultMarker (state));
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultMarker_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='getDefaultMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDefaultMarker", "(I)Landroid/graphics/drawable/Drawable;", "GetGetDefaultMarker_IHandler")]
		protected virtual global::Android.Graphics.Drawables.Drawable GetDefaultMarker (int state)
		{
			if (id_getDefaultMarker_I == IntPtr.Zero)
				id_getDefaultMarker_I = JNIEnv.GetMethodID (class_ref, "getDefaultMarker", "(I)Landroid/graphics/drawable/Drawable;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDefaultMarker_I, new JValue (state)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultMarker", "(I)Landroid/graphics/drawable/Drawable;"), new JValue (state)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;", "")]
		public global::Java.Lang.Object GetItem (int position)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (position)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II;
#pragma warning disable 0169
		static Delegate GetHitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_IIHandler ()
		{
			if (cb_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II == null)
				cb_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, int, bool>) n_HitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II);
			return cb_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II;
		}

		static bool n_HitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II (IntPtr jnienv, IntPtr native__this, IntPtr native_item, IntPtr native_marker, int hitX, int hitY)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable marker = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_marker, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HitTest (item, marker, hitX, hitY);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='hitTest' and count(parameter)=4 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("hitTest", "(Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/drawable/Drawable;II)Z", "GetHitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_IIHandler")]
		protected virtual bool HitTest (global::Java.Lang.Object item, global::Android.Graphics.Drawables.Drawable marker, int hitX, int hitY)
		{
			if (id_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II == IntPtr.Zero)
				id_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II = JNIEnv.GetMethodID (class_ref, "hitTest", "(Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/drawable/Drawable;II)Z");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hitTest_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_drawable_Drawable_II, new JValue (native_item), new JValue (marker), new JValue (hitX), new JValue (hitY));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hitTest", "(Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/drawable/Drawable;II)Z"), new JValue (native_item), new JValue (marker), new JValue (hitX), new JValue (hitY));
			JNIEnv.DeleteLocalRef (native_item);
			return __ret;
		}

		static Delegate cb_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F;
#pragma warning disable 0169
		static Delegate GetOnDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_FHandler ()
		{
			if (cb_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F == null)
				cb_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float>) n_OnDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F);
			return cb_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F;
		}

		static void n_OnDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_item, IntPtr native_curScreenCoords, float aMapOrientation)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point curScreenCoords = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_curScreenCoords, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawItem (canvas, item, curScreenCoords, aMapOrientation);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='onDrawItem' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='float']]"
		[Register ("onDrawItem", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/Point;F)V", "GetOnDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_FHandler")]
		protected virtual void OnDrawItem (global::Android.Graphics.Canvas canvas, global::Java.Lang.Object item, global::Android.Graphics.Point curScreenCoords, float aMapOrientation)
		{
			if (id_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F == IntPtr.Zero)
				id_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F = JNIEnv.GetMethodID (class_ref, "onDrawItem", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/Point;F)V");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDrawItem_Landroid_graphics_Canvas_Lorg_osmdroid_views_overlay_OverlayItem_Landroid_graphics_Point_F, new JValue (canvas), new JValue (native_item), new JValue (curScreenCoords), new JValue (aMapOrientation));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawItem", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/overlay/OverlayItem;Landroid/graphics/Point;F)V"), new JValue (canvas), new JValue (native_item), new JValue (curScreenCoords), new JValue (aMapOrientation));
			JNIEnv.DeleteLocalRef (native_item);
		}

		static Delegate cb_onTap_I;
#pragma warning disable 0169
		static Delegate GetOnTap_IHandler ()
		{
			if (cb_onTap_I == null)
				cb_onTap_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_OnTap_I);
			return cb_onTap_I;
		}

		static bool n_OnTap_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnTap (index);
		}
#pragma warning restore 0169

		static IntPtr id_onTap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='onTap' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTap", "(I)Z", "GetOnTap_IHandler")]
		protected virtual bool OnTap (int index)
		{
			if (id_onTap_I == IntPtr.Zero)
				id_onTap_I = JNIEnv.GetMethodID (class_ref, "onTap", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_onTap_I, new JValue (index));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTap", "(I)Z"), new JValue (index));
		}

		static IntPtr id_populate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='populate' and count(parameter)=0]"
		[Register ("populate", "()V", "")]
		protected void Populate ()
		{
			if (id_populate == IntPtr.Zero)
				id_populate = JNIEnv.GetMethodID (class_ref, "populate", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_populate);
		}

		static Delegate cb_setDrawFocusedItem_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawFocusedItem_ZHandler ()
		{
			if (cb_setDrawFocusedItem_Z == null)
				cb_setDrawFocusedItem_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawFocusedItem_Z);
			return cb_setDrawFocusedItem_Z;
		}

		static void n_SetDrawFocusedItem_Z (IntPtr jnienv, IntPtr native__this, bool drawFocusedItem)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawFocusedItem (drawFocusedItem);
		}
#pragma warning restore 0169

		static IntPtr id_setDrawFocusedItem_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='setDrawFocusedItem' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawFocusedItem", "(Z)V", "GetSetDrawFocusedItem_ZHandler")]
		public virtual void SetDrawFocusedItem (bool drawFocusedItem)
		{
			if (id_setDrawFocusedItem_Z == IntPtr.Zero)
				id_setDrawFocusedItem_Z = JNIEnv.GetMethodID (class_ref, "setDrawFocusedItem", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDrawFocusedItem_Z, new JValue (drawFocusedItem));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawFocusedItem", "(Z)V"), new JValue (drawFocusedItem));
		}

		static Delegate cb_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_Handler ()
		{
			if (cb_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_ == null)
				cb_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_);
			return cb_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_;
		}

		static void n_SetOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener l = (global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnFocusChangeListener (l);
		}
#pragma warning restore 0169

		static IntPtr id_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='setOnFocusChangeListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.ItemizedOverlay.OnFocusChangeListener']]"
		[Register ("setOnFocusChangeListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener;)V", "GetSetOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_Handler")]
		public virtual void SetOnFocusChangeListener (global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener l)
		{
			if (id_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_ == IntPtr.Zero)
				id_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_ = JNIEnv.GetMethodID (class_ref, "setOnFocusChangeListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnFocusChangeListener_Lorg_osmdroid_views_overlay_ItemizedOverlay_OnFocusChangeListener_, new JValue (l));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnFocusChangeListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlay$OnFocusChangeListener;)V"), new JValue (l));
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
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public abstract int Size ();

#region "Event implementation for Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener"
		public event EventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlay.FocusChangeEventArgs> FocusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener, global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						__CreateIOnFocusChangeListenerImplementor,
						SetOnFocusChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListener, global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListenerImplementor>(
						ref weak_implementor_SetOnFocusChangeListener,
						global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListenerImplementor.__IsEmpty,
						__v => SetOnFocusChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnFocusChangeListener;

		global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListenerImplementor __CreateIOnFocusChangeListenerImplementor ()
		{
			return new global::Osmdroid.Views.Overlay.ItemizedOverlay.IOnFocusChangeListenerImplementor (this);
		}
#endregion
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
			global::Osmdroid.Views.Overlay.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point snapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_snapPoint, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IMapView mapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSnapToItem (x, y, snapPoint, mapView);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
		[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler")]
		public abstract bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView mapView);

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlay", DoNotGenerateAcw=true)]
	internal partial class ItemizedOverlayInvoker : ItemizedOverlay {

		public ItemizedOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlayInvoker); }
		}

		static IntPtr id_createItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;", "GetCreateItem_IHandler")]
		protected override global::Java.Lang.Object CreateItem (int i)
		{
			if (id_createItem_I == IntPtr.Zero)
				id_createItem_I = JNIEnv.GetMethodID (class_ref, "createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_createItem_I, new JValue (i)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			return JNIEnv.CallIntMethod  (Handle, id_size);
		}

		static IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlay']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
		[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler")]
		public override bool OnSnapToItem (int x, int y, global::Android.Graphics.Point snapPoint, global::Osmdroid.Api.IMapView mapView)
		{
			if (id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == IntPtr.Zero)
				id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNIEnv.GetMethodID (class_ref, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z");
			bool __ret = JNIEnv.CallBooleanMethod  (Handle, id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_, new JValue (x), new JValue (y), new JValue (snapPoint), new JValue (mapView));
			return __ret;
		}

	}

}
