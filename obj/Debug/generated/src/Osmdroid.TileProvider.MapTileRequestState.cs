using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileRequestState", DoNotGenerateAcw=true)]
	public partial class MapTileRequestState : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileRequestState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileRequestState); }
		}

		protected MapTileRequestState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_MapTile_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Lorg_osmdroid_tileprovider_IMapTileProviderCallback_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/constructor[@name='MapTileRequestState' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.MapTile'] and parameter[2][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase[]'] and parameter[3][@type='org.osmdroid.tileprovider.IMapTileProviderCallback']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/MapTile;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Lorg/osmdroid/tileprovider/IMapTileProviderCallback;)V", "")]
		public MapTileRequestState (global::Osmdroid.TileProvider.MapTile mapTile, global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase[] providers, global::Osmdroid.TileProvider.IMapTileProviderCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_providers = JNIEnv.NewArray (providers);;
			if (GetType () != typeof (MapTileRequestState)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/MapTile;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Lorg/osmdroid/tileprovider/IMapTileProviderCallback;)V", new JValue (mapTile), new JValue (native_providers), new JValue (@callback)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/MapTile;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Lorg/osmdroid/tileprovider/IMapTileProviderCallback;)V", new JValue (mapTile), new JValue (native_providers), new JValue (@callback));
				if (providers != null) {
					JNIEnv.CopyArray (native_providers, providers);
					JNIEnv.DeleteLocalRef (native_providers);
				}
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_MapTile_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Lorg_osmdroid_tileprovider_IMapTileProviderCallback_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_MapTile_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Lorg_osmdroid_tileprovider_IMapTileProviderCallback_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/MapTile;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;Lorg/osmdroid/tileprovider/IMapTileProviderCallback;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTile_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Lorg_osmdroid_tileprovider_IMapTileProviderCallback_, new JValue (mapTile), new JValue (native_providers), new JValue (@callback)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_MapTile_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Lorg_osmdroid_tileprovider_IMapTileProviderCallback_, new JValue (mapTile), new JValue (native_providers), new JValue (@callback));
			if (providers != null) {
				JNIEnv.CopyArray (native_providers, providers);
				JNIEnv.DeleteLocalRef (native_providers);
			}
		}

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileRequestState __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCallback;
		public virtual global::Osmdroid.TileProvider.IMapTileProviderCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lorg/osmdroid/tileprovider/IMapTileProviderCallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lorg/osmdroid/tileprovider/IMapTileProviderCallback;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (JNIEnv.CallObjectMethod  (Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallback", "()Lorg/osmdroid/tileprovider/IMapTileProviderCallback;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentProvider;
#pragma warning disable 0169
		static Delegate GetGetCurrentProviderHandler ()
		{
			if (cb_getCurrentProvider == null)
				cb_getCurrentProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentProvider);
			return cb_getCurrentProvider;
		}

		static IntPtr n_GetCurrentProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileRequestState __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentProvider;
		public virtual global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase CurrentProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/method[@name='getCurrentProvider' and count(parameter)=0]"
			[Register ("getCurrentProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;", "GetGetCurrentProviderHandler")]
			get {
				if (id_getCurrentProvider == IntPtr.Zero)
					id_getCurrentProvider = JNIEnv.GetMethodID (class_ref, "getCurrentProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallObjectMethod  (Handle, id_getCurrentProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileRequestState __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isEmpty);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
			}
		}

		static Delegate cb_getMapTile;
#pragma warning disable 0169
		static Delegate GetGetMapTileHandler ()
		{
			if (cb_getMapTile == null)
				cb_getMapTile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapTile);
			return cb_getMapTile;
		}

		static IntPtr n_GetMapTile (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileRequestState __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapTile);
		}
#pragma warning restore 0169

		static IntPtr id_getMapTile;
		public virtual global::Osmdroid.TileProvider.MapTile MapTile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/method[@name='getMapTile' and count(parameter)=0]"
			[Register ("getMapTile", "()Lorg/osmdroid/tileprovider/MapTile;", "GetGetMapTileHandler")]
			get {
				if (id_getMapTile == IntPtr.Zero)
					id_getMapTile = JNIEnv.GetMethodID (class_ref, "getMapTile", "()Lorg/osmdroid/tileprovider/MapTile;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (JNIEnv.CallObjectMethod  (Handle, id_getMapTile), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapTile", "()Lorg/osmdroid/tileprovider/MapTile;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getNextProvider;
#pragma warning disable 0169
		static Delegate GetGetNextProviderHandler ()
		{
			if (cb_getNextProvider == null)
				cb_getNextProvider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextProvider);
			return cb_getNextProvider;
		}

		static IntPtr n_GetNextProvider (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileRequestState __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextProvider);
		}
#pragma warning restore 0169

		static IntPtr id_getNextProvider;
		public virtual global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase NextProvider {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileRequestState']/method[@name='getNextProvider' and count(parameter)=0]"
			[Register ("getNextProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;", "GetGetNextProviderHandler")]
			get {
				if (id_getNextProvider == IntPtr.Zero)
					id_getNextProvider = JNIEnv.GetMethodID (class_ref, "getNextProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallObjectMethod  (Handle, id_getNextProvider), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextProvider", "()Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;")), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
