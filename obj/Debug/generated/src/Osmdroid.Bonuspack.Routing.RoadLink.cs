using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Routing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLink']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/routing/RoadLink", DoNotGenerateAcw=true)]
	public partial class RoadLink : global::Java.Lang.Object {


		static IntPtr mDuration_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLink']/field[@name='mDuration']"
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

		static IntPtr mLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLink']/field[@name='mLength']"
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

		static IntPtr mShapeIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLink']/field[@name='mShapeIndex']"
		[Register ("mShapeIndex")]
		public int MShapeIndex {
			get {
				if (mShapeIndex_jfieldId == IntPtr.Zero)
					mShapeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mShapeIndex", "I");
				return JNIEnv.GetIntField (Handle, mShapeIndex_jfieldId);
			}
			set {
				if (mShapeIndex_jfieldId == IntPtr.Zero)
					mShapeIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mShapeIndex", "I");
				JNIEnv.SetField (Handle, mShapeIndex_jfieldId, value);
			}
		}

		static IntPtr mSpeed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.routing']/class[@name='RoadLink']/field[@name='mSpeed']"
		[Register ("mSpeed")]
		public double MSpeed {
			get {
				if (mSpeed_jfieldId == IntPtr.Zero)
					mSpeed_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpeed", "D");
				return JNIEnv.GetDoubleField (Handle, mSpeed_jfieldId);
			}
			set {
				if (mSpeed_jfieldId == IntPtr.Zero)
					mSpeed_jfieldId = JNIEnv.GetFieldID (class_ref, "mSpeed", "D");
				JNIEnv.SetField (Handle, mSpeed_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/routing/RoadLink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RoadLink); }
		}

		protected RoadLink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
