using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='LRUMapTileCache']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/LRUMapTileCache", DoNotGenerateAcw=true)]
	public partial class LRUMapTileCache : global::Java.Util.LinkedHashMap {


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

		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='LRUMapTileCache.TileRemovedListener']"
		[Register ("org/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener", "", "Osmdroid.TileProvider.LRUMapTileCache/ITileRemovedListenerInvoker")]
		public partial interface ITileRemovedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='LRUMapTileCache.TileRemovedListener']/method[@name='onTileRemoved' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
			[Register ("onTileRemoved", "(Lorg/osmdroid/tileprovider/MapTile;)V", "GetOnTileRemoved_Lorg_osmdroid_tileprovider_MapTile_Handler:Osmdroid.TileProvider.LRUMapTileCache/ITileRemovedListenerInvoker, OsmdroidAndroidBinding")]
			void OnTileRemoved (global::Osmdroid.TileProvider.MapTile mapTile);

		}

		[global::Android.Runtime.Register ("org/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener", DoNotGenerateAcw=true)]
		internal class ITileRemovedListenerInvoker : global::Java.Lang.Object, ITileRemovedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener");
			IntPtr class_ref;

			public static ITileRemovedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITileRemovedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.LRUMapTileCache.TileRemovedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITileRemovedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (ITileRemovedListenerInvoker); }
			}

			static Delegate cb_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
			static Delegate GetOnTileRemoved_Lorg_osmdroid_tileprovider_MapTile_Handler ()
			{
				if (cb_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_ == null)
					cb_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTileRemoved_Lorg_osmdroid_tileprovider_MapTile_);
				return cb_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_;
			}

			static void n_OnTileRemoved_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapTile)
			{
				global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.TileProvider.MapTile mapTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_mapTile, JniHandleOwnership.DoNotTransfer);
				__this.OnTileRemoved (mapTile);
			}
#pragma warning restore 0169

			IntPtr id_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_;
			public void OnTileRemoved (global::Osmdroid.TileProvider.MapTile mapTile)
			{
				if (id_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
					id_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "onTileRemoved", "(Lorg/osmdroid/tileprovider/MapTile;)V");
				JNIEnv.CallVoidMethod (Handle, id_onTileRemoved_Lorg_osmdroid_tileprovider_MapTile_, new JValue (mapTile));
			}

		}

		public partial class TileRemovedEventArgs : global::System.EventArgs {

			public TileRemovedEventArgs (global::Osmdroid.TileProvider.MapTile mapTile)
			{
				this.mapTile = mapTile;
			}

			global::Osmdroid.TileProvider.MapTile mapTile;
			public global::Osmdroid.TileProvider.MapTile MapTile {
				get { return mapTile; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/tileprovider/LRUMapTileCache_TileRemovedListenerImplementor")]
		internal sealed class ITileRemovedListenerImplementor : global::Java.Lang.Object, ITileRemovedListener {

			object sender;

			public ITileRemovedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/tileprovider/LRUMapTileCache_TileRemovedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TileRemovedEventArgs> Handler;
#pragma warning restore 0649

			public void OnTileRemoved (global::Osmdroid.TileProvider.MapTile mapTile)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TileRemovedEventArgs (mapTile));
			}

			internal static bool __IsEmpty (ITileRemovedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/LRUMapTileCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LRUMapTileCache); }
		}

		protected LRUMapTileCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='LRUMapTileCache']/constructor[@name='LRUMapTileCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public LRUMapTileCache (int aCapacity) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LRUMapTileCache)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (aCapacity)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (aCapacity));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (aCapacity)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (aCapacity));
		}

		static Delegate cb_getTileRemovedListener;
#pragma warning disable 0169
		static Delegate GetGetTileRemovedListenerHandler ()
		{
			if (cb_getTileRemovedListener == null)
				cb_getTileRemovedListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileRemovedListener);
			return cb_getTileRemovedListener;
		}

		static IntPtr n_GetTileRemovedListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.LRUMapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TileRemovedListener);
		}
#pragma warning restore 0169

		static Delegate cb_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_;
#pragma warning disable 0169
		static Delegate GetSetTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_Handler ()
		{
			if (cb_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_ == null)
				cb_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_);
			return cb_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_;
		}

		static void n_SetTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tileRemovedListener)
		{
			global::Osmdroid.TileProvider.LRUMapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener tileRemovedListener = (global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener> (native_tileRemovedListener, JniHandleOwnership.DoNotTransfer);
			__this.TileRemovedListener = tileRemovedListener;
		}
#pragma warning restore 0169

		static IntPtr id_getTileRemovedListener;
		static IntPtr id_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_;
		public virtual global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener TileRemovedListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='LRUMapTileCache']/method[@name='getTileRemovedListener' and count(parameter)=0]"
			[Register ("getTileRemovedListener", "()Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;", "GetGetTileRemovedListenerHandler")]
			get {
				if (id_getTileRemovedListener == IntPtr.Zero)
					id_getTileRemovedListener = JNIEnv.GetMethodID (class_ref, "getTileRemovedListener", "()Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener> (JNIEnv.CallObjectMethod  (Handle, id_getTileRemovedListener), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileRemovedListener", "()Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='LRUMapTileCache']/method[@name='setTileRemovedListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.LRUMapTileCache.TileRemovedListener']]"
			[Register ("setTileRemovedListener", "(Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;)V", "GetSetTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_Handler")]
			set {
				if (id_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_ == IntPtr.Zero)
					id_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_ = JNIEnv.GetMethodID (class_ref, "setTileRemovedListener", "(Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTileRemovedListener_Lorg_osmdroid_tileprovider_LRUMapTileCache_TileRemovedListener_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileRemovedListener", "(Lorg/osmdroid/tileprovider/LRUMapTileCache$TileRemovedListener;)V"), new JValue (value));
			}
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
			global::Osmdroid.TileProvider.LRUMapTileCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.LRUMapTileCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnsureCapacity (aCapacity);
		}
#pragma warning restore 0169

		static IntPtr id_ensureCapacity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='LRUMapTileCache']/method[@name='ensureCapacity' and count(parameter)=1 and parameter[1][@type='int']]"
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

#region "Event implementation for Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener"
		public event EventHandler<global::Osmdroid.TileProvider.LRUMapTileCache.TileRemovedEventArgs> TileRemoved {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener, global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListenerImplementor>(
						ref weak_implementor___SetTileRemovedListener,
						__CreateITileRemovedListenerImplementor,
						__v => TileRemovedListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListener, global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListenerImplementor>(
						ref weak_implementor___SetTileRemovedListener,
						global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListenerImplementor.__IsEmpty,
						__v => TileRemovedListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetTileRemovedListener;

		global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListenerImplementor __CreateITileRemovedListenerImplementor ()
		{
			return new global::Osmdroid.TileProvider.LRUMapTileCache.ITileRemovedListenerImplementor (this);
		}
#endregion
	}
}
