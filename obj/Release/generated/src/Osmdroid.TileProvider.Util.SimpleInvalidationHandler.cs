using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleInvalidationHandler']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/util/SimpleInvalidationHandler", DoNotGenerateAcw=true)]
	public partial class SimpleInvalidationHandler : global::Android.OS.Handler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/util/SimpleInvalidationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleInvalidationHandler); }
		}

		protected SimpleInvalidationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_view_View_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.util']/class[@name='SimpleInvalidationHandler']/constructor[@name='SimpleInvalidationHandler' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/view/View;)V", "")]
		public SimpleInvalidationHandler (global::Android.Views.View pView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleInvalidationHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/View;)V", new JValue (pView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/View;)V", new JValue (pView));
				return;
			}

			if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
				id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, new JValue (pView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_View_, new JValue (pView));
		}

	}
}
