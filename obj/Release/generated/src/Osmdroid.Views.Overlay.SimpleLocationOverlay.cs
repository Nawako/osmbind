using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/SimpleLocationOverlay", DoNotGenerateAcw=true)]
	public partial class SimpleLocationOverlay : global::Osmdroid.Views.Overlay.Overlay {


		static IntPtr PERSON_HOTSPOT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/field[@name='PERSON_HOTSPOT']"
		[Register ("PERSON_HOTSPOT")]
		protected global::Android.Graphics.Point PersonHotspot {
			get {
				if (PERSON_HOTSPOT_jfieldId == IntPtr.Zero)
					PERSON_HOTSPOT_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_HOTSPOT", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, PERSON_HOTSPOT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERSON_HOTSPOT_jfieldId == IntPtr.Zero)
					PERSON_HOTSPOT_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_HOTSPOT", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, PERSON_HOTSPOT_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr PERSON_ICON_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/field[@name='PERSON_ICON']"
		[Register ("PERSON_ICON")]
		protected global::Android.Graphics.Bitmap PersonIcon {
			get {
				if (PERSON_ICON_jfieldId == IntPtr.Zero)
					PERSON_ICON_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_ICON", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, PERSON_ICON_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PERSON_ICON_jfieldId == IntPtr.Zero)
					PERSON_ICON_jfieldId = JNIEnv.GetFieldID (class_ref, "PERSON_ICON", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, PERSON_ICON_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLocation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/field[@name='mLocation']"
		[Register ("mLocation")]
		protected global::Osmdroid.Util.GeoPoint MLocation {
			get {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLocation_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/field[@name='mPaint']"
		[Register ("mPaint")]
		protected global::Android.Graphics.Paint MPaint {
			get {
				if (mPaint_jfieldId == IntPtr.Zero)
					mPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPaint_jfieldId == IntPtr.Zero)
					mPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/SimpleLocationOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleLocationOverlay); }
		}

		protected SimpleLocationOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/constructor[@name='SimpleLocationOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", "")]
		public SimpleLocationOverlay (global::Android.Content.Context ctx, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleLocationOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", new JValue (ctx), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", new JValue (ctx), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_, new JValue (ctx), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_, new JValue (ctx), new JValue (pResourceProxy));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/constructor[@name='SimpleLocationOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public SimpleLocationOverlay (global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SimpleLocationOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (ctx)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (ctx));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (ctx)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (ctx));
		}

		static Delegate cb_getMyLocation;
#pragma warning disable 0169
		static Delegate GetGetMyLocationHandler ()
		{
			if (cb_getMyLocation == null)
				cb_getMyLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyLocation);
			return cb_getMyLocation;
		}

		static IntPtr n_GetMyLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.SimpleLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.SimpleLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getMyLocation;
		public virtual global::Osmdroid.Util.GeoPoint MyLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/method[@name='getMyLocation' and count(parameter)=0]"
			[Register ("getMyLocation", "()Lorg/osmdroid/util/GeoPoint;", "GetGetMyLocationHandler")]
			get {
				if (id_getMyLocation == IntPtr.Zero)
					id_getMyLocation = JNIEnv.GetMethodID (class_ref, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getMyLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyLocation", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
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

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_osmv, bool shadow)
		{
			global::Osmdroid.Views.Overlay.SimpleLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.SimpleLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, osmv, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (osmv), new JValue (shadow));
		}

		static Delegate cb_setLocation_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_setLocation_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_setLocation_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Lorg_osmdroid_util_GeoPoint_);
			return cb_setLocation_Lorg_osmdroid_util_GeoPoint_;
		}

		static void n_SetLocation_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mp)
		{
			global::Osmdroid.Views.Overlay.SimpleLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.SimpleLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint mp = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_mp, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (mp);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='SimpleLocationOverlay']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("setLocation", "(Lorg/osmdroid/util/GeoPoint;)V", "GetSetLocation_Lorg_osmdroid_util_GeoPoint_Handler")]
		public virtual void SetLocation (global::Osmdroid.Util.GeoPoint mp)
		{
			if (id_setLocation_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_setLocation_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lorg/osmdroid/util/GeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLocation_Lorg_osmdroid_util_GeoPoint_, new JValue (mp));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Lorg/osmdroid/util/GeoPoint;)V"), new JValue (mp));
		}

	}
}
