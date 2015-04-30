using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Mapsforge {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileModuleProvider", DoNotGenerateAcw=true)]
	public partial class MapsForgeTileModuleProvider : global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider.TileLoader']"
		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileModuleProvider$TileLoader", DoNotGenerateAcw=true)]
		public new partial class TileLoader : global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileModuleProvider$TileLoader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TileLoader); }
			}

			protected TileLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
			static Delegate GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
			{
				if (cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
					cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_);
				return cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			}

			static IntPtr n_LoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider.TileLoader __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadTile (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider.TileLoader']/method[@name='loadTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
			[Register ("loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;", "GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
			public override global::Android.Graphics.Drawables.Drawable LoadTile (global::Osmdroid.TileProvider.MapTileRequestState p0)
			{
				if (id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
					id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;");

				global::Android.Graphics.Drawables.Drawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileModuleProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapsForgeTileModuleProvider); }
		}

		protected MapsForgeTileModuleProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumZoomLevel;
		public override int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
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
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumZoomLevel;
		public override int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		protected override string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getThreadGroupName;
#pragma warning disable 0169
		static Delegate GetGetThreadGroupNameHandler ()
		{
			if (cb_getThreadGroupName == null)
				cb_getThreadGroupName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThreadGroupName);
			return cb_getThreadGroupName;
		}

		static IntPtr n_GetThreadGroupName (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThreadGroupName);
		}
#pragma warning restore 0169

		static IntPtr id_getThreadGroupName;
		protected override string ThreadGroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getThreadGroupName' and count(parameter)=0]"
			[Register ("getThreadGroupName", "()Ljava/lang/String;", "GetGetThreadGroupNameHandler")]
			get {
				if (id_getThreadGroupName == IntPtr.Zero)
					id_getThreadGroupName = JNIEnv.GetMethodID (class_ref, "getThreadGroupName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getThreadGroupName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThreadGroupName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUsesDataConnection;
#pragma warning disable 0169
		static Delegate GetGetUsesDataConnectionHandler ()
		{
			if (cb_getUsesDataConnection == null)
				cb_getUsesDataConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUsesDataConnection);
			return cb_getUsesDataConnection;
		}

		static bool n_GetUsesDataConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsesDataConnection;
		}
#pragma warning restore 0169

		static IntPtr id_getUsesDataConnection;
		public override bool UsesDataConnection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getUsesDataConnection' and count(parameter)=0]"
			[Register ("getUsesDataConnection", "()Z", "GetGetUsesDataConnectionHandler")]
			get {
				if (id_getUsesDataConnection == IntPtr.Zero)
					id_getUsesDataConnection = JNIEnv.GetMethodID (class_ref, "getUsesDataConnection", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getUsesDataConnection);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsesDataConnection", "()Z"));
			}
		}

		static Delegate cb_getTileLoader;
#pragma warning disable 0169
		static Delegate GetGetTileLoaderHandler ()
		{
			if (cb_getTileLoader == null)
				cb_getTileLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileLoader);
			return cb_getTileLoader;
		}

		static IntPtr n_GetTileLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTileLoader ());
		}
#pragma warning restore 0169

		static IntPtr id_getTileLoader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='getTileLoader' and count(parameter)=0]"
		[Register ("getTileLoader", "()Ljava/lang/Runnable;", "GetGetTileLoaderHandler")]
		protected override global::Java.Lang.IRunnable GetTileLoader ()
		{
			if (id_getTileLoader == IntPtr.Zero)
				id_getTileLoader = JNIEnv.GetMethodID (class_ref, "getTileLoader", "()Ljava/lang/Runnable;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod  (Handle, id_getTileLoader), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileLoader", "()Ljava/lang/Runnable;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
#pragma warning disable 0169
		static Delegate GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler ()
		{
			if (cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == null)
				cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_);
			return cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		}

		static void n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.MapsForgeTileModuleProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource p0 = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTileSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileModuleProvider']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public override void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource p0)
		{
			if (id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V"), new JValue (p0));
		}

	}
}
