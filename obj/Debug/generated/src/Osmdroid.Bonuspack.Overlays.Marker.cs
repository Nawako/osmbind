using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Marker", DoNotGenerateAcw=true)]
	public partial class Marker : global::Osmdroid.Views.Overlay.Overlay {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='ANCHOR_BOTTOM']"
		[Register ("ANCHOR_BOTTOM")]
		public const float AnchorBottom = (float) 1.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='ANCHOR_CENTER']"
		[Register ("ANCHOR_CENTER")]
		public const float AnchorCenter = (float) 0.500000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='ANCHOR_LEFT']"
		[Register ("ANCHOR_LEFT")]
		public const float AnchorLeft = (float) 0.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='ANCHOR_RIGHT']"
		[Register ("ANCHOR_RIGHT")]
		public const float AnchorRight = (float) 1.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='ANCHOR_TOP']"
		[Register ("ANCHOR_TOP")]
		public const float AnchorTop = (float) 0.000000;

		static IntPtr mAlpha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mAlpha']"
		[Register ("mAlpha")]
		protected float MAlpha {
			get {
				if (mAlpha_jfieldId == IntPtr.Zero)
					mAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlpha", "F");
				return JNIEnv.GetFloatField (Handle, mAlpha_jfieldId);
			}
			set {
				if (mAlpha_jfieldId == IntPtr.Zero)
					mAlpha_jfieldId = JNIEnv.GetFieldID (class_ref, "mAlpha", "F");
				JNIEnv.SetField (Handle, mAlpha_jfieldId, value);
			}
		}

		static IntPtr mAnchorU_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mAnchorU']"
		[Register ("mAnchorU")]
		protected float MAnchorU {
			get {
				if (mAnchorU_jfieldId == IntPtr.Zero)
					mAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorU", "F");
				return JNIEnv.GetFloatField (Handle, mAnchorU_jfieldId);
			}
			set {
				if (mAnchorU_jfieldId == IntPtr.Zero)
					mAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorU", "F");
				JNIEnv.SetField (Handle, mAnchorU_jfieldId, value);
			}
		}

		static IntPtr mAnchorV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mAnchorV']"
		[Register ("mAnchorV")]
		protected float MAnchorV {
			get {
				if (mAnchorV_jfieldId == IntPtr.Zero)
					mAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorV", "F");
				return JNIEnv.GetFloatField (Handle, mAnchorV_jfieldId);
			}
			set {
				if (mAnchorV_jfieldId == IntPtr.Zero)
					mAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorV", "F");
				JNIEnv.SetField (Handle, mAnchorV_jfieldId, value);
			}
		}

		static IntPtr mBearing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mBearing']"
		[Register ("mBearing")]
		protected float MBearing {
			get {
				if (mBearing_jfieldId == IntPtr.Zero)
					mBearing_jfieldId = JNIEnv.GetFieldID (class_ref, "mBearing", "F");
				return JNIEnv.GetFloatField (Handle, mBearing_jfieldId);
			}
			set {
				if (mBearing_jfieldId == IntPtr.Zero)
					mBearing_jfieldId = JNIEnv.GetFieldID (class_ref, "mBearing", "F");
				JNIEnv.SetField (Handle, mBearing_jfieldId, value);
			}
		}

		static IntPtr mDefaultIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mDefaultIcon']"
		[Register ("mDefaultIcon")]
		protected static global::Android.Graphics.Drawables.Drawable MDefaultIcon {
			get {
				if (mDefaultIcon_jfieldId == IntPtr.Zero)
					mDefaultIcon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultIcon", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mDefaultIcon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDefaultIcon_jfieldId == IntPtr.Zero)
					mDefaultIcon_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultIcon", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mDefaultIcon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDefaultInfoWindow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mDefaultInfoWindow']"
		[Register ("mDefaultInfoWindow")]
		protected static global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow MDefaultInfoWindow {
			get {
				if (mDefaultInfoWindow_jfieldId == IntPtr.Zero)
					mDefaultInfoWindow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultInfoWindow", "Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mDefaultInfoWindow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDefaultInfoWindow_jfieldId == IntPtr.Zero)
					mDefaultInfoWindow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mDefaultInfoWindow", "Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mDefaultInfoWindow_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDraggable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mDraggable']"
		[Register ("mDraggable")]
		protected bool MDraggable {
			get {
				if (mDraggable_jfieldId == IntPtr.Zero)
					mDraggable_jfieldId = JNIEnv.GetFieldID (class_ref, "mDraggable", "Z");
				return JNIEnv.GetBooleanField (Handle, mDraggable_jfieldId);
			}
			set {
				if (mDraggable_jfieldId == IntPtr.Zero)
					mDraggable_jfieldId = JNIEnv.GetFieldID (class_ref, "mDraggable", "Z");
				JNIEnv.SetField (Handle, mDraggable_jfieldId, value);
			}
		}

		static IntPtr mFlat_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mFlat']"
		[Register ("mFlat")]
		protected bool MFlat {
			get {
				if (mFlat_jfieldId == IntPtr.Zero)
					mFlat_jfieldId = JNIEnv.GetFieldID (class_ref, "mFlat", "Z");
				return JNIEnv.GetBooleanField (Handle, mFlat_jfieldId);
			}
			set {
				if (mFlat_jfieldId == IntPtr.Zero)
					mFlat_jfieldId = JNIEnv.GetFieldID (class_ref, "mFlat", "Z");
				JNIEnv.SetField (Handle, mFlat_jfieldId, value);
			}
		}

		static IntPtr mIWAnchorU_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mIWAnchorU']"
		[Register ("mIWAnchorU")]
		protected float MIWAnchorU {
			get {
				if (mIWAnchorU_jfieldId == IntPtr.Zero)
					mIWAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mIWAnchorU", "F");
				return JNIEnv.GetFloatField (Handle, mIWAnchorU_jfieldId);
			}
			set {
				if (mIWAnchorU_jfieldId == IntPtr.Zero)
					mIWAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mIWAnchorU", "F");
				JNIEnv.SetField (Handle, mIWAnchorU_jfieldId, value);
			}
		}

		static IntPtr mIWAnchorV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mIWAnchorV']"
		[Register ("mIWAnchorV")]
		protected float MIWAnchorV {
			get {
				if (mIWAnchorV_jfieldId == IntPtr.Zero)
					mIWAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mIWAnchorV", "F");
				return JNIEnv.GetFloatField (Handle, mIWAnchorV_jfieldId);
			}
			set {
				if (mIWAnchorV_jfieldId == IntPtr.Zero)
					mIWAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mIWAnchorV", "F");
				JNIEnv.SetField (Handle, mIWAnchorV_jfieldId, value);
			}
		}

		static IntPtr mIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mIcon']"
		[Register ("mIcon")]
		protected global::Android.Graphics.Drawables.Drawable MIcon {
			get {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mIcon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mIcon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mImage']"
		[Register ("mImage")]
		protected global::Android.Graphics.Drawables.Drawable MImage {
			get {
				if (mImage_jfieldId == IntPtr.Zero)
					mImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mImage", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mImage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mImage_jfieldId == IntPtr.Zero)
					mImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mImage", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mImage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mInfoWindow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mInfoWindow']"
		[Register ("mInfoWindow")]
		protected global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow MInfoWindow {
			get {
				if (mInfoWindow_jfieldId == IntPtr.Zero)
					mInfoWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mInfoWindow", "Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mInfoWindow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mInfoWindow_jfieldId == IntPtr.Zero)
					mInfoWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mInfoWindow", "Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mInfoWindow_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mIsDragged_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mIsDragged']"
		[Register ("mIsDragged")]
		protected bool MIsDragged {
			get {
				if (mIsDragged_jfieldId == IntPtr.Zero)
					mIsDragged_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDragged", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsDragged_jfieldId);
			}
			set {
				if (mIsDragged_jfieldId == IntPtr.Zero)
					mIsDragged_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsDragged", "Z");
				JNIEnv.SetField (Handle, mIsDragged_jfieldId, value);
			}
		}

		static IntPtr mOnMarkerClickListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mOnMarkerClickListener']"
		[Register ("mOnMarkerClickListener")]
		protected global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener MOnMarkerClickListener {
			get {
				if (mOnMarkerClickListener_jfieldId == IntPtr.Zero)
					mOnMarkerClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnMarkerClickListener", "Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOnMarkerClickListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnMarkerClickListener_jfieldId == IntPtr.Zero)
					mOnMarkerClickListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnMarkerClickListener", "Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOnMarkerClickListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mOnMarkerDragListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mOnMarkerDragListener']"
		[Register ("mOnMarkerDragListener")]
		protected global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener MOnMarkerDragListener {
			get {
				if (mOnMarkerDragListener_jfieldId == IntPtr.Zero)
					mOnMarkerDragListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnMarkerDragListener", "Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOnMarkerDragListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnMarkerDragListener_jfieldId == IntPtr.Zero)
					mOnMarkerDragListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnMarkerDragListener", "Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOnMarkerDragListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPanToView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mPanToView']"
		[Register ("mPanToView")]
		protected bool MPanToView {
			get {
				if (mPanToView_jfieldId == IntPtr.Zero)
					mPanToView_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanToView", "Z");
				return JNIEnv.GetBooleanField (Handle, mPanToView_jfieldId);
			}
			set {
				if (mPanToView_jfieldId == IntPtr.Zero)
					mPanToView_jfieldId = JNIEnv.GetFieldID (class_ref, "mPanToView", "Z");
				JNIEnv.SetField (Handle, mPanToView_jfieldId, value);
			}
		}

		static IntPtr mPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mPosition']"
		[Register ("mPosition")]
		protected global::Org.Osmdroid.Util.GeoPoint MPosition {
			get {
				if (mPosition_jfieldId == IntPtr.Zero)
					mPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mPosition", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPosition_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPosition_jfieldId == IntPtr.Zero)
					mPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mPosition", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPosition_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPositionPixels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mPositionPixels']"
		[Register ("mPositionPixels")]
		protected global::Android.Graphics.Point MPositionPixels {
			get {
				if (mPositionPixels_jfieldId == IntPtr.Zero)
					mPositionPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionPixels", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPositionPixels_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPositionPixels_jfieldId == IntPtr.Zero)
					mPositionPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionPixels", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPositionPixels_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mRelatedObject_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mRelatedObject']"
		[Register ("mRelatedObject")]
		protected global::Java.Lang.Object MRelatedObject {
			get {
				if (mRelatedObject_jfieldId == IntPtr.Zero)
					mRelatedObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mRelatedObject", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRelatedObject_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRelatedObject_jfieldId == IntPtr.Zero)
					mRelatedObject_jfieldId = JNIEnv.GetFieldID (class_ref, "mRelatedObject", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mRelatedObject_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSnippet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mSnippet']"
		[Register ("mSnippet")]
		protected string MSnippet {
			get {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSnippet_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mSnippet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSubDescription_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mSubDescription']"
		[Register ("mSubDescription")]
		protected string MSubDescription {
			get {
				if (mSubDescription_jfieldId == IntPtr.Zero)
					mSubDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "mSubDescription", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSubDescription_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSubDescription_jfieldId == IntPtr.Zero)
					mSubDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "mSubDescription", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mSubDescription_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/field[@name='mTitle']"
		[Register ("mTitle")]
		protected string MTitle {
			get {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTitle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mTitle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerClickListener']"
		[Register ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener", "", "Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker'] and parameter[2][@type='org.osmdroid.views.MapView']]"
			[Register ("onMarkerClick", "(Lorg/osmdroid/bonuspack/overlays/Marker;Lorg/osmdroid/views/MapView;)Z", "GetOnMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_Handler:Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerClickListenerInvoker, OsmdroidAndroidBinding")]
			bool OnMarkerClick (global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Osmdroid.Views.MapView p1);

		}

		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener");
			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.bonuspack.overlays.Marker.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerClickListenerInvoker); }
			}

			static Delegate cb_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_Handler ()
			{
				if (cb_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ == null)
					cb_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_);
				return cb_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
			}

			static bool n_OnMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
			public bool OnMarkerClick (global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Osmdroid.Views.MapView p1)
			{
				if (id_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
					id_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lorg/osmdroid/bonuspack/overlays/Marker;Lorg/osmdroid/views/MapView;)Z");
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onMarkerClick_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
				return __ret;
			}

		}

		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Osmdroid.Views.MapView p1)
			{
				this.handled = handled;
				this.p0 = p0;
				this.p1 = p1;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Osmdroid.Bonuspack.Overlays.Marker p0;
			public global::Osmdroid.Bonuspack.Overlays.Marker P0 {
				get { return p0; }
			}

			global::Osmdroid.Views.MapView p1;
			public global::Osmdroid.Views.MapView P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/bonuspack/overlays/Marker_OnMarkerClickListenerImplementor")]
		internal sealed class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/bonuspack/overlays/Marker_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Osmdroid.Views.MapView p1)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0, p1);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerDragListener']"
		[Register ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener", "", "Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerDragListenerInvoker")]
		public partial interface IOnMarkerDragListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerDragListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
			[Register ("onMarkerDrag", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V", "GetOnMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_Handler:Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerDragListenerInvoker, OsmdroidAndroidBinding")]
			void OnMarkerDrag (global::Osmdroid.Bonuspack.Overlays.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerDragListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
			[Register ("onMarkerDragEnd", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V", "GetOnMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler:Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerDragListenerInvoker, OsmdroidAndroidBinding")]
			void OnMarkerDragEnd (global::Osmdroid.Bonuspack.Overlays.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/interface[@name='Marker.OnMarkerDragListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
			[Register ("onMarkerDragStart", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V", "GetOnMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_Handler:Osmdroid.Bonuspack.Overlays.Marker/IOnMarkerDragListenerInvoker, OsmdroidAndroidBinding")]
			void OnMarkerDragStart (global::Osmdroid.Bonuspack.Overlays.Marker p0);

		}

		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener");
			IntPtr class_ref;

			public static IOnMarkerDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.bonuspack.overlays.Marker.OnMarkerDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnMarkerDragListenerInvoker); }
			}

			static Delegate cb_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
					cb_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_);
				return cb_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_;
			}

			static void n_OnMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_;
			public void OnMarkerDrag (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				if (id_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDrag_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
					cb_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_);
				return cb_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_;
			}

			static void n_OnMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_;
			public void OnMarkerDragEnd (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				if (id_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragEnd_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (p0));
			}

			static Delegate cb_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
					cb_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_);
				return cb_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_;
			}

			static void n_OnMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_;
			public void OnMarkerDragStart (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				if (id_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V");
				JNIEnv.CallVoidMethod (Handle, id_onMarkerDragStart_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (p0));
			}

		}

		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				this.p0 = p0;
			}

			global::Osmdroid.Bonuspack.Overlays.Marker p0;
			public global::Osmdroid.Bonuspack.Overlays.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				this.p0 = p0;
			}

			global::Osmdroid.Bonuspack.Overlays.Marker p0;
			public global::Osmdroid.Bonuspack.Overlays.Marker P0 {
				get { return p0; }
			}
		}

		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				this.p0 = p0;
			}

			global::Osmdroid.Bonuspack.Overlays.Marker p0;
			public global::Osmdroid.Bonuspack.Overlays.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/bonuspack/overlays/Marker_OnMarkerDragListenerImplementor")]
		internal sealed class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener {

			object sender;

			public IOnMarkerDragListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/bonuspack/overlays/Marker_OnMarkerDragListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				var __h = OnMarkerDragHandler;
				if (__h != null)
					__h (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				var __h = OnMarkerDragEndHandler;
				if (__h != null)
					__h (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Osmdroid.Bonuspack.Overlays.Marker p0)
			{
				var __h = OnMarkerDragStartHandler;
				if (__h != null)
					__h (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDragListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;)V", "")]
		public Marker (global::Osmdroid.Views.MapView p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Marker)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=2 and parameter[1][@type='org.osmdroid.views.MapView'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", "")]
		public Marker (global::Osmdroid.Views.MapView p0, global::Osmdroid.IResourceProxy p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Marker)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/views/MapView;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_views_MapView_Lorg_osmdroid_ResourceProxy_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getAlpha;
#pragma warning disable 0169
		static Delegate GetGetAlphaHandler ()
		{
			if (cb_getAlpha == null)
				cb_getAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAlpha);
			return cb_getAlpha;
		}

		static float n_GetAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alpha;
		}
#pragma warning restore 0169

		static Delegate cb_setAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetAlpha_FHandler ()
		{
			if (cb_setAlpha_F == null)
				cb_setAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlpha_F);
			return cb_setAlpha_F;
		}

		static void n_SetAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alpha = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public virtual float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlpha", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_isDraggable;
#pragma warning disable 0169
		static Delegate GetIsDraggableHandler ()
		{
			if (cb_isDraggable == null)
				cb_isDraggable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDraggable);
			return cb_isDraggable;
		}

		static bool n_IsDraggable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Draggable;
		}
#pragma warning restore 0169

		static Delegate cb_setDraggable_Z;
#pragma warning disable 0169
		static Delegate GetSetDraggable_ZHandler ()
		{
			if (cb_setDraggable_Z == null)
				cb_setDraggable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDraggable_Z);
			return cb_setDraggable_Z;
		}

		static void n_SetDraggable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draggable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDraggable;
		static IntPtr id_setDraggable_Z;
		public virtual bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				if (id_isDraggable == IntPtr.Zero)
					id_isDraggable = JNIEnv.GetMethodID (class_ref, "isDraggable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isDraggable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDraggable", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				if (id_setDraggable_Z == IntPtr.Zero)
					id_setDraggable_Z = JNIEnv.GetMethodID (class_ref, "setDraggable", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDraggable_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDraggable", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isFlat;
#pragma warning disable 0169
		static Delegate GetIsFlatHandler ()
		{
			if (cb_isFlat == null)
				cb_isFlat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFlat);
			return cb_isFlat;
		}

		static bool n_IsFlat (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flat;
		}
#pragma warning restore 0169

		static Delegate cb_setFlat_Z;
#pragma warning disable 0169
		static Delegate GetSetFlat_ZHandler ()
		{
			if (cb_setFlat_Z == null)
				cb_setFlat_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFlat_Z);
			return cb_setFlat_Z;
		}

		static void n_SetFlat_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flat = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isFlat;
		static IntPtr id_setFlat_Z;
		public virtual bool Flat {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='isFlat' and count(parameter)=0]"
			[Register ("isFlat", "()Z", "GetIsFlatHandler")]
			get {
				if (id_isFlat == IntPtr.Zero)
					id_isFlat = JNIEnv.GetMethodID (class_ref, "isFlat", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isFlat);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFlat", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setFlat' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlat", "(Z)V", "GetSetFlat_ZHandler")]
			set {
				if (id_setFlat_Z == IntPtr.Zero)
					id_setFlat_Z = JNIEnv.GetMethodID (class_ref, "setFlat", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFlat_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlat", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_drawable_Drawable_);
			return cb_setImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Landroid_graphics_drawable_Drawable_;
		public virtual global::Android.Graphics.Drawables.Drawable Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/drawable/Drawable;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetImage_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setImage_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setImage_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImage_Landroid_graphics_drawable_Drawable_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (value));
			}
		}

		static Delegate cb_isInfoWindowShown;
#pragma warning disable 0169
		static Delegate GetIsInfoWindowShownHandler ()
		{
			if (cb_isInfoWindowShown == null)
				cb_isInfoWindowShown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInfoWindowShown);
			return cb_isInfoWindowShown;
		}

		static bool n_IsInfoWindowShown (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInfoWindowShown;
		}
#pragma warning restore 0169

		static IntPtr id_isInfoWindowShown;
		public virtual bool IsInfoWindowShown {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='isInfoWindowShown' and count(parameter)=0]"
			[Register ("isInfoWindowShown", "()Z", "GetIsInfoWindowShownHandler")]
			get {
				if (id_isInfoWindowShown == IntPtr.Zero)
					id_isInfoWindowShown = JNIEnv.GetMethodID (class_ref, "isInfoWindowShown", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isInfoWindowShown);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInfoWindowShown", "()Z"));
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_setPosition_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lorg_osmdroid_util_GeoPoint_);
			return cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
		}

		static void n_SetPosition_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lorg_osmdroid_util_GeoPoint_;
		public virtual global::Org.Osmdroid.Util.GeoPoint Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lorg/osmdroid/util/GeoPoint;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
			[Register ("setPosition", "(Lorg/osmdroid/util/GeoPoint;)V", "GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler")]
			set {
				if (id_setPosition_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
					id_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lorg_osmdroid_util_GeoPoint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRelatedObject;
#pragma warning disable 0169
		static Delegate GetGetRelatedObjectHandler ()
		{
			if (cb_getRelatedObject == null)
				cb_getRelatedObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelatedObject);
			return cb_getRelatedObject;
		}

		static IntPtr n_GetRelatedObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RelatedObject);
		}
#pragma warning restore 0169

		static Delegate cb_setRelatedObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetRelatedObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setRelatedObject_Ljava_lang_Object_ == null)
				cb_setRelatedObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRelatedObject_Ljava_lang_Object_);
			return cb_setRelatedObject_Ljava_lang_Object_;
		}

		static void n_SetRelatedObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RelatedObject = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRelatedObject;
		static IntPtr id_setRelatedObject_Ljava_lang_Object_;
		public virtual global::Java.Lang.Object RelatedObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getRelatedObject' and count(parameter)=0]"
			[Register ("getRelatedObject", "()Ljava/lang/Object;", "GetGetRelatedObjectHandler")]
			get {
				if (id_getRelatedObject == IntPtr.Zero)
					id_getRelatedObject = JNIEnv.GetMethodID (class_ref, "getRelatedObject", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getRelatedObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelatedObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setRelatedObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setRelatedObject", "(Ljava/lang/Object;)V", "GetSetRelatedObject_Ljava_lang_Object_Handler")]
			set {
				if (id_setRelatedObject_Ljava_lang_Object_ == IntPtr.Zero)
					id_setRelatedObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setRelatedObject", "(Ljava/lang/Object;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRelatedObject_Ljava_lang_Object_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRelatedObject", "(Ljava/lang/Object;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRotation;
#pragma warning disable 0169
		static Delegate GetGetRotationHandler ()
		{
			if (cb_getRotation == null)
				cb_getRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRotation);
			return cb_getRotation;
		}

		static float n_GetRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rotation;
		}
#pragma warning restore 0169

		static Delegate cb_setRotation_F;
#pragma warning disable 0169
		static Delegate GetSetRotation_FHandler ()
		{
			if (cb_setRotation_F == null)
				cb_setRotation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotation_F);
			return cb_setRotation_F;
		}

		static void n_SetRotation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rotation = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_F;
		public virtual float Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()F", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getRotation);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotation", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotation", "(F)V", "GetSetRotation_FHandler")]
			set {
				if (id_setRotation_F == IntPtr.Zero)
					id_setRotation_F = JNIEnv.GetMethodID (class_ref, "setRotation", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRotation_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getSnippet;
#pragma warning disable 0169
		static Delegate GetGetSnippetHandler ()
		{
			if (cb_getSnippet == null)
				cb_getSnippet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnippet);
			return cb_getSnippet;
		}

		static IntPtr n_GetSnippet (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

		static Delegate cb_setSnippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_setSnippet_Ljava_lang_String_ == null)
				cb_setSnippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSnippet_Ljava_lang_String_);
			return cb_setSnippet_Ljava_lang_String_;
		}

		static void n_SetSnippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Snippet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSnippet;
		static IntPtr id_setSnippet_Ljava_lang_String_;
		public virtual string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSnippet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
			set {
				if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
					id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSnippet_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSnippet", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSubDescription;
#pragma warning disable 0169
		static Delegate GetGetSubDescriptionHandler ()
		{
			if (cb_getSubDescription == null)
				cb_getSubDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubDescription);
			return cb_getSubDescription;
		}

		static IntPtr n_GetSubDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setSubDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setSubDescription_Ljava_lang_String_ == null)
				cb_setSubDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubDescription_Ljava_lang_String_);
			return cb_setSubDescription_Ljava_lang_String_;
		}

		static void n_SetSubDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubDescription;
		static IntPtr id_setSubDescription_Ljava_lang_String_;
		public virtual string SubDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getSubDescription' and count(parameter)=0]"
			[Register ("getSubDescription", "()Ljava/lang/String;", "GetGetSubDescriptionHandler")]
			get {
				if (id_getSubDescription == IntPtr.Zero)
					id_getSubDescription = JNIEnv.GetMethodID (class_ref, "getSubDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSubDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setSubDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubDescription", "(Ljava/lang/String;)V", "GetSetSubDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setSubDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setSubDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSubDescription_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubDescription", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_hideInfoWindow;
#pragma warning disable 0169
		static Delegate GetHideInfoWindowHandler ()
		{
			if (cb_hideInfoWindow == null)
				cb_hideInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInfoWindow);
			return cb_hideInfoWindow;
		}

		static void n_HideInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_hideInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "GetHideInfoWindowHandler")]
		public virtual void HideInfoWindow ()
		{
			if (id_hideInfoWindow == IntPtr.Zero)
				id_hideInfoWindow = JNIEnv.GetMethodID (class_ref, "hideInfoWindow", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hideInfoWindow);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideInfoWindow", "()V"));
		}

		static Delegate cb_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetHitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_HitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_HitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HitTest (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='hitTest' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("hitTest", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetHitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool HitTest (global::Android.Views.MotionEvent p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "hitTest", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_hitTest_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hitTest", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetMoveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MoveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static void n_MoveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MoveToEventPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='moveToEventPosition' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("moveToEventPosition", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V", "GetMoveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void MoveToEventPosition (global::Android.Views.MotionEvent p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "moveToEventPosition", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_moveToEventPosition_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveToEventPosition", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ == null)
				cb_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_);
			return cb_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnMarkerClickDefault (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='onMarkerClickDefault' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("onMarkerClickDefault", "(Lorg/osmdroid/bonuspack/overlays/Marker;Lorg/osmdroid/views/MapView;)Z", "GetOnMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_Handler")]
		protected virtual bool OnMarkerClickDefault (global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onMarkerClickDefault", "(Lorg/osmdroid/bonuspack/overlays/Marker;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onMarkerClickDefault_Lorg_osmdroid_bonuspack_overlays_Marker_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onMarkerClickDefault", "(Lorg/osmdroid/bonuspack/overlays/Marker;Lorg/osmdroid/views/MapView;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
		}

		static Delegate cb_remove_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetRemove_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_remove_Lorg_osmdroid_views_MapView_ == null)
				cb_remove_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lorg_osmdroid_views_MapView_);
			return cb_remove_Lorg_osmdroid_views_MapView_;
		}

		static void n_Remove_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("remove", "(Lorg/osmdroid/views/MapView;)V", "GetRemove_Lorg_osmdroid_views_MapView_Handler")]
		public virtual void Remove (global::Osmdroid.Views.MapView p0)
		{
			if (id_remove_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_remove_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lorg/osmdroid/views/MapView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_remove_Lorg_osmdroid_views_MapView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lorg/osmdroid/views/MapView;)V"), new JValue (p0));
		}

		static Delegate cb_setAnchor_FF;
#pragma warning disable 0169
		static Delegate GetSetAnchor_FFHandler ()
		{
			if (cb_setAnchor_FF == null)
				cb_setAnchor_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetAnchor_FF);
			return cb_setAnchor_FF;
		}

		static void n_SetAnchor_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnchor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "GetSetAnchor_FFHandler")]
		public virtual void SetAnchor (float p0, float p1)
		{
			if (id_setAnchor_FF == IntPtr.Zero)
				id_setAnchor_FF = JNIEnv.GetMethodID (class_ref, "setAnchor", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAnchor_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnchor", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetIcon (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_;
#pragma warning disable 0169
		static Delegate GetSetInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_Handler ()
		{
			if (cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_ == null)
				cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_);
			return cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_;
		}

		static void n_SetInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setInfoWindow' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.MarkerInfoWindow']]"
		[Register ("setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;)V", "GetSetInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_Handler")]
		public virtual void SetInfoWindow (global::Osmdroid.Bonuspack.Overlays.MarkerInfoWindow p0)
		{
			if (id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_ == IntPtr.Zero)
				id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_ = JNIEnv.GetMethodID (class_ref, "setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_MarkerInfoWindow_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/MarkerInfoWindow;)V"), new JValue (p0));
		}

		static Delegate cb_setInfoWindowAnchor_FF;
#pragma warning disable 0169
		static Delegate GetSetInfoWindowAnchor_FFHandler ()
		{
			if (cb_setInfoWindowAnchor_FF == null)
				cb_setInfoWindowAnchor_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetInfoWindowAnchor_FF);
			return cb_setInfoWindowAnchor_FF;
		}

		static void n_SetInfoWindowAnchor_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindowAnchor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setInfoWindowAnchor_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setInfoWindowAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setInfoWindowAnchor", "(FF)V", "GetSetInfoWindowAnchor_FFHandler")]
		public virtual void SetInfoWindowAnchor (float p0, float p1)
		{
			if (id_setInfoWindowAnchor_FF == IntPtr.Zero)
				id_setInfoWindowAnchor_FF = JNIEnv.GetMethodID (class_ref, "setInfoWindowAnchor", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInfoWindowAnchor_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoWindowAnchor", "(FF)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_Handler ()
		{
			if (cb_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_ == null)
				cb_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_);
			return cb_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_;
		}

		static void n_SetOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener p0 = (global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerClickListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener;)V", "GetSetOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_Handler")]
		public virtual void SetOnMarkerClickListener (global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener p0)
		{
			if (id_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_ == IntPtr.Zero)
				id_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerClickListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerClickListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerClickListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMarkerClickListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerClickListener;)V"), new JValue (p0));
		}

		static Delegate cb_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_Handler ()
		{
			if (cb_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_ == null)
				cb_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_);
			return cb_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_;
		}

		static void n_SetOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener p0 = (global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerDragListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker.OnMarkerDragListener']]"
		[Register ("setOnMarkerDragListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener;)V", "GetSetOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_Handler")]
		public virtual void SetOnMarkerDragListener (global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener p0)
		{
			if (id_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_ == IntPtr.Zero)
				id_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_ = JNIEnv.GetMethodID (class_ref, "setOnMarkerDragListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnMarkerDragListener_Lorg_osmdroid_bonuspack_overlays_Marker_OnMarkerDragListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnMarkerDragListener", "(Lorg/osmdroid/bonuspack/overlays/Marker$OnMarkerDragListener;)V"), new JValue (p0));
		}

		static Delegate cb_setPanToView_Z;
#pragma warning disable 0169
		static Delegate GetSetPanToView_ZHandler ()
		{
			if (cb_setPanToView_Z == null)
				cb_setPanToView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPanToView_Z);
			return cb_setPanToView_Z;
		}

		static void n_SetPanToView_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPanToView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPanToView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='setPanToView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPanToView", "(Z)V", "GetSetPanToView_ZHandler")]
		public virtual void SetPanToView (bool p0)
		{
			if (id_setPanToView_Z == IntPtr.Zero)
				id_setPanToView_Z = JNIEnv.GetMethodID (class_ref, "setPanToView", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPanToView_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPanToView", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_showInfoWindow;
#pragma warning disable 0169
		static Delegate GetShowInfoWindowHandler ()
		{
			if (cb_showInfoWindow == null)
				cb_showInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowInfoWindow);
			return cb_showInfoWindow;
		}

		static void n_ShowInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindow ();
		}
#pragma warning restore 0169

		static IntPtr id_showInfoWindow;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Marker']/method[@name='showInfoWindow' and count(parameter)=0]"
		[Register ("showInfoWindow", "()V", "GetShowInfoWindowHandler")]
		public virtual void ShowInfoWindow ()
		{
			if (id_showInfoWindow == IntPtr.Zero)
				id_showInfoWindow = JNIEnv.GetMethodID (class_ref, "showInfoWindow", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showInfoWindow);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showInfoWindow", "()V"));
		}

#region "Event implementation for Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener"
		public event EventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener"
		public event EventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListener, global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor ()
		{
			return new global::Osmdroid.Bonuspack.Overlays.Marker.IOnMarkerDragListenerImplementor (this);
		}
#endregion
	}
}
