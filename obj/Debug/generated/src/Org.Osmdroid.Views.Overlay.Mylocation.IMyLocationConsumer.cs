using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Overlay.Mylocation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationConsumer']"
	[Register ("org/osmdroid/views/overlay/mylocation/IMyLocationConsumer", "", "Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationConsumerInvoker")]
	public partial interface IMyLocationConsumer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationConsumer']/method[@name='onLocationChanged' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='org.osmdroid.views.overlay.mylocation.IMyLocationProvider']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V", "GetOnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler:Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationConsumerInvoker, OsmdroidAndroidBinding")]
		void OnLocationChanged (global::Android.Locations.Location location, global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationProvider source);

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/mylocation/IMyLocationConsumer", DoNotGenerateAcw=true)]
	internal class IMyLocationConsumerInvoker : global::Java.Lang.Object, IMyLocationConsumer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/mylocation/IMyLocationConsumer");
		IntPtr class_ref;

		public static IMyLocationConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMyLocationConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.mylocation.IMyLocationConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMyLocationConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMyLocationConsumerInvoker); }
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == null)
				cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_);
			return cb_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location, IntPtr native_source)
		{
			global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationConsumer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationProvider source = (global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationProvider)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationProvider> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (location, source);
		}
#pragma warning restore 0169

		IntPtr id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_;
		public void OnLocationChanged (global::Android.Locations.Location location, global::Org.Osmdroid.Views.Overlay.Mylocation.IMyLocationProvider source)
		{
			if (id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;Lorg/osmdroid/views/overlay/mylocation/IMyLocationProvider;)V");
			JNIEnv.CallVoidMethod (Handle, id_onLocationChanged_Landroid_location_Location_Lorg_osmdroid_views_overlay_mylocation_IMyLocationProvider_, new JValue (location), new JValue (source));
		}

	}

}
