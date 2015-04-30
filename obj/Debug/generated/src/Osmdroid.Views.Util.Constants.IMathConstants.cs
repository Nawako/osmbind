using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Util.Constants {

	[Register ("org/osmdroid/views/util/constants/MathConstants")]
	public abstract class MathConstants {

		internal MathConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='DEG2RAD']"
		[Register ("DEG2RAD")]
		public const float Deg2rad = (float) 0.017453;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI']"
		[Register ("PI")]
		public const float Pi = (float) 3.141593;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_2']"
		[Register ("PI_2")]
		public const float Pi2 = (float) 1.570796;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_4']"
		[Register ("PI_4")]
		public const float Pi4 = (float) 0.785398;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='RAD2DEG']"
		[Register ("RAD2DEG")]
		public const float Rad2deg = (float) 57.295780;
	}

	[System.Obsolete ("Use the 'MathConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class MathConstantsConsts : MathConstants {

		private MathConstantsConsts ()
		{
		}
	}

}
