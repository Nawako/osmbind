using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']"
	[Register ("org/osmdroid/tileprovider/tilesource/ITileSource", "", "Osmdroid.TileProvider.TileSource.ITileSourceInvoker")]
	public partial interface ITileSource : IJavaObject {

		int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")] get;
		}

		int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")] get;
		}

		int TileSizePixels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getTileSizePixels' and count(parameter)=0]"
			[Register ("getTileSizePixels", "()I", "GetGetTileSizePixelsHandler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("getDrawable", "(Ljava/io/InputStream;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_io_InputStream_Handler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		global::Android.Graphics.Drawables.Drawable GetDrawable (global::System.IO.Stream aTileInputStream);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Ljava_lang_String_Handler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		global::Android.Graphics.Drawables.Drawable GetDrawable (string aFilePath);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='getTileRelativeFilenameString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getTileRelativeFilenameString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;", "GetGetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_Handler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		string GetTileRelativeFilenameString (global::Osmdroid.TileProvider.MapTile aTile);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='localizedName' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register ("localizedName", "(Lorg/osmdroid/ResourceProxy;)Ljava/lang/String;", "GetLocalizedName_Lorg_osmdroid_ResourceProxy_Handler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		string LocalizedName (global::Osmdroid.IResourceProxy proxy);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		string Name ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='ITileSource']/method[@name='ordinal' and count(parameter)=0]"
		[Register ("ordinal", "()I", "GetOrdinalHandler:Osmdroid.TileProvider.TileSource.ITileSourceInvoker, OsmdroidAndroidBinding")]
		int Ordinal ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/ITileSource", DoNotGenerateAcw=true)]
	internal class ITileSourceInvoker : global::Java.Lang.Object, ITileSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/ITileSource");
		IntPtr class_ref;

		public static ITileSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITileSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.tilesource.ITileSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITileSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (ITileSourceInvoker); }
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMaximumZoomLevel;
		public int MaximumZoomLevel {
			get {
				if (id_getMaximumZoomLevel == IntPtr.Zero)
					id_getMaximumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaximumZoomLevel", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMaximumZoomLevel);
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		IntPtr id_getMinimumZoomLevel;
		public int MinimumZoomLevel {
			get {
				if (id_getMinimumZoomLevel == IntPtr.Zero)
					id_getMinimumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinimumZoomLevel", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getMinimumZoomLevel);
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TileSizePixels;
		}
#pragma warning restore 0169

		IntPtr id_getTileSizePixels;
		public int TileSizePixels {
			get {
				if (id_getTileSizePixels == IntPtr.Zero)
					id_getTileSizePixels = JNIEnv.GetMethodID (class_ref, "getTileSizePixels", "()I");
				return JNIEnv.CallIntMethod (Handle, id_getTileSizePixels);
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

		static IntPtr n_GetDrawable_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTileInputStream)
		{
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream aTileInputStream = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_aTileInputStream, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (aTileInputStream));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDrawable_Ljava_io_InputStream_;
		public global::Android.Graphics.Drawables.Drawable GetDrawable (global::System.IO.Stream aTileInputStream)
		{
			if (id_getDrawable_Ljava_io_InputStream_ == IntPtr.Zero)
				id_getDrawable_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Ljava/io/InputStream;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_aTileInputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (aTileInputStream);
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_getDrawable_Ljava_io_InputStream_, new JValue (native_aTileInputStream)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aTileInputStream);
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aFilePath = JNIEnv.GetString (native_aFilePath, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (aFilePath));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDrawable_Ljava_lang_String_;
		public global::Android.Graphics.Drawables.Drawable GetDrawable (string aFilePath)
		{
			if (id_getDrawable_Ljava_lang_String_ == IntPtr.Zero)
				id_getDrawable_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			IntPtr native_aFilePath = JNIEnv.NewString (aFilePath);
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_getDrawable_Ljava_lang_String_, new JValue (native_aFilePath)), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_GetTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile)
		{
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTileRelativeFilenameString (aTile));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_;
		public string GetTileRelativeFilenameString (global::Osmdroid.TileProvider.MapTile aTile)
		{
			if (id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getTileRelativeFilenameString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getTileRelativeFilenameString_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.IResourceProxy proxy = (global::Osmdroid.IResourceProxy)global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (native_proxy, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LocalizedName (proxy));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_localizedName_Lorg_osmdroid_ResourceProxy_;
		public string LocalizedName (global::Osmdroid.IResourceProxy proxy)
		{
			if (id_localizedName_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_localizedName_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "localizedName", "(Lorg/osmdroid/ResourceProxy;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_localizedName_Lorg_osmdroid_ResourceProxy_, new JValue (proxy)), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		IntPtr id_name;
		public string Name ()
		{
			if (id_name == IntPtr.Zero)
				id_name = JNIEnv.GetMethodID (class_ref, "name", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_name), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.TileProvider.TileSource.ITileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ordinal ();
		}
#pragma warning restore 0169

		IntPtr id_ordinal;
		public int Ordinal ()
		{
			if (id_ordinal == IntPtr.Zero)
				id_ordinal = JNIEnv.GetMethodID (class_ref, "ordinal", "()I");
			return JNIEnv.CallIntMethod (Handle, id_ordinal);
		}

	}

}
