using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/BitmapPool", DoNotGenerateAcw=true)]
	public partial class BitmapPool : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/BitmapPool", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BitmapPool); }
		}

		protected BitmapPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/constructor[@name='BitmapPool' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BitmapPool () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BitmapPool)) {
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

		static IntPtr id_getInstance;
		public static global::Osmdroid.TileProvider.BitmapPool Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lorg/osmdroid/tileprovider/BitmapPool;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lorg/osmdroid/tileprovider/BitmapPool;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_;
#pragma warning disable 0169
		static Delegate GetApplyReusableOptions_Landroid_graphics_BitmapFactory_Options_Handler ()
		{
			if (cb_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_ == null)
				cb_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyReusableOptions_Landroid_graphics_BitmapFactory_Options_);
			return cb_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_;
		}

		static void n_ApplyReusableOptions_Landroid_graphics_BitmapFactory_Options_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aBitmapOptions)
		{
			global::Osmdroid.TileProvider.BitmapPool __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.BitmapFactory.Options aBitmapOptions = global::Java.Lang.Object.GetObject<global::Android.Graphics.BitmapFactory.Options> (native_aBitmapOptions, JniHandleOwnership.DoNotTransfer);
			__this.ApplyReusableOptions (aBitmapOptions);
		}
#pragma warning restore 0169

		static IntPtr id_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='applyReusableOptions' and count(parameter)=1 and parameter[1][@type='android.graphics.BitmapFactory.Options']]"
		[Register ("applyReusableOptions", "(Landroid/graphics/BitmapFactory$Options;)V", "GetApplyReusableOptions_Landroid_graphics_BitmapFactory_Options_Handler")]
		public virtual void ApplyReusableOptions (global::Android.Graphics.BitmapFactory.Options aBitmapOptions)
		{
			if (id_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_ == IntPtr.Zero)
				id_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_ = JNIEnv.GetMethodID (class_ref, "applyReusableOptions", "(Landroid/graphics/BitmapFactory$Options;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_applyReusableOptions_Landroid_graphics_BitmapFactory_Options_, new JValue (aBitmapOptions));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyReusableOptions", "(Landroid/graphics/BitmapFactory$Options;)V"), new JValue (aBitmapOptions));
		}

		static Delegate cb_clearBitmapPool;
#pragma warning disable 0169
		static Delegate GetClearBitmapPoolHandler ()
		{
			if (cb_clearBitmapPool == null)
				cb_clearBitmapPool = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearBitmapPool);
			return cb_clearBitmapPool;
		}

		static void n_ClearBitmapPool (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.BitmapPool __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearBitmapPool ();
		}
#pragma warning restore 0169

		static IntPtr id_clearBitmapPool;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='clearBitmapPool' and count(parameter)=0]"
		[Register ("clearBitmapPool", "()V", "GetClearBitmapPoolHandler")]
		public virtual void ClearBitmapPool ()
		{
			if (id_clearBitmapPool == IntPtr.Zero)
				id_clearBitmapPool = JNIEnv.GetMethodID (class_ref, "clearBitmapPool", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearBitmapPool);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearBitmapPool", "()V"));
		}

		static Delegate cb_obtainBitmapFromPool;
#pragma warning disable 0169
		static Delegate GetObtainBitmapFromPoolHandler ()
		{
			if (cb_obtainBitmapFromPool == null)
				cb_obtainBitmapFromPool = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ObtainBitmapFromPool);
			return cb_obtainBitmapFromPool;
		}

		static IntPtr n_ObtainBitmapFromPool (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.BitmapPool __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainBitmapFromPool ());
		}
#pragma warning restore 0169

		static IntPtr id_obtainBitmapFromPool;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='obtainBitmapFromPool' and count(parameter)=0]"
		[Register ("obtainBitmapFromPool", "()Landroid/graphics/Bitmap;", "GetObtainBitmapFromPoolHandler")]
		public virtual global::Android.Graphics.Bitmap ObtainBitmapFromPool ()
		{
			if (id_obtainBitmapFromPool == IntPtr.Zero)
				id_obtainBitmapFromPool = JNIEnv.GetMethodID (class_ref, "obtainBitmapFromPool", "()Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_obtainBitmapFromPool), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainBitmapFromPool", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_obtainSizedBitmapFromPool_II;
#pragma warning disable 0169
		static Delegate GetObtainSizedBitmapFromPool_IIHandler ()
		{
			if (cb_obtainSizedBitmapFromPool_II == null)
				cb_obtainSizedBitmapFromPool_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_ObtainSizedBitmapFromPool_II);
			return cb_obtainSizedBitmapFromPool_II;
		}

		static IntPtr n_ObtainSizedBitmapFromPool_II (IntPtr jnienv, IntPtr native__this, int aWidth, int aHeight)
		{
			global::Osmdroid.TileProvider.BitmapPool __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObtainSizedBitmapFromPool (aWidth, aHeight));
		}
#pragma warning restore 0169

		static IntPtr id_obtainSizedBitmapFromPool_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='obtainSizedBitmapFromPool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("obtainSizedBitmapFromPool", "(II)Landroid/graphics/Bitmap;", "GetObtainSizedBitmapFromPool_IIHandler")]
		public virtual global::Android.Graphics.Bitmap ObtainSizedBitmapFromPool (int aWidth, int aHeight)
		{
			if (id_obtainSizedBitmapFromPool_II == IntPtr.Zero)
				id_obtainSizedBitmapFromPool_II = JNIEnv.GetMethodID (class_ref, "obtainSizedBitmapFromPool", "(II)Landroid/graphics/Bitmap;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_obtainSizedBitmapFromPool_II, new JValue (aWidth), new JValue (aHeight)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "obtainSizedBitmapFromPool", "(II)Landroid/graphics/Bitmap;"), new JValue (aWidth), new JValue (aHeight)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_;
#pragma warning disable 0169
		static Delegate GetReturnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_Handler ()
		{
			if (cb_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_ == null)
				cb_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReturnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_);
			return cb_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_;
		}

		static void n_ReturnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Osmdroid.TileProvider.BitmapPool __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.BitmapPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.ReusableBitmapDrawable drawable = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.ReusableBitmapDrawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.ReturnDrawableToPool (drawable);
		}
#pragma warning restore 0169

		static IntPtr id_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='BitmapPool']/method[@name='returnDrawableToPool' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.ReusableBitmapDrawable']]"
		[Register ("returnDrawableToPool", "(Lorg/osmdroid/tileprovider/ReusableBitmapDrawable;)V", "GetReturnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_Handler")]
		public virtual void ReturnDrawableToPool (global::Osmdroid.TileProvider.ReusableBitmapDrawable drawable)
		{
			if (id_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_ == IntPtr.Zero)
				id_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_ = JNIEnv.GetMethodID (class_ref, "returnDrawableToPool", "(Lorg/osmdroid/tileprovider/ReusableBitmapDrawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_returnDrawableToPool_Lorg_osmdroid_tileprovider_ReusableBitmapDrawable_, new JValue (drawable));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "returnDrawableToPool", "(Lorg/osmdroid/tileprovider/ReusableBitmapDrawable;)V"), new JValue (drawable));
		}

	}
}
