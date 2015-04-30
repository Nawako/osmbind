using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Kml {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/kml/LineStyle", DoNotGenerateAcw=true)]
	public partial class LineStyle : global::Osmdroid.Bonuspack.Kml.ColorStyle, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/field[@name='CREATOR']"
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

		static IntPtr mWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/field[@name='mWidth']"
		[Register ("mWidth")]
		public float MWidth {
			get {
				if (mWidth_jfieldId == IntPtr.Zero)
					mWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mWidth", "F");
				return JNIEnv.GetFloatField (Handle, mWidth_jfieldId);
			}
			set {
				if (mWidth_jfieldId == IntPtr.Zero)
					mWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mWidth", "F");
				JNIEnv.SetField (Handle, mWidth_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/kml/LineStyle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LineStyle); }
		}

		protected LineStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/constructor[@name='LineStyle' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public LineStyle (global::Android.OS.Parcel p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LineStyle)) {
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

		static IntPtr id_ctor_IF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/constructor[@name='LineStyle' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register (".ctor", "(IF)V", "")]
		public LineStyle (int p0, float p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LineStyle)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IF)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IF)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_IF == IntPtr.Zero)
				id_ctor_IF = JNIEnv.GetMethodID (class_ref, "<init>", "(IF)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IF, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IF, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/constructor[@name='LineStyle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public LineStyle () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (LineStyle)) {
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
			global::Osmdroid.Bonuspack.Kml.LineStyle __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Kml.LineStyle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutlinePaint);
		}
#pragma warning restore 0169

		static IntPtr id_getOutlinePaint;
		public virtual global::Android.Graphics.Paint OutlinePaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.kml']/class[@name='LineStyle']/method[@name='getOutlinePaint' and count(parameter)=0]"
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

	}
}
