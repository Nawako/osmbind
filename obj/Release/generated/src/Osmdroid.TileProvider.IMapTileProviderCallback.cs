using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IMapTileProviderCallback']"
	[Register ("org/osmdroid/tileprovider/IMapTileProviderCallback", "", "Osmdroid.TileProvider.IMapTileProviderCallbackInvoker")]
	public partial interface IMapTileProviderCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IMapTileProviderCallback']/method[@name='mapTileRequestCompleted' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("mapTileRequestCompleted", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetMapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler:Osmdroid.TileProvider.IMapTileProviderCallbackInvoker, OsmdroidAndroidBinding")]
		void MapTileRequestCompleted (global::Osmdroid.TileProvider.MapTileRequestState aState, global::Android.Graphics.Drawables.Drawable aDrawable);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IMapTileProviderCallback']/method[@name='mapTileRequestExpiredTile' and count(parameter)=2 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("mapTileRequestExpiredTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V", "GetMapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler:Osmdroid.TileProvider.IMapTileProviderCallbackInvoker, OsmdroidAndroidBinding")]
		void MapTileRequestExpiredTile (global::Osmdroid.TileProvider.MapTileRequestState aState, global::Android.Graphics.Drawables.Drawable aDrawable);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IMapTileProviderCallback']/method[@name='mapTileRequestFailed' and count(parameter)=1 and parameter[1][@type='org.osmdroid.tileprovider.MapTileRequestState']]"
		[Register ("mapTileRequestFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V", "GetMapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler:Osmdroid.TileProvider.IMapTileProviderCallbackInvoker, OsmdroidAndroidBinding")]
		void MapTileRequestFailed (global::Osmdroid.TileProvider.MapTileRequestState aState);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider']/interface[@name='IMapTileProviderCallback']/method[@name='useDataConnection' and count(parameter)=0]"
		[Register ("useDataConnection", "()Z", "GetUseDataConnectionHandler:Osmdroid.TileProvider.IMapTileProviderCallbackInvoker, OsmdroidAndroidBinding")]
		bool UseDataConnection ();

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/IMapTileProviderCallback", DoNotGenerateAcw=true)]
	internal class IMapTileProviderCallbackInvoker : global::Java.Lang.Object, IMapTileProviderCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/IMapTileProviderCallback");
		IntPtr class_ref;

		public static IMapTileProviderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMapTileProviderCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.IMapTileProviderCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMapTileProviderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IMapTileProviderCallbackInvoker); }
		}

		static Delegate cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_MapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aState, IntPtr native_aDrawable)
		{
			global::Osmdroid.TileProvider.IMapTileProviderCallback __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState aState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_aState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable aDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_aDrawable, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestCompleted (aState, aDrawable);
		}
#pragma warning restore 0169

		IntPtr id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		public void MapTileRequestCompleted (global::Osmdroid.TileProvider.MapTileRequestState aState, global::Android.Graphics.Drawables.Drawable aDrawable)
		{
			if (id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestCompleted", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod (Handle, id_mapTileRequestCompleted_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (aState), new JValue (aDrawable));
		}

		static Delegate cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == null)
				cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_);
			return cb_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		}

		static void n_MapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aState, IntPtr native_aDrawable)
		{
			global::Osmdroid.TileProvider.IMapTileProviderCallback __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState aState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_aState, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable aDrawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_aDrawable, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestExpiredTile (aState, aDrawable);
		}
#pragma warning restore 0169

		IntPtr id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_;
		public void MapTileRequestExpiredTile (global::Osmdroid.TileProvider.MapTileRequestState aState, global::Android.Graphics.Drawables.Drawable aDrawable)
		{
			if (id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestExpiredTile", "(Lorg/osmdroid/tileprovider/MapTileRequestState;Landroid/graphics/drawable/Drawable;)V");
			JNIEnv.CallVoidMethod (Handle, id_mapTileRequestExpiredTile_Lorg_osmdroid_tileprovider_MapTileRequestState_Landroid_graphics_drawable_Drawable_, new JValue (aState), new JValue (aDrawable));
		}

		static Delegate cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
#pragma warning disable 0169
		static Delegate GetMapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_Handler ()
		{
			if (cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == null)
				cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_);
			return cb_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		}

		static void n_MapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aState)
		{
			global::Osmdroid.TileProvider.IMapTileProviderCallback __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTileRequestState aState = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTileRequestState> (native_aState, JniHandleOwnership.DoNotTransfer);
			__this.MapTileRequestFailed (aState);
		}
#pragma warning restore 0169

		IntPtr id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_;
		public void MapTileRequestFailed (global::Osmdroid.TileProvider.MapTileRequestState aState)
		{
			if (id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ == IntPtr.Zero)
				id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_ = JNIEnv.GetMethodID (class_ref, "mapTileRequestFailed", "(Lorg/osmdroid/tileprovider/MapTileRequestState;)V");
			JNIEnv.CallVoidMethod (Handle, id_mapTileRequestFailed_Lorg_osmdroid_tileprovider_MapTileRequestState_, new JValue (aState));
		}

		static Delegate cb_useDataConnection;
#pragma warning disable 0169
		static Delegate GetUseDataConnectionHandler ()
		{
			if (cb_useDataConnection == null)
				cb_useDataConnection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseDataConnection);
			return cb_useDataConnection;
		}

		static bool n_UseDataConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.IMapTileProviderCallback __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.IMapTileProviderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseDataConnection ();
		}
#pragma warning restore 0169

		IntPtr id_useDataConnection;
		public bool UseDataConnection ()
		{
			if (id_useDataConnection == IntPtr.Zero)
				id_useDataConnection = JNIEnv.GetMethodID (class_ref, "useDataConnection", "()Z");
			return JNIEnv.CallBooleanMethod (Handle, id_useDataConnection);
		}

	}

}
