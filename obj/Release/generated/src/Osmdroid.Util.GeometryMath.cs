using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']"
	[global::Android.Runtime.Register ("org/osmdroid/util/GeometryMath", DoNotGenerateAcw=true)]
	public partial class GeometryMath : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/field[@name='DEG2RAD']"
		[Register ("DEG2RAD")]
		public const double Deg2rad = (double) 0.017453292519943;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/field[@name='RAD2DEG']"
		[Register ("RAD2DEG")]
		public const double Rad2deg = (double) 57.295779513082320;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/GeometryMath", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GeometryMath); }
		}

		protected GeometryMath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/constructor[@name='GeometryMath' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GeometryMath () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GeometryMath)) {
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

		static IntPtr id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_Landroid_graphics_Point_FLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/method[@name='getBoundingBoxForRotatatedRectangle' and count(parameter)=4 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='android.graphics.Point'] and parameter[3][@type='float'] and parameter[4][@type='android.graphics.Rect']]"
		[Register ("getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;Landroid/graphics/Point;FLandroid/graphics/Rect;)Landroid/graphics/Rect;", "")]
		public static global::Android.Graphics.Rect GetBoundingBoxForRotatatedRectangle (global::Android.Graphics.Rect rect, global::Android.Graphics.Point centerPoint, float angle, global::Android.Graphics.Rect reuse)
		{
			if (id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_Landroid_graphics_Point_FLandroid_graphics_Rect_ == IntPtr.Zero)
				id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_Landroid_graphics_Point_FLandroid_graphics_Rect_ = JNIEnv.GetStaticMethodID (class_ref, "getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;Landroid/graphics/Point;FLandroid/graphics/Rect;)Landroid/graphics/Rect;");
			global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_Landroid_graphics_Point_FLandroid_graphics_Rect_, new JValue (rect), new JValue (centerPoint), new JValue (angle), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_FLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/method[@name='getBoundingBoxForRotatatedRectangle' and count(parameter)=3 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Rect']]"
		[Register ("getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;FLandroid/graphics/Rect;)Landroid/graphics/Rect;", "")]
		public static global::Android.Graphics.Rect GetBoundingBoxForRotatatedRectangle (global::Android.Graphics.Rect rect, float angle, global::Android.Graphics.Rect reuse)
		{
			if (id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_FLandroid_graphics_Rect_ == IntPtr.Zero)
				id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_FLandroid_graphics_Rect_ = JNIEnv.GetStaticMethodID (class_ref, "getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;FLandroid/graphics/Rect;)Landroid/graphics/Rect;");
			global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_FLandroid_graphics_Rect_, new JValue (rect), new JValue (angle), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_IIFLandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GeometryMath']/method[@name='getBoundingBoxForRotatatedRectangle' and count(parameter)=5 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.Rect']]"
		[Register ("getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;IIFLandroid/graphics/Rect;)Landroid/graphics/Rect;", "")]
		public static global::Android.Graphics.Rect GetBoundingBoxForRotatatedRectangle (global::Android.Graphics.Rect rect, int centerX, int centerY, float angle, global::Android.Graphics.Rect reuse)
		{
			if (id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_IIFLandroid_graphics_Rect_ == IntPtr.Zero)
				id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_IIFLandroid_graphics_Rect_ = JNIEnv.GetStaticMethodID (class_ref, "getBoundingBoxForRotatatedRectangle", "(Landroid/graphics/Rect;IIFLandroid/graphics/Rect;)Landroid/graphics/Rect;");
			global::Android.Graphics.Rect __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoundingBoxForRotatatedRectangle_Landroid_graphics_Rect_IIFLandroid_graphics_Rect_, new JValue (rect), new JValue (centerX), new JValue (centerY), new JValue (angle), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
