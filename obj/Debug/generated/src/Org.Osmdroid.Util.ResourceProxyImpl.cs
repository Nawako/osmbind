using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='ResourceProxyImpl']"
	[global::Android.Runtime.Register ("org/osmdroid/util/ResourceProxyImpl", DoNotGenerateAcw=true)]
	public partial class ResourceProxyImpl : global::Osmdroid.DefaultResourceProxyImpl {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/ResourceProxyImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceProxyImpl); }
		}

		protected ResourceProxyImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='ResourceProxyImpl']/constructor[@name='ResourceProxyImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ResourceProxyImpl (global::Android.Content.Context aContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ResourceProxyImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (aContext)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (aContext));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (aContext)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (aContext));
		}

	}
}
