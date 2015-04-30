using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ArchiveFileFactory']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/ArchiveFileFactory", DoNotGenerateAcw=true)]
	public partial class ArchiveFileFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/ArchiveFileFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArchiveFileFactory); }
		}

		protected ArchiveFileFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ArchiveFileFactory']/constructor[@name='ArchiveFileFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ArchiveFileFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ArchiveFileFactory)) {
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

		static IntPtr id_getArchiveFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ArchiveFileFactory']/method[@name='getArchiveFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getArchiveFile", "(Ljava/io/File;)Lorg/osmdroid/tileprovider/modules/IArchiveFile;", "")]
		public static global::Osmdroid.TileProvider.Modules.IArchiveFile GetArchiveFile (global::Java.IO.File pFile)
		{
			if (id_getArchiveFile_Ljava_io_File_ == IntPtr.Zero)
				id_getArchiveFile_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getArchiveFile", "(Ljava/io/File;)Lorg/osmdroid/tileprovider/modules/IArchiveFile;");
			global::Osmdroid.TileProvider.Modules.IArchiveFile __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.IArchiveFile> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getArchiveFile_Ljava_io_File_, new JValue (pFile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
