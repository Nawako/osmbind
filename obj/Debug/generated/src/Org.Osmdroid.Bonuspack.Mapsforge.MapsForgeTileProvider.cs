using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Mapsforge {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileProvider", DoNotGenerateAcw=true)]
	public partial class MapsForgeTileProvider : global::Osmdroid.TileProvider.MapTileProviderArray {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/mapsforge/MapsForgeTileProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapsForgeTileProvider); }
		}

		protected MapsForgeTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='MapsForgeTileProvider']/constructor[@name='MapsForgeTileProvider' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[2][@type='java.io.File']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Ljava/io/File;)V", "")]
		public MapsForgeTileProvider (global::Osmdroid.TileProvider.IRegisterReceiver p0, global::Java.IO.File p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapsForgeTileProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Ljava/io/File;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Ljava/io/File;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Ljava_io_File_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/IRegisterReceiver;Ljava/io/File;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Ljava_io_File_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_IRegisterReceiver_Ljava_io_File_, new JValue (p0), new JValue (p1));
		}

	}
}
