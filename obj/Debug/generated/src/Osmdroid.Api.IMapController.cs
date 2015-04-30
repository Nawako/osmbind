using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']"
	[Register ("org/osmdroid/api/IMapController", "", "Osmdroid.Api.IMapControllerInvoker")]
	public partial interface IMapController : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='animateTo' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("animateTo", "(Lorg/osmdroid/api/IGeoPoint;)V", "GetAnimateTo_Lorg_osmdroid_api_IGeoPoint_Handler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void AnimateTo (global::Osmdroid.Api.IGeoPoint geoPoint);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollBy", "(II)V", "GetScrollBy_IIHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void ScrollBy (int x, int y);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='org.osmdroid.api.IGeoPoint']]"
		[Register ("setCenter", "(Lorg/osmdroid/api/IGeoPoint;)V", "GetSetCenter_Lorg_osmdroid_api_IGeoPoint_Handler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void SetCenter (global::Osmdroid.Api.IGeoPoint point);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoom", "(I)I", "GetSetZoom_IHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		int SetZoom (int zoomLevel);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='stopAnimation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("stopAnimation", "(Z)V", "GetStopAnimation_ZHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void StopAnimation (bool jumpToFinish);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='stopPanning' and count(parameter)=0]"
		[Register ("stopPanning", "()V", "GetStopPanningHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void StopPanning ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Z", "GetZoomInHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		bool ZoomIn ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='zoomInFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomInFixing", "(II)Z", "GetZoomInFixing_IIHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		bool ZoomInFixing (int xPixel, int yPixel);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Z", "GetZoomOutHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		bool ZoomOut ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='zoomOutFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomOutFixing", "(II)Z", "GetZoomOutFixing_IIHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		bool ZoomOutFixing (int xPixel, int yPixel);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IMapController']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("zoomToSpan", "(II)V", "GetZoomToSpan_IIHandler:Osmdroid.Api.IMapControllerInvoker, OsmdroidAndroidBinding")]
		void ZoomToSpan (int latSpanE6, int lonSpanE6);

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IMapController", DoNotGenerateAcw=true)]
	internal class IMapControllerInvoker : global::Java.Lang.Object, IMapController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IMapController");
		IntPtr class_ref;

		public static IMapController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IMapController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapControllerInvoker); }
		}

		static Delegate cb_animateTo_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_animateTo_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_animateTo_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lorg_osmdroid_api_IGeoPoint_);
			return cb_animateTo_Lorg_osmdroid_api_IGeoPoint_;
		}

		static void n_AnimateTo_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_geoPoint)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint geoPoint = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_geoPoint, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (geoPoint);
		}
#pragma warning restore 0169

		IntPtr id_animateTo_Lorg_osmdroid_api_IGeoPoint_;
		public void AnimateTo (global::Osmdroid.Api.IGeoPoint geoPoint)
		{
			if (id_animateTo_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_animateTo_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "animateTo", "(Lorg/osmdroid/api/IGeoPoint;)V");
			JNIEnv.CallVoidMethod (Handle, id_animateTo_Lorg_osmdroid_api_IGeoPoint_, new JValue (geoPoint));
		}

		static Delegate cb_scrollBy_II;
#pragma warning disable 0169
		static Delegate GetScrollBy_IIHandler ()
		{
			if (cb_scrollBy_II == null)
				cb_scrollBy_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ScrollBy_II);
			return cb_scrollBy_II;
		}

		static void n_ScrollBy_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (x, y);
		}
#pragma warning restore 0169

		IntPtr id_scrollBy_II;
		public void ScrollBy (int x, int y)
		{
			if (id_scrollBy_II == IntPtr.Zero)
				id_scrollBy_II = JNIEnv.GetMethodID (class_ref, "scrollBy", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_scrollBy_II, new JValue (x), new JValue (y));
		}

		static Delegate cb_setCenter_Lorg_osmdroid_api_IGeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lorg_osmdroid_api_IGeoPoint_Handler ()
		{
			if (cb_setCenter_Lorg_osmdroid_api_IGeoPoint_ == null)
				cb_setCenter_Lorg_osmdroid_api_IGeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lorg_osmdroid_api_IGeoPoint_);
			return cb_setCenter_Lorg_osmdroid_api_IGeoPoint_;
		}

		static void n_SetCenter_Lorg_osmdroid_api_IGeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_point)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint point = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (point);
		}
#pragma warning restore 0169

		IntPtr id_setCenter_Lorg_osmdroid_api_IGeoPoint_;
		public void SetCenter (global::Osmdroid.Api.IGeoPoint point)
		{
			if (id_setCenter_Lorg_osmdroid_api_IGeoPoint_ == IntPtr.Zero)
				id_setCenter_Lorg_osmdroid_api_IGeoPoint_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Lorg/osmdroid/api/IGeoPoint;)V");
			JNIEnv.CallVoidMethod (Handle, id_setCenter_Lorg_osmdroid_api_IGeoPoint_, new JValue (point));
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static int n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int zoomLevel)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetZoom (zoomLevel);
		}
#pragma warning restore 0169

		IntPtr id_setZoom_I;
		public int SetZoom (int zoomLevel)
		{
			if (id_setZoom_I == IntPtr.Zero)
				id_setZoom_I = JNIEnv.GetMethodID (class_ref, "setZoom", "(I)I");
			return JNIEnv.CallIntMethod (Handle, id_setZoom_I, new JValue (zoomLevel));
		}

		static Delegate cb_stopAnimation_Z;
#pragma warning disable 0169
		static Delegate GetStopAnimation_ZHandler ()
		{
			if (cb_stopAnimation_Z == null)
				cb_stopAnimation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_StopAnimation_Z);
			return cb_stopAnimation_Z;
		}

		static void n_StopAnimation_Z (IntPtr jnienv, IntPtr native__this, bool jumpToFinish)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation (jumpToFinish);
		}
#pragma warning restore 0169

		IntPtr id_stopAnimation_Z;
		public void StopAnimation (bool jumpToFinish)
		{
			if (id_stopAnimation_Z == IntPtr.Zero)
				id_stopAnimation_Z = JNIEnv.GetMethodID (class_ref, "stopAnimation", "(Z)V");
			JNIEnv.CallVoidMethod (Handle, id_stopAnimation_Z, new JValue (jumpToFinish));
		}

		static Delegate cb_stopPanning;
#pragma warning disable 0169
		static Delegate GetStopPanningHandler ()
		{
			if (cb_stopPanning == null)
				cb_stopPanning = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPanning);
			return cb_stopPanning;
		}

		static void n_StopPanning (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPanning ();
		}
#pragma warning restore 0169

		IntPtr id_stopPanning;
		public void StopPanning ()
		{
			if (id_stopPanning == IntPtr.Zero)
				id_stopPanning = JNIEnv.GetMethodID (class_ref, "stopPanning", "()V");
			JNIEnv.CallVoidMethod (Handle, id_stopPanning);
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomIn);
			return cb_zoomIn;
		}

		static bool n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomIn ();
		}
#pragma warning restore 0169

		IntPtr id_zoomIn;
		public bool ZoomIn ()
		{
			if (id_zoomIn == IntPtr.Zero)
				id_zoomIn = JNIEnv.GetMethodID (class_ref, "zoomIn", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomIn);
		}

		static Delegate cb_zoomInFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomInFixing_IIHandler ()
		{
			if (cb_zoomInFixing_II == null)
				cb_zoomInFixing_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_ZoomInFixing_II);
			return cb_zoomInFixing_II;
		}

		static bool n_ZoomInFixing_II (IntPtr jnienv, IntPtr native__this, int xPixel, int yPixel)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomInFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		IntPtr id_zoomInFixing_II;
		public bool ZoomInFixing (int xPixel, int yPixel)
		{
			if (id_zoomInFixing_II == IntPtr.Zero)
				id_zoomInFixing_II = JNIEnv.GetMethodID (class_ref, "zoomInFixing", "(II)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomInFixing_II, new JValue (xPixel), new JValue (yPixel));
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ZoomOut);
			return cb_zoomOut;
		}

		static bool n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOut ();
		}
#pragma warning restore 0169

		IntPtr id_zoomOut;
		public bool ZoomOut ()
		{
			if (id_zoomOut == IntPtr.Zero)
				id_zoomOut = JNIEnv.GetMethodID (class_ref, "zoomOut", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomOut);
		}

		static Delegate cb_zoomOutFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomOutFixing_IIHandler ()
		{
			if (cb_zoomOutFixing_II == null)
				cb_zoomOutFixing_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_ZoomOutFixing_II);
			return cb_zoomOutFixing_II;
		}

		static bool n_ZoomOutFixing_II (IntPtr jnienv, IntPtr native__this, int xPixel, int yPixel)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomOutFixing (xPixel, yPixel);
		}
#pragma warning restore 0169

		IntPtr id_zoomOutFixing_II;
		public bool ZoomOutFixing (int xPixel, int yPixel)
		{
			if (id_zoomOutFixing_II == IntPtr.Zero)
				id_zoomOutFixing_II = JNIEnv.GetMethodID (class_ref, "zoomOutFixing", "(II)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_zoomOutFixing_II, new JValue (xPixel), new JValue (yPixel));
		}

		static Delegate cb_zoomToSpan_II;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_IIHandler ()
		{
			if (cb_zoomToSpan_II == null)
				cb_zoomToSpan_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomToSpan_II);
			return cb_zoomToSpan_II;
		}

		static void n_ZoomToSpan_II (IntPtr jnienv, IntPtr native__this, int latSpanE6, int lonSpanE6)
		{
			global::Osmdroid.Api.IMapController __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (latSpanE6, lonSpanE6);
		}
#pragma warning restore 0169

		IntPtr id_zoomToSpan_II;
		public void ZoomToSpan (int latSpanE6, int lonSpanE6)
		{
			if (id_zoomToSpan_II == IntPtr.Zero)
				id_zoomToSpan_II = JNIEnv.GetMethodID (class_ref, "zoomToSpan", "(II)V");
			JNIEnv.CallVoidMethod (Handle, id_zoomToSpan_II, new JValue (latSpanE6), new JValue (lonSpanE6));
		}

	}

}
