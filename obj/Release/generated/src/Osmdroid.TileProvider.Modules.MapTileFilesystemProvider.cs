using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileFilesystemProvider", DoNotGenerateAcw=true)]
	public partial class MapTileFilesystemProvider : global::Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider.TileLoader']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileFilesystemProvider$TileLoader", DoNotGenerateAcw=true)]
		protected internal new partial class TileLoader : global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileFilesystemProvider$TileLoader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TileLoader); }
			}

			protected TileLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileFilesystemProvider_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider.TileLoader']/constructor[@name='MapTileFilesystemProvider.TileLoader' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.modules.MapTileFilesystemProvider']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/modules/MapTileFilesystemProvider;)V", "")]
			protected TileLoader (global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (TileLoader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileFilesystemProvider_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileFilesystemProvider_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/modules/MapTileFilesystemProvider;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileFilesystemProvider_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileFilesystemProvider_, new JValue (__self));
			}

			static Delegate cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
			static Delegate GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
			{
				if (cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
					cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_);
				return cb_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			}

			static IntPtr n_LoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState)
			{
				global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadTile (pState));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider.TileLoader']/method[@name='loadTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
			[Register ("loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;", "GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
			public override global::Android.Graphics.Drawables.Drawable LoadTile (global::Osmdroid.TileProvider.MapTileRequestState pState)
			{
				if (id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
					id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;");

				global::Android.Graphics.Drawables.Drawable __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (pState)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;"), new JValue (pState)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileFilesystemProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileFilesystemProvider); }
		}

		protected MapTileFilesystemProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/constructor[@name='MapTileFilesystemProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", "")]
		public MapTileFilesystemProvider (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileFilesystemProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", new JValue (pRegisterReceiver)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", new JValue (pRegisterReceiver));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_, new JValue (pRegisterReceiver)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_, new JValue (pRegisterReceiver));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/constructor[@name='MapTileFilesystemProvider' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;J)V", "")]
		public MapTileFilesystemProvider (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver, global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, long pMaximumCachedFileAge) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileFilesystemProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;J)V", new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;J)V", new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_J == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_J, new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_J, new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_JII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/constructor[@name='MapTileFilesystemProvider' and count(parameter)=5 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;JII)V", "")]
		public MapTileFilesystemProvider (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver, global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, long pMaximumCachedFileAge, int pThreadPoolSize, int pPendingQueueSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileFilesystemProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;JII)V", new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;JII)V", new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_JII == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_JII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;JII)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_JII, new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_JII, new JValue (pRegisterReceiver), new JValue (pTileSource), new JValue (pMaximumCachedFileAge), new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/constructor[@name='MapTileFilesystemProvider' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "")]
		public MapTileFilesystemProvider (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver, global::Osmdroid.TileProvider.TileSource.ITileSource aTileSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileFilesystemProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pRegisterReceiver), new JValue (aTileSource)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pRegisterReceiver), new JValue (aTileSource));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pRegisterReceiver), new JValue (aTileSource)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pRegisterReceiver), new JValue (aTileSource));
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumZoomLevel;
		public override int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumZoomLevel;
		public override int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		protected override string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getName' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThreadGroupName);
		}
#pragma warning restore 0169

		static IntPtr id_getThreadGroupName;
		protected override string ThreadGroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getThreadGroupName' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsesDataConnection;
		}
#pragma warning restore 0169

		static IntPtr id_getUsesDataConnection;
		public override bool UsesDataConnection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getUsesDataConnection' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTileLoader ());
		}
#pragma warning restore 0169

		static IntPtr id_getTileLoader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='getTileLoader' and count(parameter)=0]"
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

		static void n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTileSource)
		{
			global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileFilesystemProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_pTileSource, JniHandleOwnership.DoNotTransfer);
			__this.SetTileSource (pTileSource);
		}
#pragma warning restore 0169

		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileFilesystemProvider']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public override void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource)
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
