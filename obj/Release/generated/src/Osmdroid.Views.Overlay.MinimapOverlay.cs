using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/MinimapOverlay", DoNotGenerateAcw=true)]
	public partial class MinimapOverlay : global::Osmdroid.Views.Overlay.TilesOverlay {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/MinimapOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MinimapOverlay); }
		}

		protected MinimapOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/constructor[@name='MinimapOverlay' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", "")]
		public MinimapOverlay (global::Android.Content.Context pContext, global::Android.OS.Handler pTileRequestCompleteHandler, global::Osmdroid.TileProvider.MapTileProviderBase pTileProvider, int pZoomDifference) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MinimapOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider), new JValue (pZoomDifference)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider), new JValue (pZoomDifference));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider), new JValue (pZoomDifference)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider), new JValue (pZoomDifference));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/constructor[@name='MinimapOverlay' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler'] and parameter[3][@type='org.osmdroid.tileprovider.MapTileProviderBase']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", "")]
		public MinimapOverlay (global::Android.Content.Context pContext, global::Android.OS.Handler pTileRequestCompleteHandler, global::Osmdroid.TileProvider.MapTileProviderBase pTileProvider) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MinimapOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_, new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_Lorg_osmdroid_tileprovider_MapTileProviderBase_, new JValue (pContext), new JValue (pTileRequestCompleteHandler), new JValue (pTileProvider));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/constructor[@name='MinimapOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/os/Handler;)V", "")]
		public MinimapOverlay (global::Android.Content.Context pContext, global::Android.OS.Handler pTileRequestCompleteHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MinimapOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/os/Handler;)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/os/Handler;)V", new JValue (pContext), new JValue (pTileRequestCompleteHandler));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/os/Handler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_, new JValue (pContext), new JValue (pTileRequestCompleteHandler)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_os_Handler_, new JValue (pContext), new JValue (pTileRequestCompleteHandler));
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		static IntPtr id_setHeight_I;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				if (id_setHeight_I == IntPtr.Zero)
					id_setHeight_I = JNIEnv.GetMethodID (class_ref, "setHeight", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHeight_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeight", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getPadding;
#pragma warning disable 0169
		static Delegate GetGetPaddingHandler ()
		{
			if (cb_getPadding == null)
				cb_getPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPadding);
			return cb_getPadding;
		}

		static int n_GetPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		static Delegate cb_setPadding_I;
#pragma warning disable 0169
		static Delegate GetSetPadding_IHandler ()
		{
			if (cb_setPadding_I == null)
				cb_setPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPadding_I);
			return cb_setPadding_I;
		}

		static void n_SetPadding_I (IntPtr jnienv, IntPtr native__this, int padding)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = padding;
		}
#pragma warning restore 0169

		static IntPtr id_getPadding;
		static IntPtr id_setPadding_I;
		public virtual int Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()I", "GetGetPaddingHandler")]
			get {
				if (id_getPadding == IntPtr.Zero)
					id_getPadding = JNIEnv.GetMethodID (class_ref, "getPadding", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPadding);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPadding", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPadding", "(I)V", "GetSetPadding_IHandler")]
			set {
				if (id_setPadding_I == IntPtr.Zero)
					id_setPadding_I = JNIEnv.GetMethodID (class_ref, "setPadding", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPadding_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPadding", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_I;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				if (id_setWidth_I == IntPtr.Zero)
					id_setWidth_I = JNIEnv.GetMethodID (class_ref, "setWidth", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWidth_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getZoomDifference;
#pragma warning disable 0169
		static Delegate GetGetZoomDifferenceHandler ()
		{
			if (cb_getZoomDifference == null)
				cb_getZoomDifference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomDifference);
			return cb_getZoomDifference;
		}

		static int n_GetZoomDifference (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomDifference;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomDifference_I;
#pragma warning disable 0169
		static Delegate GetSetZoomDifference_IHandler ()
		{
			if (cb_setZoomDifference_I == null)
				cb_setZoomDifference_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomDifference_I);
			return cb_setZoomDifference_I;
		}

		static void n_SetZoomDifference_I (IntPtr jnienv, IntPtr native__this, int zoomDifference)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomDifference = zoomDifference;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomDifference;
		static IntPtr id_setZoomDifference_I;
		public virtual int ZoomDifference {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='getZoomDifference' and count(parameter)=0]"
			[Register ("getZoomDifference", "()I", "GetGetZoomDifferenceHandler")]
			get {
				if (id_getZoomDifference == IntPtr.Zero)
					id_getZoomDifference = JNIEnv.GetMethodID (class_ref, "getZoomDifference", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getZoomDifference);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomDifference", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='setZoomDifference' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoomDifference", "(I)V", "GetSetZoomDifference_IHandler")]
			set {
				if (id_setZoomDifference_I == IntPtr.Zero)
					id_setZoomDifference_I = JNIEnv.GetMethodID (class_ref, "setZoomDifference", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomDifference_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomDifference", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
#pragma warning disable 0169
		static Delegate GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler ()
		{
			if (cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == null)
				cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_);
			return cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		}

		static void n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTileSource)
		{
			global::Osmdroid.Views.Overlay.MinimapOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MinimapOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_pTileSource, JniHandleOwnership.DoNotTransfer);
			__this.SetTileSource (pTileSource);
		}
#pragma warning restore 0169

		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='MinimapOverlay']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public virtual void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource)
		{
			if (id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pTileSource));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V"), new JValue (pTileSource));
		}

	}
}
