using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ExpirableBitmapDrawable']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/ExpirableBitmapDrawable", DoNotGenerateAcw=true)]
	public partial class ExpirableBitmapDrawable : global::Android.Graphics.Drawables.BitmapDrawable {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ExpirableBitmapDrawable']/field[@name='EXPIRED']"
		[Register ("EXPIRED")]
		public const int Expired = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/ExpirableBitmapDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExpirableBitmapDrawable); }
		}

		protected ExpirableBitmapDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ExpirableBitmapDrawable']/constructor[@name='ExpirableBitmapDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public ExpirableBitmapDrawable (global::Android.Graphics.Bitmap pBitmap) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ExpirableBitmapDrawable)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Bitmap;)V", new JValue (pBitmap)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Bitmap;)V", new JValue (pBitmap));
				return;
			}

			if (id_ctor_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Bitmap;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (pBitmap)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Bitmap_, new JValue (pBitmap));
		}

		static IntPtr id_isDrawableExpired_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ExpirableBitmapDrawable']/method[@name='isDrawableExpired' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("isDrawableExpired", "(Landroid/graphics/drawable/Drawable;)Z", "")]
		public static bool IsDrawableExpired (global::Android.Graphics.Drawables.Drawable pTile)
		{
			if (id_isDrawableExpired_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_isDrawableExpired_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetStaticMethodID (class_ref, "isDrawableExpired", "(Landroid/graphics/drawable/Drawable;)Z");
			bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDrawableExpired_Landroid_graphics_drawable_Drawable_, new JValue (pTile));
			return __ret;
		}

	}
}
