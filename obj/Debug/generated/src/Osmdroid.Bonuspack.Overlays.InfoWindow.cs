using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/InfoWindow", DoNotGenerateAcw=true)]
	public abstract partial class InfoWindow : global::Java.Lang.Object {


		static IntPtr mIsVisible_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/field[@name='mIsVisible']"
		[Register ("mIsVisible")]
		protected bool MIsVisible {
			get {
				if (mIsVisible_jfieldId == IntPtr.Zero)
					mIsVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsVisible", "Z");
				return JNIEnv.GetBooleanField (Handle, mIsVisible_jfieldId);
			}
			set {
				if (mIsVisible_jfieldId == IntPtr.Zero)
					mIsVisible_jfieldId = JNIEnv.GetFieldID (class_ref, "mIsVisible", "Z");
				JNIEnv.SetField (Handle, mIsVisible_jfieldId, value);
			}
		}

		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/field[@name='mMapView']"
		[Register ("mMapView")]
		protected global::Osmdroid.Views.MapView MMapView {
			get {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMapView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMapView_jfieldId == IntPtr.Zero)
					mMapView_jfieldId = JNIEnv.GetFieldID (class_ref, "mMapView", "Lorg/osmdroid/views/MapView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMapView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/field[@name='mView']"
		[Register ("mView")]
		protected global::Android.Views.View MView {
			get {
				if (mView_jfieldId == IntPtr.Zero)
					mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Landroid/view/View;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mView_jfieldId == IntPtr.Zero)
					mView_jfieldId = JNIEnv.GetFieldID (class_ref, "mView", "Landroid/view/View;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mView_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/InfoWindow", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InfoWindow); }
		}

		protected InfoWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/constructor[@name='InfoWindow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(ILorg/osmdroid/views/MapView;)V", "")]
		public InfoWindow (int p0, global::Osmdroid.Views.MapView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (InfoWindow)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_ILorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_ILorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_isOpen;
#pragma warning disable 0169
		static Delegate GetIsOpenHandler ()
		{
			if (cb_isOpen == null)
				cb_isOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOpen);
			return cb_isOpen;
		}

		static bool n_IsOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOpen;
		}
#pragma warning restore 0169

		static IntPtr id_isOpen;
		public virtual bool IsOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='isOpen' and count(parameter)=0]"
			[Register ("isOpen", "()Z", "GetIsOpenHandler")]
			get {
				if (id_isOpen == IntPtr.Zero)
					id_isOpen = JNIEnv.GetMethodID (class_ref, "isOpen", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isOpen);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOpen", "()Z"));
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Landroid/view/View;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod  (Handle, id_getView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static IntPtr id_closeAllInfoWindowsOn_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='closeAllInfoWindowsOn' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("closeAllInfoWindowsOn", "(Lorg/osmdroid/views/MapView;)V", "")]
		public static void CloseAllInfoWindowsOn (global::Osmdroid.Views.MapView p0)
		{
			if (id_closeAllInfoWindowsOn_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_closeAllInfoWindowsOn_Lorg_osmdroid_views_MapView_ = JNIEnv.GetStaticMethodID (class_ref, "closeAllInfoWindowsOn", "(Lorg/osmdroid/views/MapView;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_closeAllInfoWindowsOn_Lorg_osmdroid_views_MapView_, new JValue (p0));
		}

		static IntPtr id_getOpenedInfoWindowsOn_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='getOpenedInfoWindowsOn' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("getOpenedInfoWindowsOn", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;", "")]
		public static global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Overlays.InfoWindow> GetOpenedInfoWindowsOn (global::Osmdroid.Views.MapView p0)
		{
			if (id_getOpenedInfoWindowsOn_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_getOpenedInfoWindowsOn_Lorg_osmdroid_views_MapView_ = JNIEnv.GetStaticMethodID (class_ref, "getOpenedInfoWindowsOn", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;");
			global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Overlays.InfoWindow> __ret = global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Overlays.InfoWindow>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getOpenedInfoWindowsOn_Lorg_osmdroid_views_MapView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_onClose;
#pragma warning disable 0169
		static Delegate GetOnCloseHandler ()
		{
			if (cb_onClose == null)
				cb_onClose = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnClose);
			return cb_onClose;
		}

		static void n_OnClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='onClose' and count(parameter)=0]"
		[Register ("onClose", "()V", "GetOnCloseHandler")]
		public abstract void OnClose ();

		static Delegate cb_onOpen_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnOpen_Ljava_lang_Object_Handler ()
		{
			if (cb_onOpen_Ljava_lang_Object_ == null)
				cb_onOpen_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnOpen_Ljava_lang_Object_);
			return cb_onOpen_Ljava_lang_Object_;
		}

		static void n_OnOpen_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onOpen", "(Ljava/lang/Object;)V", "GetOnOpen_Ljava_lang_Object_Handler")]
		public abstract void OnOpen (global::Java.Lang.Object p0);

		static Delegate cb_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II;
#pragma warning disable 0169
		static Delegate GetOpen_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_IIHandler ()
		{
			if (cb_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II == null)
				cb_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_Open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II);
			return cb_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II;
		}

		static void n_Open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			global::Osmdroid.Bonuspack.Overlays.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p1 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Open (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='open' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.osmdroid.util.GeoPoint'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("open", "(Ljava/lang/Object;Lorg/osmdroid/util/GeoPoint;II)V", "GetOpen_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_IIHandler")]
		public virtual void Open (global::Java.Lang.Object p0, global::Org.Osmdroid.Util.GeoPoint p1, int p2, int p3)
		{
			if (id_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II == IntPtr.Zero)
				id_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II = JNIEnv.GetMethodID (class_ref, "open", "(Ljava/lang/Object;Lorg/osmdroid/util/GeoPoint;II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_open_Ljava_lang_Object_Lorg_osmdroid_util_GeoPoint_II, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "open", "(Ljava/lang/Object;Lorg/osmdroid/util/GeoPoint;II)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/InfoWindow", DoNotGenerateAcw=true)]
	internal partial class InfoWindowInvoker : InfoWindow {

		public InfoWindowInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (InfoWindowInvoker); }
		}

		static IntPtr id_onClose;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='onClose' and count(parameter)=0]"
		[Register ("onClose", "()V", "GetOnCloseHandler")]
		public override void OnClose ()
		{
			if (id_onClose == IntPtr.Zero)
				id_onClose = JNIEnv.GetMethodID (class_ref, "onClose", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_onClose);
		}

		static IntPtr id_onOpen_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='InfoWindow']/method[@name='onOpen' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onOpen", "(Ljava/lang/Object;)V", "GetOnOpen_Ljava_lang_Object_Handler")]
		public override void OnOpen (global::Java.Lang.Object p0)
		{
			if (id_onOpen_Ljava_lang_Object_ == IntPtr.Zero)
				id_onOpen_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onOpen", "(Ljava/lang/Object;)V");
			JNIEnv.CallVoidMethod  (Handle, id_onOpen_Ljava_lang_Object_, new JValue (p0));
		}

	}

}
