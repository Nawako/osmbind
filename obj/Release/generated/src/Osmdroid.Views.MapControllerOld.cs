using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']"
	[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld", DoNotGenerateAcw=true)]
	public partial class MapControllerOld : global::Java.Lang.Object, global::Osmdroid.Api.IMapController {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.MapViewConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_DEFAULT']"
			[Register ("ANIMATION_DURATION_DEFAULT")]
			public const int AnimationDurationDefault = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_LONG']"
			[Register ("ANIMATION_DURATION_LONG")]
			public const int AnimationDurationLong = (int) 2000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_SHORT']"
			[Register ("ANIMATION_DURATION_SHORT")]
			public const int AnimationDurationShort = (int) 500;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_DEFAULT']"
			[Register ("ANIMATION_SMOOTHNESS_DEFAULT")]
			public const int AnimationSmoothnessDefault = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_HIGH']"
			[Register ("ANIMATION_SMOOTHNESS_HIGH")]
			public const int AnimationSmoothnessHigh = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_LOW']"
			[Register ("ANIMATION_SMOOTHNESS_LOW")]
			public const int AnimationSmoothnessLow = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MAXIMUM_ZOOMLEVEL']"
			[Register ("MAXIMUM_ZOOMLEVEL")]
			public const int MaximumZoomlevel = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MINIMUM_ZOOMLEVEL']"
			[Register ("MINIMUM_ZOOMLEVEL")]
			public const int MinimumZoomlevel = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$AbstractAnimationRunner", DoNotGenerateAcw=true)]
		public abstract partial class AbstractAnimationRunner : global::Java.Lang.Thread {


			static IntPtr mDone_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mDone']"
			[Register ("mDone")]
			protected bool MDone {
				get {
					if (mDone_jfieldId == IntPtr.Zero)
						mDone_jfieldId = JNIEnv.GetFieldID (class_ref, "mDone", "Z");
					return JNIEnv.GetBooleanField (Handle, mDone_jfieldId);
				}
				set {
					if (mDone_jfieldId == IntPtr.Zero)
						mDone_jfieldId = JNIEnv.GetFieldID (class_ref, "mDone", "Z");
					JNIEnv.SetField (Handle, mDone_jfieldId, value);
				}
			}

			static IntPtr mPanTotalLatitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mPanTotalLatitudeE6']"
			[Register ("mPanTotalLatitudeE6")]
			protected int MPanTotalLatitudeE6 {
				get {
					if (mPanTotalLatitudeE6_jfieldId == IntPtr.Zero)
						mPanTotalLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanTotalLatitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mPanTotalLatitudeE6_jfieldId);
				}
				set {
					if (mPanTotalLatitudeE6_jfieldId == IntPtr.Zero)
						mPanTotalLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanTotalLatitudeE6", "I");
					JNIEnv.SetField (Handle, mPanTotalLatitudeE6_jfieldId, value);
				}
			}

			static IntPtr mPanTotalLongitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mPanTotalLongitudeE6']"
			[Register ("mPanTotalLongitudeE6")]
			protected int MPanTotalLongitudeE6 {
				get {
					if (mPanTotalLongitudeE6_jfieldId == IntPtr.Zero)
						mPanTotalLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanTotalLongitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mPanTotalLongitudeE6_jfieldId);
				}
				set {
					if (mPanTotalLongitudeE6_jfieldId == IntPtr.Zero)
						mPanTotalLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanTotalLongitudeE6", "I");
					JNIEnv.SetField (Handle, mPanTotalLongitudeE6_jfieldId, value);
				}
			}

			static IntPtr mSmoothness_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mSmoothness']"
			[Register ("mSmoothness")]
			protected int MSmoothness {
				get {
					if (mSmoothness_jfieldId == IntPtr.Zero)
						mSmoothness_jfieldId = JNIEnv.GetFieldID (class_ref, "mSmoothness", "I");
					return JNIEnv.GetIntField (Handle, mSmoothness_jfieldId);
				}
				set {
					if (mSmoothness_jfieldId == IntPtr.Zero)
						mSmoothness_jfieldId = JNIEnv.GetFieldID (class_ref, "mSmoothness", "I");
					JNIEnv.SetField (Handle, mSmoothness_jfieldId, value);
				}
			}

			static IntPtr mStepDuration_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mStepDuration']"
			[Register ("mStepDuration")]
			protected int MStepDuration {
				get {
					if (mStepDuration_jfieldId == IntPtr.Zero)
						mStepDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mStepDuration", "I");
					return JNIEnv.GetIntField (Handle, mStepDuration_jfieldId);
				}
				set {
					if (mStepDuration_jfieldId == IntPtr.Zero)
						mStepDuration_jfieldId = JNIEnv.GetFieldID (class_ref, "mStepDuration", "I");
					JNIEnv.SetField (Handle, mStepDuration_jfieldId, value);
				}
			}

			static IntPtr mTargetLatitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mTargetLatitudeE6']"
			[Register ("mTargetLatitudeE6")]
			protected int MTargetLatitudeE6 {
				get {
					if (mTargetLatitudeE6_jfieldId == IntPtr.Zero)
						mTargetLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetLatitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mTargetLatitudeE6_jfieldId);
				}
				set {
					if (mTargetLatitudeE6_jfieldId == IntPtr.Zero)
						mTargetLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetLatitudeE6", "I");
					JNIEnv.SetField (Handle, mTargetLatitudeE6_jfieldId, value);
				}
			}

			static IntPtr mTargetLongitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/field[@name='mTargetLongitudeE6']"
			[Register ("mTargetLongitudeE6")]
			protected int MTargetLongitudeE6 {
				get {
					if (mTargetLongitudeE6_jfieldId == IntPtr.Zero)
						mTargetLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetLongitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mTargetLongitudeE6_jfieldId);
				}
				set {
					if (mTargetLongitudeE6_jfieldId == IntPtr.Zero)
						mTargetLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetLongitudeE6", "I");
					JNIEnv.SetField (Handle, mTargetLongitudeE6_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$AbstractAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractAnimationRunner); }
			}

			protected AbstractAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/constructor[@name='MapControllerOld.AbstractAnimationRunner' and count(parameter)=4 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='org.osmdroid.views.MapControllerOld'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			public AbstractAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, global::Osmdroid.Views.MapControllerOld p1, int p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (AbstractAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/osmdroid/views/MapControllerOld;II)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lorg/osmdroid/views/MapControllerOld;II)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/constructor[@name='MapControllerOld.AbstractAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			public AbstractAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (AbstractAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

			static Delegate cb_isDone;
#pragma warning disable 0169
			static Delegate GetIsDoneHandler ()
			{
				if (cb_isDone == null)
					cb_isDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDone);
				return cb_isDone;
			}

			static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDone;
			}
#pragma warning restore 0169

			static IntPtr id_isDone;
			public virtual bool IsDone {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/method[@name='isDone' and count(parameter)=0]"
				[Register ("isDone", "()Z", "GetIsDoneHandler")]
				get {
					if (id_isDone == IntPtr.Zero)
						id_isDone = JNIEnv.GetMethodID (class_ref, "isDone", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDone);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDone", "()Z"));
				}
			}

			static Delegate cb_onRunAnimation;
#pragma warning disable 0169
			static Delegate GetOnRunAnimationHandler ()
			{
				if (cb_onRunAnimation == null)
					cb_onRunAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRunAnimation);
				return cb_onRunAnimation;
			}

			static void n_OnRunAnimation (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRunAnimation ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/method[@name='onRunAnimation' and count(parameter)=0]"
			[Register ("onRunAnimation", "()V", "GetOnRunAnimationHandler")]
			public abstract void OnRunAnimation ();

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$AbstractAnimationRunner", DoNotGenerateAcw=true)]
		internal partial class AbstractAnimationRunnerInvoker : AbstractAnimationRunner {

			public AbstractAnimationRunnerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (AbstractAnimationRunnerInvoker); }
			}

			static IntPtr id_onRunAnimation;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AbstractAnimationRunner']/method[@name='onRunAnimation' and count(parameter)=0]"
			[Register ("onRunAnimation", "()V", "GetOnRunAnimationHandler")]
			public override void OnRunAnimation ()
			{
				if (id_onRunAnimation == IntPtr.Zero)
					id_onRunAnimation = JNIEnv.GetMethodID (class_ref, "onRunAnimation", "()V");
				JNIEnv.CallVoidMethod  (Handle, id_onRunAnimation);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$AnimationType", DoNotGenerateAcw=true)]
		public sealed partial class AnimationType : global::Java.Lang.Enum {


			static IntPtr EXPONENTIALDECELERATING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/field[@name='EXPONENTIALDECELERATING']"
			[Register ("EXPONENTIALDECELERATING")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType Exponentialdecelerating {
				get {
					if (EXPONENTIALDECELERATING_jfieldId == IntPtr.Zero)
						EXPONENTIALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPONENTIALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPONENTIALDECELERATING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (EXPONENTIALDECELERATING_jfieldId == IntPtr.Zero)
						EXPONENTIALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPONENTIALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, EXPONENTIALDECELERATING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr HALFCOSINUSALDECELERATING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/field[@name='HALFCOSINUSALDECELERATING']"
			[Register ("HALFCOSINUSALDECELERATING")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType Halfcosinusaldecelerating {
				get {
					if (HALFCOSINUSALDECELERATING_jfieldId == IntPtr.Zero)
						HALFCOSINUSALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HALFCOSINUSALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HALFCOSINUSALDECELERATING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (HALFCOSINUSALDECELERATING_jfieldId == IntPtr.Zero)
						HALFCOSINUSALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HALFCOSINUSALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, HALFCOSINUSALDECELERATING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LINEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/field[@name='LINEAR']"
			[Register ("LINEAR")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType Linear {
				get {
					if (LINEAR_jfieldId == IntPtr.Zero)
						LINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINEAR", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LINEAR_jfieldId == IntPtr.Zero)
						LINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINEAR", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LINEAR_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr MIDDLEPEAKSPEED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/field[@name='MIDDLEPEAKSPEED']"
			[Register ("MIDDLEPEAKSPEED")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType Middlepeakspeed {
				get {
					if (MIDDLEPEAKSPEED_jfieldId == IntPtr.Zero)
						MIDDLEPEAKSPEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIDDLEPEAKSPEED", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIDDLEPEAKSPEED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (MIDDLEPEAKSPEED_jfieldId == IntPtr.Zero)
						MIDDLEPEAKSPEED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIDDLEPEAKSPEED", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, MIDDLEPEAKSPEED_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr QUARTERCOSINUSALDECELERATING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/field[@name='QUARTERCOSINUSALDECELERATING']"
			[Register ("QUARTERCOSINUSALDECELERATING")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType Quartercosinusaldecelerating {
				get {
					if (QUARTERCOSINUSALDECELERATING_jfieldId == IntPtr.Zero)
						QUARTERCOSINUSALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUARTERCOSINUSALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUARTERCOSINUSALDECELERATING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (QUARTERCOSINUSALDECELERATING_jfieldId == IntPtr.Zero)
						QUARTERCOSINUSALDECELERATING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUARTERCOSINUSALDECELERATING", "Lorg/osmdroid/views/MapControllerOld$AnimationType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, QUARTERCOSINUSALDECELERATING_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$AnimationType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AnimationType); }
			}

			internal AnimationType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/MapControllerOld$AnimationType;", "")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/MapControllerOld$AnimationType;");
				IntPtr native_name = JNIEnv.NewString (name);
				global::Osmdroid.Views.MapControllerOld.AnimationType __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_name);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.AnimationType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/osmdroid/views/MapControllerOld$AnimationType;", "")]
			public static global::Osmdroid.Views.MapControllerOld.AnimationType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/views/MapControllerOld$AnimationType;");
				return (global::Osmdroid.Views.MapControllerOld.AnimationType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.Views.MapControllerOld.AnimationType));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$CosinusalBasedAnimationRunner", DoNotGenerateAcw=true)]
		public partial class CosinusalBasedAnimationRunner : global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner {


			static IntPtr mAmountStretch_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/field[@name='mAmountStretch']"
			[Register ("mAmountStretch")]
			protected float MAmountStretch {
				get {
					if (mAmountStretch_jfieldId == IntPtr.Zero)
						mAmountStretch_jfieldId = JNIEnv.GetFieldID (class_ref, "mAmountStretch", "F");
					return JNIEnv.GetFloatField (Handle, mAmountStretch_jfieldId);
				}
				set {
					if (mAmountStretch_jfieldId == IntPtr.Zero)
						mAmountStretch_jfieldId = JNIEnv.GetFieldID (class_ref, "mAmountStretch", "F");
					JNIEnv.SetField (Handle, mAmountStretch_jfieldId, value);
				}
			}

			static IntPtr mStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/field[@name='mStart']"
			[Register ("mStart")]
			protected float MStart {
				get {
					if (mStart_jfieldId == IntPtr.Zero)
						mStart_jfieldId = JNIEnv.GetFieldID (class_ref, "mStart", "F");
					return JNIEnv.GetFloatField (Handle, mStart_jfieldId);
				}
				set {
					if (mStart_jfieldId == IntPtr.Zero)
						mStart_jfieldId = JNIEnv.GetFieldID (class_ref, "mStart", "F");
					JNIEnv.SetField (Handle, mStart_jfieldId, value);
				}
			}

			static IntPtr mStepIncrement_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/field[@name='mStepIncrement']"
			[Register ("mStepIncrement")]
			protected float MStepIncrement {
				get {
					if (mStepIncrement_jfieldId == IntPtr.Zero)
						mStepIncrement_jfieldId = JNIEnv.GetFieldID (class_ref, "mStepIncrement", "F");
					return JNIEnv.GetFloatField (Handle, mStepIncrement_jfieldId);
				}
				set {
					if (mStepIncrement_jfieldId == IntPtr.Zero)
						mStepIncrement_jfieldId = JNIEnv.GetFieldID (class_ref, "mStepIncrement", "F");
					JNIEnv.SetField (Handle, mStepIncrement_jfieldId, value);
				}
			}

			static IntPtr mYOffset_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/field[@name='mYOffset']"
			[Register ("mYOffset")]
			protected float MYOffset {
				get {
					if (mYOffset_jfieldId == IntPtr.Zero)
						mYOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mYOffset", "F");
					return JNIEnv.GetFloatField (Handle, mYOffset_jfieldId);
				}
				set {
					if (mYOffset_jfieldId == IntPtr.Zero)
						mYOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "mYOffset", "F");
					JNIEnv.SetField (Handle, mYOffset_jfieldId, value);
				}
			}

			public static class InterfaceConsts {

				// The following are fields from: org.osmdroid.views.util.constants.MathConstants

				// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='DEG2RAD']"
				[Register ("DEG2RAD")]
				public const float Deg2rad = (float) 0.017453;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI']"
				[Register ("PI")]
				public const float Pi = (float) 3.141593;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_2']"
				[Register ("PI_2")]
				public const float Pi2 = (float) 1.570796;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_4']"
				[Register ("PI_4")]
				public const float Pi4 = (float) 0.785398;

				// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='RAD2DEG']"
				[Register ("RAD2DEG")]
				public const float Rad2deg = (float) 57.295780;
			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$CosinusalBasedAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CosinusalBasedAnimationRunner); }
			}

			protected CosinusalBasedAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIIIFFF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/constructor[@name='MapControllerOld.CosinusalBasedAnimationRunner' and count(parameter)=8 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIIIFFF)V", "")]
			public CosinusalBasedAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4, float p5, float p6, float p7) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CosinusalBasedAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIIIFFF)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIIIFFF)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIIIFFF == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIIIFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIIIFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIIIFFF, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIIIFFF, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5), new JValue (p6), new JValue (p7));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIFFF;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/constructor[@name='MapControllerOld.CosinusalBasedAnimationRunner' and count(parameter)=6 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIFFF)V", "")]
			public CosinusalBasedAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, float p3, float p4, float p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (CosinusalBasedAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIFFF)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIFFF)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIFFF == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIFFF, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIFFF, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			}

			static Delegate cb_onRunAnimation;
#pragma warning disable 0169
			static Delegate GetOnRunAnimationHandler ()
			{
				if (cb_onRunAnimation == null)
					cb_onRunAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRunAnimation);
				return cb_onRunAnimation;
			}

			static void n_OnRunAnimation (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.MapControllerOld.CosinusalBasedAnimationRunner __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.CosinusalBasedAnimationRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRunAnimation ();
			}
#pragma warning restore 0169

			static IntPtr id_onRunAnimation;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.CosinusalBasedAnimationRunner']/method[@name='onRunAnimation' and count(parameter)=0]"
			[Register ("onRunAnimation", "()V", "GetOnRunAnimationHandler")]
			public override void OnRunAnimation ()
			{
				if (id_onRunAnimation == IntPtr.Zero)
					id_onRunAnimation = JNIEnv.GetMethodID (class_ref, "onRunAnimation", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRunAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRunAnimation", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$ExponentialDeceleratingAnimationRunner", DoNotGenerateAcw=true)]
		public partial class ExponentialDeceleratingAnimationRunner : global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$ExponentialDeceleratingAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExponentialDeceleratingAnimationRunner); }
			}

			protected ExponentialDeceleratingAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			public ExponentialDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ExponentialDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			public ExponentialDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ExponentialDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onRunAnimation;
#pragma warning disable 0169
			static Delegate GetOnRunAnimationHandler ()
			{
				if (cb_onRunAnimation == null)
					cb_onRunAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRunAnimation);
				return cb_onRunAnimation;
			}

			static void n_OnRunAnimation (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.MapControllerOld.ExponentialDeceleratingAnimationRunner __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.ExponentialDeceleratingAnimationRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRunAnimation ();
			}
#pragma warning restore 0169

			static IntPtr id_onRunAnimation;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.ExponentialDeceleratingAnimationRunner']/method[@name='onRunAnimation' and count(parameter)=0]"
			[Register ("onRunAnimation", "()V", "GetOnRunAnimationHandler")]
			public override void OnRunAnimation ()
			{
				if (id_onRunAnimation == IntPtr.Zero)
					id_onRunAnimation = JNIEnv.GetMethodID (class_ref, "onRunAnimation", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRunAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRunAnimation", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.HalfCosinusalDeceleratingAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$HalfCosinusalDeceleratingAnimationRunner", DoNotGenerateAcw=true)]
		protected internal partial class HalfCosinusalDeceleratingAnimationRunner : global::Osmdroid.Views.MapControllerOld.CosinusalBasedAnimationRunner {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$HalfCosinusalDeceleratingAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HalfCosinusalDeceleratingAnimationRunner); }
			}

			protected HalfCosinusalDeceleratingAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.HalfCosinusalDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.HalfCosinusalDeceleratingAnimationRunner' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			protected HalfCosinusalDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (HalfCosinusalDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.HalfCosinusalDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.HalfCosinusalDeceleratingAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			protected HalfCosinusalDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (HalfCosinusalDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$LinearAnimationRunner", DoNotGenerateAcw=true)]
		public partial class LinearAnimationRunner : global::Osmdroid.Views.MapControllerOld.AbstractAnimationRunner {


			static IntPtr mPanPerStepLatitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']/field[@name='mPanPerStepLatitudeE6']"
			[Register ("mPanPerStepLatitudeE6")]
			protected int MPanPerStepLatitudeE6 {
				get {
					if (mPanPerStepLatitudeE6_jfieldId == IntPtr.Zero)
						mPanPerStepLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanPerStepLatitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mPanPerStepLatitudeE6_jfieldId);
				}
				set {
					if (mPanPerStepLatitudeE6_jfieldId == IntPtr.Zero)
						mPanPerStepLatitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanPerStepLatitudeE6", "I");
					JNIEnv.SetField (Handle, mPanPerStepLatitudeE6_jfieldId, value);
				}
			}

			static IntPtr mPanPerStepLongitudeE6_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']/field[@name='mPanPerStepLongitudeE6']"
			[Register ("mPanPerStepLongitudeE6")]
			protected int MPanPerStepLongitudeE6 {
				get {
					if (mPanPerStepLongitudeE6_jfieldId == IntPtr.Zero)
						mPanPerStepLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanPerStepLongitudeE6", "I");
					return JNIEnv.GetIntField (Handle, mPanPerStepLongitudeE6_jfieldId);
				}
				set {
					if (mPanPerStepLongitudeE6_jfieldId == IntPtr.Zero)
						mPanPerStepLongitudeE6_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanPerStepLongitudeE6", "I");
					JNIEnv.SetField (Handle, mPanPerStepLongitudeE6_jfieldId, value);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$LinearAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LinearAnimationRunner); }
			}

			protected LinearAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']/constructor[@name='MapControllerOld.LinearAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			public LinearAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LinearAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']/constructor[@name='MapControllerOld.LinearAnimationRunner' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			public LinearAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LinearAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static Delegate cb_onRunAnimation;
#pragma warning disable 0169
			static Delegate GetOnRunAnimationHandler ()
			{
				if (cb_onRunAnimation == null)
					cb_onRunAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRunAnimation);
				return cb_onRunAnimation;
			}

			static void n_OnRunAnimation (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.MapControllerOld.LinearAnimationRunner __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.LinearAnimationRunner> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnRunAnimation ();
			}
#pragma warning restore 0169

			static IntPtr id_onRunAnimation;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.LinearAnimationRunner']/method[@name='onRunAnimation' and count(parameter)=0]"
			[Register ("onRunAnimation", "()V", "GetOnRunAnimationHandler")]
			public override void OnRunAnimation ()
			{
				if (id_onRunAnimation == IntPtr.Zero)
					id_onRunAnimation = JNIEnv.GetMethodID (class_ref, "onRunAnimation", "()V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onRunAnimation);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRunAnimation", "()V"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.MiddlePeakSpeedAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$MiddlePeakSpeedAnimationRunner", DoNotGenerateAcw=true)]
		protected internal partial class MiddlePeakSpeedAnimationRunner : global::Osmdroid.Views.MapControllerOld.CosinusalBasedAnimationRunner {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$MiddlePeakSpeedAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MiddlePeakSpeedAnimationRunner); }
			}

			protected MiddlePeakSpeedAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.MiddlePeakSpeedAnimationRunner']/constructor[@name='MapControllerOld.MiddlePeakSpeedAnimationRunner' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			protected MiddlePeakSpeedAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MiddlePeakSpeedAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.MiddlePeakSpeedAnimationRunner']/constructor[@name='MapControllerOld.MiddlePeakSpeedAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			protected MiddlePeakSpeedAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MiddlePeakSpeedAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.QuarterCosinusalDeceleratingAnimationRunner']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapControllerOld$QuarterCosinusalDeceleratingAnimationRunner", DoNotGenerateAcw=true)]
		protected internal partial class QuarterCosinusalDeceleratingAnimationRunner : global::Osmdroid.Views.MapControllerOld.CosinusalBasedAnimationRunner {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld$QuarterCosinusalDeceleratingAnimationRunner", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (QuarterCosinusalDeceleratingAnimationRunner); }
			}

			protected QuarterCosinusalDeceleratingAnimationRunner (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.QuarterCosinusalDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.QuarterCosinusalDeceleratingAnimationRunner' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;II)V", "")]
			protected QuarterCosinusalDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (QuarterCosinusalDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";II)V", new JValue (__self), new JValue (p1), new JValue (p2));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_II == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_II, new JValue (__self), new JValue (p1), new JValue (p2));
			}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld.QuarterCosinusalDeceleratingAnimationRunner']/constructor[@name='MapControllerOld.QuarterCosinusalDeceleratingAnimationRunner' and count(parameter)=5 and parameter[1][@type='org.osmdroid.views.MapControllerOld'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapControllerOld;IIII)V", "")]
			protected QuarterCosinusalDeceleratingAnimationRunner (global::Osmdroid.Views.MapControllerOld __self, int p1, int p2, int p3, int p4) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (QuarterCosinusalDeceleratingAnimationRunner)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IIII)V", new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapControllerOld;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapControllerOld_IIII, new JValue (__self), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/MapControllerOld", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapControllerOld); }
		}

		protected MapControllerOld (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/constructor[@name='MapControllerOld' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;)V", "")]
		public MapControllerOld (global::Osmdroid.Views.MapView osmv) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapControllerOld)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;)V", new JValue (osmv)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;)V", new JValue (osmv));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (osmv)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (osmv));
		}

		static Delegate cb_animateTo_DD;
#pragma warning disable 0169
		static Delegate GetAnimateTo_DDHandler ()
		{
			if (cb_animateTo_DD == null)
				cb_animateTo_DD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double>) n_AnimateTo_DD);
			return cb_animateTo_DD;
		}

		static void n_AnimateTo_DD (IntPtr jnienv, IntPtr native__this, double latitude, double longitude)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (latitude, longitude);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("animateTo", "(DD)V", "GetAnimateTo_DDHandler")]
		public virtual void AnimateTo (double latitude, double longitude)
		{
			if (id_animateTo_DD == IntPtr.Zero)
				id_animateTo_DD = JNIEnv.GetMethodID (class_ref, "animateTo", "(DD)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_DD, new JValue (latitude), new JValue (longitude));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(DD)V"), new JValue (latitude), new JValue (longitude));
		}

		static Delegate cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_Handler ()
		{
			if (cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_ == null)
				cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_);
			return cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_;
		}

		static void n_AnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_ (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6, IntPtr native_aAnimationType)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (native_aAnimationType, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (aLatitudeE6, aLongitudeE6, aAnimationType);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapControllerOld.AnimationType']]"
		[Register ("animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;)V", "GetAnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_Handler")]
		public virtual void AnimateTo (int aLatitudeE6, int aLongitudeE6, global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType)
		{
			if (id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_ == IntPtr.Zero)
				id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_, new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAnimationType));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;)V"), new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAnimationType));
		}

		static Delegate cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II;
#pragma warning disable 0169
		static Delegate GetAnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_IIHandler ()
		{
			if (cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II == null)
				cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, int, int>) n_AnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II);
			return cb_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II;
		}

		static void n_AnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6, IntPtr native_aAnimationType, int aSmoothness, int aDuration)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (native_aAnimationType, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (aLatitudeE6, aLongitudeE6, aAnimationType, aSmoothness, aDuration);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.views.MapControllerOld.AnimationType'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;II)V", "GetAnimateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_IIHandler")]
		public virtual void AnimateTo (int aLatitudeE6, int aLongitudeE6, global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType, int aSmoothness, int aDuration)
		{
			if (id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II == IntPtr.Zero)
				id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II = JNIEnv.GetMethodID (class_ref, "animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_IILorg_osmdroid_views_MapControllerOld_AnimationType_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAnimationType), new JValue (aSmoothness), new JValue (aDuration));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(IILorg/osmdroid/views/MapControllerOld$AnimationType;II)V"), new JValue (aLatitudeE6), new JValue (aLongitudeE6), new JValue (aAnimationType), new JValue (aSmoothness), new JValue (aDuration));
		}

		static Delegate cb_animateTo_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_animateTo_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_animateTo_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lorg_osmdroid_api_IGeoPoint_);
			return cb_animateTo_Lorg_osmdroid_api_IGeoPoint_;
		}

		static void n_AnimateTo_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint point = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (point);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("animateTo", "(Lorg/osmdroid/api/IGeoPoint;)V", "GetAnimateTo_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual void AnimateTo (global::Osmdroid.Api.IGeoPoint point)
		{
			if (id_animateTo_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_animateTo_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lorg/osmdroid/api/IGeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lorg_osmdroid_api_IGeoPoint_, new JValue (point));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lorg/osmdroid/api/IGeoPoint;)V"), new JValue (point));
		}

		static Delegate cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_Handler ()
		{
			if (cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_ == null)
				cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_);
			return cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_;
		}

		static void n_AnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gp, IntPtr native_aAnimationType)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint gp = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_gp, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (native_aAnimationType, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (gp, aAnimationType);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.views.MapControllerOld.AnimationType']]"
		[Register ("animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;)V", "GetAnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_Handler")]
		public virtual void AnimateTo (global::Osmdroid.Util.GeoPoint gp, global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType)
		{
			if (id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_ == IntPtr.Zero)
				id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_, new JValue (gp), new JValue (aAnimationType));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;)V"), new JValue (gp), new JValue (aAnimationType));
		}

		static Delegate cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_IIHandler ()
		{
			if (cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II == null)
				cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_AnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II);
			return cb_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II;
		}

		static void n_AnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II (IntPtr jnienv, IntPtr native__this, IntPtr native_gp, IntPtr native_aAnimationType, int aSmoothness, int aDuration)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint gp = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_gp, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld.AnimationType> (native_aAnimationType, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (gp, aAnimationType, aSmoothness, aDuration);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='animateTo' and count(parameter)=4 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.views.MapControllerOld.AnimationType'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;II)V", "GetAnimateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_IIHandler")]
		public virtual void AnimateTo (global::Osmdroid.Util.GeoPoint gp, global::Osmdroid.Views.MapControllerOld.AnimationType aAnimationType, int aSmoothness, int aDuration)
		{
			if (id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II == IntPtr.Zero)
				id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_views_MapControllerOld_AnimationType_II, new JValue (gp), new JValue (aAnimationType), new JValue (aSmoothness), new JValue (aDuration));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/views/MapControllerOld$AnimationType;II)V"), new JValue (gp), new JValue (aAnimationType), new JValue (aSmoothness), new JValue (aDuration));
		}

		static Delegate cb_scrollBy_II;
#pragma warning disable 0169
		static Delegate GetScrollBy_IIHandler ()
		{
			if (cb_scrollBy_II == null)
				cb_scrollBy_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ScrollBy_II);
			return cb_scrollBy_II;
		}

		static void n_ScrollBy_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_scrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollBy", "(II)V", "GetScrollBy_IIHandler")]
		public virtual void ScrollBy (int x, int y)
		{
			if (id_scrollBy_II == IntPtr.Zero)
				id_scrollBy_II = JNIEnv.GetMethodID (class_ref, "scrollBy", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_scrollBy_II, new JValue (x), new JValue (y));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scrollBy", "(II)V"), new JValue (x), new JValue (y));
		}

		static Delegate cb_setCenter_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_setCenter_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_setCenter_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lorg_osmdroid_api_IGeoPoint_);
			return cb_setCenter_Lorg_osmdroid_api_IGeoPoint_;
		}

		static void n_SetCenter_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint point = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (point);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("setCenter", "(Lorg/osmdroid/api/IGeoPoint;)V", "GetSetCenter_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual void SetCenter (global::Osmdroid.Api.IGeoPoint point)
		{
			if (id_setCenter_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_setCenter_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lorg/osmdroid/api/IGeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCenter_Lorg_osmdroid_api_IGeoPoint_, new JValue (point));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenter", "(Lorg/osmdroid/api/IGeoPoint;)V"), new JValue (point));
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static int n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int zoomlevel)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetZoom (zoomlevel);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoom", "(I)I", "GetSetZoom_IHandler")]
		public virtual int SetZoom (int zoomlevel)
		{
			if (id_setZoom_I == IntPtr.Zero)
				id_setZoom_I = JNIEnv.GetMethodID (class_ref, "setZoom", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_setZoom_I, new JValue (zoomlevel));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(I)I"), new JValue (zoomlevel));
		}

		static Delegate cb_stopAnimation_Z;
#pragma warning disable 0169
		static Delegate GetStopAnimation_ZHandler ()
		{
			if (cb_stopAnimation_Z == null)
				cb_stopAnimation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StopAnimation_Z);
			return cb_stopAnimation_Z;
		}

		static void n_StopAnimation_Z (IntPtr jnienv, IntPtr native__this, bool jumpToTarget)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation (jumpToTarget);
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='stopAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopAnimation", "(Z)V", "GetStopAnimation_ZHandler")]
		public virtual void StopAnimation (bool jumpToTarget)
		{
			if (id_stopAnimation_Z == IntPtr.Zero)
				id_stopAnimation_Z = JNIEnv.GetMethodID (class_ref, "stopAnimation", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopAnimation_Z, new JValue (jumpToTarget));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAnimation", "(Z)V"), new JValue (jumpToTarget));
		}

		static Delegate cb_stopPanning;
#pragma warning disable 0169
		static Delegate GetStopPanningHandler ()
		{
			if (cb_stopPanning == null)
				cb_stopPanning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPanning);
			return cb_stopPanning;
		}

		static void n_StopPanning (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPanning ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='stopPanning' and count(parameter)=0]"
		[Register ("stopPanning", "()V", "GetStopPanningHandler")]
		public virtual void StopPanning ()
		{
			if (id_stopPanning == IntPtr.Zero)
				id_stopPanning = JNIEnv.GetMethodID (class_ref, "stopPanning", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopPanning);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopPanning", "()V"));
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomIn);
			return cb_zoomIn;
		}

		static bool n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Z", "GetZoomInHandler")]
		public virtual bool ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_zoomIn);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomIn", "()Z"));
		}

		static Delegate cb_zoomInFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomInFixing_IIHandler ()
		{
			if (cb_zoomInFixing_II == null)
				cb_zoomInFixing_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_ZoomInFixing_II);
			return cb_zoomInFixing_II;
		}

		static bool n_ZoomInFixing_II (IntPtr jnienv, IntPtr native__this, int xPixel, int yPixel)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		static IntPtr id_zoomInFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomInFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomInFixing", "(II)Z", "GetZoomInFixing_IIHandler")]
		public virtual bool ZoomInFixing (int xPixel, int yPixel)
		{
			if (id_zoomInFixing_II == IntPtr.Zero)
				id_zoomInFixing_II = JNIEnv.GetMethodID (class_ref, "zoomInFixing", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_zoomInFixing_II, new JValue (xPixel), new JValue (yPixel));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomInFixing", "(II)Z"), new JValue (xPixel), new JValue (yPixel));
		}

		static Delegate cb_zoomInFixing_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetZoomInFixing_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_zoomInFixing_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_zoomInFixing_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ZoomInFixing_Lorg_osmdroid_util_GeoPoint_);
			return cb_zoomInFixing_Lorg_osmdroid_util_GeoPoint_;
		}

		static bool n_ZoomInFixing_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint point = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ZoomInFixing (point);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_zoomInFixing_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomInFixing' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("zoomInFixing", "(Lorg/osmdroid/util/GeoPoint;)Z", "GetZoomInFixing_Lorg_osmdroid_util_GeoPoint_Handler")]
		public virtual bool ZoomInFixing (global::Osmdroid.Util.GeoPoint point)
		{
			if (id_zoomInFixing_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_zoomInFixing_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "zoomInFixing", "(Lorg/osmdroid/util/GeoPoint;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_zoomInFixing_Lorg_osmdroid_util_GeoPoint_, new JValue (point));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomInFixing", "(Lorg/osmdroid/util/GeoPoint;)Z"), new JValue (point));
			return __ret;
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomOut);
			return cb_zoomOut;
		}

		static bool n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Z", "GetZoomOutHandler")]
		public virtual bool ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_zoomOut);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOut", "()Z"));
		}

		static Delegate cb_zoomOutFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomOutFixing_IIHandler ()
		{
			if (cb_zoomOutFixing_II == null)
				cb_zoomOutFixing_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_ZoomOutFixing_II);
			return cb_zoomOutFixing_II;
		}

		static bool n_ZoomOutFixing_II (IntPtr jnienv, IntPtr native__this, int xPixel, int yPixel)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOutFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		static IntPtr id_zoomOutFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomOutFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomOutFixing", "(II)Z", "GetZoomOutFixing_IIHandler")]
		public virtual bool ZoomOutFixing (int xPixel, int yPixel)
		{
			if (id_zoomOutFixing_II == IntPtr.Zero)
				id_zoomOutFixing_II = JNIEnv.GetMethodID (class_ref, "zoomOutFixing", "(II)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_zoomOutFixing_II, new JValue (xPixel), new JValue (yPixel));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOutFixing", "(II)Z"), new JValue (xPixel), new JValue (yPixel));
		}

		static Delegate cb_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetZoomOutFixing_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ZoomOutFixing_Lorg_osmdroid_util_GeoPoint_);
			return cb_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_;
		}

		static bool n_ZoomOutFixing_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint point = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ZoomOutFixing (point);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomOutFixing' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("zoomOutFixing", "(Lorg/osmdroid/util/GeoPoint;)Z", "GetZoomOutFixing_Lorg_osmdroid_util_GeoPoint_Handler")]
		public virtual bool ZoomOutFixing (global::Osmdroid.Util.GeoPoint point)
		{
			if (id_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "zoomOutFixing", "(Lorg/osmdroid/util/GeoPoint;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_zoomOutFixing_Lorg_osmdroid_util_GeoPoint_, new JValue (point));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomOutFixing", "(Lorg/osmdroid/util/GeoPoint;)Z"), new JValue (point));
			return __ret;
		}

		static Delegate cb_zoomToSpan_II;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_IIHandler ()
		{
			if (cb_zoomToSpan_II == null)
				cb_zoomToSpan_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomToSpan_II);
			return cb_zoomToSpan_II;
		}

		static void n_ZoomToSpan_II (IntPtr jnienv, IntPtr native__this, int reqLatSpan, int reqLonSpan)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (reqLatSpan, reqLonSpan);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomToSpan", "(II)V", "GetZoomToSpan_IIHandler")]
		public virtual void ZoomToSpan (int reqLatSpan, int reqLonSpan)
		{
			if (id_zoomToSpan_II == IntPtr.Zero)
				id_zoomToSpan_II = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan_II, new JValue (reqLatSpan), new JValue (reqLonSpan));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "(II)V"), new JValue (reqLatSpan), new JValue (reqLonSpan));
		}

		static Delegate cb_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_Handler ()
		{
			if (cb_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_ == null)
				cb_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ZoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_);
			return cb_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_;
		}

		static void n_ZoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bb)
		{
			global::Osmdroid.Views.MapControllerOld __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapControllerOld> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.BoundingBoxE6 bb = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.BoundingBoxE6> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (bb);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapControllerOld']/method[@name='zoomToSpan' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6']]"
		[Register ("zoomToSpan", "(Lorg/osmdroid/util/BoundingBoxE6;)V", "GetZoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_Handler")]
		public virtual void ZoomToSpan (global::Osmdroid.Util.BoundingBoxE6 bb)
		{
			if (id_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_ == IntPtr.Zero)
				id_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_ = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(Lorg/osmdroid/util/BoundingBoxE6;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_, new JValue (bb));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "(Lorg/osmdroid/util/BoundingBoxE6;)V"), new JValue (bb));
		}

	}
}
