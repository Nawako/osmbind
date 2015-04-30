using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/DirectedLocationOverlay", DoNotGenerateAcw=true)]
	public partial class DirectedLocationOverlay : global::Osmdroid.Views.Overlay.Overlay {


		static IntPtr DIRECTION_ARROW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/field[@name='DIRECTION_ARROW']"
		[Register ("DIRECTION_ARROW")]
		protected global::Android.Graphics.Bitmap DirectionArrow {
			get {
				if (DIRECTION_ARROW_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, DIRECTION_ARROW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DIRECTION_ARROW_jfieldId == IntPtr.Zero)
					DIRECTION_ARROW_jfieldId = JNIEnv.GetFieldID (class_ref, "DIRECTION_ARROW", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, DIRECTION_ARROW_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mAccuracyPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/field[@name='mAccuracyPaint']"
		[Register ("mAccuracyPaint")]
		protected global::Android.Graphics.Paint MAccuracyPaint {
			get {
				if (mAccuracyPaint_jfieldId == IntPtr.Zero)
					mAccuracyPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccuracyPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mAccuracyPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAccuracyPaint_jfieldId == IntPtr.Zero)
					mAccuracyPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mAccuracyPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mAccuracyPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mBearing_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/field[@name='mBearing']"
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

		static IntPtr mLocation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/field[@name='mLocation']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/field[@name='mPaint']"
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
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/DirectedLocationOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DirectedLocationOverlay); }
		}

		protected DirectedLocationOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/constructor[@name='DirectedLocationOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", "")]
		public DirectedLocationOverlay (global::Android.Content.Context ctx, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DirectedLocationOverlay)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/constructor[@name='DirectedLocationOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public DirectedLocationOverlay (global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DirectedLocationOverlay)) {
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

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

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
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Util.GeoPoint mp = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (native_mp, JniHandleOwnership.DoNotTransfer);
			__this.Location = mp;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Lorg_osmdroid_util_GeoPoint_;
		public virtual global::Osmdroid.Util.GeoPoint Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Lorg/osmdroid/util/GeoPoint;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
			[Register ("setLocation", "(Lorg/osmdroid/util/GeoPoint;)V", "GetSetLocation_Lorg_osmdroid_util_GeoPoint_Handler")]
			set {
				if (id_setLocation_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
					id_setLocation_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Lorg/osmdroid/util/GeoPoint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setLocation_Lorg_osmdroid_util_GeoPoint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Lorg/osmdroid/util/GeoPoint;)V"), new JValue (value));
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
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, osmv, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
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

		static Delegate cb_setAccuracy_I;
#pragma warning disable 0169
		static Delegate GetSetAccuracy_IHandler ()
		{
			if (cb_setAccuracy_I == null)
				cb_setAccuracy_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAccuracy_I);
			return cb_setAccuracy_I;
		}

		static void n_SetAccuracy_I (IntPtr jnienv, IntPtr native__this, int pAccuracy)
		{
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAccuracy (pAccuracy);
		}
#pragma warning restore 0169

		static IntPtr id_setAccuracy_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='setAccuracy' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAccuracy", "(I)V", "GetSetAccuracy_IHandler")]
		public virtual void SetAccuracy (int pAccuracy)
		{
			if (id_setAccuracy_I == IntPtr.Zero)
				id_setAccuracy_I = JNIEnv.GetMethodID (class_ref, "setAccuracy", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAccuracy_I, new JValue (pAccuracy));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccuracy", "(I)V"), new JValue (pAccuracy));
		}

		static Delegate cb_setBearing_F;
#pragma warning disable 0169
		static Delegate GetSetBearing_FHandler ()
		{
			if (cb_setBearing_F == null)
				cb_setBearing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBearing_F);
			return cb_setBearing_F;
		}

		static void n_SetBearing_F (IntPtr jnienv, IntPtr native__this, float aHeading)
		{
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBearing (aHeading);
		}
#pragma warning restore 0169

		static IntPtr id_setBearing_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBearing", "(F)V", "GetSetBearing_FHandler")]
		public virtual void SetBearing (float aHeading)
		{
			if (id_setBearing_F == IntPtr.Zero)
				id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBearing_F, new JValue (aHeading));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearing", "(F)V"), new JValue (aHeading));
		}

		static Delegate cb_setShowAccuracy_Z;
#pragma warning disable 0169
		static Delegate GetSetShowAccuracy_ZHandler ()
		{
			if (cb_setShowAccuracy_Z == null)
				cb_setShowAccuracy_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowAccuracy_Z);
			return cb_setShowAccuracy_Z;
		}

		static void n_SetShowAccuracy_Z (IntPtr jnienv, IntPtr native__this, bool pShowIt)
		{
			global::Osmdroid.Views.Overlay.DirectedLocationOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.DirectedLocationOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShowAccuracy (pShowIt);
		}
#pragma warning restore 0169

		static IntPtr id_setShowAccuracy_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='DirectedLocationOverlay']/method[@name='setShowAccuracy' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowAccuracy", "(Z)V", "GetSetShowAccuracy_ZHandler")]
		public virtual void SetShowAccuracy (bool pShowIt)
		{
			if (id_setShowAccuracy_Z == IntPtr.Zero)
				id_setShowAccuracy_Z = JNIEnv.GetMethodID (class_ref, "setShowAccuracy", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setShowAccuracy_Z, new JValue (pShowIt));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowAccuracy", "(Z)V"), new JValue (pShowIt));
		}

	}
}
