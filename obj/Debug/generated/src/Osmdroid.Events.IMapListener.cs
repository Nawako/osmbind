using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.events']/interface[@name='MapListener']"
	[Register ("org/osmdroid/events/MapListener", "", "Osmdroid.Events.IMapListenerInvoker")]
	public partial interface IMapListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/interface[@name='MapListener']/method[@name='onScroll' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ScrollEvent']]"
		[Register ("onScroll", "(Lorg/osmdroid/events/ScrollEvent;)Z", "GetOnScroll_Lorg_osmdroid_events_ScrollEvent_Handler:Osmdroid.Events.IMapListenerInvoker, OsmdroidAndroidBinding")]
		bool OnScroll (global::Osmdroid.Events.ScrollEvent e);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/interface[@name='MapListener']/method[@name='onZoom' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.ZoomEvent']]"
		[Register ("onZoom", "(Lorg/osmdroid/events/ZoomEvent;)Z", "GetOnZoom_Lorg_osmdroid_events_ZoomEvent_Handler:Osmdroid.Events.IMapListenerInvoker, OsmdroidAndroidBinding")]
		bool OnZoom (global::Osmdroid.Events.ZoomEvent e);

	}

	[global::Android.Runtime.Register ("org/osmdroid/events/MapListener", DoNotGenerateAcw=true)]
	internal class IMapListenerInvoker : global::Java.Lang.Object, IMapListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/events/MapListener");
		IntPtr class_ref;

		public static IMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.events.MapListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapListenerInvoker); }
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
			global::Osmdroid.Events.IMapListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.IMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ScrollEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnScroll (e);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onScroll_Lorg_osmdroid_events_ScrollEvent_;
		public bool OnScroll (global::Osmdroid.Events.ScrollEvent e)
		{
			if (id_onScroll_Lorg_osmdroid_events_ScrollEvent_ == IntPtr.Zero)
				id_onScroll_Lorg_osmdroid_events_ScrollEvent_ = JNIEnv.GetMethodID (class_ref, "onScroll", "(Lorg/osmdroid/events/ScrollEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onScroll_Lorg_osmdroid_events_ScrollEvent_, new JValue (e));
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
			global::Osmdroid.Events.IMapListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.IMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.ZoomEvent e = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ZoomEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnZoom (e);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onZoom_Lorg_osmdroid_events_ZoomEvent_;
		public bool OnZoom (global::Osmdroid.Events.ZoomEvent e)
		{
			if (id_onZoom_Lorg_osmdroid_events_ZoomEvent_ == IntPtr.Zero)
				id_onZoom_Lorg_osmdroid_events_ZoomEvent_ = JNIEnv.GetMethodID (class_ref, "onZoom", "(Lorg/osmdroid/events/ZoomEvent;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onZoom_Lorg_osmdroid_events_ZoomEvent_, new JValue (e));
			return __ret;
		}

	}

	public partial class ScrollEventArgs : global::System.EventArgs {

		public ScrollEventArgs (bool handled, global::Osmdroid.Events.ScrollEvent e)
		{
			this.handled = handled;
			this.e = e;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Osmdroid.Events.ScrollEvent e;
		public global::Osmdroid.Events.ScrollEvent Event {
			get { return e; }
		}
	}

	public partial class ZoomEventArgs : global::System.EventArgs {

		public ZoomEventArgs (bool handled, global::Osmdroid.Events.ZoomEvent e)
		{
			this.handled = handled;
			this.e = e;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		global::Osmdroid.Events.ZoomEvent e;
		public global::Osmdroid.Events.ZoomEvent Event {
			get { return e; }
		}
	}

	[global::Android.Runtime.Register ("mono/org/osmdroid/events/MapListenerImplementor")]
	internal sealed class IMapListenerImplementor : global::Java.Lang.Object, IMapListener {

		object sender;

		public IMapListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/events/MapListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ScrollEventArgs> OnScrollHandler;
#pragma warning restore 0649

		public bool OnScroll (global::Osmdroid.Events.ScrollEvent e)
		{
			var __h = OnScrollHandler;
			if (__h == null)
				return false;
			var __e = new ScrollEventArgs (true, e);
			__h (sender, __e);
			return __e.Handled;
		}
#pragma warning disable 0649
		public EventHandler<ZoomEventArgs> OnZoomHandler;
#pragma warning restore 0649

		public bool OnZoom (global::Osmdroid.Events.ZoomEvent e)
		{
			var __h = OnZoomHandler;
			if (__h == null)
				return false;
			var __e = new ZoomEventArgs (true, e);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IMapListenerImplementor value)
		{
			return value.OnScrollHandler == null && value.OnZoomHandler == null;
		}
	}

}
