using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/osmdroid",
						"org/osmdroid/api",
						"org/osmdroid/contributor",
						"org/osmdroid/contributor/util",
						"org/osmdroid/events",
						"org/osmdroid/tileprovider",
						"org/osmdroid/tileprovider/modules",
						"org/osmdroid/tileprovider/tilesource",
						"org/osmdroid/tileprovider/util",
						"org/osmdroid/util",
						"org/osmdroid/views",
						"org/osmdroid/views/drawing",
						"org/osmdroid/views/overlay",
						"org/osmdroid/views/overlay/compass",
						"org/osmdroid/views/overlay/mylocation",
					},
					new Converter<string, Type>[]{
						lookup_org_osmdroid_package,
						lookup_org_osmdroid_api_package,
						lookup_org_osmdroid_contributor_package,
						lookup_org_osmdroid_contributor_util_package,
						lookup_org_osmdroid_events_package,
						lookup_org_osmdroid_tileprovider_package,
						lookup_org_osmdroid_tileprovider_modules_package,
						lookup_org_osmdroid_tileprovider_tilesource_package,
						lookup_org_osmdroid_tileprovider_util_package,
						lookup_org_osmdroid_util_package,
						lookup_org_osmdroid_views_package,
						lookup_org_osmdroid_views_drawing_package,
						lookup_org_osmdroid_views_overlay_package,
						lookup_org_osmdroid_views_overlay_compass_package,
						lookup_org_osmdroid_views_overlay_mylocation_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_osmdroid_mappings;
		static Type lookup_org_osmdroid_package (string klass)
		{
			if (package_org_osmdroid_mappings == null) {
				package_org_osmdroid_mappings = new string[]{
					"org/osmdroid/DefaultResourceProxyImpl:Osmdroid.DefaultResourceProxyImpl",
					"org/osmdroid/LocationListenerProxy:Osmdroid.LocationListenerProxy",
					"org/osmdroid/ResourceProxy$bitmap:Osmdroid.ResourceProxyBitmap",
					"org/osmdroid/ResourceProxy$string:Osmdroid.ResourceProxyString",
					"org/osmdroid/SensorEventListenerProxy:Osmdroid.SensorEventListenerProxy",
				};
			}

			return Lookup (package_org_osmdroid_mappings, klass);
		}

		static string[] package_org_osmdroid_api_mappings;
		static Type lookup_org_osmdroid_api_package (string klass)
		{
			if (package_org_osmdroid_api_mappings == null) {
				package_org_osmdroid_api_mappings = new string[]{
					"org/osmdroid/api/Marker:Osmdroid.Api.Marker",
					"org/osmdroid/api/Marker$Anchor:Osmdroid.Api.Marker/Anchor",
					"org/osmdroid/api/Polyline:Osmdroid.Api.Polyline",
				};
			}

			return Lookup (package_org_osmdroid_api_mappings, klass);
		}

		static string[] package_org_osmdroid_contributor_mappings;
		static Type lookup_org_osmdroid_contributor_package (string klass)
		{
			if (package_org_osmdroid_contributor_mappings == null) {
				package_org_osmdroid_contributor_mappings = new string[]{
					"org/osmdroid/contributor/GpxToPHPUploader:Osmdroid.Contributor.GpxToPHPUploader",
					"org/osmdroid/contributor/OSMUploader:Osmdroid.Contributor.OSMUploader",
					"org/osmdroid/contributor/RouteRecorder:Osmdroid.Contributor.RouteRecorder",
				};
			}

			return Lookup (package_org_osmdroid_contributor_mappings, klass);
		}

		static string[] package_org_osmdroid_contributor_util_mappings;
		static Type lookup_org_osmdroid_contributor_util_package (string klass)
		{
			if (package_org_osmdroid_contributor_util_mappings == null) {
				package_org_osmdroid_contributor_util_mappings = new string[]{
					"org/osmdroid/contributor/util/RecordedGeoPoint:Osmdroid.Contributor.Util.RecordedGeoPoint",
					"org/osmdroid/contributor/util/RecordedRouteGPXFormatter:Osmdroid.Contributor.Util.RecordedRouteGPXFormatter",
					"org/osmdroid/contributor/util/Util:Osmdroid.Contributor.Util.Util",
				};
			}

			return Lookup (package_org_osmdroid_contributor_util_mappings, klass);
		}

		static string[] package_org_osmdroid_events_mappings;
		static Type lookup_org_osmdroid_events_package (string klass)
		{
			if (package_org_osmdroid_events_mappings == null) {
				package_org_osmdroid_events_mappings = new string[]{
					"org/osmdroid/events/DelayedMapListener:Osmdroid.Events.DelayedMapListener",
					"org/osmdroid/events/DelayedMapListener$CallbackTask:Osmdroid.Events.DelayedMapListener/CallbackTask",
					"org/osmdroid/events/MapAdapter:Osmdroid.Events.MapAdapter",
					"org/osmdroid/events/ScrollEvent:Osmdroid.Events.ScrollEvent",
					"org/osmdroid/events/ZoomEvent:Osmdroid.Events.ZoomEvent",
				};
			}

			return Lookup (package_org_osmdroid_events_mappings, klass);
		}

		static string[] package_org_osmdroid_tileprovider_mappings;
		static Type lookup_org_osmdroid_tileprovider_package (string klass)
		{
			if (package_org_osmdroid_tileprovider_mappings == null) {
				package_org_osmdroid_tileprovider_mappings = new string[]{
					"org/osmdroid/tileprovider/BitmapPool:Osmdroid.TileProvider.BitmapPool",
					"org/osmdroid/tileprovider/ExpirableBitmapDrawable:Osmdroid.TileProvider.ExpirableBitmapDrawable",
					"org/osmdroid/tileprovider/LRUMapTileCache:Osmdroid.TileProvider.LRUMapTileCache",
					"org/osmdroid/tileprovider/MapTile:Osmdroid.TileProvider.MapTile",
					"org/osmdroid/tileprovider/MapTileCache:Osmdroid.TileProvider.MapTileCache",
					"org/osmdroid/tileprovider/MapTileProviderArray:Osmdroid.TileProvider.MapTileProviderArray",
					"org/osmdroid/tileprovider/MapTileProviderBase:Osmdroid.TileProvider.MapTileProviderBase",
					"org/osmdroid/tileprovider/MapTileProviderBase$ScaleTileLooper:Osmdroid.TileProvider.MapTileProviderBase/ScaleTileLooper",
					"org/osmdroid/tileprovider/MapTileProviderBase$ZoomInTileLooper:Osmdroid.TileProvider.MapTileProviderBase/ZoomInTileLooper",
					"org/osmdroid/tileprovider/MapTileProviderBase$ZoomOutTileLooper:Osmdroid.TileProvider.MapTileProviderBase/ZoomOutTileLooper",
					"org/osmdroid/tileprovider/MapTileProviderBasic:Osmdroid.TileProvider.MapTileProviderBasic",
					"org/osmdroid/tileprovider/MapTileRequestState:Osmdroid.TileProvider.MapTileRequestState",
					"org/osmdroid/tileprovider/ReusableBitmapDrawable:Osmdroid.TileProvider.ReusableBitmapDrawable",
				};
			}

			return Lookup (package_org_osmdroid_tileprovider_mappings, klass);
		}

		static string[] package_org_osmdroid_tileprovider_modules_mappings;
		static Type lookup_org_osmdroid_tileprovider_modules_package (string klass)
		{
			if (package_org_osmdroid_tileprovider_modules_mappings == null) {
				package_org_osmdroid_tileprovider_modules_mappings = new string[]{
					"org/osmdroid/tileprovider/modules/ArchiveFileFactory:Osmdroid.TileProvider.Modules.ArchiveFileFactory",
					"org/osmdroid/tileprovider/modules/ConfigurablePriorityThreadFactory:Osmdroid.TileProvider.Modules.ConfigurablePriorityThreadFactory",
					"org/osmdroid/tileprovider/modules/DatabaseFileArchive:Osmdroid.TileProvider.Modules.DatabaseFileArchive",
					"org/osmdroid/tileprovider/modules/GEMFFileArchive:Osmdroid.TileProvider.Modules.GEMFFileArchive",
					"org/osmdroid/tileprovider/modules/MapTileDownloader:Osmdroid.TileProvider.Modules.MapTileDownloader",
					"org/osmdroid/tileprovider/modules/MapTileDownloader$TileLoader:Osmdroid.TileProvider.Modules.MapTileDownloader/TileLoader",
					"org/osmdroid/tileprovider/modules/MapTileFileArchiveProvider:Osmdroid.TileProvider.Modules.MapTileFileArchiveProvider",
					"org/osmdroid/tileprovider/modules/MapTileFileArchiveProvider$TileLoader:Osmdroid.TileProvider.Modules.MapTileFileArchiveProvider/TileLoader",
					"org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase:Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase",
					"org/osmdroid/tileprovider/modules/MapTileFileStorageProviderBase$MyBroadcastReceiver:Osmdroid.TileProvider.Modules.MapTileFileStorageProviderBase/MyBroadcastReceiver",
					"org/osmdroid/tileprovider/modules/MapTileFilesystemProvider:Osmdroid.TileProvider.Modules.MapTileFilesystemProvider",
					"org/osmdroid/tileprovider/modules/MapTileFilesystemProvider$TileLoader:Osmdroid.TileProvider.Modules.MapTileFilesystemProvider/TileLoader",
					"org/osmdroid/tileprovider/modules/MapTileModuleProviderBase:Osmdroid.TileProvider.Modules.MapTileModuleProviderBase",
					"org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$CantContinueException:Osmdroid.TileProvider.Modules.MapTileModuleProviderBase/CantContinueException",
					"org/osmdroid/tileprovider/modules/MapTileModuleProviderBase$TileLoader:Osmdroid.TileProvider.Modules.MapTileModuleProviderBase/TileLoader",
					"org/osmdroid/tileprovider/modules/MBTilesFileArchive:Osmdroid.TileProvider.Modules.MBTilesFileArchive",
					"org/osmdroid/tileprovider/modules/NetworkAvailabliltyCheck:Osmdroid.TileProvider.Modules.NetworkAvailabliltyCheck",
					"org/osmdroid/tileprovider/modules/TileWriter:Osmdroid.TileProvider.Modules.TileWriter",
					"org/osmdroid/tileprovider/modules/ZipFileArchive:Osmdroid.TileProvider.Modules.ZipFileArchive",
				};
			}

			return Lookup (package_org_osmdroid_tileprovider_modules_mappings, klass);
		}

		static string[] package_org_osmdroid_tileprovider_tilesource_mappings;
		static Type lookup_org_osmdroid_tileprovider_tilesource_package (string klass)
		{
			if (package_org_osmdroid_tileprovider_tilesource_mappings == null) {
				package_org_osmdroid_tileprovider_tilesource_mappings = new string[]{
					"org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase:Osmdroid.TileProvider.TileSource.BitmapTileSourceBase",
					"org/osmdroid/tileprovider/tilesource/BitmapTileSourceBase$LowMemoryException:Osmdroid.TileProvider.TileSource.BitmapTileSourceBase/LowMemoryException",
					"org/osmdroid/tileprovider/tilesource/MapBoxTileSource:Osmdroid.TileProvider.TileSource.MapBoxTileSource",
					"org/osmdroid/tileprovider/tilesource/OnlineTileSourceBase:Osmdroid.TileProvider.TileSource.OnlineTileSourceBase",
					"org/osmdroid/tileprovider/tilesource/QuadTreeTileSource:Osmdroid.TileProvider.TileSource.QuadTreeTileSource",
					"org/osmdroid/tileprovider/tilesource/TileSourceFactory:Osmdroid.TileProvider.TileSource.TileSourceFactory",
					"org/osmdroid/tileprovider/tilesource/XYTileSource:Osmdroid.TileProvider.TileSource.XYTileSource",
				};
			}

			return Lookup (package_org_osmdroid_tileprovider_tilesource_mappings, klass);
		}

		static string[] package_org_osmdroid_tileprovider_util_mappings;
		static Type lookup_org_osmdroid_tileprovider_util_package (string klass)
		{
			if (package_org_osmdroid_tileprovider_util_mappings == null) {
				package_org_osmdroid_tileprovider_util_mappings = new string[]{
					"org/osmdroid/tileprovider/util/CloudmadeUtil:Osmdroid.TileProvider.Util.CloudmadeUtil",
					"org/osmdroid/tileprovider/util/ManifestUtil:Osmdroid.TileProvider.Util.ManifestUtil",
					"org/osmdroid/tileprovider/util/SimpleInvalidationHandler:Osmdroid.TileProvider.Util.SimpleInvalidationHandler",
					"org/osmdroid/tileprovider/util/SimpleRegisterReceiver:Osmdroid.TileProvider.Util.SimpleRegisterReceiver",
					"org/osmdroid/tileprovider/util/StreamUtils:Osmdroid.TileProvider.Util.StreamUtils",
				};
			}

			return Lookup (package_org_osmdroid_tileprovider_util_mappings, klass);
		}

		static string[] package_org_osmdroid_util_mappings;
		static Type lookup_org_osmdroid_util_package (string klass)
		{
			if (package_org_osmdroid_util_mappings == null) {
				package_org_osmdroid_util_mappings = new string[]{
					"org/osmdroid/util/BoundingBoxE6:Osmdroid.Util.BoundingBoxE6",
					"org/osmdroid/util/GEMFFile:Osmdroid.Util.GEMFFile",
					"org/osmdroid/util/GEMFFile$GEMFInputStream:Osmdroid.Util.GEMFFile/GEMFInputStream",
					"org/osmdroid/util/GEMFFile$GEMFRange:Osmdroid.Util.GEMFFile/GEMFRange",
					"org/osmdroid/util/GeometryMath:Osmdroid.Util.GeometryMath",
					"org/osmdroid/util/GeoPoint:Osmdroid.Util.GeoPoint",
					"org/osmdroid/util/LocationUtils:Osmdroid.Util.LocationUtils",
					"org/osmdroid/util/MyMath:Osmdroid.Util.MyMath",
					"org/osmdroid/util/NetworkLocationIgnorer:Osmdroid.Util.NetworkLocationIgnorer",
					"org/osmdroid/util/Position:Osmdroid.Util.Position",
					"org/osmdroid/util/ResourceProxyImpl:Osmdroid.Util.ResourceProxyImpl",
					"org/osmdroid/util/TileLooper:Osmdroid.Util.TileLooper",
					"org/osmdroid/util/TileSystem:Osmdroid.Util.TileSystem",
				};
			}

			return Lookup (package_org_osmdroid_util_mappings, klass);
		}

		static string[] package_org_osmdroid_views_mappings;
		static Type lookup_org_osmdroid_views_package (string klass)
		{
			if (package_org_osmdroid_views_mappings == null) {
				package_org_osmdroid_views_mappings = new string[]{
					"org/osmdroid/views/MapController:Osmdroid.Views.MapController",
					"org/osmdroid/views/MapController$MyZoomAnimationListener:Osmdroid.Views.MapController/MyZoomAnimationListener",
					"org/osmdroid/views/MapController$MyZoomAnimatorListener:Osmdroid.Views.MapController/MyZoomAnimatorListener",
					"org/osmdroid/views/MapController$MyZoomAnimatorUpdateListener:Osmdroid.Views.MapController/MyZoomAnimatorUpdateListener",
					"org/osmdroid/views/MapControllerOld:Osmdroid.Views.MapControllerOld",
					"org/osmdroid/views/MapControllerOld$AbstractAnimationRunner:Osmdroid.Views.MapControllerOld/AbstractAnimationRunner",
					"org/osmdroid/views/MapControllerOld$AnimationType:Osmdroid.Views.MapControllerOld/AnimationType",
					"org/osmdroid/views/MapControllerOld$CosinusalBasedAnimationRunner:Osmdroid.Views.MapControllerOld/CosinusalBasedAnimationRunner",
					"org/osmdroid/views/MapControllerOld$ExponentialDeceleratingAnimationRunner:Osmdroid.Views.MapControllerOld/ExponentialDeceleratingAnimationRunner",
					"org/osmdroid/views/MapControllerOld$HalfCosinusalDeceleratingAnimationRunner:Osmdroid.Views.MapControllerOld/HalfCosinusalDeceleratingAnimationRunner",
					"org/osmdroid/views/MapControllerOld$LinearAnimationRunner:Osmdroid.Views.MapControllerOld/LinearAnimationRunner",
					"org/osmdroid/views/MapControllerOld$MiddlePeakSpeedAnimationRunner:Osmdroid.Views.MapControllerOld/MiddlePeakSpeedAnimationRunner",
					"org/osmdroid/views/MapControllerOld$QuarterCosinusalDeceleratingAnimationRunner:Osmdroid.Views.MapControllerOld/QuarterCosinusalDeceleratingAnimationRunner",
					"org/osmdroid/views/MapView:Osmdroid.Views.MapView",
					"org/osmdroid/views/MapView$LayoutParams:Osmdroid.Views.MapView/LayoutParams",
					"org/osmdroid/views/MapView$MapViewDoubleClickListener:Osmdroid.Views.MapView/MapViewDoubleClickListener",
					"org/osmdroid/views/MapView$MapViewGestureDetectorListener:Osmdroid.Views.MapView/MapViewGestureDetectorListener",
					"org/osmdroid/views/MapView$MapViewZoomListener:Osmdroid.Views.MapView/MapViewZoomListener",
					"org/osmdroid/views/Projection:Osmdroid.Views.Projection",
				};
			}

			return Lookup (package_org_osmdroid_views_mappings, klass);
		}

		static string[] package_org_osmdroid_views_drawing_mappings;
		static Type lookup_org_osmdroid_views_drawing_package (string klass)
		{
			if (package_org_osmdroid_views_drawing_mappings == null) {
				package_org_osmdroid_views_drawing_mappings = new string[]{
					"org/osmdroid/views/drawing/OsmBitmapShader:Osmdroid.Views.Drawing.OsmBitmapShader",
					"org/osmdroid/views/drawing/OsmPath:Osmdroid.Views.Drawing.OsmPath",
				};
			}

			return Lookup (package_org_osmdroid_views_drawing_mappings, klass);
		}

		static string[] package_org_osmdroid_views_overlay_mappings;
		static Type lookup_org_osmdroid_views_overlay_package (string klass)
		{
			if (package_org_osmdroid_views_overlay_mappings == null) {
				package_org_osmdroid_views_overlay_mappings = new string[]{
					"org/osmdroid/views/overlay/DirectedLocationOverlay:Osmdroid.Views.Overlay.DirectedLocationOverlay",
					"org/osmdroid/views/overlay/ItemizedIconOverlay:Osmdroid.Views.Overlay.ItemizedIconOverlay",
					"org/osmdroid/views/overlay/ItemizedOverlay:Osmdroid.Views.Overlay.ItemizedOverlay",
					"org/osmdroid/views/overlay/ItemizedOverlayControlView:Osmdroid.Views.Overlay.ItemizedOverlayControlView",
					"org/osmdroid/views/overlay/ItemizedOverlayWithFocus:Osmdroid.Views.Overlay.ItemizedOverlayWithFocus",
					"org/osmdroid/views/overlay/MinimapOverlay:Osmdroid.Views.Overlay.MinimapOverlay",
					"org/osmdroid/views/overlay/MyLocationOverlay:Osmdroid.Views.Overlay.MyLocationOverlay",
					"org/osmdroid/views/overlay/NonAcceleratedOverlay:Osmdroid.Views.Overlay.NonAcceleratedOverlay",
					"org/osmdroid/views/overlay/Overlay:Osmdroid.Views.Overlay.Overlay",
					"org/osmdroid/views/overlay/OverlayItem:Osmdroid.Views.Overlay.OverlayItem",
					"org/osmdroid/views/overlay/OverlayItem$HotspotPlace:Osmdroid.Views.Overlay.OverlayItem/HotspotPlace",
					"org/osmdroid/views/overlay/OverlayManager:Osmdroid.Views.Overlay.OverlayManager",
					"org/osmdroid/views/overlay/PathOverlay:Osmdroid.Views.Overlay.PathOverlay",
					"org/osmdroid/views/overlay/ScaleBarOverlay:Osmdroid.Views.Overlay.ScaleBarOverlay",
					"org/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure:Osmdroid.Views.Overlay.ScaleBarOverlay/UnitsOfMeasure",
					"org/osmdroid/views/overlay/SimpleLocationOverlay:Osmdroid.Views.Overlay.SimpleLocationOverlay",
					"org/osmdroid/views/overlay/TilesOverlay:Osmdroid.Views.Overlay.TilesOverlay",
				};
			}

			return Lookup (package_org_osmdroid_views_overlay_mappings, klass);
		}

		static string[] package_org_osmdroid_views_overlay_compass_mappings;
		static Type lookup_org_osmdroid_views_overlay_compass_package (string klass)
		{
			if (package_org_osmdroid_views_overlay_compass_mappings == null) {
				package_org_osmdroid_views_overlay_compass_mappings = new string[]{
					"org/osmdroid/views/overlay/compass/CompassOverlay:Osmdroid.Views.Overlay.Compass.CompassOverlay",
					"org/osmdroid/views/overlay/compass/InternalCompassOrientationProvider:Osmdroid.Views.Overlay.Compass.InternalCompassOrientationProvider",
				};
			}

			return Lookup (package_org_osmdroid_views_overlay_compass_mappings, klass);
		}

		static string[] package_org_osmdroid_views_overlay_mylocation_mappings;
		static Type lookup_org_osmdroid_views_overlay_mylocation_package (string klass)
		{
			if (package_org_osmdroid_views_overlay_mylocation_mappings == null) {
				package_org_osmdroid_views_overlay_mylocation_mappings = new string[]{
					"org/osmdroid/views/overlay/mylocation/GpsMyLocationProvider:Osmdroid.Views.Overlay.MyLocation.GpsMyLocationProvider",
					"org/osmdroid/views/overlay/mylocation/MyLocationNewOverlay:Osmdroid.Views.Overlay.MyLocation.MyLocationNewOverlay",
				};
			}

			return Lookup (package_org_osmdroid_views_overlay_mylocation_mappings, klass);
		}
	}
}
