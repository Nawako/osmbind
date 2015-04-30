using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']"
	[global::Android.Runtime.Register ("org/osmdroid/util/TileLooper", DoNotGenerateAcw=true)]
	public abstract partial class TileLooper : global::Java.Lang.Object {


		static IntPtr mLowerRight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/field[@name='mLowerRight']"
		[Register ("mLowerRight")]
		protected global::Android.Graphics.Point MLowerRight {
			get {
				if (mLowerRight_jfieldId == IntPtr.Zero)
					mLowerRight_jfieldId = JNIEnv.GetFieldID (class_ref, "mLowerRight", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLowerRight_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLowerRight_jfieldId == IntPtr.Zero)
					mLowerRight_jfieldId = JNIEnv.GetFieldID (class_ref, "mLowerRight", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLowerRight_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mUpperLeft_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/field[@name='mUpperLeft']"
		[Register ("mUpperLeft")]
		protected global::Android.Graphics.Point MUpperLeft {
			get {
				if (mUpperLeft_jfieldId == IntPtr.Zero)
					mUpperLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpperLeft", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUpperLeft_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUpperLeft_jfieldId == IntPtr.Zero)
					mUpperLeft_jfieldId = JNIEnv.GetFieldID (class_ref, "mUpperLeft", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mUpperLeft_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/TileLooper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileLooper); }
		}

		protected TileLooper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/constructor[@name='TileLooper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TileLooper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TileLooper)) {
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

		static Delegate cb_finaliseLoop;
#pragma warning disable 0169
		static Delegate GetFinaliseLoopHandler ()
		{
			if (cb_finaliseLoop == null)
				cb_finaliseLoop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FinaliseLoop);
			return cb_finaliseLoop;
		}

		static void n_FinaliseLoop (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.TileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.TileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FinaliseLoop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='finaliseLoop' and count(parameter)=0]"
		[Register ("finaliseLoop", "()V", "GetFinaliseLoopHandler")]
		public abstract void FinaliseLoop ();

		static Delegate cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
#pragma warning disable 0169
		static Delegate GetHandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_IIHandler ()
		{
			if (cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II == null)
				cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr, int, int>) n_HandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II);
			return cb_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
		}

		static void n_HandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II (IntPtr jnienv, IntPtr native__this, IntPtr native_pCanvas, int pTileSizePx, IntPtr native_pTile, int pX, int pY)
		{
			global::Osmdroid.Util.TileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.TileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas pCanvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_pCanvas, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.TileProvider.MapTile pTile = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.MapTile> (native_pTile, JniHandleOwnership.DoNotTransfer);
			__this.HandleTile (pCanvas, pTileSizePx, pTile, pX, pY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='handleTile' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.tileprovider.MapTile'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
		public abstract void HandleTile (global::Android.Graphics.Canvas pCanvas, int pTileSizePx, global::Osmdroid.TileProvider.MapTile pTile, int pX, int pY);

		static Delegate cb_initialiseLoop_II;
#pragma warning disable 0169
		static Delegate GetInitialiseLoop_IIHandler ()
		{
			if (cb_initialiseLoop_II == null)
				cb_initialiseLoop_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_InitialiseLoop_II);
			return cb_initialiseLoop_II;
		}

		static void n_InitialiseLoop_II (IntPtr jnienv, IntPtr native__this, int pZoomLevel, int pTileSizePx)
		{
			global::Osmdroid.Util.TileLooper __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.TileLooper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitialiseLoop (pZoomLevel, pTileSizePx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='initialiseLoop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initialiseLoop", "(II)V", "GetInitialiseLoop_IIHandler")]
		public abstract void InitialiseLoop (int pZoomLevel, int pTileSizePx);

		static IntPtr id_loop_Landroid_graphics_Canvas_IILandroid_graphics_Rect_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='loop' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Rect']]"
		[Register ("loop", "(Landroid/graphics/Canvas;IILandroid/graphics/Rect;)V", "")]
		public void Loop (global::Android.Graphics.Canvas pCanvas, int pZoomLevel, int pTileSizePx, global::Android.Graphics.Rect pViewPort)
		{
			if (id_loop_Landroid_graphics_Canvas_IILandroid_graphics_Rect_ == IntPtr.Zero)
				id_loop_Landroid_graphics_Canvas_IILandroid_graphics_Rect_ = JNIEnv.GetMethodID (class_ref, "loop", "(Landroid/graphics/Canvas;IILandroid/graphics/Rect;)V");
			JNIEnv.CallVoidMethod  (Handle, id_loop_Landroid_graphics_Canvas_IILandroid_graphics_Rect_, new JValue (pCanvas), new JValue (pZoomLevel), new JValue (pTileSizePx), new JValue (pViewPort));
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/util/TileLooper", DoNotGenerateAcw=true)]
	internal partial class TileLooperInvoker : TileLooper {

		public TileLooperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileLooperInvoker); }
		}

		static IntPtr id_finaliseLoop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='finaliseLoop' and count(parameter)=0]"
		[Register ("finaliseLoop", "()V", "GetFinaliseLoopHandler")]
		public override void FinaliseLoop ()
		{
			if (id_finaliseLoop == IntPtr.Zero)
				id_finaliseLoop = JNIEnv.GetMethodID (class_ref, "finaliseLoop", "()V");
			JNIEnv.CallVoidMethod  (Handle, id_finaliseLoop);
		}

		static IntPtr id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='handleTile' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='int'] and parameter[3][@type='org.osmdroid.tileprovider.MapTile'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V", "GetHandleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_IIHandler")]
		public override void HandleTile (global::Android.Graphics.Canvas pCanvas, int pTileSizePx, global::Osmdroid.TileProvider.MapTile pTile, int pX, int pY)
		{
			if (id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II == IntPtr.Zero)
				id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II = JNIEnv.GetMethodID (class_ref, "handleTile", "(Landroid/graphics/Canvas;ILorg/osmdroid/tileprovider/MapTile;II)V");
			JNIEnv.CallVoidMethod  (Handle, id_handleTile_Landroid_graphics_Canvas_ILorg_osmdroid_tileprovider_MapTile_II, new JValue (pCanvas), new JValue (pTileSizePx), new JValue (pTile), new JValue (pX), new JValue (pY));
		}

		static IntPtr id_initialiseLoop_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileLooper']/method[@name='initialiseLoop' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("initialiseLoop", "(II)V", "GetInitialiseLoop_IIHandler")]
		public override void InitialiseLoop (int pZoomLevel, int pTileSizePx)
		{
			if (id_initialiseLoop_II == IntPtr.Zero)
				id_initialiseLoop_II = JNIEnv.GetMethodID (class_ref, "initialiseLoop", "(II)V");
			JNIEnv.CallVoidMethod  (Handle, id_initialiseLoop_II, new JValue (pZoomLevel), new JValue (pTileSizePx));
		}

	}

}
