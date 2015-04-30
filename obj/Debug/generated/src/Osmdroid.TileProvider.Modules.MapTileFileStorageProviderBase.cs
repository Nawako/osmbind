using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase", DoNotGenerateAcw=true)]
	public abstract partial class MapTileFileStorageProviderBase : global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase.MyBroadcastReceiver']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase$MyBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class MyBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase$MyBroadcastReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyBroadcastReceiver); }
			}

			protected MyBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase.MyBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase.MyBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase.MyBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), new JValue (p0), new JValue (p1));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileFileStorageProviderBase); }
		}

		protected MapTileFileStorageProviderBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase']/constructor[@name='MapTileFileStorageProviderBase' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;II)V", "")]
		public MapTileFileStorageProviderBase (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver, int pThreadPoolSize, int pPendingQueueSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileFileStorageProviderBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;II)V", new JValue (pRegisterReceiver), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;II)V", new JValue (pRegisterReceiver), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_II == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_II, new JValue (pRegisterReceiver), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_II, new JValue (pRegisterReceiver), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
		}

		static Delegate cb_getSdCardAvailable;
#pragma warning disable 0169
		static Delegate GetGetSdCardAvailableHandler ()
		{
			if (cb_getSdCardAvailable == null)
				cb_getSdCardAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSdCardAvailable);
			return cb_getSdCardAvailable;
		}

		static bool n_GetSdCardAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SdCardAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_getSdCardAvailable;
		protected virtual bool SdCardAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase']/method[@name='getSdCardAvailable' and count(parameter)=0]"
			[Register ("getSdCardAvailable", "()Z", "GetGetSdCardAvailableHandler")]
			get {
				if (id_getSdCardAvailable == IntPtr.Zero)
					id_getSdCardAvailable = JNIEnv.GetMethodID (class_ref, "getSdCardAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getSdCardAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSdCardAvailable", "()Z"));
			}
		}

		static Delegate cb_onMediaMounted;
#pragma warning disable 0169
		static Delegate GetOnMediaMountedHandler ()
		{
			if (cb_onMediaMounted == null)
				cb_onMediaMounted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaMounted);
			return cb_onMediaMounted;
		}

		static void n_OnMediaMounted (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaMounted ();
		}
#pragma warning restore 0169

		static IntPtr id_onMediaMounted;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase']/method[@name='onMediaMounted' and count(parameter)=0]"
		[Register ("onMediaMounted", "()V", "GetOnMediaMountedHandler")]
		protected virtual void OnMediaMounted ()
		{
			if (id_onMediaMounted == IntPtr.Zero)
				id_onMediaMounted = JNIEnv.GetMethodID (class_ref, "onMediaMounted", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onMediaMounted);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMediaMounted", "()V"));
		}

		static Delegate cb_onMediaUnmounted;
#pragma warning disable 0169
		static Delegate GetOnMediaUnmountedHandler ()
		{
			if (cb_onMediaUnmounted == null)
				cb_onMediaUnmounted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMediaUnmounted);
			return cb_onMediaUnmounted;
		}

		static void n_OnMediaUnmounted (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaUnmounted ();
		}
#pragma warning restore 0169

		static IntPtr id_onMediaUnmounted;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFileStorageProviderBase']/method[@name='onMediaUnmounted' and count(parameter)=0]"
		[Register ("onMediaUnmounted", "()V", "GetOnMediaUnmountedHandler")]
		protected virtual void OnMediaUnmounted ()
		{
			if (id_onMediaUnmounted == IntPtr.Zero)
				id_onMediaUnmounted = JNIEnv.GetMethodID (class_ref, "onMediaUnmounted", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onMediaUnmounted);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMediaUnmounted", "()V"));
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase", DoNotGenerateAcw=true)]
	internal partial class MapTileFileStorageProviderBaseInvoker : MapTileFileStorageProviderBase {

		public MapTileFileStorageProviderBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileFileStorageProviderBaseInvoker); }
		}

		static IntPtr id_getMaximumZoomLevel;
		public override int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler")]
			get {
				if (id_getMaximumZoomLevel == IntPtr.Zero)
					id_getMaximumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaximumZoomLevel", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMaximumZoomLevel);
			}
		}

		static IntPtr id_getMinimumZoomLevel;
		public override int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")]
			get {
				if (id_getMinimumZoomLevel == IntPtr.Zero)
					id_getMinimumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinimumZoomLevel", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMinimumZoomLevel);
			}
		}

		static IntPtr id_getName;
		protected override string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getThreadGroupName;
		protected override string ThreadGroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getThreadGroupName' and count(parameter)=0]"
			[Register ("getThreadGroupName", "()Ljava/lang/String;", "GetGetThreadGroupNameHandler")]
			get {
				if (id_getThreadGroupName == IntPtr.Zero)
					id_getThreadGroupName = JNIEnv.GetMethodID (class_ref, "getThreadGroupName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getThreadGroupName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getUsesDataConnection;
		public override bool UsesDataConnection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getUsesDataConnection' and count(parameter)=0]"
			[Register ("getUsesDataConnection", "()Z", "GetGetUsesDataConnectionHandler")]
			get {
				if (id_getUsesDataConnection == IntPtr.Zero)
					id_getUsesDataConnection = JNIEnv.GetMethodID (class_ref, "getUsesDataConnection", "()Z");
				return JNIEnv.CallBooleanMethod  (Handle, id_getUsesDataConnection);
			}
		}

		static IntPtr id_getTileLoader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getTileLoader' and count(parameter)=0]"
		[Register ("getTileLoader", "()Ljava/lang/Runnable;", "GetGetTileLoaderHandler")]
		protected override global::Java.Lang.IRunnable GetTileLoader ()
		{
			if (id_getTileLoader == IntPtr.Zero)
				id_getTileLoader = JNIEnv.GetMethodID (class_ref, "getTileLoader", "()Ljava/lang/Runnable;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (JNIEnv.CallObjectMethod  (Handle, id_getTileLoader), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public override void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource tileSource)
		{
			if (id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			JNIEnv.CallVoidMethod  (Handle, id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (tileSource));
		}

	}

}
