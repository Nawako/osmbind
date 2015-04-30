using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Util.Constants {

	[Register ("org/osmdroid/views/util/constants/MapViewConstants")]
	public abstract class MapViewConstants {

		internal MapViewConstants ()
		{
		}

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

	[System.Obsolete ("Use the 'MapViewConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MapViewConstantsConsts : MapViewConstants {

		private MapViewConstantsConsts ()
		{
		}
	}

}
