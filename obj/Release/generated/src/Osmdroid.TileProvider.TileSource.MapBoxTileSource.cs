using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/MapBoxTileSource", DoNotGenerateAcw=true)]
	public partial class MapBoxTileSource : global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/MapBoxTileSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapBoxTileSource); }
		}

		protected MapBoxTileSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/constructor[@name='MapBoxTileSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MapBoxTileSource () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapBoxTileSource)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/constructor[@name='MapBoxTileSource' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.osmdroid.ResourceProxy.string'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public MapBoxTileSource (string name, global::Osmdroid.ResourceProxyString resourceId, int zoomMinLevel, int zoomMaxLevel, int tileSizePixels, string imageFilenameEnding, string mapBoxMapId, string mapBoxVersionBaseUrl) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);;
			IntPtr native_imageFilenameEnding = JNIEnv.NewString (imageFilenameEnding);;
			IntPtr native_mapBoxMapId = JNIEnv.NewString (mapBoxMapId);;
			IntPtr native_mapBoxVersionBaseUrl = JNIEnv.NewString (mapBoxVersionBaseUrl);;
			if (GetType () != typeof (MapBoxTileSource)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding), new JValue (native_mapBoxMapId), new JValue (native_mapBoxVersionBaseUrl)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding), new JValue (native_mapBoxMapId), new JValue (native_mapBoxVersionBaseUrl));
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_imageFilenameEnding);
				JNIEnv.DeleteLocalRef (native_mapBoxMapId);
				JNIEnv.DeleteLocalRef (native_mapBoxVersionBaseUrl);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding), new JValue (native_mapBoxMapId), new JValue (native_mapBoxVersionBaseUrl)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_Ljava_lang_String_Ljava_lang_String_, new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding), new JValue (native_mapBoxMapId), new JValue (native_mapBoxVersionBaseUrl));
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_imageFilenameEnding);
			JNIEnv.DeleteLocalRef (native_mapBoxMapId);
			JNIEnv.DeleteLocalRef (native_mapBoxVersionBaseUrl);
		}

		static IntPtr id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/constructor[@name='MapBoxTileSource' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.osmdroid.ResourceProxy.string'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", "")]
		public MapBoxTileSource (string name, global::Osmdroid.ResourceProxyString resourceId, int zoomMinLevel, int zoomMaxLevel, int tileSizePixels, string imageFilenameEnding) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);;
			IntPtr native_imageFilenameEnding = JNIEnv.NewString (imageFilenameEnding);;
			if (GetType () != typeof (MapBoxTileSource)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V", new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding));
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_imageFilenameEnding);
				return;
			}

			if (id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lorg/osmdroid/ResourceProxy$string;IIILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_, new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lorg_osmdroid_ResourceProxy_string_IIILjava_lang_String_, new JValue (native_name), new JValue (resourceId), new JValue (zoomMinLevel), new JValue (zoomMaxLevel), new JValue (tileSizePixels), new JValue (native_imageFilenameEnding));
			JNIEnv.DeleteLocalRef (native_name);
			JNIEnv.DeleteLocalRef (native_imageFilenameEnding);
		}

		static IntPtr id_getMapBoxMapId;
		public static string MapBoxMapId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/method[@name='getMapBoxMapId' and count(parameter)=0]"
			[Register ("getMapBoxMapId", "()Ljava/lang/String;", "GetGetMapBoxMapIdHandler")]
			get {
				if (id_getMapBoxMapId == IntPtr.Zero)
					id_getMapBoxMapId = JNIEnv.GetStaticMethodID (class_ref, "getMapBoxMapId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMapBoxMapId), JniHandleOwnership.TransferLocalRef);
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

		static IntPtr n_GetTileURLString_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aMapTile)
		{
			global::Osmdroid.TileProvider.TileSource.MapBoxTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.MapBoxTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile aMapTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_aMapTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTileURLString (aMapTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/method[@name='getTileURLString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;", "GetGetTileURLString_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public override string GetTileURLString (global::Osmdroid.TileProvider.MapTile aMapTile)
		{
			if (id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTileURLString_Lorg_osmdroid_tileprovider_MapTile_, new JValue (aMapTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileURLString", "(Lorg/osmdroid/tileprovider/MapTile;)Ljava/lang/String;"), new JValue (aMapTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_retrieveMapBoxMapId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='MapBoxTileSource']/method[@name='retrieveMapBoxMapId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("retrieveMapBoxMapId", "(Landroid/content/Context;)V", "")]
		public static void RetrieveMapBoxMapId (global::Android.Content.Context aContext)
		{
			if (id_retrieveMapBoxMapId_Landroid_content_Context_ == IntPtr.Zero)
				id_retrieveMapBoxMapId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "retrieveMapBoxMapId", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_retrieveMapBoxMapId_Landroid_content_Context_, new JValue (aContext));
		}

	}
}
