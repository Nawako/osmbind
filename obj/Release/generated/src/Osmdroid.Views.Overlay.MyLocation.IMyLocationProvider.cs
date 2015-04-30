using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay.MyLocation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationProvider']"
	[Register ("org/osmdroid/views/overlay/mylocation/IMyLocationProvider", "", "Osmdroid.Views.Overlay.MyLocation.IMyLocationProviderInvoker")]
	public partial interface IMyLocationProvider : IJavaObject {

		global::Android.Locations.Location LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationProvider']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Landroid/location/Location;", "GetGetLastKnownLocationHandler:Osmdroid.Views.Overlay.MyLocation.IMyLocationProviderInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationProvider']/method[@name='startLocationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.mylocation.IMyLocationConsumer']]"
		[Register ("startLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationConsumer;)Z", "GetStartLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_Handler:Osmdroid.Views.Overlay.MyLocation.IMyLocationProviderInvoker, OsmdroidAndroidBinding")]
		bool StartLocationProvider (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer myLocationConsumer);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/interface[@name='IMyLocationProvider']/method[@name='stopLocationProvider' and count(parameter)=0]"
		[Register ("stopLocationProvider", "()V", "GetStopLocationProviderHandler:Osmdroid.Views.Overlay.MyLocation.IMyLocationProviderInvoker, OsmdroidAndroidBinding")]
		void StopLocationProvider ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/mylocation/IMyLocationProvider", DoNotGenerateAcw=true)]
	internal class IMyLocationProviderInvoker : global::Java.Lang.Object, IMyLocationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/mylocation/IMyLocationProvider");
		IntPtr class_ref;

		public static IMyLocationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMyLocationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.mylocation.IMyLocationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMyLocationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMyLocationProviderInvoker); }
		}

		static Delegate cb_getLastKnownLocation;
#pragma warning disable 0169
		static Delegate GetGetLastKnownLocationHandler ()
		{
			if (cb_getLastKnownLocation == null)
				cb_getLastKnownLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastKnownLocation);
			return cb_getLastKnownLocation;
		}

		static IntPtr n_GetLastKnownLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownLocation);
		}
#pragma warning restore 0169

		IntPtr id_getLastKnownLocation;
		public global::Android.Locations.Location LastKnownLocation {
			get {
				if (id_getLastKnownLocation == IntPtr.Zero)
					id_getLastKnownLocation = JNIEnv.GetMethodID (class_ref, "getLastKnownLocation", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (Handle, id_getLastKnownLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_;
#pragma warning disable 0169
		static Delegate GetStartLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_Handler ()
		{
			if (cb_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ == null)
				cb_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_);
			return cb_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_;
		}

		static bool n_StartLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_myLocationConsumer)
		{
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer myLocationConsumer = (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer> (native_myLocationConsumer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartLocationProvider (myLocationConsumer);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_;
		public bool StartLocationProvider (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer myLocationConsumer)
		{
			if (id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ == IntPtr.Zero)
				id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ = JNIEnv.GetMethodID (class_ref, "startLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationConsumer;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_, new JValue (myLocationConsumer));
			return __ret;
		}

		static Delegate cb_stopLocationProvider;
#pragma warning disable 0169
		static Delegate GetStopLocationProviderHandler ()
		{
			if (cb_stopLocationProvider == null)
				cb_stopLocationProvider = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocationProvider);
			return cb_stopLocationProvider;
		}

		static void n_StopLocationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocationProvider ();
		}
#pragma warning restore 0169

		IntPtr id_stopLocationProvider;
		public void StopLocationProvider ()
		{
			if (id_stopLocationProvider == IntPtr.Zero)
				id_stopLocationProvider = JNIEnv.GetMethodID (class_ref, "stopLocationProvider", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stopLocationProvider);
		}

	}

}
