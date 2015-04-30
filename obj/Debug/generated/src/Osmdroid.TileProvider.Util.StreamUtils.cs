using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='StreamUtils']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/util/StreamUtils", DoNotGenerateAcw=true)]
	public partial class StreamUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='StreamUtils']/field[@name='IO_BUFFER_SIZE']"
		[Register ("IO_BUFFER_SIZE")]
		public const int IoBufferSize = (int) 8192;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/util/StreamUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StreamUtils); }
		}

		protected StreamUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_closeStream_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='StreamUtils']/method[@name='closeStream' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeStream", "(Ljava/io/Closeable;)V", "")]
		public static void CloseStream (global::Java.IO.ICloseable stream)
		{
			if (id_closeStream_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeStream_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeStream", "(Ljava/io/Closeable;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeStream_Ljava_io_Closeable_, new JValue (stream));
		}

		static IntPtr id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='StreamUtils']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.io.OutputStream']]"
		[Register ("copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)J", "")]
		public static long Copy (global::System.IO.Stream @in, global::System.IO.Stream @out)
		{
			if (id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ == IntPtr.Zero)
				id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_ = JNIEnv.GetStaticMethodID (class_ref, "copy", "(Ljava/io/InputStream;Ljava/io/OutputStream;)J");
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_copy_Ljava_io_InputStream_Ljava_io_OutputStream_, new JValue (native__in), new JValue (native__out));
			JNIEnv.DeleteLocalRef (native__in);
			JNIEnv.DeleteLocalRef (native__out);
			return __ret;
		}

	}
}
