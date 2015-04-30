using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']"
	[global::Android.Runtime.Register ("org/osmdroid/util/TileSystem", DoNotGenerateAcw=true)]
	public sealed partial class TileSystem : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/TileSystem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TileSystem); }
		}

		internal TileSystem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/constructor[@name='TileSystem' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public TileSystem () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (TileSystem)) {
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

		static IntPtr id_getTileSize;
		static IntPtr id_setTileSize_I;
		public static int TileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='getTileSize' and count(parameter)=0]"
			[Register ("getTileSize", "()I", "GetGetTileSizeHandler")]
			get {
				if (id_getTileSize == IntPtr.Zero)
					id_getTileSize = JNIEnv.GetStaticMethodID (class_ref, "getTileSize", "()I");
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getTileSize);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='setTileSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTileSize", "(I)V", "GetSetTileSize_IHandler")]
			set {
				if (id_setTileSize_I == IntPtr.Zero)
					id_setTileSize_I = JNIEnv.GetStaticMethodID (class_ref, "setTileSize", "(I)V");
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTileSize_I, new JValue (value));
			}
		}

		static IntPtr id_GroundResolution_DI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='GroundResolution' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='int']]"
		[Register ("GroundResolution", "(DI)D", "")]
		public static double GroundResolution (double latitude, int levelOfDetail)
		{
			if (id_GroundResolution_DI == IntPtr.Zero)
				id_GroundResolution_DI = JNIEnv.GetStaticMethodID (class_ref, "GroundResolution", "(DI)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_GroundResolution_DI, new JValue (latitude), new JValue (levelOfDetail));
		}

		static IntPtr id_LatLongToPixelXY_DDILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='LatLongToPixelXY' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Point']]"
		[Register ("LatLongToPixelXY", "(DDILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point LatLongToPixelXY (double latitude, double longitude, int levelOfDetail, global::Android.Graphics.Point reuse)
		{
			if (id_LatLongToPixelXY_DDILandroid_graphics_Point_ == IntPtr.Zero)
				id_LatLongToPixelXY_DDILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "LatLongToPixelXY", "(DDILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_LatLongToPixelXY_DDILandroid_graphics_Point_, new JValue (latitude), new JValue (longitude), new JValue (levelOfDetail), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_MapScale_DII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='MapScale' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("MapScale", "(DII)D", "")]
		public static double MapScale (double latitude, int levelOfDetail, int screenDpi)
		{
			if (id_MapScale_DII == IntPtr.Zero)
				id_MapScale_DII = JNIEnv.GetStaticMethodID (class_ref, "MapScale", "(DII)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_MapScale_DII, new JValue (latitude), new JValue (levelOfDetail), new JValue (screenDpi));
		}

		static IntPtr id_MapSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='MapSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("MapSize", "(I)I", "")]
		public static int MapSize (int levelOfDetail)
		{
			if (id_MapSize_I == IntPtr.Zero)
				id_MapSize_I = JNIEnv.GetStaticMethodID (class_ref, "MapSize", "(I)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_MapSize_I, new JValue (levelOfDetail));
		}

		static IntPtr id_PixelXYToLatLong_IIILorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='PixelXYToLatLong' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("PixelXYToLatLong", "(IIILorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Osmdroid.Util.GeoPoint PixelXYToLatLong (int pixelX, int pixelY, int levelOfDetail, global::Osmdroid.Util.GeoPoint reuse)
		{
			if (id_PixelXYToLatLong_IIILorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_PixelXYToLatLong_IIILorg_osmdroid_util_GeoPoint_ = JNIEnv.GetStaticMethodID (class_ref, "PixelXYToLatLong", "(IIILorg/osmdroid/util/GeoPoint;)Lorg/osmdroid/util/GeoPoint;");
			global::Osmdroid.Util.GeoPoint __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_PixelXYToLatLong_IIILorg_osmdroid_util_GeoPoint_, new JValue (pixelX), new JValue (pixelY), new JValue (levelOfDetail), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_PixelXYToTileXY_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='PixelXYToTileXY' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("PixelXYToTileXY", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point PixelXYToTileXY (int pixelX, int pixelY, global::Android.Graphics.Point reuse)
		{
			if (id_PixelXYToTileXY_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_PixelXYToTileXY_IILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "PixelXYToTileXY", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_PixelXYToTileXY_IILandroid_graphics_Point_, new JValue (pixelX), new JValue (pixelY), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_QuadKeyToTileXY_Ljava_lang_String_Landroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='QuadKeyToTileXY' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("QuadKeyToTileXY", "(Ljava/lang/String;Landroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point QuadKeyToTileXY (string quadKey, global::Android.Graphics.Point reuse)
		{
			if (id_QuadKeyToTileXY_Ljava_lang_String_Landroid_graphics_Point_ == IntPtr.Zero)
				id_QuadKeyToTileXY_Ljava_lang_String_Landroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "QuadKeyToTileXY", "(Ljava/lang/String;Landroid/graphics/Point;)Landroid/graphics/Point;");
			IntPtr native_quadKey = JNIEnv.NewString (quadKey);
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_QuadKeyToTileXY_Ljava_lang_String_Landroid_graphics_Point_, new JValue (native_quadKey), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_quadKey);
			return __ret;
		}

		static IntPtr id_TileXYToPixelXY_IILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='TileXYToPixelXY' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("TileXYToPixelXY", "(IILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point TileXYToPixelXY (int tileX, int tileY, global::Android.Graphics.Point reuse)
		{
			if (id_TileXYToPixelXY_IILandroid_graphics_Point_ == IntPtr.Zero)
				id_TileXYToPixelXY_IILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "TileXYToPixelXY", "(IILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_TileXYToPixelXY_IILandroid_graphics_Point_, new JValue (tileX), new JValue (tileY), new JValue (reuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_TileXYToQuadKey_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='TileSystem']/method[@name='TileXYToQuadKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("TileXYToQuadKey", "(III)Ljava/lang/String;", "")]
		public static string TileXYToQuadKey (int tileX, int tileY, int levelOfDetail)
		{
			if (id_TileXYToQuadKey_III == IntPtr.Zero)
				id_TileXYToQuadKey_III = JNIEnv.GetStaticMethodID (class_ref, "TileXYToQuadKey", "(III)Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_TileXYToQuadKey_III, new JValue (tileX), new JValue (tileY), new JValue (levelOfDetail)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
