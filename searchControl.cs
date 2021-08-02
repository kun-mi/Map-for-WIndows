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
    public partial class searchControl : UserControl
    {
        public searchControl()
        {
            InitializeComponent();
        }

        users user = new users();

        private void SearchControl_Load(object sender, EventArgs e)
        {
            map.ShowCenter = false;
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(9.072264, 7.491302);
            //map.SetPositionByKeywords("Abuja, Nigeria");
            map.Zoom = 13;
            PointLatLng point = map.Position;
            currentLat.Text = point.Lat.ToString();
            currentLng.Text = point.Lng.ToString();

        }

        
        private void BtnSearchyName_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSearchyName.Checked)
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

        private void BtnSaerchByLatLng_CheckedChanged(object sender, EventArgs e)
        {

            if (BtnSearchByLatLng.Checked)
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
        
        private void BtnLatLng_Click(object sender, EventArgs e)
        {
            if (txtLat.Text.Trim() != "" && txtLng.Text.Trim() != "")
            {
                RemoveOverlays();
                double Lat = Convert.ToDouble(txtLat.Text);
                double Lng = Convert.ToDouble(txtLng.Text);
                map.Position = new PointLatLng(Lat, Lng);
                zoomMap();
                PointLatLng point = new PointLatLng(Lat, Lng);
                map.Overlays.Add(user.AddMarker(point, GMarkerGoogleType.lightblue));
            }
            else
            {
                MessageBox.Show(owner: btnLatLng, "One or more required fields are empty!", "Error Loading Location");
            }
        }

        private void BtnLoadByAddress_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text.Trim() != "")
            {
                try
                {
                    RemoveOverlays();
                    map.SetPositionByKeywords(txtAddress.Text.ToString());
                    zoomMap();

                    PointLatLng point = map.Position;
                    map.Overlays.Add(user.AddMarker(point, GMarkerGoogleType.lightblue));
                    currentLat.Text = point.Lat.ToString();
                    currentLng.Text = point.Lng.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show(owner: btnLoadByAddress, "Location not found!", "Error Loading Location");
                }
            }
            else
            {
                MessageBox.Show(owner: btnLoadByAddress, "Address cannot be empty!", "Error Loading Location");
                txtAddress.Focus();

            }
        }

        private void Map_OnMapDrag()
        {
            PointLatLng point = map.Position;
            currentLat.Text = point.Lat.ToString();
            currentLng.Text = point.Lng.ToString();
        }

        private void RemoveOverlays()
        {
            while (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(0);
                map.Refresh();
            }
        }

        private void TxtLat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtLat.Text.Trim() != "" && txtLng.Text.Trim() != "")
                {
                    RemoveOverlays();
                    double Lat = Convert.ToDouble(txtLat.Text);
                    double Lng = Convert.ToDouble(txtLng.Text);
                    map.Position = new PointLatLng(Lat, Lng);
                    zoomMap();
                    PointLatLng point = new PointLatLng(Lat, Lng);
                    map.Overlays.Add(user.AddMarker(point, GMarkerGoogleType.lightblue));
                }
                else
                {
                    MessageBox.Show(owner: btnLatLng, "One or more required fields are empty!", "Error Loading Location");
                }
            }
        }

        private void TxtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtAddress.Text.Trim() != "")
                {
                    try
                    {
                        RemoveOverlays();
                        map.SetPositionByKeywords(txtAddress.Text.ToString());
                        zoomMap();

                        PointLatLng point = map.Position;
                        map.Overlays.Add(user.AddMarker(point, GMarkerGoogleType.lightblue));

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(owner: btnLoadByAddress, "Location not found!", "Error Loading Location");
                    }
                }
                else
                {
                    MessageBox.Show(owner: btnLoadByAddress, "Address cannot be empty!", "Error Loading Location");
                    txtAddress.Focus();

                }
            }
        }

        private void TxtLng_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtLat.Focus();
            }
        }

        private void Map_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void zoomMap()
        {
            map.Zoom = 13;
        }
        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoveOverlays();
            var point = map.FromLocalToLatLng(e.X, e.Y);
            currentLat.Text = point.Lat.ToString();
            currentLng.Text = point.Lng.ToString();
            zoomMap();
            map.Overlays.Add(user.AddMarker(point, GMarkerGoogleType.lightblue));
        }
    }
}
