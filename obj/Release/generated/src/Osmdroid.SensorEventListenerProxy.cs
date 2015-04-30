using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']"
	[global::Android.Runtime.Register ("org/osmdroid/SensorEventListenerProxy", DoNotGenerateAcw=true)]
	public partial class SensorEventListenerProxy : global::Java.Lang.Object, global::Android.Hardware.ISensorEventListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/SensorEventListenerProxy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SensorEventListenerProxy); }
		}

		protected SensorEventListenerProxy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_hardware_SensorManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']/constructor[@name='SensorEventListenerProxy' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorManager']]"
		[Register (".ctor", "(Landroid/hardware/SensorManager;)V", "")]
		public SensorEventListenerProxy (global::Android.Hardware.SensorManager pSensorManager) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SensorEventListenerProxy)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/hardware/SensorManager;)V", new JValue (pSensorManager)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/hardware/SensorManager;)V", new JValue (pSensorManager));
				return;
			}

			if (id_ctor_Landroid_hardware_SensorManager_ == IntPtr.Zero)
				id_ctor_Landroid_hardware_SensorManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/hardware/SensorManager;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_hardware_SensorManager_, new JValue (pSensorManager)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_hardware_SensorManager_, new JValue (pSensorManager));
		}

		static Delegate cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
#pragma warning disable 0169
		static Delegate GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler ()
		{
			if (cb_onAccuracyChanged_Landroid_hardware_Sensor_I == null)
				cb_onAccuracyChanged_Landroid_hardware_Sensor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnAccuracyChanged_Landroid_hardware_Sensor_I);
			return cb_onAccuracyChanged_Landroid_hardware_Sensor_I;
		}

		static void n_OnAccuracyChanged_Landroid_hardware_Sensor_I (IntPtr jnienv, IntPtr native__this, IntPtr native_pSensor, int native_pAccuracy)
		{
			global::Osmdroid.SensorEventListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.SensorEventListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Sensor pSensor = global::Java.Lang.Object.GetObject<global::Android.Hardware.Sensor> (native_pSensor, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorStatus pAccuracy = (global::Android.Hardware.SensorStatus) native_pAccuracy;
			__this.OnAccuracyChanged (pSensor, pAccuracy);
		}
#pragma warning restore 0169

		static IntPtr id_onAccuracyChanged_Landroid_hardware_Sensor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']/method[@name='onAccuracyChanged' and count(parameter)=2 and parameter[1][@type='android.hardware.Sensor'] and parameter[2][@type='int']]"
		[Register ("onAccuracyChanged", "(Landroid/hardware/Sensor;I)V", "GetOnAccuracyChanged_Landroid_hardware_Sensor_IHandler")]
		public virtual void OnAccuracyChanged (global::Android.Hardware.Sensor pSensor, [global::Android.Runtime.GeneratedEnum] global::Android.Hardware.SensorStatus pAccuracy)
		{
			if (id_onAccuracyChanged_Landroid_hardware_Sensor_I == IntPtr.Zero)
				id_onAccuracyChanged_Landroid_hardware_Sensor_I = JNIEnv.GetMethodID (class_ref, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAccuracyChanged_Landroid_hardware_Sensor_I, new JValue (pSensor), new JValue ((int) pAccuracy));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAccuracyChanged", "(Landroid/hardware/Sensor;I)V"), new JValue (pSensor), new JValue ((int) pAccuracy));
		}

		static Delegate cb_onSensorChanged_Landroid_hardware_SensorEvent_;
#pragma warning disable 0169
		static Delegate GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler ()
		{
			if (cb_onSensorChanged_Landroid_hardware_SensorEvent_ == null)
				cb_onSensorChanged_Landroid_hardware_SensorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSensorChanged_Landroid_hardware_SensorEvent_);
			return cb_onSensorChanged_Landroid_hardware_SensorEvent_;
		}

		static void n_OnSensorChanged_Landroid_hardware_SensorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pEvent)
		{
			global::Osmdroid.SensorEventListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.SensorEventListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.SensorEvent pEvent = global::Java.Lang.Object.GetObject<global::Android.Hardware.SensorEvent> (native_pEvent, JniHandleOwnership.DoNotTransfer);
			__this.OnSensorChanged (pEvent);
		}
#pragma warning restore 0169

		static IntPtr id_onSensorChanged_Landroid_hardware_SensorEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']/method[@name='onSensorChanged' and count(parameter)=1 and parameter[1][@type='android.hardware.SensorEvent']]"
		[Register ("onSensorChanged", "(Landroid/hardware/SensorEvent;)V", "GetOnSensorChanged_Landroid_hardware_SensorEvent_Handler")]
		public virtual void OnSensorChanged (global::Android.Hardware.SensorEvent pEvent)
		{
			if (id_onSensorChanged_Landroid_hardware_SensorEvent_ == IntPtr.Zero)
				id_onSensorChanged_Landroid_hardware_SensorEvent_ = JNIEnv.GetMethodID (class_ref, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onSensorChanged_Landroid_hardware_SensorEvent_, new JValue (pEvent));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSensorChanged", "(Landroid/hardware/SensorEvent;)V"), new JValue (pEvent));
		}

		static Delegate cb_startListening_Landroid_hardware_SensorEventListener_II;
#pragma warning disable 0169
		static Delegate GetStartListening_Landroid_hardware_SensorEventListener_IIHandler ()
		{
			if (cb_startListening_Landroid_hardware_SensorEventListener_II == null)
				cb_startListening_Landroid_hardware_SensorEventListener_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool>) n_StartListening_Landroid_hardware_SensorEventListener_II);
			return cb_startListening_Landroid_hardware_SensorEventListener_II;
		}

		static bool n_StartListening_Landroid_hardware_SensorEventListener_II (IntPtr jnienv, IntPtr native__this, IntPtr native_pListener, int pSensorType, int pRate)
		{
			global::Osmdroid.SensorEventListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.SensorEventListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.ISensorEventListener pListener = (global::Android.Hardware.ISensorEventListener)global::Java.Lang.Object.GetObject<global::Android.Hardware.ISensorEventListener> (native_pListener, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartListening (pListener, pSensorType, pRate);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_startListening_Landroid_hardware_SensorEventListener_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']/method[@name='startListening' and count(parameter)=3 and parameter[1][@type='android.hardware.SensorEventListener'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("startListening", "(Landroid/hardware/SensorEventListener;II)Z", "GetStartListening_Landroid_hardware_SensorEventListener_IIHandler")]
		public virtual bool StartListening (global::Android.Hardware.ISensorEventListener pListener, int pSensorType, int pRate)
		{
			if (id_startListening_Landroid_hardware_SensorEventListener_II == IntPtr.Zero)
				id_startListening_Landroid_hardware_SensorEventListener_II = JNIEnv.GetMethodID (class_ref, "startListening", "(Landroid/hardware/SensorEventListener;II)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_startListening_Landroid_hardware_SensorEventListener_II, new JValue (pListener), new JValue (pSensorType), new JValue (pRate));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startListening", "(Landroid/hardware/SensorEventListener;II)Z"), new JValue (pListener), new JValue (pSensorType), new JValue (pRate));
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
			global::Osmdroid.SensorEventListenerProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.SensorEventListenerProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopListening ();
		}
#pragma warning restore 0169

		static IntPtr id_stopListening;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='SensorEventListenerProxy']/method[@name='stopListening' and count(parameter)=0]"
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
