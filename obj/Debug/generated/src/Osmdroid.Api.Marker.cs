using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']"
	[global::Android.Runtime.Register ("org/osmdroid/api/Marker", DoNotGenerateAcw=true)]
	public partial class Marker : global::Java.Lang.Object {


		static IntPtr latitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				return JNIEnv.GetDoubleField (Handle, latitude_jfieldId);
			}
			set {
				if (latitude_jfieldId == IntPtr.Zero)
					latitude_jfieldId = JNIEnv.GetFieldID (class_ref, "latitude", "D");
				JNIEnv.SetField (Handle, latitude_jfieldId, value);
			}
		}

		static IntPtr longitude_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				return JNIEnv.GetDoubleField (Handle, longitude_jfieldId);
			}
			set {
				if (longitude_jfieldId == IntPtr.Zero)
					longitude_jfieldId = JNIEnv.GetFieldID (class_ref, "longitude", "D");
				JNIEnv.SetField (Handle, longitude_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']"
		[global::Android.Runtime.Register ("org/osmdroid/api/Marker$Anchor", DoNotGenerateAcw=true)]
		public sealed partial class Anchor : global::Java.Lang.Enum {


			static IntPtr BOTTOM_CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public static global::Osmdroid.Api.Marker.Anchor BottomCenter {
				get {
					if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
						BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOTTOM_CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker.Anchor> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (BOTTOM_CENTER_jfieldId == IntPtr.Zero)
						BOTTOM_CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOTTOM_CENTER", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, BOTTOM_CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr CENTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Osmdroid.Api.Marker.Anchor Center {
				get {
					if (CENTER_jfieldId == IntPtr.Zero)
						CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker.Anchor> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (CENTER_jfieldId == IntPtr.Zero)
						CENTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, CENTER_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Osmdroid.Api.Marker.Anchor None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker.Anchor> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lorg/osmdroid/api/Marker$Anchor;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, NONE_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/api/Marker$Anchor", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Anchor); }
			}

			internal Anchor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker$Anchor;", "")]
			public static global::Osmdroid.Api.Marker.Anchor ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker$Anchor;");
				IntPtr native_name = JNIEnv.NewString (name);
				global::Osmdroid.Api.Marker.Anchor __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker.Anchor> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_name);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker.Anchor']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/osmdroid/api/Marker$Anchor;", "")]
			public static global::Osmdroid.Api.Marker.Anchor[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/api/Marker$Anchor;");
				return (global::Osmdroid.Api.Marker.Anchor[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.Api.Marker.Anchor));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/api/Marker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marker); }
		}

		protected Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/constructor[@name='Marker' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public Marker (double aLatitude, double aLongitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Marker)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (aLatitude), new JValue (aLongitude)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (aLatitude), new JValue (aLongitude));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude));
		}

		static Delegate cb_anchor_Lorg_osmdroid_api_Marker_Anchor_;
#pragma warning disable 0169
		static Delegate GetInvokeAnchor_Lorg_osmdroid_api_Marker_Anchor_Handler ()
		{
			if (cb_anchor_Lorg_osmdroid_api_Marker_Anchor_ == null)
				cb_anchor_Lorg_osmdroid_api_Marker_Anchor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_InvokeAnchor_Lorg_osmdroid_api_Marker_Anchor_);
			return cb_anchor_Lorg_osmdroid_api_Marker_Anchor_;
		}

		static IntPtr n_InvokeAnchor_Lorg_osmdroid_api_Marker_Anchor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aAnchor)
		{
			global::Osmdroid.Api.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.Marker.Anchor aAnchor = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker.Anchor> (native_aAnchor, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InvokeAnchor (aAnchor));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_anchor_Lorg_osmdroid_api_Marker_Anchor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/method[@name='anchor' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.Marker.Anchor']]"
		[Register ("anchor", "(Lorg/osmdroid/api/Marker$Anchor;)Lorg/osmdroid/api/Marker;", "GetInvokeAnchor_Lorg_osmdroid_api_Marker_Anchor_Handler")]
		public virtual global::Osmdroid.Api.Marker InvokeAnchor (global::Osmdroid.Api.Marker.Anchor aAnchor)
		{
			if (id_anchor_Lorg_osmdroid_api_Marker_Anchor_ == IntPtr.Zero)
				id_anchor_Lorg_osmdroid_api_Marker_Anchor_ = JNIEnv.GetMethodID (class_ref, "anchor", "(Lorg/osmdroid/api/Marker$Anchor;)Lorg/osmdroid/api/Marker;");

			global::Osmdroid.Api.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallObjectMethod  (Handle, id_anchor_Lorg_osmdroid_api_Marker_Anchor_, new JValue (aAnchor)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "anchor", "(Lorg/osmdroid/api/Marker$Anchor;)Lorg/osmdroid/api/Marker;"), new JValue (aAnchor)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_bitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_bitmap_Landroid_graphics_Bitmap_ == null)
				cb_bitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Bitmap_Landroid_graphics_Bitmap_);
			return cb_bitmap_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_Bitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBitmap)
		{
			global::Osmdroid.Api.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap aBitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_aBitmap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Bitmap (aBitmap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_bitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/method[@name='bitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("bitmap", "(Landroid/graphics/Bitmap;)Lorg/osmdroid/api/Marker;", "GetBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual global::Osmdroid.Api.Marker Bitmap (global::Android.Graphics.Bitmap aBitmap)
		{
			if (id_bitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_bitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "bitmap", "(Landroid/graphics/Bitmap;)Lorg/osmdroid/api/Marker;");

			global::Osmdroid.Api.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallObjectMethod  (Handle, id_bitmap_Landroid_graphics_Bitmap_, new JValue (aBitmap)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bitmap", "(Landroid/graphics/Bitmap;)Lorg/osmdroid/api/Marker;"), new JValue (aBitmap)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_icon_I;
#pragma warning disable 0169
		static Delegate GetIcon_IHandler ()
		{
			if (cb_icon_I == null)
				cb_icon_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Icon_I);
			return cb_icon_I;
		}

		static IntPtr n_Icon_I (IntPtr jnienv, IntPtr native__this, int aIcon)
		{
			global::Osmdroid.Api.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon (aIcon));
		}
#pragma warning restore 0169

		static IntPtr id_icon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/method[@name='icon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("icon", "(I)Lorg/osmdroid/api/Marker;", "GetIcon_IHandler")]
		public virtual global::Osmdroid.Api.Marker Icon (int aIcon)
		{
			if (id_icon_I == IntPtr.Zero)
				id_icon_I = JNIEnv.GetMethodID (class_ref, "icon", "(I)Lorg/osmdroid/api/Marker;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallObjectMethod  (Handle, id_icon_I, new JValue (aIcon)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "icon", "(I)Lorg/osmdroid/api/Marker;"), new JValue (aIcon)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_snippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_snippet_Ljava_lang_String_ == null)
				cb_snippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Snippet_Ljava_lang_String_);
			return cb_snippet_Ljava_lang_String_;
		}

		static IntPtr n_Snippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aSnippet)
		{
			global::Osmdroid.Api.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aSnippet = JNIEnv.GetString (native_aSnippet, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Snippet (aSnippet));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_snippet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/method[@name='snippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("snippet", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;", "GetSnippet_Ljava_lang_String_Handler")]
		public virtual global::Osmdroid.Api.Marker Snippet (string aSnippet)
		{
			if (id_snippet_Ljava_lang_String_ == IntPtr.Zero)
				id_snippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "snippet", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;");
			IntPtr native_aSnippet = JNIEnv.NewString (aSnippet);

			global::Osmdroid.Api.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallObjectMethod  (Handle, id_snippet_Ljava_lang_String_, new JValue (native_aSnippet)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "snippet", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;"), new JValue (native_aSnippet)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aSnippet);
			return __ret;
		}

		static Delegate cb_title_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_title_Ljava_lang_String_ == null)
				cb_title_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Title_Ljava_lang_String_);
			return cb_title_Ljava_lang_String_;
		}

		static IntPtr n_Title_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aTitle)
		{
			global::Osmdroid.Api.Marker __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string aTitle = JNIEnv.GetString (native_aTitle, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Title (aTitle));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_title_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Marker']/method[@name='title' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("title", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;", "GetTitle_Ljava_lang_String_Handler")]
		public virtual global::Osmdroid.Api.Marker Title (string aTitle)
		{
			if (id_title_Ljava_lang_String_ == IntPtr.Zero)
				id_title_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "title", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;");
			IntPtr native_aTitle = JNIEnv.NewString (aTitle);

			global::Osmdroid.Api.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallObjectMethod  (Handle, id_title_Ljava_lang_String_, new JValue (native_aTitle)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "title", "(Ljava/lang/String;)Lorg/osmdroid/api/Marker;"), new JValue (native_aTitle)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_aTitle);
			return __ret;
		}

	}
}
