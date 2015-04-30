using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']"
	[global::Android.Runtime.Register ("org/osmdroid/views/MapView", DoNotGenerateAcw=true)]
	public partial class MapView : global::Android.Views.ViewGroup, global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas, global::Osmdroid.Api.IMapView {


		static IntPtr mIsAnimating_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mIsAnimating']"
		[Register ("mIsAnimating")]
		protected global::Java.Util.Concurrent.Atomic.AtomicBoolean MIsAnimating {
			get {
				if (mIsAnimating_jfieldId == IntPtr.Zero)
					mIsAnimating_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsAnimating", "Ljava/util/concurrent/atomic/AtomicBoolean;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mIsAnimating_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicBoolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIsAnimating_jfieldId == IntPtr.Zero)
					mIsAnimating_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsAnimating", "Ljava/util/concurrent/atomic/AtomicBoolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mIsAnimating_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mIsFlinging_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mIsFlinging']"
		[Register ("mIsFlinging")]
		protected bool MIsFlinging {
			get {
				if (mIsFlinging_jfieldId == IntPtr.Zero)
					mIsFlinging_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFlinging", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsFlinging_jfieldId);
			}
			set {
				if (mIsFlinging_jfieldId == IntPtr.Zero)
					mIsFlinging_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsFlinging", "Z");
				JNIEnv.SetField (Handle, mIsFlinging_jfieldId, value);
			}
		}

		static IntPtr mListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mListener']"
		[Register ("mListener")]
		protected global::Osmdroid.Events.IMapListener MListener {
			get {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lorg/osmdroid/events/MapListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Events.IMapListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mListener_jfieldId == IntPtr.Zero)
					mListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mListener", "Lorg/osmdroid/events/MapListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMaximumZoomLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mMaximumZoomLevel']"
		[Register ("mMaximumZoomLevel")]
		protected global::Java.Lang.Integer MMaximumZoomLevel {
			get {
				if (mMaximumZoomLevel_jfieldId == IntPtr.Zero)
					mMaximumZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaximumZoomLevel", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMaximumZoomLevel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMaximumZoomLevel_jfieldId == IntPtr.Zero)
					mMaximumZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mMaximumZoomLevel", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMaximumZoomLevel_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMinimumZoomLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mMinimumZoomLevel']"
		[Register ("mMinimumZoomLevel")]
		protected global::Java.Lang.Integer MMinimumZoomLevel {
			get {
				if (mMinimumZoomLevel_jfieldId == IntPtr.Zero)
					mMinimumZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mMinimumZoomLevel", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMinimumZoomLevel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMinimumZoomLevel_jfieldId == IntPtr.Zero)
					mMinimumZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mMinimumZoomLevel", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMinimumZoomLevel_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMultiTouchScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mMultiTouchScale']"
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

		static IntPtr mMultiTouchScalePoint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mMultiTouchScalePoint']"
		[Register ("mMultiTouchScalePoint")]
		protected global::Android.Graphics.PointF MMultiTouchScalePoint {
			get {
				if (mMultiTouchScalePoint_jfieldId == IntPtr.Zero)
					mMultiTouchScalePoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiTouchScalePoint", "Landroid/graphics/PointF;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMultiTouchScalePoint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMultiTouchScalePoint_jfieldId == IntPtr.Zero)
					mMultiTouchScalePoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mMultiTouchScalePoint", "Landroid/graphics/PointF;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMultiTouchScalePoint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mScrollableAreaBoundingBox_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mScrollableAreaBoundingBox']"
		[Register ("mScrollableAreaBoundingBox")]
		protected global::Org.Osmdroid.Util.BoundingBoxE6 MScrollableAreaBoundingBox {
			get {
				if (mScrollableAreaBoundingBox_jfieldId == IntPtr.Zero)
					mScrollableAreaBoundingBox_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollableAreaBoundingBox", "Lorg/osmdroid/util/BoundingBoxE6;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mScrollableAreaBoundingBox_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mScrollableAreaBoundingBox_jfieldId == IntPtr.Zero)
					mScrollableAreaBoundingBox_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollableAreaBoundingBox", "Lorg/osmdroid/util/BoundingBoxE6;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mScrollableAreaBoundingBox_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mScrollableAreaLimit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mScrollableAreaLimit']"
		[Register ("mScrollableAreaLimit")]
		protected global::Android.Graphics.Rect MScrollableAreaLimit {
			get {
				if (mScrollableAreaLimit_jfieldId == IntPtr.Zero)
					mScrollableAreaLimit_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollableAreaLimit", "Landroid/graphics/Rect;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mScrollableAreaLimit_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mScrollableAreaLimit_jfieldId == IntPtr.Zero)
					mScrollableAreaLimit_jfieldId = JNIEnv.GetFieldID (class_ref, "mScrollableAreaLimit", "Landroid/graphics/Rect;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mScrollableAreaLimit_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTargetZoomLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/field[@name='mTargetZoomLevel']"
		[Register ("mTargetZoomLevel")]
		protected global::Java.Util.Concurrent.Atomic.AtomicInteger MTargetZoomLevel {
			get {
				if (mTargetZoomLevel_jfieldId == IntPtr.Zero)
					mTargetZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetZoomLevel", "Ljava/util/concurrent/atomic/AtomicInteger;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTargetZoomLevel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicInteger> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTargetZoomLevel_jfieldId == IntPtr.Zero)
					mTargetZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mTargetZoomLevel", "Ljava/util/concurrent/atomic/AtomicInteger;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTargetZoomLevel_jfieldId, native_value);
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

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapView$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Views.ViewGroup.LayoutParams {


			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public const int BottomCenter = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM_LEFT']"
			[Register ("BOTTOM_LEFT")]
			public const int BottomLeft = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM_RIGHT']"
			[Register ("BOTTOM_RIGHT")]
			public const int BottomRight = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='CENTER']"
			[Register ("CENTER")]
			public const int Center = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='CENTER_LEFT']"
			[Register ("CENTER_LEFT")]
			public const int CenterLeft = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='CENTER_RIGHT']"
			[Register ("CENTER_RIGHT")]
			public const int CenterRight = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='TOP_CENTER']"
			[Register ("TOP_CENTER")]
			public const int TopCenter = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='TOP_LEFT']"
			[Register ("TOP_LEFT")]
			public const int TopLeft = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='TOP_RIGHT']"
			[Register ("TOP_RIGHT")]
			public const int TopRight = (int) 3;

			static IntPtr alignment_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='alignment']"
			[Register ("alignment")]
			public int Alignment {
				get {
					if (alignment_jfieldId == IntPtr.Zero)
						alignment_jfieldId = JNIEnv.GetFieldID (class_ref, "alignment", "I");
					return JNIEnv.GetIntField (Handle, alignment_jfieldId);
				}
				set {
					if (alignment_jfieldId == IntPtr.Zero)
						alignment_jfieldId = JNIEnv.GetFieldID (class_ref, "alignment", "I");
					JNIEnv.SetField (Handle, alignment_jfieldId, value);
				}
			}

			static IntPtr geoPoint_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='geoPoint']"
			[Register ("geoPoint")]
			public global::Osmdroid.Api.IGeoPoint GeoPoint {
				get {
					if (geoPoint_jfieldId == IntPtr.Zero)
						geoPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "geoPoint", "Lorg/osmdroid/api/IGeoPoint;");
					IntPtr __ret = JNIEnv.GetObjectField (Handle, geoPoint_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (geoPoint_jfieldId == IntPtr.Zero)
						geoPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "geoPoint", "Lorg/osmdroid/api/IGeoPoint;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, geoPoint_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr offsetX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='offsetX']"
			[Register ("offsetX")]
			public int OffsetX {
				get {
					if (offsetX_jfieldId == IntPtr.Zero)
						offsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetX", "I");
					return JNIEnv.GetIntField (Handle, offsetX_jfieldId);
				}
				set {
					if (offsetX_jfieldId == IntPtr.Zero)
						offsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetX", "I");
					JNIEnv.SetField (Handle, offsetX_jfieldId, value);
				}
			}

			static IntPtr offsetY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/field[@name='offsetY']"
			[Register ("offsetY")]
			public int OffsetY {
				get {
					if (offsetY_jfieldId == IntPtr.Zero)
						offsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetY", "I");
					return JNIEnv.GetIntField (Handle, offsetY_jfieldId);
				}
				set {
					if (offsetY_jfieldId == IntPtr.Zero)
						offsetY_jfieldId = JNIEnv.GetFieldID (class_ref, "offsetY", "I");
					JNIEnv.SetField (Handle, offsetY_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapView$LayoutParams", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LayoutParams); }
			}

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IILorg_osmdroid_api_IGeoPoint_III;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.api.IGeoPoint'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IILorg/osmdroid/api/IGeoPoint;III)V", "")]
			public LayoutParams (int width, int height, global::Osmdroid.Api.IGeoPoint geoPoint, int alignment, int offsetX, int offsetY) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILorg/osmdroid/api/IGeoPoint;III)V", new JValue (width), new JValue (height), new JValue (geoPoint), new JValue (alignment), new JValue (offsetX), new JValue (offsetY)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IILorg/osmdroid/api/IGeoPoint;III)V", new JValue (width), new JValue (height), new JValue (geoPoint), new JValue (alignment), new JValue (offsetX), new JValue (offsetY));
					return;
				}

				if (id_ctor_IILorg_osmdroid_api_IGeoPoint_III == IntPtr.Zero)
					id_ctor_IILorg_osmdroid_api_IGeoPoint_III = JNIEnv.GetMethodID (class_ref, "<init>", "(IILorg/osmdroid/api/IGeoPoint;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILorg_osmdroid_api_IGeoPoint_III, new JValue (width), new JValue (height), new JValue (geoPoint), new JValue (alignment), new JValue (offsetX), new JValue (offsetY)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IILorg_osmdroid_api_IGeoPoint_III, new JValue (width), new JValue (height), new JValue (geoPoint), new JValue (alignment), new JValue (offsetX), new JValue (offsetY));
			}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public LayoutParams (global::Android.Content.Context c, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (c), new JValue (attrs)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (c), new JValue (attrs));
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (c), new JValue (attrs)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (c), new JValue (attrs));
			}

			static IntPtr id_ctor_Landroid_view_ViewGroup_LayoutParams_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public LayoutParams (global::Android.Views.ViewGroup.LayoutParams source) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (LayoutParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/view/ViewGroup$LayoutParams;)V", new JValue (source)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/view/ViewGroup$LayoutParams;)V", new JValue (source));
					return;
				}

				if (id_ctor_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
					id_ctor_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, new JValue (source)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_view_ViewGroup_LayoutParams_, new JValue (source));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewDoubleClickListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapView$MapViewDoubleClickListener", DoNotGenerateAcw=true)]
		public partial class MapViewDoubleClickListener : global::Java.Lang.Object, global::Android.Views.GestureDetector.IOnDoubleTapListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapView$MapViewDoubleClickListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MapViewDoubleClickListener); }
			}

			protected MapViewDoubleClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onDoubleTap_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTap_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTap_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTap_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTap_Landroid_view_MotionEvent_);
				return cb_onDoubleTap_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTap_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTap (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onDoubleTap_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewDoubleClickListener']/method[@name='onDoubleTap' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDoubleTap", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTap_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnDoubleTap (global::Android.Views.MotionEvent p0)
			{
				if (id_onDoubleTap_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDoubleTap_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTap", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTap_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTap", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDoubleTapEvent_Landroid_view_MotionEvent_ == null)
					cb_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDoubleTapEvent_Landroid_view_MotionEvent_);
				return cb_onDoubleTapEvent_Landroid_view_MotionEvent_;
			}

			static bool n_OnDoubleTapEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDoubleTapEvent (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onDoubleTapEvent_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewDoubleClickListener']/method[@name='onDoubleTapEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z", "GetOnDoubleTapEvent_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnDoubleTapEvent (global::Android.Views.MotionEvent p0)
			{
				if (id_onDoubleTapEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDoubleTapEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDoubleTapEvent_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDoubleTapEvent", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapConfirmed_Landroid_view_MotionEvent_);
				return cb_onSingleTapConfirmed_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapConfirmed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapConfirmed (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onSingleTapConfirmed_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewDoubleClickListener']/method[@name='onSingleTapConfirmed' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapConfirmed_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnSingleTapConfirmed (global::Android.Views.MotionEvent p0)
			{
				if (id_onSingleTapConfirmed_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onSingleTapConfirmed_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapConfirmed_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapConfirmed", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapView$MapViewGestureDetectorListener", DoNotGenerateAcw=true)]
		public partial class MapViewGestureDetectorListener : global::Java.Lang.Object, global::Android.Views.GestureDetector.IOnGestureListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapView$MapViewGestureDetectorListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MapViewGestureDetectorListener); }
			}

			protected MapViewGestureDetectorListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onDown_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnDown_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onDown_Landroid_view_MotionEvent_ == null)
					cb_onDown_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnDown_Landroid_view_MotionEvent_);
				return cb_onDown_Landroid_view_MotionEvent_;
			}

			static bool n_OnDown_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnDown (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onDown_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onDown' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onDown", "(Landroid/view/MotionEvent;)Z", "GetOnDown_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnDown (global::Android.Views.MotionEvent p0)
			{
				if (id_onDown_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onDown_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onDown", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onDown_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDown", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

			static Delegate cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnFling (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onFling' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
			public virtual bool OnFling (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
			{
				if (id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
					id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return __ret;
			}

			static Delegate cb_onLongPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnLongPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onLongPress_Landroid_view_MotionEvent_ == null)
					cb_onLongPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLongPress_Landroid_view_MotionEvent_);
				return cb_onLongPress_Landroid_view_MotionEvent_;
			}

			static void n_OnLongPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnLongPress (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onLongPress_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onLongPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onLongPress", "(Landroid/view/MotionEvent;)V", "GetOnLongPress_Landroid_view_MotionEvent_Handler")]
			public virtual void OnLongPress (global::Android.Views.MotionEvent p0)
			{
				if (id_onLongPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onLongPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onLongPress", "(Landroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onLongPress_Landroid_view_MotionEvent_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPress", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
			}

			static Delegate cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
			static Delegate GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
			{
				if (cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
					cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, bool>) n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
				return cb_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			}

			static bool n_OnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnScroll (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onScroll' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
			[Register ("onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z", "GetOnScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler")]
			public virtual bool OnScroll (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
			{
				if (id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
					id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onScroll_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onScroll", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)Z"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return __ret;
			}

			static Delegate cb_onShowPress_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnShowPress_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onShowPress_Landroid_view_MotionEvent_ == null)
					cb_onShowPress_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnShowPress_Landroid_view_MotionEvent_);
				return cb_onShowPress_Landroid_view_MotionEvent_;
			}

			static void n_OnShowPress_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnShowPress (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onShowPress_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onShowPress' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onShowPress", "(Landroid/view/MotionEvent;)V", "GetOnShowPress_Landroid_view_MotionEvent_Handler")]
			public virtual void OnShowPress (global::Android.Views.MotionEvent p0)
			{
				if (id_onShowPress_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onShowPress_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onShowPress", "(Landroid/view/MotionEvent;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onShowPress_Landroid_view_MotionEvent_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onShowPress", "(Landroid/view/MotionEvent;)V"), new JValue (p0));
			}

			static Delegate cb_onSingleTapUp_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnSingleTapUp_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onSingleTapUp_Landroid_view_MotionEvent_ == null)
					cb_onSingleTapUp_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnSingleTapUp_Landroid_view_MotionEvent_);
				return cb_onSingleTapUp_Landroid_view_MotionEvent_;
			}

			static bool n_OnSingleTapUp_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Views.MapView.MapViewGestureDetectorListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewGestureDetectorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnSingleTapUp (p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onSingleTapUp_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewGestureDetectorListener']/method[@name='onSingleTapUp' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onSingleTapUp", "(Landroid/view/MotionEvent;)Z", "GetOnSingleTapUp_Landroid_view_MotionEvent_Handler")]
			public virtual bool OnSingleTapUp (global::Android.Views.MotionEvent p0)
			{
				if (id_onSingleTapUp_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onSingleTapUp_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z");

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapUp_Landroid_view_MotionEvent_, new JValue (p0));
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUp", "(Landroid/view/MotionEvent;)Z"), new JValue (p0));
				return __ret;
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewZoomListener']"
		[global::Android.Runtime.Register ("org/osmdroid/views/MapView$MapViewZoomListener", DoNotGenerateAcw=true)]
		public partial class MapViewZoomListener : global::Java.Lang.Object, global::Android.Widget.ZoomButtonsController.IOnZoomListener {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/MapView$MapViewZoomListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MapViewZoomListener); }
			}

			protected MapViewZoomListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onVisibilityChanged_Z;
#pragma warning disable 0169
			static Delegate GetOnVisibilityChanged_ZHandler ()
			{
				if (cb_onVisibilityChanged_Z == null)
					cb_onVisibilityChanged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChanged_Z);
				return cb_onVisibilityChanged_Z;
			}

			static void n_OnVisibilityChanged_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Osmdroid.Views.MapView.MapViewZoomListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewZoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnVisibilityChanged (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onVisibilityChanged_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewZoomListener']/method[@name='onVisibilityChanged' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onVisibilityChanged", "(Z)V", "GetOnVisibilityChanged_ZHandler")]
			public virtual void OnVisibilityChanged (bool p0)
			{
				if (id_onVisibilityChanged_Z == IntPtr.Zero)
					id_onVisibilityChanged_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChanged", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onVisibilityChanged_Z, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onVisibilityChanged", "(Z)V"), new JValue (p0));
			}

			static Delegate cb_onZoom_Z;
#pragma warning disable 0169
			static Delegate GetOnZoom_ZHandler ()
			{
				if (cb_onZoom_Z == null)
					cb_onZoom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnZoom_Z);
				return cb_onZoom_Z;
			}

			static void n_OnZoom_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Osmdroid.Views.MapView.MapViewZoomListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView.MapViewZoomListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnZoom (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onZoom_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView.MapViewZoomListener']/method[@name='onZoom' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onZoom", "(Z)V", "GetOnZoom_ZHandler")]
			public virtual void OnZoom (bool p0)
			{
				if (id_onZoom_Z == IntPtr.Zero)
					id_onZoom_Z = JNIEnv.GetMethodID (class_ref, "onZoom", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onZoom_Z, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onZoom", "(Z)V"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/MapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapView); }
		}

		protected MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public MapView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (attrs)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (attrs));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (context), new JValue (attrs)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (context), new JValue (attrs));
		}

		static IntPtr id_ctor_Landroid_content_Context_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public MapView (global::Android.Content.Context context, int tileSizePixels) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;I)V", new JValue (context), new JValue (tileSizePixels)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;I)V", new JValue (context), new JValue (tileSizePixels));
				return;
			}

			if (id_ctor_Landroid_content_Context_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_I, new JValue (context), new JValue (tileSizePixels)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_I, new JValue (context), new JValue (tileSizePixels));
		}

		static IntPtr id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;)V", "")]
		public MapView (global::Android.Content.Context context, int tileSizePixels, global::Osmdroid.IResourceProxy resourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy));
		}

		static IntPtr id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.ResourceProxy'] and parameter[4][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;Landroid/util/AttributeSet;)V", "")]
		protected MapView (global::Android.Content.Context context, int tileSizePixels, global::Osmdroid.IResourceProxy resourceProxy, global::Osmdroid.TileProvider.MapTileProviderBase tileProvider, global::Android.OS.Handler tileRequestCompleteHandler, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (tileProvider), new JValue (tileRequestCompleteHandler), new JValue (attrs)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (tileProvider), new JValue (tileRequestCompleteHandler), new JValue (attrs));
				return;
			}

			if (id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_Landroid_util_AttributeSet_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (tileProvider), new JValue (tileRequestCompleteHandler), new JValue (attrs)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_Landroid_util_AttributeSet_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (tileProvider), new JValue (tileRequestCompleteHandler), new JValue (attrs));
		}

		static IntPtr id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.ResourceProxy'] and parameter[4][@type='org.osmdroid.tileprovider.MapTileProviderBase'] and parameter[5][@type='android.os.Handler']]"
		[Register (".ctor", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;)V", "")]
		public MapView (global::Android.Content.Context context, int tileSizePixels, global::Osmdroid.IResourceProxy resourceProxy, global::Osmdroid.TileProvider.MapTileProviderBase aTileProvider, global::Android.OS.Handler tileRequestCompleteHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider), new JValue (tileRequestCompleteHandler)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider), new JValue (tileRequestCompleteHandler));
				return;
			}

			if (id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;Landroid/os/Handler;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider), new JValue (tileRequestCompleteHandler)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_Landroid_os_Handler_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider), new JValue (tileRequestCompleteHandler));
		}

		static IntPtr id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.ResourceProxy'] and parameter[4][@type='org.osmdroid.tileprovider.MapTileProviderBase']]"
		[Register (".ctor", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", "")]
		public MapView (global::Android.Content.Context context, int tileSizePixels, global::Osmdroid.IResourceProxy resourceProxy, global::Osmdroid.TileProvider.MapTileProviderBase aTileProvider) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider));
				return;
			}

			if (id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;ILorg/osmdroid/ResourceProxy;Lorg/osmdroid/tileprovider/MapTileProviderBase;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_ILorg_osmdroid_ResourceProxy_Lorg_osmdroid_tileprovider_MapTileProviderBase_, new JValue (context), new JValue (tileSizePixels), new JValue (resourceProxy), new JValue (aTileProvider));
		}

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
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BoundingBox);
		}
#pragma warning restore 0169

		static IntPtr id_getBoundingBox;
		public virtual global::Org.Osmdroid.Util.BoundingBoxE6 BoundingBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getBoundingBox' and count(parameter)=0]"
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

		static Delegate cb_getController;
#pragma warning disable 0169
		static Delegate GetGetControllerHandler ()
		{
			if (cb_getController == null)
				cb_getController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetController);
			return cb_getController;
		}

		static IntPtr n_GetController (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Controller);
		}
#pragma warning restore 0169

		static IntPtr id_getController;
		public virtual global::Osmdroid.Api.IMapController Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lorg/osmdroid/api/IMapController;", "GetGetControllerHandler")]
			get {
				if (id_getController == IntPtr.Zero)
					id_getController = JNIEnv.GetMethodID (class_ref, "getController", "()Lorg/osmdroid/api/IMapController;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (JNIEnv.CallObjectMethod  (Handle, id_getController), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getController", "()Lorg/osmdroid/api/IMapController;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isAnimating;
#pragma warning disable 0169
		static Delegate GetIsAnimatingHandler ()
		{
			if (cb_isAnimating == null)
				cb_isAnimating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimating);
			return cb_isAnimating;
		}

		static bool n_IsAnimating (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimating;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimating;
		public virtual bool IsAnimating {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='isAnimating' and count(parameter)=0]"
			[Register ("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get {
				if (id_isAnimating == IntPtr.Zero)
					id_isAnimating = JNIEnv.GetMethodID (class_ref, "isAnimating", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAnimating);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimating", "()Z"));
			}
		}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static int n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitudeSpan;
		public virtual int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()I", "GetGetLatitudeSpanHandler")]
			get {
				if (id_getLatitudeSpan == IntPtr.Zero)
					id_getLatitudeSpan = JNIEnv.GetMethodID (class_ref, "getLatitudeSpan", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLatitudeSpan);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitudeSpan", "()I"));
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static int n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitudeSpan;
		public virtual int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()I", "GetGetLongitudeSpanHandler")]
			get {
				if (id_getLongitudeSpan == IntPtr.Zero)
					id_getLongitudeSpan = JNIEnv.GetMethodID (class_ref, "getLongitudeSpan", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLongitudeSpan);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitudeSpan", "()I"));
			}
		}

		static Delegate cb_getMapCenter;
#pragma warning disable 0169
		static Delegate GetGetMapCenterHandler ()
		{
			if (cb_getMapCenter == null)
				cb_getMapCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapCenter);
			return cb_getMapCenter;
		}

		static IntPtr n_GetMapCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		static IntPtr id_getMapCenter;
		public virtual global::Osmdroid.Api.IGeoPoint MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getMapCenter' and count(parameter)=0]"
			[Register ("getMapCenter", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetMapCenterHandler")]
			get {
				if (id_getMapCenter == IntPtr.Zero)
					id_getMapCenter = JNIEnv.GetMethodID (class_ref, "getMapCenter", "()Lorg/osmdroid/api/IGeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getMapCenter), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapCenter", "()Lorg/osmdroid/api/IGeoPoint;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapOrientation;
		}
#pragma warning restore 0169

		static Delegate cb_setMapOrientation_F;
#pragma warning disable 0169
		static Delegate GetSetMapOrientation_FHandler ()
		{
			if (cb_setMapOrientation_F == null)
				cb_setMapOrientation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMapOrientation_F);
			return cb_setMapOrientation_F;
		}

		static void n_SetMapOrientation_F (IntPtr jnienv, IntPtr native__this, float degrees)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MapOrientation = degrees;
		}
#pragma warning restore 0169

		static IntPtr id_getMapOrientation;
		static IntPtr id_setMapOrientation_F;
		public virtual float MapOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getMapOrientation' and count(parameter)=0]"
			[Register ("getMapOrientation", "()F", "GetGetMapOrientationHandler")]
			get {
				if (id_getMapOrientation == IntPtr.Zero)
					id_getMapOrientation = JNIEnv.GetMethodID (class_ref, "getMapOrientation", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMapOrientation);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapOrientation", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setMapOrientation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMapOrientation", "(F)V", "GetSetMapOrientation_FHandler")]
			set {
				if (id_setMapOrientation_F == IntPtr.Zero)
					id_setMapOrientation_F = JNIEnv.GetMethodID (class_ref, "setMapOrientation", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMapOrientation_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapOrientation", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMaxZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomLevelHandler ()
		{
			if (cb_getMaxZoomLevel == null)
				cb_getMaxZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxZoomLevel);
			return cb_getMaxZoomLevel;
		}

		static int n_GetMaxZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxZoomLevel;
		public virtual int MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()I", "GetGetMaxZoomLevelHandler")]
			get {
				if (id_getMaxZoomLevel == IntPtr.Zero)
					id_getMaxZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaxZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaxZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxZoomLevel", "()I"));
			}
		}

		static Delegate cb_getMinZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinZoomLevelHandler ()
		{
			if (cb_getMinZoomLevel == null)
				cb_getMinZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinZoomLevel);
			return cb_getMinZoomLevel;
		}

		static int n_GetMinZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinZoomLevel;
		public virtual int MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()I", "GetGetMinZoomLevelHandler")]
			get {
				if (id_getMinZoomLevel == IntPtr.Zero)
					id_getMinZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinZoomLevel", "()I"));
			}
		}

		static Delegate cb_getOverlayManager;
#pragma warning disable 0169
		static Delegate GetGetOverlayManagerHandler ()
		{
			if (cb_getOverlayManager == null)
				cb_getOverlayManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlayManager);
			return cb_getOverlayManager;
		}

		static IntPtr n_GetOverlayManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OverlayManager);
		}
#pragma warning restore 0169

		static IntPtr id_getOverlayManager;
		public virtual global::Osmdroid.Views.Overlay.OverlayManager OverlayManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getOverlayManager' and count(parameter)=0]"
			[Register ("getOverlayManager", "()Lorg/osmdroid/views/overlay/OverlayManager;", "GetGetOverlayManagerHandler")]
			get {
				if (id_getOverlayManager == IntPtr.Zero)
					id_getOverlayManager = JNIEnv.GetMethodID (class_ref, "getOverlayManager", "()Lorg/osmdroid/views/overlay/OverlayManager;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (JNIEnv.CallObjectMethod  (Handle, id_getOverlayManager), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayManager> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOverlayManager", "()Lorg/osmdroid/views/overlay/OverlayManager;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getOverlays;
#pragma warning disable 0169
		static Delegate GetGetOverlaysHandler ()
		{
			if (cb_getOverlays == null)
				cb_getOverlays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOverlays);
			return cb_getOverlays;
		}

		static IntPtr n_GetOverlays (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Osmdroid.Views.Overlay.Overlay>.ToLocalJniHandle (__this.Overlays);
		}
#pragma warning restore 0169

		static IntPtr id_getOverlays;
		public virtual global::System.Collections.Generic.IList<global::Osmdroid.Views.Overlay.Overlay> Overlays {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getOverlays' and count(parameter)=0]"
			[Register ("getOverlays", "()Ljava/util/List;", "GetGetOverlaysHandler")]
			get {
				if (id_getOverlays == IntPtr.Zero)
					id_getOverlays = JNIEnv.GetMethodID (class_ref, "getOverlays", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Osmdroid.Views.Overlay.Overlay>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getOverlays), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Osmdroid.Views.Overlay.Overlay>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOverlays", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		static IntPtr id_getProjection;
		public virtual global::Osmdroid.Api.IProjection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lorg/osmdroid/views/Projection;", "GetGetProjectionHandler")]
			get {
				if (id_getProjection == IntPtr.Zero)
					id_getProjection = JNIEnv.GetMethodID (class_ref, "getProjection", "()Lorg/osmdroid/views/Projection;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (JNIEnv.CallObjectMethod  (Handle, id_getProjection), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProjection", "()Lorg/osmdroid/views/Projection;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResourceProxy;
#pragma warning disable 0169
		static Delegate GetGetResourceProxyHandler ()
		{
			if (cb_getResourceProxy == null)
				cb_getResourceProxy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceProxy);
			return cb_getResourceProxy;
		}

		static IntPtr n_GetResourceProxy (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResourceProxy);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceProxy;
		public virtual global::Osmdroid.IResourceProxy ResourceProxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getResourceProxy' and count(parameter)=0]"
			[Register ("getResourceProxy", "()Lorg/osmdroid/ResourceProxy;", "GetGetResourceProxyHandler")]
			get {
				if (id_getResourceProxy == IntPtr.Zero)
					id_getResourceProxy = JNIEnv.GetMethodID (class_ref, "getResourceProxy", "()Lorg/osmdroid/ResourceProxy;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (JNIEnv.CallObjectMethod  (Handle, id_getResourceProxy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceProxy", "()Lorg/osmdroid/ResourceProxy;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getScrollableAreaLimit;
#pragma warning disable 0169
		static Delegate GetGetScrollableAreaLimitHandler ()
		{
			if (cb_getScrollableAreaLimit == null)
				cb_getScrollableAreaLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScrollableAreaLimit);
			return cb_getScrollableAreaLimit;
		}

		static IntPtr n_GetScrollableAreaLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScrollableAreaLimit);
		}
#pragma warning restore 0169

		static Delegate cb_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_;
#pragma warning disable 0169
		static Delegate GetSetScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_Handler ()
		{
			if (cb_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_ == null)
				cb_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_);
			return cb_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_;
		}

		static void n_SetScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boundingBox)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 boundingBox = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_boundingBox, JniHandleOwnership.DoNotTransfer);
			__this.ScrollableAreaLimit = boundingBox;
		}
#pragma warning restore 0169

		static IntPtr id_getScrollableAreaLimit;
		static IntPtr id_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_;
		public virtual global::Org.Osmdroid.Util.BoundingBoxE6 ScrollableAreaLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getScrollableAreaLimit' and count(parameter)=0]"
			[Register ("getScrollableAreaLimit", "()Lorg/osmdroid/util/BoundingBoxE6;", "GetGetScrollableAreaLimitHandler")]
			get {
				if (id_getScrollableAreaLimit == IntPtr.Zero)
					id_getScrollableAreaLimit = JNIEnv.GetMethodID (class_ref, "getScrollableAreaLimit", "()Lorg/osmdroid/util/BoundingBoxE6;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallObjectMethod  (Handle, id_getScrollableAreaLimit), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScrollableAreaLimit", "()Lorg/osmdroid/util/BoundingBoxE6;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setScrollableAreaLimit' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6']]"
			[Register ("setScrollableAreaLimit", "(Lorg/osmdroid/util/BoundingBoxE6;)V", "GetSetScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_Handler")]
			set {
				if (id_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_ == IntPtr.Zero)
					id_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_ = JNIEnv.GetMethodID (class_ref, "setScrollableAreaLimit", "(Lorg/osmdroid/util/BoundingBoxE6;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScrollableAreaLimit_Lorg_osmdroid_util_BoundingBoxE6_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollableAreaLimit", "(Lorg/osmdroid/util/BoundingBoxE6;)V"), new JValue (value));
			}
		}

		static Delegate cb_getScroller;
#pragma warning disable 0169
		static Delegate GetGetScrollerHandler ()
		{
			if (cb_getScroller == null)
				cb_getScroller = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScroller);
			return cb_getScroller;
		}

		static IntPtr n_GetScroller (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Scroller);
		}
#pragma warning restore 0169

		static IntPtr id_getScroller;
		public virtual global::Android.Widget.Scroller Scroller {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getScroller' and count(parameter)=0]"
			[Register ("getScroller", "()Landroid/widget/Scroller;", "GetGetScrollerHandler")]
			get {
				if (id_getScroller == IntPtr.Zero)
					id_getScroller = JNIEnv.GetMethodID (class_ref, "getScroller", "()Landroid/widget/Scroller;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller> (JNIEnv.CallObjectMethod  (Handle, id_getScroller), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Widget.Scroller> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScroller", "()Landroid/widget/Scroller;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTileProvider;
#pragma warning disable 0169
		static Delegate GetGetTileProviderHandler ()
		{
			if (cb_getTileProvider == null)
				cb_getTileProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileProvider);
			return cb_getTileProvider;
		}

		static IntPtr n_GetTileProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TileProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getTileProvider;
		public virtual global::Osmdroid.TileProvider.MapTileProviderBase TileProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getTileProvider' and count(parameter)=0]"
			[Register ("getTileProvider", "()Lorg/osmdroid/tileprovider/MapTileProviderBase;", "GetGetTileProviderHandler")]
			get {
				if (id_getTileProvider == IntPtr.Zero)
					id_getTileProvider = JNIEnv.GetMethodID (class_ref, "getTileProvider", "()Lorg/osmdroid/tileprovider/MapTileProviderBase;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (JNIEnv.CallObjectMethod  (Handle, id_getTileProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileProvider", "()Lorg/osmdroid/tileprovider/MapTileProviderBase;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTileRequestCompleteHandler;
#pragma warning disable 0169
		static Delegate GetGetTileRequestCompleteHandlerHandler ()
		{
			if (cb_getTileRequestCompleteHandler == null)
				cb_getTileRequestCompleteHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileRequestCompleteHandler);
			return cb_getTileRequestCompleteHandler;
		}

		static IntPtr n_GetTileRequestCompleteHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TileRequestCompleteHandler);
		}
#pragma warning restore 0169

		static IntPtr id_getTileRequestCompleteHandler;
		public virtual global::Android.OS.Handler TileRequestCompleteHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getTileRequestCompleteHandler' and count(parameter)=0]"
			[Register ("getTileRequestCompleteHandler", "()Landroid/os/Handler;", "GetGetTileRequestCompleteHandlerHandler")]
			get {
				if (id_getTileRequestCompleteHandler == IntPtr.Zero)
					id_getTileRequestCompleteHandler = JNIEnv.GetMethodID (class_ref, "getTileRequestCompleteHandler", "()Landroid/os/Handler;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallObjectMethod  (Handle, id_getTileRequestCompleteHandler), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTileRequestCompleteHandler", "()Landroid/os/Handler;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		public virtual int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getZoomLevel' and count(parameter)=0]"
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

		static Delegate cb_canZoomIn;
#pragma warning disable 0169
		static Delegate GetCanZoomInHandler ()
		{
			if (cb_canZoomIn == null)
				cb_canZoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomIn);
			return cb_canZoomIn;
		}

		static bool n_CanZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomIn ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoomIn;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='canZoomIn' and count(parameter)=0]"
		[Register ("canZoomIn", "()Z", "GetCanZoomInHandler")]
		public virtual bool CanZoomIn ()
		{
			if (id_canZoomIn == IntPtr.Zero)
				id_canZoomIn = JNIEnv.GetMethodID (class_ref, "canZoomIn", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canZoomIn);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoomIn", "()Z"));
		}

		static Delegate cb_canZoomOut;
#pragma warning disable 0169
		static Delegate GetCanZoomOutHandler ()
		{
			if (cb_canZoomOut == null)
				cb_canZoomOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomOut);
			return cb_canZoomOut;
		}

		static bool n_CanZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomOut ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoomOut;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='canZoomOut' and count(parameter)=0]"
		[Register ("canZoomOut", "()Z", "GetCanZoomOutHandler")]
		public virtual bool CanZoomOut ()
		{
			if (id_canZoomOut == IntPtr.Zero)
				id_canZoomOut = JNIEnv.GetMethodID (class_ref, "canZoomOut", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canZoomOut);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoomOut", "()Z"));
		}

		static Delegate cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
		static Delegate GetGetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
		{
			if (cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
				cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
			return cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		}

		static IntPtr n_GetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pt)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo pt = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_pt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDraggableObjectAtPoint (pt));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getDraggableObjectAtPoint' and count(parameter)=1 and parameter[1][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
		[Register ("getDraggableObjectAtPoint", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Ljava/lang/Object;", "GetGetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler")]
		public virtual global::Java.Lang.Object GetDraggableObjectAtPoint (global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo pt)
		{
			if (id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
				id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "getDraggableObjectAtPoint", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Ljava/lang/Object;");

			global::Java.Lang.Object __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (pt)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDraggableObjectAtPoint", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Ljava/lang/Object;"), new JValue (pt)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getIntrinsicScreenRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetIntrinsicScreenRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getIntrinsicScreenRect_Landroid_graphics_Rect_ == null)
				cb_getIntrinsicScreenRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetIntrinsicScreenRect_Landroid_graphics_Rect_);
			return cb_getIntrinsicScreenRect_Landroid_graphics_Rect_;
		}

		static IntPtr n_GetIntrinsicScreenRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reuse)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetIntrinsicScreenRect (reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getIntrinsicScreenRect_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getIntrinsicScreenRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("getIntrinsicScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;", "GetGetIntrinsicScreenRect_Landroid_graphics_Rect_Handler")]
		public virtual global::Android.Graphics.Rect GetIntrinsicScreenRect (global::Android.Graphics.Rect reuse)
		{
			if (id_getIntrinsicScreenRect_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_getIntrinsicScreenRect_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "getIntrinsicScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getIntrinsicScreenRect_Landroid_graphics_Rect_, new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntrinsicScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;"), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
#pragma warning disable 0169
		static Delegate GetGetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Handler ()
		{
			if (cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ == null)
				cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_);
			return cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
		}

		static void n_GetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_objPosAndScaleOut)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (native_objPosAndScaleOut, JniHandleOwnership.DoNotTransfer);
			__this.GetPositionAndScale (obj, objPosAndScaleOut);
		}
#pragma warning restore 0169

		static IntPtr id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getPositionAndScale' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PositionAndScale']]"
		[Register ("getPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;)V", "GetGetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Handler")]
		public virtual void GetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut)
		{
			if (id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ == IntPtr.Zero)
				id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ = JNIEnv.GetMethodID (class_ref, "getPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_, new JValue (obj), new JValue (objPosAndScaleOut));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;)V"), new JValue (obj), new JValue (objPosAndScaleOut));
		}

		static Delegate cb_getScreenRect_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetScreenRect_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getScreenRect_Landroid_graphics_Rect_ == null)
				cb_getScreenRect_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScreenRect_Landroid_graphics_Rect_);
			return cb_getScreenRect_Landroid_graphics_Rect_;
		}

		static IntPtr n_GetScreenRect_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_reuse)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect reuse = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_reuse, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetScreenRect (reuse));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getScreenRect_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getScreenRect' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("getScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;", "GetGetScreenRect_Landroid_graphics_Rect_Handler")]
		public virtual global::Android.Graphics.Rect GetScreenRect (global::Android.Graphics.Rect reuse)
		{
			if (id_getScreenRect_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_getScreenRect_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "getScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;");

			global::Android.Graphics.Rect __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallObjectMethod  (Handle, id_getScreenRect_Landroid_graphics_Rect_, new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScreenRect", "(Landroid/graphics/Rect;)Landroid/graphics/Rect;"), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getZoomLevel_Z;
#pragma warning disable 0169
		static Delegate GetGetZoomLevel_ZHandler ()
		{
			if (cb_getZoomLevel_Z == null)
				cb_getZoomLevel_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_GetZoomLevel_Z);
			return cb_getZoomLevel_Z;
		}

		static int n_GetZoomLevel_Z (IntPtr jnienv, IntPtr native__this, bool aPending)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetZoomLevel (aPending);
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='getZoomLevel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getZoomLevel", "(Z)I", "GetGetZoomLevel_ZHandler")]
		public virtual int GetZoomLevel (bool aPending)
		{
			if (id_getZoomLevel_Z == IntPtr.Zero)
				id_getZoomLevel_Z = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "(Z)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getZoomLevel_Z, new JValue (aPending));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "(Z)I"), new JValue (aPending));
		}

		static Delegate cb_invalidateMapCoordinates_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetInvalidateMapCoordinates_Landroid_graphics_Rect_Handler ()
		{
			if (cb_invalidateMapCoordinates_Landroid_graphics_Rect_ == null)
				cb_invalidateMapCoordinates_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InvalidateMapCoordinates_Landroid_graphics_Rect_);
			return cb_invalidateMapCoordinates_Landroid_graphics_Rect_;
		}

		static void n_InvalidateMapCoordinates_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dirty)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect dirty = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_dirty, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateMapCoordinates (dirty);
		}
#pragma warning restore 0169

		static IntPtr id_invalidateMapCoordinates_Landroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='invalidateMapCoordinates' and count(parameter)=1 and parameter[1][@type='android.graphics.Rect']]"
		[Register ("invalidateMapCoordinates", "(Landroid/graphics/Rect;)V", "GetInvalidateMapCoordinates_Landroid_graphics_Rect_Handler")]
		public virtual void InvalidateMapCoordinates (global::Android.Graphics.Rect dirty)
		{
			if (id_invalidateMapCoordinates_Landroid_graphics_Rect_ == IntPtr.Zero)
				id_invalidateMapCoordinates_Landroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "invalidateMapCoordinates", "(Landroid/graphics/Rect;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidateMapCoordinates_Landroid_graphics_Rect_, new JValue (dirty));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateMapCoordinates", "(Landroid/graphics/Rect;)V"), new JValue (dirty));
		}

		static Delegate cb_invalidateMapCoordinates_IIII;
#pragma warning disable 0169
		static Delegate GetInvalidateMapCoordinates_IIIIHandler ()
		{
			if (cb_invalidateMapCoordinates_IIII == null)
				cb_invalidateMapCoordinates_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_InvalidateMapCoordinates_IIII);
			return cb_invalidateMapCoordinates_IIII;
		}

		static void n_InvalidateMapCoordinates_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InvalidateMapCoordinates (left, top, right, bottom);
		}
#pragma warning restore 0169

		static IntPtr id_invalidateMapCoordinates_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='invalidateMapCoordinates' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("invalidateMapCoordinates", "(IIII)V", "GetInvalidateMapCoordinates_IIIIHandler")]
		public virtual void InvalidateMapCoordinates (int left, int top, int right, int bottom)
		{
			if (id_invalidateMapCoordinates_IIII == IntPtr.Zero)
				id_invalidateMapCoordinates_IIII = JNIEnv.GetMethodID (class_ref, "invalidateMapCoordinates", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidateMapCoordinates_IIII, new JValue (left), new JValue (top), new JValue (right), new JValue (bottom));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidateMapCoordinates", "(IIII)V"), new JValue (left), new JValue (top), new JValue (right), new JValue (bottom));
		}

		static Delegate cb_onDetach;
#pragma warning disable 0169
		static Delegate GetOnDetachHandler ()
		{
			if (cb_onDetach == null)
				cb_onDetach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetach);
			return cb_onDetach;
		}

		static void n_OnDetach (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		static IntPtr id_onDetach;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		public virtual void OnDetach ()
		{
			if (id_onDetach == IntPtr.Zero)
				id_onDetach = JNIEnv.GetMethodID (class_ref, "onDetach", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDetach);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDetach", "()V"));
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, l, t, r, b);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override void OnLayout (bool changed, int l, int t, int r, int b)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onLayout_ZIIII, new JValue (changed), new JValue (l), new JValue (t), new JValue (r), new JValue (b));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), new JValue (changed), new JValue (l), new JValue (t), new JValue (r), new JValue (b));
		}

		static Delegate cb_postInvalidateMapCoordinates_IIII;
#pragma warning disable 0169
		static Delegate GetPostInvalidateMapCoordinates_IIIIHandler ()
		{
			if (cb_postInvalidateMapCoordinates_IIII == null)
				cb_postInvalidateMapCoordinates_IIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int>) n_PostInvalidateMapCoordinates_IIII);
			return cb_postInvalidateMapCoordinates_IIII;
		}

		static void n_PostInvalidateMapCoordinates_IIII (IntPtr jnienv, IntPtr native__this, int left, int top, int right, int bottom)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostInvalidateMapCoordinates (left, top, right, bottom);
		}
#pragma warning restore 0169

		static IntPtr id_postInvalidateMapCoordinates_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='postInvalidateMapCoordinates' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("postInvalidateMapCoordinates", "(IIII)V", "GetPostInvalidateMapCoordinates_IIIIHandler")]
		public virtual void PostInvalidateMapCoordinates (int left, int top, int right, int bottom)
		{
			if (id_postInvalidateMapCoordinates_IIII == IntPtr.Zero)
				id_postInvalidateMapCoordinates_IIII = JNIEnv.GetMethodID (class_ref, "postInvalidateMapCoordinates", "(IIII)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_postInvalidateMapCoordinates_IIII, new JValue (left), new JValue (top), new JValue (right), new JValue (bottom));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postInvalidateMapCoordinates", "(IIII)V"), new JValue (left), new JValue (top), new JValue (right), new JValue (bottom));
		}

		static Delegate cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
		static Delegate GetSelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
		{
			if (cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
				cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
			return cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		}

		static void n_SelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_pt)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo pt = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_pt, JniHandleOwnership.DoNotTransfer);
			__this.SelectObject (obj, pt);
		}
#pragma warning restore 0169

		static IntPtr id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='selectObject' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
		[Register ("selectObject", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V", "GetSelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler")]
		public virtual void SelectObject (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo pt)
		{
			if (id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
				id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "selectObject", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (obj), new JValue (pt));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectObject", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V"), new JValue (obj), new JValue (pt));
		}

		static Delegate cb_setBuiltInZoomControls_Z;
#pragma warning disable 0169
		static Delegate GetSetBuiltInZoomControls_ZHandler ()
		{
			if (cb_setBuiltInZoomControls_Z == null)
				cb_setBuiltInZoomControls_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBuiltInZoomControls_Z);
			return cb_setBuiltInZoomControls_Z;
		}

		static void n_SetBuiltInZoomControls_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBuiltInZoomControls (on);
		}
#pragma warning restore 0169

		static IntPtr id_setBuiltInZoomControls_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setBuiltInZoomControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setBuiltInZoomControls", "(Z)V", "GetSetBuiltInZoomControls_ZHandler")]
		public virtual void SetBuiltInZoomControls (bool on)
		{
			if (id_setBuiltInZoomControls_Z == IntPtr.Zero)
				id_setBuiltInZoomControls_Z = JNIEnv.GetMethodID (class_ref, "setBuiltInZoomControls", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBuiltInZoomControls_Z, new JValue (on));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBuiltInZoomControls", "(Z)V"), new JValue (on));
		}

		static Delegate cb_setMapListener_Lorg_osmdroid_events_MapListener_;
#pragma warning disable 0169
		static Delegate GetSetMapListener_Lorg_osmdroid_events_MapListener_Handler ()
		{
			if (cb_setMapListener_Lorg_osmdroid_events_MapListener_ == null)
				cb_setMapListener_Lorg_osmdroid_events_MapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapListener_Lorg_osmdroid_events_MapListener_);
			return cb_setMapListener_Lorg_osmdroid_events_MapListener_;
		}

		static void n_SetMapListener_Lorg_osmdroid_events_MapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ml)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Events.IMapListener ml = (global::Osmdroid.Events.IMapListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Events.IMapListener> (native_ml, JniHandleOwnership.DoNotTransfer);
			__this.SetMapListener (ml);
		}
#pragma warning restore 0169

		static IntPtr id_setMapListener_Lorg_osmdroid_events_MapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setMapListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.events.MapListener']]"
		[Register ("setMapListener", "(Lorg/osmdroid/events/MapListener;)V", "GetSetMapListener_Lorg_osmdroid_events_MapListener_Handler")]
		public virtual void SetMapListener (global::Osmdroid.Events.IMapListener ml)
		{
			if (id_setMapListener_Lorg_osmdroid_events_MapListener_ == IntPtr.Zero)
				id_setMapListener_Lorg_osmdroid_events_MapListener_ = JNIEnv.GetMethodID (class_ref, "setMapListener", "(Lorg/osmdroid/events/MapListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMapListener_Lorg_osmdroid_events_MapListener_, new JValue (ml));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapListener", "(Lorg/osmdroid/events/MapListener;)V"), new JValue (ml));
		}

		static Delegate cb_setMaxZoomLevel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMaxZoomLevel_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMaxZoomLevel_Ljava_lang_Integer_ == null)
				cb_setMaxZoomLevel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaxZoomLevel_Ljava_lang_Integer_);
			return cb_setMaxZoomLevel_Ljava_lang_Integer_;
		}

		static void n_SetMaxZoomLevel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_zoomLevel)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer zoomLevel = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_zoomLevel, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxZoomLevel (zoomLevel);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxZoomLevel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setMaxZoomLevel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setMaxZoomLevel", "(Ljava/lang/Integer;)V", "GetSetMaxZoomLevel_Ljava_lang_Integer_Handler")]
		public virtual void SetMaxZoomLevel (global::Java.Lang.Integer zoomLevel)
		{
			if (id_setMaxZoomLevel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_setMaxZoomLevel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMaxZoomLevel", "(Ljava/lang/Integer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMaxZoomLevel_Ljava_lang_Integer_, new JValue (zoomLevel));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxZoomLevel", "(Ljava/lang/Integer;)V"), new JValue (zoomLevel));
		}

		static Delegate cb_setMinZoomLevel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMinZoomLevel_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMinZoomLevel_Ljava_lang_Integer_ == null)
				cb_setMinZoomLevel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinZoomLevel_Ljava_lang_Integer_);
			return cb_setMinZoomLevel_Ljava_lang_Integer_;
		}

		static void n_SetMinZoomLevel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_zoomLevel)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer zoomLevel = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_zoomLevel, JniHandleOwnership.DoNotTransfer);
			__this.SetMinZoomLevel (zoomLevel);
		}
#pragma warning restore 0169

		static IntPtr id_setMinZoomLevel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setMinZoomLevel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setMinZoomLevel", "(Ljava/lang/Integer;)V", "GetSetMinZoomLevel_Ljava_lang_Integer_Handler")]
		public virtual void SetMinZoomLevel (global::Java.Lang.Integer zoomLevel)
		{
			if (id_setMinZoomLevel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_setMinZoomLevel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMinZoomLevel", "(Ljava/lang/Integer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMinZoomLevel_Ljava_lang_Integer_, new JValue (zoomLevel));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinZoomLevel", "(Ljava/lang/Integer;)V"), new JValue (zoomLevel));
		}

		static Delegate cb_setMultiTouchControls_Z;
#pragma warning disable 0169
		static Delegate GetSetMultiTouchControls_ZHandler ()
		{
			if (cb_setMultiTouchControls_Z == null)
				cb_setMultiTouchControls_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMultiTouchControls_Z);
			return cb_setMultiTouchControls_Z;
		}

		static void n_SetMultiTouchControls_Z (IntPtr jnienv, IntPtr native__this, bool on)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMultiTouchControls (on);
		}
#pragma warning restore 0169

		static IntPtr id_setMultiTouchControls_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setMultiTouchControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMultiTouchControls", "(Z)V", "GetSetMultiTouchControls_ZHandler")]
		public virtual void SetMultiTouchControls (bool on)
		{
			if (id_setMultiTouchControls_Z == IntPtr.Zero)
				id_setMultiTouchControls_Z = JNIEnv.GetMethodID (class_ref, "setMultiTouchControls", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMultiTouchControls_Z, new JValue (on));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMultiTouchControls", "(Z)V"), new JValue (on));
		}

		static Delegate cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
		static Delegate GetSetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
		{
			if (cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
				cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
			return cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		}

		static bool n_SetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_aNewObjPosAndScale, IntPtr native_aTouchPoint)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale aNewObjPosAndScale = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (native_aNewObjPosAndScale, JniHandleOwnership.DoNotTransfer);
			global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo aTouchPoint = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_aTouchPoint, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetPositionAndScale (obj, aNewObjPosAndScale, aTouchPoint);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setPositionAndScale' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PositionAndScale'] and parameter[3][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
		[Register ("setPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Z", "GetSetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler")]
		public virtual bool SetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale aNewObjPosAndScale, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo aTouchPoint)
		{
			if (id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
				id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "setPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (obj), new JValue (aNewObjPosAndScale), new JValue (aTouchPoint));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Z"), new JValue (obj), new JValue (aNewObjPosAndScale), new JValue (aTouchPoint));
			return __ret;
		}

		static Delegate cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
#pragma warning disable 0169
		static Delegate GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler ()
		{
			if (cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == null)
				cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_);
			return cb_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		}

		static void n_SetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTileSource)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.TileSource.ITileSource aTileSource = (global::Osmdroid.TileProvider.TileSource.ITileSource)global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.ITileSource> (native_aTileSource, JniHandleOwnership.DoNotTransfer);
			__this.SetTileSource (aTileSource);
		}
#pragma warning restore 0169

		static IntPtr id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setTileSource' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource']]"
		[Register ("setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V", "GetSetTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Handler")]
		public virtual void SetTileSource (global::Osmdroid.TileProvider.TileSource.ITileSource aTileSource)
		{
			if (id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ == IntPtr.Zero)
				id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_ = JNIEnv.GetMethodID (class_ref, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTileSource_Lorg_osmdroid_tileprovider_tilesource_ITileSource_, new JValue (aTileSource));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileSource", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;)V"), new JValue (aTileSource));
		}

		static Delegate cb_setUseDataConnection_Z;
#pragma warning disable 0169
		static Delegate GetSetUseDataConnection_ZHandler ()
		{
			if (cb_setUseDataConnection_Z == null)
				cb_setUseDataConnection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseDataConnection_Z);
			return cb_setUseDataConnection_Z;
		}

		static void n_SetUseDataConnection_Z (IntPtr jnienv, IntPtr native__this, bool aMode)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUseDataConnection (aMode);
		}
#pragma warning restore 0169

		static IntPtr id_setUseDataConnection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='setUseDataConnection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUseDataConnection", "(Z)V", "GetSetUseDataConnection_ZHandler")]
		public virtual void SetUseDataConnection (bool aMode)
		{
			if (id_setUseDataConnection_Z == IntPtr.Zero)
				id_setUseDataConnection_Z = JNIEnv.GetMethodID (class_ref, "setUseDataConnection", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUseDataConnection_Z, new JValue (aMode));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseDataConnection", "(Z)V"), new JValue (aMode));
		}

		static Delegate cb_useDataConnection;
#pragma warning disable 0169
		static Delegate GetUseDataConnectionHandler ()
		{
			if (cb_useDataConnection == null)
				cb_useDataConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseDataConnection);
			return cb_useDataConnection;
		}

		static bool n_UseDataConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDataConnection ();
		}
#pragma warning restore 0169

		static IntPtr id_useDataConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='useDataConnection' and count(parameter)=0]"
		[Register ("useDataConnection", "()Z", "GetUseDataConnectionHandler")]
		public virtual bool UseDataConnection ()
		{
			if (id_useDataConnection == IntPtr.Zero)
				id_useDataConnection = JNIEnv.GetMethodID (class_ref, "useDataConnection", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_useDataConnection);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useDataConnection", "()Z"));
		}

		static Delegate cb_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_;
#pragma warning disable 0169
		static Delegate GetZoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_Handler ()
		{
			if (cb_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_ == null)
				cb_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ZoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_);
			return cb_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_;
		}

		static void n_ZoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_ (IntPtr jnienv, IntPtr native__this, IntPtr native_boundingBox)
		{
			global::Osmdroid.Views.MapView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.BoundingBoxE6 boundingBox = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (native_boundingBox, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToBoundingBox (boundingBox);
		}
#pragma warning restore 0169

		static IntPtr id_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views']/class[@name='MapView']/method[@name='zoomToBoundingBox' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6']]"
		[Register ("zoomToBoundingBox", "(Lorg/osmdroid/util/BoundingBoxE6;)V", "GetZoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_Handler")]
		public virtual void ZoomToBoundingBox (global::Org.Osmdroid.Util.BoundingBoxE6 boundingBox)
		{
			if (id_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_ == IntPtr.Zero)
				id_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_ = JNIEnv.GetMethodID (class_ref, "zoomToBoundingBox", "(Lorg/osmdroid/util/BoundingBoxE6;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_zoomToBoundingBox_Lorg_osmdroid_util_BoundingBoxE6_, new JValue (boundingBox));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "zoomToBoundingBox", "(Lorg/osmdroid/util/BoundingBoxE6;)V"), new JValue (boundingBox));
		}

#region "Event implementation for Osmdroid.Events.IMapListener"
		public event EventHandler<global::Osmdroid.Events.ScrollEventArgs> Scroll {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Events.IMapListener, global::Osmdroid.Events.IMapListenerImplementor>(
						ref weak_implementor_SetMapListener,
						__CreateIMapListenerImplementor,
						SetMapListener,
						__h => __h.OnScrollHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Events.IMapListener, global::Osmdroid.Events.IMapListenerImplementor>(
						ref weak_implementor_SetMapListener,
						global::Osmdroid.Events.IMapListenerImplementor.__IsEmpty,
						__v => SetMapListener (null),
						__h => __h.OnScrollHandler -= value);
			}
		}

		public event EventHandler<global::Osmdroid.Events.ZoomEventArgs> Zoom {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Events.IMapListener, global::Osmdroid.Events.IMapListenerImplementor>(
						ref weak_implementor_SetMapListener,
						__CreateIMapListenerImplementor,
						SetMapListener,
						__h => __h.OnZoomHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Events.IMapListener, global::Osmdroid.Events.IMapListenerImplementor>(
						ref weak_implementor_SetMapListener,
						global::Osmdroid.Events.IMapListenerImplementor.__IsEmpty,
						__v => SetMapListener (null),
						__h => __h.OnZoomHandler -= value);
			}
		}

		WeakReference weak_implementor_SetMapListener;

		global::Osmdroid.Events.IMapListenerImplementor __CreateIMapListenerImplementor ()
		{
			return new global::Osmdroid.Events.IMapListenerImplementor (this);
		}
#endregion
		// This method is explicitly implemented as a member of an instantiated Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas
		global::Java.Lang.Object global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas.GetDraggableObjectAtPoint (global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(GetDraggableObjectAtPoint (touchPoint));
		}

		// This method is explicitly implemented as a member of an instantiated Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas
		void global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas.GetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut)
		{
			GetPositionAndScale (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(obj), objPosAndScaleOut);
		}

		// This method is explicitly implemented as a member of an instantiated Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas
		void global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas.SelectObject (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
		{
			SelectObject (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(obj), touchPoint);
		}

		// This method is explicitly implemented as a member of an instantiated Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas
		bool global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas.SetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale newObjPosAndScale, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
		{
			return SetPositionAndScale (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Java.Lang.Object>(obj), newObjPosAndScale, touchPoint);
		}

	}
}
