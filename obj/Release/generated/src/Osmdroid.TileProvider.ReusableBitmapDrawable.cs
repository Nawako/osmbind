using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/ReusableBitmapDrawable", DoNotGenerateAcw=true)]
	public partial class ReusableBitmapDrawable : global::Osmdroid.TileProvider.ExpirableBitmapDrawable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/ReusableBitmapDrawable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ReusableBitmapDrawable); }
		}

		protected ReusableBitmapDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']/constructor[@name='ReusableBitmapDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register (".ctor", "(Landroid/graphics/Bitmap;)V", "")]
		public ReusableBitmapDrawable (global::Android.Graphics.Bitmap pBitmap) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ReusableBitmapDrawable)) {
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

		static Delegate cb_isBitmapValid;
#pragma warning disable 0169
		static Delegate GetIsBitmapValidHandler ()
		{
			if (cb_isBitmapValid == null)
				cb_isBitmapValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBitmapValid);
			return cb_isBitmapValid;
		}

		static bool n_IsBitmapValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.ReusableBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.ReusableBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBitmapValid;
		}
#pragma warning restore 0169

		static IntPtr id_isBitmapValid;
		public virtual bool IsBitmapValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']/method[@name='isBitmapValid' and count(parameter)=0]"
			[Register ("isBitmapValid", "()Z", "GetIsBitmapValidHandler")]
			get {
				if (id_isBitmapValid == IntPtr.Zero)
					id_isBitmapValid = JNIEnv.GetMethodID (class_ref, "isBitmapValid", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isBitmapValid);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBitmapValid", "()Z"));
			}
		}

		static Delegate cb_beginUsingDrawable;
#pragma warning disable 0169
		static Delegate GetBeginUsingDrawableHandler ()
		{
			if (cb_beginUsingDrawable == null)
				cb_beginUsingDrawable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginUsingDrawable);
			return cb_beginUsingDrawable;
		}

		static void n_BeginUsingDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.ReusableBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.ReusableBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginUsingDrawable ();
		}
#pragma warning restore 0169

		static IntPtr id_beginUsingDrawable;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']/method[@name='beginUsingDrawable' and count(parameter)=0]"
		[Register ("beginUsingDrawable", "()V", "GetBeginUsingDrawableHandler")]
		public virtual void BeginUsingDrawable ()
		{
			if (id_beginUsingDrawable == IntPtr.Zero)
				id_beginUsingDrawable = JNIEnv.GetMethodID (class_ref, "beginUsingDrawable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_beginUsingDrawable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginUsingDrawable", "()V"));
		}

		static Delegate cb_finishUsingDrawable;
#pragma warning disable 0169
		static Delegate GetFinishUsingDrawableHandler ()
		{
			if (cb_finishUsingDrawable == null)
				cb_finishUsingDrawable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinishUsingDrawable);
			return cb_finishUsingDrawable;
		}

		static void n_FinishUsingDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.ReusableBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.ReusableBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinishUsingDrawable ();
		}
#pragma warning restore 0169

		static IntPtr id_finishUsingDrawable;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']/method[@name='finishUsingDrawable' and count(parameter)=0]"
		[Register ("finishUsingDrawable", "()V", "GetFinishUsingDrawableHandler")]
		public virtual void FinishUsingDrawable ()
		{
			if (id_finishUsingDrawable == IntPtr.Zero)
				id_finishUsingDrawable = JNIEnv.GetMethodID (class_ref, "finishUsingDrawable", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_finishUsingDrawable);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishUsingDrawable", "()V"));
		}

		static Delegate cb_tryRecycle;
#pragma warning disable 0169
		static Delegate GetTryRecycleHandler ()
		{
			if (cb_tryRecycle == null)
				cb_tryRecycle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TryRecycle);
			return cb_tryRecycle;
		}

		static IntPtr n_TryRecycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.ReusableBitmapDrawable __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.ReusableBitmapDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TryRecycle ());
		}
#pragma warning restore 0169

		static IntPtr id_tryRecycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='ReusableBitmapDrawable']/method[@name='tryRecycle' and count(parameter)=0]"
		[Register ("tryRecycle", "()Landroid/graphics/Bitmap;", "GetTryRecycleHandler")]
		public virtual global::Android.Graphics.Bitmap TryRecycle ()
		{
			if (id_tryRecycle == IntPtr.Zero)
				id_tryRecycle = JNIEnv.GetMethodID (class_ref, "tryRecycle", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_tryRecycle), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "tryRecycle", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
		}

	}
}
