using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase", DoNotGenerateAcw=true)]
	public abstract partial class MapTileProviderBase : global::Java.Lang.Object, global::Osmdroid.TileProvider.IMapTileProviderCallback {


		static IntPtr mTileCache_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/field[@name='mTileCache']"
		[Register ("mTileCache")]
		protected global::Osmdroid.TileProvider.MapTileCache MTileCache {
			get {
				if (mTileCache_jfieldId == IntPtr.Zero)
					mTileCache_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileCache", "Lorg/osmdroid/tileprovider/MapTileCache;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTileCache_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTileCache_jfieldId == IntPtr.Zero)
					mTileCache_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileCache", "Lorg/osmdroid/tileprovider/MapTileCache;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTileCache_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTileRequestCompleteHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/field[@name='mTileRequestCompleteHandler']"
		[Register ("mTileRequestCompleteHandler")]
		protected global::Android.OS.Handler MTileRequestCompleteHandler {
			get {
				if (mTileRequestCompleteHandler_jfieldId == IntPtr.Zero)
					mTileRequestCompleteHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileRequestCompleteHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTileRequestCompleteHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTileRequestCompleteHandler_jfieldId == IntPtr.Zero)
					mTileRequestCompleteHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileRequestCompleteHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTileRequestCompleteHandler_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mUseDataConnection_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/field[@name='mUseDataConnection']"
		[Register ("mUseDataConnection")]
		protected bool MUseDataConnection {
			get {
				if (mUseDataConnection_jfieldId == IntPtr.Zero)
					mUseDataConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mUseDataConnection", "Z");
				return JNIEnv.GetBooleanField (Handle, mUseDataConnection_jfieldId);
			}
			set {
				if (mUseDataConnection_jfieldId == IntPtr.Zero)
					mUseDataConnection_jfieldId = JNIEnv.GetFieldID (class_ref, "mUseDataConnection", "Z");
				JNIEnv.SetField (Handle, mUseDataConnection_jfieldId, value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.tileprovider.constants.OpenStreetMapTileProviderConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='CACHE_MAPTILECOUNT_DEFAULT']"
			[Register ("CACHE_MAPTILECOUNT_DEFAULT")]
			public const int CacheMaptilecountDefault = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='DEBUG_TILE_PROVIDERS']"
			[Register ("DEBUG_TILE_PROVIDERS")]
			public const bool DebugTileProviders = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='DEFAULT_MAXIMUM_CACHED_FILE_AGE']"
			[Register ("DEFAULT_MAXIMUM_CACHED_FILE_AGE")]
			public const long DefaultMaximumCachedFileAge = (long) 604800000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='MAXIMUM_ZOOMLEVEL']"
			[Register ("MAXIMUM_ZOOMLEVEL")]
			public const int MaximumZoomlevel = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='MINIMUM_ZOOMLEVEL']"
			[Register ("MINIMUM_ZOOMLEVEL")]
			public const int MinimumZoomlevel = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='NUMBER_OF_TILE_DOWNLOAD_THREADS']"
			[Register ("NUMBER_OF_TILE_DOWNLOAD_THREADS")]
			public const int NumberOfTileDownloadThreads = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='NUMBER_OF_TILE_FILESYSTEM_THREADS']"
			[Register ("NUMBER_OF_TILE_FILESYSTEM_THREADS")]
			public const int NumberOfTileFilesystemThreads = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_DAY']"
			[Register ("ONE_DAY")]
			public const long OneDay = (long) 86400000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_HOUR']"
			[Register ("ONE_HOUR")]
			public const long OneHour = (long) 3600000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_MINUTE']"
			[Register ("ONE_MINUTE")]
			public const long OneMinute = (long) 60000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_SECOND']"
			[Register ("ONE_SECOND")]
			public const long OneSecond = (long) 1000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_WEEK']"
			[Register ("ONE_WEEK")]
			public const long OneWeek = (long) 604800000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='ONE_YEAR']"
			[Register ("ONE_YEAR")]
			public const long OneYear = (long) 31536000000L;

			static IntPtr OSMDROID_PATH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='OSMDROID_PATH']"
			[Register ("OSMDROID_PATH")]
			public static global::Java.IO.File OsmdroidPath {
				get {
					if (OSMDROID_PATH_jfieldId == IntPtr.Zero)
						OSMDROID_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OSMDROID_PATH", "Ljava/io/File;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OSMDROID_PATH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (OSMDROID_PATH_jfieldId == IntPtr.Zero)
						OSMDROID_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OSMDROID_PATH", "Ljava/io/File;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, OSMDROID_PATH_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_DOWNLOAD_MAXIMUM_QUEUE_SIZE']"
			[Register ("TILE_DOWNLOAD_MAXIMUM_QUEUE_SIZE")]
			public const int TileDownloadMaximumQueueSize = (int) 40;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_EXPIRY_TIME_MILLISECONDS']"
			[Register ("TILE_EXPIRY_TIME_MILLISECONDS")]
			public const long TileExpiryTimeMilliseconds = (long) 2592000000L;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_FILESYSTEM_MAXIMUM_QUEUE_SIZE']"
			[Register ("TILE_FILESYSTEM_MAXIMUM_QUEUE_SIZE")]
			public const int TileFilesystemMaximumQueueSize = (int) 40;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_MAX_CACHE_SIZE_BYTES']"
			[Register ("TILE_MAX_CACHE_SIZE_BYTES")]
			public const long TileMaxCacheSizeBytes = (long) 629145600L;

			static IntPtr TILE_PATH_BASE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_PATH_BASE']"
			[Register ("TILE_PATH_BASE")]
			public static global::Java.IO.File TilePathBase {
				get {
					if (TILE_PATH_BASE_jfieldId == IntPtr.Zero)
						TILE_PATH_BASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TILE_PATH_BASE", "Ljava/io/File;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TILE_PATH_BASE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TILE_PATH_BASE_jfieldId == IntPtr.Zero)
						TILE_PATH_BASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TILE_PATH_BASE", "Ljava/io/File;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TILE_PATH_BASE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_PATH_EXTENSION']"
			[Register ("TILE_PATH_EXTENSION")]
			public const string TilePathExtension = (string) ".tile";

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.constants']/interface[@name='OpenStreetMapTileProviderConstants']/field[@name='TILE_TRIM_CACHE_SIZE_BYTES']"
			[Register ("TILE_TRIM_CACHE_SIZE_BYTES")]
			public const long TileTrimCacheSizeBytes = (long) 524288000L;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase$ScaleTileLooper", DoNotGenerateAcw=true)]
		public abstract partial class ScaleTileLooper : global::Org.Osmdroid.Util.TileLooper {


			static IntPtr mDebugPaint_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mDebugPaint']"
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

			static IntPtr mDestRect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mDestRect']"
			[Register ("mDestRect")]
			protected global::Android.Graphics.Rect MDestRect {
				get {
					if (mDestRect_jfieldId == IntPtr.Zero)
						mDestRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mDestRect", "Landroid/graphics/Rect;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mDestRect_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mDestRect_jfieldId == IntPtr.Zero)
						mDestRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mDestRect", "Landroid/graphics/Rect;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mDestRect_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mDiff_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mDiff']"
			[Register ("mDiff")]
			protected int MDiff {
				get {
					if (mDiff_jfieldId == IntPtr.Zero)
						mDiff_jfieldId = JNIEnv.GetFieldID (class_ref, "mDiff", "I");
					return JNIEnv.GetIntField (Handle, mDiff_jfieldId);
				}
				set {
					if (mDiff_jfieldId == IntPtr.Zero)
						mDiff_jfieldId = JNIEnv.GetFieldID (class_ref, "mDiff", "I");
					JNIEnv.SetField (Handle, mDiff_jfieldId, value);
				}
			}

			static IntPtr mNewTiles_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mNewTiles']"
			[Register ("mNewTiles")]
			protected global::System.Collections.IDictionary MNewTiles {
				get {
					if (mNewTiles_jfieldId == IntPtr.Zero)
						mNewTiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mNewTiles", "Ljava/util/HashMap;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mNewTiles_jfieldId);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mNewTiles_jfieldId == IntPtr.Zero)
						mNewTiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mNewTiles", "Ljava/util/HashMap;");
					IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mNewTiles_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mOldZoomLevel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mOldZoomLevel']"
			[Register ("mOldZoomLevel")]
			protected int MOldZoomLevel {
				get {
					if (mOldZoomLevel_jfieldId == IntPtr.Zero)
						mOldZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mOldZoomLevel", "I");
					return JNIEnv.GetIntField (Handle, mOldZoomLevel_jfieldId);
				}
				set {
					if (mOldZoomLevel_jfieldId == IntPtr.Zero)
						mOldZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mOldZoomLevel", "I");
					JNIEnv.SetField (Handle, mOldZoomLevel_jfieldId, value);
				}
			}

			static IntPtr mSrcRect_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mSrcRect']"
			[Register ("mSrcRect")]
			protected global::Android.Graphics.Rect MSrcRect {
				get {
					if (mSrcRect_jfieldId == IntPtr.Zero)
						mSrcRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mSrcRect", "Landroid/graphics/Rect;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, mSrcRect_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (mSrcRect_jfieldId == IntPtr.Zero)
						mSrcRect_jfieldId = JNIEnv.GetFieldID (class_ref, "mSrcRect", "Landroid/graphics/Rect;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, mSrcRect_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr mTileSize_2_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/field[@name='mTileSize_2']"
			[Register ("mTileSize_2")]
			protected int MTileSize2 {
				get {
					if (mTileSize_2_jfieldId == IntPtr.Zero)
						mTileSize_2_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileSize_2", "I");
					return JNIEnv.GetIntField (Handle, mTileSize_2_jfieldId);
				}
				set {
					if (mTileSize_2_jfieldId == IntPtr.Zero)
						mTileSize_2_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileSize_2", "I");
					JNIEnv.SetField (Handle, mTileSize_2_jfieldId, value);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderBase$ScaleTileLooper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScaleTileLooper); }
			}

			protected ScaleTileLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/constructor[@name='MapTileProviderBase.ScaleTileLooper' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", "")]
			public ScaleTileLooper (global::Osmdroid.TileProvider.MapTileProviderBase __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ScaleTileLooper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_finaliseLoop;
#pragma warning disable 0169
			static Delegate GetFinaliseLoopHandler ()
			{
				if (cb_finaliseLoop == null)
					cb_finaliseLoop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinaliseLoop);
				return cb_finaliseLoop;
			}

			static void n_FinaliseLoop (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.FinaliseLoop ();
			}
#pragma warning restore 0169

			static IntPtr id_finaliseLoop;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/method[@name='finaliseLoop' and count(parameter)=0]"
			[Register ("finaliseLoop", "()V", "GetFinaliseLoopHandler")]
			public override void FinaliseLoop ()
			{
				if (id_finaliseLoop == IntPtr.Zero)
					id_finaliseLoop = JNIEnv.GetMethodID (class_ref, "finaliseLoop", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_finaliseLoop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finaliseLoop", "()V"));
			}

			static Delegate cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
#pragma warning disable 0169
			static Delegate GetHandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_IIHandler ()
			{
				if (cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II == null)
					cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int, int>) n_HandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II);
				return cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
			}

			static void n_HandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, int p3, int p4)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTile p2 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.HandleTile (p0, p1, p2, p3, p4);
			}
#pragma warning restore 0169

			static IntPtr id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/method[@name='handleTile' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.tileprovider.MapTile'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register ("handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
			public override void HandleTile (global::Android.Graphics.Canvas p0, int p1, global::Osmdroid.TileProvider.MapTile p2, int p3, int p4)
			{
				if (id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II == IntPtr.Zero)
					id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II = JNIEnv.GetMethodID (class_ref, "handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

			static Delegate cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
#pragma warning disable 0169
			static Delegate GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler ()
			{
				if (cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == null)
					cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, int>) n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II);
				return cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			}

			static void n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTile p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleTile (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/method[@name='handleTile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
			public abstract void HandleTile (int p0, global::Osmdroid.TileProvider.MapTile p1, int p2, int p3);

			static Delegate cb_initialiseLoop_II;
#pragma warning disable 0169
			static Delegate GetInitialiseLoop_IIHandler ()
			{
				if (cb_initialiseLoop_II == null)
					cb_initialiseLoop_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_InitialiseLoop_II);
				return cb_initialiseLoop_II;
			}

			static void n_InitialiseLoop_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.InitialiseLoop (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_initialiseLoop_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/method[@name='initialiseLoop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("initialiseLoop", "(II)V", "GetInitialiseLoop_IIHandler")]
			public override void InitialiseLoop (int p0, int p1)
			{
				if (id_initialiseLoop_II == IntPtr.Zero)
					id_initialiseLoop_II = JNIEnv.GetMethodID (class_ref, "initialiseLoop", "(II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_initialiseLoop_II, new JValue (p0), new JValue (p1));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialiseLoop", "(II)V"), new JValue (p0), new JValue (p1));
			}

		}

		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase$ScaleTileLooper", DoNotGenerateAcw=true)]
		internal partial class ScaleTileLooperInvoker : ScaleTileLooper {

			public ScaleTileLooperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScaleTileLooperInvoker); }
			}

			static IntPtr id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ScaleTileLooper']/method[@name='handleTile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
			public override void HandleTile (int p0, global::Osmdroid.TileProvider.MapTile p1, int p2, int p3)
			{
				if (id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == IntPtr.Zero)
					id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNIEnv.GetMethodID (class_ref, "handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V");
				JNIEnv.CallVoidMethod  (Handle, id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomInTileLooper']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase$ZoomInTileLooper", DoNotGenerateAcw=true)]
		public partial class ZoomInTileLooper : global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderBase$ZoomInTileLooper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ZoomInTileLooper); }
			}

			protected ZoomInTileLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomInTileLooper']/constructor[@name='MapTileProviderBase.ZoomInTileLooper' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", "")]
			public ZoomInTileLooper (global::Osmdroid.TileProvider.MapTileProviderBase __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ZoomInTileLooper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
#pragma warning disable 0169
			static Delegate GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler ()
			{
				if (cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == null)
					cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, int>) n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II);
				return cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			}

			static void n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ZoomInTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ZoomInTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTile p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleTile (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomInTileLooper']/method[@name='handleTile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
			public override void HandleTile (int p0, global::Osmdroid.TileProvider.MapTile p1, int p2, int p3)
			{
				if (id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == IntPtr.Zero)
					id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNIEnv.GetMethodID (class_ref, "handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomOutTileLooper']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase$ZoomOutTileLooper", DoNotGenerateAcw=true)]
		public partial class ZoomOutTileLooper : global::Osmdroid.TileProvider.MapTileProviderBase.ScaleTileLooper {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderBase$ZoomOutTileLooper", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ZoomOutTileLooper); }
			}

			protected ZoomOutTileLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomOutTileLooper']/constructor[@name='MapTileProviderBase.ZoomOutTileLooper' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V", "")]
			public ZoomOutTileLooper (global::Osmdroid.TileProvider.MapTileProviderBase __self, int p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ZoomOutTileLooper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";I)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTileProviderBase_I, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
#pragma warning disable 0169
			static Delegate GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler ()
			{
				if (cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == null)
					cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, int>) n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II);
				return cb_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			}

			static void n_HandleTile_ILorg_osmdroid_tileprovider_MapTile_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, int p3)
			{
				global::Osmdroid.TileProvider.MapTileProviderBase.ZoomOutTileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase.ZoomOutTileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTile p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.HandleTile (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			static IntPtr id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase.ZoomOutTileLooper']/method[@name='handleTile' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register ("handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
			public override void HandleTile (int p0, global::Osmdroid.TileProvider.MapTile p1, int p2, int p3)
			{
				if (id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II == IntPtr.Zero)
					id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II = JNIEnv.GetMethodID (class_ref, "handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_handleTile_ILorg_osmdroid_tileprovider_MapTile_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleTile", "(ILorg/osmdroid/tileprovider/MapTile;II)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileProviderBase); }
		}

		protected MapTileProviderBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/constructor[@name='MapTileProviderBase' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='android.os.Handler']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Landroid/os/Handler;)V", "")]
		public MapTileProviderBase (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, global::Android.OS.Handler pDownloadFinishedListener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Landroid/os/Handler;)V", new JValue (pTileSource), new JValue (pDownloadFinishedListener)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Landroid/os/Handler;)V", new JValue (pTileSource), new JValue (pDownloadFinishedListener));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Landroid/os/Handler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Landroid_os_Handler_, new JValue (pTileSource), new JValue (pDownloadFinishedListener)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Landroid_os_Handler_, new JValue (pTileSource), new JValue (pDownloadFinishedListener));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/constructor[@name='MapTileProviderBase' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "")]
		public MapTileProviderBase (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pTileSource)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pTileSource));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pTileSource)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pTileSource));
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
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		public abstract int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler")] get;
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
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		public abstract int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")] get;
		}

		static Delegate cb_getTileSource;
#pragma warning disable 0169
		static Delegate GetGetTileSourceHandler ()
		{
			if (cb_getTileSource == null)
				cb_getTileSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileSource);
			return cb_getTileSource;
		}

		static IntPtr n_GetTileSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TileSource);
		}
#pragma warning restore 0169

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
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_pTileSource, JniHandleOwnership.DoNotTransfer);
			__this.TileSource = pTileSource;
		}
#pragma warning restore 0169

		static IntPtr id_getTileSource;
		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		public virtual global::Osmdroid.TileProvider.TileSource.ITileSource TileSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getTileSource' and count(parameter)=0]"
			[Register ("getTileSource", "()Lorg/osmdroid/tileprovider/tilesource/ITileSource;", "GetGetTileSourceHandler")]
			get {
				if (id_getTileSource == IntPtr.Zero)
					id_getTileSource = JNIEnv.GetMethodID (class_ref, "getTileSource", "()Lorg/osmdroid/tileprovider/tilesource/ITileSource;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (JNIEnv.CallObjectMethod  (Handle, id_getTileSource), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileSource", "()Lorg/osmdroid/tileprovider/tilesource/ITileSource;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
			[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
			set {
				if (id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
					id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V"), new JValue (value));
			}
		}

		static Delegate cb_clearTileCache;
#pragma warning disable 0169
		static Delegate GetClearTileCacheHandler ()
		{
			if (cb_clearTileCache == null)
				cb_clearTileCache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearTileCache);
			return cb_clearTileCache;
		}

		static void n_ClearTileCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearTileCache ();
		}
#pragma warning restore 0169

		static IntPtr id_clearTileCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='clearTileCache' and count(parameter)=0]"
		[Register ("clearTileCache", "()V", "GetClearTileCacheHandler")]
		public virtual void ClearTileCache ()
		{
			if (id_clearTileCache == IntPtr.Zero)
				id_clearTileCache = JNIEnv.GetMethodID (class_ref, "clearTileCache", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearTileCache);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearTileCache", "()V"));
		}

		static Delegate cb_createTileCache;
#pragma warning disable 0169
		static Delegate GetCreateTileCacheHandler ()
		{
			if (cb_createTileCache == null)
				cb_createTileCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateTileCache);
			return cb_createTileCache;
		}

		static IntPtr n_CreateTileCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateTileCache ());
		}
#pragma warning restore 0169

		static IntPtr id_createTileCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='createTileCache' and count(parameter)=0]"
		[Register ("createTileCache", "()Lorg/osmdroid/tileprovider/MapTileCache;", "GetCreateTileCacheHandler")]
		public virtual global::Osmdroid.TileProvider.MapTileCache CreateTileCache ()
		{
			if (id_createTileCache == IntPtr.Zero)
				id_createTileCache = JNIEnv.GetMethodID (class_ref, "createTileCache", "()Lorg/osmdroid/tileprovider/MapTileCache;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (JNIEnv.CallObjectMethod  (Handle, id_createTileCache), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTileCache", "()Lorg/osmdroid/tileprovider/MapTileCache;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public abstract void Detach ();

		static Delegate cb_ensureCapacity_I;
#pragma warning disable 0169
		static Delegate GetEnsureCapacity_IHandler ()
		{
			if (cb_ensureCapacity_I == null)
				cb_ensureCapacity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnsureCapacity_I);
			return cb_ensureCapacity_I;
		}

		static void n_EnsureCapacity_I (IntPtr jnienv, IntPtr native__this, int pCapacity)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsureCapacity (pCapacity);
		}
#pragma warning restore 0169

		static IntPtr id_ensureCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='ensureCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ensureCapacity", "(I)V", "GetEnsureCapacity_IHandler")]
		public virtual void EnsureCapacity (int pCapacity)
		{
			if (id_ensureCapacity_I == IntPtr.Zero)
				id_ensureCapacity_I = JNIEnv.GetMethodID (class_ref, "ensureCapacity", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ensureCapacity_I, new JValue (pCapacity));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ensureCapacity", "(I)V"), new JValue (pCapacity));
		}

		static Delegate cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTile)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile pTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_pTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMapTile (pTile));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMapTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;", "GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public abstract global::Android.Graphics.Drawables.Drawable GetMapTile (global::Osmdroid.TileProvider.MapTile pTile);

		static Delegate cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_MapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestCompleted (pState, pDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='mapTileRequestCompleted' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("mapTileRequestCompleted", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetMapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void MapTileRequestCompleted (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
		{
			if (id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestCompleted", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapTileRequestCompleted", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
		}

		static Delegate cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_MapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestExpiredTile (pState, pDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='mapTileRequestExpiredTile' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("mapTileRequestExpiredTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetMapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void MapTileRequestExpiredTile (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
		{
			if (id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestExpiredTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapTileRequestExpiredTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
		}

		static Delegate cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
		{
			if (cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
				cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_);
			return cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		}

		static void n_MapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestFailed (pState);
		}
#pragma warning restore 0169

		static IntPtr id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='mapTileRequestFailed' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
		[Register ("mapTileRequestFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V", "GetMapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
		public virtual void MapTileRequestFailed (global::Osmdroid.TileProvider.MapTileRequestState pState)
		{
			if (id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
				id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (pState));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mapTileRequestFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V"), new JValue (pState));
		}

		static Delegate cb_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPutExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_PutExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
			__this.PutExpiredTileIntoCache (pState, pDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='putExpiredTileIntoCache' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("putExpiredTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetPutExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
		protected virtual void PutExpiredTileIntoCache (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
		{
			if (id_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "putExpiredTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putExpiredTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putExpiredTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
		}

		static Delegate cb_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPutTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_PutTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
			__this.PutTileIntoCache (pState, pDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='putTileIntoCache' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("putTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetPutTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
		protected virtual void PutTileIntoCache (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
		{
			if (id_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "putTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putTileIntoCache_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putTileIntoCache", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
		}

		static Delegate cb_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetRescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_Handler ()
		{
			if (cb_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ == null)
				cb_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_RescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_);
			return cb_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
		}

		static void n_RescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pProjection, int pNewZoomLevel, int pOldZoomLevel, IntPtr native_pViewPort)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Projection pProjection = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (native_pProjection, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect pViewPort = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_pViewPort, JniHandleOwnership.DoNotTransfer);
			__this.RescaleCache (pProjection, pNewZoomLevel, pOldZoomLevel, pViewPort);
		}
#pragma warning restore 0169

		static IntPtr id_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='rescaleCache' and count(parameter)=4 and parameter[1][@type='org.osmdroid.views.Projection'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Rect']]"
		[Register ("rescaleCache", "(Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V", "GetRescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_Handler")]
		public virtual void RescaleCache (global::Osmdroid.Views.Projection pProjection, int pNewZoomLevel, int pOldZoomLevel, global::Android.Graphics.Rect pViewPort)
		{
			if (id_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ == IntPtr.Zero)
				id_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "rescaleCache", "(Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_rescaleCache_Lorg_osmdroid_views_Projection_IILandroid_graphics_Rect_, new JValue (pProjection), new JValue (pNewZoomLevel), new JValue (pOldZoomLevel), new JValue (pViewPort));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rescaleCache", "(Lorg/osmdroid/views/Projection;IILandroid/graphics/Rect;)V"), new JValue (pProjection), new JValue (pNewZoomLevel), new JValue (pOldZoomLevel), new JValue (pViewPort));
		}

		static Delegate cb_setTileRequestCompleteHandler_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetSetTileRequestCompleteHandler_Landroid_os_Handler_Handler ()
		{
			if (cb_setTileRequestCompleteHandler_Landroid_os_Handler_ == null)
				cb_setTileRequestCompleteHandler_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileRequestCompleteHandler_Landroid_os_Handler_);
			return cb_setTileRequestCompleteHandler_Landroid_os_Handler_;
		}

		static void n_SetTileRequestCompleteHandler_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler handler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.SetTileRequestCompleteHandler (handler);
		}
#pragma warning restore 0169

		static IntPtr id_setTileRequestCompleteHandler_Landroid_os_Handler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='setTileRequestCompleteHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
		[Register ("setTileRequestCompleteHandler", "(Landroid/os/Handler;)V", "GetSetTileRequestCompleteHandler_Landroid_os_Handler_Handler")]
		public virtual void SetTileRequestCompleteHandler (global::Android.OS.Handler handler)
		{
			if (id_setTileRequestCompleteHandler_Landroid_os_Handler_ == IntPtr.Zero)
				id_setTileRequestCompleteHandler_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "setTileRequestCompleteHandler", "(Landroid/os/Handler;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTileRequestCompleteHandler_Landroid_os_Handler_, new JValue (handler));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileRequestCompleteHandler", "(Landroid/os/Handler;)V"), new JValue (handler));
		}

		static Delegate cb_setUseDataConnection_Z;
#pragma warning disable 0169
		static Delegate GetSetUseDataConnection_ZHandler ()
		{
			if (cb_setUseDataConnection_Z == null)
				cb_setUseDataConnection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseDataConnection_Z);
			return cb_setUseDataConnection_Z;
		}

		static void n_SetUseDataConnection_Z (IntPtr jnienv, IntPtr native__this, bool pMode)
		{
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseDataConnection (pMode);
		}
#pragma warning restore 0169

		static IntPtr id_setUseDataConnection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='setUseDataConnection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseDataConnection", "(Z)V", "GetSetUseDataConnection_ZHandler")]
		public virtual void SetUseDataConnection (bool pMode)
		{
			if (id_setUseDataConnection_Z == IntPtr.Zero)
				id_setUseDataConnection_Z = JNIEnv.GetMethodID (class_ref, "setUseDataConnection", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUseDataConnection_Z, new JValue (pMode));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseDataConnection", "(Z)V"), new JValue (pMode));
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
			global::Osmdroid.TileProvider.MapTileProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDataConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_useDataConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='useDataConnection' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBase", DoNotGenerateAcw=true)]
	internal partial class MapTileProviderBaseInvoker : MapTileProviderBase {

		public MapTileProviderBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileProviderBaseInvoker); }
		}

		static IntPtr id_getMaximumZoomLevel;
		public override int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler")]
			get {
				if (id_getMaximumZoomLevel == IntPtr.Zero)
					id_getMaximumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaximumZoomLevel", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMaximumZoomLevel);
			}
		}

		static IntPtr id_getMinimumZoomLevel;
		public override int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")]
			get {
				if (id_getMinimumZoomLevel == IntPtr.Zero)
					id_getMinimumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinimumZoomLevel", "()I");
				return JNIEnv.CallIntMethod  (Handle, id_getMinimumZoomLevel);
			}
		}

		static IntPtr id_detach;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public override void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_detach);
		}

		static IntPtr id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBase']/method[@name='getMapTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;", "GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public override global::Android.Graphics.Drawables.Drawable GetMapTile (global::Osmdroid.TileProvider.MapTile pTile)
		{
			if (id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;");
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_, new JValue (pTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
