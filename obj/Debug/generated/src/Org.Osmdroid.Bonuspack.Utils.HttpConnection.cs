using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/utils/HttpConnection", DoNotGenerateAcw=true)]
	public partial class HttpConnection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/utils/HttpConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpConnection); }
		}

		protected HttpConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/constructor[@name='HttpConnection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public HttpConnection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (HttpConnection)) {
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

		static Delegate cb_getContentAsString;
#pragma warning disable 0169
		static Delegate GetGetContentAsStringHandler ()
		{
			if (cb_getContentAsString == null)
				cb_getContentAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentAsString);
			return cb_getContentAsString;
		}

		static IntPtr n_GetContentAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentAsString);
		}
#pragma warning restore 0169

		static IntPtr id_getContentAsString;
		public virtual string ContentAsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='getContentAsString' and count(parameter)=0]"
			[Register ("getContentAsString", "()Ljava/lang/String;", "GetGetContentAsStringHandler")]
			get {
				if (id_getContentAsString == IntPtr.Zero)
					id_getContentAsString = JNIEnv.GetMethodID (class_ref, "getContentAsString", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContentAsString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentAsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStream;
#pragma warning disable 0169
		static Delegate GetGetStreamHandler ()
		{
			if (cb_getStream == null)
				cb_getStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStream);
			return cb_getStream;
		}

		static IntPtr n_GetStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.Stream);
		}
#pragma warning restore 0169

		static IntPtr id_getStream;
		public virtual global::System.IO.Stream Stream {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='getStream' and count(parameter)=0]"
			[Register ("getStream", "()Ljava/io/InputStream;", "GetGetStreamHandler")]
			get {
				if (id_getStream == IntPtr.Zero)
					id_getStream = JNIEnv.GetMethodID (class_ref, "getStream", "()Ljava/io/InputStream;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getStream), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_doGet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDoGet_Ljava_lang_String_Handler ()
		{
			if (cb_doGet_Ljava_lang_String_ == null)
				cb_doGet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DoGet_Ljava_lang_String_);
			return cb_doGet_Ljava_lang_String_;
		}

		static void n_DoGet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DoGet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_doGet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='doGet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("doGet", "(Ljava/lang/String;)V", "GetDoGet_Ljava_lang_String_Handler")]
		public virtual void DoGet (string p0)
		{
			if (id_doGet_Ljava_lang_String_ == IntPtr.Zero)
				id_doGet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doGet", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doGet_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doGet", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_doPost_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDoPost_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_doPost_Ljava_lang_String_Ljava_util_List_ == null)
				cb_doPost_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoPost_Ljava_lang_String_Ljava_util_List_);
			return cb_doPost_Ljava_lang_String_Ljava_util_List_;
		}

		static void n_DoPost_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Apache.Http.INameValuePair> p1 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DoPost (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_doPost_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='doPost' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List']]"
		[Register ("doPost", "(Ljava/lang/String;Ljava/util/List;)V", "GetDoPost_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual void DoPost (string p0, global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> p1)
		{
			if (id_doPost_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_doPost_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "doPost", "(Ljava/lang/String;Ljava/util/List;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_doPost_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doPost", "(Ljava/lang/String;Ljava/util/List;)V"), new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgent_Ljava_lang_String_ == null)
				cb_setUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgent_Ljava_lang_String_);
			return cb_setUserAgent_Ljava_lang_String_;
		}

		static void n_SetUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Utils.HttpConnection __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Utils.HttpConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserAgent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='HttpConnection']/method[@name='setUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserAgent", "(Ljava/lang/String;)V", "GetSetUserAgent_Ljava_lang_String_Handler")]
		public virtual void SetUserAgent (string p0)
		{
			if (id_setUserAgent_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserAgent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserAgent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUserAgent_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAgent", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
