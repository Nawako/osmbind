using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']"
	[global::Android.Runtime.Register ("org/osmdroid/views/MapController", DoNotGenerateAcw=true)]
	public partial class MapController : global::Java.Lang.Object, global::Osmdroid.Api.IMapController {


		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/field[@name='mMapView']"
		[Register ("mMapView")]
		protected global::Osmdroid.Views.MapView MMapView {
			get {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMapView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMapView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

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

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimationListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapController$MyZoomAnimationListener", DoNotGenerateAcw=true)]
		protected internal partial class MyZoomAnimationListener : global::Java.Lang.Object, global::Android.Views.Animations.Animation.IAnimationListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapController$MyZoomAnimationListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyZoomAnimationListener); }
			}

			protected MyZoomAnimationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapController_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimationListener']/constructor[@name='MapController.MyZoomAnimationListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapController']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapController;)V", "")]
			protected MyZoomAnimationListener (global::Osmdroid.Views.MapController __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MyZoomAnimationListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapController_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapController_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapController;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self));
			}

			static Delegate cb_onAnimationEnd_Landroid_view_animation_Animation_;
#pragma warning disable 0169
			static Delegate GetOnAnimationEnd_Landroid_view_animation_Animation_Handler ()
			{
				if (cb_onAnimationEnd_Landroid_view_animation_Animation_ == null)
					cb_onAnimationEnd_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Landroid_view_animation_Animation_);
				return cb_onAnimationEnd_Landroid_view_animation_Animation_;
			}

			static void n_OnAnimationEnd_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				global::Osmdroid.Views.MapController.MyZoomAnimationListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController.MyZoomAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd (animation);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationEnd_Landroid_view_animation_Animation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimationListener']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
			[Register ("onAnimationEnd", "(Landroid/view/animation/Animation;)V", "GetOnAnimationEnd_Landroid_view_animation_Animation_Handler")]
			public virtual void OnAnimationEnd (global::Android.Views.Animations.Animation animation)
			{
				if (id_onAnimationEnd_Landroid_view_animation_Animation_ == IntPtr.Zero)
					id_onAnimationEnd_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "(Landroid/view/animation/Animation;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationEnd_Landroid_view_animation_Animation_, new JValue (animation));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationEnd", "(Landroid/view/animation/Animation;)V"), new JValue (animation));
			}

			static Delegate cb_onAnimationRepeat_Landroid_view_animation_Animation_;
#pragma warning disable 0169
			static Delegate GetOnAnimationRepeat_Landroid_view_animation_Animation_Handler ()
			{
				if (cb_onAnimationRepeat_Landroid_view_animation_Animation_ == null)
					cb_onAnimationRepeat_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Landroid_view_animation_Animation_);
				return cb_onAnimationRepeat_Landroid_view_animation_Animation_;
			}

			static void n_OnAnimationRepeat_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				global::Osmdroid.Views.MapController.MyZoomAnimationListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController.MyZoomAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat (animation);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationRepeat_Landroid_view_animation_Animation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimationListener']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
			[Register ("onAnimationRepeat", "(Landroid/view/animation/Animation;)V", "GetOnAnimationRepeat_Landroid_view_animation_Animation_Handler")]
			public virtual void OnAnimationRepeat (global::Android.Views.Animations.Animation animation)
			{
				if (id_onAnimationRepeat_Landroid_view_animation_Animation_ == IntPtr.Zero)
					id_onAnimationRepeat_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationRepeat_Landroid_view_animation_Animation_, new JValue (animation));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationRepeat", "(Landroid/view/animation/Animation;)V"), new JValue (animation));
			}

			static Delegate cb_onAnimationStart_Landroid_view_animation_Animation_;
#pragma warning disable 0169
			static Delegate GetOnAnimationStart_Landroid_view_animation_Animation_Handler ()
			{
				if (cb_onAnimationStart_Landroid_view_animation_Animation_ == null)
					cb_onAnimationStart_Landroid_view_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Landroid_view_animation_Animation_);
				return cb_onAnimationStart_Landroid_view_animation_Animation_;
			}

			static void n_OnAnimationStart_Landroid_view_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				global::Osmdroid.Views.MapController.MyZoomAnimationListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController.MyZoomAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.Animations.Animation animation = global::Java.Lang.Object.GetObject<global::Android.Views.Animations.Animation> (native_animation, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart (animation);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationStart_Landroid_view_animation_Animation_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimationListener']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='android.view.animation.Animation']]"
			[Register ("onAnimationStart", "(Landroid/view/animation/Animation;)V", "GetOnAnimationStart_Landroid_view_animation_Animation_Handler")]
			public virtual void OnAnimationStart (global::Android.Views.Animations.Animation animation)
			{
				if (id_onAnimationStart_Landroid_view_animation_Animation_ == IntPtr.Zero)
					id_onAnimationStart_Landroid_view_animation_Animation_ = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "(Landroid/view/animation/Animation;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationStart_Landroid_view_animation_Animation_, new JValue (animation));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationStart", "(Landroid/view/animation/Animation;)V"), new JValue (animation));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimatorListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapController$MyZoomAnimatorListener", DoNotGenerateAcw=true)]
		protected internal partial class MyZoomAnimatorListener : global::Android.Animation.AnimatorListenerAdapter {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapController$MyZoomAnimatorListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyZoomAnimatorListener); }
			}

			protected MyZoomAnimatorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapController_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimatorListener']/constructor[@name='MapController.MyZoomAnimatorListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapController']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapController;)V", "")]
			protected MyZoomAnimatorListener (global::Osmdroid.Views.MapController __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MyZoomAnimatorListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapController_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapController_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapController;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimatorUpdateListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapController$MyZoomAnimatorUpdateListener", DoNotGenerateAcw=true)]
		protected internal partial class MyZoomAnimatorUpdateListener : global::Java.Lang.Object, global::Android.Animation.ValueAnimator.IAnimatorUpdateListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapController$MyZoomAnimatorUpdateListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyZoomAnimatorUpdateListener); }
			}

			protected MyZoomAnimatorUpdateListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_views_MapController_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimatorUpdateListener']/constructor[@name='MapController.MyZoomAnimatorUpdateListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapController']]"
			[Register (".ctor", "(Lorg/osmdroid/views/MapController;)V", "")]
			protected MyZoomAnimatorUpdateListener (global::Osmdroid.Views.MapController __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (MyZoomAnimatorUpdateListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", new JValue (__self));
					return;
				}

				if (id_ctor_Lorg_osmdroid_views_MapController_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_views_MapController_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapController;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapController_, new JValue (__self));
			}

			static Delegate cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
#pragma warning disable 0169
			static Delegate GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler ()
			{
				if (cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ == null)
					cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationUpdate_Landroid_animation_ValueAnimator_);
				return cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
			}

			static void n_OnAnimationUpdate_Landroid_animation_ValueAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				global::Osmdroid.Views.MapController.MyZoomAnimatorUpdateListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController.MyZoomAnimatorUpdateListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Animation.ValueAnimator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (native_animation, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationUpdate (animation);
			}
#pragma warning restore 0169

			static IntPtr id_onAnimationUpdate_Landroid_animation_ValueAnimator_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController.MyZoomAnimatorUpdateListener']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='android.animation.ValueAnimator']]"
			[Register ("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler")]
			public virtual void OnAnimationUpdate (global::Android.Animation.ValueAnimator animation)
			{
				if (id_onAnimationUpdate_Landroid_animation_ValueAnimator_ == IntPtr.Zero)
					id_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNIEnv.GetMethodID (class_ref, "onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onAnimationUpdate_Landroid_animation_ValueAnimator_, new JValue (animation));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V"), new JValue (animation));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/MapController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapController); }
		}

		protected MapController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/constructor[@name='MapController' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;)V", "")]
		public MapController (global::Osmdroid.Views.MapView mapView) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;)V", new JValue (mapView)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;)V", new JValue (mapView));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (mapView)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (mapView));
		}

		static Delegate cb_animateTo_II;
#pragma warning disable 0169
		static Delegate GetAnimateTo_IIHandler ()
		{
			if (cb_animateTo_II == null)
				cb_animateTo_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AnimateTo_II);
			return cb_animateTo_II;
		}

		static void n_AnimateTo_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("animateTo", "(II)V", "GetAnimateTo_IIHandler")]
		public virtual void AnimateTo (int x, int y)
		{
			if (id_animateTo_II == IntPtr.Zero)
				id_animateTo_II = JNIEnv.GetMethodID (class_ref, "animateTo", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_animateTo_II, new JValue (x), new JValue (y));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "animateTo", "(II)V"), new JValue (x), new JValue (y));
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint point = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (point);
		}
#pragma warning restore 0169

		static IntPtr id_animateTo_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
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

		static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
		static Delegate GetOnAnimationEndHandler ()
		{
			if (cb_onAnimationEnd == null)
				cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
			return cb_onAnimationEnd;
		}

		static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='onAnimationEnd' and count(parameter)=0]"
		[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler")]
		protected virtual void OnAnimationEnd ()
		{
			if (id_onAnimationEnd == IntPtr.Zero)
				id_onAnimationEnd = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAnimationEnd);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationEnd", "()V"));
		}

		static Delegate cb_onAnimationStart;
#pragma warning disable 0169
		static Delegate GetOnAnimationStartHandler ()
		{
			if (cb_onAnimationStart == null)
				cb_onAnimationStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationStart);
			return cb_onAnimationStart;
		}

		static void n_OnAnimationStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart ();
		}
#pragma warning restore 0169

		static IntPtr id_onAnimationStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='onAnimationStart' and count(parameter)=0]"
		[Register ("onAnimationStart", "()V", "GetOnAnimationStartHandler")]
		protected virtual void OnAnimationStart ()
		{
			if (id_onAnimationStart == IntPtr.Zero)
				id_onAnimationStart = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onAnimationStart);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAnimationStart", "()V"));
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_scrollBy_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint point = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (point);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetZoom (zoomlevel);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation (jumpToTarget);
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='stopAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPanning ();
		}
#pragma warning restore 0169

		static IntPtr id_stopPanning;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='stopPanning' and count(parameter)=0]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomIn' and count(parameter)=0]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		static IntPtr id_zoomInFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomInFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_zoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomOut' and count(parameter)=0]"
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOutFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		static IntPtr id_zoomOutFixing_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomOutFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_zoomToSpan_II;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_IIHandler ()
		{
			if (cb_zoomToSpan_II == null)
				cb_zoomToSpan_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomToSpan_II);
			return cb_zoomToSpan_II;
		}

		static void n_ZoomToSpan_II (IntPtr jnienv, IntPtr native__this, int latSpanE6, int lonSpanE6)
		{
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (latSpanE6, lonSpanE6);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomToSpan", "(II)V", "GetZoomToSpan_IIHandler")]
		public virtual void ZoomToSpan (int latSpanE6, int lonSpanE6)
		{
			if (id_zoomToSpan_II == IntPtr.Zero)
				id_zoomToSpan_II = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToSpan_II, new JValue (latSpanE6), new JValue (lonSpanE6));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToSpan", "(II)V"), new JValue (latSpanE6), new JValue (lonSpanE6));
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
			global::Osmdroid.Views.MapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 bb = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_bb, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (bb);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapController']/method[@name='zoomToSpan' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6']]"
		[Register ("zoomToSpan", "(Lorg/osmdroid/util/BoundingBoxE6;)V", "GetZoomToSpan_Lorg_osmdroid_util_BoundingBoxE6_Handler")]
		public virtual void ZoomToSpan (global::Org.Osmdroid.Util.BoundingBoxE6 bb)
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
