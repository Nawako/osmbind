using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='MapEventsReceiver']"
	[Register ("org/osmdroid/bonuspack/overlays/MapEventsReceiver", "", "Osmdroid.Bonuspack.Overlays.IMapEventsReceiverInvoker")]
	public partial interface IMapEventsReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='MapEventsReceiver']/method[@name='longPressHelper' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("longPressHelper", "(Lorg/osmdroid/util/GeoPoint;)Z", "GetLongPressHelper_Lorg_osmdroid_util_GeoPoint_Handler:Osmdroid.Bonuspack.Overlays.IMapEventsReceiverInvoker, OsmdroidAndroidBinding")]
		bool LongPressHelper (global::Org.Osmdroid.Util.GeoPoint p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='MapEventsReceiver']/method[@name='singleTapConfirmedHelper' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("singleTapConfirmedHelper", "(Lorg/osmdroid/util/GeoPoint;)Z", "GetSingleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_Handler:Osmdroid.Bonuspack.Overlays.IMapEventsReceiverInvoker, OsmdroidAndroidBinding")]
		bool SingleTapConfirmedHelper (global::Org.Osmdroid.Util.GeoPoint p0);

	}

	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/MapEventsReceiver", DoNotGenerateAcw=true)]
	internal class IMapEventsReceiverInvoker : global::Java.Lang.Object, IMapEventsReceiver {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/MapEventsReceiver");
		IntPtr class_ref;

		public static IMapEventsReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapEventsReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.bonuspack.overlays.MapEventsReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapEventsReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapEventsReceiverInvoker); }
		}

		static Delegate cb_longPressHelper_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetLongPressHelper_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_longPressHelper_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_longPressHelper_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_LongPressHelper_Lorg_osmdroid_util_GeoPoint_);
			return cb_longPressHelper_Lorg_osmdroid_util_GeoPoint_;
		}

		static bool n_LongPressHelper_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.IMapEventsReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.IMapEventsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.LongPressHelper (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_longPressHelper_Lorg_osmdroid_util_GeoPoint_;
		public bool LongPressHelper (global::Org.Osmdroid.Util.GeoPoint p0)
		{
			if (id_longPressHelper_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_longPressHelper_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "longPressHelper", "(Lorg/osmdroid/util/GeoPoint;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_longPressHelper_Lorg_osmdroid_util_GeoPoint_, new JValue (p0));
			return __ret;
		}

		static Delegate cb_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSingleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SingleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_);
			return cb_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_;
		}

		static bool n_SingleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.IMapEventsReceiver __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.IMapEventsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SingleTapConfirmedHelper (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_;
		public bool SingleTapConfirmedHelper (global::Org.Osmdroid.Util.GeoPoint p0)
		{
			if (id_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "singleTapConfirmedHelper", "(Lorg/osmdroid/util/GeoPoint;)Z");
			bool __ret = JNIEnv.CallBooleanMethod (Handle, id_singleTapConfirmedHelper_Lorg_osmdroid_util_GeoPoint_, new JValue (p0));
			return __ret;
		}

	}

}
