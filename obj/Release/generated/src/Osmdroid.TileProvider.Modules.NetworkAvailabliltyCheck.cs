using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/NetworkAvailabliltyCheck", DoNotGenerateAcw=true)]
	public partial class NetworkAvailabliltyCheck : global::Java.Lang.Object, global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/NetworkAvailabliltyCheck", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkAvailabliltyCheck); }
		}

		protected NetworkAvailabliltyCheck (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']/constructor[@name='NetworkAvailabliltyCheck' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public NetworkAvailabliltyCheck (global::Android.Content.Context aContext) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NetworkAvailabliltyCheck)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (aContext)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (aContext));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (aContext)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (aContext));
		}

		static Delegate cb_getCellularDataNetworkAvailable;
#pragma warning disable 0169
		static Delegate GetGetCellularDataNetworkAvailableHandler ()
		{
			if (cb_getCellularDataNetworkAvailable == null)
				cb_getCellularDataNetworkAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetCellularDataNetworkAvailable);
			return cb_getCellularDataNetworkAvailable;
		}

		static bool n_GetCellularDataNetworkAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CellularDataNetworkAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_getCellularDataNetworkAvailable;
		public virtual bool CellularDataNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']/method[@name='getCellularDataNetworkAvailable' and count(parameter)=0]"
			[Register ("getCellularDataNetworkAvailable", "()Z", "GetGetCellularDataNetworkAvailableHandler")]
			get {
				if (id_getCellularDataNetworkAvailable == IntPtr.Zero)
					id_getCellularDataNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getCellularDataNetworkAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getCellularDataNetworkAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCellularDataNetworkAvailable", "()Z"));
			}
		}

		static Delegate cb_getNetworkAvailable;
#pragma warning disable 0169
		static Delegate GetGetNetworkAvailableHandler ()
		{
			if (cb_getNetworkAvailable == null)
				cb_getNetworkAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNetworkAvailable);
			return cb_getNetworkAvailable;
		}

		static bool n_GetNetworkAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkAvailable;
		public virtual bool NetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']/method[@name='getNetworkAvailable' and count(parameter)=0]"
			[Register ("getNetworkAvailable", "()Z", "GetGetNetworkAvailableHandler")]
			get {
				if (id_getNetworkAvailable == IntPtr.Zero)
					id_getNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getNetworkAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getNetworkAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkAvailable", "()Z"));
			}
		}

		static Delegate cb_getWiFiNetworkAvailable;
#pragma warning disable 0169
		static Delegate GetGetWiFiNetworkAvailableHandler ()
		{
			if (cb_getWiFiNetworkAvailable == null)
				cb_getWiFiNetworkAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWiFiNetworkAvailable);
			return cb_getWiFiNetworkAvailable;
		}

		static bool n_GetWiFiNetworkAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WiFiNetworkAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_getWiFiNetworkAvailable;
		public virtual bool WiFiNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']/method[@name='getWiFiNetworkAvailable' and count(parameter)=0]"
			[Register ("getWiFiNetworkAvailable", "()Z", "GetGetWiFiNetworkAvailableHandler")]
			get {
				if (id_getWiFiNetworkAvailable == IntPtr.Zero)
					id_getWiFiNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getWiFiNetworkAvailable", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_getWiFiNetworkAvailable);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWiFiNetworkAvailable", "()Z"));
			}
		}

		static Delegate cb_getRouteToPathExists_I;
#pragma warning disable 0169
		static Delegate GetGetRouteToPathExists_IHandler ()
		{
			if (cb_getRouteToPathExists_I == null)
				cb_getRouteToPathExists_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_GetRouteToPathExists_I);
			return cb_getRouteToPathExists_I;
		}

		static bool n_GetRouteToPathExists_I (IntPtr jnienv, IntPtr native__this, int hostAddress)
		{
			global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRouteToPathExists (hostAddress);
		}
#pragma warning restore 0169

		static IntPtr id_getRouteToPathExists_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/class[@name='NetworkAvailabliltyCheck']/method[@name='getRouteToPathExists' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRouteToPathExists", "(I)Z", "GetGetRouteToPathExists_IHandler")]
		public virtual bool GetRouteToPathExists (int hostAddress)
		{
			if (id_getRouteToPathExists_I == IntPtr.Zero)
				id_getRouteToPathExists_I = JNIEnv.GetMethodID (class_ref, "getRouteToPathExists", "(I)Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_getRouteToPathExists_I, new JValue (hostAddress));
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRouteToPathExists", "(I)Z"), new JValue (hostAddress));
		}

	}
}
