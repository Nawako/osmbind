using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase", DoNotGenerateAcw=true)]
	public abstract partial class MapTileModuleProviderBase : global::Java.Lang.Object {


		static IntPtr mPending_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/field[@name='mPending']"
		[Register ("mPending")]
		protected global::Java.Util.LinkedHashMap MPending {
			get {
				if (mPending_jfieldId == IntPtr.Zero)
					mPending_jfieldId = JNIEnv.GetFieldID (class_ref, "mPending", "Ljava/util/LinkedHashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPending_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPending_jfieldId == IntPtr.Zero)
					mPending_jfieldId = JNIEnv.GetFieldID (class_ref, "mPending", "Ljava/util/LinkedHashMap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPending_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mQueueLockObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/field[@name='mQueueLockObject']"
		[Register ("mQueueLockObject")]
		protected global::Java.Lang.Object MQueueLockObject {
			get {
				if (mQueueLockObject_jfieldId == IntPtr.Zero)
					mQueueLockObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mQueueLockObject", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mQueueLockObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mQueueLockObject_jfieldId == IntPtr.Zero)
					mQueueLockObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mQueueLockObject", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mQueueLockObject_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mWorking_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/field[@name='mWorking']"
		[Register ("mWorking")]
		protected global::System.Collections.IDictionary MWorking {
			get {
				if (mWorking_jfieldId == IntPtr.Zero)
					mWorking_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorking", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mWorking_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWorking_jfieldId == IntPtr.Zero)
					mWorking_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorking", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mWorking_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.CantContinueException']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$CantContinueException", DoNotGenerateAcw=true)]
		public partial class CantContinueException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$CantContinueException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CantContinueException); }
			}

			protected CantContinueException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.CantContinueException']/constructor[@name='MapTileModuleProviderBase.CantContinueException' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Ljava/lang/String;)V", "")]
			public CantContinueException (global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (CantContinueException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_Throwable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.CantContinueException']/constructor[@name='MapTileModuleProviderBase.CantContinueException' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase'] and parameter[2][@type='java.lang.Throwable']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Ljava/lang/Throwable;)V", "")]
			public CantContinueException (global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __self, global::Java.Lang.Throwable p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CantContinueException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/Throwable;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/Throwable;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_Throwable_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Ljava_lang_Throwable_, new JValue (__self), new JValue (p1));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$TileLoader", DoNotGenerateAcw=true)]
		public abstract partial class TileLoader : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$TileLoader", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TileLoader); }
			}

			protected TileLoader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/constructor[@name='MapTileModuleProviderBase.TileLoader' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V", "")]
			protected TileLoader (global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

				if (id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_, new JValue (__self));
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
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadTile (pState));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='loadTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
			[Register ("loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;", "GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
			public abstract global::Android.Graphics.Drawables.Drawable LoadTile (global::Osmdroid.TileProvider.MapTileRequestState pState);

			static Delegate cb_nextTile;
#pragma warning disable 0169
			static Delegate GetNextTileHandler ()
			{
				if (cb_nextTile == null)
					cb_nextTile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextTile);
				return cb_nextTile;
			}

			static IntPtr n_NextTile (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NextTile ());
			}
#pragma warning restore 0169

			static IntPtr id_nextTile;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='nextTile' and count(parameter)=0]"
			[Register ("nextTile", "()Lorg/osmdroid/tileprovider/MapTileRequestState;", "GetNextTileHandler")]
			protected virtual global::Osmdroid.TileProvider.MapTileRequestState NextTile ()
			{
				if (id_nextTile == IntPtr.Zero)
					id_nextTile = JNIEnv.GetMethodID (class_ref, "nextTile", "()Lorg/osmdroid/tileprovider/MapTileRequestState;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (JNIEnv.CallObjectMethod  (Handle, id_nextTile), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextTile", "()Lorg/osmdroid/tileprovider/MapTileRequestState;")), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_onTileLoaderInit;
#pragma warning disable 0169
			static Delegate GetOnTileLoaderInitHandler ()
			{
				if (cb_onTileLoaderInit == null)
					cb_onTileLoaderInit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTileLoaderInit);
				return cb_onTileLoaderInit;
			}

			static void n_OnTileLoaderInit (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTileLoaderInit ();
			}
#pragma warning restore 0169

			static IntPtr id_onTileLoaderInit;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='onTileLoaderInit' and count(parameter)=0]"
			[Register ("onTileLoaderInit", "()V", "GetOnTileLoaderInitHandler")]
			protected virtual void OnTileLoaderInit ()
			{
				if (id_onTileLoaderInit == IntPtr.Zero)
					id_onTileLoaderInit = JNIEnv.GetMethodID (class_ref, "onTileLoaderInit", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTileLoaderInit);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTileLoaderInit", "()V"));
			}

			static Delegate cb_onTileLoaderShutdown;
#pragma warning disable 0169
			static Delegate GetOnTileLoaderShutdownHandler ()
			{
				if (cb_onTileLoaderShutdown == null)
					cb_onTileLoaderShutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTileLoaderShutdown);
				return cb_onTileLoaderShutdown;
			}

			static void n_OnTileLoaderShutdown (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTileLoaderShutdown ();
			}
#pragma warning restore 0169

			static IntPtr id_onTileLoaderShutdown;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='onTileLoaderShutdown' and count(parameter)=0]"
			[Register ("onTileLoaderShutdown", "()V", "GetOnTileLoaderShutdownHandler")]
			protected virtual void OnTileLoaderShutdown ()
			{
				if (id_onTileLoaderShutdown == IntPtr.Zero)
					id_onTileLoaderShutdown = JNIEnv.GetMethodID (class_ref, "onTileLoaderShutdown", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onTileLoaderShutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTileLoaderShutdown", "()V"));
			}

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "")]
			public void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_run);
			}

			static Delegate cb_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetTileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
					cb_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
				return cb_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
			}

			static void n_TileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
				__this.TileLoaded (pState, pDrawable);
			}
#pragma warning restore 0169

			static IntPtr id_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='tileLoaded' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
			[Register ("tileLoaded", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetTileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
			protected virtual void TileLoaded (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
			{
				if (id_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "tileLoaded", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tileLoaded_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tileLoaded", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
			}

			static Delegate cb_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
			static Delegate GetTileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
			{
				if (cb_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
					cb_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
				return cb_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
			}

			static void n_TileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState, IntPtr native_pDrawable)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Drawables.Drawable pDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_pDrawable, JniHandleOwnership.DoNotTransfer);
				__this.TileLoadedExpired (pState, pDrawable);
			}
#pragma warning restore 0169

			static IntPtr id_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='tileLoadedExpired' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
			[Register ("tileLoadedExpired", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetTileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler")]
			protected virtual void TileLoadedExpired (global::Osmdroid.TileProvider.MapTileRequestState pState, global::Android.Graphics.Drawables.Drawable pDrawable)
			{
				if (id_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "tileLoadedExpired", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tileLoadedExpired_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (pState), new JValue (pDrawable));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tileLoadedExpired", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V"), new JValue (pState), new JValue (pDrawable));
			}

			static Delegate cb_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
			static Delegate GetTileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
			{
				if (cb_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
					cb_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_);
				return cb_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			}

			static void n_TileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState)
			{
				global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase.TileLoader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
				__this.TileLoadedFailed (pState);
			}
#pragma warning restore 0169

			static IntPtr id_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='tileLoadedFailed' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
			[Register ("tileLoadedFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V", "GetTileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
			protected virtual void TileLoadedFailed (global::Osmdroid.TileProvider.MapTileRequestState pState)
			{
				if (id_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
					id_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "tileLoadedFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_tileLoadedFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (pState));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tileLoadedFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V"), new JValue (pState));
			}

		}

		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$TileLoader", DoNotGenerateAcw=true)]
		internal partial class TileLoaderInvoker : TileLoader {

			public TileLoaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (TileLoaderInvoker); }
			}

			static IntPtr id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase.TileLoader']/method[@name='loadTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
			[Register ("loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;", "GetLoadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
			public override global::Android.Graphics.Drawables.Drawable LoadTile (global::Osmdroid.TileProvider.MapTileRequestState pState)
			{
				if (id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
					id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "loadTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Landroid/graphics/drawable/Drawable;");
				global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_loadTile_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (pState)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileModuleProviderBase); }
		}

		protected MapTileModuleProviderBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/constructor[@name='MapTileModuleProviderBase' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public MapTileModuleProviderBase (int pThreadPoolSize, int pPendingQueueSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileModuleProviderBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(II)V", new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
				return;
			}

			if (id_ctor_II == IntPtr.Zero)
				id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, new JValue (pThreadPoolSize), new JValue (pPendingQueueSize)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_II, new JValue (pThreadPoolSize), new JValue (pPendingQueueSize));
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		public abstract int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		public abstract int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")] get;
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		protected abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThreadGroupName);
		}
#pragma warning restore 0169

		protected abstract string ThreadGroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getThreadGroupName' and count(parameter)=0]"
			[Register ("getThreadGroupName", "()Ljava/lang/String;", "GetGetThreadGroupNameHandler")] get;
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UsesDataConnection;
		}
#pragma warning restore 0169

		public abstract bool UsesDataConnection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getUsesDataConnection' and count(parameter)=0]"
			[Register ("getUsesDataConnection", "()Z", "GetGetUsesDataConnectionHandler")] get;
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		static IntPtr id_detach;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public virtual void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_detach);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detach", "()V"));
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
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTileLoader ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='getTileLoader' and count(parameter)=0]"
		[Register ("getTileLoader", "()Ljava/lang/Runnable;", "GetGetTileLoaderHandler")]
		protected abstract global::Java.Lang.IRunnable GetTileLoader ();

		static Delegate cb_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
		static Delegate GetLoadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
		{
			if (cb_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
				cb_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_);
			return cb_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		}

		static void n_LoadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pState)
		{
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState pState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_pState, JniHandleOwnership.DoNotTransfer);
			__this.LoadMapTileAsync (pState);
		}
#pragma warning restore 0169

		static IntPtr id_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='loadMapTileAsync' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
		[Register ("loadMapTileAsync", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V", "GetLoadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
		public virtual void LoadMapTileAsync (global::Osmdroid.TileProvider.MapTileRequestState pState)
		{
			if (id_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
				id_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "loadMapTileAsync", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_loadMapTileAsync_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (pState));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadMapTileAsync", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V"), new JValue (pState));
		}

		static Delegate cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
#pragma warning disable 0169
		static Delegate GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler ()
		{
			if (cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == null)
				cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_);
			return cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		}

		static void n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tileSource)
		{
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource tileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_tileSource, JniHandleOwnership.DoNotTransfer);
			__this.SetTileSource (tileSource);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='MapTileModuleProviderBase']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public abstract void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource tileSource);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/MapTileModuleProviderBase", DoNotGenerateAcw=true)]
	internal partial class MapTileModuleProviderBaseInvoker : MapTileModuleProviderBase {

		public MapTileModuleProviderBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileModuleProviderBaseInvoker); }
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
