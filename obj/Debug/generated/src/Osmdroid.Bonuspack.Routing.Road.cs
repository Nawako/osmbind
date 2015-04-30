using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/Road", DoNotGenerateAcw=true)]
	public partial class Road : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='STATUS_INVALID']"
		[Register ("STATUS_INVALID")]
		public const int StatusInvalid = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='STATUS_OK']"
		[Register ("STATUS_OK")]
		public const int StatusOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='STATUS_TECHNICAL_ISSUE']"
		[Register ("STATUS_TECHNICAL_ISSUE")]
		public const int StatusTechnicalIssue = (int) 2;

		static IntPtr mBoundingBox_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mBoundingBox']"
		[Register ("mBoundingBox")]
		public global::Org.Osmdroid.Util.BoundingBoxE6 MBoundingBox {
			get {
				if (mBoundingBox_jfieldId == IntPtr.Zero)
					mBoundingBox_jfieldId = JNIEnv.GetFieldID (class_ref, "mBoundingBox", "Lorg/osmdroid/util/BoundingBoxE6;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBoundingBox_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBoundingBox_jfieldId == IntPtr.Zero)
					mBoundingBox_jfieldId = JNIEnv.GetFieldID (class_ref, "mBoundingBox", "Lorg/osmdroid/util/BoundingBoxE6;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mBoundingBox_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mDuration']"
		[Register ("mDuration")]
		public double MDuration {
			get {
				if (mDuration_jfieldId == IntPtr.Zero)
					mDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mDuration", "D");
				return JNIEnv.GetDoubleField (Handle, mDuration_jfieldId);
			}
			set {
				if (mDuration_jfieldId == IntPtr.Zero)
					mDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mDuration", "D");
				JNIEnv.SetField (Handle, mDuration_jfieldId, value);
			}
		}

		static IntPtr mLegs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mLegs']"
		[Register ("mLegs")]
		public global::System.Collections.IList MLegs {
			get {
				if (mLegs_jfieldId == IntPtr.Zero)
					mLegs_jfieldId = JNIEnv.GetFieldID (class_ref, "mLegs", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLegs_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLegs_jfieldId == IntPtr.Zero)
					mLegs_jfieldId = JNIEnv.GetFieldID (class_ref, "mLegs", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLegs_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mLength']"
		[Register ("mLength")]
		public double MLength {
			get {
				if (mLength_jfieldId == IntPtr.Zero)
					mLength_jfieldId = JNIEnv.GetFieldID (class_ref, "mLength", "D");
				return JNIEnv.GetDoubleField (Handle, mLength_jfieldId);
			}
			set {
				if (mLength_jfieldId == IntPtr.Zero)
					mLength_jfieldId = JNIEnv.GetFieldID (class_ref, "mLength", "D");
				JNIEnv.SetField (Handle, mLength_jfieldId, value);
			}
		}

		static IntPtr mNodes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mNodes']"
		[Register ("mNodes")]
		public global::System.Collections.IList MNodes {
			get {
				if (mNodes_jfieldId == IntPtr.Zero)
					mNodes_jfieldId = JNIEnv.GetFieldID (class_ref, "mNodes", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mNodes_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNodes_jfieldId == IntPtr.Zero)
					mNodes_jfieldId = JNIEnv.GetFieldID (class_ref, "mNodes", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mNodes_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mRouteHigh_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mRouteHigh']"
		[Register ("mRouteHigh")]
		public global::System.Collections.IList MRouteHigh {
			get {
				if (mRouteHigh_jfieldId == IntPtr.Zero)
					mRouteHigh_jfieldId = JNIEnv.GetFieldID (class_ref, "mRouteHigh", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRouteHigh_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRouteHigh_jfieldId == IntPtr.Zero)
					mRouteHigh_jfieldId = JNIEnv.GetFieldID (class_ref, "mRouteHigh", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mRouteHigh_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mStatus_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/field[@name='mStatus']"
		[Register ("mStatus")]
		public int MStatus {
			get {
				if (mStatus_jfieldId == IntPtr.Zero)
					mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "I");
				return JNIEnv.GetIntField (Handle, mStatus_jfieldId);
			}
			set {
				if (mStatus_jfieldId == IntPtr.Zero)
					mStatus_jfieldId = JNIEnv.GetFieldID (class_ref, "mStatus", "I");
				JNIEnv.SetField (Handle, mStatus_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/Road", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Road); }
		}

		protected Road (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/constructor[@name='Road' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Road () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Road)) {
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

		static IntPtr id_ctor_Ljava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/constructor[@name='Road' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register (".ctor", "(Ljava/util/ArrayList;)V", "")]
		public Road (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);;
			if (GetType () != typeof (Road)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/ArrayList;)V", new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/ArrayList;)V", new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_ctor_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/ArrayList;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_ArrayList_, new JValue (native_p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_ArrayList_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getRouteLow;
#pragma warning disable 0169
		static Delegate GetGetRouteLowHandler ()
		{
			if (cb_getRouteLow == null)
				cb_getRouteLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRouteLow);
			return cb_getRouteLow;
		}

		static IntPtr n_GetRouteLow (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (__this.RouteLow);
		}
#pragma warning restore 0169

		static Delegate cb_setRouteLow_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetRouteLow_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setRouteLow_Ljava_util_ArrayList_ == null)
				cb_setRouteLow_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRouteLow_Ljava_util_ArrayList_);
			return cb_setRouteLow_Ljava_util_ArrayList_;
		}

		static void n_SetRouteLow_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RouteLow = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRouteLow;
		static IntPtr id_setRouteLow_Ljava_util_ArrayList_;
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> RouteLow {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='getRouteLow' and count(parameter)=0]"
			[Register ("getRouteLow", "()Ljava/util/ArrayList;", "GetGetRouteLowHandler")]
			get {
				if (id_getRouteLow == IntPtr.Zero)
					id_getRouteLow = JNIEnv.GetMethodID (class_ref, "getRouteLow", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRouteLow), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRouteLow", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='setRouteLow' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
			[Register ("setRouteLow", "(Ljava/util/ArrayList;)V", "GetSetRouteLow_Ljava_util_ArrayList_Handler")]
			set {
				if (id_setRouteLow_Ljava_util_ArrayList_ == IntPtr.Zero)
					id_setRouteLow_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "setRouteLow", "(Ljava/util/ArrayList;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRouteLow_Ljava_util_ArrayList_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRouteLow", "(Ljava/util/ArrayList;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_buildLegs_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetBuildLegs_Ljava_util_ArrayList_Handler ()
		{
			if (cb_buildLegs_Ljava_util_ArrayList_ == null)
				cb_buildLegs_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BuildLegs_Ljava_util_ArrayList_);
			return cb_buildLegs_Ljava_util_ArrayList_;
		}

		static void n_BuildLegs_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BuildLegs (p0);
		}
#pragma warning restore 0169

		static IntPtr id_buildLegs_Ljava_util_ArrayList_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='buildLegs' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
		[Register ("buildLegs", "(Ljava/util/ArrayList;)V", "GetBuildLegs_Ljava_util_ArrayList_Handler")]
		public virtual void BuildLegs (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0)
		{
			if (id_buildLegs_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_buildLegs_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "buildLegs", "(Ljava/util/ArrayList;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_buildLegs_Ljava_util_ArrayList_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildLegs", "(Ljava/util/ArrayList;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_DistanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_);
			return cb_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		}

		static double n_DistanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p1 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceLLSquared (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='distanceLLSquared' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("distanceLLSquared", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)D", "GetDistanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Handler")]
		protected virtual double DistanceLLSquared (global::Org.Osmdroid.Util.GeoPoint p0, global::Org.Osmdroid.Util.GeoPoint p1)
		{
			if (id_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "distanceLLSquared", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)D");

			double __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallDoubleMethod  (Handle, id_distanceLLSquared_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "distanceLLSquared", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)D"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static IntPtr id_getLengthDurationText_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='getLengthDurationText' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("getLengthDurationText", "(DD)Ljava/lang/String;", "")]
		public static string GetLengthDurationText (double p0, double p1)
		{
			if (id_getLengthDurationText_DD == IntPtr.Zero)
				id_getLengthDurationText_DD = JNIEnv.GetStaticMethodID (class_ref, "getLengthDurationText", "(DD)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLengthDurationText_DD, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getLengthDurationText_I;
#pragma warning disable 0169
		static Delegate GetGetLengthDurationText_IHandler ()
		{
			if (cb_getLengthDurationText_I == null)
				cb_getLengthDurationText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetLengthDurationText_I);
			return cb_getLengthDurationText_I;
		}

		static IntPtr n_GetLengthDurationText_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetLengthDurationText (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getLengthDurationText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='getLengthDurationText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLengthDurationText", "(I)Ljava/lang/String;", "GetGetLengthDurationText_IHandler")]
		public virtual string GetLengthDurationText (int p0)
		{
			if (id_getLengthDurationText_I == IntPtr.Zero)
				id_getLengthDurationText_I = JNIEnv.GetMethodID (class_ref, "getLengthDurationText", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getLengthDurationText_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLengthDurationText", "(I)Ljava/lang/String;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Osmdroid.Bonuspack.Routing.Road __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.Road> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='Road']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
