using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='DefaultInfoWindow']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/DefaultInfoWindow", DoNotGenerateAcw=true)]
	public partial class DefaultInfoWindow : global::Osmdroid.Bonuspack.Overlays.InfoWindow {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/DefaultInfoWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultInfoWindow); }
		}

		protected DefaultInfoWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='DefaultInfoWindow']/constructor[@name='DefaultInfoWindow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(ILorg/osmdroid/views/MapView;)V", "")]
		public DefaultInfoWindow (int p0, global::Osmdroid.Views.MapView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultInfoWindow)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onClose;
#pragma warning disable 0169
		static Delegate GetOnCloseHandler ()
		{
			if (cb_onClose == null)
				cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
			return cb_onClose;
		}

		static void n_OnClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.DefaultInfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.DefaultInfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClose ();
		}
#pragma warning restore 0169

		static IntPtr id_onClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='DefaultInfoWindow']/method[@name='onClose' and count(parameter)=0]"
		[Register ("onClose", "()V", "GetOnCloseHandler")]
		public override void OnClose ()
		{
			if (id_onClose == IntPtr.Zero)
				id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onClose);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClose", "()V"));
		}

		static Delegate cb_onOpen_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Ljava_lang_Object_Handler ()
		{
			if (cb_onOpen_Ljava_lang_Object_ == null)
				cb_onOpen_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Ljava_lang_Object_);
			return cb_onOpen_Ljava_lang_Object_;
		}

		static void n_OnOpen_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.DefaultInfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.DefaultInfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onOpen_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='DefaultInfoWindow']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onOpen", "(Ljava/lang/Object;)V", "GetOnOpen_Ljava_lang_Object_Handler")]
		public override void OnOpen (global::Java.Lang.Object p0)
		{
			if (id_onOpen_Ljava_lang_Object_ == IntPtr.Zero)
				id_onOpen_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Ljava/lang/Object;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onOpen_Ljava_lang_Object_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOpen", "(Ljava/lang/Object;)V"), new JValue (p0));
		}

	}
}
