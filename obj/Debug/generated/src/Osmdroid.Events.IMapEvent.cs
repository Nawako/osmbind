using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Events {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.events']/interface[@name='MapEvent']"
	[Register ("org/osmdroid/events/MapEvent", "", "Osmdroid.Events.IMapEventInvoker")]
	public partial interface IMapEvent : IJavaObject {

	}

	[global::Android.Runtime.Register ("org/osmdroid/events/MapEvent", DoNotGenerateAcw=true)]
	internal class IMapEventInvoker : global::Java.Lang.Object, IMapEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/events/MapEvent");
		IntPtr class_ref;

		public static IMapEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.events.MapEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapEventInvoker); }
		}

	}

}
