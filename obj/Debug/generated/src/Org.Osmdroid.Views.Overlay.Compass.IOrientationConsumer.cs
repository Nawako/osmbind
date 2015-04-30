using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Overlay.Compass {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationConsumer']"
	[Register ("org/osmdroid/views/overlay/compass/IOrientationConsumer", "", "Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumerInvoker")]
	public partial interface IOrientationConsumer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationConsumer']/method[@name='onOrientationChanged' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='org.osmdroid.views.overlay.compass.IOrientationProvider']]"
		[Register ("onOrientationChanged", "(FLorg/osmdroid/views/overlay/compass/IOrientationProvider;)V", "GetOnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler:Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumerInvoker, OsmdroidAndroidBinding")]
		void OnOrientationChanged (float orientation, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider source);

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/compass/IOrientationConsumer", DoNotGenerateAcw=true)]
	internal class IOrientationConsumerInvoker : global::Java.Lang.Object, IOrientationConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/compass/IOrientationConsumer");
		IntPtr class_ref;

		public static IOrientationConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOrientationConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.compass.IOrientationConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOrientationConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOrientationConsumerInvoker); }
		}

		static Delegate cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
#pragma warning disable 0169
		static Delegate GetOnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_Handler ()
		{
			if (cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ == null)
				cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_OnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_);
			return cb_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		}

		static void n_OnOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ (IntPtr jnienv, IntPtr native__this, float orientation, IntPtr native_source)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider source = (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.OnOrientationChanged (orientation, source);
		}
#pragma warning restore 0169

		IntPtr id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_;
		public void OnOrientationChanged (float orientation, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider source)
		{
			if (id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ == IntPtr.Zero)
				id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_ = JNIEnv.GetMethodID (class_ref, "onOrientationChanged", "(FLorg/osmdroid/views/overlay/compass/IOrientationProvider;)V");
			JNIEnv.CallVoidMethod (Handle, id_onOrientationChanged_FLorg_osmdroid_views_overlay_compass_IOrientationProvider_, new JValue (orientation), new JValue (source));
		}

	}

}
