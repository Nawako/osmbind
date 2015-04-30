using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/GroundOverlay", DoNotGenerateAcw=true)]
	public partial class GroundOverlay : global::Osmdroid.Views.Overlay.Overlay {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='NO_DIMENSION']"
		[Register ("NO_DIMENSION")]
		public const float NoDimension = (float) -1.000000;

		static IntPtr mBearing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mBearing']"
		[Register ("mBearing")]
		protected float MBearing {
			get {
				if (mBearing_jfieldId == IntPtr.Zero)
					mBearing_jfieldId = JNIEnv.GetFieldID (class_ref, "mBearing", "F");
				return JNIEnv.GetFloatField (Handle, mBearing_jfieldId);
			}
			set {
				if (mBearing_jfieldId == IntPtr.Zero)
					mBearing_jfieldId = JNIEnv.GetFieldID (class_ref, "mBearing", "F");
				JNIEnv.SetField (Handle, mBearing_jfieldId, value);
			}
		}

		static IntPtr mHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mHeight']"
		[Register ("mHeight")]
		protected float MHeight {
			get {
				if (mHeight_jfieldId == IntPtr.Zero)
					mHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeight", "F");
				return JNIEnv.GetFloatField (Handle, mHeight_jfieldId);
			}
			set {
				if (mHeight_jfieldId == IntPtr.Zero)
					mHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeight", "F");
				JNIEnv.SetField (Handle, mHeight_jfieldId, value);
			}
		}

		static IntPtr mImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mImage']"
		[Register ("mImage")]
		protected global::Android.Graphics.Drawables.Drawable MImage {
			get {
				if (mImage_jfieldId == IntPtr.Zero)
					mImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mImage", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mImage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mImage_jfieldId == IntPtr.Zero)
					mImage_jfieldId = JNIEnv.GetFieldID (class_ref, "mImage", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mImage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mPosition']"
		[Register ("mPosition")]
		protected global::Org.Osmdroid.Util.GeoPoint MPosition {
			get {
				if (mPosition_jfieldId == IntPtr.Zero)
					mPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mPosition", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPosition_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPosition_jfieldId == IntPtr.Zero)
					mPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mPosition", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPosition_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPositionPixels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mPositionPixels']"
		[Register ("mPositionPixels")]
		protected global::Android.Graphics.Point MPositionPixels {
			get {
				if (mPositionPixels_jfieldId == IntPtr.Zero)
					mPositionPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionPixels", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPositionPixels_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPositionPixels_jfieldId == IntPtr.Zero)
					mPositionPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mPositionPixels", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPositionPixels_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSouthEastPixels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mSouthEastPixels']"
		[Register ("mSouthEastPixels")]
		protected global::Android.Graphics.Point MSouthEastPixels {
			get {
				if (mSouthEastPixels_jfieldId == IntPtr.Zero)
					mSouthEastPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mSouthEastPixels", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSouthEastPixels_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSouthEastPixels_jfieldId == IntPtr.Zero)
					mSouthEastPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mSouthEastPixels", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mSouthEastPixels_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTransparency_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mTransparency']"
		[Register ("mTransparency")]
		protected float MTransparency {
			get {
				if (mTransparency_jfieldId == IntPtr.Zero)
					mTransparency_jfieldId = JNIEnv.GetFieldID (class_ref, "mTransparency", "F");
				return JNIEnv.GetFloatField (Handle, mTransparency_jfieldId);
			}
			set {
				if (mTransparency_jfieldId == IntPtr.Zero)
					mTransparency_jfieldId = JNIEnv.GetFieldID (class_ref, "mTransparency", "F");
				JNIEnv.SetField (Handle, mTransparency_jfieldId, value);
			}
		}

		static IntPtr mWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/field[@name='mWidth']"
		[Register ("mWidth")]
		protected float MWidth {
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
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/GroundOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroundOverlay); }
		}

		protected GroundOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/constructor[@name='GroundOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GroundOverlay (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GroundOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/constructor[@name='GroundOverlay' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/ResourceProxy;)V", "")]
		public GroundOverlay (global::Osmdroid.IResourceProxy p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GroundOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/ResourceProxy;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/ResourceProxy;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_ResourceProxy_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_ResourceProxy_, new JValue (p0));
		}

		static Delegate cb_getBearing;
#pragma warning disable 0169
		static Delegate GetGetBearingHandler ()
		{
			if (cb_getBearing == null)
				cb_getBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBearing);
			return cb_getBearing;
		}

		static float n_GetBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		static Delegate cb_setBearing_F;
#pragma warning disable 0169
		static Delegate GetSetBearing_FHandler ()
		{
			if (cb_setBearing_F == null)
				cb_setBearing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBearing_F);
			return cb_setBearing_F;
		}

		static void n_SetBearing_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bearing = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBearing;
		static IntPtr id_setBearing_F;
		public virtual float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBearing", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler")]
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBearing_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearing", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHeight);
			return cb_getHeight;
		}

		static float n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual float Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()F", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getHeight);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()F"));
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
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Image = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImage;
		static IntPtr id_setImage_Landroid_graphics_drawable_Drawable_;
		public virtual global::Android.Graphics.Drawables.Drawable Image {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getImage' and count(parameter)=0]"
			[Register ("getImage", "()Landroid/graphics/drawable/Drawable;", "GetGetImageHandler")]
			get {
				if (id_getImage == IntPtr.Zero)
					id_getImage = JNIEnv.GetMethodID (class_ref, "getImage", "()Landroid/graphics/drawable/Drawable;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getImage), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImage", "()Landroid/graphics/drawable/Drawable;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
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

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_setPosition_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lorg_osmdroid_util_GeoPoint_);
			return cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
		}

		static void n_SetPosition_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lorg_osmdroid_util_GeoPoint_;
		public virtual global::Org.Osmdroid.Util.GeoPoint Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lorg/osmdroid/util/GeoPoint;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
			[Register ("setPosition", "(Lorg/osmdroid/util/GeoPoint;)V", "GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler")]
			set {
				if (id_setPosition_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
					id_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lorg_osmdroid_util_GeoPoint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V"), new JValue (value));
			}
		}

		static Delegate cb_getTransparency;
#pragma warning disable 0169
		static Delegate GetGetTransparencyHandler ()
		{
			if (cb_getTransparency == null)
				cb_getTransparency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTransparency);
			return cb_getTransparency;
		}

		static float n_GetTransparency (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Transparency;
		}
#pragma warning restore 0169

		static Delegate cb_setTransparency_F;
#pragma warning disable 0169
		static Delegate GetSetTransparency_FHandler ()
		{
			if (cb_setTransparency_F == null)
				cb_setTransparency_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTransparency_F);
			return cb_setTransparency_F;
		}

		static void n_SetTransparency_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Transparency = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTransparency;
		static IntPtr id_setTransparency_F;
		public virtual float Transparency {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getTransparency' and count(parameter)=0]"
			[Register ("getTransparency", "()F", "GetGetTransparencyHandler")]
			get {
				if (id_getTransparency == IntPtr.Zero)
					id_getTransparency = JNIEnv.GetMethodID (class_ref, "getTransparency", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getTransparency);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransparency", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setTransparency' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparency", "(F)V", "GetSetTransparency_FHandler")]
			set {
				if (id_setTransparency_F == IntPtr.Zero)
					id_setTransparency_F = JNIEnv.GetMethodID (class_ref, "setTransparency", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTransparency_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransparency", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWidth);
			return cb_getWidth;
		}

		static float n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()F"));
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_setDimensions_F;
#pragma warning disable 0169
		static Delegate GetSetDimensions_FHandler ()
		{
			if (cb_setDimensions_F == null)
				cb_setDimensions_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDimensions_F);
			return cb_setDimensions_F;
		}

		static void n_SetDimensions_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDimensions_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDimensions", "(F)V", "GetSetDimensions_FHandler")]
		public virtual void SetDimensions (float p0)
		{
			if (id_setDimensions_F == IntPtr.Zero)
				id_setDimensions_F = JNIEnv.GetMethodID (class_ref, "setDimensions", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDimensions_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDimensions", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setDimensions_FF;
#pragma warning disable 0169
		static Delegate GetSetDimensions_FFHandler ()
		{
			if (cb_setDimensions_FF == null)
				cb_setDimensions_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetDimensions_FF);
			return cb_setDimensions_FF;
		}

		static void n_SetDimensions_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Osmdroid.Bonuspack.Overlays.GroundOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.GroundOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDimensions (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setDimensions_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='GroundOverlay']/method[@name='setDimensions' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setDimensions", "(FF)V", "GetSetDimensions_FFHandler")]
		public virtual void SetDimensions (float p0, float p1)
		{
			if (id_setDimensions_FF == IntPtr.Zero)
				id_setDimensions_FF = JNIEnv.GetMethodID (class_ref, "setDimensions", "(FF)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setDimensions_FF, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDimensions", "(FF)V"), new JValue (p0), new JValue (p1));
		}

	}
}
