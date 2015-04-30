using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']"
	[global::Android.Runtime.Register ("org/osmdroid/events/ScrollEvent", DoNotGenerateAcw=true)]
	public partial class ScrollEvent : global::Java.Lang.Object, global::Osmdroid.Events.IMapEvent {


		static IntPtr x_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/field[@name='x']"
		[Register ("x")]
		protected int X {
			get {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				return JNIEnv.GetIntField (Handle, x_jfieldId);
			}
			set {
				if (x_jfieldId == IntPtr.Zero)
					x_jfieldId = JNIEnv.GetFieldID (class_ref, "x", "I");
				JNIEnv.SetField (Handle, x_jfieldId, value);
			}
		}

		static IntPtr y_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/field[@name='y']"
		[Register ("y")]
		protected int Y {
			get {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				return JNIEnv.GetIntField (Handle, y_jfieldId);
			}
			set {
				if (y_jfieldId == IntPtr.Zero)
					y_jfieldId = JNIEnv.GetFieldID (class_ref, "y", "I");
				JNIEnv.SetField (Handle, y_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/events/ScrollEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScrollEvent); }
		}

		protected ScrollEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/constructor[@name='ScrollEvent' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapView'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;II)V", "")]
		public ScrollEvent (global::Osmdroid.Views.MapView source, int x, int y) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScrollEvent)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;II)V", new JValue (source), new JValue (x), new JValue (y)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;II)V", new JValue (source), new JValue (x), new JValue (y));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_II == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;II)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_II, new JValue (source), new JValue (x), new JValue (y)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_II, new JValue (source), new JValue (x), new JValue (y));
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
			global::Osmdroid.Events.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		static IntPtr id_getSource;
		public virtual global::Osmdroid.Views.MapView Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/method[@name='getSource' and count(parameter)=0]"
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

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetX);
			return cb_getX;
		}

		static int n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Events.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()I", "GetGetXHandler")]
		public virtual int GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getX);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()I"));
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetY);
			return cb_getY;
		}

		static int n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Events.ScrollEvent __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Events.ScrollEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.events']/class[@name='ScrollEvent']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()I", "GetGetYHandler")]
		public virtual int GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getY);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()I"));
		}

	}
}
