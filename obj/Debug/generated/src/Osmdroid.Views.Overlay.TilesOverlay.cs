using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/TilesOverlay", DoNotGenerateAcw=true)]
	public partial class TilesOverlay : global::Osmdroid.Views.Overlay.Overlay, global::Osmdroid.Views.Overlay.IOverlayMenuProvider {


		static IntPtr MENU_MAP_MODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/field[@name='MENU_MAP_MODE']"
		[Register ("MENU_MAP_MODE")]
		public static int MenuMapMode {
			get {
				if (MENU_MAP_MODE_jfieldId == IntPtr.Zero)
					MENU_MAP_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_MAP_MODE", "I");
				return JNIEnv.GetStaticIntField (class_ref, MENU_MAP_MODE_jfieldId);
			}
			set {
				if (MENU_MAP_MODE_jfieldId == IntPtr.Zero)
					MENU_MAP_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_MAP_MODE", "I");
				JNIEnv.SetStaticField (class_ref, MENU_MAP_MODE_jfieldId, value);
			}
		}

		static IntPtr MENU_OFFLINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/field[@name='MENU_OFFLINE']"
		[Register ("MENU_OFFLINE")]
		public static int MenuOffline {
			get {
				if (MENU_OFFLINE_jfieldId == IntPtr.Zero)
					MENU_OFFLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_OFFLINE", "I");
				return JNIEnv.GetStaticIntField (class_ref, MENU_OFFLINE_jfieldId);
			}
			set {
				if (MENU_OFFLINE_jfieldId == IntPtr.Zero)
					MENU_OFFLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_OFFLINE", "I");
				JNIEnv.SetStaticField (class_ref, MENU_OFFLINE_jfieldId, value);
			}
		}

		static IntPtr MENU_TILE_SOURCE_STARTING_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/field[@name='MENU_TILE_SOURCE_STARTING_ID']"
		[Register ("MENU_TILE_SOURCE_STARTING_ID")]
		public static int MenuTileSourceStartingId {
			get {
				if (MENU_TILE_SOURCE_STARTING_ID_jfieldId == IntPtr.Zero)
					MENU_TILE_SOURCE_STARTING_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_TILE_SOURCE_STARTING_ID", "I");
				return JNIEnv.GetStaticIntField (class_ref, MENU_TILE_SOURCE_STARTING_ID_jfieldId);
			}
			set {
				if (MENU_TILE_SOURCE_STARTING_ID_jfieldId == IntPtr.Zero)
					MENU_TILE_SOURCE_STARTING_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MENU_TILE_SOURCE_STARTING_ID", "I");
				JNIEnv.SetStaticField (class_ref, MENU_TILE_SOURCE_STARTING_ID_jfieldId, value);
			}
		}

		static IntPtr mDebugPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/field[@name='mDebugPaint']"
		[Register ("mDebugPaint")]
		protected global::Android.Graphics.Paint MDebugPaint {
			get {
				if (mDebugPaint_jfieldId == IntPtr.Zero)
					mDebugPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mDebugPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDebugPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDebugPaint_jfieldId == IntPtr.Zero)
					mDebugPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mDebugPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDebugPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTileProvider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/field[@name='mTileProvider']"
		[Register ("mTileProvider")]
		protected global::Osmdroid.TileProvider.MapTileProviderBase MTileProvider {
			get {
				if (mTileProvider_jfieldId == IntPtr.Zero)
					mTileProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileProvider", "Lorg/osmdroid/tileprovider/MapTileProviderBase;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTileProvider_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTileProvider_jfieldId == IntPtr.Zero)
					mTileProvider_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileProvider", "Lorg/osmdroid/tileprovider/MapTileProviderBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTileProvider_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/TilesOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TilesOverlay); }
		}

		protected TilesOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/constructor[@name='TilesOverlay' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/content/Context;)V", "")]
		public TilesOverlay (global::Osmdroid.TileProvider.MapTileProviderBase aTileProvider, global::Android.Content.Context aContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TilesOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/content/Context;)V", new JValue (aTileProvider), new JValue (aContext)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/content/Context;)V", new JValue (aTileProvider), new JValue (aContext));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_content_Context_, new JValue (aTileProvider), new JValue (aContext)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_content_Context_, new JValue (aTileProvider), new JValue (aContext));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/constructor[@name='TilesOverlay' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Lorg/osmdroid/ResourceProxy;)V", "")]
		public TilesOverlay (global::Osmdroid.TileProvider.MapTileProviderBase aTileProvider, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TilesOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Lorg/osmdroid/ResourceProxy;)V", new JValue (aTileProvider), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Lorg/osmdroid/ResourceProxy;)V", new JValue (aTileProvider), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Lorg_osmdroid_ResourceProxy_, new JValue (aTileProvider), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_Lorg_osmdroid_ResourceProxy_, new JValue (aTileProvider), new JValue (pResourceProxy));
		}

		static Delegate cb_getLoadingBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetLoadingBackgroundColorHandler ()
		{
			if (cb_getLoadingBackgroundColor == null)
				cb_getLoadingBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoadingBackgroundColor);
			return cb_getLoadingBackgroundColor;
		}

		static int n_GetLoadingBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadingBackgroundColor;
		}
#pragma warning restore 0169

		static Delegate cb_setLoadingBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetLoadingBackgroundColor_IHandler ()
		{
			if (cb_setLoadingBackgroundColor_I == null)
				cb_setLoadingBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLoadingBackgroundColor_I);
			return cb_setLoadingBackgroundColor_I;
		}

		static void n_SetLoadingBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int pLoadingBackgroundColor)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadingBackgroundColor = pLoadingBackgroundColor;
		}
#pragma warning restore 0169

		static IntPtr id_getLoadingBackgroundColor;
		static IntPtr id_setLoadingBackgroundColor_I;
		public virtual int LoadingBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='getLoadingBackgroundColor' and count(parameter)=0]"
			[Register ("getLoadingBackgroundColor", "()I", "GetGetLoadingBackgroundColorHandler")]
			get {
				if (id_getLoadingBackgroundColor == IntPtr.Zero)
					id_getLoadingBackgroundColor = JNIEnv.GetMethodID (class_ref, "getLoadingBackgroundColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLoadingBackgroundColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadingBackgroundColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='setLoadingBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLoadingBackgroundColor", "(I)V", "GetSetLoadingBackgroundColor_IHandler")]
			set {
				if (id_setLoadingBackgroundColor_I == IntPtr.Zero)
					id_setLoadingBackgroundColor_I = JNIEnv.GetMethodID (class_ref, "setLoadingBackgroundColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLoadingBackgroundColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoadingBackgroundColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getLoadingLineColor;
#pragma warning disable 0169
		static Delegate GetGetLoadingLineColorHandler ()
		{
			if (cb_getLoadingLineColor == null)
				cb_getLoadingLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoadingLineColor);
			return cb_getLoadingLineColor;
		}

		static int n_GetLoadingLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoadingLineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setLoadingLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetLoadingLineColor_IHandler ()
		{
			if (cb_setLoadingLineColor_I == null)
				cb_setLoadingLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLoadingLineColor_I);
			return cb_setLoadingLineColor_I;
		}

		static void n_SetLoadingLineColor_I (IntPtr jnienv, IntPtr native__this, int pLoadingLineColor)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadingLineColor = pLoadingLineColor;
		}
#pragma warning restore 0169

		static IntPtr id_getLoadingLineColor;
		static IntPtr id_setLoadingLineColor_I;
		public virtual int LoadingLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='getLoadingLineColor' and count(parameter)=0]"
			[Register ("getLoadingLineColor", "()I", "GetGetLoadingLineColorHandler")]
			get {
				if (id_getLoadingLineColor == IntPtr.Zero)
					id_getLoadingLineColor = JNIEnv.GetMethodID (class_ref, "getLoadingLineColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLoadingLineColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoadingLineColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='setLoadingLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLoadingLineColor", "(I)V", "GetSetLoadingLineColor_IHandler")]
			set {
				if (id_setLoadingLineColor_I == IntPtr.Zero)
					id_setLoadingLineColor_I = JNIEnv.GetMethodID (class_ref, "setLoadingLineColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLoadingLineColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLoadingLineColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getMaximumZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaximumZoomLevelHandler ()
		{
			if (cb_getMaximumZoomLevel == null)
				cb_getMaximumZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumZoomLevel);
			return cb_getMaximumZoomLevel;
		}

		static int n_GetMaximumZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumZoomLevel;
		public virtual int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler")]
			get {
				if (id_getMaximumZoomLevel == IntPtr.Zero)
					id_getMaximumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaximumZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaximumZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumZoomLevel", "()I"));
			}
		}

		static Delegate cb_getMinimumZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinimumZoomLevelHandler ()
		{
			if (cb_getMinimumZoomLevel == null)
				cb_getMinimumZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimumZoomLevel);
			return cb_getMinimumZoomLevel;
		}

		static int n_GetMinimumZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumZoomLevel;
		public virtual int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")]
			get {
				if (id_getMinimumZoomLevel == IntPtr.Zero)
					id_getMinimumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinimumZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinimumZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumZoomLevel", "()I"));
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptionsMenuEnabled = pOptionsMenuEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isOptionsMenuEnabled;
		static IntPtr id_setOptionsMenuEnabled_Z;
		public virtual bool OptionsMenuEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='isOptionsMenuEnabled' and count(parameter)=0]"
			[Register ("isOptionsMenuEnabled", "()Z", "GetIsOptionsMenuEnabledHandler")]
			get {
				if (id_isOptionsMenuEnabled == IntPtr.Zero)
					id_isOptionsMenuEnabled = JNIEnv.GetMethodID (class_ref, "isOptionsMenuEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOptionsMenuEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOptionsMenuEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='setOptionsMenuEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getOvershootTileCache;
#pragma warning disable 0169
		static Delegate GetGetOvershootTileCacheHandler ()
		{
			if (cb_getOvershootTileCache == null)
				cb_getOvershootTileCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOvershootTileCache);
			return cb_getOvershootTileCache;
		}

		static int n_GetOvershootTileCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OvershootTileCache;
		}
#pragma warning restore 0169

		static Delegate cb_setOvershootTileCache_I;
#pragma warning disable 0169
		static Delegate GetSetOvershootTileCache_IHandler ()
		{
			if (cb_setOvershootTileCache_I == null)
				cb_setOvershootTileCache_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOvershootTileCache_I);
			return cb_setOvershootTileCache_I;
		}

		static void n_SetOvershootTileCache_I (IntPtr jnienv, IntPtr native__this, int overshootTileCache)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OvershootTileCache = overshootTileCache;
		}
#pragma warning restore 0169

		static IntPtr id_getOvershootTileCache;
		static IntPtr id_setOvershootTileCache_I;
		public virtual int OvershootTileCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='getOvershootTileCache' and count(parameter)=0]"
			[Register ("getOvershootTileCache", "()I", "GetGetOvershootTileCacheHandler")]
			get {
				if (id_getOvershootTileCache == IntPtr.Zero)
					id_getOvershootTileCache = JNIEnv.GetMethodID (class_ref, "getOvershootTileCache", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getOvershootTileCache);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOvershootTileCache", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='setOvershootTileCache' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOvershootTileCache", "(I)V", "GetSetOvershootTileCache_IHandler")]
			set {
				if (id_setOvershootTileCache_I == IntPtr.Zero)
					id_setOvershootTileCache_I = JNIEnv.GetMethodID (class_ref, "setOvershootTileCache", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setOvershootTileCache_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOvershootTileCache", "(I)V"), new JValue (value));
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, osmv, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (osmv), new JValue (shadow));
		}

		static Delegate cb_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetDrawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_Handler ()
		{
			if (cb_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ == null)
				cb_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_DrawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_);
			return cb_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
		}

		static void n_DrawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_projection, int zoomLevel, int tileSizePx, IntPtr native_viewPort)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Projection projection = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (native_projection, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect viewPort = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_viewPort, JniHandleOwnership.DoNotTransfer);
			__this.DrawTiles (c, projection, zoomLevel, tileSizePx, viewPort);
		}
#pragma warning restore 0169

		static IntPtr id_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='drawTiles' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.Projection'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.graphics.Rect']]"
		[Register ("drawTiles", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V", "GetDrawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_Handler")]
		public virtual void DrawTiles (global::Android.Graphics.Canvas c, global::Osmdroid.Views.Projection projection, int zoomLevel, int tileSizePx, global::Android.Graphics.Rect viewPort)
		{
			if (id_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ == IntPtr.Zero)
				id_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "drawTiles", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawTiles_Landroid_graphics_Canvas_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_, new JValue (c), new JValue (projection), new JValue (zoomLevel), new JValue (tileSizePx), new JValue (viewPort));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawTiles", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V"), new JValue (c), new JValue (projection), new JValue (zoomLevel), new JValue (tileSizePx), new JValue (viewPort));
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnCreateOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='onCreateOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem pItem = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_pItem, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnOptionsItemSelected (pItem, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onOptionsItemSelected_Landroid_view_MenuItem_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='onOptionsItemSelected' and count(parameter)=3 and parameter[1][@type='android.view.MenuItem'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenu pMenu = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_pMenu, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView pMapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnPrepareOptionsMenu (pMenu, pMenuIdOffset, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareOptionsMenu_Landroid_view_Menu_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='onPrepareOptionsMenu' and count(parameter)=3 and parameter[1][@type='android.view.Menu'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapView']]"
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

		static Delegate cb_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetOnTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_Handler ()
		{
			if (cb_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_ == null)
				cb_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_);
			return cb_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_;
		}

		static void n_OnTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_currentMapTile, IntPtr native_tileRect)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable currentMapTile = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_currentMapTile, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect tileRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_tileRect, JniHandleOwnership.DoNotTransfer);
			__this.OnTileReadyToDraw (c, currentMapTile, tileRect);
		}
#pragma warning restore 0169

		static IntPtr id_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='onTileReadyToDraw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("onTileReadyToDraw", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;Landroid/graphics/Rect;)V", "GetOnTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_Handler")]
		protected virtual void OnTileReadyToDraw (global::Android.Graphics.Canvas c, global::Android.Graphics.Drawables.Drawable currentMapTile, global::Android.Graphics.Rect tileRect)
		{
			if (id_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "onTileReadyToDraw", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;Landroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onTileReadyToDraw_Landroid_graphics_Canvas_Landroid_graphics_drawable_Drawable_Landroid_graphics_Rect_, new JValue (c), new JValue (currentMapTile), new JValue (tileRect));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTileReadyToDraw", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;Landroid/graphics/Rect;)V"), new JValue (c), new JValue (currentMapTile), new JValue (tileRect));
		}

		static Delegate cb_setUseDataConnection_Z;
#pragma warning disable 0169
		static Delegate GetSetUseDataConnection_ZHandler ()
		{
			if (cb_setUseDataConnection_Z == null)
				cb_setUseDataConnection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseDataConnection_Z);
			return cb_setUseDataConnection_Z;
		}

		static void n_SetUseDataConnection_Z (IntPtr jnienv, IntPtr native__this, bool aMode)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseDataConnection (aMode);
		}
#pragma warning restore 0169

		static IntPtr id_setUseDataConnection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='setUseDataConnection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseDataConnection", "(Z)V", "GetSetUseDataConnection_ZHandler")]
		public virtual void SetUseDataConnection (bool aMode)
		{
			if (id_setUseDataConnection_Z == IntPtr.Zero)
				id_setUseDataConnection_Z = JNIEnv.GetMethodID (class_ref, "setUseDataConnection", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUseDataConnection_Z, new JValue (aMode));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseDataConnection", "(Z)V"), new JValue (aMode));
		}

		static Delegate cb_useDataConnection;
#pragma warning disable 0169
		static Delegate GetUseDataConnectionHandler ()
		{
			if (cb_useDataConnection == null)
				cb_useDataConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseDataConnection);
			return cb_useDataConnection;
		}

		static bool n_UseDataConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.TilesOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.TilesOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDataConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_useDataConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='TilesOverlay']/method[@name='useDataConnection' and count(parameter)=0]"
		[Register ("useDataConnection", "()Z", "GetUseDataConnectionHandler")]
		public virtual bool UseDataConnection ()
		{
			if (id_useDataConnection == IntPtr.Zero)
				id_useDataConnection = JNIEnv.GetMethodID (class_ref, "useDataConnection", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_useDataConnection);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useDataConnection", "()Z"));
		}

	}
}
