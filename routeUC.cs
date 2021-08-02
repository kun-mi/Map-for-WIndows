using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class routeUC : UserControl
    {
        private List<PointLatLng> _points;
        private List<string> _locations;

        public routeUC()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _locations = new List<string>();
        }

        private void RouteUC_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(9.073264, 7.491402);
            map.ShowCenter = false;
            map.DragButton = MouseButtons.Left;
            map.Zoom = 13;
            
        }

        private void BtnFindRouteLatLng_Click(object sender, EventArgs e)
        {
            RemoveOverlays();
            _points.Add(new PointLatLng(Convert.ToDouble(txtstartLat.Text), Convert.ToDouble(txtStartLng.Text)));
            _points.Add(new PointLatLng(Convert.ToDouble(txtstopLat.Text), Convert.ToDouble(txtStopLng.Text)));

            //YOU NEED TO ADD YOUR GOOGLEMAP API KEY FOR ROUTES TO WORK. REPLACE "YOUR API KEY" WITH YOURS.....
            GoogleMapProvider.Instance.ApiKey = ""; // Routes won't work without API key
            var Route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);
            var parseRoute = new GMapRoute(Route.Points, "Route");
            var layRoutes = new GMapOverlay("layRoutes");
            layRoutes.Routes.Add(parseRoute);
            map.Overlays.Add(layRoutes);
            map.Zoom = 10;
        }

        private void RemoveOverlays()
        {
            while (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        private void RouteByLocation_CheckedChanged(object sender, EventArgs e)
        {
            if (routeByLocation.Checked)
            {
                LatLngPanel.Enabled = true;
                LatLngPanel.Visible = true;
            }
            else
            {
                LatLngPanel.Enabled = false;
                LatLngPanel.Visible = false;
            }
        }

        private void RouteByAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (routeByAddress.Checked)
            {
                addressPanel.Enabled = true;
                addressPanel.Visible = true;
            }
            else
            {
                addressPanel.Enabled = false;
                addressPanel.Visible = false;
            }
        }

        private void BtnFindRoute_Click(object sender, EventArgs e)
        {
            RemoveOverlays();
            _locations.Add(txtstartAddress.Text.ToString());
            _locations.Add(txtstopaddress.Text.ToString());

            //YOU NEED TO ADD YOUR GOOGLEMAP API KEY FOR ROUTES TO WORK. REPLACE "YOUR API KEY" WITH YOURS.....
            GoogleMapProvider.Instance.ApiKey = ""; // Routes won't work without API key
            var route = GoogleMapProvider.Instance.GetRoute(_locations[0], _locations[1], false, false, 15);
            var parseRoute = new GMapRoute(route.Points, "Route");
            var layRoute = new GMapOverlay("layRoute");
            layRoute.Routes.Add(parseRoute);
            map.Overlays.Add(layRoute);
        }
    }
}
