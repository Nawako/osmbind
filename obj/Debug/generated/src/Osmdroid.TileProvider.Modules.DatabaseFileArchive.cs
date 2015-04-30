using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='DatabaseFileArchive']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/DatabaseFileArchive", DoNotGenerateAcw=true)]
	public partial class DatabaseFileArchive : global::Java.Lang.Object, global::Osmdroid.TileProvider.Modules.IArchiveFile {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/DatabaseFileArchive", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DatabaseFileArchive); }
		}

		protected DatabaseFileArchive (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.DatabaseFileArchive __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.DatabaseFileArchive> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='DatabaseFileArchive']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static IntPtr id_getDatabaseFileArchive_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='DatabaseFileArchive']/method[@name='getDatabaseFileArchive' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getDatabaseFileArchive", "(Ljava/io/File;)Lorg/osmdroid/tileprovider/modules/DatabaseFileArchive;", "")]
		public static global::Osmdroid.TileProvider.Modules.DatabaseFileArchive GetDatabaseFileArchive (global::Java.IO.File pFile)
		{
			if (id_getDatabaseFileArchive_Ljava_io_File_ == IntPtr.Zero)
				id_getDatabaseFileArchive_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getDatabaseFileArchive", "(Ljava/io/File;)Lorg/osmdroid/tileprovider/modules/DatabaseFileArchive;");
			global::Osmdroid.TileProvider.Modules.DatabaseFileArchive __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.DatabaseFileArchive> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDatabaseFileArchive_Ljava_io_File_, new JValue (pFile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTileSource, IntPtr native_pTile)
		{
			global::Osmdroid.TileProvider.Modules.DatabaseFileArchive __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.DatabaseFileArchive> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_pTileSource, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile pTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_pTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetInputStream (pTileSource, pTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='DatabaseFileArchive']/method[@name='getInputStream' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getInputStream", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;)Ljava/io/InputStream;", "GetGetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public virtual global::System.IO.Stream GetInputStream (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, global::Osmdroid.TileProvider.MapTile pTile)
		{
			if (id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getInputStream", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;)Ljava/io/InputStream;");

			global::System.IO.Stream __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_, new JValue (pTileSource), new JValue (pTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;)Ljava/io/InputStream;"), new JValue (pTileSource), new JValue (pTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
