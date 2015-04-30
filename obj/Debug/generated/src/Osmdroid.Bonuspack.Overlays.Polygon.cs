using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Polygon", DoNotGenerateAcw=true)]
	public partial class Polygon : global::Osmdroid.Views.Overlay.Overlay {


		static IntPtr mFillPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/field[@name='mFillPaint']"
		[Register ("mFillPaint")]
		protected global::Android.Graphics.Paint MFillPaint {
			get {
				if (mFillPaint_jfieldId == IntPtr.Zero)
					mFillPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mFillPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mFillPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFillPaint_jfieldId == IntPtr.Zero)
					mFillPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mFillPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mFillPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mInfoWindow_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/field[@name='mInfoWindow']"
		[Register ("mInfoWindow")]
		protected global::Osmdroid.Bonuspack.Overlays.InfoWindow MInfoWindow {
			get {
				if (mInfoWindow_jfieldId == IntPtr.Zero)
					mInfoWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mInfoWindow", "Lorg/osmdroid/bonuspack/overlays/InfoWindow;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mInfoWindow_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mInfoWindow_jfieldId == IntPtr.Zero)
					mInfoWindow_jfieldId = JNIEnv.GetFieldID (class_ref, "mInfoWindow", "Lorg/osmdroid/bonuspack/overlays/InfoWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mInfoWindow_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mOutlinePaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/field[@name='mOutlinePaint']"
		[Register ("mOutlinePaint")]
		protected global::Android.Graphics.Paint MOutlinePaint {
			get {
				if (mOutlinePaint_jfieldId == IntPtr.Zero)
					mOutlinePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutlinePaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOutlinePaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOutlinePaint_jfieldId == IntPtr.Zero)
					mOutlinePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutlinePaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOutlinePaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mSnippet_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/field[@name='mSnippet']"
		[Register ("mSnippet")]
		protected string MSnippet {
			get {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mSnippet_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSnippet_jfieldId == IntPtr.Zero)
					mSnippet_jfieldId = JNIEnv.GetFieldID (class_ref, "mSnippet", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mSnippet_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTitle_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/field[@name='mTitle']"
		[Register ("mTitle")]
		protected string MTitle {
			get {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTitle_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTitle_jfieldId == IntPtr.Zero)
					mTitle_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitle", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mTitle_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon.LinearRing']"
		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/Polygon$LinearRing", DoNotGenerateAcw=true)]
		public partial class LinearRing : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Polygon$LinearRing", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LinearRing); }
			}

			protected LinearRing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_buildPathPortion_Lorg_osmdroid_views_Projection_;
#pragma warning disable 0169
			static Delegate GetBuildPathPortion_Lorg_osmdroid_views_Projection_Handler ()
			{
				if (cb_buildPathPortion_Lorg_osmdroid_views_Projection_ == null)
					cb_buildPathPortion_Lorg_osmdroid_views_Projection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_BuildPathPortion_Lorg_osmdroid_views_Projection_);
				return cb_buildPathPortion_Lorg_osmdroid_views_Projection_;
			}

			static void n_BuildPathPortion_Lorg_osmdroid_views_Projection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Osmdroid.Bonuspack.Overlays.Polygon.LinearRing __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon.LinearRing> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Osmdroid.Views.Projection p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.BuildPathPortion (p0);
			}
#pragma warning restore 0169

			static IntPtr id_buildPathPortion_Lorg_osmdroid_views_Projection_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon.LinearRing']/method[@name='buildPathPortion' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.Projection']]"
			[Register ("buildPathPortion", "(Lorg/osmdroid/views/Projection;)V", "GetBuildPathPortion_Lorg_osmdroid_views_Projection_Handler")]
			protected virtual void BuildPathPortion (global::Osmdroid.Views.Projection p0)
			{
				if (id_buildPathPortion_Lorg_osmdroid_views_Projection_ == IntPtr.Zero)
					id_buildPathPortion_Lorg_osmdroid_views_Projection_ = JNIEnv.GetMethodID (class_ref, "buildPathPortion", "(Lorg/osmdroid/views/Projection;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_buildPathPortion_Lorg_osmdroid_views_Projection_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildPathPortion", "(Lorg/osmdroid/views/Projection;)V"), new JValue (p0));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/Polygon", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Polygon); }
		}

		protected Polygon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/constructor[@name='Polygon' and count(parameter)=1 and parameter[1][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Lorg/osmdroid/ResourceProxy;)V", "")]
		public Polygon (global::Osmdroid.IResourceProxy p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Polygon)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/constructor[@name='Polygon' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public Polygon (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Polygon)) {
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

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_setFillColor_I == null)
				cb_setFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_setFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFillColor;
		static IntPtr id_setFillColor_I;
		public virtual int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFillColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFillColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				if (id_setFillColor_I == IntPtr.Zero)
					id_setFillColor_I = JNIEnv.GetMethodID (class_ref, "setFillColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFillColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFillColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getHoles;
#pragma warning disable 0169
		static Delegate GetGetHolesHandler ()
		{
			if (cb_getHoles == null)
				cb_getHoles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHoles);
			return cb_getHoles;
		}

		static IntPtr n_GetHoles (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>>.ToLocalJniHandle (__this.Holes);
		}
#pragma warning restore 0169

		static Delegate cb_setHoles_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHoles_Ljava_util_List_Handler ()
		{
			if (cb_setHoles_Ljava_util_List_ == null)
				cb_setHoles_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHoles_Ljava_util_List_);
			return cb_setHoles_Ljava_util_List_;
		}

		static void n_SetHoles_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint>> p0 = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Holes = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHoles;
		static IntPtr id_setHoles_Ljava_util_List_;
		public virtual global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>> Holes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getHoles' and count(parameter)=0]"
			[Register ("getHoles", "()Ljava/util/List;", "GetGetHolesHandler")]
			get {
				if (id_getHoles == IntPtr.Zero)
					id_getHoles = JNIEnv.GetMethodID (class_ref, "getHoles", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHoles), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHoles", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setHoles' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setHoles", "(Ljava/util/List;)V", "GetSetHoles_Ljava_util_List_Handler")]
			set {
				if (id_setHoles_Ljava_util_List_ == IntPtr.Zero)
					id_setHoles_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHoles", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint>>.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHoles_Ljava_util_List_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHoles", "(Ljava/util/List;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Util.GeoPoint> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Points = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPoints;
		static IntPtr id_setPoints_Ljava_util_List_;
		public virtual global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				if (id_getPoints == IntPtr.Zero)
					id_getPoints = JNIEnv.GetMethodID (class_ref, "getPoints", "()Ljava/util/List;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPoints), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
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

		static Delegate cb_getSnippet;
#pragma warning disable 0169
		static Delegate GetGetSnippetHandler ()
		{
			if (cb_getSnippet == null)
				cb_getSnippet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSnippet);
			return cb_getSnippet;
		}

		static IntPtr n_GetSnippet (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Snippet);
		}
#pragma warning restore 0169

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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Snippet = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSnippet;
		static IntPtr id_setSnippet_Ljava_lang_String_;
		public virtual string Snippet {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getSnippet' and count(parameter)=0]"
			[Register ("getSnippet", "()Ljava/lang/String;", "GetGetSnippetHandler")]
			get {
				if (id_getSnippet == IntPtr.Zero)
					id_getSnippet = JNIEnv.GetMethodID (class_ref, "getSnippet", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getSnippet), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSnippet", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setSnippet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSnippet", "(Ljava/lang/String;)V", "GetSetSnippet_Ljava_lang_String_Handler")]
			set {
				if (id_setSnippet_Ljava_lang_String_ == IntPtr.Zero)
					id_setSnippet_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSnippet", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSnippet_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSnippet", "(Ljava/lang/String;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetStrokeColorHandler ()
		{
			if (cb_getStrokeColor == null)
				cb_getStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStrokeColor);
			return cb_getStrokeColor;
		}

		static int n_GetStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeColor;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetStrokeColor_IHandler ()
		{
			if (cb_setStrokeColor_I == null)
				cb_setStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStrokeColor_I);
			return cb_setStrokeColor_I;
		}

		static void n_SetStrokeColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeColor;
		static IntPtr id_setStrokeColor_I;
		public virtual int StrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getStrokeColor' and count(parameter)=0]"
			[Register ("getStrokeColor", "()I", "GetGetStrokeColorHandler")]
			get {
				if (id_getStrokeColor == IntPtr.Zero)
					id_getStrokeColor = JNIEnv.GetMethodID (class_ref, "getStrokeColor", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getStrokeColor);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeColor", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrokeColor", "(I)V", "GetSetStrokeColor_IHandler")]
			set {
				if (id_setStrokeColor_I == IntPtr.Zero)
					id_setStrokeColor_I = JNIEnv.GetMethodID (class_ref, "setStrokeColor", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStrokeColor_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeColor", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_getStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetStrokeWidthHandler ()
		{
			if (cb_getStrokeWidth == null)
				cb_getStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStrokeWidth);
			return cb_getStrokeWidth;
		}

		static float n_GetStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetStrokeWidth_FHandler ()
		{
			if (cb_setStrokeWidth_F == null)
				cb_setStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStrokeWidth_F);
			return cb_setStrokeWidth_F;
		}

		static void n_SetStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrokeWidth = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStrokeWidth;
		static IntPtr id_setStrokeWidth_F;
		public virtual float StrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getStrokeWidth' and count(parameter)=0]"
			[Register ("getStrokeWidth", "()F", "GetGetStrokeWidthHandler")]
			get {
				if (id_getStrokeWidth == IntPtr.Zero)
					id_getStrokeWidth = JNIEnv.GetMethodID (class_ref, "getStrokeWidth", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getStrokeWidth);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStrokeWidth", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStrokeWidth", "(F)V", "GetSetStrokeWidth_FHandler")]
			set {
				if (id_setStrokeWidth_F == IntPtr.Zero)
					id_setStrokeWidth_F = JNIEnv.GetMethodID (class_ref, "setStrokeWidth", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStrokeWidth_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStrokeWidth", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), new JValue (native_value));
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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVisible;
		static IntPtr id_setVisible_Z;
		public virtual bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isVisible);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetContains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == null)
				cb_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_);
			return cb_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		}

		static bool n_Contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='contains' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("contains", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z", "GetContains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_Handler")]
		public virtual bool Contains (global::Android.Views.MotionEvent p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "contains", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_contains_Landroid_view_MotionEvent_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contains", "(Landroid/view/MotionEvent;Lorg/osmdroid/views/MapView;)Z"), new JValue (p0), new JValue (p1));
			return __ret;
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
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
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

		static Delegate cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_;
#pragma warning disable 0169
		static Delegate GetSetInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Handler ()
		{
			if (cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ == null)
				cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_);
			return cb_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_;
		}

		static void n_SetInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindow (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setInfoWindow' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.InfoWindow']]"
		[Register ("setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V", "GetSetInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_Handler")]
		public virtual void SetInfoWindow (global::Osmdroid.Bonuspack.Overlays.InfoWindow p0)
		{
			if (id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ == IntPtr.Zero)
				id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ = JNIEnv.GetMethodID (class_ref, "setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setInfoWindow_Lorg_osmdroid_bonuspack_overlays_InfoWindow_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInfoWindow", "(Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V"), new JValue (p0));
		}

		static Delegate cb_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D;
#pragma warning disable 0169
		static Delegate GetSetPointsAsCircle_Lorg_osmdroid_util_GeoPoint_DHandler ()
		{
			if (cb_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D == null)
				cb_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_SetPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D);
			return cb_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D;
		}

		static void n_SetPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Osmdroid.Bonuspack.Overlays.Polygon __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Polygon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPointsAsCircle (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='Polygon']/method[@name='setPointsAsCircle' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='double']]"
		[Register ("setPointsAsCircle", "(Lorg/osmdroid/util/GeoPoint;D)V", "GetSetPointsAsCircle_Lorg_osmdroid_util_GeoPoint_DHandler")]
		public virtual void SetPointsAsCircle (global::Org.Osmdroid.Util.GeoPoint p0, double p1)
		{
			if (id_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D == IntPtr.Zero)
				id_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D = JNIEnv.GetMethodID (class_ref, "setPointsAsCircle", "(Lorg/osmdroid/util/GeoPoint;D)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPointsAsCircle_Lorg_osmdroid_util_GeoPoint_D, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPointsAsCircle", "(Lorg/osmdroid/util/GeoPoint;D)V"), new JValue (p0), new JValue (p1));
		}

	}
}
