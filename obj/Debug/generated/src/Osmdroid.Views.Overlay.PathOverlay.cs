using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/PathOverlay", DoNotGenerateAcw=true)]
	public partial class PathOverlay : global::Osmdroid.Views.Overlay.Overlay {


		static IntPtr mPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/field[@name='mPaint']"
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
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/PathOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PathOverlay); }
		}

		protected PathOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/constructor[@name='PathOverlay' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(ILorg/osmdroid/ResourceProxy;)V", "")]
		public PathOverlay (int color, global::Osmdroid.IResourceProxy resourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PathOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILorg/osmdroid/ResourceProxy;)V", new JValue (color), new JValue (resourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILorg/osmdroid/ResourceProxy;)V", new JValue (color), new JValue (resourceProxy));
				return;
			}

			if (id_ctor_ILorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_ILorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_osmdroid_ResourceProxy_, new JValue (color), new JValue (resourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILorg_osmdroid_ResourceProxy_, new JValue (color), new JValue (resourceProxy));
		}

		static IntPtr id_ctor_ILandroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/constructor[@name='PathOverlay' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(ILandroid/content/Context;)V", "")]
		public PathOverlay (int color, global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PathOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILandroid/content/Context;)V", new JValue (color), new JValue (ctx)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILandroid/content/Context;)V", new JValue (color), new JValue (ctx));
				return;
			}

			if (id_ctor_ILandroid_content_Context_ == IntPtr.Zero)
				id_ctor_ILandroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_content_Context_, new JValue (color), new JValue (ctx)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILandroid_content_Context_, new JValue (color), new JValue (ctx));
		}

		static IntPtr id_ctor_IFLorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/constructor[@name='PathOverlay' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(IFLorg/osmdroid/ResourceProxy;)V", "")]
		public PathOverlay (int color, float width, global::Osmdroid.IResourceProxy resourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PathOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IFLorg/osmdroid/ResourceProxy;)V", new JValue (color), new JValue (width), new JValue (resourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IFLorg/osmdroid/ResourceProxy;)V", new JValue (color), new JValue (width), new JValue (resourceProxy));
				return;
			}

			if (id_ctor_IFLorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_IFLorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IFLorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IFLorg_osmdroid_ResourceProxy_, new JValue (color), new JValue (width), new JValue (resourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IFLorg_osmdroid_ResourceProxy_, new JValue (color), new JValue (width), new JValue (resourceProxy));
		}

		static Delegate cb_getNumberOfPoints;
#pragma warning disable 0169
		static Delegate GetGetNumberOfPointsHandler ()
		{
			if (cb_getNumberOfPoints == null)
				cb_getNumberOfPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfPoints);
			return cb_getNumberOfPoints;
		}

		static int n_GetNumberOfPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfPoints;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfPoints;
		public virtual int NumberOfPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='getNumberOfPoints' and count(parameter)=0]"
			[Register ("getNumberOfPoints", "()I", "GetGetNumberOfPointsHandler")]
			get {
				if (id_getNumberOfPoints == IntPtr.Zero)
					id_getNumberOfPoints = JNIEnv.GetMethodID (class_ref, "getNumberOfPoints", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNumberOfPoints);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfPoints", "()I"));
			}
		}

		static Delegate cb_getPaint;
#pragma warning disable 0169
		static Delegate GetGetPaintHandler ()
		{
			if (cb_getPaint == null)
				cb_getPaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaint);
			return cb_getPaint;
		}

		static IntPtr n_GetPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Paint);
		}
#pragma warning restore 0169

		static Delegate cb_setPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setPaint_Landroid_graphics_Paint_ == null)
				cb_setPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPaint_Landroid_graphics_Paint_);
			return cb_setPaint_Landroid_graphics_Paint_;
		}

		static void n_SetPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pPaint)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint pPaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_pPaint, JniHandleOwnership.DoNotTransfer);
			__this.Paint = pPaint;
		}
#pragma warning restore 0169

		static IntPtr id_getPaint;
		static IntPtr id_setPaint_Landroid_graphics_Paint_;
		public virtual global::Android.Graphics.Paint Paint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='getPaint' and count(parameter)=0]"
			[Register ("getPaint", "()Landroid/graphics/Paint;", "GetGetPaintHandler")]
			get {
				if (id_getPaint == IntPtr.Zero)
					id_getPaint = JNIEnv.GetMethodID (class_ref, "getPaint", "()Landroid/graphics/Paint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getPaint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='setPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
			[Register ("setPaint", "(Landroid/graphics/Paint;)V", "GetSetPaint_Landroid_graphics_Paint_Handler")]
			set {
				if (id_setPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
					id_setPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "setPaint", "(Landroid/graphics/Paint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPaint_Landroid_graphics_Paint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPaint", "(Landroid/graphics/Paint;)V"), new JValue (value));
			}
		}

		static Delegate cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetAddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_);
			return cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		}

		static void n_AddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_startPoint, IntPtr native_endPoint)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint startPoint = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_startPoint, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint endPoint = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_endPoint, JniHandleOwnership.DoNotTransfer);
			__this.AddGreatCircle (startPoint, endPoint);
		}
#pragma warning restore 0169

		static IntPtr id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addGreatCircle' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)V", "GetAddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Handler")]
		public virtual void AddGreatCircle (global::Org.Osmdroid.Util.GeoPoint startPoint, global::Org.Osmdroid.Util.GeoPoint endPoint)
		{
			if (id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_, new JValue (startPoint), new JValue (endPoint));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)V"), new JValue (startPoint), new JValue (endPoint));
		}

		static Delegate cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I;
#pragma warning disable 0169
		static Delegate GetAddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_IHandler ()
		{
			if (cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I == null)
				cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_AddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I);
			return cb_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I;
		}

		static void n_AddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I (IntPtr jnienv, IntPtr native__this, IntPtr native_startPoint, IntPtr native_endPoint, int numberOfPoints)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint startPoint = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_startPoint, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint endPoint = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_endPoint, JniHandleOwnership.DoNotTransfer);
			__this.AddGreatCircle (startPoint, endPoint, numberOfPoints);
		}
#pragma warning restore 0169

		static IntPtr id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addGreatCircle' and count(parameter)=3 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.util.GeoPoint'] and parameter[3][@type='int']]"
		[Register ("addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;I)V", "GetAddGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_IHandler")]
		public virtual void AddGreatCircle (global::Org.Osmdroid.Util.GeoPoint startPoint, global::Org.Osmdroid.Util.GeoPoint endPoint, int numberOfPoints)
		{
			if (id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I == IntPtr.Zero)
				id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I = JNIEnv.GetMethodID (class_ref, "addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addGreatCircle_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_I, new JValue (startPoint), new JValue (endPoint), new JValue (numberOfPoints));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addGreatCircle", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;I)V"), new JValue (startPoint), new JValue (endPoint), new JValue (numberOfPoints));
		}

		static Delegate cb_addPoint_II;
#pragma warning disable 0169
		static Delegate GetAddPoint_IIHandler ()
		{
			if (cb_addPoint_II == null)
				cb_addPoint_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AddPoint_II);
			return cb_addPoint_II;
		}

		static void n_AddPoint_II (IntPtr jnienv, IntPtr native__this, int aLatitudeE6, int aLongitudeE6)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddPoint (aLatitudeE6, aLongitudeE6);
		}
#pragma warning restore 0169

		static IntPtr id_addPoint_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addPoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("addPoint", "(II)V", "GetAddPoint_IIHandler")]
		public virtual void AddPoint (int aLatitudeE6, int aLongitudeE6)
		{
			if (id_addPoint_II == IntPtr.Zero)
				id_addPoint_II = JNIEnv.GetMethodID (class_ref, "addPoint", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPoint_II, new JValue (aLatitudeE6), new JValue (aLongitudeE6));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPoint", "(II)V"), new JValue (aLatitudeE6), new JValue (aLongitudeE6));
		}

		static Delegate cb_addPoint_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetAddPoint_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_addPoint_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_addPoint_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPoint_Lorg_osmdroid_api_IGeoPoint_);
			return cb_addPoint_Lorg_osmdroid_api_IGeoPoint_;
		}

		static void n_AddPoint_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPoint)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint aPoint = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_aPoint, JniHandleOwnership.DoNotTransfer);
			__this.AddPoint (aPoint);
		}
#pragma warning restore 0169

		static IntPtr id_addPoint_Lorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addPoint' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("addPoint", "(Lorg/osmdroid/api/IGeoPoint;)V", "GetAddPoint_Lorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual void AddPoint (global::Osmdroid.Api.IGeoPoint aPoint)
		{
			if (id_addPoint_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_addPoint_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "addPoint", "(Lorg/osmdroid/api/IGeoPoint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPoint_Lorg_osmdroid_api_IGeoPoint_, new JValue (aPoint));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPoint", "(Lorg/osmdroid/api/IGeoPoint;)V"), new JValue (aPoint));
		}

		static Delegate cb_addPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddPoints_Ljava_util_List_Handler ()
		{
			if (cb_addPoints_Ljava_util_List_ == null)
				cb_addPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPoints_Ljava_util_List_);
			return cb_addPoints_Ljava_util_List_;
		}

		static void n_AddPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Osmdroid.Api.IGeoPoint> p0 = global::Android.Runtime.JavaList<global::Osmdroid.Api.IGeoPoint>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPoints (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPoints_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addPoints' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addPoints", "(Ljava/util/List;)V", "GetAddPoints_Ljava_util_List_Handler")]
		public virtual void AddPoints (global::System.Collections.Generic.IList<global::Osmdroid.Api.IGeoPoint> p0)
		{
			if (id_addPoints_Ljava_util_List_ == IntPtr.Zero)
				id_addPoints_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addPoints", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Osmdroid.Api.IGeoPoint>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPoints_Ljava_util_List_, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPoints", "(Ljava/util/List;)V"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_addPoints_arrayLorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetAddPoints_arrayLorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_addPoints_arrayLorg_osmdroid_api_IGeoPoint_ == null)
				cb_addPoints_arrayLorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPoints_arrayLorg_osmdroid_api_IGeoPoint_);
			return cb_addPoints_arrayLorg_osmdroid_api_IGeoPoint_;
		}

		static void n_AddPoints_arrayLorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aPoints)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint[] aPoints = (global::Osmdroid.Api.IGeoPoint[]) JNIEnv.GetArray (native_aPoints, JniHandleOwnership.DoNotTransfer, typeof (global::Osmdroid.Api.IGeoPoint));
			__this.AddPoints (aPoints);
			if (aPoints != null)
				JNIEnv.CopyArray (aPoints, native_aPoints);
		}
#pragma warning restore 0169

		static IntPtr id_addPoints_arrayLorg_osmdroid_api_IGeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='addPoints' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint...']]"
		[Register ("addPoints", "([Lorg/osmdroid/api/IGeoPoint;)V", "GetAddPoints_arrayLorg_osmdroid_api_IGeoPoint_Handler")]
		public virtual void AddPoints (params global:: Osmdroid.Api.IGeoPoint[] aPoints)
		{
			if (id_addPoints_arrayLorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_addPoints_arrayLorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "addPoints", "([Lorg/osmdroid/api/IGeoPoint;)V");
			IntPtr native_aPoints = JNIEnv.NewArray (aPoints);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addPoints_arrayLorg_osmdroid_api_IGeoPoint_, new JValue (native_aPoints));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPoints", "([Lorg/osmdroid/api/IGeoPoint;)V"), new JValue (native_aPoints));
			if (aPoints != null) {
				JNIEnv.CopyArray (native_aPoints, aPoints);
				JNIEnv.DeleteLocalRef (native_aPoints);
			}
		}

		static Delegate cb_clearPath;
#pragma warning disable 0169
		static Delegate GetClearPathHandler ()
		{
			if (cb_clearPath == null)
				cb_clearPath = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPath);
			return cb_clearPath;
		}

		static void n_ClearPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPath ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPath;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='clearPath' and count(parameter)=0]"
		[Register ("clearPath", "()V", "GetClearPathHandler")]
		public virtual void ClearPath ()
		{
			if (id_clearPath == IntPtr.Zero)
				id_clearPath = JNIEnv.GetMethodID (class_ref, "clearPath", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clearPath);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPath", "()V"));
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_mapView, bool shadow)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas canvas, global::Osmdroid.Views.MapView mapView, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (canvas), new JValue (mapView), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (canvas), new JValue (mapView), new JValue (shadow));
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int a)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (a);
		}
#pragma warning restore 0169

		static IntPtr id_setAlpha_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public virtual void SetAlpha (int a)
		{
			if (id_setAlpha_I == IntPtr.Zero)
				id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAlpha_I, new JValue (a));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), new JValue (a));
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Osmdroid.Views.Overlay.PathOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.PathOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='PathOverlay']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual void SetColor (int color)
		{
			if (id_setColor_I == IntPtr.Zero)
				id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setColor_I, new JValue (color));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), new JValue (color));
		}

	}
}
