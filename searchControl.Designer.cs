namespace WindowsMap
{
    partial class searchControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchyName = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtLng = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLat = new Guna.UI2.WinForms.Guna2TextBox();
            this.latLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnLatLng = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoadByAddress = new Guna.UI2.WinForms.Guna2Button();
            this.LatLngPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addressPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.curren = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.currentLat = new Bunifu.UI.WinForms.BunifuLabel();
            this.currentLng = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnSearchByLatLng = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.LatLngPanel.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchyName
            // 
            this.btnSearchyName.AutoSize = true;
            this.btnSearchyName.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSearchyName.CheckedState.BorderThickness = 1;
            this.btnSearchyName.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSearchyName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnSearchyName.CheckedState.InnerOffset = -4;
            this.btnSearchyName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchyName.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchyName.ForeColor = System.Drawing.Color.White;
            this.btnSearchyName.Location = new System.Drawing.Point(8, 276);
            this.btnSearchyName.Name = "btnSearchyName";
            this.btnSearchyName.Size = new System.Drawing.Size(153, 22);
            this.btnSearchyName.TabIndex = 2;
            this.btnSearchyName.Text = "Search by Address";
            this.btnSearchyName.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.btnSearchyName.UncheckedState.BorderThickness = 2;
            this.btnSearchyName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSearchyName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnSearchyName.CheckedChanged += new System.EventHandler(this.BtnSearchyName_CheckedChanged);
            // 
            // txtLng
            // 
            this.txtLng.Animated = true;
            this.txtLng.AutoRoundedCorners = true;
            this.txtLng.BorderRadius = 17;
            this.txtLng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLng.DefaultText = "";
            this.txtLng.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLng.DisabledState.Parent = this.txtLng;
            this.txtLng.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLng.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLng.FocusedState.Parent = this.txtLng;
            this.txtLng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLng.ForeColor = System.Drawing.Color.Black;
            this.txtLng.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLng.HoverState.Parent = this.txtLng;
            this.txtLng.Location = new System.Drawing.Point(8, 24);
            this.txtLng.Name = "txtLng";
            this.txtLng.PasswordChar = '\0';
            this.txtLng.PlaceholderText = "Enter Longitude";
            this.txtLng.SelectedText = "";
            this.txtLng.ShadowDecoration.Parent = this.txtLng;
            this.txtLng.Size = new System.Drawing.Size(220, 36);
            this.txtLng.TabIndex = 2;
            this.txtLng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLng_KeyDown);
            // 
            // txtLat
            // 
            this.txtLat.AutoRoundedCorners = true;
            this.txtLat.BorderRadius = 17;
            this.txtLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLat.DefaultText = "";
            this.txtLat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLat.DisabledState.Parent = this.txtLat;
            this.txtLat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLat.FocusedState.Parent = this.txtLat;
            this.txtLat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLat.ForeColor = System.Drawing.Color.Black;
            this.txtLat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLat.HoverState.Parent = this.txtLat;
            this.txtLat.Location = new System.Drawing.Point(8, 89);
            this.txtLat.Name = "txtLat";
            this.txtLat.PasswordChar = '\0';
            this.txtLat.PlaceholderText = "Enter Latitude";
            this.txtLat.SelectedText = "";
            this.txtLat.ShadowDecoration.Parent = this.txtLat;
            this.txtLat.Size = new System.Drawing.Size(220, 36);
            this.txtLat.TabIndex = 3;
            this.txtLat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLat_KeyDown);
            // 
            // latLabel
            // 
            this.latLabel.AutoEllipsis = false;
            this.latLabel.CursorType = null;
            this.latLabel.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latLabel.ForeColor = System.Drawing.Color.White;
            this.latLabel.Location = new System.Drawing.Point(12, 67);
            this.latLabel.Name = "latLabel";
            this.latLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.latLabel.Size = new System.Drawing.Size(61, 20);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "Latitude";
            this.latLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.latLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(9, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(73, 20);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Longitude";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnLatLng
            // 
            this.btnLatLng.Animated = true;
            this.btnLatLng.AutoRoundedCorners = true;
            this.btnLatLng.BorderRadius = 17;
            this.btnLatLng.CheckedState.Parent = this.btnLatLng;
            this.btnLatLng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLatLng.CustomImages.Parent = this.btnLatLng;
            this.btnLatLng.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatLng.ForeColor = System.Drawing.Color.White;
            this.btnLatLng.HoverState.Parent = this.btnLatLng;
            this.btnLatLng.Location = new System.Drawing.Point(8, 142);
            this.btnLatLng.Name = "btnLatLng";
            this.btnLatLng.ShadowDecoration.Parent = this.btnLatLng;
            this.btnLatLng.Size = new System.Drawing.Size(220, 36);
            this.btnLatLng.TabIndex = 5;
            this.btnLatLng.Tag = "4";
            this.btnLatLng.Text = "Load Location";
            this.btnLatLng.Click += new System.EventHandler(this.BtnLatLng_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.BorderRadius = 17;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(10, 13);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Enter Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(220, 36);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAddress_KeyDown);
            // 
            // btnLoadByAddress
            // 
            this.btnLoadByAddress.Animated = true;
            this.btnLoadByAddress.AnimatedGIF = true;
            this.btnLoadByAddress.AutoRoundedCorners = true;
            this.btnLoadByAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadByAddress.BorderRadius = 17;
            this.btnLoadByAddress.CheckedState.Parent = this.btnLoadByAddress;
            this.btnLoadByAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadByAddress.CustomImages.Parent = this.btnLoadByAddress;
            this.btnLoadByAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadByAddress.ForeColor = System.Drawing.Color.White;
            this.btnLoadByAddress.HoverState.Parent = this.btnLoadByAddress;
            this.btnLoadByAddress.Location = new System.Drawing.Point(12, 76);
            this.btnLoadByAddress.Name = "btnLoadByAddress";
            this.btnLoadByAddress.ShadowDecoration.Parent = this.btnLoadByAddress;
            this.btnLoadByAddress.Size = new System.Drawing.Size(220, 36);
            this.btnLoadByAddress.TabIndex = 7;
            this.btnLoadByAddress.Text = "Load Address";
            this.btnLoadByAddress.Click += new System.EventHandler(this.BtnLoadByAddress_Click);
            // 
            // LatLngPanel
            // 
            this.LatLngPanel.AutoRoundedCorners = true;
            this.LatLngPanel.BorderRadius = 100;
            this.LatLngPanel.Controls.Add(this.btnLatLng);
            this.LatLngPanel.Controls.Add(this.latLabel);
            this.LatLngPanel.Controls.Add(this.txtLat);
            this.LatLngPanel.Controls.Add(this.txtLng);
            this.LatLngPanel.Controls.Add(this.bunifuLabel1);
            this.LatLngPanel.Enabled = false;
            this.LatLngPanel.Location = new System.Drawing.Point(14, 44);
            this.LatLngPanel.Name = "LatLngPanel";
            this.LatLngPanel.ShadowDecoration.Parent = this.LatLngPanel;
            this.LatLngPanel.Size = new System.Drawing.Size(252, 203);
            this.LatLngPanel.TabIndex = 8;
            this.LatLngPanel.Visible = false;
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.btnLoadByAddress);
            this.addressPanel.Controls.Add(this.txtAddress);
            this.addressPanel.Enabled = false;
            this.addressPanel.Location = new System.Drawing.Point(10, 304);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.ShadowDecoration.Parent = this.addressPanel;
            this.addressPanel.Size = new System.Drawing.Size(237, 133);
            this.addressPanel.TabIndex = 9;
            this.addressPanel.Visible = false;
            // 
            // curren
            // 
            this.curren.AutoEllipsis = false;
            this.curren.CursorType = null;
            this.curren.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curren.ForeColor = System.Drawing.Color.White;
            this.curren.Location = new System.Drawing.Point(9, 464);
            this.curren.Name = "curren";
            this.curren.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.curren.Size = new System.Drawing.Size(122, 20);
            this.curren.TabIndex = 10;
            this.curren.Text = "Current Location";
            this.curren.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.curren.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(7, 496);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(28, 20);
            this.bunifuLabel2.TabIndex = 11;
            this.bunifuLabel2.Text = "Lat:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(7, 521);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(32, 20);
            this.bunifuLabel3.TabIndex = 11;
            this.bunifuLabel3.Text = "Lng:";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // currentLat
            // 
            this.currentLat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentLat.AutoEllipsis = false;
            this.currentLat.CursorType = null;
            this.currentLat.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLat.ForeColor = System.Drawing.Color.White;
            this.currentLat.Location = new System.Drawing.Point(52, 499);
            this.currentLat.Name = "currentLat";
            this.currentLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentLat.Size = new System.Drawing.Size(42, 20);
            this.currentLat.TabIndex = 11;
            this.currentLat.Text = "30.252";
            this.currentLat.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentLat.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // currentLng
            // 
            this.currentLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentLng.AutoEllipsis = false;
            this.currentLng.CursorType = null;
            this.currentLng.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLng.ForeColor = System.Drawing.Color.White;
            this.currentLng.Location = new System.Drawing.Point(52, 524);
            this.currentLng.Name = "currentLng";
            this.currentLng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentLng.Size = new System.Drawing.Size(42, 20);
            this.currentLng.TabIndex = 11;
            this.currentLng.Text = "30.252";
            this.currentLng.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentLng.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BtnSearchByLatLng
            // 
            this.BtnSearchByLatLng.AutoSize = true;
            this.BtnSearchByLatLng.CheckedState.BorderColor = System.Drawing.Color.White;
            this.BtnSearchByLatLng.CheckedState.BorderThickness = 0;
            this.BtnSearchByLatLng.CheckedState.FillColor = System.Drawing.Color.White;
            this.BtnSearchByLatLng.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BtnSearchByLatLng.CheckedState.InnerOffset = -4;
            this.BtnSearchByLatLng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchByLatLng.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSearchByLatLng.ForeColor = System.Drawing.Color.White;
            this.BtnSearchByLatLng.Location = new System.Drawing.Point(17, 12);
            this.BtnSearchByLatLng.Name = "BtnSearchByLatLng";
            this.BtnSearchByLatLng.Size = new System.Drawing.Size(234, 22);
            this.BtnSearchByLatLng.TabIndex = 12;
            this.BtnSearchByLatLng.Text = "Search by Latitude/Longitude";
            this.BtnSearchByLatLng.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BtnSearchByLatLng.UncheckedState.BorderThickness = 2;
            this.BtnSearchByLatLng.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.BtnSearchByLatLng.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.BtnSearchByLatLng.CheckedChanged += new System.EventHandler(this.BtnSaerchByLatLng_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.map);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(286, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(645, 581);
            this.guna2Panel1.TabIndex = 13;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 30;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(645, 581);
            this.map.TabIndex = 0;
            this.map.Zoom = 11D;
            this.map.OnMapDrag += new GMap.NET.MapDrag(this.Map_OnMapDrag);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDoubleClick);
            // 
            // searchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.BtnSearchByLatLng);
            this.Controls.Add(this.currentLng);
            this.Controls.Add(this.currentLat);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.curren);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.LatLngPanel);
            this.Controls.Add(this.btnSearchyName);
            this.Name = "searchControl";
            this.Size = new System.Drawing.Size(931, 581);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            this.LatLngPanel.ResumeLayout(false);
            this.LatLngPanel.PerformLayout();
            this.addressPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton btnSearchyName;
        private Guna.UI2.WinForms.Guna2TextBox txtLng;
        private Guna.UI2.WinForms.Guna2TextBox txtLat;
        private Bunifu.UI.WinForms.BunifuLabel latLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2Button btnLatLng;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2Button btnLoadByAddress;
        private Guna.UI2.WinForms.Guna2Panel LatLngPanel;
        private Guna.UI2.WinForms.Guna2Panel addressPanel;
        private Bunifu.UI.WinForms.BunifuLabel curren;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel currentLat;
        private Bunifu.UI.WinForms.BunifuLabel currentLng;
        private Guna.UI2.WinForms.Guna2RadioButton BtnSearchByLatLng;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GMap.NET.WindowsForms.GMapControl map;
    }
}
