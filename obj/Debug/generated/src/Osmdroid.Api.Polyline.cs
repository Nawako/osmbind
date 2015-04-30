using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']"
	[global::Android.Runtime.Register ("org/osmdroid/api/Polyline", DoNotGenerateAcw=true)]
	public partial class Polyline : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/api/Polyline", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polyline); }
		}

		protected Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']/constructor[@name='Polyline' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public Polyline () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Polyline)) {
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

		static Delegate cb_color_I;
#pragma warning disable 0169
		static Delegate GetColor_IHandler ()
		{
			if (cb_color_I == null)
				cb_color_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Color_I);
			return cb_color_I;
		}

		static IntPtr n_Color_I (IntPtr jnienv, IntPtr native__this, int aColor)
		{
			global::Osmdroid.Api.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Color (aColor));
		}
#pragma warning restore 0169

		static IntPtr id_color_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("color", "(I)Lorg/osmdroid/api/Polyline;", "GetColor_IHandler")]
		public virtual global::Osmdroid.Api.Polyline Color (int aColor)
		{
			if (id_color_I == IntPtr.Zero)
				id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lorg/osmdroid/api/Polyline;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_color_I, new JValue (aColor)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "color", "(I)Lorg/osmdroid/api/Polyline;"), new JValue (aColor)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_points_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetPoints_Ljava_util_List_Handler ()
		{
			if (cb_points_Ljava_util_List_ == null)
				cb_points_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Points_Ljava_util_List_);
			return cb_points_Ljava_util_List_;
		}

		static IntPtr n_Points_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Api.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Osmdroid.Api.IGeoPoint> p0 = global::Android.Runtime.JavaList<global::Osmdroid.Api.IGeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Points (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_points_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']/method[@name='points' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("points", "(Ljava/util/List;)Lorg/osmdroid/api/Polyline;", "GetPoints_Ljava_util_List_Handler")]
		public virtual global::Osmdroid.Api.Polyline Points (global::System.Collections.Generic.IList<global::Osmdroid.Api.IGeoPoint> p0)
		{
			if (id_points_Ljava_util_List_ == IntPtr.Zero)
				id_points_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "points", "(Ljava/util/List;)Lorg/osmdroid/api/Polyline;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Api.IGeoPoint>.ToLocalJniHandle (p0);

			global::Osmdroid.Api.Polyline __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_points_Ljava_util_List_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "points", "(Ljava/util/List;)Lorg/osmdroid/api/Polyline;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_points_arrayLorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetPoints_arrayLorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_points_arrayLorg_osmdroid_api_IGeoPoint_ == null)
				cb_points_arrayLorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Points_arrayLorg_osmdroid_api_IGeoPoint_);
			return cb_points_arrayLorg_osmdroid_api_IGeoPoint_;
		}

		static IntPtr n_Points_arrayLorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPoints)
		{
			global::Osmdroid.Api.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint[] aPoints = (global::Osmdroid.Api.IGeoPoint[]) JNIEnv.GetArray (native_aPoints, JniHandleOwnership.DoNotTransfer, typeof (global::Osmdroid.Api.IGeoPoint));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Points (aPoints));
			if (aPoints != null)
				JNIEnv.CopyArray (aPoints, native_aPoints);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_points_arrayLorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']/method[@name='points' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint...']]"
		[Register ("points", "([Lorg/osmdroid/api/IGeoPoint;)Lorg/osmdroid/api/Polyline;", "GetPoints_arrayLorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual global::Osmdroid.Api.Polyline Points (params global:: Osmdroid.Api.IGeoPoint[] aPoints)
		{
			if (id_points_arrayLorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_points_arrayLorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "points", "([Lorg/osmdroid/api/IGeoPoint;)Lorg/osmdroid/api/Polyline;");
			IntPtr native_aPoints = JNIEnv.NewArray (aPoints);

			global::Osmdroid.Api.Polyline __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_points_arrayLorg_osmdroid_api_IGeoPoint_, new JValue (native_aPoints)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "points", "([Lorg/osmdroid/api/IGeoPoint;)Lorg/osmdroid/api/Polyline;"), new JValue (native_aPoints)), JniHandleOwnership.TransferLocalRef);
			if (aPoints != null) {
				JNIEnv.CopyArray (native_aPoints, aPoints);
				JNIEnv.DeleteLocalRef (native_aPoints);
			}
			return __ret;
		}

		static Delegate cb_width_F;
#pragma warning disable 0169
		static Delegate GetWidth_FHandler ()
		{
			if (cb_width_F == null)
				cb_width_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Width_F);
			return cb_width_F;
		}

		static IntPtr n_Width_F (IntPtr jnienv, IntPtr native__this, float aWidth)
		{
			global::Osmdroid.Api.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Width (aWidth));
		}
#pragma warning restore 0169

		static IntPtr id_width_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/class[@name='Polyline']/method[@name='width' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("width", "(F)Lorg/osmdroid/api/Polyline;", "GetWidth_FHandler")]
		public virtual global::Osmdroid.Api.Polyline Width (float aWidth)
		{
			if (id_width_F == IntPtr.Zero)
				id_width_F = JNIEnv.GetMethodID (class_ref, "width", "(F)Lorg/osmdroid/api/Polyline;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallObjectMethod  (Handle, id_width_F, new JValue (aWidth)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.Polyline> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "width", "(F)Lorg/osmdroid/api/Polyline;"), new JValue (aWidth)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
