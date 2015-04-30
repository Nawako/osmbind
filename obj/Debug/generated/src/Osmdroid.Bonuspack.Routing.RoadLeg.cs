using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/RoadLeg", DoNotGenerateAcw=true)]
	public partial class RoadLeg : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/field[@name='CREATOR']"
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

		static IntPtr mDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/field[@name='mDuration']"
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

		static IntPtr mEndNodeIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/field[@name='mEndNodeIndex']"
		[Register ("mEndNodeIndex")]
		public int MEndNodeIndex {
			get {
				if (mEndNodeIndex_jfieldId == IntPtr.Zero)
					mEndNodeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndNodeIndex", "I");
				return JNIEnv.GetIntField (Handle, mEndNodeIndex_jfieldId);
			}
			set {
				if (mEndNodeIndex_jfieldId == IntPtr.Zero)
					mEndNodeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mEndNodeIndex", "I");
				JNIEnv.SetField (Handle, mEndNodeIndex_jfieldId, value);
			}
		}

		static IntPtr mLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/field[@name='mLength']"
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

		static IntPtr mStartNodeIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/field[@name='mStartNodeIndex']"
		[Register ("mStartNodeIndex")]
		public int MStartNodeIndex {
			get {
				if (mStartNodeIndex_jfieldId == IntPtr.Zero)
					mStartNodeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartNodeIndex", "I");
				return JNIEnv.GetIntField (Handle, mStartNodeIndex_jfieldId);
			}
			set {
				if (mStartNodeIndex_jfieldId == IntPtr.Zero)
					mStartNodeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mStartNodeIndex", "I");
				JNIEnv.SetField (Handle, mStartNodeIndex_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/RoadLeg", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoadLeg); }
		}

		protected RoadLeg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILjava_util_ArrayList_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/constructor[@name='RoadLeg' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.ArrayList']]"
		[Register (".ctor", "(IILjava/util/ArrayList;)V", "")]
		public RoadLeg (int p0, int p1, global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Routing.RoadNode> p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Routing.RoadNode>.ToLocalJniHandle (p2);;
			if (GetType () != typeof (RoadLeg)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/util/ArrayList;)V", new JValue (p0), new JValue (p1), new JValue (native_p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILjava/util/ArrayList;)V", new JValue (p0), new JValue (p1), new JValue (native_p2));
				JNIEnv.DeleteLocalRef (native_p2);
				return;
			}

			if (id_ctor_IILjava_util_ArrayList_ == IntPtr.Zero)
				id_ctor_IILjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/util/ArrayList;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_util_ArrayList_, new JValue (p0), new JValue (p1), new JValue (native_p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILjava_util_ArrayList_, new JValue (p0), new JValue (p1), new JValue (native_p2));
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/constructor[@name='RoadLeg' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public RoadLeg () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (RoadLeg)) {
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
			global::Osmdroid.Bonuspack.Routing.RoadLeg __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.RoadLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Osmdroid.Bonuspack.Routing.RoadLeg __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Routing.RoadLeg> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLeg']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
