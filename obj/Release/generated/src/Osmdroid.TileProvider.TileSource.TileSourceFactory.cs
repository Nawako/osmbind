using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/TileSourceFactory", DoNotGenerateAcw=true)]
	public partial class TileSourceFactory : global::Java.Lang.Object {


		static IntPtr BASE_OVERLAY_NL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='BASE_OVERLAY_NL']"
		[Register ("BASE_OVERLAY_NL")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase BaseOverlayNl {
			get {
				if (BASE_OVERLAY_NL_jfieldId == IntPtr.Zero)
					BASE_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BASE_OVERLAY_NL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BASE_OVERLAY_NL_jfieldId == IntPtr.Zero)
					BASE_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BASE_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, BASE_OVERLAY_NL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CLOUDMADESMALLTILES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='CLOUDMADESMALLTILES']"
		[Register ("CLOUDMADESMALLTILES")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Cloudmadesmalltiles {
			get {
				if (CLOUDMADESMALLTILES_jfieldId == IntPtr.Zero)
					CLOUDMADESMALLTILES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOUDMADESMALLTILES", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOUDMADESMALLTILES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLOUDMADESMALLTILES_jfieldId == IntPtr.Zero)
					CLOUDMADESMALLTILES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOUDMADESMALLTILES", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLOUDMADESMALLTILES_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CLOUDMADESTANDARDTILES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='CLOUDMADESTANDARDTILES']"
		[Register ("CLOUDMADESTANDARDTILES")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Cloudmadestandardtiles {
			get {
				if (CLOUDMADESTANDARDTILES_jfieldId == IntPtr.Zero)
					CLOUDMADESTANDARDTILES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOUDMADESTANDARDTILES", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOUDMADESTANDARDTILES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLOUDMADESTANDARDTILES_jfieldId == IntPtr.Zero)
					CLOUDMADESTANDARDTILES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOUDMADESTANDARDTILES", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CLOUDMADESTANDARDTILES_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr CYCLEMAP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='CYCLEMAP']"
		[Register ("CYCLEMAP")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Cyclemap {
			get {
				if (CYCLEMAP_jfieldId == IntPtr.Zero)
					CYCLEMAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CYCLEMAP", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CYCLEMAP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CYCLEMAP_jfieldId == IntPtr.Zero)
					CYCLEMAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CYCLEMAP", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CYCLEMAP_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr DEFAULT_TILE_SOURCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='DEFAULT_TILE_SOURCE']"
		[Register ("DEFAULT_TILE_SOURCE")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase DefaultTileSource {
			get {
				if (DEFAULT_TILE_SOURCE_jfieldId == IntPtr.Zero)
					DEFAULT_TILE_SOURCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_TILE_SOURCE", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_TILE_SOURCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_TILE_SOURCE_jfieldId == IntPtr.Zero)
					DEFAULT_TILE_SOURCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_TILE_SOURCE", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_TILE_SOURCE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr FIETS_OVERLAY_NL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='FIETS_OVERLAY_NL']"
		[Register ("FIETS_OVERLAY_NL")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase FietsOverlayNl {
			get {
				if (FIETS_OVERLAY_NL_jfieldId == IntPtr.Zero)
					FIETS_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIETS_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIETS_OVERLAY_NL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FIETS_OVERLAY_NL_jfieldId == IntPtr.Zero)
					FIETS_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIETS_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, FIETS_OVERLAY_NL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAPNIK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='MAPNIK']"
		[Register ("MAPNIK")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Mapnik {
			get {
				if (MAPNIK_jfieldId == IntPtr.Zero)
					MAPNIK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPNIK", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAPNIK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAPNIK_jfieldId == IntPtr.Zero)
					MAPNIK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPNIK", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAPNIK_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAPQUESTAERIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='MAPQUESTAERIAL']"
		[Register ("MAPQUESTAERIAL")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Mapquestaerial {
			get {
				if (MAPQUESTAERIAL_jfieldId == IntPtr.Zero)
					MAPQUESTAERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPQUESTAERIAL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAPQUESTAERIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAPQUESTAERIAL_jfieldId == IntPtr.Zero)
					MAPQUESTAERIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPQUESTAERIAL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAPQUESTAERIAL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAPQUESTOSM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='MAPQUESTOSM']"
		[Register ("MAPQUESTOSM")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase Mapquestosm {
			get {
				if (MAPQUESTOSM_jfieldId == IntPtr.Zero)
					MAPQUESTOSM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPQUESTOSM", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAPQUESTOSM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAPQUESTOSM_jfieldId == IntPtr.Zero)
					MAPQUESTOSM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAPQUESTOSM", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, MAPQUESTOSM_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PUBLIC_TRANSPORT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='PUBLIC_TRANSPORT']"
		[Register ("PUBLIC_TRANSPORT")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase PublicTransport {
			get {
				if (PUBLIC_TRANSPORT_jfieldId == IntPtr.Zero)
					PUBLIC_TRANSPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC_TRANSPORT", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PUBLIC_TRANSPORT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PUBLIC_TRANSPORT_jfieldId == IntPtr.Zero)
					PUBLIC_TRANSPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PUBLIC_TRANSPORT", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, PUBLIC_TRANSPORT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ROADS_OVERLAY_NL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/field[@name='ROADS_OVERLAY_NL']"
		[Register ("ROADS_OVERLAY_NL")]
		public static global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase RoadsOverlayNl {
			get {
				if (ROADS_OVERLAY_NL_jfieldId == IntPtr.Zero)
					ROADS_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROADS_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROADS_OVERLAY_NL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.OnlineTileSourceBase> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ROADS_OVERLAY_NL_jfieldId == IntPtr.Zero)
					ROADS_OVERLAY_NL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROADS_OVERLAY_NL", "Lorg/osmdroid/tileprovider/tilesource/OnlineTileSourceBase;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ROADS_OVERLAY_NL_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/TileSourceFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileSourceFactory); }
		}

		protected TileSourceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/constructor[@name='TileSourceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TileSourceFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TileSourceFactory)) {
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

		static IntPtr id_getTileSources;
		public static global::System.Collections.Generic.IList<global::Osmdroid.TileProvider.TileSource.ITileSource> TileSources {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/method[@name='getTileSources' and count(parameter)=0]"
			[Register ("getTileSources", "()Ljava/util/ArrayList;", "GetGetTileSourcesHandler")]
			get {
				if (id_getTileSources == IntPtr.Zero)
					id_getTileSources = JNIEnv.GetStaticMethodID (class_ref, "getTileSources", "()Ljava/util/ArrayList;");
				return global::Android.Runtime.JavaList<global::Osmdroid.TileProvider.TileSource.ITileSource>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTileSources), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr id_addTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/method[@name='addTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("addTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "")]
		public static void AddTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource mTileSource)
		{
			if (id_addTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_addTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetStaticMethodID (class_ref, "addTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_addTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (mTileSource));
		}

		static IntPtr id_containsTileSource_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/method[@name='containsTileSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsTileSource", "(Ljava/lang/String;)Z", "")]
		public static bool ContainsTileSource (string aName)
		{
			if (id_containsTileSource_Ljava_lang_String_ == IntPtr.Zero)
				id_containsTileSource_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "containsTileSource", "(Ljava/lang/String;)Z");
			IntPtr native_aName = JNIEnv.NewString (aName);
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_containsTileSource_Ljava_lang_String_, new JValue (native_aName));
			JNIEnv.DeleteLocalRef (native_aName);
			return __ret;
		}

		static IntPtr id_getTileSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/method[@name='getTileSource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTileSource", "(I)Lorg/osmdroid/tileprovider/tilesource/ITileSource;", "")]
		public static global::Osmdroid.TileProvider.TileSource.ITileSource GetTileSource (int aOrdinal)
		{
			if (id_getTileSource_I == IntPtr.Zero)
				id_getTileSource_I = JNIEnv.GetStaticMethodID (class_ref, "getTileSource", "(I)Lorg/osmdroid/tileprovider/tilesource/ITileSource;");
			return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTileSource_I, new JValue (aOrdinal)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getTileSource_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/class[@name='TileSourceFactory']/method[@name='getTileSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTileSource", "(Ljava/lang/String;)Lorg/osmdroid/tileprovider/tilesource/ITileSource;", "")]
		public static global::Osmdroid.TileProvider.TileSource.ITileSource GetTileSource (string aName)
		{
			if (id_getTileSource_Ljava_lang_String_ == IntPtr.Zero)
				id_getTileSource_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getTileSource", "(Ljava/lang/String;)Lorg/osmdroid/tileprovider/tilesource/ITileSource;");
			IntPtr native_aName = JNIEnv.NewString (aName);
			global::Osmdroid.TileProvider.TileSource.ITileSource __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTileSource_Ljava_lang_String_, new JValue (native_aName)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aName);
			return __ret;
		}

	}
}
