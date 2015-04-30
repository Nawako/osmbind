using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util.Constants {

	[Register ("org/osmdroid/contributor/util/constants/OpenStreetMapContributorConstants")]
	public abstract class OpenStreetMapContributorConstants {

		internal OpenStreetMapContributorConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='MINDIAGONALMETERS_FOR_OSM_CONTRIBUTION']"
		[Register ("MINDIAGONALMETERS_FOR_OSM_CONTRIBUTION")]
		public const int MindiagonalmetersForOsmContribution = (int) 300;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='MINGEOPOINTS_FOR_OSM_CONTRIBUTION']"
		[Register ("MINGEOPOINTS_FOR_OSM_CONTRIBUTION")]
		public const int MingeopointsForOsmContribution = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public const int NotSet = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_CREATOR_INFO']"
		[Register ("OSM_CREATOR_INFO")]
		public const string OsmCreatorInfo = (string) "AndNav - http://www.andnav.org - Android Navigation System";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_PASSWORD']"
		[Register ("OSM_PASSWORD")]
		public const string OsmPassword = (string) "PUT_YOUR_PASSWORD_HERE";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.contributor.util.constants']/interface[@name='OpenStreetMapContributorConstants']/field[@name='OSM_USERNAME']"
		[Register ("OSM_USERNAME")]
		public const string OsmUsername = (string) "PUT_YOUR_USERNAME_HERE";
	}

	[System.Obsolete ("Use the 'OpenStreetMapContributorConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class OpenStreetMapContributorConstantsConsts : OpenStreetMapContributorConstants {

		private OpenStreetMapContributorConstantsConsts ()
		{
		}
	}

}
