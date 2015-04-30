using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileCache", DoNotGenerateAcw=true)]
	public partial class MapTileCache : global::Java.Lang.Object {


		static IntPtr mCachedTiles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/field[@name='mCachedTiles']"
		[Register ("mCachedTiles")]
		protected global::Osmdroid.TileProvider.LRUMapTileCache MCachedTiles {
			get {
				if (mCachedTiles_jfieldId == IntPtr.Zero)
					mCachedTiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTiles", "Lorg/osmdroid/tileprovider/LRUMapTileCache;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCachedTiles_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTiles_jfieldId == IntPtr.Zero)
					mCachedTiles_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTiles", "Lorg/osmdroid/tileprovider/LRUMapTileCache;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCachedTiles_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mCachedTilesLockObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/field[@name='mCachedTilesLockObject']"
		[Register ("mCachedTilesLockObject")]
		protected global::Java.Lang.Object MCachedTilesLockObject {
			get {
				if (mCachedTilesLockObject_jfieldId == IntPtr.Zero)
					mCachedTilesLockObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTilesLockObject", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCachedTilesLockObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTilesLockObject_jfieldId == IntPtr.Zero)
					mCachedTilesLockObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTilesLockObject", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCachedTilesLockObject_jfieldId, native_value);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileCache); }
		}

		protected MapTileCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/constructor[@name='MapTileCache' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MapTileCache () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/constructor[@name='MapTileCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public MapTileCache (int aMaximumCacheSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (aMaximumCacheSize)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (aMaximumCacheSize));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (aMaximumCacheSize)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (aMaximumCacheSize));
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_containsTile_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetContainsTile_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_containsTile_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_containsTile_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ContainsTile_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_containsTile_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static bool n_ContainsTile_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile)
		{
			global::Osmdroid.TileProvider.MapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsTile (aTile);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_containsTile_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/method[@name='containsTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("containsTile", "(Lorg/osmdroid/tileprovider/MapTile;)Z", "GetContainsTile_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public virtual bool ContainsTile (global::Osmdroid.TileProvider.MapTile aTile)
		{
			if (id_containsTile_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_containsTile_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "containsTile", "(Lorg/osmdroid/tileprovider/MapTile;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_containsTile_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aTile));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "containsTile", "(Lorg/osmdroid/tileprovider/MapTile;)Z"), new JValue (aTile));
			return __ret;
		}

		static Delegate cb_ensureCapacity_I;
#pragma warning disable 0169
		static Delegate GetEnsureCapacity_IHandler ()
		{
			if (cb_ensureCapacity_I == null)
				cb_ensureCapacity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_EnsureCapacity_I);
			return cb_ensureCapacity_I;
		}

		static void n_EnsureCapacity_I (IntPtr jnienv, IntPtr native__this, int aCapacity)
		{
			global::Osmdroid.TileProvider.MapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsureCapacity (aCapacity);
		}
#pragma warning restore 0169

		static IntPtr id_ensureCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/method[@name='ensureCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ensureCapacity", "(I)V", "GetEnsureCapacity_IHandler")]
		public virtual void EnsureCapacity (int aCapacity)
		{
			if (id_ensureCapacity_I == IntPtr.Zero)
				id_ensureCapacity_I = JNIEnv.GetMethodID (class_ref, "ensureCapacity", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_ensureCapacity_I, new JValue (aCapacity));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ensureCapacity", "(I)V"), new JValue (aCapacity));
		}

		static Delegate cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile)
		{
			global::Osmdroid.TileProvider.MapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMapTile (aTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/method[@name='getMapTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;", "GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public virtual global::Android.Graphics.Drawables.Drawable GetMapTile (global::Osmdroid.TileProvider.MapTile aTile)
		{
			if (id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;");

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;"), new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetPutTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_ == null)
				cb_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_);
			return cb_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_;
		}

		static void n_PutTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile, IntPtr native_aDrawable)
		{
			global::Osmdroid.TileProvider.MapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable aDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_aDrawable, JniHandleOwnership.DoNotTransfer);
			__this.PutTile (aTile, aDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileCache']/method[@name='putTile' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTile'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("putTile", "(Lorg/osmdroid/tileprovider/MapTile;Landroid/graphics/drawable/Drawable;)V", "GetPutTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void PutTile (global::Osmdroid.TileProvider.MapTile aTile, global::Android.Graphics.Drawables.Drawable aDrawable)
		{
			if (id_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "putTile", "(Lorg/osmdroid/tileprovider/MapTile;Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_putTile_Lorg_osmdroid_tileprovider_MapTile_Landroid_graphics_drawable_Drawable_, new JValue (aTile), new JValue (aDrawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putTile", "(Lorg/osmdroid/tileprovider/MapTile;Landroid/graphics/drawable/Drawable;)V"), new JValue (aTile), new JValue (aDrawable));
		}

	}
}
