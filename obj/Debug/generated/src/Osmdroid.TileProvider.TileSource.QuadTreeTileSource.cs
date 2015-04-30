using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='QuadTreeTileSource']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/QuadTreeTileSource", DoNotGenerateAcw=true)]
	public partial class QuadTreeTileSource : global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/QuadTreeTileSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (QuadTreeTileSource); }
		}

		protected QuadTreeTileSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='QuadTreeTileSource']/constructor[@name='QuadTreeTileSource' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.osmdroid.ResourceProxy.string'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String[]']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;[Ljava/lang/String;)V", "")]
		public QuadTreeTileSource (string aName, global::Osmdroid.ResourceProxyString aResourceId, int aZoomMinLevel, int aZoomMaxLevel, int aTileSizePixels, string aImageFilenameEnding, string[] aBaseUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_aName = JNIEnv.NewString (aName);;
			IntPtr native_aImageFilenameEnding = JNIEnv.NewString (aImageFilenameEnding);;
			IntPtr native_aBaseUrl = JNIEnv.NewArray (aBaseUrl);;
			if (GetType () != typeof (QuadTreeTileSource)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;[Ljava/lang/String;)V", new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding), new JValue (native_aBaseUrl)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;[Ljava/lang/String;)V", new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding), new JValue (native_aBaseUrl));
				JNIEnv.DeleteLocalRef (native_aName);
				JNIEnv.DeleteLocalRef (native_aImageFilenameEnding);
				if (aBaseUrl != null) {
					JNIEnv.CopyArray (native_aBaseUrl, aBaseUrl);
					JNIEnv.DeleteLocalRef (native_aBaseUrl);
				}
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;[Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_arrayLjava_lang_String_, new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding), new JValue (native_aBaseUrl)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_arrayLjava_lang_String_, new JValue (native_aName), new JValue (aResourceId), new JValue (aZoomMinLevel), new JValue (aZoomMaxLevel), new JValue (aTileSizePixels), new JValue (native_aImageFilenameEnding), new JValue (native_aBaseUrl));
			JNIEnv.DeleteLocalRef (native_aName);
			JNIEnv.DeleteLocalRef (native_aImageFilenameEnding);
			if (aBaseUrl != null) {
				JNIEnv.CopyArray (native_aBaseUrl, aBaseUrl);
				JNIEnv.DeleteLocalRef (native_aBaseUrl);
			}
		}

		static Delegate cb_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetTileURLString_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTileURLString_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetTileURLString_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile)
		{
			global::Osmdroid.TileProvider.TileSource.QuadTreeTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.QuadTreeTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTileURLString (aTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='QuadTreeTileSource']/method[@name='getTileURLString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;", "GetGetTileURLString_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public override string GetTileURLString (global::Osmdroid.TileProvider.MapTile aTile)
		{
			if (id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;"), new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_quadTree_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetQuadTree_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_quadTree_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_quadTree_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_QuadTree_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_quadTree_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_QuadTree_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTile)
		{
			global::Osmdroid.TileProvider.TileSource.QuadTreeTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.QuadTreeTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.QuadTree (aTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_quadTree_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='QuadTreeTileSource']/method[@name='quadTree' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("quadTree", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;", "GetQuadTree_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		protected virtual string QuadTree (global::Osmdroid.TileProvider.MapTile aTile)
		{
			if (id_quadTree_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_quadTree_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "quadTree", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_quadTree_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quadTree", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;"), new JValue (aTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
