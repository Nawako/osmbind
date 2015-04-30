using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Kml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/kml/ColorStyle", DoNotGenerateAcw=true)]
	public partial class ColorStyle : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/field[@name='CREATOR']"
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

		static IntPtr mColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/field[@name='mColor']"
		[Register ("mColor")]
		public int MColor {
			get {
				if (mColor_jfieldId == IntPtr.Zero)
					mColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mColor", "I");
				return JNIEnv.GetIntField (Handle, mColor_jfieldId);
			}
			set {
				if (mColor_jfieldId == IntPtr.Zero)
					mColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mColor", "I");
				JNIEnv.SetField (Handle, mColor_jfieldId, value);
			}
		}

		static IntPtr mColorMode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/field[@name='mColorMode']"
		[Register ("mColorMode")]
		public int MColorMode {
			get {
				if (mColorMode_jfieldId == IntPtr.Zero)
					mColorMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mColorMode", "I");
				return JNIEnv.GetIntField (Handle, mColorMode_jfieldId);
			}
			set {
				if (mColorMode_jfieldId == IntPtr.Zero)
					mColorMode_jfieldId = JNIEnv.GetFieldID (class_ref, "mColorMode", "I");
				JNIEnv.SetField (Handle, mColorMode_jfieldId, value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/kml/ColorStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorStyle); }
		}

		protected ColorStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/constructor[@name='ColorStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public ColorStyle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ColorStyle)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/constructor[@name='ColorStyle' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public ColorStyle (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ColorStyle)) {
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

		static Delegate cb_getFinalColor;
#pragma warning disable 0169
		static Delegate GetGetFinalColorHandler ()
		{
			if (cb_getFinalColor == null)
				cb_getFinalColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFinalColor);
			return cb_getFinalColor;
		}

		static int n_GetFinalColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Kml.ColorStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FinalColor;
		}
#pragma warning restore 0169

		static IntPtr id_getFinalColor;
		public virtual int FinalColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='getFinalColor' and count(parameter)=0]"
			[Register ("getFinalColor", "()I", "GetGetFinalColorHandler")]
			get {
				if (id_getFinalColor == IntPtr.Zero)
					id_getFinalColor = JNIEnv.GetMethodID (class_ref, "getFinalColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFinalColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFinalColor", "()I"));
			}
		}

		static Delegate cb_colorAsAndroidString;
#pragma warning disable 0169
		static Delegate GetColorAsAndroidStringHandler ()
		{
			if (cb_colorAsAndroidString == null)
				cb_colorAsAndroidString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ColorAsAndroidString);
			return cb_colorAsAndroidString;
		}

		static IntPtr n_ColorAsAndroidString (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Kml.ColorStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ColorAsAndroidString ());
		}
#pragma warning restore 0169

		static IntPtr id_colorAsAndroidString;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='colorAsAndroidString' and count(parameter)=0]"
		[Register ("colorAsAndroidString", "()Ljava/lang/String;", "GetColorAsAndroidStringHandler")]
		public virtual string ColorAsAndroidString ()
		{
			if (id_colorAsAndroidString == IntPtr.Zero)
				id_colorAsAndroidString = JNIEnv.GetMethodID (class_ref, "colorAsAndroidString", "()Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_colorAsAndroidString), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "colorAsAndroidString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_colorAsAndroidString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='colorAsAndroidString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorAsAndroidString", "(I)Ljava/lang/String;", "")]
		public static string ColorAsAndroidString (int p0)
		{
			if (id_colorAsAndroidString_I == IntPtr.Zero)
				id_colorAsAndroidString_I = JNIEnv.GetStaticMethodID (class_ref, "colorAsAndroidString", "(I)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_colorAsAndroidString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_colorAsKMLString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='colorAsKMLString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("colorAsKMLString", "(I)Ljava/lang/String;", "")]
		public static string ColorAsKMLString (int p0)
		{
			if (id_colorAsKMLString_I == IntPtr.Zero)
				id_colorAsKMLString_I = JNIEnv.GetStaticMethodID (class_ref, "colorAsKMLString", "(I)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_colorAsKMLString_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
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
			global::Osmdroid.Bonuspack.Kml.ColorStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_parseKMLColor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='parseKMLColor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseKMLColor", "(Ljava/lang/String;)I", "")]
		public static int ParseKMLColor (string p0)
		{
			if (id_parseKMLColor_Ljava_lang_String_ == IntPtr.Zero)
				id_parseKMLColor_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseKMLColor", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseKMLColor_Ljava_lang_String_, new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_writeAsKML_Ljava_io_Writer_;
#pragma warning disable 0169
		static Delegate GetWriteAsKML_Ljava_io_Writer_Handler ()
		{
			if (cb_writeAsKML_Ljava_io_Writer_ == null)
				cb_writeAsKML_Ljava_io_Writer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteAsKML_Ljava_io_Writer_);
			return cb_writeAsKML_Ljava_io_Writer_;
		}

		static void n_WriteAsKML_Ljava_io_Writer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Kml.ColorStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.Writer p0 = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteAsKML (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeAsKML_Ljava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='writeAsKML' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("writeAsKML", "(Ljava/io/Writer;)V", "GetWriteAsKML_Ljava_io_Writer_Handler")]
		public virtual void WriteAsKML (global::Java.IO.Writer p0)
		{
			if (id_writeAsKML_Ljava_io_Writer_ == IntPtr.Zero)
				id_writeAsKML_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "writeAsKML", "(Ljava/io/Writer;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeAsKML_Ljava_io_Writer_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeAsKML", "(Ljava/io/Writer;)V"), new JValue (p0));
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
			global::Osmdroid.Bonuspack.Kml.ColorStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.ColorStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='ColorStyle']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
