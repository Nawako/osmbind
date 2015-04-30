using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IRegisterReceiver']"
	[Register ("org/osmdroid/tileprovider/IRegisterReceiver", "", "Osmdroid.TileProvider.IRegisterReceiverInvoker")]
	public partial interface IRegisterReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IRegisterReceiver']/method[@name='registerReceiver' and count(parameter)=2 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler:Osmdroid.TileProvider.IRegisterReceiverInvoker, OsmdroidAndroidBinding")]
		global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IRegisterReceiver']/method[@name='unregisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler:Osmdroid.TileProvider.IRegisterReceiverInvoker, OsmdroidAndroidBinding")]
		void UnregisterReceiver (global::Android.Content.BroadcastReceiver receiver);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/IRegisterReceiver", DoNotGenerateAcw=true)]
	internal class IRegisterReceiverInvoker : global::Java.Lang.Object, IRegisterReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/IRegisterReceiver");
		IntPtr class_ref;

		public static IRegisterReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRegisterReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.IRegisterReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRegisterReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IRegisterReceiverInvoker); }
		}

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver, IntPtr native_filter)
		{
			global::Osmdroid.TileProvider.IRegisterReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IRegisterReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter filter = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (receiver, filter));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		public global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			if (id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == IntPtr.Zero)
				id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNIEnv.GetMethodID (class_ref, "registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;");
			global::Android.Content.Intent __ret = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (Handle, id_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_, new JValue (receiver), new JValue (filter)), JniHandleOwnership.TransferLocalRef);
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

		static void n_UnregisterReceiver_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			global::Osmdroid.TileProvider.IRegisterReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IRegisterReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceiver (receiver);
		}
#pragma warning restore 0169

		IntPtr id_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		public void UnregisterReceiver (global::Android.Content.BroadcastReceiver receiver)
		{
			if (id_unregisterReceiver_Landroid_content_BroadcastReceiver_ == IntPtr.Zero)
				id_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNIEnv.GetMethodID (class_ref, "unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V");
			JNIEnv.CallVoidMethod (Handle, id_unregisterReceiver_Landroid_content_BroadcastReceiver_, new JValue (receiver));
		}

	}

}
