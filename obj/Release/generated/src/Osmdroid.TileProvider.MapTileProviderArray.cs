using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']"
	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/MapTileProviderArray", DoNotGenerateAcw=true)]
	public partial class MapTileProviderArray : global::Osmdroid.TileProvider.MapTileProviderBase {


		static IntPtr mTileProviderList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/field[@name='mTileProviderList']"
		[Register ("mTileProviderList")]
		protected global::System.Collections.IList MTileProviderList {
			get {
				if (mTileProviderList_jfieldId == IntPtr.Zero)
					mTileProviderList_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileProviderList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTileProviderList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTileProviderList_jfieldId == IntPtr.Zero)
					mTileProviderList_jfieldId = JNIEnv.GetFieldID (class_ref, "mTileProviderList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTileProviderList_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mWorking_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/field[@name='mWorking']"
		[Register ("mWorking")]
		protected global::System.Collections.IDictionary MWorking {
			get {
				if (mWorking_jfieldId == IntPtr.Zero)
					mWorking_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorking", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mWorking_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWorking_jfieldId == IntPtr.Zero)
					mWorking_jfieldId = JNIEnv.GetFieldID (class_ref, "mWorking", "Ljava/util/HashMap;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mWorking_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/tileprovider/MapTileProviderArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTileProviderArray); }
		}

		protected MapTileProviderArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/constructor[@name='MapTileProviderArray' and count(parameter)=3 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='org.osmdroid.tileprovider.IRegisterReceiver'] and parameter[3][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase[]']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V", "")]
		public MapTileProviderArray (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, global::Osmdroid.TileProvider.IRegisterReceiver aRegisterReceiver, global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase[] pTileProviderArray) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_pTileProviderArray = JNIEnv.NewArray (pTileProviderArray);;
			if (GetType () != typeof (MapTileProviderArray)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V", new JValue (pTileSource), new JValue (aRegisterReceiver), new JValue (native_pTileProviderArray)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V", new JValue (pTileSource), new JValue (aRegisterReceiver), new JValue (native_pTileProviderArray));
				if (pTileProviderArray != null) {
					JNIEnv.CopyArray (native_pTileProviderArray, pTileProviderArray);
					JNIEnv.DeleteLocalRef (native_pTileProviderArray);
				}
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;[Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_, new JValue (pTileSource), new JValue (aRegisterReceiver), new JValue (native_pTileProviderArray)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_arrayLorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_, new JValue (pTileSource), new JValue (aRegisterReceiver), new JValue (native_pTileProviderArray));
			if (pTileProviderArray != null) {
				JNIEnv.CopyArray (native_pTileProviderArray, pTileProviderArray);
				JNIEnv.DeleteLocalRef (native_pTileProviderArray);
			}
		}

		static IntPtr id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/constructor[@name='MapTileProviderArray' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.tilesource.ITileSource'] and parameter[2][@type='org.osmdroid.tileprovider.IRegisterReceiver']]"
		[Register (".ctor", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", "")]
		protected MapTileProviderArray (global::Osmdroid.TileProvider.TileSource.ITileSource pTileSource, global::Osmdroid.TileProvider.IRegisterReceiver pRegisterReceiver) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MapTileProviderArray)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", new JValue (pTileSource), new JValue (pRegisterReceiver)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;)V", new JValue (pTileSource), new JValue (pRegisterReceiver));
				return;
			}

			if (id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/tileprovider/tilesource/ITileSource;Lorg/osmdroid/tileprovider/IRegisterReceiver;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_, new JValue (pTileSource), new JValue (pRegisterReceiver)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_tileprovider_tilesource_ITileSource_Lorg_osmdroid_tileprovider_IRegisterReceiver_, new JValue (pTileSource), new JValue (pRegisterReceiver));
		}

		static Delegate cb_getMaximumZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaximumZoomLevelHandler ()
		{
			if (cb_getMaximumZoomLevel == null)
				cb_getMaximumZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumZoomLevel);
			return cb_getMaximumZoomLevel;
		}

		static int n_GetMaximumZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumZoomLevel;
		public override int MaximumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='getMaximumZoomLevel' and count(parameter)=0]"
			[Register ("getMaximumZoomLevel", "()I", "GetGetMaximumZoomLevelHandler")]
			get {
				if (id_getMaximumZoomLevel == IntPtr.Zero)
					id_getMaximumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMaximumZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMaximumZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumZoomLevel", "()I"));
			}
		}

		static Delegate cb_getMinimumZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinimumZoomLevelHandler ()
		{
			if (cb_getMinimumZoomLevel == null)
				cb_getMinimumZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinimumZoomLevel);
			return cb_getMinimumZoomLevel;
		}

		static int n_GetMinimumZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumZoomLevel;
		public override int MinimumZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='getMinimumZoomLevel' and count(parameter)=0]"
			[Register ("getMinimumZoomLevel", "()I", "GetGetMinimumZoomLevelHandler")]
			get {
				if (id_getMinimumZoomLevel == IntPtr.Zero)
					id_getMinimumZoomLevel = JNIEnv.GetMethodID (class_ref, "getMinimumZoomLevel", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getMinimumZoomLevel);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumZoomLevel", "()I"));
			}
		}

		static Delegate cb_detach;
#pragma warning disable 0169
		static Delegate GetDetachHandler ()
		{
			if (cb_detach == null)
				cb_detach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Detach);
			return cb_detach;
		}

		static void n_Detach (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Detach ();
		}
#pragma warning restore 0169

		static IntPtr id_detach;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='detach' and count(parameter)=0]"
		[Register ("detach", "()V", "GetDetachHandler")]
		public override void Detach ()
		{
			if (id_detach == IntPtr.Zero)
				id_detach = JNIEnv.GetMethodID (class_ref, "detach", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_detach);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "detach", "()V"));
		}

		static Delegate cb_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
		static Delegate GetFindNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
		{
			if (cb_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
				cb_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_);
			return cb_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		}

		static IntPtr n_FindNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aState)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState aState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_aState, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindNextAppropriateProvider (aState));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='findNextAppropriateProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
		[Register ("findNextAppropriateProvider", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;", "GetFindNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler")]
		protected virtual global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase FindNextAppropriateProvider (global::Osmdroid.TileProvider.MapTileRequestState aState)
		{
			if (id_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
				id_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "findNextAppropriateProvider", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;");

			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallObjectMethod  (Handle, id_findNextAppropriateProvider_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (aState)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findNextAppropriateProvider", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;"), new JValue (aState)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
#pragma warning disable 0169
		static Delegate GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler ()
		{
			if (cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == null)
				cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_);
			return cb_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		}

		static IntPtr n_GetMapTile_Lorg_osmdroid_tileprovider_MapTile_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTile)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile pTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_pTile, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMapTile (pTile));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='getMapTile' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTile']]"
		[Register ("getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;", "GetGetMapTile_Lorg_osmdroid_tileprovider_MapTile_Handler")]
		public override global::Android.Graphics.Drawables.Drawable GetMapTile (global::Osmdroid.TileProvider.MapTile pTile)
		{
			if (id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ == IntPtr.Zero)
				id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_ = JNIEnv.GetMethodID (class_ref, "getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;");

			global::Android.Graphics.Drawables.Drawable __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod  (Handle, id_getMapTile_Lorg_osmdroid_tileprovider_MapTile_, new JValue (pTile)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapTile", "(Lorg/osmdroid/tileprovider/MapTile;)Landroid/graphics/drawable/Drawable;"), new JValue (pTile)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_;
#pragma warning disable 0169
		static Delegate GetGetProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Handler ()
		{
			if (cb_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ == null)
				cb_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_);
			return cb_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_;
		}

		static bool n_GetProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_provider)
		{
			global::Osmdroid.TileProvider.MapTileProviderArray __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase provider = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase> (native_provider, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetProviderExists (provider);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/class[@name='MapTileProviderArray']/method[@name='getProviderExists' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.modules.MapTileModuleProviderBase']]"
		[Register ("getProviderExists", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)Z", "GetGetProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_Handler")]
		public virtual bool GetProviderExists (global::Osmdroid.TileProvider.Modules.MapTileModuleProviderBase provider)
		{
			if (id_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ == IntPtr.Zero)
				id_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_ = JNIEnv.GetMethodID (class_ref, "getProviderExists", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_getProviderExists_Lorg_osmdroid_tileprovider_modules_MapTileModuleProviderBase_, new JValue (provider));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProviderExists", "(Lorg/osmdroid/tileprovider/modules/MapTileModuleProviderBase;)Z"), new JValue (provider));
			return __ret;
		}

	}
}
