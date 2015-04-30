using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='IFilesystemCache']"
	[Register ("org/osmdroid/tileprovider/modules/IFilesystemCache", "", "Osmdroid.TileProvider.Modules.IFilesystemCacheInvoker")]
	public partial interface IFilesystemCache : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='IFilesystemCache']/method[@name='saveFile' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile'] and parameter[3][@type='java.io.InputStream']]"
		[Register ("saveFile", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;Ljava/io/InputStream;)Z", "GetSaveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_Handler:Osmdroid.TileProvider.Modules.IFilesystemCacheInvoker, OsmdroidAndroidBinding")]
		bool SaveFile (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSourceInfo, global::Osmdroid.TileProvider.MapTile pTile, global::System.IO.Stream pStream);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/IFilesystemCache", DoNotGenerateAcw=true)]
	internal class IFilesystemCacheInvoker : global::Java.Lang.Object, IFilesystemCache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/IFilesystemCache");
		IntPtr class_ref;

		public static IFilesystemCache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFilesystemCache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.modules.IFilesystemCache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFilesystemCacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IFilesystemCacheInvoker); }
		}

		static Delegate cb_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSaveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_Handler ()
		{
			if (cb_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_ == null)
				cb_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SaveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_);
			return cb_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_;
		}

		static bool n_SaveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTileSourceInfo, IntPtr native_pTile, IntPtr native_pStream)
		{
			global::Osmdroid.TileProvider.Modules.IFilesystemCache __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.IFilesystemCache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource pTileSourceInfo = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_pTileSourceInfo, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile pTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_pTile, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream pStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_pStream, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveFile (pTileSourceInfo, pTile, pStream);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_;
		public bool SaveFile (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSourceInfo, global::Osmdroid.TileProvider.MapTile pTile, global::System.IO.Stream pStream)
		{
			if (id_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_ == IntPtr.Zero)
				id_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "saveFile", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;Ljava/io/InputStream;)Z");
			IntPtr native_pStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (pStream);
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_saveFile_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Ljava_io_InputStream_, new JValue (pTileSourceInfo), new JValue (pTile), new JValue (native_pStream));
			JNIEnv.DeleteLocalRef (native_pStream);
			return __ret;
		}

	}

}
