using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace WindowsMap
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchPanel.Visible = true;
            searchPanel.Enabled = true;
            searchPanel.BringToFront();
            route.Visible = false;
            route.Enabled = false;
            route.SendToBack();

        }

        private void Guna2ImageButton1_Click(object sender, EventArgs e)
        {
            route.Visible = true;
            route.Enabled = true;
            route.BringToFront();
            searchPanel.Visible = false;
            searchPanel.Enabled = false;
            searchPanel.SendToBack();
            
        }
    }
}
