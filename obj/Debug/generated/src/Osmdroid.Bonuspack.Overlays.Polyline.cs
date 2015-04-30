using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Polyline", DoNotGenerateAcw=true)]
	public partial class Polyline : global::Osmdroid.Views.Overlay.PathOverlay {


		static IntPtr mGeodesic_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/field[@name='mGeodesic']"
		[Register ("mGeodesic")]
		protected bool MGeodesic {
			get {
				if (mGeodesic_jfieldId == IntPtr.Zero)
					mGeodesic_jfieldId = JNIEnv.GetFieldID (class_ref, "mGeodesic", "Z");
				return JNIEnv.GetBooleanField (Handle, mGeodesic_jfieldId);
			}
			set {
				if (mGeodesic_jfieldId == IntPtr.Zero)
					mGeodesic_jfieldId = JNIEnv.GetFieldID (class_ref, "mGeodesic", "Z");
				JNIEnv.SetField (Handle, mGeodesic_jfieldId, value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Polyline", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polyline); }
		}

		protected Polyline (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/constructor[@name='Polyline' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/ResourceProxy;)V", "")]
		public Polyline (global::Osmdroid.IResourceProxy p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Polyline)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/constructor[@name='Polyline' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public Polyline (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Polyline)) {
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

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
			}
		}

		static Delegate cb_isGeodesic;
#pragma warning disable 0169
		static Delegate GetIsGeodesicHandler ()
		{
			if (cb_isGeodesic == null)
				cb_isGeodesic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGeodesic);
			return cb_isGeodesic;
		}

		static bool n_IsGeodesic (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Geodesic;
		}
#pragma warning restore 0169

		static Delegate cb_setGeodesic_Z;
#pragma warning disable 0169
		static Delegate GetSetGeodesic_ZHandler ()
		{
			if (cb_setGeodesic_Z == null)
				cb_setGeodesic_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGeodesic_Z);
			return cb_setGeodesic_Z;
		}

		static void n_SetGeodesic_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Geodesic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isGeodesic;
		static IntPtr id_setGeodesic_Z;
		public virtual bool Geodesic {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='isGeodesic' and count(parameter)=0]"
			[Register ("isGeodesic", "()Z", "GetIsGeodesicHandler")]
			get {
				if (id_isGeodesic == IntPtr.Zero)
					id_isGeodesic = JNIEnv.GetMethodID (class_ref, "isGeodesic", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isGeodesic);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGeodesic", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='setGeodesic' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGeodesic", "(Z)V", "GetSetGeodesic_ZHandler")]
			set {
				if (id_setGeodesic_Z == IntPtr.Zero)
					id_setGeodesic_Z = JNIEnv.GetMethodID (class_ref, "setGeodesic", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setGeodesic_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGeodesic", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_getPoints;
#pragma warning disable 0169
		static Delegate GetGetPointsHandler ()
		{
			if (cb_getPoints == null)
				cb_getPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoints);
			return cb_getPoints;
		}

		static IntPtr n_GetPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (__this.Points);
		}
#pragma warning restore 0169

		static Delegate cb_setPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPoints_Ljava_util_List_Handler ()
		{
			if (cb_setPoints_Ljava_util_List_ == null)
				cb_setPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoints_Ljava_util_List_);
			return cb_setPoints_Ljava_util_List_;
		}

		static void n_SetPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Points = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				if (id_setPoints_Ljava_util_List_ == IntPtr.Zero)
					id_setPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPoints", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPoints_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoints", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public virtual bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setVisible_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisible", "(Z)V"), new JValue (value));
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
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_F;
#pragma warning disable 0169
		static Delegate GetSetWidth_FHandler ()
		{
			if (cb_setWidth_F == null)
				cb_setWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWidth_F);
			return cb_setWidth_F;
		}

		static void n_SetWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polyline __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polyline> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		static IntPtr id_setWidth_F;
		public virtual float Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()F", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polyline']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWidth", "(F)V", "GetSetWidth_FHandler")]
			set {
				if (id_setWidth_F == IntPtr.Zero)
					id_setWidth_F = JNIEnv.GetMethodID (class_ref, "setWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWidth", "(F)V"), new JValue (value));
			}
		}

	}
}
