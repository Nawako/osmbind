using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ZoomEvent']"
	[global::Android.Runtime.Register ("org/osmdroid/events/ZoomEvent", DoNotGenerateAcw=true)]
	public partial class ZoomEvent : global::Java.Lang.Object, global::Osmdroid.Events.IMapEvent {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/events/ZoomEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ZoomEvent); }
		}

		protected ZoomEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ZoomEvent']/constructor[@name='ZoomEvent' and count(parameter)=2 and parameter[1][@type='org.osmdroid.views.MapView'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;I)V", "")]
		public ZoomEvent (global::Osmdroid.Views.MapView source, int zoomLevel) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ZoomEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;I)V", new JValue (source), new JValue (zoomLevel)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;I)V", new JValue (source), new JValue (zoomLevel));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_I == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_I, new JValue (source), new JValue (zoomLevel)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_I, new JValue (source), new JValue (zoomLevel));
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Events.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ZoomEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		static IntPtr id_getSource;
		public virtual global::Osmdroid.Views.MapView Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ZoomEvent']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lorg/osmdroid/views/MapView;", "GetGetSourceHandler")]
			get {
				if (id_getSource == IntPtr.Zero)
					id_getSource = JNIEnv.GetMethodID (class_ref, "getSource", "()Lorg/osmdroid/views/MapView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (JNIEnv.CallObjectMethod  (Handle, id_getSource), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSource", "()Lorg/osmdroid/views/MapView;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Events.ZoomEvent __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ZoomEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		public virtual int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ZoomEvent']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "()I"));
			}
		}

	}
}
