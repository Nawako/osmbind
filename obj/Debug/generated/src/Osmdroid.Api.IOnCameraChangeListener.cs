using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='OnCameraChangeListener']"
	[Register ("org/osmdroid/api/OnCameraChangeListener", "", "Osmdroid.Api.IOnCameraChangeListenerInvoker")]
	public partial interface IOnCameraChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='OnCameraChangeListener']/method[@name='onCameraChange' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IPosition']]"
		[Register ("onCameraChange", "(Lorg/osmdroid/api/IPosition;)V", "GetOnCameraChange_Lorg_osmdroid_api_IPosition_Handler:Osmdroid.Api.IOnCameraChangeListenerInvoker, OsmdroidAndroidBinding")]
		void OnCameraChange (global::Osmdroid.Api.IPosition position);

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/OnCameraChangeListener", DoNotGenerateAcw=true)]
	internal class IOnCameraChangeListenerInvoker : global::Java.Lang.Object, IOnCameraChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/OnCameraChangeListener");
		IntPtr class_ref;

		public static IOnCameraChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCameraChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.OnCameraChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCameraChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOnCameraChangeListenerInvoker); }
		}

		static Delegate cb_onCameraChange_Lorg_osmdroid_api_IPosition_;
#pragma warning disable 0169
		static Delegate GetOnCameraChange_Lorg_osmdroid_api_IPosition_Handler ()
		{
			if (cb_onCameraChange_Lorg_osmdroid_api_IPosition_ == null)
				cb_onCameraChange_Lorg_osmdroid_api_IPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCameraChange_Lorg_osmdroid_api_IPosition_);
			return cb_onCameraChange_Lorg_osmdroid_api_IPosition_;
		}

		static void n_OnCameraChange_Lorg_osmdroid_api_IPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_position)
		{
			global::Osmdroid.Api.IOnCameraChangeListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IOnCameraChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IPosition position = (global::Osmdroid.Api.IPosition)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IPosition> (native_position, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraChange (position);
		}
#pragma warning restore 0169

		IntPtr id_onCameraChange_Lorg_osmdroid_api_IPosition_;
		public void OnCameraChange (global::Osmdroid.Api.IPosition position)
		{
			if (id_onCameraChange_Lorg_osmdroid_api_IPosition_ == IntPtr.Zero)
				id_onCameraChange_Lorg_osmdroid_api_IPosition_ = JNIEnv.GetMethodID (class_ref, "onCameraChange", "(Lorg/osmdroid/api/IPosition;)V");
			JNIEnv.CallVoidMethod (Handle, id_onCameraChange_Lorg_osmdroid_api_IPosition_, new JValue (position));
		}

	}

	public partial class CameraChangeEventArgs : global::System.EventArgs {

		public CameraChangeEventArgs (global::Osmdroid.Api.IPosition position)
		{
			this.position = position;
		}

		global::Osmdroid.Api.IPosition position;
		public global::Osmdroid.Api.IPosition Position {
			get { return position; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/osmdroid/api/OnCameraChangeListenerImplementor")]
	internal sealed class IOnCameraChangeListenerImplementor : global::Java.Lang.Object, IOnCameraChangeListener {

		object sender;

		public IOnCameraChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/api/OnCameraChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CameraChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnCameraChange (global::Osmdroid.Api.IPosition position)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CameraChangeEventArgs (position));
		}

		internal static bool __IsEmpty (IOnCameraChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
