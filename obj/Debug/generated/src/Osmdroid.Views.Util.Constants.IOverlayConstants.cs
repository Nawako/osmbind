using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Util.Constants {

	[Register ("org/osmdroid/views/util/constants/OverlayConstants")]
	public abstract class OverlayConstants {

		internal OverlayConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='DEBUGMODE']"
		[Register ("DEBUGMODE")]
		public const bool Debugmode = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='DEFAULT_ZOOMLEVEL_MINIMAP_DIFFERENCE']"
		[Register ("DEFAULT_ZOOMLEVEL_MINIMAP_DIFFERENCE")]
		public const int DefaultZoomlevelMinimapDifference = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='OverlayConstants']/field[@name='NOT_SET']"
		[Register ("NOT_SET")]
		public const int NotSet = (int) -2147483648;
	}

	[System.Obsolete ("Use the 'OverlayConstants' type. This type will be removed in Mono for Android 5.0.")]
	public abstract class OverlayConstantsConsts : OverlayConstants {

		private OverlayConstantsConsts ()
		{
		}
	}

}
