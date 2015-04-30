using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']"
	[global::Android.Runtime.Register ("org/osmdroid/views/util/Mercator", DoNotGenerateAcw=true)]
	public partial class Mercator : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.MapViewConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_DEFAULT']"
			[Register ("ANIMATION_DURATION_DEFAULT")]
			public const int AnimationDurationDefault = (int) 1000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_LONG']"
			[Register ("ANIMATION_DURATION_LONG")]
			public const int AnimationDurationLong = (int) 2000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_DURATION_SHORT']"
			[Register ("ANIMATION_DURATION_SHORT")]
			public const int AnimationDurationShort = (int) 500;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_DEFAULT']"
			[Register ("ANIMATION_SMOOTHNESS_DEFAULT")]
			public const int AnimationSmoothnessDefault = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_HIGH']"
			[Register ("ANIMATION_SMOOTHNESS_HIGH")]
			public const int AnimationSmoothnessHigh = (int) 20;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='ANIMATION_SMOOTHNESS_LOW']"
			[Register ("ANIMATION_SMOOTHNESS_LOW")]
			public const int AnimationSmoothnessLow = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='DEBUGMODE']"
			[Register ("DEBUGMODE")]
			public const bool Debugmode = (bool) false;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MAXIMUM_ZOOMLEVEL']"
			[Register ("MAXIMUM_ZOOMLEVEL")]
			public const int MaximumZoomlevel = (int) 22;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='MINIMUM_ZOOMLEVEL']"
			[Register ("MINIMUM_ZOOMLEVEL")]
			public const int MinimumZoomlevel = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MapViewConstants']/field[@name='NOT_SET']"
			[Register ("NOT_SET")]
			public const int NotSet = (int) -2147483648;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/util/Mercator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mercator); }
		}

		protected Mercator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getBoundingBoxFromCoords_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='getBoundingBoxFromCoords' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getBoundingBoxFromCoords", "(IIIII)Lorg/osmdroid/util/BoundingBoxE6;", "")]
		public static global::Org.Osmdroid.Util.BoundingBoxE6 GetBoundingBoxFromCoords (int left, int top, int right, int bottom, int zoom)
		{
			if (id_getBoundingBoxFromCoords_IIIII == IntPtr.Zero)
				id_getBoundingBoxFromCoords_IIIII = JNIEnv.GetStaticMethodID (class_ref, "getBoundingBoxFromCoords", "(IIIII)Lorg/osmdroid/util/BoundingBoxE6;");
			return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoundingBoxFromCoords_IIIII, new JValue (left), new JValue (top), new JValue (right), new JValue (bottom), new JValue (zoom)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_getBoundingBoxFromPointInMapTile_Landroid_graphics_Point_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='getBoundingBoxFromPointInMapTile' and count(parameter)=2 and parameter[1][@type='android.graphics.Point'] and parameter[2][@type='int']]"
		[Register ("getBoundingBoxFromPointInMapTile", "(Landroid/graphics/Point;I)Lorg/osmdroid/util/BoundingBoxE6;", "")]
		public static global::Org.Osmdroid.Util.BoundingBoxE6 GetBoundingBoxFromPointInMapTile (global::Android.Graphics.Point aMapTile, int aZoom)
		{
			if (id_getBoundingBoxFromPointInMapTile_Landroid_graphics_Point_I == IntPtr.Zero)
				id_getBoundingBoxFromPointInMapTile_Landroid_graphics_Point_I = JNIEnv.GetStaticMethodID (class_ref, "getBoundingBoxFromPointInMapTile", "(Landroid/graphics/Point;I)Lorg/osmdroid/util/BoundingBoxE6;");
			global::Org.Osmdroid.Util.BoundingBoxE6 __ret = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoundingBoxFromPointInMapTile_Landroid_graphics_Point_I, new JValue (aMapTile), new JValue (aZoom)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_projectGeoPoint_DDILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='projectGeoPoint' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Point']]"
		[Register ("projectGeoPoint", "(DDILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point ProjectGeoPoint (double aLat, double aLon, int aZoom, global::Android.Graphics.Point aReuse)
		{
			if (id_projectGeoPoint_DDILandroid_graphics_Point_ == IntPtr.Zero)
				id_projectGeoPoint_DDILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "projectGeoPoint", "(DDILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_projectGeoPoint_DDILandroid_graphics_Point_, new JValue (aLat), new JValue (aLon), new JValue (aZoom), new JValue (aReuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_projectGeoPoint_IIILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='projectGeoPoint' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Point']]"
		[Register ("projectGeoPoint", "(IIILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point ProjectGeoPoint (int aLatE6, int aLonE6, int aZoom, global::Android.Graphics.Point aReuse)
		{
			if (id_projectGeoPoint_IIILandroid_graphics_Point_ == IntPtr.Zero)
				id_projectGeoPoint_IIILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "projectGeoPoint", "(IIILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_projectGeoPoint_IIILandroid_graphics_Point_, new JValue (aLatE6), new JValue (aLonE6), new JValue (aZoom), new JValue (aReuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_projectGeoPoint_Lorg_osmdroid_api_IGeoPoint_ILandroid_graphics_Point_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='projectGeoPoint' and count(parameter)=3 and parameter[1][@type='org.osmdroid.api.IGeoPoint'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point']]"
		[Register ("projectGeoPoint", "(Lorg/osmdroid/api/IGeoPoint;ILandroid/graphics/Point;)Landroid/graphics/Point;", "")]
		public static global::Android.Graphics.Point ProjectGeoPoint (global::Osmdroid.Api.IGeoPoint aGeoPoint, int aZoom, global::Android.Graphics.Point aReuse)
		{
			if (id_projectGeoPoint_Lorg_osmdroid_api_IGeoPoint_ILandroid_graphics_Point_ == IntPtr.Zero)
				id_projectGeoPoint_Lorg_osmdroid_api_IGeoPoint_ILandroid_graphics_Point_ = JNIEnv.GetStaticMethodID (class_ref, "projectGeoPoint", "(Lorg/osmdroid/api/IGeoPoint;ILandroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallStaticObjectMethod  (class_ref, id_projectGeoPoint_Lorg_osmdroid_api_IGeoPoint_ILandroid_graphics_Point_, new JValue (aGeoPoint), new JValue (aZoom), new JValue (aReuse)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_projectPoint_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='projectPoint' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("projectPoint", "(III)Lorg/osmdroid/util/GeoPoint;", "")]
		public static global::Org.Osmdroid.Util.GeoPoint ProjectPoint (int x, int y, int aZoom)
		{
			if (id_projectPoint_III == IntPtr.Zero)
				id_projectPoint_III = JNIEnv.GetStaticMethodID (class_ref, "projectPoint", "(III)Lorg/osmdroid/util/GeoPoint;");
			return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallStaticObjectMethod  (class_ref, id_projectPoint_III, new JValue (x), new JValue (y), new JValue (aZoom)), JniHandleOwnership.TransferLocalRef);
		}

		static IntPtr id_tile2lat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='tile2lat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("tile2lat", "(II)D", "")]
		public static double Tile2lat (int y, int aZoom)
		{
			if (id_tile2lat_II == IntPtr.Zero)
				id_tile2lat_II = JNIEnv.GetStaticMethodID (class_ref, "tile2lat", "(II)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_tile2lat_II, new JValue (y), new JValue (aZoom));
		}

		static IntPtr id_tile2lon_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='Mercator']/method[@name='tile2lon' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("tile2lon", "(II)D", "")]
		public static double Tile2lon (int x, int aZoom)
		{
			if (id_tile2lon_II == IntPtr.Zero)
				id_tile2lon_II = JNIEnv.GetStaticMethodID (class_ref, "tile2lon", "(II)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_tile2lon_II, new JValue (x), new JValue (aZoom));
		}

	}
}
