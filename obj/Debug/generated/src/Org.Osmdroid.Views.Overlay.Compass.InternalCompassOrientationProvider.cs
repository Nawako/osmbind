using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Overlay.Compass {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/compass/InternalCompassOrientationProvider", DoNotGenerateAcw=true)]
	public partial class InternalCompassOrientationProvider : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener, global::Org.Osmdroid.Views.Overlay.Compass.IOrientationProvider {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/compass/InternalCompassOrientationProvider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InternalCompassOrientationProvider); }
		}

		protected InternalCompassOrientationProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/constructor[@name='InternalCompassOrientationProvider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public InternalCompassOrientationProvider (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InternalCompassOrientationProvider)) {
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

		static Delegate cb_getLastKnownOrientation;
#pragma warning disable 0169
		static Delegate GetGetLastKnownOrientationHandler ()
		{
			if (cb_getLastKnownOrientation == null)
				cb_getLastKnownOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLastKnownOrientation);
			return cb_getLastKnownOrientation;
		}

		static float n_GetLastKnownOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastKnownOrientation;
		}
#pragma warning restore 0169

		static IntPtr id_getLastKnownOrientation;
		public virtual float LastKnownOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/method[@name='getLastKnownOrientation' and count(parameter)=0]"
			[Register ("getLastKnownOrientation", "()F", "GetGetLastKnownOrientationHandler")]
			get {
				if (id_getLastKnownOrientation == IntPtr.Zero)
					id_getLastKnownOrientation = JNIEnv.GetMethodID (class_ref, "getLastKnownOrientation", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getLastKnownOrientation);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastKnownOrientation", "()F"));
			}
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sensor, int native_accuracy)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor sensor = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_sensor, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus accuracy = (global::Android.Hardware.SensorStatus) native_accuracy;
			__this.OnAccuracyChanged (sensor, accuracy);
		}
#pragma warning restore 0169

		static IntPtr id_onAccuracyChanged_Landroid_hardware_Sensor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual void OnAccuracyChanged (global::Android.Hardware.Sensor sensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus accuracy)
		{
			if (id_onAccuracyChanged_Landroid_hardware_Sensor_I == IntPtr.Zero)
				id_onAccuracyChanged_Landroid_hardware_Sensor_I = JNIEnv.GetMethodID (class_ref, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAccuracyChanged_Landroid_hardware_Sensor_I, new JValue (sensor), new JValue ((int) accuracy));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V"), new JValue (sensor), new JValue ((int) accuracy));
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent e = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (e);
		}
#pragma warning restore 0169

		static IntPtr id_onSensorChanged_Landroid_hardware_SensorEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual void OnSensorChanged (global::Android.Hardware.SensorEvent e)
		{
			if (id_onSensorChanged_Landroid_hardware_SensorEvent_ == IntPtr.Zero)
				id_onSensorChanged_Landroid_hardware_SensorEvent_ = JNIEnv.GetMethodID (class_ref, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSensorChanged_Landroid_hardware_SensorEvent_, new JValue (e));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V"), new JValue (e));
		}

		static Delegate cb_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_;
#pragma warning disable 0169
		static Delegate GetStartOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_Handler ()
		{
			if (cb_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ == null)
				cb_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_);
			return cb_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_;
		}

		static bool n_StartOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_orientationConsumer)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer orientationConsumer = (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer)global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer> (native_orientationConsumer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartOrientationProvider (orientationConsumer);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/method[@name='startOrientationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.compass.IOrientationConsumer']]"
		[Register ("startOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationConsumer;)Z", "GetStartOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_Handler")]
		public virtual bool StartOrientationProvider (global::Org.Osmdroid.Views.Overlay.Compass.IOrientationConsumer orientationConsumer)
		{
			if (id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ == IntPtr.Zero)
				id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ = JNIEnv.GetMethodID (class_ref, "startOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationConsumer;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_, new JValue (orientationConsumer));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationConsumer;)Z"), new JValue (orientationConsumer));
			return __ret;
		}

		static Delegate cb_stopOrientationProvider;
#pragma warning disable 0169
		static Delegate GetStopOrientationProviderHandler ()
		{
			if (cb_stopOrientationProvider == null)
				cb_stopOrientationProvider = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopOrientationProvider);
			return cb_stopOrientationProvider;
		}

		static void n_StopOrientationProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopOrientationProvider ();
		}
#pragma warning restore 0169

		static IntPtr id_stopOrientationProvider;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/class[@name='InternalCompassOrientationProvider']/method[@name='stopOrientationProvider' and count(parameter)=0]"
		[Register ("stopOrientationProvider", "()V", "GetStopOrientationProviderHandler")]
		public virtual void StopOrientationProvider ()
		{
			if (id_stopOrientationProvider == IntPtr.Zero)
				id_stopOrientationProvider = JNIEnv.GetMethodID (class_ref, "stopOrientationProvider", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopOrientationProvider);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopOrientationProvider", "()V"));
		}

	}
}
