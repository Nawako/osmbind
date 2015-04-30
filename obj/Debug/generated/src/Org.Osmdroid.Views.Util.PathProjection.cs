using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='PathProjection']"
	[global::Android.Runtime.Register ("org/osmdroid/views/util/PathProjection", DoNotGenerateAcw=true)]
	public partial class PathProjection : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/util/PathProjection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PathProjection); }
		}

		protected PathProjection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='PathProjection']/constructor[@name='PathProjection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PathProjection () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PathProjection)) {
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

		static IntPtr id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='PathProjection']/method[@name='toPixels' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.Projection'] and parameter[2][@type='java.util.List'] and parameter[3][@type='android.graphics.Path']]"
		[Register ("toPixels", "(Lorg/osmdroid/views/Projection;Ljava/util/List;Landroid/graphics/Path;)Landroid/graphics/Path;", "")]
		public static global::Android.Graphics.Path ToPixels (global::Osmdroid.Views.Projection p0, global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p1, global::Android.Graphics.Path p2)
		{
			if (id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_ == IntPtr.Zero)
				id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_ = JNIEnv.GetStaticMethodID (class_ref, "toPixels", "(Lorg/osmdroid/views/Projection;Ljava/util/List;Landroid/graphics/Path;)Landroid/graphics/Path;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p1);
			global::Android.Graphics.Path __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_, new JValue (p0), new JValue (native_p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='PathProjection']/method[@name='toPixels' and count(parameter)=4 and parameter[1][@type='org.osmdroid.views.Projection'] and parameter[2][@type='java.util.List'] and parameter[3][@type='android.graphics.Path'] and parameter[4][@type='boolean']]"
		[Register ("toPixels", "(Lorg/osmdroid/views/Projection;Ljava/util/List;Landroid/graphics/Path;Z)Landroid/graphics/Path;", "")]
		public static global::Android.Graphics.Path ToPixels (global::Osmdroid.Views.Projection p0, global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p1, global::Android.Graphics.Path p2, bool p3)
		{
			if (id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_Z == IntPtr.Zero)
				id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_Z = JNIEnv.GetStaticMethodID (class_ref, "toPixels", "(Lorg/osmdroid/views/Projection;Ljava/util/List;Landroid/graphics/Path;Z)Landroid/graphics/Path;");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p1);
			global::Android.Graphics.Path __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (JNIEnv.CallStaticObjectMethod  (class_ref, id_toPixels_Lorg_osmdroid_views_Projection_Ljava_util_List_Landroid_graphics_Path_Z, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}
}
