using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace WindowsMap
{
    class users
    {
        public GMapOverlay AddMarker(PointLatLng point, GMarkerGoogleType MarkerType)
        {

            var marker = new GMarkerGoogle(point, MarkerType);
            var overlays = new GMapOverlay("overlays");
            overlays.Markers.Add(marker);
            var address = GetAddress(point);

            //YOU NEED TO ADD YOUR GOOGLEMAP API KEY FOR ADDRESSES TO WORK. REPLACE "YOUR API KEY" WITH YOURS.....
            GoogleMapProvider.Instance.ApiKey = ""; // Won't work without API key
            if (address != null)
            {
                marker.ToolTipText = address[0].ToString();
            }
            else
            {
                marker.ToolTipText = "Error loading address";
            }
            
            var toolTip = new GMapToolTip(marker);
            toolTip.Fill = new SolidBrush(Color.DarkBlue);
            toolTip.Foreground = new SolidBrush(Color.White);
            toolTip.Offset = new Point(50, 0);
            marker.ToolTip = toolTip;


            return overlays;
            

        }

        private List<String> GetAddress(PointLatLng point)
        {
            List<Placemark> placemarks = null;
            var statuscode = GMapProviders.GoogleMap.GetPlacemarks(point, out placemarks);
            if (statuscode == GeoCoderStatusCode.OK && placemarks != null)
            {
                List<string> addresses = new List<string>();
                foreach (var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            else
            {
                return null;
            }
            
        }
    }
}
