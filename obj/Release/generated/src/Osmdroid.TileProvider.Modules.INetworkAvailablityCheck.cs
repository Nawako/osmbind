using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.Modules {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='INetworkAvailablityCheck']"
	[Register ("org/osmdroid/tileprovider/modules/INetworkAvailablityCheck", "", "Osmdroid.TileProvider.Modules.INetworkAvailablityCheckInvoker")]
	public partial interface INetworkAvailablityCheck : IJavaObject {

		bool CellularDataNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='INetworkAvailablityCheck']/method[@name='getCellularDataNetworkAvailable' and count(parameter)=0]"
			[Register ("getCellularDataNetworkAvailable", "()Z", "GetGetCellularDataNetworkAvailableHandler:Osmdroid.TileProvider.Modules.INetworkAvailablityCheckInvoker, OsmdroidAndroidBinding")] get;
		}

		bool NetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='INetworkAvailablityCheck']/method[@name='getNetworkAvailable' and count(parameter)=0]"
			[Register ("getNetworkAvailable", "()Z", "GetGetNetworkAvailableHandler:Osmdroid.TileProvider.Modules.INetworkAvailablityCheckInvoker, OsmdroidAndroidBinding")] get;
		}

		bool WiFiNetworkAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='INetworkAvailablityCheck']/method[@name='getWiFiNetworkAvailable' and count(parameter)=0]"
			[Register ("getWiFiNetworkAvailable", "()Z", "GetGetWiFiNetworkAvailableHandler:Osmdroid.TileProvider.Modules.INetworkAvailablityCheckInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.modules']/interface[@name='INetworkAvailablityCheck']/method[@name='getRouteToPathExists' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRouteToPathExists", "(I)Z", "GetGetRouteToPathExists_IHandler:Osmdroid.TileProvider.Modules.INetworkAvailablityCheckInvoker, OsmdroidAndroidBinding")]
		bool GetRouteToPathExists (int hostAddress);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/modules/INetworkAvailablityCheck", DoNotGenerateAcw=true)]
	internal class INetworkAvailablityCheckInvoker : global::Java.Lang.Object, INetworkAvailablityCheck {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/modules/INetworkAvailablityCheck");
		IntPtr class_ref;

		public static INetworkAvailablityCheck GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<INetworkAvailablityCheck> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.modules.INetworkAvailablityCheck"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public INetworkAvailablityCheckInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (INetworkAvailablityCheckInvoker); }
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
			global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CellularDataNetworkAvailable;
		}
#pragma warning restore 0169

		IntPtr id_getCellularDataNetworkAvailable;
		public bool CellularDataNetworkAvailable {
			get {
				if (id_getCellularDataNetworkAvailable == IntPtr.Zero)
					id_getCellularDataNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getCellularDataNetworkAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_getCellularDataNetworkAvailable);
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
			global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkAvailable;
		}
#pragma warning restore 0169

		IntPtr id_getNetworkAvailable;
		public bool NetworkAvailable {
			get {
				if (id_getNetworkAvailable == IntPtr.Zero)
					id_getNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getNetworkAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_getNetworkAvailable);
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
			global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WiFiNetworkAvailable;
		}
#pragma warning restore 0169

		IntPtr id_getWiFiNetworkAvailable;
		public bool WiFiNetworkAvailable {
			get {
				if (id_getWiFiNetworkAvailable == IntPtr.Zero)
					id_getWiFiNetworkAvailable = JNIEnv.GetMethodID (class_ref, "getWiFiNetworkAvailable", "()Z");
				return JNIEnv.CallBooleanMethod (Handle, id_getWiFiNetworkAvailable);
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
			global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.INetworkAvailablityCheck> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRouteToPathExists (hostAddress);
		}
#pragma warning restore 0169

		IntPtr id_getRouteToPathExists_I;
		public bool GetRouteToPathExists (int hostAddress)
		{
			if (id_getRouteToPathExists_I == IntPtr.Zero)
				id_getRouteToPathExists_I = JNIEnv.GetMethodID (class_ref, "getRouteToPathExists", "(I)Z");
			return JNIEnv.CallBooleanMethod (Handle, id_getRouteToPathExists_I, new JValue (hostAddress));
		}

	}

}
