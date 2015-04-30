using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase", DoNotGenerateAcw=true)]
	public abstract partial class BitmapTileSourceBase : global::Java.Lang.Object, global::Osmdroid.TileProvider.TileSource.ITileSource {


		static IntPtr mImageFilenameEnding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/field[@name='mImageFilenameEnding']"
		[Register ("mImageFilenameEnding")]
		protected string MImageFilenameEnding {
			get {
				if (mImageFilenameEnding_jfieldId == IntPtr.Zero)
					mImageFilenameEnding_jfieldId = JNIEnv.GetFieldID (class_ref, "mImageFilenameEnding", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mImageFilenameEnding_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mImageFilenameEnding_jfieldId == IntPtr.Zero)
					mImageFilenameEnding_jfieldId = JNIEnv.GetFieldID (class_ref, "mImageFilenameEnding", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mImageFilenameEnding_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/field[@name='mName']"
		[Register ("mName")]
		protected string MName {
			get {
				if (mName_jfieldId == IntPtr.Zero)
					mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mName_jfieldId == IntPtr.Zero)
					mName_jfieldId = JNIEnv.GetFieldID (class_ref, "mName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mName_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr random_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/field[@name='random']"
		[Register ("random")]
		protected global::Java.Util.Random Random {
			get {
				if (random_jfieldId == IntPtr.Zero)
					random_jfieldId = JNIEnv.GetFieldID (class_ref, "random", "Ljava/util/Random;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, random_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Random> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (random_jfieldId == IntPtr.Zero)
					random_jfieldId = JNIEnv.GetFieldID (class_ref, "random", "Ljava/util/Random;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, random_jfieldId, native_value);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase.LowMemoryException']"
		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase$LowMemoryException", DoNotGenerateAcw=true)]
		public sealed partial class LowMemoryException : global::Java.Lang.Exception {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase$LowMemoryException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LowMemoryException); }
			}

			internal LowMemoryException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase.LowMemoryException']/constructor[@name='BitmapTileSourceBase.LowMemoryException' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.BitmapTileSourceBase'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/BitmapTileSourceBase;Ljava/lang/String;)V", "")]
			public LowMemoryException (global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __self, string p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewString (p1);;
				if (GetType () != typeof (LowMemoryException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;)V", new JValue (__self), new JValue (native_p1));
					JNIEnv.DeleteLocalRef (native_p1);
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/BitmapTileSourceBase;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_String_, new JValue (__self), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_Throwable_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase.LowMemoryException']/constructor[@name='BitmapTileSourceBase.LowMemoryException' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.BitmapTileSourceBase'] and parameter[2][@type='java.lang.Throwable']]"
			[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/BitmapTileSourceBase;Ljava/lang/Throwable;)V", "")]
			public LowMemoryException (global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __self, global::Java.Lang.Throwable p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LowMemoryException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/Throwable;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/Throwable;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/BitmapTileSourceBase;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_Throwable_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_BitmapTileSourceBase_Ljava_lang_Throwable_, new JValue (__self), new JValue (p1));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapTileSourceBase); }
		}

		protected BitmapTileSourceBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/constructor[@name='BitmapTileSourceBase' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.osmdroid.ResourceProxy.string'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", "")]
		public BitmapTileSourceBase (string aName, global::Osmdroid.ResourceProxyString aResourceId, int aZoomMinLevel, int aZoomMaxLevel, int aTileSizePixels, string aImageFilenameEnding) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_aName = JNIEnv.NewString (aName);;
			IntPtr native_aImageFilenameEnding = JNIEnv.NewString (aImageFilenameEnding);;
			if (GetType () != typeof (BitmapTileSourceBase)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding));
				JNIEnv.DeleteLocalRef (native_aName);
				JNIEnv.DeleteLocalRef (native_aImageFilenameEnding);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_, new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_, new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding));
			JNIEnv.DeleteLocalRef (native_aName);
			JNIEnv.DeleteLocalRef (native_aImageFilenameEnding);
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
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumZoomLevel;
		public virtual int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
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
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumZoomLevel;
		public virtual int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
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

		static Delegate cb_getTileSizePixels;
#pragma warning disable 0169
		static Delegate GetGetTileSizePixelsHandler ()
		{
			if (cb_getTileSizePixels == null)
				cb_getTileSizePixels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTileSizePixels);
			return cb_getTileSizePixels;
		}

		static int n_GetTileSizePixels (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileSizePixels;
		}
#pragma warning restore 0169

		static IntPtr id_getTileSizePixels;
		public virtual int TileSizePixels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getTileSizePixels' and count(parameter)=0]"
			[Register ("getTileSizePixels", "()I", "GetGetTileSizePixelsHandler")]
			get {
				if (id_getTileSizePixels == IntPtr.Zero)
					id_getTileSizePixels = JNIEnv.GetMethodID (class_ref, "getTileSizePixels", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getTileSizePixels);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileSizePixels", "()I"));
			}
		}

		static Delegate cb_getDrawable_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetGetDrawable_Ljava_io_InputStream_Handler ()
		{
			if (cb_getDrawable_Ljava_io_InputStream_ == null)
				cb_getDrawable_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDrawable_Ljava_io_InputStream_);
			return cb_getDrawable_Ljava_io_InputStream_;
		}

		static IntPtr n_GetDrawable_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aFileInputStream)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aFileInputStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_aFileInputStream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (aFileInputStream));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("getDrawable", "(Ljava/io/InputStream;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_io_InputStream_Handler")]
		public virtual global::Android.Graphics.Drawables.Drawable GetDrawable (global::System.IO.Stream aFileInputStream)
		{
			if (id_getDrawable_Ljava_io_InputStream_ == IntPtr.Zero)
				id_getDrawable_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Ljava/io/InputStream;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_aFileInputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (aFileInputStream);

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_Ljava_io_InputStream_, new JValue (native_aFileInputStream)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(Ljava/io/InputStream;)Landroid/graphics/drawable/Drawable;"), new JValue (native_aFileInputStream)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aFileInputStream);
			return __ret;
		}

		static Delegate cb_getDrawable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDrawable_Ljava_lang_String_Handler ()
		{
			if (cb_getDrawable_Ljava_lang_String_ == null)
				cb_getDrawable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDrawable_Ljava_lang_String_);
			return cb_getDrawable_Ljava_lang_String_;
		}

		static IntPtr n_GetDrawable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aFilePath)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aFilePath = JNIEnv.GetString (native_aFilePath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (aFilePath));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_lang_String_Handler")]
		public virtual global::Android.Graphics.Drawables.Drawable GetDrawable (string aFilePath)
		{
			if (id_getDrawable_Ljava_lang_String_ == IntPtr.Zero)
				id_getDrawable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_aFilePath = JNIEnv.NewString (aFilePath);

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_Ljava_lang_String_, new JValue (native_aFilePath)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"), new JValue (native_aFilePath)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aFilePath);
			return __ret;
		}

		static Delegate cb_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tile)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile tile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_tile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTileRelativeFilenameString (tile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='getTileRelativeFilenameString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getTileRelativeFilenameString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;", "GetGetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public virtual string GetTileRelativeFilenameString (global::Osmdroid.TileProvider.MapTile tile)
		{
			if (id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getTileRelativeFilenameString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_, new JValue (tile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileRelativeFilenameString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;"), new JValue (tile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_imageFilenameEnding;
#pragma warning disable 0169
		static Delegate GetImageFilenameEndingHandler ()
		{
			if (cb_imageFilenameEnding == null)
				cb_imageFilenameEnding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ImageFilenameEnding);
			return cb_imageFilenameEnding;
		}

		static IntPtr n_ImageFilenameEnding (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageFilenameEnding ());
		}
#pragma warning restore 0169

		static IntPtr id_imageFilenameEnding;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='imageFilenameEnding' and count(parameter)=0]"
		[Register ("imageFilenameEnding", "()Ljava/lang/String;", "GetImageFilenameEndingHandler")]
		public virtual string ImageFilenameEnding ()
		{
			if (id_imageFilenameEnding == IntPtr.Zero)
				id_imageFilenameEnding = JNIEnv.GetMethodID (class_ref, "imageFilenameEnding", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_imageFilenameEnding), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "imageFilenameEnding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_localizedName_Lorg_osmdroid_ResourceProxy_;
#pragma warning disable 0169
		static Delegate GetLocalizedName_Lorg_osmdroid_ResourceProxy_Handler ()
		{
			if (cb_localizedName_Lorg_osmdroid_ResourceProxy_ == null)
				cb_localizedName_Lorg_osmdroid_ResourceProxy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LocalizedName_Lorg_osmdroid_ResourceProxy_);
			return cb_localizedName_Lorg_osmdroid_ResourceProxy_;
		}

		static IntPtr n_LocalizedName_Lorg_osmdroid_ResourceProxy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proxy)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.IResourceProxy proxy = (global::Osmdroid.IResourceProxy)global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LocalizedName (proxy));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_localizedName_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='localizedName' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register ("localizedName", "(Lorg/osmdroid/ResourceProxy;)Ljava/lang/String;", "GetLocalizedName_Lorg_osmdroid_ResourceProxy_Handler")]
		public virtual string LocalizedName (global::Osmdroid.IResourceProxy proxy)
		{
			if (id_localizedName_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_localizedName_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "localizedName", "(Lorg/osmdroid/ResourceProxy;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_localizedName_Lorg_osmdroid_ResourceProxy_, new JValue (proxy)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "localizedName", "(Lorg/osmdroid/ResourceProxy;)Ljava/lang/String;"), new JValue (proxy)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_name;
#pragma warning disable 0169
		static Delegate GetNameHandler ()
		{
			if (cb_name == null)
				cb_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Name);
			return cb_name;
		}

		static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		static IntPtr id_name;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler")]
		public virtual string Name ()
		{
			if (id_name == IntPtr.Zero)
				id_name = JNIEnv.GetMethodID (class_ref, "name", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_name), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "name", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_ordinal;
#pragma warning disable 0169
		static Delegate GetOrdinalHandler ()
		{
			if (cb_ordinal == null)
				cb_ordinal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Ordinal);
			return cb_ordinal;
		}

		static int n_Ordinal (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ordinal ();
		}
#pragma warning restore 0169

		static IntPtr id_ordinal;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='ordinal' and count(parameter)=0]"
		[Register ("ordinal", "()I", "GetOrdinalHandler")]
		public virtual int Ordinal ()
		{
			if (id_ordinal == IntPtr.Zero)
				id_ordinal = JNIEnv.GetMethodID (class_ref, "ordinal", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_ordinal);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ordinal", "()I"));
		}

		static Delegate cb_pathBase;
#pragma warning disable 0169
		static Delegate GetPathBaseHandler ()
		{
			if (cb_pathBase == null)
				cb_pathBase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PathBase);
			return cb_pathBase;
		}

		static IntPtr n_PathBase (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.BitmapTileSourceBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PathBase ());
		}
#pragma warning restore 0169

		static IntPtr id_pathBase;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='BitmapTileSourceBase']/method[@name='pathBase' and count(parameter)=0]"
		[Register ("pathBase", "()Ljava/lang/String;", "GetPathBaseHandler")]
		public virtual string PathBase ()
		{
			if (id_pathBase == IntPtr.Zero)
				id_pathBase = JNIEnv.GetMethodID (class_ref, "pathBase", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_pathBase), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pathBase", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase", DoNotGenerateAcw=true)]
	internal partial class BitmapTileSourceBaseInvoker : BitmapTileSourceBase {

		public BitmapTileSourceBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapTileSourceBaseInvoker); }
		}

	}

}
