using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']"
	[global::Android.Runtime.Register ("org/osmdroid/ResourceProxy$bitmap", DoNotGenerateAcw=true)]
	public sealed partial class ResourceProxyBitmap : global::Java.Lang.Enum {


		static IntPtr center_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='center']"
		[Register ("center")]
		public static global::Osmdroid.ResourceProxyBitmap Center {
			get {
				if (center_jfieldId == IntPtr.Zero)
					center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "center", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, center_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (center_jfieldId == IntPtr.Zero)
					center_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "center", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, center_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr direction_arrow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='direction_arrow']"
		[Register ("direction_arrow")]
		public static global::Osmdroid.ResourceProxyBitmap DirectionArrow {
			get {
				if (direction_arrow_jfieldId == IntPtr.Zero)
					direction_arrow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "direction_arrow", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, direction_arrow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (direction_arrow_jfieldId == IntPtr.Zero)
					direction_arrow_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "direction_arrow", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, direction_arrow_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ic_menu_compass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='ic_menu_compass']"
		[Register ("ic_menu_compass")]
		public static global::Osmdroid.ResourceProxyBitmap IcMenuCompass {
			get {
				if (ic_menu_compass_jfieldId == IntPtr.Zero)
					ic_menu_compass_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_compass", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ic_menu_compass_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ic_menu_compass_jfieldId == IntPtr.Zero)
					ic_menu_compass_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_compass", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ic_menu_compass_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ic_menu_mapmode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='ic_menu_mapmode']"
		[Register ("ic_menu_mapmode")]
		public static global::Osmdroid.ResourceProxyBitmap IcMenuMapmode {
			get {
				if (ic_menu_mapmode_jfieldId == IntPtr.Zero)
					ic_menu_mapmode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_mapmode", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ic_menu_mapmode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ic_menu_mapmode_jfieldId == IntPtr.Zero)
					ic_menu_mapmode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_mapmode", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ic_menu_mapmode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ic_menu_mylocation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='ic_menu_mylocation']"
		[Register ("ic_menu_mylocation")]
		public static global::Osmdroid.ResourceProxyBitmap IcMenuMylocation {
			get {
				if (ic_menu_mylocation_jfieldId == IntPtr.Zero)
					ic_menu_mylocation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_mylocation", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ic_menu_mylocation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ic_menu_mylocation_jfieldId == IntPtr.Zero)
					ic_menu_mylocation_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_mylocation", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ic_menu_mylocation_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr ic_menu_offline_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='ic_menu_offline']"
		[Register ("ic_menu_offline")]
		public static global::Osmdroid.ResourceProxyBitmap IcMenuOffline {
			get {
				if (ic_menu_offline_jfieldId == IntPtr.Zero)
					ic_menu_offline_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_offline", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ic_menu_offline_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ic_menu_offline_jfieldId == IntPtr.Zero)
					ic_menu_offline_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ic_menu_offline", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, ic_menu_offline_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr marker_default_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='marker_default']"
		[Register ("marker_default")]
		public static global::Osmdroid.ResourceProxyBitmap MarkerDefault {
			get {
				if (marker_default_jfieldId == IntPtr.Zero)
					marker_default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "marker_default", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, marker_default_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (marker_default_jfieldId == IntPtr.Zero)
					marker_default_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "marker_default", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, marker_default_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr marker_default_focused_base_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='marker_default_focused_base']"
		[Register ("marker_default_focused_base")]
		public static global::Osmdroid.ResourceProxyBitmap MarkerDefaultFocusedBase {
			get {
				if (marker_default_focused_base_jfieldId == IntPtr.Zero)
					marker_default_focused_base_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "marker_default_focused_base", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, marker_default_focused_base_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (marker_default_focused_base_jfieldId == IntPtr.Zero)
					marker_default_focused_base_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "marker_default_focused_base", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, marker_default_focused_base_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr navto_small_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='navto_small']"
		[Register ("navto_small")]
		public static global::Osmdroid.ResourceProxyBitmap NavtoSmall {
			get {
				if (navto_small_jfieldId == IntPtr.Zero)
					navto_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "navto_small", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, navto_small_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (navto_small_jfieldId == IntPtr.Zero)
					navto_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "navto_small", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, navto_small_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr next_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='next']"
		[Register ("next")]
		public static global::Osmdroid.ResourceProxyBitmap Next {
			get {
				if (next_jfieldId == IntPtr.Zero)
					next_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "next", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, next_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (next_jfieldId == IntPtr.Zero)
					next_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "next", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, next_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr person_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='person']"
		[Register ("person")]
		public static global::Osmdroid.ResourceProxyBitmap Person {
			get {
				if (person_jfieldId == IntPtr.Zero)
					person_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "person", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, person_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (person_jfieldId == IntPtr.Zero)
					person_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "person", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, person_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr previous_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='previous']"
		[Register ("previous")]
		public static global::Osmdroid.ResourceProxyBitmap Previous {
			get {
				if (previous_jfieldId == IntPtr.Zero)
					previous_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "previous", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, previous_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (previous_jfieldId == IntPtr.Zero)
					previous_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "previous", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, previous_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/field[@name='unknown']"
		[Register ("unknown")]
		public static global::Osmdroid.ResourceProxyBitmap Unknown {
			get {
				if (unknown_jfieldId == IntPtr.Zero)
					unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "unknown", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (unknown_jfieldId == IntPtr.Zero)
					unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "unknown", "Lorg/osmdroid/ResourceProxy$bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, unknown_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/ResourceProxy$bitmap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceProxyBitmap); }
		}

		internal ResourceProxyBitmap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/ResourceProxy$bitmap;", "")]
		public static global::Osmdroid.ResourceProxyBitmap ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/ResourceProxy$bitmap;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Osmdroid.ResourceProxyBitmap __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.bitmap']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/osmdroid/ResourceProxy$bitmap;", "")]
		public static global::Osmdroid.ResourceProxyBitmap[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/ResourceProxy$bitmap;");
			return (global::Osmdroid.ResourceProxyBitmap[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.ResourceProxyBitmap));
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']"
	[global::Android.Runtime.Register ("org/osmdroid/ResourceProxy$string", DoNotGenerateAcw=true)]
	public sealed partial class ResourceProxyString : global::Java.Lang.Enum {


		static IntPtr base_nl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='base_nl']"
		[Register ("base_nl")]
		public static global::Osmdroid.ResourceProxyString BaseNl {
			get {
				if (base_nl_jfieldId == IntPtr.Zero)
					base_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "base_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, base_nl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (base_nl_jfieldId == IntPtr.Zero)
					base_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "base_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, base_nl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr bing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='bing']"
		[Register ("bing")]
		public static global::Osmdroid.ResourceProxyString Bing {
			get {
				if (bing_jfieldId == IntPtr.Zero)
					bing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bing", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, bing_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bing_jfieldId == IntPtr.Zero)
					bing_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "bing", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, bing_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr cloudmade_small_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='cloudmade_small']"
		[Register ("cloudmade_small")]
		public static global::Osmdroid.ResourceProxyString CloudmadeSmall {
			get {
				if (cloudmade_small_jfieldId == IntPtr.Zero)
					cloudmade_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cloudmade_small", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, cloudmade_small_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cloudmade_small_jfieldId == IntPtr.Zero)
					cloudmade_small_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cloudmade_small", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, cloudmade_small_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr cloudmade_standard_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='cloudmade_standard']"
		[Register ("cloudmade_standard")]
		public static global::Osmdroid.ResourceProxyString CloudmadeStandard {
			get {
				if (cloudmade_standard_jfieldId == IntPtr.Zero)
					cloudmade_standard_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cloudmade_standard", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, cloudmade_standard_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cloudmade_standard_jfieldId == IntPtr.Zero)
					cloudmade_standard_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cloudmade_standard", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, cloudmade_standard_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr compass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='compass']"
		[Register ("compass")]
		public static global::Osmdroid.ResourceProxyString Compass {
			get {
				if (compass_jfieldId == IntPtr.Zero)
					compass_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "compass", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, compass_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (compass_jfieldId == IntPtr.Zero)
					compass_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "compass", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, compass_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr cyclemap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='cyclemap']"
		[Register ("cyclemap")]
		public static global::Osmdroid.ResourceProxyString Cyclemap {
			get {
				if (cyclemap_jfieldId == IntPtr.Zero)
					cyclemap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cyclemap", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, cyclemap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cyclemap_jfieldId == IntPtr.Zero)
					cyclemap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cyclemap", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, cyclemap_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr fiets_nl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='fiets_nl']"
		[Register ("fiets_nl")]
		public static global::Osmdroid.ResourceProxyString FietsNl {
			get {
				if (fiets_nl_jfieldId == IntPtr.Zero)
					fiets_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fiets_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, fiets_nl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fiets_nl_jfieldId == IntPtr.Zero)
					fiets_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "fiets_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, fiets_nl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr format_distance_feet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='format_distance_feet']"
		[Register ("format_distance_feet")]
		public static global::Osmdroid.ResourceProxyString FormatDistanceFeet {
			get {
				if (format_distance_feet_jfieldId == IntPtr.Zero)
					format_distance_feet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_feet", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, format_distance_feet_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_distance_feet_jfieldId == IntPtr.Zero)
					format_distance_feet_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_feet", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, format_distance_feet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr format_distance_kilometers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='format_distance_kilometers']"
		[Register ("format_distance_kilometers")]
		public static global::Osmdroid.ResourceProxyString FormatDistanceKilometers {
			get {
				if (format_distance_kilometers_jfieldId == IntPtr.Zero)
					format_distance_kilometers_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_kilometers", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, format_distance_kilometers_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_distance_kilometers_jfieldId == IntPtr.Zero)
					format_distance_kilometers_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_kilometers", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, format_distance_kilometers_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr format_distance_meters_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='format_distance_meters']"
		[Register ("format_distance_meters")]
		public static global::Osmdroid.ResourceProxyString FormatDistanceMeters {
			get {
				if (format_distance_meters_jfieldId == IntPtr.Zero)
					format_distance_meters_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_meters", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, format_distance_meters_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_distance_meters_jfieldId == IntPtr.Zero)
					format_distance_meters_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_meters", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, format_distance_meters_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr format_distance_miles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='format_distance_miles']"
		[Register ("format_distance_miles")]
		public static global::Osmdroid.ResourceProxyString FormatDistanceMiles {
			get {
				if (format_distance_miles_jfieldId == IntPtr.Zero)
					format_distance_miles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_miles", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, format_distance_miles_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_distance_miles_jfieldId == IntPtr.Zero)
					format_distance_miles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_miles", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, format_distance_miles_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr format_distance_nautical_miles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='format_distance_nautical_miles']"
		[Register ("format_distance_nautical_miles")]
		public static global::Osmdroid.ResourceProxyString FormatDistanceNauticalMiles {
			get {
				if (format_distance_nautical_miles_jfieldId == IntPtr.Zero)
					format_distance_nautical_miles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_nautical_miles", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, format_distance_nautical_miles_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (format_distance_nautical_miles_jfieldId == IntPtr.Zero)
					format_distance_nautical_miles_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "format_distance_nautical_miles", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, format_distance_nautical_miles_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr map_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='map_mode']"
		[Register ("map_mode")]
		public static global::Osmdroid.ResourceProxyString MapMode {
			get {
				if (map_mode_jfieldId == IntPtr.Zero)
					map_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "map_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, map_mode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (map_mode_jfieldId == IntPtr.Zero)
					map_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "map_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, map_mode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mapbox_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='mapbox']"
		[Register ("mapbox")]
		public static global::Osmdroid.ResourceProxyString Mapbox {
			get {
				if (mapbox_jfieldId == IntPtr.Zero)
					mapbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapbox", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mapbox_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mapbox_jfieldId == IntPtr.Zero)
					mapbox_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapbox", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mapbox_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mapnik_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='mapnik']"
		[Register ("mapnik")]
		public static global::Osmdroid.ResourceProxyString Mapnik {
			get {
				if (mapnik_jfieldId == IntPtr.Zero)
					mapnik_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapnik", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mapnik_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mapnik_jfieldId == IntPtr.Zero)
					mapnik_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapnik", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mapnik_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mapquest_aerial_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='mapquest_aerial']"
		[Register ("mapquest_aerial")]
		public static global::Osmdroid.ResourceProxyString MapquestAerial {
			get {
				if (mapquest_aerial_jfieldId == IntPtr.Zero)
					mapquest_aerial_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapquest_aerial", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mapquest_aerial_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mapquest_aerial_jfieldId == IntPtr.Zero)
					mapquest_aerial_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapquest_aerial", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mapquest_aerial_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mapquest_osm_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='mapquest_osm']"
		[Register ("mapquest_osm")]
		public static global::Osmdroid.ResourceProxyString MapquestOsm {
			get {
				if (mapquest_osm_jfieldId == IntPtr.Zero)
					mapquest_osm_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapquest_osm", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mapquest_osm_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mapquest_osm_jfieldId == IntPtr.Zero)
					mapquest_osm_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mapquest_osm", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, mapquest_osm_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr my_location_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='my_location']"
		[Register ("my_location")]
		public static global::Osmdroid.ResourceProxyString MyLocation {
			get {
				if (my_location_jfieldId == IntPtr.Zero)
					my_location_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "my_location", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, my_location_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (my_location_jfieldId == IntPtr.Zero)
					my_location_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "my_location", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, my_location_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr offline_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='offline_mode']"
		[Register ("offline_mode")]
		public static global::Osmdroid.ResourceProxyString OfflineMode {
			get {
				if (offline_mode_jfieldId == IntPtr.Zero)
					offline_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "offline_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, offline_mode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (offline_mode_jfieldId == IntPtr.Zero)
					offline_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "offline_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, offline_mode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr online_mode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='online_mode']"
		[Register ("online_mode")]
		public static global::Osmdroid.ResourceProxyString OnlineMode {
			get {
				if (online_mode_jfieldId == IntPtr.Zero)
					online_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "online_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, online_mode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (online_mode_jfieldId == IntPtr.Zero)
					online_mode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "online_mode", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, online_mode_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr public_transport_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='public_transport']"
		[Register ("public_transport")]
		public static global::Osmdroid.ResourceProxyString PublicTransport {
			get {
				if (public_transport_jfieldId == IntPtr.Zero)
					public_transport_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "public_transport", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, public_transport_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (public_transport_jfieldId == IntPtr.Zero)
					public_transport_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "public_transport", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, public_transport_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr roads_nl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='roads_nl']"
		[Register ("roads_nl")]
		public static global::Osmdroid.ResourceProxyString RoadsNl {
			get {
				if (roads_nl_jfieldId == IntPtr.Zero)
					roads_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "roads_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, roads_nl_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (roads_nl_jfieldId == IntPtr.Zero)
					roads_nl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "roads_nl", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, roads_nl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/field[@name='unknown']"
		[Register ("unknown")]
		public static global::Osmdroid.ResourceProxyString Unknown {
			get {
				if (unknown_jfieldId == IntPtr.Zero)
					unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "unknown", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (unknown_jfieldId == IntPtr.Zero)
					unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "unknown", "Lorg/osmdroid/ResourceProxy$string;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, unknown_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/ResourceProxy$string", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceProxyString); }
		}

		internal ResourceProxyString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/ResourceProxy$string;", "")]
		public static global::Osmdroid.ResourceProxyString ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/ResourceProxy$string;");
			IntPtr native_name = JNIEnv.NewString (name);
			global::Osmdroid.ResourceProxyString __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_name);
			return __ret;
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='ResourceProxy.string']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/osmdroid/ResourceProxy$string;", "")]
		public static global::Osmdroid.ResourceProxyString[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/ResourceProxy$string;");
			return (global::Osmdroid.ResourceProxyString[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.ResourceProxyString));
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']"
	[Register ("org/osmdroid/ResourceProxy", "", "Osmdroid.IResourceProxyInvoker")]
	public partial interface IResourceProxy : IJavaObject {

		float DisplayMetricsDensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']/method[@name='getDisplayMetricsDensity' and count(parameter)=0]"
			[Register ("getDisplayMetricsDensity", "()F", "GetGetDisplayMetricsDensityHandler:Osmdroid.IResourceProxyInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.bitmap']]"
		[Register ("getBitmap", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/Bitmap;", "GetGetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_Handler:Osmdroid.IResourceProxyInvoker, OsmdroidAndroidBinding")]
		global::Android.Graphics.Bitmap GetBitmap (global::Osmdroid.ResourceProxyBitmap pResId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.bitmap']]"
		[Register ("getDrawable", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_Handler:Osmdroid.IResourceProxyInvoker, OsmdroidAndroidBinding")]
		global::Android.Graphics.Drawables.Drawable GetDrawable (global::Osmdroid.ResourceProxyBitmap pResId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.string']]"
		[Register ("getString", "(Lorg/osmdroid/ResourceProxy$string;)Ljava/lang/String;", "GetGetString_Lorg_osmdroid_ResourceProxy_string_Handler:Osmdroid.IResourceProxyInvoker, OsmdroidAndroidBinding")]
		string GetString (global::Osmdroid.ResourceProxyString pResId);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/interface[@name='ResourceProxy']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='org.osmdroid.ResourceProxy.string'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getString", "(Lorg/osmdroid/ResourceProxy$string;[Ljava/lang/Object;)Ljava/lang/String;", "GetGetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_Handler:Osmdroid.IResourceProxyInvoker, OsmdroidAndroidBinding")]
		string GetString (global::Osmdroid.ResourceProxyString pResId, params global:: Java.Lang.Object[] formatArgs);

	}

	[global::Android.Runtime.Register ("org/osmdroid/ResourceProxy", DoNotGenerateAcw=true)]
	internal class IResourceProxyInvoker : global::Java.Lang.Object, IResourceProxy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/ResourceProxy");
		IntPtr class_ref;

		public static IResourceProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResourceProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.ResourceProxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResourceProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IResourceProxyInvoker); }
		}

		static Delegate cb_getDisplayMetricsDensity;
#pragma warning disable 0169
		static Delegate GetGetDisplayMetricsDensityHandler ()
		{
			if (cb_getDisplayMetricsDensity == null)
				cb_getDisplayMetricsDensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDisplayMetricsDensity);
			return cb_getDisplayMetricsDensity;
		}

		static float n_GetDisplayMetricsDensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.IResourceProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayMetricsDensity;
		}
#pragma warning restore 0169

		IntPtr id_getDisplayMetricsDensity;
		public float DisplayMetricsDensity {
			get {
				if (id_getDisplayMetricsDensity == IntPtr.Zero)
					id_getDisplayMetricsDensity = JNIEnv.GetMethodID (class_ref, "getDisplayMetricsDensity", "()F");
				return JNIEnv.CallFloatMethod (Handle, id_getDisplayMetricsDensity);
			}
		}

		static Delegate cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
#pragma warning disable 0169
		static Delegate GetGetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_Handler ()
		{
			if (cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ == null)
				cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_);
			return cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
		}

		static IntPtr n_GetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.IResourceProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyBitmap pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmap (pResId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
		public global::Android.Graphics.Bitmap GetBitmap (global::Osmdroid.ResourceProxyBitmap pResId)
		{
			if (id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ == IntPtr.Zero)
				id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ = JNIEnv.GetMethodID (class_ref, "getBitmap", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/Bitmap;");
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (Handle, id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
#pragma warning disable 0169
		static Delegate GetGetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_Handler ()
		{
			if (cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ == null)
				cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_);
			return cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
		}

		static IntPtr n_GetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.IResourceProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyBitmap pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (pResId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
		public global::Android.Graphics.Drawables.Drawable GetDrawable (global::Osmdroid.ResourceProxyBitmap pResId)
		{
			if (id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ == IntPtr.Zero)
				id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/drawable/Drawable;");
			global::Android.Graphics.Drawables.Drawable __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (Handle, id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getString_Lorg_osmdroid_ResourceProxy_string_;
#pragma warning disable 0169
		static Delegate GetGetString_Lorg_osmdroid_ResourceProxy_string_Handler ()
		{
			if (cb_getString_Lorg_osmdroid_ResourceProxy_string_ == null)
				cb_getString_Lorg_osmdroid_ResourceProxy_string_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Lorg_osmdroid_ResourceProxy_string_);
			return cb_getString_Lorg_osmdroid_ResourceProxy_string_;
		}

		static IntPtr n_GetString_Lorg_osmdroid_ResourceProxy_string_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.IResourceProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyString pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (pResId));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Lorg_osmdroid_ResourceProxy_string_;
		public string GetString (global::Osmdroid.ResourceProxyString pResId)
		{
			if (id_getString_Lorg_osmdroid_ResourceProxy_string_ == IntPtr.Zero)
				id_getString_Lorg_osmdroid_ResourceProxy_string_ = JNIEnv.GetMethodID (class_ref, "getString", "(Lorg/osmdroid/ResourceProxy$string;)Ljava/lang/String;");
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getString_Lorg_osmdroid_ResourceProxy_string_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ == null)
				cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_);
			return cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId, IntPtr native_formatArgs)
		{
			global::Osmdroid.IResourceProxy __this = global::Java.Lang.Object.GetObject<global::Osmdroid.IResourceProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyString pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (native_pResId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] formatArgs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_formatArgs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewString (__this.GetString (pResId, formatArgs));
			if (formatArgs != null)
				JNIEnv.CopyArray (formatArgs, native_formatArgs);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
		public string GetString (global::Osmdroid.ResourceProxyString pResId, params global:: Java.Lang.Object[] formatArgs)
		{
			if (id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getString", "(Lorg/osmdroid/ResourceProxy$string;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_formatArgs = JNIEnv.NewArray (formatArgs);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_, new JValue (pResId), new JValue (native_formatArgs)), JniHandleOwnership.TransferLocalRef);
			if (formatArgs != null) {
				JNIEnv.CopyArray (native_formatArgs, formatArgs);
				JNIEnv.DeleteLocalRef (native_formatArgs);
			}
			return __ret;
		}

	}

}
