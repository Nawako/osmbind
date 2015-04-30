using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay.Compass {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationProvider']"
	[Register ("org/osmdroid/views/overlay/compass/IOrientationProvider", "", "Osmdroid.Views.Overlay.Compass.IOrientationProviderInvoker")]
	public partial interface IOrientationProvider : IJavaObject {

		float LastKnownOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationProvider']/method[@name='getLastKnownOrientation' and count(parameter)=0]"
			[Register ("getLastKnownOrientation", "()F", "GetGetLastKnownOrientationHandler:Osmdroid.Views.Overlay.Compass.IOrientationProviderInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationProvider']/method[@name='startOrientationProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.compass.IOrientationConsumer']]"
		[Register ("startOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationConsumer;)Z", "GetStartOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_Handler:Osmdroid.Views.Overlay.Compass.IOrientationProviderInvoker, OsmdroidAndroidBinding")]
		bool StartOrientationProvider (global::Osmdroid.Views.Overlay.Compass.IOrientationConsumer orientationConsumer);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay.compass']/interface[@name='IOrientationProvider']/method[@name='stopOrientationProvider' and count(parameter)=0]"
		[Register ("stopOrientationProvider", "()V", "GetStopOrientationProviderHandler:Osmdroid.Views.Overlay.Compass.IOrientationProviderInvoker, OsmdroidAndroidBinding")]
		void StopOrientationProvider ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/compass/IOrientationProvider", DoNotGenerateAcw=true)]
	internal class IOrientationProviderInvoker : global::Java.Lang.Object, IOrientationProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/compass/IOrientationProvider");
		IntPtr class_ref;

		public static IOrientationProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOrientationProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.compass.IOrientationProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOrientationProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IOrientationProviderInvoker); }
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
			global::Osmdroid.Views.Overlay.Compass.IOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Compass.IOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastKnownOrientation;
		}
#pragma warning restore 0169

		IntPtr id_getLastKnownOrientation;
		public float LastKnownOrientation {
			get {
				if (id_getLastKnownOrientation == IntPtr.Zero)
					id_getLastKnownOrientation = JNIEnv.GetMethodID (class_ref, "getLastKnownOrientation", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getLastKnownOrientation);
			}
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
			global::Osmdroid.Views.Overlay.Compass.IOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Compass.IOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.Compass.IOrientationConsumer orientationConsumer = (global::Osmdroid.Views.Overlay.Compass.IOrientationConsumer)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Compass.IOrientationConsumer> (native_orientationConsumer, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartOrientationProvider (orientationConsumer);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_;
		public bool StartOrientationProvider (global::Osmdroid.Views.Overlay.Compass.IOrientationConsumer orientationConsumer)
		{
			if (id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ == IntPtr.Zero)
				id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_ = JNIEnv.GetMethodID (class_ref, "startOrientationProvider", "(Lorg/osmdroid/views/overlay/compass/IOrientationConsumer;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_startOrientationProvider_Lorg_osmdroid_views_overlay_compass_IOrientationConsumer_, new JValue (orientationConsumer));
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
			global::Osmdroid.Views.Overlay.Compass.IOrientationProvider __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.Compass.IOrientationProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopOrientationProvider ();
		}
#pragma warning restore 0169

		IntPtr id_stopOrientationProvider;
		public void StopOrientationProvider ()
		{
			if (id_stopOrientationProvider == IntPtr.Zero)
				id_stopOrientationProvider = JNIEnv.GetMethodID (class_ref, "stopOrientationProvider", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stopOrientationProvider);
		}

	}

}
