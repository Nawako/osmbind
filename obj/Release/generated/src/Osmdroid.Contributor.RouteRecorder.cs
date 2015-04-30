using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Contributor {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']"
	[global::Android.Runtime.Register ("org/osmdroid/contributor/RouteRecorder", DoNotGenerateAcw=true)]
	public partial class RouteRecorder : global::Java.Lang.Object {


		static IntPtr mRecords_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']/field[@name='mRecords']"
		[Register ("mRecords")]
		protected global::System.Collections.IList MRecords {
			get {
				if (mRecords_jfieldId == IntPtr.Zero)
					mRecords_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecords", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRecords_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRecords_jfieldId == IntPtr.Zero)
					mRecords_jfieldId = JNIEnv.GetFieldID (class_ref, "mRecords", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mRecords_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/contributor/RouteRecorder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RouteRecorder); }
		}

		protected RouteRecorder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']/constructor[@name='RouteRecorder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RouteRecorder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RouteRecorder)) {
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

		static Delegate cb_getRecordedGeoPoints;
#pragma warning disable 0169
		static Delegate GetGetRecordedGeoPointsHandler ()
		{
			if (cb_getRecordedGeoPoints == null)
				cb_getRecordedGeoPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecordedGeoPoints);
			return cb_getRecordedGeoPoints;
		}

		static IntPtr n_GetRecordedGeoPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Contributor.RouteRecorder __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.RouteRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.ToLocalJniHandle (__this.RecordedGeoPoints);
		}
#pragma warning restore 0169

		static IntPtr id_getRecordedGeoPoints;
		public virtual global::System.Collections.Generic.IList<global::Osmdroid.Contributor.Util.RecordedGeoPoint> RecordedGeoPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']/method[@name='getRecordedGeoPoints' and count(parameter)=0]"
			[Register ("getRecordedGeoPoints", "()Ljava/util/ArrayList;", "GetGetRecordedGeoPointsHandler")]
			get {
				if (id_getRecordedGeoPoints == IntPtr.Zero)
					id_getRecordedGeoPoints = JNIEnv.GetMethodID (class_ref, "getRecordedGeoPoints", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRecordedGeoPoints), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Osmdroid.Contributor.Util.RecordedGeoPoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecordedGeoPoints", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Landroid_location_Location_I;
#pragma warning disable 0169
		static Delegate GetAdd_Landroid_location_Location_IHandler ()
		{
			if (cb_add_Landroid_location_Location_I == null)
				cb_add_Landroid_location_Location_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Add_Landroid_location_Location_I);
			return cb_add_Landroid_location_Location_I;
		}

		static void n_Add_Landroid_location_Location_I (IntPtr jnienv, IntPtr native__this, IntPtr native_aLocation, int aNumSatellites)
		{
			global::Osmdroid.Contributor.RouteRecorder __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.RouteRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location aLocation = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_aLocation, JniHandleOwnership.DoNotTransfer);
			__this.Add (aLocation, aNumSatellites);
		}
#pragma warning restore 0169

		static IntPtr id_add_Landroid_location_Location_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='android.location.Location'] and parameter[2][@type='int']]"
		[Register ("add", "(Landroid/location/Location;I)V", "GetAdd_Landroid_location_Location_IHandler")]
		public virtual void Add (global::Android.Locations.Location aLocation, int aNumSatellites)
		{
			if (id_add_Landroid_location_Location_I == IntPtr.Zero)
				id_add_Landroid_location_Location_I = JNIEnv.GetMethodID (class_ref, "add", "(Landroid/location/Location;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Landroid_location_Location_I, new JValue (aLocation), new JValue (aNumSatellites));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Landroid/location/Location;I)V"), new JValue (aLocation), new JValue (aNumSatellites));
		}

		static Delegate cb_add_Lorg_osmdroid_util_GeoPoint_I;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_osmdroid_util_GeoPoint_IHandler ()
		{
			if (cb_add_Lorg_osmdroid_util_GeoPoint_I == null)
				cb_add_Lorg_osmdroid_util_GeoPoint_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Add_Lorg_osmdroid_util_GeoPoint_I);
			return cb_add_Lorg_osmdroid_util_GeoPoint_I;
		}

		static void n_Add_Lorg_osmdroid_util_GeoPoint_I (IntPtr jnienv, IntPtr native__this, IntPtr native_aGeoPoint, int aNumSatellites)
		{
			global::Osmdroid.Contributor.RouteRecorder __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Contributor.RouteRecorder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint aGeoPoint = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_aGeoPoint, JniHandleOwnership.DoNotTransfer);
			__this.Add (aGeoPoint, aNumSatellites);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_osmdroid_util_GeoPoint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.contributor']/class[@name='RouteRecorder']/method[@name='add' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='int']]"
		[Register ("add", "(Lorg/osmdroid/util/GeoPoint;I)V", "GetAdd_Lorg_osmdroid_util_GeoPoint_IHandler")]
		public virtual void Add (global::Osmdroid.Util.GeoPoint aGeoPoint, int aNumSatellites)
		{
			if (id_add_Lorg_osmdroid_util_GeoPoint_I == IntPtr.Zero)
				id_add_Lorg_osmdroid_util_GeoPoint_I = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/osmdroid/util/GeoPoint;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Lorg_osmdroid_util_GeoPoint_I, new JValue (aGeoPoint), new JValue (aNumSatellites));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/osmdroid/util/GeoPoint;I)V"), new JValue (aGeoPoint), new JValue (aNumSatellites));
		}

	}
}
