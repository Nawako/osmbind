using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']"
	[global::Android.Runtime.Register ("org/osmdroid/events/DelayedMapListener", DoNotGenerateAcw=true)]
	public partial class DelayedMapListener : global::Java.Lang.Object, global::Osmdroid.Events.IMapListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/field[@name='DEFAULT_DELAY']"
		[Register ("DEFAULT_DELAY")]
		protected const int DefaultDelay = (int) 100;

		static IntPtr callback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/field[@name='callback']"
		[Register ("callback")]
		protected global::Osmdroid.Events.DelayedMapListener.CallbackTask Callback {
			get {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lorg/osmdroid/events/DelayedMapListener$CallbackTask;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, callback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Events.DelayedMapListener.CallbackTask> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (callback_jfieldId == IntPtr.Zero)
					callback_jfieldId = JNIEnv.GetFieldID (class_ref, "callback", "Lorg/osmdroid/events/DelayedMapListener$CallbackTask;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, callback_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr delay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/field[@name='delay']"
		[Register ("delay")]
		protected long Delay {
			get {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "J");
				return JNIEnv.GetLongField (Handle, delay_jfieldId);
			}
			set {
				if (delay_jfieldId == IntPtr.Zero)
					delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "J");
				JNIEnv.SetField (Handle, delay_jfieldId, value);
			}
		}

		static IntPtr handler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/field[@name='handler']"
		[Register ("handler")]
		protected global::Android.OS.Handler Handler {
			get {
				if (handler_jfieldId == IntPtr.Zero)
					handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, handler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (handler_jfieldId == IntPtr.Zero)
					handler_jfieldId = JNIEnv.GetFieldID (class_ref, "handler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, handler_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener.CallbackTask']"
		[global::Android.Runtime.Register ("org/osmdroid/events/DelayedMapListener$CallbackTask", DoNotGenerateAcw=true)]
		public partial class CallbackTask : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/events/DelayedMapListener$CallbackTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CallbackTask); }
			}

			protected CallbackTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_events_DelayedMapListener_Lorg_osmdroid_events_MapEvent_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener.CallbackTask']/constructor[@name='DelayedMapListener.CallbackTask' and count(parameter)=2 and parameter[1][@type='org.osmdroid.events.DelayedMapListener'] and parameter[2][@type='org.osmdroid.events.MapEvent']]"
			[Register (".ctor", "(Lorg/osmdroid/events/DelayedMapListener;Lorg/osmdroid/events/MapEvent;)V", "")]
			public CallbackTask (global::Osmdroid.Events.DelayedMapListener __self, global::Osmdroid.Events.IMapEvent p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CallbackTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/osmdroid/events/MapEvent;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/osmdroid/events/MapEvent;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_events_DelayedMapListener_Lorg_osmdroid_events_MapEvent_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_events_DelayedMapListener_Lorg_osmdroid_events_MapEvent_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/events/DelayedMapListener;Lorg/osmdroid/events/MapEvent;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_events_DelayedMapListener_Lorg_osmdroid_events_MapEvent_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_events_DelayedMapListener_Lorg_osmdroid_events_MapEvent_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Events.DelayedMapListener.CallbackTask __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.DelayedMapListener.CallbackTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener.CallbackTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/events/DelayedMapListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DelayedMapListener); }
		}

		protected DelayedMapListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_events_MapListener_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/constructor[@name='DelayedMapListener' and count(parameter)=2 and parameter[1][@type='org.osmdroid.events.MapListener'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lorg/osmdroid/events/MapListener;J)V", "")]
		public DelayedMapListener (global::Osmdroid.Events.IMapListener wrappedListener, long delay) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DelayedMapListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/events/MapListener;J)V", new JValue (wrappedListener), new JValue (delay)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/events/MapListener;J)V", new JValue (wrappedListener), new JValue (delay));
				return;
			}

			if (id_ctor_Lorg_osmdroid_events_MapListener_J == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_events_MapListener_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/events/MapListener;J)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_events_MapListener_J, new JValue (wrappedListener), new JValue (delay)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_events_MapListener_J, new JValue (wrappedListener), new JValue (delay));
		}

		static IntPtr id_ctor_Lorg_osmdroid_events_MapListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/constructor[@name='DelayedMapListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.MapListener']]"
		[Register (".ctor", "(Lorg/osmdroid/events/MapListener;)V", "")]
		public DelayedMapListener (global::Osmdroid.Events.IMapListener wrappedListener) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DelayedMapListener)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/events/MapListener;)V", new JValue (wrappedListener)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/events/MapListener;)V", new JValue (wrappedListener));
				return;
			}

			if (id_ctor_Lorg_osmdroid_events_MapListener_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_events_MapListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/events/MapListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_events_MapListener_, new JValue (wrappedListener)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_events_MapListener_, new JValue (wrappedListener));
		}

		static Delegate cb_dispatch_Lorg_osmdroid_events_MapEvent_;
#pragma warning disable 0169
		static Delegate GetDispatch_Lorg_osmdroid_events_MapEvent_Handler ()
		{
			if (cb_dispatch_Lorg_osmdroid_events_MapEvent_ == null)
				cb_dispatch_Lorg_osmdroid_events_MapEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dispatch_Lorg_osmdroid_events_MapEvent_);
			return cb_dispatch_Lorg_osmdroid_events_MapEvent_;
		}

		static void n_Dispatch_Lorg_osmdroid_events_MapEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Osmdroid.Events.DelayedMapListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.DelayedMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.IMapEvent e = (global::Osmdroid.Events.IMapEvent)global::Java.Lang.Object.GetObject<global::Osmdroid.Events.IMapEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Dispatch (e);
		}
#pragma warning restore 0169

		static IntPtr id_dispatch_Lorg_osmdroid_events_MapEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/method[@name='dispatch' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.MapEvent']]"
		[Register ("dispatch", "(Lorg/osmdroid/events/MapEvent;)V", "GetDispatch_Lorg_osmdroid_events_MapEvent_Handler")]
		protected virtual void Dispatch (global::Osmdroid.Events.IMapEvent e)
		{
			if (id_dispatch_Lorg_osmdroid_events_MapEvent_ == IntPtr.Zero)
				id_dispatch_Lorg_osmdroid_events_MapEvent_ = JNIEnv.GetMethodID (class_ref, "dispatch", "(Lorg/osmdroid/events/MapEvent;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_dispatch_Lorg_osmdroid_events_MapEvent_, new JValue (e));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatch", "(Lorg/osmdroid/events/MapEvent;)V"), new JValue (e));
		}

		static Delegate cb_onScroll_Lorg_osmdroid_events_ScrollEvent_;
#pragma warning disable 0169
		static Delegate GetOnScroll_Lorg_osmdroid_events_ScrollEvent_Handler ()
		{
			if (cb_onScroll_Lorg_osmdroid_events_ScrollEvent_ == null)
				cb_onScroll_Lorg_osmdroid_events_ScrollEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnScroll_Lorg_osmdroid_events_ScrollEvent_);
			return cb_onScroll_Lorg_osmdroid_events_ScrollEvent_;
		}

		static bool n_OnScroll_Lorg_osmdroid_events_ScrollEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Osmdroid.Events.DelayedMapListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.DelayedMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ScrollEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (e);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Lorg_osmdroid_events_ScrollEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/method[@name='onScroll' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ScrollEvent']]"
		[Register ("onScroll", "(Lorg/osmdroid/events/ScrollEvent;)Z", "GetOnScroll_Lorg_osmdroid_events_ScrollEvent_Handler")]
		public virtual bool OnScroll (global::Osmdroid.Events.ScrollEvent e)
		{
			if (id_onScroll_Lorg_osmdroid_events_ScrollEvent_ == IntPtr.Zero)
				id_onScroll_Lorg_osmdroid_events_ScrollEvent_ = JNIEnv.GetMethodID (class_ref, "onScroll", "(Lorg/osmdroid/events/ScrollEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onScroll_Lorg_osmdroid_events_ScrollEvent_, new JValue (e));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Lorg/osmdroid/events/ScrollEvent;)Z"), new JValue (e));
			return __ret;
		}

		static Delegate cb_onZoom_Lorg_osmdroid_events_ZoomEvent_;
#pragma warning disable 0169
		static Delegate GetOnZoom_Lorg_osmdroid_events_ZoomEvent_Handler ()
		{
			if (cb_onZoom_Lorg_osmdroid_events_ZoomEvent_ == null)
				cb_onZoom_Lorg_osmdroid_events_ZoomEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnZoom_Lorg_osmdroid_events_ZoomEvent_);
			return cb_onZoom_Lorg_osmdroid_events_ZoomEvent_;
		}

		static bool n_OnZoom_Lorg_osmdroid_events_ZoomEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Osmdroid.Events.DelayedMapListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.DelayedMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ZoomEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ZoomEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnZoom (e);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onZoom_Lorg_osmdroid_events_ZoomEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='DelayedMapListener']/method[@name='onZoom' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ZoomEvent']]"
		[Register ("onZoom", "(Lorg/osmdroid/events/ZoomEvent;)Z", "GetOnZoom_Lorg_osmdroid_events_ZoomEvent_Handler")]
		public virtual bool OnZoom (global::Osmdroid.Events.ZoomEvent e)
		{
			if (id_onZoom_Lorg_osmdroid_events_ZoomEvent_ == IntPtr.Zero)
				id_onZoom_Lorg_osmdroid_events_ZoomEvent_ = JNIEnv.GetMethodID (class_ref, "onZoom", "(Lorg/osmdroid/events/ZoomEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onZoom_Lorg_osmdroid_events_ZoomEvent_, new JValue (e));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onZoom", "(Lorg/osmdroid/events/ZoomEvent;)Z"), new JValue (e));
			return __ret;
		}

	}
}
