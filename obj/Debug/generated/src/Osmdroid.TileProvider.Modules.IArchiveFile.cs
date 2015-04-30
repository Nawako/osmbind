using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='IArchiveFile']"
	[Register ("org/osmdroid/tileprovider/modules/IArchiveFile", "", "Osmdroid.TileProvider.Modules.IArchiveFileInvoker")]
	public partial interface IArchiveFile : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='IArchiveFile']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Osmdroid.TileProvider.Modules.IArchiveFileInvoker, OsmdroidAndroidBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='IArchiveFile']/method[@name='getInputStream' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getInputStream", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;)Ljava/io/InputStream;", "GetGetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Handler:Osmdroid.TileProvider.Modules.IArchiveFileInvoker, OsmdroidAndroidBinding")]
		global::System.IO.Stream GetInputStream (global::Osmdroid.TileProvider.TileSource.ITileSource tileSource, global::Osmdroid.TileProvider.MapTile tile);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/IArchiveFile", DoNotGenerateAcw=true)]
	internal class IArchiveFileInvoker : global::Java.Lang.Object, IArchiveFile {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/IArchiveFile");
		IntPtr class_ref;

		public static IArchiveFile GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IArchiveFile> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.modules.IArchiveFile"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IArchiveFileInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IArchiveFileInvoker); }
		}

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
			global::Osmdroid.TileProvider.Modules.IArchiveFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.IArchiveFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (Handle, id_close);
		}

		static Delegate cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tileSource, IntPtr native_tile)
		{
			global::Osmdroid.TileProvider.Modules.IArchiveFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.IArchiveFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource tileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_tileSource, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile tile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_tile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetInputStream (tileSource, tile));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_;
		public global::System.IO.Stream GetInputStream (global::Osmdroid.TileProvider.TileSource.ITileSource tileSource, global::Osmdroid.TileProvider.MapTile tile)
		{
			if (id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getInputStream", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/MapTile;)Ljava/io/InputStream;");
			global::System.IO.Stream __ret = global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (Handle, id_getInputStream_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_MapTile_, new JValue (tileSource), new JValue (tile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
