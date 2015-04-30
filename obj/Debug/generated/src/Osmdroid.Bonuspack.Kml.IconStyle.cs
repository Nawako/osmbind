using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Kml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/kml/IconStyle", DoNotGenerateAcw=true)]
	public partial class IconStyle : global::Osmdroid.Bonuspack.Kml.ColorStyle, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='CREATOR']"
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

		static IntPtr mHeading_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mHeading']"
		[Register ("mHeading")]
		public float MHeading {
			get {
				if (mHeading_jfieldId == IntPtr.Zero)
					mHeading_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeading", "F");
				return JNIEnv.GetFloatField (Handle, mHeading_jfieldId);
			}
			set {
				if (mHeading_jfieldId == IntPtr.Zero)
					mHeading_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeading", "F");
				JNIEnv.SetField (Handle, mHeading_jfieldId, value);
			}
		}

		static IntPtr mHotSpotX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mHotSpotX']"
		[Register ("mHotSpotX")]
		public float MHotSpotX {
			get {
				if (mHotSpotX_jfieldId == IntPtr.Zero)
					mHotSpotX_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotSpotX", "F");
				return JNIEnv.GetFloatField (Handle, mHotSpotX_jfieldId);
			}
			set {
				if (mHotSpotX_jfieldId == IntPtr.Zero)
					mHotSpotX_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotSpotX", "F");
				JNIEnv.SetField (Handle, mHotSpotX_jfieldId, value);
			}
		}

		static IntPtr mHotSpotY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mHotSpotY']"
		[Register ("mHotSpotY")]
		public float MHotSpotY {
			get {
				if (mHotSpotY_jfieldId == IntPtr.Zero)
					mHotSpotY_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotSpotY", "F");
				return JNIEnv.GetFloatField (Handle, mHotSpotY_jfieldId);
			}
			set {
				if (mHotSpotY_jfieldId == IntPtr.Zero)
					mHotSpotY_jfieldId = JNIEnv.GetFieldID (class_ref, "mHotSpotY", "F");
				JNIEnv.SetField (Handle, mHotSpotY_jfieldId, value);
			}
		}

		static IntPtr mHref_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mHref']"
		[Register ("mHref")]
		public string MHref {
			get {
				if (mHref_jfieldId == IntPtr.Zero)
					mHref_jfieldId = JNIEnv.GetFieldID (class_ref, "mHref", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHref_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHref_jfieldId == IntPtr.Zero)
					mHref_jfieldId = JNIEnv.GetFieldID (class_ref, "mHref", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mHref_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mIcon']"
		[Register ("mIcon")]
		public global::Android.Graphics.Bitmap MIcon {
			get {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mIcon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIcon_jfieldId == IntPtr.Zero)
					mIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mIcon", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mIcon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mScale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/field[@name='mScale']"
		[Register ("mScale")]
		public float MScale {
			get {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				return JNIEnv.GetFloatField (Handle, mScale_jfieldId);
			}
			set {
				if (mScale_jfieldId == IntPtr.Zero)
					mScale_jfieldId = JNIEnv.GetFieldID (class_ref, "mScale", "F");
				JNIEnv.SetField (Handle, mScale_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/kml/IconStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IconStyle); }
		}

		protected IconStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/constructor[@name='IconStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public IconStyle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IconStyle)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/constructor[@name='IconStyle' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public IconStyle (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (IconStyle)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Parcel;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Parcel;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
				id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Parcel_, new JValue (p0));
		}

		static Delegate cb_getFinalIcon_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetFinalIcon_Landroid_content_Context_Handler ()
		{
			if (cb_getFinalIcon_Landroid_content_Context_ == null)
				cb_getFinalIcon_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFinalIcon_Landroid_content_Context_);
			return cb_getFinalIcon_Landroid_content_Context_;
		}

		static IntPtr n_GetFinalIcon_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Kml.IconStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.IconStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFinalIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFinalIcon_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/method[@name='getFinalIcon' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getFinalIcon", "(Landroid/content/Context;)Landroid/graphics/drawable/BitmapDrawable;", "GetGetFinalIcon_Landroid_content_Context_Handler")]
		public virtual global::Android.Graphics.Drawables.BitmapDrawable GetFinalIcon (global::Android.Content.Context p0)
		{
			if (id_getFinalIcon_Landroid_content_Context_ == IntPtr.Zero)
				id_getFinalIcon_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getFinalIcon", "(Landroid/content/Context;)Landroid/graphics/drawable/BitmapDrawable;");

			global::Android.Graphics.Drawables.BitmapDrawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (JNIEnv.CallObjectMethod  (Handle, id_getFinalIcon_Landroid_content_Context_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.BitmapDrawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalIcon", "(Landroid/content/Context;)Landroid/graphics/drawable/BitmapDrawable;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_Handler ()
		{
			if (cb_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_ == null)
				cb_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_);
			return cb_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_;
		}

		static void n_SetIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Osmdroid.Bonuspack.Kml.IconStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.IconStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Zip.ZipFile p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipFile> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/method[@name='setIcon' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.zip.ZipFile']]"
		[Register ("setIcon", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/zip/ZipFile;)V", "GetSetIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_Handler")]
		public virtual void SetIcon (string p0, string p1, global::Java.Util.Zip.ZipFile p2)
		{
			if (id_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_ == IntPtr.Zero)
				id_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/zip/ZipFile;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/zip/ZipFile;)V"), new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetStyleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_Handler ()
		{
			if (cb_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_ == null)
				cb_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StyleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_);
			return cb_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_;
		}

		static void n_StyleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Kml.IconStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.IconStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StyleMarker (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='IconStyle']/method[@name='styleMarker' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker'] and parameter[2][@type='android.content.Context']]"
		[Register ("styleMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;Landroid/content/Context;)V", "GetStyleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_Handler")]
		public virtual void StyleMarker (global::Osmdroid.Bonuspack.Overlays.Marker p0, global::Android.Content.Context p1)
		{
			if (id_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_ == IntPtr.Zero)
				id_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "styleMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;Landroid/content/Context;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_styleMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Landroid_content_Context_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "styleMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;Landroid/content/Context;)V"), new JValue (p0), new JValue (p1));
		}

	}
}
