using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.events']/class[@name='MapAdapter']"
	[global::Android.Runtime.Register ("org/osmdroid/events/MapAdapter", DoNotGenerateAcw=true)]
	public abstract partial class MapAdapter : global::Java.Lang.Object, global::Osmdroid.Events.IMapListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/events/MapAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapAdapter); }
		}

		protected MapAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='MapAdapter']/constructor[@name='MapAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public MapAdapter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapAdapter)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
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
			global::Osmdroid.Events.MapAdapter __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.MapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ScrollEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (e);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onScroll_Lorg_osmdroid_events_ScrollEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='MapAdapter']/method[@name='onScroll' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ScrollEvent']]"
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
			global::Osmdroid.Events.MapAdapter __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.MapAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ZoomEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ZoomEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnZoom (e);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onZoom_Lorg_osmdroid_events_ZoomEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='MapAdapter']/method[@name='onZoom' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ZoomEvent']]"
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

	[global::Android.Runtime.Register ("org/osmdroid/events/MapAdapter", DoNotGenerateAcw=true)]
	internal partial class MapAdapterInvoker : MapAdapter {

		public MapAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapAdapterInvoker); }
		}

	}

}
