using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/NonAcceleratedOverlay", DoNotGenerateAcw=true)]
	public abstract partial class NonAcceleratedOverlay : global::Osmdroid.Views.Overlay.Overlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/NonAcceleratedOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonAcceleratedOverlay); }
		}

		protected NonAcceleratedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/constructor[@name='NonAcceleratedOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public NonAcceleratedOverlay (global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NonAcceleratedOverlay)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/constructor[@name='NonAcceleratedOverlay' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/ResourceProxy;)V", "")]
		public NonAcceleratedOverlay (global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NonAcceleratedOverlay)) {
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

		static Delegate cb_isUsingBackingBitmap;
#pragma warning disable 0169
		static Delegate GetIsUsingBackingBitmapHandler ()
		{
			if (cb_isUsingBackingBitmap == null)
				cb_isUsingBackingBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUsingBackingBitmap);
			return cb_isUsingBackingBitmap;
		}

		static bool n_IsUsingBackingBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.NonAcceleratedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.NonAcceleratedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUsingBackingBitmap;
		}
#pragma warning restore 0169

		static IntPtr id_isUsingBackingBitmap;
		public virtual bool IsUsingBackingBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/method[@name='isUsingBackingBitmap' and count(parameter)=0]"
			[Register ("isUsingBackingBitmap", "()Z", "GetIsUsingBackingBitmapHandler")]
			get {
				if (id_isUsingBackingBitmap == IntPtr.Zero)
					id_isUsingBackingBitmap = JNIEnv.GetMethodID (class_ref, "isUsingBackingBitmap", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isUsingBackingBitmap);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUsingBackingBitmap", "()Z"));
			}
		}

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "")]
		public override sealed void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_acceleratedCanvas, IntPtr native_osmv, bool shadow)
		{
			global::Osmdroid.Views.Overlay.NonAcceleratedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.NonAcceleratedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas acceleratedCanvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_acceleratedCanvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (c, acceleratedCanvas, osmv, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/method[@name='onDraw' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='org.osmdroid.views.MapView'] and parameter[4][@type='boolean']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetOnDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		protected virtual void OnDraw (global::Android.Graphics.Canvas c, global::Android.Graphics.Canvas acceleratedCanvas, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (acceleratedCanvas), new JValue (osmv), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(Landroid/graphics/Canvas;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (acceleratedCanvas), new JValue (osmv), new JValue (shadow));
		}

		static Delegate cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetOnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_OnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_osmv, bool shadow)
		{
			global::Osmdroid.Views.Overlay.NonAcceleratedOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.NonAcceleratedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (c, osmv, shadow);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/method[@name='onDraw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetOnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		protected abstract void OnDraw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow);

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/NonAcceleratedOverlay", DoNotGenerateAcw=true)]
	internal partial class NonAcceleratedOverlayInvoker : NonAcceleratedOverlay {

		public NonAcceleratedOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (NonAcceleratedOverlayInvoker); }
		}

		static IntPtr id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='NonAcceleratedOverlay']/method[@name='onDraw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetOnDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		protected override void OnDraw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "onDraw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");
			JNIEnv.CallVoidMethod  (Handle, id_onDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
		}

	}

}
