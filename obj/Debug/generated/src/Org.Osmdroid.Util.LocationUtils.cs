using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='LocationUtils']"
	[global::Android.Runtime.Register ("org/osmdroid/util/LocationUtils", DoNotGenerateAcw=true)]
	public partial class LocationUtils : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.util.constants.UtilConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='UtilConstants']/field[@name='GPS_WAIT_TIME']"
			[Register ("GPS_WAIT_TIME")]
			public const long GpsWaitTime = (long) 20000L;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/LocationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationUtils); }
		}

		protected LocationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLastKnownLocation_Landroid_location_LocationManager_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='LocationUtils']/method[@name='getLastKnownLocation' and count(parameter)=1 and parameter[1][@type='android.location.LocationManager']]"
		[Register ("getLastKnownLocation", "(Landroid/location/LocationManager;)Landroid/location/Location;", "")]
		public static global::Android.Locations.Location GetLastKnownLocation (global::Android.Locations.LocationManager pLocationManager)
		{
			if (id_getLastKnownLocation_Landroid_location_LocationManager_ == IntPtr.Zero)
				id_getLastKnownLocation_Landroid_location_LocationManager_ = JNIEnv.GetStaticMethodID (class_ref, "getLastKnownLocation", "(Landroid/location/LocationManager;)Landroid/location/Location;");
			global::Android.Locations.Location __ret = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLastKnownLocation_Landroid_location_LocationManager_, new JValue (pLocationManager)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
