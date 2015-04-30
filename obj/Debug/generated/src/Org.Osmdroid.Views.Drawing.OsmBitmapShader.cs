using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Drawing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmBitmapShader']"
	[global::Android.Runtime.Register ("org/osmdroid/views/drawing/OsmBitmapShader", DoNotGenerateAcw=true)]
	public partial class OsmBitmapShader : global::Android.Graphics.BitmapShader {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/drawing/OsmBitmapShader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OsmBitmapShader); }
		}

		protected OsmBitmapShader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Shader_TileMode_Landroid_graphics_Shader_TileMode_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmBitmapShader']/constructor[@name='OsmBitmapShader' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='android.graphics.Shader.TileMode'] and parameter[3][@type='android.graphics.Shader.TileMode']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", "")]
		public OsmBitmapShader (global::Android.Graphics.Bitmap bitmap, global::Android.Graphics.Shader.TileMode tileX, global::Android.Graphics.Shader.TileMode tileY) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OsmBitmapShader)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", new JValue (bitmap), new JValue (tileX), new JValue (tileY)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V", new JValue (bitmap), new JValue (tileX), new JValue (tileY));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Shader_TileMode_Landroid_graphics_Shader_TileMode_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Shader_TileMode_Landroid_graphics_Shader_TileMode_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;Landroid/graphics/Shader$TileMode;Landroid/graphics/Shader$TileMode;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Shader_TileMode_Landroid_graphics_Shader_TileMode_, new JValue (bitmap), new JValue (tileX), new JValue (tileY)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_Landroid_graphics_Shader_TileMode_Landroid_graphics_Shader_TileMode_, new JValue (bitmap), new JValue (tileX), new JValue (tileY));
		}

		static Delegate cb_onDrawCycle_Lorg_osmdroid_views_Projection_;
#pragma warning disable 0169
		static Delegate GetOnDrawCycle_Lorg_osmdroid_views_Projection_Handler ()
		{
			if (cb_onDrawCycle_Lorg_osmdroid_views_Projection_ == null)
				cb_onDrawCycle_Lorg_osmdroid_views_Projection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawCycle_Lorg_osmdroid_views_Projection_);
			return cb_onDrawCycle_Lorg_osmdroid_views_Projection_;
		}

		static void n_OnDrawCycle_Lorg_osmdroid_views_Projection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_projection)
		{
			global::Org.Osmdroid.Views.Drawing.OsmBitmapShader __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Drawing.OsmBitmapShader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Projection projection = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (native_projection, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawCycle (projection);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawCycle_Lorg_osmdroid_views_Projection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmBitmapShader']/method[@name='onDrawCycle' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.Projection']]"
		[Register ("onDrawCycle", "(Lorg/osmdroid/views/Projection;)V", "GetOnDrawCycle_Lorg_osmdroid_views_Projection_Handler")]
		public virtual void OnDrawCycle (global::Osmdroid.Views.Projection projection)
		{
			if (id_onDrawCycle_Lorg_osmdroid_views_Projection_ == IntPtr.Zero)
				id_onDrawCycle_Lorg_osmdroid_views_Projection_ = JNIEnv.GetMethodID (class_ref, "onDrawCycle", "(Lorg/osmdroid/views/Projection;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDrawCycle_Lorg_osmdroid_views_Projection_, new JValue (projection));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawCycle", "(Lorg/osmdroid/views/Projection;)V"), new JValue (projection));
		}

	}
}
