using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Kml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/kml/Style", DoNotGenerateAcw=true)]
	public partial class Style : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/field[@name='CREATOR']"
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

		static IntPtr mIconStyle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/field[@name='mIconStyle']"
		[Register ("mIconStyle")]
		public global::Osmdroid.Bonuspack.Kml.IconStyle MIconStyle {
			get {
				if (mIconStyle_jfieldId == IntPtr.Zero)
					mIconStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mIconStyle", "Lorg/osmdroid/bonuspack/kml/IconStyle;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mIconStyle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.IconStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mIconStyle_jfieldId == IntPtr.Zero)
					mIconStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mIconStyle", "Lorg/osmdroid/bonuspack/kml/IconStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mIconStyle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLineStyle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/field[@name='mLineStyle']"
		[Register ("mLineStyle")]
		public global::Osmdroid.Bonuspack.Kml.LineStyle MLineStyle {
			get {
				if (mLineStyle_jfieldId == IntPtr.Zero)
					mLineStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mLineStyle", "Lorg/osmdroid/bonuspack/kml/LineStyle;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLineStyle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.LineStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLineStyle_jfieldId == IntPtr.Zero)
					mLineStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mLineStyle", "Lorg/osmdroid/bonuspack/kml/LineStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLineStyle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPolyStyle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/field[@name='mPolyStyle']"
		[Register ("mPolyStyle")]
		public global::Osmdroid.Bonuspack.Kml.ColorStyle MPolyStyle {
			get {
				if (mPolyStyle_jfieldId == IntPtr.Zero)
					mPolyStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mPolyStyle", "Lorg/osmdroid/bonuspack/kml/ColorStyle;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPolyStyle_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPolyStyle_jfieldId == IntPtr.Zero)
					mPolyStyle_jfieldId = JNIEnv.GetFieldID (class_ref, "mPolyStyle", "Lorg/osmdroid/bonuspack/kml/ColorStyle;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPolyStyle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/kml/Style", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Style); }
		}

		protected Style (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/constructor[@name='Style' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Style () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Style)) {
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

		static IntPtr id_ctor_Landroid_graphics_Bitmap_IFI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/constructor[@name='Style' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;IFI)V", "")]
		public Style (global::Android.Graphics.Bitmap p0, int p1, float p2, int p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Style)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;IFI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;IFI)V", new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_IFI == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_IFI = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;IFI)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_IFI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_IFI, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/constructor[@name='Style' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public Style (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Style)) {
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

		static Delegate cb_getOutlinePaint;
#pragma warning disable 0169
		static Delegate GetGetOutlinePaintHandler ()
		{
			if (cb_getOutlinePaint == null)
				cb_getOutlinePaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutlinePaint);
			return cb_getOutlinePaint;
		}

		static IntPtr n_GetOutlinePaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutlinePaint);
		}
#pragma warning restore 0169

		static IntPtr id_getOutlinePaint;
		public virtual global::Android.Graphics.Paint OutlinePaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='getOutlinePaint' and count(parameter)=0]"
			[Register ("getOutlinePaint", "()Landroid/graphics/Paint;", "GetGetOutlinePaintHandler")]
			get {
				if (id_getOutlinePaint == IntPtr.Zero)
					id_getOutlinePaint = JNIEnv.GetMethodID (class_ref, "getOutlinePaint", "()Landroid/graphics/Paint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getOutlinePaint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutlinePaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
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
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFinalIcon (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFinalIcon_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='getFinalIcon' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Zip.ZipFile p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Zip.ZipFile> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Ljava_lang_String_Ljava_lang_String_Ljava_util_zip_ZipFile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='setIcon' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.zip.ZipFile']]"
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

		static Delegate cb_writeAsKML_Ljava_io_Writer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteAsKML_Ljava_io_Writer_Ljava_lang_String_Handler ()
		{
			if (cb_writeAsKML_Ljava_io_Writer_Ljava_lang_String_ == null)
				cb_writeAsKML_Ljava_io_Writer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WriteAsKML_Ljava_io_Writer_Ljava_lang_String_);
			return cb_writeAsKML_Ljava_io_Writer_Ljava_lang_String_;
		}

		static void n_WriteAsKML_Ljava_io_Writer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.Writer p0 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WriteAsKML (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeAsKML_Ljava_io_Writer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='writeAsKML' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='java.lang.String']]"
		[Register ("writeAsKML", "(Ljava/io/Writer;Ljava/lang/String;)V", "GetWriteAsKML_Ljava_io_Writer_Ljava_lang_String_Handler")]
		public virtual void WriteAsKML (global::Java.IO.Writer p0, string p1)
		{
			if (id_writeAsKML_Ljava_io_Writer_Ljava_lang_String_ == IntPtr.Zero)
				id_writeAsKML_Ljava_io_Writer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeAsKML", "(Ljava/io/Writer;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeAsKML_Ljava_io_Writer_Ljava_lang_String_, new JValue (p0), new JValue (native_p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeAsKML", "(Ljava/io/Writer;Ljava/lang/String;)V"), new JValue (p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_;
#pragma warning disable 0169
		static Delegate GetWritePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_Handler ()
		{
			if (cb_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_ == null)
				cb_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WritePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_);
			return cb_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_;
		}

		static void n_WritePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.Writer p0 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Kml.ColorStyle p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WritePolyStyle (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='writePolyStyle' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='org.osmdroid.bonuspack.kml.ColorStyle']]"
		[Register ("writePolyStyle", "(Ljava/io/Writer;Lorg/osmdroid/bonuspack/kml/ColorStyle;)V", "GetWritePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_Handler")]
		protected virtual void WritePolyStyle (global::Java.IO.Writer p0, global::Osmdroid.Bonuspack.Kml.ColorStyle p1)
		{
			if (id_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_ == IntPtr.Zero)
				id_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_ = JNIEnv.GetMethodID (class_ref, "writePolyStyle", "(Ljava/io/Writer;Lorg/osmdroid/bonuspack/kml/ColorStyle;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writePolyStyle_Ljava_io_Writer_Lorg_osmdroid_bonuspack_kml_ColorStyle_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writePolyStyle", "(Ljava/io/Writer;Lorg/osmdroid/bonuspack/kml/ColorStyle;)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Osmdroid.Bonuspack.Kml.Style __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.Style> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='Style']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
