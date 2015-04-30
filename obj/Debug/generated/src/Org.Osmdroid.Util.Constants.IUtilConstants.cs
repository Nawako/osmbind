using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Util.Constants {

	[Register ("org/osmdroid/util/constants/UtilConstants")]
	public abstract class UtilConstants {

		internal UtilConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='UtilConstants']/field[@name='GPS_WAIT_TIME']"
		[Register ("GPS_WAIT_TIME")]
		public const long GpsWaitTime = (long) 20000L;
	}

	[System.Obsolete ("Use the 'UtilConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class UtilConstantsConsts : UtilConstants {

		private UtilConstantsConsts ()
		{
		}
	}

}
