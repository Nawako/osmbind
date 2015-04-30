using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/ExtendedOverlayItem", DoNotGenerateAcw=true)]
	public partial class ExtendedOverlayItem : global::Osmdroid.Views.Overlay.OverlayItem {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/ExtendedOverlayItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExtendedOverlayItem); }
		}

		protected ExtendedOverlayItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/constructor[@name='ExtendedOverlayItem' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.osmdroid.util.GeoPoint']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", "")]
		public ExtendedOverlayItem (string p0, string p1, global::Org.Osmdroid.Util.GeoPoint p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = JNIEnv.NewString (p1);;
			if (GetType () != typeof (ExtendedOverlayItem)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V", new JValue (native_p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/osmdroid/util/GeoPoint;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_osmdroid_util_GeoPoint_, new JValue (native_p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getAlpha;
#pragma warning disable 0169
		static Delegate GetGetAlphaHandler ()
		{
			if (cb_getAlpha == null)
				cb_getAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAlpha);
			return cb_getAlpha;
		}

		static float n_GetAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alpha;
		}
#pragma warning restore 0169

		static Delegate cb_setAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetAlpha_FHandler ()
		{
			if (cb_setAlpha_F == null)
				cb_setAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlpha_F);
			return cb_setAlpha_F;
		}

		static void n_SetAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Alpha = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAlpha;
		static IntPtr id_setAlpha_F;
		public virtual float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				if (id_getAlpha == IntPtr.Zero)
					id_getAlpha = JNIEnv.GetMethodID (class_ref, "getAlpha", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getAlpha);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlpha", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				if (id_setAlpha_F == IntPtr.Zero)
					id_setAlpha_F = JNIEnv.GetMethodID (class_ref, "setAlpha", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAlpha_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		static IntPtr id_getDescription;
		public virtual string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Icon = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		static IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;
		public virtual global::Android.Graphics.Drawables.Drawable Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getIcon), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_drawable_Drawable_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (value));
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Image);
		}
#pragma warning restore 0169

		static Delegate cb_setImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_drawable_Drawable_);
			return cb_setImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Landroid_graphics_drawable_Drawable_;
		public virtual global::Android.Graphics.Drawables.Drawable Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/drawable/Drawable;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetImage_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				if (id_setImage_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
					id_setImage_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/drawable/Drawable;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setImage_Landroid_graphics_drawable_Drawable_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (value));
			}
		}

		static Delegate cb_getRelatedObject;
#pragma warning disable 0169
		static Delegate GetGetRelatedObjectHandler ()
		{
			if (cb_getRelatedObject == null)
				cb_getRelatedObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRelatedObject);
			return cb_getRelatedObject;
		}

		static IntPtr n_GetRelatedObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RelatedObject);
		}
#pragma warning restore 0169

		static Delegate cb_setRelatedObject_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetRelatedObject_Ljava_lang_Object_Handler ()
		{
			if (cb_setRelatedObject_Ljava_lang_Object_ == null)
				cb_setRelatedObject_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRelatedObject_Ljava_lang_Object_);
			return cb_setRelatedObject_Ljava_lang_Object_;
		}

		static void n_SetRelatedObject_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RelatedObject = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRelatedObject;
		static IntPtr id_setRelatedObject_Ljava_lang_Object_;
		public virtual global::Java.Lang.Object RelatedObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getRelatedObject' and count(parameter)=0]"
			[Register ("getRelatedObject", "()Ljava/lang/Object;", "GetGetRelatedObjectHandler")]
			get {
				if (id_getRelatedObject == IntPtr.Zero)
					id_getRelatedObject = JNIEnv.GetMethodID (class_ref, "getRelatedObject", "()Ljava/lang/Object;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getRelatedObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRelatedObject", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setRelatedObject' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setRelatedObject", "(Ljava/lang/Object;)V", "GetSetRelatedObject_Ljava_lang_Object_Handler")]
			set {
				if (id_setRelatedObject_Ljava_lang_Object_ == IntPtr.Zero)
					id_setRelatedObject_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setRelatedObject", "(Ljava/lang/Object;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRelatedObject_Ljava_lang_Object_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRelatedObject", "(Ljava/lang/Object;)V"), new JValue (value));
			}
		}

		static Delegate cb_getSubDescription;
#pragma warning disable 0169
		static Delegate GetGetSubDescriptionHandler ()
		{
			if (cb_getSubDescription == null)
				cb_getSubDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubDescription);
			return cb_getSubDescription;
		}

		static IntPtr n_GetSubDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SubDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setSubDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setSubDescription_Ljava_lang_String_ == null)
				cb_setSubDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubDescription_Ljava_lang_String_);
			return cb_setSubDescription_Ljava_lang_String_;
		}

		static void n_SetSubDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SubDescription = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSubDescription;
		static IntPtr id_setSubDescription_Ljava_lang_String_;
		public virtual string SubDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getSubDescription' and count(parameter)=0]"
			[Register ("getSubDescription", "()Ljava/lang/String;", "GetGetSubDescriptionHandler")]
			get {
				if (id_getSubDescription == IntPtr.Zero)
					id_getSubDescription = JNIEnv.GetMethodID (class_ref, "getSubDescription", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSubDescription), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSubDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setSubDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSubDescription", "(Ljava/lang/String;)V", "GetSetSubDescription_Ljava_lang_String_Handler")]
			set {
				if (id_setSubDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setSubDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSubDescription_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSubDescription", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II;
#pragma warning disable 0169
		static Delegate GetGetHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_IIHandler ()
		{
			if (cb_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II == null)
				cb_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_GetHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II);
			return cb_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II;
		}

		static IntPtr n_GetHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetHotspot (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='getHotspot' and count(parameter)=3 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem.HotspotPlace'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;II)Landroid/graphics/Point;", "GetGetHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_IIHandler")]
		public virtual global::Android.Graphics.Point GetHotspot (global::Osmdroid.Views.Overlay.OverlayItem.HotspotPlace p0, int p1, int p2)
		{
			if (id_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II == IntPtr.Zero)
				id_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II = JNIEnv.GetMethodID (class_ref, "getHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;II)Landroid/graphics/Point;");

			global::Android.Graphics.Point __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod  (Handle, id_getHotspot_Lorg_osmdroid_views_overlay_OverlayItem_HotspotPlace_II, new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHotspot", "(Lorg/osmdroid/views/overlay/OverlayItem$HotspotPlace;II)Landroid/graphics/Point;"), new JValue (p0), new JValue (p1), new JValue (p2)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setSnippet_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSnippet_Ljava_lang_String_Handler ()
		{
			if (cb_setSnippet_Ljava_lang_String_ == null)
				cb_setSnippet_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSnippet_Ljava_lang_String_);
			return cb_setSnippet_Ljava_lang_String_;
		}

		static void n_SetSnippet_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSnippet (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSnippet_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
		public virtual void SetSnippet (string p0)
		{
			if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
				id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setSnippet_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSnippet", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTitle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTitle_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
		public virtual void SetTitle (string p0)
		{
			if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
				id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetShowBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z == null)
				cb_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShowBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z);
			return cb_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_ShowBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowBubble (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ExtendedOverlayItem']/method[@name='showBubble' and count(parameter)=3 and parameter[1][@type='org.osmdroid.bonuspack.overlays.InfoWindow'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("showBubble", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;Lorg/osmdroid/views/MapView;Z)V", "GetShowBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_ZHandler")]
		public virtual void ShowBubble (global::Osmdroid.Bonuspack.Overlays.InfoWindow p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "showBubble", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showBubble_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showBubble", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
