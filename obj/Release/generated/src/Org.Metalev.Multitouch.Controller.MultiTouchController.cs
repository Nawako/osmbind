using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Metalev.Multitouch.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']"
	[global::Android.Runtime.Register ("org/metalev/multitouch/controller/MultiTouchController", DoNotGenerateAcw=true)]
	public partial class MultiTouchController : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const bool Debug = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/field[@name='MAX_TOUCH_POINTS']"
		[Register ("MAX_TOUCH_POINTS")]
		public const int MaxTouchPoints = (int) 20;

		static IntPtr multiTouchSupported_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/field[@name='multiTouchSupported']"
		[Register ("multiTouchSupported")]
		public static bool MultiTouchSupported {
			get {
				if (multiTouchSupported_jfieldId == IntPtr.Zero)
					multiTouchSupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "multiTouchSupported", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, multiTouchSupported_jfieldId);
			}
			set {
				if (multiTouchSupported_jfieldId == IntPtr.Zero)
					multiTouchSupported_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "multiTouchSupported", "Z");
				JNIEnv.SetStaticField (class_ref, multiTouchSupported_jfieldId, value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.metalev.multitouch.controller']/interface[@name='MultiTouchController.MultiTouchObjectCanvas']"
		[Register ("org/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas", "", "Org.Metalev.Multitouch.Controller.MultiTouchController/IMultiTouchObjectCanvasInvoker")]
		public partial interface IMultiTouchObjectCanvas : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/interface[@name='MultiTouchController.MultiTouchObjectCanvas']/method[@name='getDraggableObjectAtPoint' and count(parameter)=1 and parameter[1][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
			[Register ("getDraggableObjectAtPoint", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Ljava/lang/Object;", "GetGetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler:Org.Metalev.Multitouch.Controller.MultiTouchController/IMultiTouchObjectCanvasInvoker, OsmdroidAndroidBinding")]
			global::Java.Lang.Object GetDraggableObjectAtPoint (global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/interface[@name='MultiTouchController.MultiTouchObjectCanvas']/method[@name='getPositionAndScale' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PositionAndScale']]"
			[Register ("getPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;)V", "GetGetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Handler:Org.Metalev.Multitouch.Controller.MultiTouchController/IMultiTouchObjectCanvasInvoker, OsmdroidAndroidBinding")]
			void GetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/interface[@name='MultiTouchController.MultiTouchObjectCanvas']/method[@name='selectObject' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
			[Register ("selectObject", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V", "GetSelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler:Org.Metalev.Multitouch.Controller.MultiTouchController/IMultiTouchObjectCanvasInvoker, OsmdroidAndroidBinding")]
			void SelectObject (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/interface[@name='MultiTouchController.MultiTouchObjectCanvas']/method[@name='setPositionAndScale' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.metalev.multitouch.controller.MultiTouchController.PositionAndScale'] and parameter[3][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
			[Register ("setPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Z", "GetSetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler:Org.Metalev.Multitouch.Controller.MultiTouchController/IMultiTouchObjectCanvasInvoker, OsmdroidAndroidBinding")]
			bool SetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale newObjPosAndScale, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint);

		}

		[global::Android.Runtime.Register ("org/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas", DoNotGenerateAcw=true)]
		internal class IMultiTouchObjectCanvasInvoker : global::Java.Lang.Object, IMultiTouchObjectCanvas {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas");
			IntPtr class_ref;

			public static IMultiTouchObjectCanvas GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IMultiTouchObjectCanvas> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.metalev.multitouch.controller.MultiTouchController.MultiTouchObjectCanvas"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IMultiTouchObjectCanvasInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IMultiTouchObjectCanvasInvoker); }
			}

			static Delegate cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
			static Delegate GetGetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
			{
				if (cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
					cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
				return cb_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			}

			static IntPtr n_GetDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_touchPoint)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_touchPoint, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDraggableObjectAtPoint (touchPoint));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			public global::Java.Lang.Object GetDraggableObjectAtPoint (global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
			{
				if (id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
					id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "getDraggableObjectAtPoint", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Ljava/lang/Object;");
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getDraggableObjectAtPoint_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (touchPoint)), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
#pragma warning disable 0169
			static Delegate GetGetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Handler ()
			{
				if (cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ == null)
					cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_);
				return cb_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
			}

			static void n_GetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_objPosAndScaleOut)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (native_objPosAndScaleOut, JniHandleOwnership.DoNotTransfer);
				__this.GetPositionAndScale (obj, objPosAndScaleOut);
			}
#pragma warning restore 0169

			IntPtr id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_;
			public void GetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale objPosAndScaleOut)
			{
				if (id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ == IntPtr.Zero)
					id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_ = JNIEnv.GetMethodID (class_ref, "getPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;)V");
				IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
				JNIEnv.CallVoidMethod (Handle, id_getPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_, new JValue (native_obj), new JValue (objPosAndScaleOut));
				JNIEnv.DeleteLocalRef (native_obj);
			}

			static Delegate cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
			static Delegate GetSelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
			{
				if (cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
					cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
				return cb_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			}

			static void n_SelectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_touchPoint)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_touchPoint, JniHandleOwnership.DoNotTransfer);
				__this.SelectObject (obj, touchPoint);
			}
#pragma warning restore 0169

			IntPtr id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			public void SelectObject (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
			{
				if (id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
					id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "selectObject", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V");
				IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
				JNIEnv.CallVoidMethod (Handle, id_selectObject_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (native_obj), new JValue (touchPoint));
				JNIEnv.DeleteLocalRef (native_obj);
			}

			static Delegate cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
			static Delegate GetSetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
			{
				if (cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
					cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
				return cb_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			}

			static bool n_SetPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj, IntPtr native_newObjPosAndScale, IntPtr native_touchPoint)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale newObjPosAndScale = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (native_newObjPosAndScale, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_touchPoint, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.SetPositionAndScale (obj, newObjPosAndScale, touchPoint);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			public bool SetPositionAndScale (global::Java.Lang.Object obj, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale newObjPosAndScale, global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo touchPoint)
			{
				if (id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
					id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "setPositionAndScale", "(Ljava/lang/Object;Lorg/metalev/multitouch/controller/MultiTouchController$PositionAndScale;Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)Z");
				IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_setPositionAndScale_Ljava_lang_Object_Lorg_metalev_multitouch_controller_MultiTouchController_PositionAndScale_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (native_obj), new JValue (newObjPosAndScale), new JValue (touchPoint));
				JNIEnv.DeleteLocalRef (native_obj);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']"
		[global::Android.Runtime.Register ("org/metalev/multitouch/controller/MultiTouchController$PointInfo", DoNotGenerateAcw=true)]
		public partial class PointInfo : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/metalev/multitouch/controller/MultiTouchController$PointInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PointInfo); }
			}

			protected PointInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/constructor[@name='MultiTouchController.PointInfo' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public PointInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PointInfo)) {
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

			static Delegate cb_getAction;
#pragma warning disable 0169
			static Delegate GetGetActionHandler ()
			{
				if (cb_getAction == null)
					cb_getAction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAction);
				return cb_getAction;
			}

			static int n_GetAction (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Action;
			}
#pragma warning restore 0169

			static IntPtr id_getAction;
			public virtual int Action {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getAction' and count(parameter)=0]"
				[Register ("getAction", "()I", "GetGetActionHandler")]
				get {
					if (id_getAction == IntPtr.Zero)
						id_getAction = JNIEnv.GetMethodID (class_ref, "getAction", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getAction);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAction", "()I"));
				}
			}

			static Delegate cb_getEventTime;
#pragma warning disable 0169
			static Delegate GetGetEventTimeHandler ()
			{
				if (cb_getEventTime == null)
					cb_getEventTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetEventTime);
				return cb_getEventTime;
			}

			static long n_GetEventTime (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.EventTime;
			}
#pragma warning restore 0169

			static IntPtr id_getEventTime;
			public virtual long EventTime {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getEventTime' and count(parameter)=0]"
				[Register ("getEventTime", "()J", "GetGetEventTimeHandler")]
				get {
					if (id_getEventTime == IntPtr.Zero)
						id_getEventTime = JNIEnv.GetMethodID (class_ref, "getEventTime", "()J");

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getEventTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventTime", "()J"));
				}
			}

			static Delegate cb_isDown;
#pragma warning disable 0169
			static Delegate GetIsDownHandler ()
			{
				if (cb_isDown == null)
					cb_isDown = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDown);
				return cb_isDown;
			}

			static bool n_IsDown (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDown;
			}
#pragma warning restore 0169

			static IntPtr id_isDown;
			public virtual bool IsDown {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='isDown' and count(parameter)=0]"
				[Register ("isDown", "()Z", "GetIsDownHandler")]
				get {
					if (id_isDown == IntPtr.Zero)
						id_isDown = JNIEnv.GetMethodID (class_ref, "isDown", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDown);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDown", "()Z"));
				}
			}

			static Delegate cb_isMultiTouch;
#pragma warning disable 0169
			static Delegate GetIsMultiTouchHandler ()
			{
				if (cb_isMultiTouch == null)
					cb_isMultiTouch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMultiTouch);
				return cb_isMultiTouch;
			}

			static bool n_IsMultiTouch (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsMultiTouch;
			}
#pragma warning restore 0169

			static IntPtr id_isMultiTouch;
			public virtual bool IsMultiTouch {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='isMultiTouch' and count(parameter)=0]"
				[Register ("isMultiTouch", "()Z", "GetIsMultiTouchHandler")]
				get {
					if (id_isMultiTouch == IntPtr.Zero)
						id_isMultiTouch = JNIEnv.GetMethodID (class_ref, "isMultiTouch", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isMultiTouch);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMultiTouch", "()Z"));
				}
			}

			static Delegate cb_getMultiTouchAngle;
#pragma warning disable 0169
			static Delegate GetGetMultiTouchAngleHandler ()
			{
				if (cb_getMultiTouchAngle == null)
					cb_getMultiTouchAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiTouchAngle);
				return cb_getMultiTouchAngle;
			}

			static float n_GetMultiTouchAngle (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MultiTouchAngle;
			}
#pragma warning restore 0169

			static IntPtr id_getMultiTouchAngle;
			public virtual float MultiTouchAngle {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getMultiTouchAngle' and count(parameter)=0]"
				[Register ("getMultiTouchAngle", "()F", "GetGetMultiTouchAngleHandler")]
				get {
					if (id_getMultiTouchAngle == IntPtr.Zero)
						id_getMultiTouchAngle = JNIEnv.GetMethodID (class_ref, "getMultiTouchAngle", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMultiTouchAngle);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiTouchAngle", "()F"));
				}
			}

			static Delegate cb_getMultiTouchDiameter;
#pragma warning disable 0169
			static Delegate GetGetMultiTouchDiameterHandler ()
			{
				if (cb_getMultiTouchDiameter == null)
					cb_getMultiTouchDiameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiTouchDiameter);
				return cb_getMultiTouchDiameter;
			}

			static float n_GetMultiTouchDiameter (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MultiTouchDiameter;
			}
#pragma warning restore 0169

			static IntPtr id_getMultiTouchDiameter;
			public virtual float MultiTouchDiameter {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getMultiTouchDiameter' and count(parameter)=0]"
				[Register ("getMultiTouchDiameter", "()F", "GetGetMultiTouchDiameterHandler")]
				get {
					if (id_getMultiTouchDiameter == IntPtr.Zero)
						id_getMultiTouchDiameter = JNIEnv.GetMethodID (class_ref, "getMultiTouchDiameter", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMultiTouchDiameter);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiTouchDiameter", "()F"));
				}
			}

			static Delegate cb_getMultiTouchDiameterSq;
#pragma warning disable 0169
			static Delegate GetGetMultiTouchDiameterSqHandler ()
			{
				if (cb_getMultiTouchDiameterSq == null)
					cb_getMultiTouchDiameterSq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiTouchDiameterSq);
				return cb_getMultiTouchDiameterSq;
			}

			static float n_GetMultiTouchDiameterSq (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MultiTouchDiameterSq;
			}
#pragma warning restore 0169

			static IntPtr id_getMultiTouchDiameterSq;
			public virtual float MultiTouchDiameterSq {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getMultiTouchDiameterSq' and count(parameter)=0]"
				[Register ("getMultiTouchDiameterSq", "()F", "GetGetMultiTouchDiameterSqHandler")]
				get {
					if (id_getMultiTouchDiameterSq == IntPtr.Zero)
						id_getMultiTouchDiameterSq = JNIEnv.GetMethodID (class_ref, "getMultiTouchDiameterSq", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMultiTouchDiameterSq);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiTouchDiameterSq", "()F"));
				}
			}

			static Delegate cb_getMultiTouchHeight;
#pragma warning disable 0169
			static Delegate GetGetMultiTouchHeightHandler ()
			{
				if (cb_getMultiTouchHeight == null)
					cb_getMultiTouchHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiTouchHeight);
				return cb_getMultiTouchHeight;
			}

			static float n_GetMultiTouchHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MultiTouchHeight;
			}
#pragma warning restore 0169

			static IntPtr id_getMultiTouchHeight;
			public virtual float MultiTouchHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getMultiTouchHeight' and count(parameter)=0]"
				[Register ("getMultiTouchHeight", "()F", "GetGetMultiTouchHeightHandler")]
				get {
					if (id_getMultiTouchHeight == IntPtr.Zero)
						id_getMultiTouchHeight = JNIEnv.GetMethodID (class_ref, "getMultiTouchHeight", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMultiTouchHeight);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiTouchHeight", "()F"));
				}
			}

			static Delegate cb_getMultiTouchWidth;
#pragma warning disable 0169
			static Delegate GetGetMultiTouchWidthHandler ()
			{
				if (cb_getMultiTouchWidth == null)
					cb_getMultiTouchWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMultiTouchWidth);
				return cb_getMultiTouchWidth;
			}

			static float n_GetMultiTouchWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MultiTouchWidth;
			}
#pragma warning restore 0169

			static IntPtr id_getMultiTouchWidth;
			public virtual float MultiTouchWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getMultiTouchWidth' and count(parameter)=0]"
				[Register ("getMultiTouchWidth", "()F", "GetGetMultiTouchWidthHandler")]
				get {
					if (id_getMultiTouchWidth == IntPtr.Zero)
						id_getMultiTouchWidth = JNIEnv.GetMethodID (class_ref, "getMultiTouchWidth", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getMultiTouchWidth);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMultiTouchWidth", "()F"));
				}
			}

			static Delegate cb_getNumTouchPoints;
#pragma warning disable 0169
			static Delegate GetGetNumTouchPointsHandler ()
			{
				if (cb_getNumTouchPoints == null)
					cb_getNumTouchPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumTouchPoints);
				return cb_getNumTouchPoints;
			}

			static int n_GetNumTouchPoints (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NumTouchPoints;
			}
#pragma warning restore 0169

			static IntPtr id_getNumTouchPoints;
			public virtual int NumTouchPoints {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getNumTouchPoints' and count(parameter)=0]"
				[Register ("getNumTouchPoints", "()I", "GetGetNumTouchPointsHandler")]
				get {
					if (id_getNumTouchPoints == IntPtr.Zero)
						id_getNumTouchPoints = JNIEnv.GetMethodID (class_ref, "getNumTouchPoints", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNumTouchPoints);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumTouchPoints", "()I"));
				}
			}

			static Delegate cb_getPressure;
#pragma warning disable 0169
			static Delegate GetGetPressureHandler ()
			{
				if (cb_getPressure == null)
					cb_getPressure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPressure);
				return cb_getPressure;
			}

			static float n_GetPressure (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Pressure;
			}
#pragma warning restore 0169

			static IntPtr id_getPressure;
			public virtual float Pressure {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getPressure' and count(parameter)=0]"
				[Register ("getPressure", "()F", "GetGetPressureHandler")]
				get {
					if (id_getPressure == IntPtr.Zero)
						id_getPressure = JNIEnv.GetMethodID (class_ref, "getPressure", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getPressure);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPressure", "()F"));
				}
			}

			static Delegate cb_getPointerIds;
#pragma warning disable 0169
			static Delegate GetGetPointerIdsHandler ()
			{
				if (cb_getPointerIds == null)
					cb_getPointerIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPointerIds);
				return cb_getPointerIds;
			}

			static IntPtr n_GetPointerIds (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetPointerIds ());
			}
#pragma warning restore 0169

			static IntPtr id_getPointerIds;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getPointerIds' and count(parameter)=0]"
			[Register ("getPointerIds", "()[I", "GetGetPointerIdsHandler")]
			public virtual int[] GetPointerIds ()
			{
				if (id_getPointerIds == IntPtr.Zero)
					id_getPointerIds = JNIEnv.GetMethodID (class_ref, "getPointerIds", "()[I");

				if (GetType () == ThresholdType)
					return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPointerIds), JniHandleOwnership.TransferLocalRef, typeof (int));
				else
					return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPointerIds", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
			}

			static Delegate cb_getPressures;
#pragma warning disable 0169
			static Delegate GetGetPressuresHandler ()
			{
				if (cb_getPressures == null)
					cb_getPressures = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPressures);
				return cb_getPressures;
			}

			static IntPtr n_GetPressures (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetPressures ());
			}
#pragma warning restore 0169

			static IntPtr id_getPressures;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getPressures' and count(parameter)=0]"
			[Register ("getPressures", "()[F", "GetGetPressuresHandler")]
			public virtual float[] GetPressures ()
			{
				if (id_getPressures == IntPtr.Zero)
					id_getPressures = JNIEnv.GetMethodID (class_ref, "getPressures", "()[F");

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPressures), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPressures", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			}

			static Delegate cb_getX;
#pragma warning disable 0169
			static Delegate GetGetXHandler ()
			{
				if (cb_getX == null)
					cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
				return cb_getX;
			}

			static float n_GetX (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetX ();
			}
#pragma warning restore 0169

			static IntPtr id_getX;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getX' and count(parameter)=0]"
			[Register ("getX", "()F", "GetGetXHandler")]
			public virtual float GetX ()
			{
				if (id_getX == IntPtr.Zero)
					id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()F"));
			}

			static Delegate cb_getXs;
#pragma warning disable 0169
			static Delegate GetGetXsHandler ()
			{
				if (cb_getXs == null)
					cb_getXs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXs);
				return cb_getXs;
			}

			static IntPtr n_GetXs (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetXs ());
			}
#pragma warning restore 0169

			static IntPtr id_getXs;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getXs' and count(parameter)=0]"
			[Register ("getXs", "()[F", "GetGetXsHandler")]
			public virtual float[] GetXs ()
			{
				if (id_getXs == IntPtr.Zero)
					id_getXs = JNIEnv.GetMethodID (class_ref, "getXs", "()[F");

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getXs), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXs", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			}

			static Delegate cb_getY;
#pragma warning disable 0169
			static Delegate GetGetYHandler ()
			{
				if (cb_getY == null)
					cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
				return cb_getY;
			}

			static float n_GetY (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetY ();
			}
#pragma warning restore 0169

			static IntPtr id_getY;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getY' and count(parameter)=0]"
			[Register ("getY", "()F", "GetGetYHandler")]
			public virtual float GetY ()
			{
				if (id_getY == IntPtr.Zero)
					id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getY);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()F"));
			}

			static Delegate cb_getYs;
#pragma warning disable 0169
			static Delegate GetGetYsHandler ()
			{
				if (cb_getYs == null)
					cb_getYs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYs);
				return cb_getYs;
			}

			static IntPtr n_GetYs (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetYs ());
			}
#pragma warning restore 0169

			static IntPtr id_getYs;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='getYs' and count(parameter)=0]"
			[Register ("getYs", "()[F", "GetGetYsHandler")]
			public virtual float[] GetYs ()
			{
				if (id_getYs == IntPtr.Zero)
					id_getYs = JNIEnv.GetMethodID (class_ref, "getYs", "()[F");

				if (GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getYs), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYs", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			}

			static Delegate cb_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
#pragma warning disable 0169
			static Delegate GetSet_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler ()
			{
				if (cb_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == null)
					cb_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_);
				return cb_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			}

			static void n_Set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo other = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo> (native_other, JniHandleOwnership.DoNotTransfer);
				__this.Set (other);
			}
#pragma warning restore 0169

			static IntPtr id_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PointInfo']/method[@name='set' and count(parameter)=1 and parameter[1][@type='org.metalev.multitouch.controller.MultiTouchController.PointInfo']]"
			[Register ("set", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V", "GetSet_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_Handler")]
			public virtual void Set (global::Org.Metalev.Multitouch.Controller.MultiTouchController.PointInfo other)
			{
				if (id_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ == IntPtr.Zero)
					id_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_ = JNIEnv.GetMethodID (class_ref, "set", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_Lorg_metalev_multitouch_controller_MultiTouchController_PointInfo_, new JValue (other));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Lorg/metalev/multitouch/controller/MultiTouchController$PointInfo;)V"), new JValue (other));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']"
		[global::Android.Runtime.Register ("org/metalev/multitouch/controller/MultiTouchController$PositionAndScale", DoNotGenerateAcw=true)]
		public partial class PositionAndScale : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/metalev/multitouch/controller/MultiTouchController$PositionAndScale", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PositionAndScale); }
			}

			protected PositionAndScale (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/constructor[@name='MultiTouchController.PositionAndScale' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public PositionAndScale () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (PositionAndScale)) {
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

			static Delegate cb_getAngle;
#pragma warning disable 0169
			static Delegate GetGetAngleHandler ()
			{
				if (cb_getAngle == null)
					cb_getAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAngle);
				return cb_getAngle;
			}

			static float n_GetAngle (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Angle;
			}
#pragma warning restore 0169

			static IntPtr id_getAngle;
			public virtual float Angle {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getAngle' and count(parameter)=0]"
				[Register ("getAngle", "()F", "GetGetAngleHandler")]
				get {
					if (id_getAngle == IntPtr.Zero)
						id_getAngle = JNIEnv.GetMethodID (class_ref, "getAngle", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getAngle);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAngle", "()F"));
				}
			}

			static Delegate cb_getScale;
#pragma warning disable 0169
			static Delegate GetGetScaleHandler ()
			{
				if (cb_getScale == null)
					cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
				return cb_getScale;
			}

			static float n_GetScale (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Scale;
			}
#pragma warning restore 0169

			static IntPtr id_getScale;
			public virtual float Scale {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getScale' and count(parameter)=0]"
				[Register ("getScale", "()F", "GetGetScaleHandler")]
				get {
					if (id_getScale == IntPtr.Zero)
						id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getScale);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
				}
			}

			static Delegate cb_getScaleX;
#pragma warning disable 0169
			static Delegate GetGetScaleXHandler ()
			{
				if (cb_getScaleX == null)
					cb_getScaleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleX);
				return cb_getScaleX;
			}

			static float n_GetScaleX (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ScaleX;
			}
#pragma warning restore 0169

			static IntPtr id_getScaleX;
			public virtual float ScaleX {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getScaleX' and count(parameter)=0]"
				[Register ("getScaleX", "()F", "GetGetScaleXHandler")]
				get {
					if (id_getScaleX == IntPtr.Zero)
						id_getScaleX = JNIEnv.GetMethodID (class_ref, "getScaleX", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getScaleX);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleX", "()F"));
				}
			}

			static Delegate cb_getScaleY;
#pragma warning disable 0169
			static Delegate GetGetScaleYHandler ()
			{
				if (cb_getScaleY == null)
					cb_getScaleY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleY);
				return cb_getScaleY;
			}

			static float n_GetScaleY (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ScaleY;
			}
#pragma warning restore 0169

			static IntPtr id_getScaleY;
			public virtual float ScaleY {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getScaleY' and count(parameter)=0]"
				[Register ("getScaleY", "()F", "GetGetScaleYHandler")]
				get {
					if (id_getScaleY == IntPtr.Zero)
						id_getScaleY = JNIEnv.GetMethodID (class_ref, "getScaleY", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getScaleY);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleY", "()F"));
				}
			}

			static Delegate cb_getXOff;
#pragma warning disable 0169
			static Delegate GetGetXOffHandler ()
			{
				if (cb_getXOff == null)
					cb_getXOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXOff);
				return cb_getXOff;
			}

			static float n_GetXOff (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.XOff;
			}
#pragma warning restore 0169

			static IntPtr id_getXOff;
			public virtual float XOff {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getXOff' and count(parameter)=0]"
				[Register ("getXOff", "()F", "GetGetXOffHandler")]
				get {
					if (id_getXOff == IntPtr.Zero)
						id_getXOff = JNIEnv.GetMethodID (class_ref, "getXOff", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getXOff);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getXOff", "()F"));
				}
			}

			static Delegate cb_getYOff;
#pragma warning disable 0169
			static Delegate GetGetYOffHandler ()
			{
				if (cb_getYOff == null)
					cb_getYOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYOff);
				return cb_getYOff;
			}

			static float n_GetYOff (IntPtr jnienv, IntPtr native__this)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.YOff;
			}
#pragma warning restore 0169

			static IntPtr id_getYOff;
			public virtual float YOff {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='getYOff' and count(parameter)=0]"
				[Register ("getYOff", "()F", "GetGetYOffHandler")]
				get {
					if (id_getYOff == IntPtr.Zero)
						id_getYOff = JNIEnv.GetMethodID (class_ref, "getYOff", "()F");

					if (GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod  (Handle, id_getYOff);
					else
						return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getYOff", "()F"));
				}
			}

			static Delegate cb_set_FFZFZFFZF;
#pragma warning disable 0169
			static Delegate GetSet_FFZFZFFZFHandler ()
			{
				if (cb_set_FFZFZFFZF == null)
					cb_set_FFZFZFFZF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, bool, float, bool, float, float, bool, float>) n_Set_FFZFZFFZF);
				return cb_set_FFZFZFFZF;
			}

			static void n_Set_FFZFZFFZF (IntPtr jnienv, IntPtr native__this, float xOff, float yOff, bool updateScale, float scale, bool updateScaleXY, float scaleX, float scaleY, bool updateAngle, float angle)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Set (xOff, yOff, updateScale, scale, updateScaleXY, scaleX, scaleY, updateAngle, angle);
			}
#pragma warning restore 0169

			static IntPtr id_set_FFZFZFFZF;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='set' and count(parameter)=9 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean'] and parameter[4][@type='float'] and parameter[5][@type='boolean'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='boolean'] and parameter[9][@type='float']]"
			[Register ("set", "(FFZFZFFZF)V", "GetSet_FFZFZFFZFHandler")]
			public virtual void Set (float xOff, float yOff, bool updateScale, float scale, bool updateScaleXY, float scaleX, float scaleY, bool updateAngle, float angle)
			{
				if (id_set_FFZFZFFZF == IntPtr.Zero)
					id_set_FFZFZFFZF = JNIEnv.GetMethodID (class_ref, "set", "(FFZFZFFZF)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_FFZFZFFZF, new JValue (xOff), new JValue (yOff), new JValue (updateScale), new JValue (scale), new JValue (updateScaleXY), new JValue (scaleX), new JValue (scaleY), new JValue (updateAngle), new JValue (angle));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(FFZFZFFZF)V"), new JValue (xOff), new JValue (yOff), new JValue (updateScale), new JValue (scale), new JValue (updateScaleXY), new JValue (scaleX), new JValue (scaleY), new JValue (updateAngle), new JValue (angle));
			}

			static Delegate cb_set_FFFFFF;
#pragma warning disable 0169
			static Delegate GetSet_FFFFFFHandler ()
			{
				if (cb_set_FFFFFF == null)
					cb_set_FFFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, float, float>) n_Set_FFFFFF);
				return cb_set_FFFFFF;
			}

			static void n_Set_FFFFFF (IntPtr jnienv, IntPtr native__this, float xOff, float yOff, float scale, float scaleX, float scaleY, float angle)
			{
				global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController.PositionAndScale> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Set (xOff, yOff, scale, scaleX, scaleY, angle);
			}
#pragma warning restore 0169

			static IntPtr id_set_FFFFFF;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController.PositionAndScale']/method[@name='set' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
			[Register ("set", "(FFFFFF)V", "GetSet_FFFFFFHandler")]
			protected virtual void Set (float xOff, float yOff, float scale, float scaleX, float scaleY, float angle)
			{
				if (id_set_FFFFFF == IntPtr.Zero)
					id_set_FFFFFF = JNIEnv.GetMethodID (class_ref, "set", "(FFFFFF)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_set_FFFFFF, new JValue (xOff), new JValue (yOff), new JValue (scale), new JValue (scaleX), new JValue (scaleY), new JValue (angle));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(FFFFFF)V"), new JValue (xOff), new JValue (yOff), new JValue (scale), new JValue (scaleX), new JValue (scaleY), new JValue (angle));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/metalev/multitouch/controller/MultiTouchController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiTouchController); }
		}

		protected MultiTouchController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/constructor[@name='MultiTouchController' and count(parameter)=1 and parameter[1][@type='org.metalev.multitouch.controller.MultiTouchController.MultiTouchObjectCanvas']]"
		[Register (".ctor", "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;)V", "")]
		public MultiTouchController (global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MultiTouchController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_ == IntPtr.Zero)
				id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_, new JValue (p0));
		}

		static IntPtr id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/constructor[@name='MultiTouchController' and count(parameter)=2 and parameter[1][@type='org.metalev.multitouch.controller.MultiTouchController.MultiTouchObjectCanvas'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;Z)V", "")]
		public MultiTouchController (global::Org.Metalev.Multitouch.Controller.MultiTouchController.IMultiTouchObjectCanvas p0, bool p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MultiTouchController)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;Z)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;Z)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_Z == IntPtr.Zero)
				id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/metalev/multitouch/controller/MultiTouchController$MultiTouchObjectCanvas;Z)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_Z, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_metalev_multitouch_controller_MultiTouchController_MultiTouchObjectCanvas_Z, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getHandleSingleTouchEvents;
#pragma warning disable 0169
		static Delegate GetGetHandleSingleTouchEventsHandler ()
		{
			if (cb_getHandleSingleTouchEvents == null)
				cb_getHandleSingleTouchEvents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHandleSingleTouchEvents);
			return cb_getHandleSingleTouchEvents;
		}

		static bool n_GetHandleSingleTouchEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Metalev.Multitouch.Controller.MultiTouchController __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HandleSingleTouchEvents;
		}
#pragma warning restore 0169

		static Delegate cb_setHandleSingleTouchEvents_Z;
#pragma warning disable 0169
		static Delegate GetSetHandleSingleTouchEvents_ZHandler ()
		{
			if (cb_setHandleSingleTouchEvents_Z == null)
				cb_setHandleSingleTouchEvents_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHandleSingleTouchEvents_Z);
			return cb_setHandleSingleTouchEvents_Z;
		}

		static void n_SetHandleSingleTouchEvents_Z (IntPtr jnienv, IntPtr native__this, bool handleSingleTouchEvents)
		{
			global::Org.Metalev.Multitouch.Controller.MultiTouchController __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleSingleTouchEvents = handleSingleTouchEvents;
		}
#pragma warning restore 0169

		static IntPtr id_getHandleSingleTouchEvents;
		static IntPtr id_setHandleSingleTouchEvents_Z;
		protected virtual bool HandleSingleTouchEvents {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/method[@name='getHandleSingleTouchEvents' and count(parameter)=0]"
			[Register ("getHandleSingleTouchEvents", "()Z", "GetGetHandleSingleTouchEventsHandler")]
			get {
				if (id_getHandleSingleTouchEvents == IntPtr.Zero)
					id_getHandleSingleTouchEvents = JNIEnv.GetMethodID (class_ref, "getHandleSingleTouchEvents", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getHandleSingleTouchEvents);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHandleSingleTouchEvents", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/method[@name='setHandleSingleTouchEvents' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHandleSingleTouchEvents", "(Z)V", "GetSetHandleSingleTouchEvents_ZHandler")]
			set {
				if (id_setHandleSingleTouchEvents_Z == IntPtr.Zero)
					id_setHandleSingleTouchEvents_Z = JNIEnv.GetMethodID (class_ref, "setHandleSingleTouchEvents", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setHandleSingleTouchEvents_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandleSingleTouchEvents", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_isPinching;
#pragma warning disable 0169
		static Delegate GetIsPinchingHandler ()
		{
			if (cb_isPinching == null)
				cb_isPinching = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPinching);
			return cb_isPinching;
		}

		static bool n_IsPinching (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Metalev.Multitouch.Controller.MultiTouchController __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPinching;
		}
#pragma warning restore 0169

		static IntPtr id_isPinching;
		public virtual bool IsPinching {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/method[@name='isPinching' and count(parameter)=0]"
			[Register ("isPinching", "()Z", "GetIsPinchingHandler")]
			get {
				if (id_isPinching == IntPtr.Zero)
					id_isPinching = JNIEnv.GetMethodID (class_ref, "isPinching", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isPinching);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPinching", "()Z"));
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Org.Metalev.Multitouch.Controller.MultiTouchController __this = global::Java.Lang.Object.GetObject<global::Org.Metalev.Multitouch.Controller.MultiTouchController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.metalev.multitouch.controller']/class[@name='MultiTouchController']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual bool OnTouchEvent (global::Android.Views.MotionEvent e)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onTouchEvent_Landroid_view_MotionEvent_, new JValue (e));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouchEvent", "(Landroid/view/MotionEvent;)Z"), new JValue (e));
			return __ret;
		}

	}
}
