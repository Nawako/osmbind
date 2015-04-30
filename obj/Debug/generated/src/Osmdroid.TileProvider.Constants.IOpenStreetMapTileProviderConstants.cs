using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Constants {

	[Register ("org/osmdroid/tileprovider/constants/OpenStreetMapTileProviderConstants")]
	public abstract class OpenStreetMapTileProviderConstants {

		internal OpenStreetMapTileProviderConstants ()
		{
		}

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

		static IntPtr class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/constants/OpenStreetMapTileProviderConstants");
	}

	[System.Obsolete ("Use the 'OpenStreetMapTileProviderConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class OpenStreetMapTileProviderConstantsConsts : OpenStreetMapTileProviderConstants {

		private OpenStreetMapTileProviderConstantsConsts ()
		{
		}
	}

}
