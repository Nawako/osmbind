using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/OverlayItem", DoNotGenerateAcw=true)]
	public partial class OverlayItem : global::Java.Lang.Object {


		static IntPtr DEFAULT_MARKER_SIZE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='DEFAULT_MARKER_SIZE']"
		[Register ("DEFAULT_MARKER_SIZE")]
		protected static global::Android.Graphics.Point DefaultMarkerSize {
			get {
				if (DEFAULT_MARKER_SIZE_jfieldId == IntPtr.Zero)
					DEFAULT_MARKER_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_MARKER_SIZE", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_MARKER_SIZE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_MARKER_SIZE_jfieldId == IntPtr.Zero)
					DEFAULT_MARKER_SIZE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT_MARKER_SIZE", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, DEFAULT_MARKER_SIZE_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='ITEM_STATE_FOCUSED_MASK']"
		[Register ("ITEM_STATE_FOCUSED_MASK")]
		public const int ItemStateFocusedMask = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='ITEM_STATE_PRESSED_MASK']"
		[Register ("ITEM_STATE_PRESSED_MASK")]
		public const int ItemStatePressedMask = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='ITEM_STATE_SELECTED_MASK']"
		[Register ("ITEM_STATE_SELECTED_MASK")]
		public const int ItemStateSelectedMask = (int) 2;

		static IntPtr mGeoPoint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mGeoPoint']"
		[Register ("mGeoPoint")]
		protected global::Org.Osmdroid.Util.GeoPoint MGeoPoint {
			get {
				if (mGeoPoint_jfieldId == IntPtr.Zero)
					mGeoPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mGeoPoint", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mGeoPoint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mGeoPoint_jfieldId == IntPtr.Zero)
					mGeoPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mGeoPoint", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mGeoPoint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mHotspotPlace_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mHotspotPlace']"
		[Register ("mHotspotPlace")]
		protected global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace MHotspotPlace {
			get {
				if (mHotspotPlace_jfieldId == IntPtr.Zero)
					mHotspotPlace_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotspotPlace", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHotspotPlace_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHotspotPlace_jfieldId == IntPtr.Zero)
					mHotspotPlace_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotspotPlace", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mHotspotPlace_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMarker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mMarker']"
		[Register ("mMarker")]
		protected global::Android.Graphics.Drawables.Drawable MMarker {
			get {
				if (mMarker_jfieldId == IntPtr.Zero)
					mMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarker", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMarker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMarker_jfieldId == IntPtr.Zero)
					mMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarker", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMarker_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSnippet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mSnippet']"
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

		static IntPtr mTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mTitle']"
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

		static IntPtr mUid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/field[@name='mUid']"
		[Register ("mUid")]
		protected string MUid {
			get {
				if (mUid_jfieldId == IntPtr.Zero)
					mUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mUid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUid_jfieldId == IntPtr.Zero)
					mUid_jfieldId = JNIEnv.GetFieldID (class_ref, "mUid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mUid_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']"
		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/OverlayItem$HotspotPlace", DoNotGenerateAcw=true)]
		public sealed partial class HotspotPlace : global::Java.Lang.Enum {


			static IntPtr BOTTOM_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace BottomCenter {
				get {
					if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
						BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
						BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOTTOM_CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace Center {
				get {
					if (CENTER_jfieldId == IntPtr.Zero)
						CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CENTER_jfieldId == IntPtr.Zero)
						CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LEFT_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='LEFT_CENTER']"
			[Register ("LEFT_CENTER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace LeftCenter {
				get {
					if (LEFT_CENTER_jfieldId == IntPtr.Zero)
						LEFT_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LEFT_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LEFT_CENTER_jfieldId == IntPtr.Zero)
						LEFT_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LEFT_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LEFT_CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOWER_LEFT_CORNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='LOWER_LEFT_CORNER']"
			[Register ("LOWER_LEFT_CORNER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace LowerLeftCorner {
				get {
					if (LOWER_LEFT_CORNER_jfieldId == IntPtr.Zero)
						LOWER_LEFT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_LEFT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWER_LEFT_CORNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOWER_LEFT_CORNER_jfieldId == IntPtr.Zero)
						LOWER_LEFT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_LEFT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOWER_LEFT_CORNER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr LOWER_RIGHT_CORNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='LOWER_RIGHT_CORNER']"
			[Register ("LOWER_RIGHT_CORNER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace LowerRightCorner {
				get {
					if (LOWER_RIGHT_CORNER_jfieldId == IntPtr.Zero)
						LOWER_RIGHT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_RIGHT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWER_RIGHT_CORNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (LOWER_RIGHT_CORNER_jfieldId == IntPtr.Zero)
						LOWER_RIGHT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_RIGHT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, LOWER_RIGHT_CORNER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr RIGHT_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='RIGHT_CENTER']"
			[Register ("RIGHT_CENTER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace RightCenter {
				get {
					if (RIGHT_CENTER_jfieldId == IntPtr.Zero)
						RIGHT_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RIGHT_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (RIGHT_CENTER_jfieldId == IntPtr.Zero)
						RIGHT_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RIGHT_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, RIGHT_CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr TOP_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='TOP_CENTER']"
			[Register ("TOP_CENTER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace TopCenter {
				get {
					if (TOP_CENTER_jfieldId == IntPtr.Zero)
						TOP_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TOP_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (TOP_CENTER_jfieldId == IntPtr.Zero)
						TOP_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TOP_CENTER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, TOP_CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPPER_LEFT_CORNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='UPPER_LEFT_CORNER']"
			[Register ("UPPER_LEFT_CORNER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace UpperLeftCorner {
				get {
					if (UPPER_LEFT_CORNER_jfieldId == IntPtr.Zero)
						UPPER_LEFT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_LEFT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPPER_LEFT_CORNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPPER_LEFT_CORNER_jfieldId == IntPtr.Zero)
						UPPER_LEFT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_LEFT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPPER_LEFT_CORNER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr UPPER_RIGHT_CORNER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/field[@name='UPPER_RIGHT_CORNER']"
			[Register ("UPPER_RIGHT_CORNER")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace UpperRightCorner {
				get {
					if (UPPER_RIGHT_CORNER_jfieldId == IntPtr.Zero)
						UPPER_RIGHT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_RIGHT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPPER_RIGHT_CORNER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (UPPER_RIGHT_CORNER_jfieldId == IntPtr.Zero)
						UPPER_RIGHT_CORNER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_RIGHT_CORNER", "Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, UPPER_RIGHT_CORNER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/overlay/OverlayItem$HotspotPlace", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HotspotPlace); }
			}

			internal HotspotPlace (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;", "")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
				IntPtr native_name = JNIEnv.NewString (name);
				global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_name);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem.HotspotPlace']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;", "")]
			public static global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");
				return (global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/OverlayItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OverlayItem); }
		}

		protected OverlayItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/constructor[@name='OverlayItem' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.osmdroid.util.GeoPoint']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", "")]
		public OverlayItem (string aTitle, string aSnippet, global::Org.Osmdroid.Util.GeoPoint aGeoPoint) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_aTitle = JNIEnv.NewString (aTitle);;
			IntPtr native_aSnippet = JNIEnv.NewString (aSnippet);;
			if (GetType () != typeof (OverlayItem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_aTitle), new JValue (native_aSnippet), new JValue (aGeoPoint)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_aTitle), new JValue (native_aSnippet), new JValue (aGeoPoint));
				JNIEnv.DeleteLocalRef (native_aTitle);
				JNIEnv.DeleteLocalRef (native_aSnippet);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_aTitle), new JValue (native_aSnippet), new JValue (aGeoPoint)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_aTitle), new JValue (native_aSnippet), new JValue (aGeoPoint));
			JNIEnv.DeleteLocalRef (native_aTitle);
			JNIEnv.DeleteLocalRef (native_aSnippet);
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/constructor[@name='OverlayItem' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.osmdroid.util.GeoPoint']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", "")]
		public OverlayItem (string aUid, string aTitle, string aDescription, global::Org.Osmdroid.Util.GeoPoint aGeoPoint) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_aUid = JNIEnv.NewString (aUid);;
			IntPtr native_aTitle = JNIEnv.NewString (aTitle);;
			IntPtr native_aDescription = JNIEnv.NewString (aDescription);;
			if (GetType () != typeof (OverlayItem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_aUid), new JValue (native_aTitle), new JValue (native_aDescription), new JValue (aGeoPoint)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_aUid), new JValue (native_aTitle), new JValue (native_aDescription), new JValue (aGeoPoint));
				JNIEnv.DeleteLocalRef (native_aUid);
				JNIEnv.DeleteLocalRef (native_aTitle);
				JNIEnv.DeleteLocalRef (native_aDescription);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_aUid), new JValue (native_aTitle), new JValue (native_aDescription), new JValue (aGeoPoint)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_aUid), new JValue (native_aTitle), new JValue (native_aDescription), new JValue (aGeoPoint));
			JNIEnv.DeleteLocalRef (native_aUid);
			JNIEnv.DeleteLocalRef (native_aTitle);
			JNIEnv.DeleteLocalRef (native_aDescription);
		}

		static Delegate cb_getDrawable;
#pragma warning disable 0169
		static Delegate GetGetDrawableHandler ()
		{
			if (cb_getDrawable == null)
				cb_getDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawable);
			return cb_getDrawable;
		}

		static IntPtr n_GetDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Drawable);
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable;
		public virtual global::Android.Graphics.Drawables.Drawable Drawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getDrawable' and count(parameter)=0]"
			[Register ("getDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetDrawableHandler")]
			get {
				if (id_getDrawable == IntPtr.Zero)
					id_getDrawable = JNIEnv.GetMethodID (class_ref, "getDrawable", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
			}
		}

		static Delegate cb_getMarkerHotspot;
#pragma warning disable 0169
		static Delegate GetGetMarkerHotspotHandler ()
		{
			if (cb_getMarkerHotspot == null)
				cb_getMarkerHotspot = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarkerHotspot);
			return cb_getMarkerHotspot;
		}

		static IntPtr n_GetMarkerHotspot (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MarkerHotspot);
		}
#pragma warning restore 0169

		static Delegate cb_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
#pragma warning disable 0169
		static Delegate GetSetMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_Handler ()
		{
			if (cb_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ == null)
				cb_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_);
			return cb_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
		}

		static void n_SetMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ (IntPtr jnienv, IntPtr native__this, IntPtr native_place)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace place = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (native_place, JniHandleOwnership.DoNotTransfer);
			__this.MarkerHotspot = place;
		}
#pragma warning restore 0169

		static IntPtr id_getMarkerHotspot;
		static IntPtr id_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_;
		public virtual global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace MarkerHotspot {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getMarkerHotspot' and count(parameter)=0]"
			[Register ("getMarkerHotspot", "()Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;", "GetGetMarkerHotspotHandler")]
			get {
				if (id_getMarkerHotspot == IntPtr.Zero)
					id_getMarkerHotspot = JNIEnv.GetMethodID (class_ref, "getMarkerHotspot", "()Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (JNIEnv.CallObjectMethod  (Handle, id_getMarkerHotspot), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarkerHotspot", "()Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='setMarkerHotspot' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem.HotspotPlace']]"
			[Register ("setMarkerHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)V", "GetSetMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_Handler")]
			set {
				if (id_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ == IntPtr.Zero)
					id_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_ = JNIEnv.GetMethodID (class_ref, "setMarkerHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMarkerHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarkerHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;)V"), new JValue (value));
			}
		}

		static Delegate cb_getPoint;
#pragma warning disable 0169
		static Delegate GetGetPointHandler ()
		{
			if (cb_getPoint == null)
				cb_getPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoint);
			return cb_getPoint;
		}

		static IntPtr n_GetPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Point);
		}
#pragma warning restore 0169

		static IntPtr id_getPoint;
		public virtual global::Org.Osmdroid.Util.GeoPoint Point {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getPoint' and count(parameter)=0]"
			[Register ("getPoint", "()Lorg/osmdroid/util/GeoPoint;", "GetGetPointHandler")]
			get {
				if (id_getPoint == IntPtr.Zero)
					id_getPoint = JNIEnv.GetMethodID (class_ref, "getPoint", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getPoint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoint", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

		static IntPtr id_getSnippet;
		public virtual string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSnippet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static IntPtr id_getUid;
		public virtual string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
			}
		}

		static Delegate cb_getMarker_I;
#pragma warning disable 0169
		static Delegate GetGetMarker_IHandler ()
		{
			if (cb_getMarker_I == null)
				cb_getMarker_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMarker_I);
			return cb_getMarker_I;
		}

		static IntPtr n_GetMarker_I (IntPtr jnienv, IntPtr native__this, int stateBitset)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMarker (stateBitset));
		}
#pragma warning restore 0169

		static IntPtr id_getMarker_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='getMarker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMarker", "(I)Landroid/graphics/drawable/Drawable;", "GetGetMarker_IHandler")]
		public virtual global::Android.Graphics.Drawables.Drawable GetMarker (int stateBitset)
		{
			if (id_getMarker_I == IntPtr.Zero)
				id_getMarker_I = JNIEnv.GetMethodID (class_ref, "getMarker", "(I)Landroid/graphics/drawable/Drawable;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getMarker_I, new JValue (stateBitset)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarker", "(I)Landroid/graphics/drawable/Drawable;"), new JValue (stateBitset)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setMarker_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setMarker_Landroid_graphics_drawable_Drawable_ == null)
				cb_setMarker_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarker_Landroid_graphics_drawable_Drawable_);
			return cb_setMarker_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetMarker_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			global::Osmdroid.Views.Overlay.OverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable marker = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.SetMarker (marker);
		}
#pragma warning restore 0169

		static IntPtr id_setMarker_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setMarker", "(Landroid/graphics/drawable/Drawable;)V", "GetSetMarker_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetMarker (global::Android.Graphics.Drawables.Drawable marker)
		{
			if (id_setMarker_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setMarker_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setMarker", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMarker_Landroid_graphics_drawable_Drawable_, new JValue (marker));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarker", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (marker));
		}

		static IntPtr id_setState_Landroid_graphics_drawable_Drawable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='OverlayItem']/method[@name='setState' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int']]"
		[Register ("setState", "(Landroid/graphics/drawable/Drawable;I)V", "")]
		public static void SetState (global::Android.Graphics.Drawables.Drawable drawable, int stateBitset)
		{
			if (id_setState_Landroid_graphics_drawable_Drawable_I == IntPtr.Zero)
				id_setState_Landroid_graphics_drawable_Drawable_I = JNIEnv.GetStaticMethodID (class_ref, "setState", "(Landroid/graphics/drawable/Drawable;I)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_setState_Landroid_graphics_drawable_Drawable_I, new JValue (drawable), new JValue (stateBitset));
		}

	}
}
