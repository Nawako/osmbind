using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ConfigurablePriorityThreadFactory']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/ConfigurablePriorityThreadFactory", DoNotGenerateAcw=true)]
	public partial class ConfigurablePriorityThreadFactory : global::Java.Lang.Object, global::Java.Util.Concurrent.IThreadFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/ConfigurablePriorityThreadFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConfigurablePriorityThreadFactory); }
		}

		protected ConfigurablePriorityThreadFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ConfigurablePriorityThreadFactory']/constructor[@name='ConfigurablePriorityThreadFactory' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public ConfigurablePriorityThreadFactory (int pPriority, string pName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_pName = JNIEnv.NewString (pName);;
			if (GetType () != typeof (ConfigurablePriorityThreadFactory)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;)V", new JValue (pPriority), new JValue (native_pName)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;)V", new JValue (pPriority), new JValue (native_pName));
				JNIEnv.DeleteLocalRef (native_pName);
				return;
			}

			if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
				id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, new JValue (pPriority), new JValue (native_pName)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_, new JValue (pPriority), new JValue (native_pName));
			JNIEnv.DeleteLocalRef (native_pName);
		}

		static Delegate cb_newThread_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetNewThread_Ljava_lang_Runnable_Handler ()
		{
			if (cb_newThread_Ljava_lang_Runnable_ == null)
				cb_newThread_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewThread_Ljava_lang_Runnable_);
			return cb_newThread_Ljava_lang_Runnable_;
		}

		static IntPtr n_NewThread_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pRunnable)
		{
			global::Osmdroid.TileProvider.Modules.ConfigurablePriorityThreadFactory __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.ConfigurablePriorityThreadFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable pRunnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_pRunnable, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewThread (pRunnable));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_newThread_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='ConfigurablePriorityThreadFactory']/method[@name='newThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;", "GetNewThread_Ljava_lang_Runnable_Handler")]
		public virtual global::Java.Lang.Thread NewThread (global::Java.Lang.IRunnable pRunnable)
		{
			if (id_newThread_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_newThread_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;");

			global::Java.Lang.Thread __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod  (Handle, id_newThread_Ljava_lang_Runnable_, new JValue (pRunnable)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "newThread", "(Ljava/lang/Runnable;)Ljava/lang/Thread;"), new JValue (pRunnable)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
