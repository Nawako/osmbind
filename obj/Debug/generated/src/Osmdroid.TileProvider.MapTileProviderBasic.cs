using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBasic']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderBasic", DoNotGenerateAcw=true)]
	public partial class MapTileProviderBasic : global::Osmdroid.TileProvider.MapTileProviderArray, global::Osmdroid.TileProvider.IMapTileProviderCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderBasic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileProviderBasic); }
		}

		protected MapTileProviderBasic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBasic']/constructor[@name='MapTileProviderBasic' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MapTileProviderBasic (global::Android.Content.Context pContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderBasic)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (pContext)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (pContext));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (pContext)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (pContext));
		}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBasic']/constructor[@name='MapTileProviderBasic' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "")]
		public MapTileProviderBasic (global::Android.Content.Context pContext, global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderBasic)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pContext), new JValue (pTileSource)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pContext), new JValue (pTileSource));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pContext), new JValue (pTileSource)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pContext), new JValue (pTileSource));
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_modules_INetworkAvailablityCheck_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderBasic']/constructor[@name='MapTileProviderBasic' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='org.osmdroid.tileprovider.modules.INetworkAvailablityCheck'] and parameter[3][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/modules/INetworkAvailablityCheck;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "")]
		public MapTileProviderBasic (global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver, global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck aNetworkAvailablityCheck, global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderBasic)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/modules/INetworkAvailablityCheck;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pRegisterReceiver), new JValue (aNetworkAvailablityCheck), new JValue (pTileSource)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/modules/INetworkAvailablityCheck;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", new JValue (pRegisterReceiver), new JValue (aNetworkAvailablityCheck), new JValue (pTileSource));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_modules_INetworkAvailablityCheck_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_modules_INetworkAvailablityCheck_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Lorg/osmdroid/tileprovider/modules/INetworkAvailablityCheck;Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_modules_INetworkAvailablityCheck_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pRegisterReceiver), new JValue (aNetworkAvailablityCheck), new JValue (pTileSource)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Lorg_osmdroid_tileprovider_modules_INetworkAvailablityCheck_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (pRegisterReceiver), new JValue (aNetworkAvailablityCheck), new JValue (pTileSource));
		}

	}
}
