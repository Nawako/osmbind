using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Mapsforge {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='GenericMapView']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/mapsforge/GenericMapView", DoNotGenerateAcw=true)]
	public partial class GenericMapView : global::Android.Widget.FrameLayout {


		static IntPtr mMapView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='GenericMapView']/field[@name='mMapView']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/mapsforge/GenericMapView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericMapView); }
		}

		protected GenericMapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='GenericMapView']/constructor[@name='GenericMapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public GenericMapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GenericMapView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_getMapView;
#pragma warning disable 0169
		static Delegate GetGetMapViewHandler ()
		{
			if (cb_getMapView == null)
				cb_getMapView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapView);
			return cb_getMapView;
		}

		static IntPtr n_GetMapView (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.GenericMapView __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.GenericMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapView);
		}
#pragma warning restore 0169

		static IntPtr id_getMapView;
		public virtual global::Osmdroid.Views.MapView MapView {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='GenericMapView']/method[@name='getMapView' and count(parameter)=0]"
			[Register ("getMapView", "()Lorg/osmdroid/views/MapView;", "GetGetMapViewHandler")]
			get {
				if (id_getMapView == IntPtr.Zero)
					id_getMapView = JNIEnv.GetMethodID (class_ref, "getMapView", "()Lorg/osmdroid/views/MapView;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (JNIEnv.CallObjectMethod  (Handle, id_getMapView), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapView", "()Lorg/osmdroid/views/MapView;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_;
#pragma warning disable 0169
		static Delegate GetSetTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_Handler ()
		{
			if (cb_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_ == null)
				cb_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_);
			return cb_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_;
		}

		static void n_SetTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Mapsforge.GenericMapView __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Mapsforge.GenericMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileProviderBase p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileProviderBase> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTileProvider (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.mapsforge']/class[@name='GenericMapView']/method[@name='setTileProvider' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileProviderBase']]"
		[Register ("setTileProvider", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;)V", "GetSetTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_Handler")]
		public virtual void SetTileProvider (global::Osmdroid.TileProvider.MapTileProviderBase p0)
		{
			if (id_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_ == IntPtr.Zero)
				id_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_ = JNIEnv.GetMethodID (class_ref, "setTileProvider", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTileProvider_Lorg_osmdroid_tileprovider_MapTileProviderBase_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTileProvider", "(Lorg/osmdroid/tileprovider/MapTileProviderBase;)V"), new JValue (p0));
		}

	}
}
