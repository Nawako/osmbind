using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']"
	[global::Android.Runtime.Register ("org/osmdroid/views/Projection", DoNotGenerateAcw=true)]
	public partial class Projection : global::Java.Lang.Object, global::Osmdroid.Api.IProjection {


		static IntPtr mMultiTouchScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/field[@name='mMultiTouchScale']"
		[Register ("mMultiTouchScale")]
		protected float MMultiTouchScale {
			get {
				if (mMultiTouchScale_jfieldId == IntPtr.Zero)
					mMultiTouchScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiTouchScale", "F");
				return JNIEnv.GetFloatField (Handle, mMultiTouchScale_jfieldId);
			}
			set {
				if (mMultiTouchScale_jfieldId == IntPtr.Zero)
					mMultiTouchScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiTouchScale", "F");
				JNIEnv.SetField (Handle, mMultiTouchScale_jfieldId, value);
			}
		}

		static IntPtr mOffsetX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/field[@name='mOffsetX']"
		[Register ("mOffsetX")]
		protected int MOffsetX {
			get {
				if (mOffsetX_jfieldId == IntPtr.Zero)
					mOffsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "mOffsetX", "I");
				return JNIEnv.GetIntField (Handle, mOffsetX_jfieldId);
			}
			set {
				if (mOffsetX_jfieldId == IntPtr.Zero)
					mOffsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "mOffsetX", "I");
				JNIEnv.SetField (Handle, mOffsetX_jfieldId, value);
			}
		}

		static IntPtr mOffsetY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/field[@name='mOffsetY']"
		[Register ("mOffsetY")]
		protected int MOffsetY {
			get {
				if (mOffsetY_jfieldId == IntPtr.Zero)
					mOffsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "mOffsetY", "I");
				return JNIEnv.GetIntField (Handle, mOffsetY_jfieldId);
			}
			set {
				if (mOffsetY_jfieldId == IntPtr.Zero)
					mOffsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "mOffsetY", "I");
				JNIEnv.SetField (Handle, mOffsetY_jfieldId, value);
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

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/Projection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Projection); }
		}

		protected Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBoundingBox;
#pragma warning disable 0169
		static Delegate GetGetBoundingBoxHandler ()
		{
			if (cb_getBoundingBox == null)
				cb_getBoundingBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoundingBox);
			return cb_getBoundingBox;
		}

		static IntPtr n_GetBoundingBox (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BoundingBox);
		}
#pragma warning restore 0169

		static IntPtr id_getBoundingBox;
		public virtual global::Org.Osmdroid.Util.BoundingBoxE6 BoundingBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getBoundingBox' and count(parameter)=0]"
			[Register ("getBoundingBox", "()Lorg/osmdroid/util/BoundingBoxE6;", "GetGetBoundingBoxHandler")]
			get {
				if (id_getBoundingBox == IntPtr.Zero)
					id_getBoundingBox = JNIEnv.GetMethodID (class_ref, "getBoundingBox", "()Lorg/osmdroid/util/BoundingBoxE6;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallObjectMethod  (Handle, id_getBoundingBox), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoundingBox", "()Lorg/osmdroid/util/BoundingBoxE6;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIntrinsicScreenRect;
#pragma warning disable 0169
		static Delegate GetGetIntrinsicScreenRectHandler ()
		{
			if (cb_getIntrinsicScreenRect == null)
				cb_getIntrinsicScreenRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntrinsicScreenRect);
			return cb_getIntrinsicScreenRect;
		}

		static IntPtr n_GetIntrinsicScreenRect (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IntrinsicScreenRect);
		}
#pragma warning restore 0169

		static IntPtr id_getIntrinsicScreenRect;
		public virtual global::Android.Graphics.Rect IntrinsicScreenRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getIntrinsicScreenRect' and count(parameter)=0]"
			[Register ("getIntrinsicScreenRect", "()Landroid/graphics/Rect;", "GetGetIntrinsicScreenRectHandler")]
			get {
				if (id_getIntrinsicScreenRect == IntPtr.Zero)
					id_getIntrinsicScreenRect = JNIEnv.GetMethodID (class_ref, "getIntrinsicScreenRect", "()Landroid/graphics/Rect;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getIntrinsicScreenRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntrinsicScreenRect", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInvertedScaleRotateCanvasMatrix;
#pragma warning disable 0169
		static Delegate GetGetInvertedScaleRotateCanvasMatrixHandler ()
		{
			if (cb_getInvertedScaleRotateCanvasMatrix == null)
				cb_getInvertedScaleRotateCanvasMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInvertedScaleRotateCanvasMatrix);
			return cb_getInvertedScaleRotateCanvasMatrix;
		}

		static IntPtr n_GetInvertedScaleRotateCanvasMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvertedScaleRotateCanvasMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getInvertedScaleRotateCanvasMatrix;
		public virtual global::Android.Graphics.Matrix InvertedScaleRotateCanvasMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getInvertedScaleRotateCanvasMatrix' and count(parameter)=0]"
			[Register ("getInvertedScaleRotateCanvasMatrix", "()Landroid/graphics/Matrix;", "GetGetInvertedScaleRotateCanvasMatrixHandler")]
			get {
				if (id_getInvertedScaleRotateCanvasMatrix == IntPtr.Zero)
					id_getInvertedScaleRotateCanvasMatrix = JNIEnv.GetMethodID (class_ref, "getInvertedScaleRotateCanvasMatrix", "()Landroid/graphics/Matrix;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getInvertedScaleRotateCanvasMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInvertedScaleRotateCanvasMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMapOrientation;
#pragma warning disable 0169
		static Delegate GetGetMapOrientationHandler ()
		{
			if (cb_getMapOrientation == null)
				cb_getMapOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMapOrientation);
			return cb_getMapOrientation;
		}

		static float n_GetMapOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapOrientation;
		}
#pragma warning restore 0169

		static IntPtr id_getMapOrientation;
		public virtual float MapOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getMapOrientation' and count(parameter)=0]"
			[Register ("getMapOrientation", "()F", "GetGetMapOrientationHandler")]
			get {
				if (id_getMapOrientation == IntPtr.Zero)
					id_getMapOrientation = JNIEnv.GetMethodID (class_ref, "getMapOrientation", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMapOrientation);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapOrientation", "()F"));
			}
		}

		static Delegate cb_getNorthEast;
#pragma warning disable 0169
		static Delegate GetGetNorthEastHandler ()
		{
			if (cb_getNorthEast == null)
				cb_getNorthEast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNorthEast);
			return cb_getNorthEast;
		}

		static IntPtr n_GetNorthEast (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NorthEast);
		}
#pragma warning restore 0169

		static IntPtr id_getNorthEast;
		public virtual global::Osmdroid.Api.IGeoPoint NorthEast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getNorthEast' and count(parameter)=0]"
			[Register ("getNorthEast", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetNorthEastHandler")]
			get {
				if (id_getNorthEast == IntPtr.Zero)
					id_getNorthEast = JNIEnv.GetMethodID (class_ref, "getNorthEast", "()Lorg/osmdroid/api/IGeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getNorthEast), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNorthEast", "()Lorg/osmdroid/api/IGeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScreenRect;
#pragma warning disable 0169
		static Delegate GetGetScreenRectHandler ()
		{
			if (cb_getScreenRect == null)
				cb_getScreenRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScreenRect);
			return cb_getScreenRect;
		}

		static IntPtr n_GetScreenRect (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScreenRect);
		}
#pragma warning restore 0169

		static IntPtr id_getScreenRect;
		public virtual global::Android.Graphics.Rect ScreenRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getScreenRect' and count(parameter)=0]"
			[Register ("getScreenRect", "()Landroid/graphics/Rect;", "GetGetScreenRectHandler")]
			get {
				if (id_getScreenRect == IntPtr.Zero)
					id_getScreenRect = JNIEnv.GetMethodID (class_ref, "getScreenRect", "()Landroid/graphics/Rect;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getScreenRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenRect", "()Landroid/graphics/Rect;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSouthWest;
#pragma warning disable 0169
		static Delegate GetGetSouthWestHandler ()
		{
			if (cb_getSouthWest == null)
				cb_getSouthWest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthWest);
			return cb_getSouthWest;
		}

		static IntPtr n_GetSouthWest (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SouthWest);
		}
#pragma warning restore 0169

		static IntPtr id_getSouthWest;
		public virtual global::Osmdroid.Api.IGeoPoint SouthWest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getSouthWest' and count(parameter)=0]"
			[Register ("getSouthWest", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetSouthWestHandler")]
			get {
				if (id_getSouthWest == IntPtr.Zero)
					id_getSouthWest = JNIEnv.GetMethodID (class_ref, "getSouthWest", "()Lorg/osmdroid/api/IGeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getSouthWest), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSouthWest", "()Lorg/osmdroid/api/IGeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		public virtual int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "()I"));
			}
		}

		static Delegate cb_adjustForDateLine_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetAdjustForDateLine_IILandroid_graphics_Point_Handler ()
		{
			if (cb_adjustForDateLine_IILandroid_graphics_Point_ == null)
				cb_adjustForDateLine_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AdjustForDateLine_IILandroid_graphics_Point_);
			return cb_adjustForDateLine_IILandroid_graphics_Point_;
		}

		static IntPtr n_AdjustForDateLine_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AdjustForDateLine (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_adjustForDateLine_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='adjustForDateLine' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("adjustForDateLine", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetAdjustForDateLine_IILandroid_graphics_Point_Handler")]
		protected virtual global::Android.Graphics.Point AdjustForDateLine (int x, int y, global::Android.Graphics.Point reuse)
		{
			if (id_adjustForDateLine_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_adjustForDateLine_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "adjustForDateLine", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_adjustForDateLine_IILandroid_graphics_Point_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adjustForDateLine", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_fromPixels_II;
#pragma warning disable 0169
		static Delegate GetFromPixels_IIHandler ()
		{
			if (cb_fromPixels_II == null)
				cb_fromPixels_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FromPixels_II);
			return cb_fromPixels_II;
		}

		static IntPtr n_FromPixels_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromPixels (x, y));
		}
#pragma warning restore 0169

		static IntPtr id_fromPixels_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='fromPixels' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fromPixels", "(II)Lorg/osmdroid/api/IGeoPoint;", "GetFromPixels_IIHandler")]
		public virtual global::Osmdroid.Api.IGeoPoint FromPixels (int x, int y)
		{
			if (id_fromPixels_II == IntPtr.Zero)
				id_fromPixels_II = JNIEnv.GetMethodID (class_ref, "fromPixels", "(II)Lorg/osmdroid/api/IGeoPoint;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_fromPixels_II, new JValue (x), new JValue (y)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromPixels", "(II)Lorg/osmdroid/api/IGeoPoint;"), new JValue (x), new JValue (y)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fromPixels_IILorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetFromPixels_IILorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_fromPixels_IILorg_osmdroid_util_GeoPoint_ == null)
				cb_fromPixels_IILorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_FromPixels_IILorg_osmdroid_util_GeoPoint_);
			return cb_fromPixels_IILorg_osmdroid_util_GeoPoint_;
		}

		static IntPtr n_FromPixels_IILorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint reuse = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromPixels (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fromPixels_IILorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='fromPixels' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("fromPixels", "(IILorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/api/IGeoPoint;", "GetFromPixels_IILorg_osmdroid_util_GeoPoint_Handler")]
		public virtual global::Osmdroid.Api.IGeoPoint FromPixels (int x, int y, global::Org.Osmdroid.Util.GeoPoint reuse)
		{
			if (id_fromPixels_IILorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_fromPixels_IILorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "fromPixels", "(IILorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/api/IGeoPoint;");

			global::Osmdroid.Api.IGeoPoint __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_fromPixels_IILorg_osmdroid_util_GeoPoint_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fromPixels", "(IILorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/api/IGeoPoint;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_metersToEquatorPixels_F;
#pragma warning disable 0169
		static Delegate GetMetersToEquatorPixels_FHandler ()
		{
			if (cb_metersToEquatorPixels_F == null)
				cb_metersToEquatorPixels_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_MetersToEquatorPixels_F);
			return cb_metersToEquatorPixels_F;
		}

		static float n_MetersToEquatorPixels_F (IntPtr jnienv, IntPtr native__this, float meters)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToEquatorPixels (meters);
		}
#pragma warning restore 0169

		static IntPtr id_metersToEquatorPixels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='metersToEquatorPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToEquatorPixels", "(F)F", "GetMetersToEquatorPixels_FHandler")]
		public virtual float MetersToEquatorPixels (float meters)
		{
			if (id_metersToEquatorPixels_F == IntPtr.Zero)
				id_metersToEquatorPixels_F = JNIEnv.GetMethodID (class_ref, "metersToEquatorPixels", "(F)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_metersToEquatorPixels_F, new JValue (meters));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metersToEquatorPixels", "(F)F"), new JValue (meters));
		}

		static Delegate cb_metersToPixels_F;
#pragma warning disable 0169
		static Delegate GetMetersToPixels_FHandler ()
		{
			if (cb_metersToPixels_F == null)
				cb_metersToPixels_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_MetersToPixels_F);
			return cb_metersToPixels_F;
		}

		static float n_MetersToPixels_F (IntPtr jnienv, IntPtr native__this, float meters)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToPixels (meters);
		}
#pragma warning restore 0169

		static IntPtr id_metersToPixels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='metersToPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToPixels", "(F)F", "GetMetersToPixels_FHandler")]
		public virtual float MetersToPixels (float meters)
		{
			if (id_metersToPixels_F == IntPtr.Zero)
				id_metersToPixels_F = JNIEnv.GetMethodID (class_ref, "metersToPixels", "(F)F");

			if (GetType () == ThresholdType)
				return JNIEnv.CallFloatMethod  (Handle, id_metersToPixels_F, new JValue (meters));
			else
				return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "metersToPixels", "(F)F"), new JValue (meters));
		}

		static Delegate cb_rotateAndScalePoint_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetRotateAndScalePoint_IILandroid_graphics_Point_Handler ()
		{
			if (cb_rotateAndScalePoint_IILandroid_graphics_Point_ == null)
				cb_rotateAndScalePoint_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_RotateAndScalePoint_IILandroid_graphics_Point_);
			return cb_rotateAndScalePoint_IILandroid_graphics_Point_;
		}

		static IntPtr n_RotateAndScalePoint_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RotateAndScalePoint (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_rotateAndScalePoint_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='rotateAndScalePoint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("rotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetRotateAndScalePoint_IILandroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point RotateAndScalePoint (int x, int y, global::Android.Graphics.Point reuse)
		{
			if (id_rotateAndScalePoint_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_rotateAndScalePoint_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "rotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_rotateAndScalePoint_IILandroid_graphics_Point_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "rotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toMercatorPixels_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToMercatorPixels_IILandroid_graphics_Point_Handler ()
		{
			if (cb_toMercatorPixels_IILandroid_graphics_Point_ == null)
				cb_toMercatorPixels_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_ToMercatorPixels_IILandroid_graphics_Point_);
			return cb_toMercatorPixels_IILandroid_graphics_Point_;
		}

		static IntPtr n_ToMercatorPixels_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToMercatorPixels (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toMercatorPixels_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toMercatorPixels' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("toMercatorPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetToMercatorPixels_IILandroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToMercatorPixels (int x, int y, global::Android.Graphics.Point reuse)
		{
			if (id_toMercatorPixels_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_toMercatorPixels_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toMercatorPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toMercatorPixels_IILandroid_graphics_Point_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toMercatorPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_Handler ()
		{
			if (cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ == null)
				cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_);
			return cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
		}

		static IntPtr n_ToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint @in = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native__in, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixels (@in, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toPixels' and count(parameter)=2 and parameter[1][@type='org.osmdroid.api.IGeoPoint'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("toPixels", "(Lorg/osmdroid/api/IGeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToPixels (global::Osmdroid.Api.IGeoPoint @in, global::Android.Graphics.Point reuse)
		{
			if (id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ == IntPtr.Zero)
				id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toPixels", "(Lorg/osmdroid/api/IGeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_, new JValue (@in), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toPixels", "(Lorg/osmdroid/api/IGeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (@in), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toPixelsFromMercator_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixelsFromMercator_IILandroid_graphics_Point_Handler ()
		{
			if (cb_toPixelsFromMercator_IILandroid_graphics_Point_ == null)
				cb_toPixelsFromMercator_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_ToPixelsFromMercator_IILandroid_graphics_Point_);
			return cb_toPixelsFromMercator_IILandroid_graphics_Point_;
		}

		static IntPtr n_ToPixelsFromMercator_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixelsFromMercator (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toPixelsFromMercator_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toPixelsFromMercator' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("toPixelsFromMercator", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixelsFromMercator_IILandroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToPixelsFromMercator (int x, int y, global::Android.Graphics.Point reuse)
		{
			if (id_toPixelsFromMercator_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_toPixelsFromMercator_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toPixelsFromMercator", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toPixelsFromMercator_IILandroid_graphics_Point_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toPixelsFromMercator", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_Handler ()
		{
			if (cb_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_ == null)
				cb_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_);
			return cb_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_;
		}

		static IntPtr n_ToPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point @in = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native__in, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixelsFromProjected (@in, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toPixelsFromProjected' and count(parameter)=2 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("toPixelsFromProjected", "(Landroid/graphics/Point;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToPixelsFromProjected (global::Android.Graphics.Point @in, global::Android.Graphics.Point reuse)
		{
			if (id_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_ == IntPtr.Zero)
				id_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toPixelsFromProjected", "(Landroid/graphics/Point;Landroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toPixelsFromProjected_Landroid_graphics_Point_Landroid_graphics_Point_, new JValue (@in), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toPixelsFromProjected", "(Landroid/graphics/Point;Landroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (@in), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toProjectedPixels_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToProjectedPixels_IILandroid_graphics_Point_Handler ()
		{
			if (cb_toProjectedPixels_IILandroid_graphics_Point_ == null)
				cb_toProjectedPixels_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_ToProjectedPixels_IILandroid_graphics_Point_);
			return cb_toProjectedPixels_IILandroid_graphics_Point_;
		}

		static IntPtr n_ToProjectedPixels_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int latituteE6, int longitudeE6, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToProjectedPixels (latituteE6, longitudeE6, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toProjectedPixels_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toProjectedPixels' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("toProjectedPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetToProjectedPixels_IILandroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToProjectedPixels (int latituteE6, int longitudeE6, global::Android.Graphics.Point reuse)
		{
			if (id_toProjectedPixels_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_toProjectedPixels_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toProjectedPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toProjectedPixels_IILandroid_graphics_Point_, new JValue (latituteE6), new JValue (longitudeE6), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toProjectedPixels", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (latituteE6), new JValue (longitudeE6), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_Handler ()
		{
			if (cb_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_ == null)
				cb_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_);
			return cb_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_;
		}

		static IntPtr n_ToProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_geoPoint, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint geoPoint = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_geoPoint, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToProjectedPixels (geoPoint, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='toProjectedPixels' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("toProjectedPixels", "(Lorg/osmdroid/util/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point ToProjectedPixels (global::Org.Osmdroid.Util.GeoPoint geoPoint, global::Android.Graphics.Point reuse)
		{
			if (id_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_ == IntPtr.Zero)
				id_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toProjectedPixels", "(Lorg/osmdroid/util/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_toProjectedPixels_Lorg_osmdroid_util_GeoPoint_Landroid_graphics_Point_, new JValue (geoPoint), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toProjectedPixels", "(Lorg/osmdroid/util/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (geoPoint), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_unrotateAndScalePoint_IILandroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetUnrotateAndScalePoint_IILandroid_graphics_Point_Handler ()
		{
			if (cb_unrotateAndScalePoint_IILandroid_graphics_Point_ == null)
				cb_unrotateAndScalePoint_IILandroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_UnrotateAndScalePoint_IILandroid_graphics_Point_);
			return cb_unrotateAndScalePoint_IILandroid_graphics_Point_;
		}

		static IntPtr n_UnrotateAndScalePoint_IILandroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, int x, int y, IntPtr native_reuse)
		{
			global::Osmdroid.Views.Projection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UnrotateAndScalePoint (x, y, reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unrotateAndScalePoint_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='Projection']/method[@name='unrotateAndScalePoint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("unrotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "GetUnrotateAndScalePoint_IILandroid_graphics_Point_Handler")]
		public virtual global::Android.Graphics.Point UnrotateAndScalePoint (int x, int y, global::Android.Graphics.Point reuse)
		{
			if (id_unrotateAndScalePoint_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_unrotateAndScalePoint_IILandroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "unrotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_unrotateAndScalePoint_IILandroid_graphics_Point_, new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unrotateAndScalePoint", "(IILandroid/graphics/Point;)Landroid/graphics/Point;"), new JValue (x), new JValue (y), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
