using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay.MyLocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/mylocation/GpsMyLocationProvider", DoNotGenerateAcw=true)]
	public partial class GpsMyLocationProvider : global::Java.Lang.Object, global::Android.Locations.ILocationListener, global::Osmdroid.Views.Overlay.MyLocation.IMyLocationProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/mylocation/GpsMyLocationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GpsMyLocationProvider); }
		}

		protected GpsMyLocationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/constructor[@name='GpsMyLocationProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GpsMyLocationProvider (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GpsMyLocationProvider)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (context)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (context));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (context)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (context));
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
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getLastKnownLocation;
		public virtual global::Android.Locations.Location LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Landroid/location/Location;", "GetGetLastKnownLocationHandler")]
			get {
				if (id_getLastKnownLocation == IntPtr.Zero)
					id_getLastKnownLocation = JNIEnv.GetMethodID (class_ref, "getLastKnownLocation", "()Landroid/location/Location;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod  (Handle, id_getLastKnownLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastKnownLocation", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocationUpdateMinDistance;
#pragma warning disable 0169
		static Delegate GetGetLocationUpdateMinDistanceHandler ()
		{
			if (cb_getLocationUpdateMinDistance == null)
				cb_getLocationUpdateMinDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLocationUpdateMinDistance);
			return cb_getLocationUpdateMinDistance;
		}

		static float n_GetLocationUpdateMinDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationUpdateMinDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationUpdateMinDistance_F;
#pragma warning disable 0169
		static Delegate GetSetLocationUpdateMinDistance_FHandler ()
		{
			if (cb_setLocationUpdateMinDistance_F == null)
				cb_setLocationUpdateMinDistance_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLocationUpdateMinDistance_F);
			return cb_setLocationUpdateMinDistance_F;
		}

		static void n_SetLocationUpdateMinDistance_F (IntPtr jnienv, IntPtr native__this, float meters)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationUpdateMinDistance = meters;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationUpdateMinDistance;
		static IntPtr id_setLocationUpdateMinDistance_F;
		public virtual float LocationUpdateMinDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='getLocationUpdateMinDistance' and count(parameter)=0]"
			[Register ("getLocationUpdateMinDistance", "()F", "GetGetLocationUpdateMinDistanceHandler")]
			get {
				if (id_getLocationUpdateMinDistance == IntPtr.Zero)
					id_getLocationUpdateMinDistance = JNIEnv.GetMethodID (class_ref, "getLocationUpdateMinDistance", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLocationUpdateMinDistance);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationUpdateMinDistance", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='setLocationUpdateMinDistance' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLocationUpdateMinDistance", "(F)V", "GetSetLocationUpdateMinDistance_FHandler")]
			set {
				if (id_setLocationUpdateMinDistance_F == IntPtr.Zero)
					id_setLocationUpdateMinDistance_F = JNIEnv.GetMethodID (class_ref, "setLocationUpdateMinDistance", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationUpdateMinDistance_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationUpdateMinDistance", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getLocationUpdateMinTime;
#pragma warning disable 0169
		static Delegate GetGetLocationUpdateMinTimeHandler ()
		{
			if (cb_getLocationUpdateMinTime == null)
				cb_getLocationUpdateMinTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLocationUpdateMinTime);
			return cb_getLocationUpdateMinTime;
		}

		static long n_GetLocationUpdateMinTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocationUpdateMinTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLocationUpdateMinTime_J;
#pragma warning disable 0169
		static Delegate GetSetLocationUpdateMinTime_JHandler ()
		{
			if (cb_setLocationUpdateMinTime_J == null)
				cb_setLocationUpdateMinTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLocationUpdateMinTime_J);
			return cb_setLocationUpdateMinTime_J;
		}

		static void n_SetLocationUpdateMinTime_J (IntPtr jnienv, IntPtr native__this, long milliSeconds)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LocationUpdateMinTime = milliSeconds;
		}
#pragma warning restore 0169

		static IntPtr id_getLocationUpdateMinTime;
		static IntPtr id_setLocationUpdateMinTime_J;
		public virtual long LocationUpdateMinTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='getLocationUpdateMinTime' and count(parameter)=0]"
			[Register ("getLocationUpdateMinTime", "()J", "GetGetLocationUpdateMinTimeHandler")]
			get {
				if (id_getLocationUpdateMinTime == IntPtr.Zero)
					id_getLocationUpdateMinTime = JNIEnv.GetMethodID (class_ref, "getLocationUpdateMinTime", "()J");

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod  (Handle, id_getLocationUpdateMinTime);
				else
					return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocationUpdateMinTime", "()J"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='setLocationUpdateMinTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLocationUpdateMinTime", "(J)V", "GetSetLocationUpdateMinTime_JHandler")]
			set {
				if (id_setLocationUpdateMinTime_J == IntPtr.Zero)
					id_setLocationUpdateMinTime_J = JNIEnv.GetMethodID (class_ref, "setLocationUpdateMinTime", "(J)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocationUpdateMinTime_J, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocationUpdateMinTime", "(J)V"), new JValue (value));
			}
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (location);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual void OnLocationChanged (global::Android.Locations.Location location)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (location));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), new JValue (location));
		}

		static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderDisabled_Ljava_lang_String_ == null)
				cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
			return cb_onProviderDisabled_Ljava_lang_String_;
		}

		static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderDisabled (provider);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderDisabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='onProviderDisabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderDisabled (string provider)
		{
			if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderDisabled_Ljava_lang_String_, new JValue (native_provider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderDisabled", "(Ljava/lang/String;)V"), new JValue (native_provider));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderEnabled_Ljava_lang_String_ == null)
				cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
			return cb_onProviderEnabled_Ljava_lang_String_;
		}

		static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderEnabled (provider);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='onProviderEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderEnabled (string provider)
		{
			if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderEnabled_Ljava_lang_String_, new JValue (native_provider));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderEnabled", "(Ljava/lang/String;)V"), new JValue (native_provider));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider, int native_status, IntPtr native_extras)
		{
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability status = (global::Android.Locations.Availability) native_status;
			global::Android.OS.Bundle extras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_extras, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (provider, status, extras);
		}
#pragma warning restore 0169

		static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual void OnStatusChanged (string provider, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability status, global::Android.OS.Bundle extras)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_provider), new JValue ((int) status), new JValue (extras));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"), new JValue (native_provider), new JValue ((int) status), new JValue (extras));
			JNIEnv.DeleteLocalRef (native_provider);
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
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer myLocationConsumer = (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer> (native_myLocationConsumer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartLocationProvider (myLocationConsumer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='startLocationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.mylocation.IMyLocationConsumer']]"
		[Register ("startLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationConsumer;)Z", "GetStartLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_Handler")]
		public virtual bool StartLocationProvider (global::Osmdroid.Views.Overlay.MyLocation.IMyLocationConsumer myLocationConsumer)
		{
			if (id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ == IntPtr.Zero)
				id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_ = JNIEnv.GetMethodID (class_ref, "startLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationConsumer;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startLocationProvider_Lorg_osmdroid_views_overlay_mylocation_IMyLocationConsumer_, new JValue (myLocationConsumer));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startLocationProvider", "(Lorg/osmdroid/views/overlay/mylocation/IMyLocationConsumer;)Z"), new JValue (myLocationConsumer));
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
			global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocationProvider ();
		}
#pragma warning restore 0169

		static IntPtr id_stopLocationProvider;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.mylocation']/class[@name='GpsMyLocationProvider']/method[@name='stopLocationProvider' and count(parameter)=0]"
		[Register ("stopLocationProvider", "()V", "GetStopLocationProviderHandler")]
		public virtual void StopLocationProvider ()
		{
			if (id_stopLocationProvider == IntPtr.Zero)
				id_stopLocationProvider = JNIEnv.GetMethodID (class_ref, "stopLocationProvider", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopLocationProvider);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopLocationProvider", "()V"));
		}

	}
}
