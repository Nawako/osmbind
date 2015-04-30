using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.http']/interface[@name='IHttpClientFactory']"
	[Register ("org/osmdroid/http/IHttpClientFactory", "", "Org.Osmdroid.Http.IHttpClientFactoryInvoker")]
	public partial interface IHttpClientFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.http']/interface[@name='IHttpClientFactory']/method[@name='createHttpClient' and count(parameter)=0]"
		[Register ("createHttpClient", "()Lorg/apache/http/client/HttpClient;", "GetCreateHttpClientHandler:Org.Osmdroid.Http.IHttpClientFactoryInvoker, OsmdroidAndroidBinding")]
		global::Org.Apache.Http.Client.IHttpClient CreateHttpClient ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/http/IHttpClientFactory", DoNotGenerateAcw=true)]
	internal class IHttpClientFactoryInvoker : global::Java.Lang.Object, IHttpClientFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/http/IHttpClientFactory");
		IntPtr class_ref;

		public static IHttpClientFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpClientFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.http.IHttpClientFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpClientFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IHttpClientFactoryInvoker); }
		}

		static Delegate cb_createHttpClient;
#pragma warning disable 0169
		static Delegate GetCreateHttpClientHandler ()
		{
			if (cb_createHttpClient == null)
				cb_createHttpClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateHttpClient);
			return cb_createHttpClient;
		}

		static IntPtr n_CreateHttpClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Http.IHttpClientFactory __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Http.IHttpClientFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateHttpClient ());
		}
#pragma warning restore 0169

		IntPtr id_createHttpClient;
		public global::Org.Apache.Http.Client.IHttpClient CreateHttpClient ()
		{
			if (id_createHttpClient == IntPtr.Zero)
				id_createHttpClient = JNIEnv.GetMethodID (class_ref, "createHttpClient", "()Lorg/apache/http/client/HttpClient;");
			return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Client.IHttpClient> (JNIEnv.CallObjectMethod (Handle, id_createHttpClient), JniHandleOwnership.TransferLocalRef);
		}

	}

}
