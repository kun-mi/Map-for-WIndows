namespace WindowsMap
{
    partial class routeUC
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
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtstartLat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstopLat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindRouteLatLng = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtstartAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstopaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStartLng = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStopLng = new Guna.UI2.WinForms.Guna2TextBox();
            this.routeByAddress = new Guna.UI2.WinForms.Guna2RadioButton();
            this.routeByLocation = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LatLngPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.addressPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFindRoute = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.LatLngPanel.SuspendLayout();
            this.addressPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(9, 4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(96, 20);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Start Address";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(9, 91);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(89, 20);
            this.bunifuLabel2.TabIndex = 0;
            this.bunifuLabel2.Text = "End Address";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtstartLat
            // 
            this.txtstartLat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstartLat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstartLat.AutoRoundedCorners = true;
            this.txtstartLat.BorderRadius = 17;
            this.txtstartLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstartLat.DefaultText = "";
            this.txtstartLat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstartLat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstartLat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstartLat.DisabledState.Parent = this.txtstartLat;
            this.txtstartLat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstartLat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstartLat.FocusedState.Parent = this.txtstartLat;
            this.txtstartLat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstartLat.ForeColor = System.Drawing.Color.Black;
            this.txtstartLat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstartLat.HoverState.Parent = this.txtstartLat;
            this.txtstartLat.Location = new System.Drawing.Point(8, 30);
            this.txtstartLat.Name = "txtstartLat";
            this.txtstartLat.PasswordChar = '\0';
            this.txtstartLat.PlaceholderText = "Latitude";
            this.txtstartLat.SelectedText = "";
            this.txtstartLat.ShadowDecoration.Parent = this.txtstartLat;
            this.txtstartLat.Size = new System.Drawing.Size(111, 36);
            this.txtstartLat.TabIndex = 1;
            // 
            // txtstopLat
            // 
            this.txtstopLat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstopLat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstopLat.AutoRoundedCorners = true;
            this.txtstopLat.BorderRadius = 17;
            this.txtstopLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstopLat.DefaultText = "";
            this.txtstopLat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstopLat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstopLat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstopLat.DisabledState.Parent = this.txtstopLat;
            this.txtstopLat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstopLat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstopLat.FocusedState.Parent = this.txtstopLat;
            this.txtstopLat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstopLat.ForeColor = System.Drawing.Color.Black;
            this.txtstopLat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstopLat.HoverState.Parent = this.txtstopLat;
            this.txtstopLat.Location = new System.Drawing.Point(8, 122);
            this.txtstopLat.Name = "txtstopLat";
            this.txtstopLat.PasswordChar = '\0';
            this.txtstopLat.PlaceholderText = "Latitude";
            this.txtstopLat.SelectedText = "";
            this.txtstopLat.ShadowDecoration.Parent = this.txtstopLat;
            this.txtstopLat.Size = new System.Drawing.Size(111, 36);
            this.txtstopLat.TabIndex = 3;
            // 
            // btnFindRouteLatLng
            // 
            this.btnFindRouteLatLng.Animated = true;
            this.btnFindRouteLatLng.AnimatedGIF = true;
            this.btnFindRouteLatLng.AutoRoundedCorners = true;
            this.btnFindRouteLatLng.BorderRadius = 16;
            this.btnFindRouteLatLng.CheckedState.Parent = this.btnFindRouteLatLng;
            this.btnFindRouteLatLng.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindRouteLatLng.CustomImages.Parent = this.btnFindRouteLatLng;
            this.btnFindRouteLatLng.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindRouteLatLng.ForeColor = System.Drawing.Color.White;
            this.btnFindRouteLatLng.HoverState.Parent = this.btnFindRouteLatLng;
            this.btnFindRouteLatLng.Location = new System.Drawing.Point(7, 182);
            this.btnFindRouteLatLng.Name = "btnFindRouteLatLng";
            this.btnFindRouteLatLng.ShadowDecoration.Parent = this.btnFindRouteLatLng;
            this.btnFindRouteLatLng.Size = new System.Drawing.Size(242, 35);
            this.btnFindRouteLatLng.TabIndex = 5;
            this.btnFindRouteLatLng.Text = "Find Route";
            this.btnFindRouteLatLng.Click += new System.EventHandler(this.BtnFindRouteLatLng_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(11, 13);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(96, 20);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "Start Address";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel4.Location = new System.Drawing.Point(11, 100);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(89, 20);
            this.bunifuLabel4.TabIndex = 0;
            this.bunifuLabel4.Text = "End Address";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtstartAddress
            // 
            this.txtstartAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstartAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstartAddress.AutoRoundedCorners = true;
            this.txtstartAddress.BorderRadius = 17;
            this.txtstartAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstartAddress.DefaultText = "";
            this.txtstartAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstartAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstartAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstartAddress.DisabledState.Parent = this.txtstartAddress;
            this.txtstartAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstartAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstartAddress.FocusedState.Parent = this.txtstartAddress;
            this.txtstartAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstartAddress.ForeColor = System.Drawing.Color.Black;
            this.txtstartAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstartAddress.HoverState.Parent = this.txtstartAddress;
            this.txtstartAddress.Location = new System.Drawing.Point(10, 39);
            this.txtstartAddress.Name = "txtstartAddress";
            this.txtstartAddress.PasswordChar = '\0';
            this.txtstartAddress.PlaceholderText = "Start Address";
            this.txtstartAddress.SelectedText = "";
            this.txtstartAddress.ShadowDecoration.Parent = this.txtstartAddress;
            this.txtstartAddress.Size = new System.Drawing.Size(242, 36);
            this.txtstartAddress.TabIndex = 1;
            // 
            // txtstopaddress
            // 
            this.txtstopaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstopaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstopaddress.AutoRoundedCorners = true;
            this.txtstopaddress.BorderRadius = 17;
            this.txtstopaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstopaddress.DefaultText = "";
            this.txtstopaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstopaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstopaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstopaddress.DisabledState.Parent = this.txtstopaddress;
            this.txtstopaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstopaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstopaddress.FocusedState.Parent = this.txtstopaddress;
            this.txtstopaddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstopaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstopaddress.HoverState.Parent = this.txtstopaddress;
            this.txtstopaddress.Location = new System.Drawing.Point(10, 131);
            this.txtstopaddress.Name = "txtstopaddress";
            this.txtstopaddress.PasswordChar = '\0';
            this.txtstopaddress.PlaceholderText = "End Address";
            this.txtstopaddress.SelectedText = "";
            this.txtstopaddress.ShadowDecoration.Parent = this.txtstopaddress;
            this.txtstopaddress.Size = new System.Drawing.Size(242, 36);
            this.txtstopaddress.TabIndex = 2;
            // 
            // txtStartLng
            // 
            this.txtStartLng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStartLng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtStartLng.AutoRoundedCorners = true;
            this.txtStartLng.BorderRadius = 17;
            this.txtStartLng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStartLng.DefaultText = "";
            this.txtStartLng.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStartLng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStartLng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartLng.DisabledState.Parent = this.txtStartLng;
            this.txtStartLng.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStartLng.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartLng.FocusedState.Parent = this.txtStartLng;
            this.txtStartLng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStartLng.ForeColor = System.Drawing.Color.Black;
            this.txtStartLng.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStartLng.HoverState.Parent = this.txtStartLng;
            this.txtStartLng.Location = new System.Drawing.Point(137, 30);
            this.txtStartLng.Name = "txtStartLng";
            this.txtStartLng.PasswordChar = '\0';
            this.txtStartLng.PlaceholderText = "Longitude";
            this.txtStartLng.SelectedText = "";
            this.txtStartLng.ShadowDecoration.Parent = this.txtStartLng;
            this.txtStartLng.Size = new System.Drawing.Size(111, 36);
            this.txtStartLng.TabIndex = 2;
            // 
            // txtStopLng
            // 
            this.txtStopLng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStopLng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtStopLng.AutoRoundedCorners = true;
            this.txtStopLng.BorderRadius = 17;
            this.txtStopLng.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStopLng.DefaultText = "";
            this.txtStopLng.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStopLng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStopLng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStopLng.DisabledState.Parent = this.txtStopLng;
            this.txtStopLng.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStopLng.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStopLng.FocusedState.Parent = this.txtStopLng;
            this.txtStopLng.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStopLng.ForeColor = System.Drawing.Color.Black;
            this.txtStopLng.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStopLng.HoverState.Parent = this.txtStopLng;
            this.txtStopLng.Location = new System.Drawing.Point(137, 122);
            this.txtStopLng.Name = "txtStopLng";
            this.txtStopLng.PasswordChar = '\0';
            this.txtStopLng.PlaceholderText = "Longitude";
            this.txtStopLng.SelectedText = "";
            this.txtStopLng.ShadowDecoration.Parent = this.txtStopLng;
            this.txtStopLng.Size = new System.Drawing.Size(111, 36);
            this.txtStopLng.TabIndex = 4;
            // 
            // routeByAddress
            // 
            this.routeByAddress.AutoSize = true;
            this.routeByAddress.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.routeByAddress.CheckedState.BorderThickness = 0;
            this.routeByAddress.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.routeByAddress.CheckedState.InnerColor = System.Drawing.Color.White;
            this.routeByAddress.CheckedState.InnerOffset = -4;
            this.routeByAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.routeByAddress.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.routeByAddress.ForeColor = System.Drawing.Color.White;
            this.routeByAddress.Location = new System.Drawing.Point(20, 289);
            this.routeByAddress.Name = "routeByAddress";
            this.routeByAddress.Size = new System.Drawing.Size(152, 22);
            this.routeByAddress.TabIndex = 4;
            this.routeByAddress.Text = "Search by Address";
            this.routeByAddress.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.routeByAddress.UncheckedState.BorderThickness = 2;
            this.routeByAddress.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.routeByAddress.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.routeByAddress.CheckedChanged += new System.EventHandler(this.RouteByAddress_CheckedChanged);
            // 
            // routeByLocation
            // 
            this.routeByLocation.AutoSize = true;
            this.routeByLocation.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.routeByLocation.CheckedState.BorderThickness = 0;
            this.routeByLocation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.routeByLocation.CheckedState.InnerColor = System.Drawing.Color.White;
            this.routeByLocation.CheckedState.InnerOffset = -4;
            this.routeByLocation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.routeByLocation.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold);
            this.routeByLocation.ForeColor = System.Drawing.Color.White;
            this.routeByLocation.Location = new System.Drawing.Point(16, 17);
            this.routeByLocation.Name = "routeByLocation";
            this.routeByLocation.Size = new System.Drawing.Size(233, 22);
            this.routeByLocation.TabIndex = 1;
            this.routeByLocation.Text = "Search by Latitude/Longitude";
            this.routeByLocation.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.routeByLocation.UncheckedState.BorderThickness = 2;
            this.routeByLocation.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.routeByLocation.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.routeByLocation.CheckedChanged += new System.EventHandler(this.RouteByLocation_CheckedChanged);
            // 
            // LatLngPanel
            // 
            this.LatLngPanel.Controls.Add(this.btnFindRouteLatLng);
            this.LatLngPanel.Controls.Add(this.txtStopLng);
            this.LatLngPanel.Controls.Add(this.txtstopLat);
            this.LatLngPanel.Controls.Add(this.txtStartLng);
            this.LatLngPanel.Controls.Add(this.txtstartLat);
            this.LatLngPanel.Controls.Add(this.bunifuLabel2);
            this.LatLngPanel.Controls.Add(this.bunifuLabel1);
            this.LatLngPanel.Enabled = false;
            this.LatLngPanel.Location = new System.Drawing.Point(6, 50);
            this.LatLngPanel.Name = "LatLngPanel";
            this.LatLngPanel.ShadowDecoration.Parent = this.LatLngPanel;
            this.LatLngPanel.Size = new System.Drawing.Size(270, 228);
            this.LatLngPanel.TabIndex = 5;
            this.LatLngPanel.Visible = false;
            // 
            // addressPanel
            // 
            this.addressPanel.Controls.Add(this.btnFindRoute);
            this.addressPanel.Controls.Add(this.txtstopaddress);
            this.addressPanel.Controls.Add(this.txtstartAddress);
            this.addressPanel.Controls.Add(this.bunifuLabel4);
            this.addressPanel.Controls.Add(this.bunifuLabel3);
            this.addressPanel.Enabled = false;
            this.addressPanel.Location = new System.Drawing.Point(5, 315);
            this.addressPanel.Name = "addressPanel";
            this.addressPanel.ShadowDecoration.Parent = this.addressPanel;
            this.addressPanel.Size = new System.Drawing.Size(270, 240);
            this.addressPanel.TabIndex = 6;
            this.addressPanel.Visible = false;
            // 
            // btnFindRoute
            // 
            this.btnFindRoute.Animated = true;
            this.btnFindRoute.AnimatedGIF = true;
            this.btnFindRoute.AutoRoundedCorners = true;
            this.btnFindRoute.BorderRadius = 17;
            this.btnFindRoute.CheckedState.Parent = this.btnFindRoute;
            this.btnFindRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindRoute.CustomImages.Parent = this.btnFindRoute;
            this.btnFindRoute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnFindRoute.ForeColor = System.Drawing.Color.White;
            this.btnFindRoute.HoverState.Parent = this.btnFindRoute;
            this.btnFindRoute.Location = new System.Drawing.Point(16, 189);
            this.btnFindRoute.Name = "btnFindRoute";
            this.btnFindRoute.ShadowDecoration.Parent = this.btnFindRoute;
            this.btnFindRoute.Size = new System.Drawing.Size(233, 36);
            this.btnFindRoute.TabIndex = 3;
            this.btnFindRoute.Text = "Find Route";
            this.btnFindRoute.Click += new System.EventHandler(this.BtnFindRoute_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.map);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(286, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(645, 581);
            this.guna2Panel1.TabIndex = 7;
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
            this.map.MaxZoom = 2;
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
            this.map.Zoom = 0D;
            // 
            // routeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.addressPanel);
            this.Controls.Add(this.LatLngPanel);
            this.Controls.Add(this.routeByLocation);
            this.Controls.Add(this.routeByAddress);
            this.Name = "routeUC";
            this.Size = new System.Drawing.Size(931, 581);
            this.Load += new System.EventHandler(this.RouteUC_Load);
            this.LatLngPanel.ResumeLayout(false);
            this.LatLngPanel.PerformLayout();
            this.addressPanel.ResumeLayout(false);
            this.addressPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtstartLat;
        private Guna.UI2.WinForms.Guna2TextBox txtstopLat;
        private Guna.UI2.WinForms.Guna2Button btnFindRouteLatLng;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtstartAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtstopaddress;
        private Guna.UI2.WinForms.Guna2TextBox txtStartLng;
        private Guna.UI2.WinForms.Guna2TextBox txtStopLng;
        private Guna.UI2.WinForms.Guna2RadioButton routeByAddress;
        private Guna.UI2.WinForms.Guna2RadioButton routeByLocation;
        private Guna.UI2.WinForms.Guna2Panel LatLngPanel;
        private Guna.UI2.WinForms.Guna2Panel addressPanel;
        private Guna.UI2.WinForms.Guna2Button btnFindRoute;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private GMap.NET.WindowsForms.GMapControl map;
    }
}
