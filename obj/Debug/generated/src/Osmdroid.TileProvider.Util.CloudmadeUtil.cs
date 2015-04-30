using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='CloudmadeUtil']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/util/CloudmadeUtil", DoNotGenerateAcw=true)]
	public partial class CloudmadeUtil : global::Java.Lang.Object {


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
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/util/CloudmadeUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CloudmadeUtil); }
		}

		protected CloudmadeUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='CloudmadeUtil']/constructor[@name='CloudmadeUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public CloudmadeUtil () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (CloudmadeUtil)) {
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

		static IntPtr id_getCloudmadeKey;
		public static string CloudmadeKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='CloudmadeUtil']/method[@name='getCloudmadeKey' and count(parameter)=0]"
			[Register ("getCloudmadeKey", "()Ljava/lang/String;", "GetGetCloudmadeKeyHandler")]
			get {
				if (id_getCloudmadeKey == IntPtr.Zero)
					id_getCloudmadeKey = JNIEnv.GetStaticMethodID (class_ref, "getCloudmadeKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCloudmadeKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_getCloudmadeToken;
		public static string CloudmadeToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='CloudmadeUtil']/method[@name='getCloudmadeToken' and count(parameter)=0]"
			[Register ("getCloudmadeToken", "()Ljava/lang/String;", "GetGetCloudmadeTokenHandler")]
			get {
				if (id_getCloudmadeToken == IntPtr.Zero)
					id_getCloudmadeToken = JNIEnv.GetStaticMethodID (class_ref, "getCloudmadeToken", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCloudmadeToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_retrieveCloudmadeKey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='CloudmadeUtil']/method[@name='retrieveCloudmadeKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("retrieveCloudmadeKey", "(Landroid/content/Context;)V", "")]
		public static void RetrieveCloudmadeKey (global::Android.Content.Context aContext)
		{
			if (id_retrieveCloudmadeKey_Landroid_content_Context_ == IntPtr.Zero)
				id_retrieveCloudmadeKey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveCloudmadeKey", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_retrieveCloudmadeKey_Landroid_content_Context_, new JValue (aContext));
		}

	}
}
