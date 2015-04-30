using System;
using Java.Lang;

namespace Osmdroid.Views
{
    public partial class MapView
    {
        public void SetMinZoomLevel(Integer zoomLevel)
        {
			SetMinZoomLevel(new Integer(zoomLevel));
			SetMinZoomLevel(zoomLevel);
        }

        public void SetMaxZoomLevel(int zoomLevel)
        {
		//	SetMaxZoomLevel(new Integer(zoomLevel));
			SetMaxZoomLevel(zoomLevel);
        }

    }
}