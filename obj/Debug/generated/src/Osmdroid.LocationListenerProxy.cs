using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']"
	[global::Android.Runtime.Register ("org/osmdroid/LocationListenerProxy", DoNotGenerateAcw=true)]
	public partial class LocationListenerProxy : global::Java.Lang.Object, global::Android.Locations.ILocationListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/LocationListenerProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationListenerProxy); }
		}

		protected LocationListenerProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_location_LocationManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/constructor[@name='LocationListenerProxy' and count(parameter)=1 and parameter[1][@type='android.location.LocationManager']]"
		[Register (".ctor", "(Landroid/location/LocationManager;)V", "")]
		public LocationListenerProxy (global::Android.Locations.LocationManager pLocationManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LocationListenerProxy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/location/LocationManager;)V", new JValue (pLocationManager)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/location/LocationManager;)V", new JValue (pLocationManager));
				return;
			}

			if (id_ctor_Landroid_location_LocationManager_ == IntPtr.Zero)
				id_ctor_Landroid_location_LocationManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/location/LocationManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_location_LocationManager_, new JValue (pLocationManager)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_location_LocationManager_, new JValue (pLocationManager));
		}

		static Delegate cb_onLocationChanged_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetOnLocationChanged_Landroid_location_Location_Handler ()
		{
			if (cb_onLocationChanged_Landroid_location_Location_ == null)
				cb_onLocationChanged_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLocationChanged_Landroid_location_Location_);
			return cb_onLocationChanged_Landroid_location_Location_;
		}

		static void n_OnLocationChanged_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location arg0 = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.OnLocationChanged (arg0);
		}
#pragma warning restore 0169

		static IntPtr id_onLocationChanged_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='onLocationChanged' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("onLocationChanged", "(Landroid/location/Location;)V", "GetOnLocationChanged_Landroid_location_Location_Handler")]
		public virtual void OnLocationChanged (global::Android.Locations.Location arg0)
		{
			if (id_onLocationChanged_Landroid_location_Location_ == IntPtr.Zero)
				id_onLocationChanged_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "onLocationChanged", "(Landroid/location/Location;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLocationChanged_Landroid_location_Location_, new JValue (arg0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLocationChanged", "(Landroid/location/Location;)V"), new JValue (arg0));
		}

		static Delegate cb_onProviderDisabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderDisabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderDisabled_Ljava_lang_String_ == null)
				cb_onProviderDisabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderDisabled_Ljava_lang_String_);
			return cb_onProviderDisabled_Ljava_lang_String_;
		}

		static void n_OnProviderDisabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string arg0 = JNIEnv.GetString (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderDisabled (arg0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderDisabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='onProviderDisabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderDisabled", "(Ljava/lang/String;)V", "GetOnProviderDisabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderDisabled (string arg0)
		{
			if (id_onProviderDisabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderDisabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderDisabled", "(Ljava/lang/String;)V");
			IntPtr native_arg0 = JNIEnv.NewString (arg0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderDisabled_Ljava_lang_String_, new JValue (native_arg0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderDisabled", "(Ljava/lang/String;)V"), new JValue (native_arg0));
			JNIEnv.DeleteLocalRef (native_arg0);
		}

		static Delegate cb_onProviderEnabled_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnProviderEnabled_Ljava_lang_String_Handler ()
		{
			if (cb_onProviderEnabled_Ljava_lang_String_ == null)
				cb_onProviderEnabled_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnProviderEnabled_Ljava_lang_String_);
			return cb_onProviderEnabled_Ljava_lang_String_;
		}

		static void n_OnProviderEnabled_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string arg0 = JNIEnv.GetString (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.OnProviderEnabled (arg0);
		}
#pragma warning restore 0169

		static IntPtr id_onProviderEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='onProviderEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onProviderEnabled", "(Ljava/lang/String;)V", "GetOnProviderEnabled_Ljava_lang_String_Handler")]
		public virtual void OnProviderEnabled (string arg0)
		{
			if (id_onProviderEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_onProviderEnabled_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onProviderEnabled", "(Ljava/lang/String;)V");
			IntPtr native_arg0 = JNIEnv.NewString (arg0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onProviderEnabled_Ljava_lang_String_, new JValue (native_arg0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onProviderEnabled", "(Ljava/lang/String;)V"), new JValue (native_arg0));
			JNIEnv.DeleteLocalRef (native_arg0);
		}

		static Delegate cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_OnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0, int native_arg1, IntPtr native_arg2)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string arg0 = JNIEnv.GetString (native_arg0, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability arg1 = (global::Android.Locations.Availability) native_arg1;
			global::Android.OS.Bundle arg2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (arg0, arg1, arg2);
		}
#pragma warning restore 0169

		static IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual void OnStatusChanged (string arg0, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability arg1, global::Android.OS.Bundle arg2)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_arg0 = JNIEnv.NewString (arg0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_arg0), new JValue ((int) arg1), new JValue (arg2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V"), new JValue (native_arg0), new JValue ((int) arg1), new JValue (arg2));
			JNIEnv.DeleteLocalRef (native_arg0);
		}

		static Delegate cb_startListening_Landroid_location_LocationListener_JF;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_location_LocationListener_JFHandler ()
		{
			if (cb_startListening_Landroid_location_LocationListener_JF == null)
				cb_startListening_Landroid_location_LocationListener_JF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, float, bool>) n_StartListening_Landroid_location_LocationListener_JF);
			return cb_startListening_Landroid_location_LocationListener_JF;
		}

		static bool n_StartListening_Landroid_location_LocationListener_JF (IntPtr jnienv, IntPtr native__this, IntPtr native_pListener, long pUpdateTime, float pUpdateDistance)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.ILocationListener pListener = (global::Android.Locations.ILocationListener)global::Java.Lang.Object.GetObject<global::Android.Locations.ILocationListener> (native_pListener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartListening (pListener, pUpdateTime, pUpdateDistance);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startListening_Landroid_location_LocationListener_JF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='startListening' and count(parameter)=3 and parameter[1][@type='android.location.LocationListener'] and parameter[2][@type='long'] and parameter[3][@type='float']]"
		[Register ("startListening", "(Landroid/location/LocationListener;JF)Z", "GetStartListening_Landroid_location_LocationListener_JFHandler")]
		public virtual bool StartListening (global::Android.Locations.ILocationListener pListener, long pUpdateTime, float pUpdateDistance)
		{
			if (id_startListening_Landroid_location_LocationListener_JF == IntPtr.Zero)
				id_startListening_Landroid_location_LocationListener_JF = JNIEnv.GetMethodID (class_ref, "startListening", "(Landroid/location/LocationListener;JF)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startListening_Landroid_location_LocationListener_JF, new JValue (pListener), new JValue (pUpdateTime), new JValue (pUpdateDistance));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startListening", "(Landroid/location/LocationListener;JF)Z"), new JValue (pListener), new JValue (pUpdateTime), new JValue (pUpdateDistance));
			return __ret;
		}

		static Delegate cb_stopListening;
#pragma warning disable 0169
		static Delegate GetStopListeningHandler ()
		{
			if (cb_stopListening == null)
				cb_stopListening = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopListening);
			return cb_stopListening;
		}

		static void n_StopListening (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.LocationListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.LocationListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopListening ();
		}
#pragma warning restore 0169

		static IntPtr id_stopListening;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='LocationListenerProxy']/method[@name='stopListening' and count(parameter)=0]"
		[Register ("stopListening", "()V", "GetStopListeningHandler")]
		public virtual void StopListening ()
		{
			if (id_stopListening == IntPtr.Zero)
				id_stopListening = JNIEnv.GetMethodID (class_ref, "stopListening", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopListening);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopListening", "()V"));
		}

	}
}
