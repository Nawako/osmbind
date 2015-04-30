using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleRegisterReceiver']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/util/SimpleRegisterReceiver", DoNotGenerateAcw=true)]
	public partial class SimpleRegisterReceiver : global::Java.Lang.Object, global::Osmdroid.TileProvider.IRegisterReceiver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/util/SimpleRegisterReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleRegisterReceiver); }
		}

		protected SimpleRegisterReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleRegisterReceiver']/constructor[@name='SimpleRegisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public SimpleRegisterReceiver (global::Android.Content.Context pContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleRegisterReceiver)) {
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

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aReceiver, IntPtr native_aFilter)
		{
			global::Osmdroid.TileProvider.Util.SimpleRegisterReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Util.SimpleRegisterReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver aReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_aReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter aFilter = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_aFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (aReceiver, aFilter));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleRegisterReceiver']/method[@name='registerReceiver' and count(parameter)=2 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler")]
		public virtual global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver aReceiver, global::Android.Content.IntentFilter aFilter)
		{
			if (id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == IntPtr.Zero)
				id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNIEnv.GetMethodID (class_ref, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");

			global::Android.Content.Intent __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod  (Handle, id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_, new JValue (aReceiver), new JValue (aFilter)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;"), new JValue (aReceiver), new JValue (aFilter)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler ()
		{
			if (cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ == null)
				cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterReceiver_Landroid_content_BroadcastReceiver_);
			return cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		}

		static void n_UnregisterReceiver_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aReceiver)
		{
			global::Osmdroid.TileProvider.Util.SimpleRegisterReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Util.SimpleRegisterReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver aReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_aReceiver, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceiver (aReceiver);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleRegisterReceiver']/method[@name='unregisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public virtual void UnregisterReceiver (global::Android.Content.BroadcastReceiver aReceiver)
		{
			if (id_unregisterReceiver_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unregisterReceiver_Landroid_content_BroadcastReceiver_, new JValue (aReceiver));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V"), new JValue (aReceiver));
		}

	}
}
