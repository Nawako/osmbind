using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']"
	[Register ("org/osmdroid/api/IMyLocationOverlay", "", "Osmdroid.Api.IMyLocationOverlayInvoker")]
	public partial interface IMyLocationOverlay : IJavaObject {

		bool IsCompassEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='isCompassEnabled' and count(parameter)=0]"
			[Register ("isCompassEnabled", "()Z", "GetIsCompassEnabledHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")] get;
		}

		bool IsMyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")] get;
		}

		global::Android.Locations.Location LastFix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='getLastFix' and count(parameter)=0]"
			[Register ("getLastFix", "()Landroid/location/Location;", "GetGetLastFixHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")] get;
		}

		float Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()F", "GetGetOrientationHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='disableCompass' and count(parameter)=0]"
		[Register ("disableCompass", "()V", "GetDisableCompassHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		void DisableCompass ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='disableMyLocation' and count(parameter)=0]"
		[Register ("disableMyLocation", "()V", "GetDisableMyLocationHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		void DisableMyLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='enableCompass' and count(parameter)=0]"
		[Register ("enableCompass", "()Z", "GetEnableCompassHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		bool EnableCompass ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='enableMyLocation' and count(parameter)=0]"
		[Register ("enableMyLocation", "()Z", "GetEnableMyLocationHandler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		bool EnableMyLocation ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='onStatusChanged' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V", "GetOnStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_Handler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		void OnStatusChanged (string provider, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability status, global::Android.OS.Bundle extras);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMyLocationOverlay']/method[@name='runOnFirstFix' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnFirstFix", "(Ljava/lang/Runnable;)Z", "GetRunOnFirstFix_Ljava_lang_Runnable_Handler:Osmdroid.Api.IMyLocationOverlayInvoker, OsmdroidAndroidBinding")]
		bool RunOnFirstFix (global::Java.Lang.IRunnable runnable);

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IMyLocationOverlay", DoNotGenerateAcw=true)]
	internal class IMyLocationOverlayInvoker : global::Java.Lang.Object, IMyLocationOverlay {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IMyLocationOverlay");
		IntPtr class_ref;

		public static IMyLocationOverlay GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMyLocationOverlay> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IMyLocationOverlay"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMyLocationOverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMyLocationOverlayInvoker); }
		}

		static Delegate cb_isCompassEnabled;
#pragma warning disable 0169
		static Delegate GetIsCompassEnabledHandler ()
		{
			if (cb_isCompassEnabled == null)
				cb_isCompassEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCompassEnabled);
			return cb_isCompassEnabled;
		}

		static bool n_IsCompassEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCompassEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isCompassEnabled;
		public bool IsCompassEnabled {
			get {
				if (id_isCompassEnabled == IntPtr.Zero)
					id_isCompassEnabled = JNIEnv.GetMethodID (class_ref, "isCompassEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isCompassEnabled);
			}
		}

		static Delegate cb_isMyLocationEnabled;
#pragma warning disable 0169
		static Delegate GetIsMyLocationEnabledHandler ()
		{
			if (cb_isMyLocationEnabled == null)
				cb_isMyLocationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMyLocationEnabled);
			return cb_isMyLocationEnabled;
		}

		static bool n_IsMyLocationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMyLocationEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isMyLocationEnabled;
		public bool IsMyLocationEnabled {
			get {
				if (id_isMyLocationEnabled == IntPtr.Zero)
					id_isMyLocationEnabled = JNIEnv.GetMethodID (class_ref, "isMyLocationEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_isMyLocationEnabled);
			}
		}

		static Delegate cb_getLastFix;
#pragma warning disable 0169
		static Delegate GetGetLastFixHandler ()
		{
			if (cb_getLastFix == null)
				cb_getLastFix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastFix);
			return cb_getLastFix;
		}

		static IntPtr n_GetLastFix (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastFix);
		}
#pragma warning restore 0169

		IntPtr id_getLastFix;
		public global::Android.Locations.Location LastFix {
			get {
				if (id_getLastFix == IntPtr.Zero)
					id_getLastFix = JNIEnv.GetMethodID (class_ref, "getLastFix", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (Handle, id_getLastFix), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOrientation);
			return cb_getOrientation;
		}

		static float n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Orientation;
		}
#pragma warning restore 0169

		IntPtr id_getOrientation;
		public float Orientation {
			get {
				if (id_getOrientation == IntPtr.Zero)
					id_getOrientation = JNIEnv.GetMethodID (class_ref, "getOrientation", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getOrientation);
			}
		}

		static Delegate cb_disableCompass;
#pragma warning disable 0169
		static Delegate GetDisableCompassHandler ()
		{
			if (cb_disableCompass == null)
				cb_disableCompass = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableCompass);
			return cb_disableCompass;
		}

		static void n_DisableCompass (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableCompass ();
		}
#pragma warning restore 0169

		IntPtr id_disableCompass;
		public void DisableCompass ()
		{
			if (id_disableCompass == IntPtr.Zero)
				id_disableCompass = JNIEnv.GetMethodID (class_ref, "disableCompass", "()V");
			JNIEnv.CallVoidMethod (Handle, id_disableCompass);
		}

		static Delegate cb_disableMyLocation;
#pragma warning disable 0169
		static Delegate GetDisableMyLocationHandler ()
		{
			if (cb_disableMyLocation == null)
				cb_disableMyLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableMyLocation);
			return cb_disableMyLocation;
		}

		static void n_DisableMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableMyLocation ();
		}
#pragma warning restore 0169

		IntPtr id_disableMyLocation;
		public void DisableMyLocation ()
		{
			if (id_disableMyLocation == IntPtr.Zero)
				id_disableMyLocation = JNIEnv.GetMethodID (class_ref, "disableMyLocation", "()V");
			JNIEnv.CallVoidMethod (Handle, id_disableMyLocation);
		}

		static Delegate cb_enableCompass;
#pragma warning disable 0169
		static Delegate GetEnableCompassHandler ()
		{
			if (cb_enableCompass == null)
				cb_enableCompass = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableCompass);
			return cb_enableCompass;
		}

		static bool n_EnableCompass (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCompass ();
		}
#pragma warning restore 0169

		IntPtr id_enableCompass;
		public bool EnableCompass ()
		{
			if (id_enableCompass == IntPtr.Zero)
				id_enableCompass = JNIEnv.GetMethodID (class_ref, "enableCompass", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_enableCompass);
		}

		static Delegate cb_enableMyLocation;
#pragma warning disable 0169
		static Delegate GetEnableMyLocationHandler ()
		{
			if (cb_enableMyLocation == null)
				cb_enableMyLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableMyLocation);
			return cb_enableMyLocation;
		}

		static bool n_EnableMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableMyLocation ();
		}
#pragma warning restore 0169

		IntPtr id_enableMyLocation;
		public bool EnableMyLocation ()
		{
			if (id_enableMyLocation == IntPtr.Zero)
				id_enableMyLocation = JNIEnv.GetMethodID (class_ref, "enableMyLocation", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_enableMyLocation);
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
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string provider = JNIEnv.GetString (native_provider, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Availability status = (global::Android.Locations.Availability) native_status;
			global::Android.OS.Bundle extras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_extras, JniHandleOwnership.DoNotTransfer);
			__this.OnStatusChanged (provider, status, extras);
		}
#pragma warning restore 0169

		IntPtr id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_;
		public void OnStatusChanged (string provider, [global::Android.Runtime.GeneratedEnum] global::Android.Locations.Availability status, global::Android.OS.Bundle extras)
		{
			if (id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onStatusChanged", "(Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_provider = JNIEnv.NewString (provider);
			JNIEnv.CallVoidMethod (Handle, id_onStatusChanged_Ljava_lang_String_ILandroid_os_Bundle_, new JValue (native_provider), new JValue ((int) status), new JValue (extras));
			JNIEnv.DeleteLocalRef (native_provider);
		}

		static Delegate cb_runOnFirstFix_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnFirstFix_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnFirstFix_Ljava_lang_Runnable_ == null)
				cb_runOnFirstFix_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RunOnFirstFix_Ljava_lang_Runnable_);
			return cb_runOnFirstFix_Ljava_lang_Runnable_;
		}

		static bool n_RunOnFirstFix_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::Osmdroid.Api.IMyLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMyLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RunOnFirstFix (runnable);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_runOnFirstFix_Ljava_lang_Runnable_;
		public bool RunOnFirstFix (global::Java.Lang.IRunnable runnable)
		{
			if (id_runOnFirstFix_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnFirstFix_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnFirstFix", "(Ljava/lang/Runnable;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_runOnFirstFix_Ljava_lang_Runnable_, new JValue (runnable));
			return __ret;
		}

	}

}
