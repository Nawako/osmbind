using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Util.Constants {

	[Register ("org/osmdroid/util/constants/GeoConstants")]
	public abstract class GeoConstants {

		internal GeoConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='EQUATORCIRCUMFENCE']"
		[Register ("EQUATORCIRCUMFENCE")]
		public const int Equatorcircumfence = (int) 40075016;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='FEET_PER_METER']"
		[Register ("FEET_PER_METER")]
		public const double FeetPerMeter = (double) 3.280839900000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_NAUTICAL_MILE']"
		[Register ("METERS_PER_NAUTICAL_MILE")]
		public const double MetersPerNauticalMile = (double) 1852.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_STATUTE_MILE']"
		[Register ("METERS_PER_STATUTE_MILE")]
		public const double MetersPerStatuteMile = (double) 1609.344000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='RADIUS_EARTH_METERS']"
		[Register ("RADIUS_EARTH_METERS")]
		public const int RadiusEarthMeters = (int) 6378137;
	}

	[System.Obsolete ("Use the 'GeoConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class GeoConstantsConsts : GeoConstants {

		private GeoConstantsConsts ()
		{
		}
	}

}
