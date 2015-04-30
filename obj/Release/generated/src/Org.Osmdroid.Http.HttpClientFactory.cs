using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.http']/class[@name='HttpClientFactory']"
	[global::Android.Runtime.Register ("org/osmdroid/http/HttpClientFactory", DoNotGenerateAcw=true)]
	public partial class HttpClientFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/http/HttpClientFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientFactory); }
		}

		protected HttpClientFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.http']/class[@name='HttpClientFactory']/constructor[@name='HttpClientFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HttpClientFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpClientFactory)) {
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

		static IntPtr id_createHttpClient;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.http']/class[@name='HttpClientFactory']/method[@name='createHttpClient' and count(parameter)=0]"
		[Register ("createHttpClient", "()Lorg/apache/http/client/HttpClient;", "")]
		public static global::Org.Apache.Http.Client.IHttpClient CreateHttpClient ()
		{
			if (id_createHttpClient == IntPtr.Zero)
				id_createHttpClient = JNIEnv.GetStaticMethodID (class_ref, "createHttpClient", "()Lorg/apache/http/client/HttpClient;");
			return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHttpClient), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_setFactoryInstance_Lorg_osmdroid_http_IHttpClientFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.http']/class[@name='HttpClientFactory']/method[@name='setFactoryInstance' and count(parameter)=1 and parameter[1][@type='org.osmdroid.http.IHttpClientFactory']]"
		[Register ("setFactoryInstance", "(Lorg/osmdroid/http/IHttpClientFactory;)V", "")]
		public static void SetFactoryInstance (global::Org.Osmdroid.Http.IHttpClientFactory aHttpClientFactory)
		{
			if (id_setFactoryInstance_Lorg_osmdroid_http_IHttpClientFactory_ == IntPtr.Zero)
				id_setFactoryInstance_Lorg_osmdroid_http_IHttpClientFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setFactoryInstance", "(Lorg/osmdroid/http/IHttpClientFactory;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setFactoryInstance_Lorg_osmdroid_http_IHttpClientFactory_, new JValue (aHttpClientFactory));
		}

	}
}
