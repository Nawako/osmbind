using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']"
	[global::Android.Runtime.Register ("org/osmdroid/DefaultResourceProxyImpl", DoNotGenerateAcw=true)]
	public partial class DefaultResourceProxyImpl : global::Java.Lang.Object, global::Osmdroid.IResourceProxy {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.MapViewConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_DEFAULT']"
			[Register ("ANIMATION_DURATION_DEFAULT")]
			public const int AnimationDurationDefault = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_LONG']"
			[Register ("ANIMATION_DURATION_LONG")]
			public const int AnimationDurationLong = (int) 2000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_SHORT']"
			[Register ("ANIMATION_DURATION_SHORT")]
			public const int AnimationDurationShort = (int) 500;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_DEFAULT']"
			[Register ("ANIMATION_SMOOTHNESS_DEFAULT")]
			public const int AnimationSmoothnessDefault = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_HIGH']"
			[Register ("ANIMATION_SMOOTHNESS_HIGH")]
			public const int AnimationSmoothnessHigh = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_LOW']"
			[Register ("ANIMATION_SMOOTHNESS_LOW")]
			public const int AnimationSmoothnessLow = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MAXIMUM_ZOOMLEVEL']"
			[Register ("MAXIMUM_ZOOMLEVEL")]
			public const int MaximumZoomlevel = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MINIMUM_ZOOMLEVEL']"
			[Register ("MINIMUM_ZOOMLEVEL")]
			public const int MinimumZoomlevel = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/DefaultResourceProxyImpl", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultResourceProxyImpl); }
		}

		protected DefaultResourceProxyImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/constructor[@name='DefaultResourceProxyImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public DefaultResourceProxyImpl (global::Android.Content.Context pContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DefaultResourceProxyImpl)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (pContext)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (pContext));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (pContext)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (pContext));
		}

		static Delegate cb_getDisplayMetricsDensity;
#pragma warning disable 0169
		static Delegate GetGetDisplayMetricsDensityHandler ()
		{
			if (cb_getDisplayMetricsDensity == null)
				cb_getDisplayMetricsDensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDisplayMetricsDensity);
			return cb_getDisplayMetricsDensity;
		}

		static float n_GetDisplayMetricsDensity (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.DefaultResourceProxyImpl __this = global::Java.Lang.Object.GetObject<global::Osmdroid.DefaultResourceProxyImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayMetricsDensity;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayMetricsDensity;
		public virtual float DisplayMetricsDensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/method[@name='getDisplayMetricsDensity' and count(parameter)=0]"
			[Register ("getDisplayMetricsDensity", "()F", "GetGetDisplayMetricsDensityHandler")]
			get {
				if (id_getDisplayMetricsDensity == IntPtr.Zero)
					id_getDisplayMetricsDensity = JNIEnv.GetMethodID (class_ref, "getDisplayMetricsDensity", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getDisplayMetricsDensity);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayMetricsDensity", "()F"));
			}
		}

		static Delegate cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
#pragma warning disable 0169
		static Delegate GetGetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_Handler ()
		{
			if (cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ == null)
				cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_);
			return cb_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
		}

		static IntPtr n_GetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.DefaultResourceProxyImpl __this = global::Java.Lang.Object.GetObject<global::Osmdroid.DefaultResourceProxyImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyBitmap pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmap (pResId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/method[@name='getBitmap' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.bitmap']]"
		[Register ("getBitmap", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/Bitmap;", "GetGetBitmap_Lorg_osmdroid_ResourceProxy_bitmap_Handler")]
		public virtual global::Android.Graphics.Bitmap GetBitmap (global::Osmdroid.ResourceProxyBitmap pResId)
		{
			if (id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ == IntPtr.Zero)
				id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_ = JNIEnv.GetMethodID (class_ref, "getBitmap", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/Bitmap;");

			global::Android.Graphics.Bitmap __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getBitmap_Lorg_osmdroid_ResourceProxy_bitmap_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/Bitmap;"), new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
#pragma warning disable 0169
		static Delegate GetGetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_Handler ()
		{
			if (cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ == null)
				cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_);
			return cb_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
		}

		static IntPtr n_GetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.DefaultResourceProxyImpl __this = global::Java.Lang.Object.GetObject<global::Osmdroid.DefaultResourceProxyImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyBitmap pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyBitmap> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDrawable (pResId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.bitmap']]"
		[Register ("getDrawable", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/drawable/Drawable;", "GetGetDrawable_Lorg_osmdroid_ResourceProxy_bitmap_Handler")]
		public virtual global::Android.Graphics.Drawables.Drawable GetDrawable (global::Osmdroid.ResourceProxyBitmap pResId)
		{
			if (id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ == IntPtr.Zero)
				id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_ = JNIEnv.GetMethodID (class_ref, "getDrawable", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/drawable/Drawable;");

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getDrawable_Lorg_osmdroid_ResourceProxy_bitmap_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawable", "(Lorg/osmdroid/ResourceProxy$bitmap;)Landroid/graphics/drawable/Drawable;"), new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getString_Lorg_osmdroid_ResourceProxy_string_;
#pragma warning disable 0169
		static Delegate GetGetString_Lorg_osmdroid_ResourceProxy_string_Handler ()
		{
			if (cb_getString_Lorg_osmdroid_ResourceProxy_string_ == null)
				cb_getString_Lorg_osmdroid_ResourceProxy_string_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Lorg_osmdroid_ResourceProxy_string_);
			return cb_getString_Lorg_osmdroid_ResourceProxy_string_;
		}

		static IntPtr n_GetString_Lorg_osmdroid_ResourceProxy_string_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId)
		{
			global::Osmdroid.DefaultResourceProxyImpl __this = global::Java.Lang.Object.GetObject<global::Osmdroid.DefaultResourceProxyImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyString pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (native_pResId, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (pResId));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Lorg_osmdroid_ResourceProxy_string_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy.string']]"
		[Register ("getString", "(Lorg/osmdroid/ResourceProxy$string;)Ljava/lang/String;", "GetGetString_Lorg_osmdroid_ResourceProxy_string_Handler")]
		public virtual string GetString (global::Osmdroid.ResourceProxyString pResId)
		{
			if (id_getString_Lorg_osmdroid_ResourceProxy_string_ == IntPtr.Zero)
				id_getString_Lorg_osmdroid_ResourceProxy_string_ = JNIEnv.GetMethodID (class_ref, "getString", "(Lorg/osmdroid/ResourceProxy$string;)Ljava/lang/String;");

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Lorg_osmdroid_ResourceProxy_string_, new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Lorg/osmdroid/ResourceProxy$string;)Ljava/lang/String;"), new JValue (pResId)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ == null)
				cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_);
			return cb_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pResId, IntPtr native_formatArgs)
		{
			global::Osmdroid.DefaultResourceProxyImpl __this = global::Java.Lang.Object.GetObject<global::Osmdroid.DefaultResourceProxyImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.ResourceProxyString pResId = global::Java.Lang.Object.GetObject<global::Osmdroid.ResourceProxyString> (native_pResId, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] formatArgs = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_formatArgs, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewString (__this.GetString (pResId, formatArgs));
			if (formatArgs != null)
				JNIEnv.CopyArray (formatArgs, native_formatArgs);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid']/class[@name='DefaultResourceProxyImpl']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='org.osmdroid.ResourceProxy.string'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getString", "(Lorg/osmdroid/ResourceProxy$string;[Ljava/lang/Object;)Ljava/lang/String;", "GetGetString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_Handler")]
		public virtual string GetString (global::Osmdroid.ResourceProxyString pResId, params global:: Java.Lang.Object[] formatArgs)
		{
			if (id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getString", "(Lorg/osmdroid/ResourceProxy$string;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_formatArgs = JNIEnv.NewArray (formatArgs);

			string __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getString_Lorg_osmdroid_ResourceProxy_string_arrayLjava_lang_Object_, new JValue (pResId), new JValue (native_formatArgs)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Lorg/osmdroid/ResourceProxy$string;[Ljava/lang/Object;)Ljava/lang/String;"), new JValue (pResId), new JValue (native_formatArgs)), JniHandleOwnership.TransferLocalRef);
			if (formatArgs != null) {
				JNIEnv.CopyArray (native_formatArgs, formatArgs);
				JNIEnv.DeleteLocalRef (native_formatArgs);
			}
			return __ret;
		}

	}
}
