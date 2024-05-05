namespace RailwayReservationUI
{
    partial class TicketBooking
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBooking));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnllTicketBookingToolbar = new Panel();
            btnTrain = new Button();
            btnClose = new Button();
            btnRoute = new Button();
            btnStation = new Button();
            btnFind = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            pnlFormMain = new Panel();
            pnlStationForm = new Panel();
            btnSaveStation = new Button();
            panel2 = new Panel();
            lnlHeadingStation = new Label();
            txtCity = new TextBox();
            txtStation = new TextBox();
            lblResetForm = new LinkLabel();
            pnlTrainsForm = new Panel();
            cmbRoute = new ComboBox();
            btnSaveTrain = new Button();
            panel3 = new Panel();
            lblTrainHeading = new Label();
            txtNoOfCoaches = new TextBox();
            txtDescription = new TextBox();
            txtTrainName = new TextBox();
            pnlRouteForm = new Panel();
            cmbDestination = new ComboBox();
            cmbDeparture = new ComboBox();
            btnSaveRoute = new Button();
            pnlHeading = new Panel();
            lblHeading = new Label();
            txtFare = new TextBox();
            txtTotalDistance = new TextBox();
            txtRouteName = new TextBox();
            dataGridView = new DataGridView();
            pnlSeach = new Panel();
            btnGo = new Button();
            lblSearch = new Label();
            txtSearchText = new TextBox();
            pnllTicketBookingToolbar.SuspendLayout();
            pnlFormMain.SuspendLayout();
            pnlStationForm.SuspendLayout();
            panel2.SuspendLayout();
            pnlTrainsForm.SuspendLayout();
            panel3.SuspendLayout();
            pnlRouteForm.SuspendLayout();
            pnlHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            pnlSeach.SuspendLayout();
            SuspendLayout();
            // 
            // pnllTicketBookingToolbar
            // 
            pnllTicketBookingToolbar.BackColor = Color.FromArgb(34, 43, 65);
            pnllTicketBookingToolbar.Controls.Add(btnTrain);
            pnllTicketBookingToolbar.Controls.Add(btnClose);
            pnllTicketBookingToolbar.Controls.Add(btnRoute);
            pnllTicketBookingToolbar.Controls.Add(btnStation);
            pnllTicketBookingToolbar.Controls.Add(btnFind);
            pnllTicketBookingToolbar.Controls.Add(btnDelete);
            pnllTicketBookingToolbar.Controls.Add(btnUpdate);
            pnllTicketBookingToolbar.Controls.Add(btnNew);
            pnllTicketBookingToolbar.Dock = DockStyle.Top;
            pnllTicketBookingToolbar.Location = new Point(0, 0);
            pnllTicketBookingToolbar.Name = "pnllTicketBookingToolbar";
            pnllTicketBookingToolbar.Size = new Size(1203, 82);
            pnllTicketBookingToolbar.TabIndex = 2;
            // 
            // btnTrain
            // 
            btnTrain.BackColor = Color.FromArgb(34, 43, 65);
            btnTrain.FlatAppearance.BorderSize = 0;
            btnTrain.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnTrain.FlatStyle = FlatStyle.Flat;
            btnTrain.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrain.ForeColor = SystemColors.Control;
            btnTrain.Image = (Image)resources.GetObject("btnTrain.Image");
            btnTrain.ImageAlign = ContentAlignment.TopCenter;
            btnTrain.Location = new Point(877, 1);
            btnTrain.Name = "btnTrain";
            btnTrain.Padding = new Padding(0, 7, 0, 7);
            btnTrain.Size = new Size(140, 81);
            btnTrain.TabIndex = 2;
            btnTrain.Text = "Manage Trains";
            btnTrain.TextAlign = ContentAlignment.BottomCenter;
            btnTrain.UseVisualStyleBackColor = false;
            btnTrain.Click += btnTrain_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(34, 43, 65);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.TopCenter;
            btnClose.Location = new Point(1051, 1);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(0, 7, 0, 7);
            btnClose.Size = new Size(140, 81);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.BottomCenter;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnRoute
            // 
            btnRoute.BackColor = Color.FromArgb(34, 43, 65);
            btnRoute.FlatAppearance.BorderSize = 0;
            btnRoute.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnRoute.FlatStyle = FlatStyle.Flat;
            btnRoute.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoute.ForeColor = SystemColors.Control;
            btnRoute.Image = (Image)resources.GetObject("btnRoute.Image");
            btnRoute.ImageAlign = ContentAlignment.TopCenter;
            btnRoute.Location = new Point(730, 1);
            btnRoute.Name = "btnRoute";
            btnRoute.Padding = new Padding(0, 7, 0, 7);
            btnRoute.Size = new Size(140, 81);
            btnRoute.TabIndex = 1;
            btnRoute.Text = "Manage Routes";
            btnRoute.TextAlign = ContentAlignment.BottomCenter;
            btnRoute.UseVisualStyleBackColor = false;
            btnRoute.Click += btnRoutes_Click;
            // 
            // btnStation
            // 
            btnStation.BackColor = Color.FromArgb(34, 43, 65);
            btnStation.FlatAppearance.BorderSize = 0;
            btnStation.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnStation.FlatStyle = FlatStyle.Flat;
            btnStation.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStation.ForeColor = SystemColors.Control;
            btnStation.Image = (Image)resources.GetObject("btnStation.Image");
            btnStation.ImageAlign = ContentAlignment.TopCenter;
            btnStation.Location = new Point(583, 1);
            btnStation.Name = "btnStation";
            btnStation.Padding = new Padding(0, 7, 0, 7);
            btnStation.Size = new Size(140, 81);
            btnStation.TabIndex = 1;
            btnStation.Text = "Manage Stations";
            btnStation.TextAlign = ContentAlignment.BottomCenter;
            btnStation.UseVisualStyleBackColor = false;
            btnStation.Click += btnStation_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(34, 43, 65);
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFind.ForeColor = SystemColors.Control;
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.ImageAlign = ContentAlignment.TopCenter;
            btnFind.Location = new Point(418, 1);
            btnFind.Name = "btnFind";
            btnFind.Padding = new Padding(0, 7, 0, 7);
            btnFind.Size = new Size(140, 81);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.TextAlign = ContentAlignment.BottomCenter;
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(34, 43, 65);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.TopCenter;
            btnDelete.Location = new Point(279, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(0, 7, 0, 7);
            btnDelete.Size = new Size(140, 81);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(34, 43, 65);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnUpdate.Location = new Point(140, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(0, 7, 0, 7);
            btnUpdate.Size = new Size(140, 81);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(34, 43, 65);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = SystemColors.Control;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageAlign = ContentAlignment.TopCenter;
            btnNew.Location = new Point(1, 1);
            btnNew.Name = "btnNew";
            btnNew.Padding = new Padding(0, 7, 0, 7);
            btnNew.Size = new Size(140, 81);
            btnNew.TabIndex = 1;
            btnNew.Text = "Add";
            btnNew.TextAlign = ContentAlignment.BottomCenter;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // pnlFormMain
            // 
            pnlFormMain.Controls.Add(pnlStationForm);
            pnlFormMain.Controls.Add(lblResetForm);
            pnlFormMain.Controls.Add(pnlTrainsForm);
            pnlFormMain.Controls.Add(pnlRouteForm);
            pnlFormMain.Dock = DockStyle.Left;
            pnlFormMain.Location = new Point(0, 82);
            pnlFormMain.Name = "pnlFormMain";
            pnlFormMain.Size = new Size(517, 752);
            pnlFormMain.TabIndex = 3;
            // 
            // pnlStationForm
            // 
            pnlStationForm.BackColor = SystemColors.ActiveCaptionText;
            pnlStationForm.Controls.Add(btnSaveStation);
            pnlStationForm.Controls.Add(panel2);
            pnlStationForm.Controls.Add(txtCity);
            pnlStationForm.Controls.Add(txtStation);
            pnlStationForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlStationForm.Location = new Point(21, 451);
            pnlStationForm.Name = "pnlStationForm";
            pnlStationForm.Size = new Size(472, 289);
            pnlStationForm.TabIndex = 32;
            pnlStationForm.Visible = false;
            // 
            // btnSaveStation
            // 
            btnSaveStation.BackColor = Color.FromArgb(34, 43, 65);
            btnSaveStation.FlatAppearance.BorderSize = 0;
            btnSaveStation.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSaveStation.FlatStyle = FlatStyle.Flat;
            btnSaveStation.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveStation.ForeColor = SystemColors.Control;
            btnSaveStation.Image = (Image)resources.GetObject("btnSaveStation.Image");
            btnSaveStation.ImageAlign = ContentAlignment.TopCenter;
            btnSaveStation.Location = new Point(0, 209);
            btnSaveStation.Name = "btnSaveStation";
            btnSaveStation.Padding = new Padding(0, 7, 0, 7);
            btnSaveStation.Size = new Size(472, 81);
            btnSaveStation.TabIndex = 31;
            btnSaveStation.Text = "Save Station Details";
            btnSaveStation.TextAlign = ContentAlignment.BottomCenter;
            btnSaveStation.UseVisualStyleBackColor = false;
            btnSaveStation.Click += btnSaveStation_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(lnlHeadingStation);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 49);
            panel2.TabIndex = 1;
            // 
            // lnlHeadingStation
            // 
            lnlHeadingStation.AutoSize = true;
            lnlHeadingStation.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lnlHeadingStation.ForeColor = SystemColors.ButtonFace;
            lnlHeadingStation.Location = new Point(139, 7);
            lnlHeadingStation.Margin = new Padding(3, 3, 3, 0);
            lnlHeadingStation.Name = "lnlHeadingStation";
            lnlHeadingStation.Size = new Size(227, 32);
            lnlHeadingStation.TabIndex = 0;
            lnlHeadingStation.Text = "Station Information";
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.InactiveCaptionText;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.ForeColor = SystemColors.HighlightText;
            txtCity.Location = new Point(29, 131);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Enter City Name";
            txtCity.Size = new Size(433, 28);
            txtCity.TabIndex = 12;
            txtCity.WordWrap = false;
            // 
            // txtStation
            // 
            txtStation.BackColor = SystemColors.InactiveCaptionText;
            txtStation.BorderStyle = BorderStyle.FixedSingle;
            txtStation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStation.ForeColor = SystemColors.HighlightText;
            txtStation.Location = new Point(29, 90);
            txtStation.Multiline = true;
            txtStation.Name = "txtStation";
            txtStation.PlaceholderText = "Enter Station Name";
            txtStation.Size = new Size(433, 28);
            txtStation.TabIndex = 11;
            txtStation.WordWrap = false;
            // 
            // lblResetForm
            // 
            lblResetForm.ActiveLinkColor = SystemColors.InactiveCaption;
            lblResetForm.AutoSize = true;
            lblResetForm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetForm.ForeColor = SystemColors.ActiveCaption;
            lblResetForm.LinkColor = SystemColors.InactiveBorder;
            lblResetForm.Location = new Point(416, 411);
            lblResetForm.Name = "lblResetForm";
            lblResetForm.Size = new Size(77, 17);
            lblResetForm.TabIndex = 29;
            lblResetForm.TabStop = true;
            lblResetForm.Text = "Reset Form";
            lblResetForm.Visible = false;
            lblResetForm.LinkClicked += lblResetForm_LinkClicked;
            // 
            // pnlTrainsForm
            // 
            pnlTrainsForm.BackColor = SystemColors.ActiveCaptionText;
            pnlTrainsForm.Controls.Add(cmbRoute);
            pnlTrainsForm.Controls.Add(btnSaveTrain);
            pnlTrainsForm.Controls.Add(panel3);
            pnlTrainsForm.Controls.Add(txtNoOfCoaches);
            pnlTrainsForm.Controls.Add(txtDescription);
            pnlTrainsForm.Controls.Add(txtTrainName);
            pnlTrainsForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlTrainsForm.Location = new Point(24, 196);
            pnlTrainsForm.Name = "pnlTrainsForm";
            pnlTrainsForm.Size = new Size(472, 395);
            pnlTrainsForm.TabIndex = 1;
            pnlTrainsForm.Visible = false;
            // 
            // cmbRoute
            // 
            cmbRoute.BackColor = SystemColors.ActiveCaptionText;
            cmbRoute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoute.ForeColor = SystemColors.HighlightText;
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(29, 252);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(206, 28);
            cmbRoute.TabIndex = 32;
            cmbRoute.Text = "Select Route";
            // 
            // btnSaveTrain
            // 
            btnSaveTrain.BackColor = Color.FromArgb(34, 43, 65);
            btnSaveTrain.FlatAppearance.BorderSize = 0;
            btnSaveTrain.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSaveTrain.FlatStyle = FlatStyle.Flat;
            btnSaveTrain.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveTrain.ForeColor = SystemColors.Control;
            btnSaveTrain.Image = (Image)resources.GetObject("btnSaveTrain.Image");
            btnSaveTrain.ImageAlign = ContentAlignment.TopCenter;
            btnSaveTrain.Location = new Point(-1, 314);
            btnSaveTrain.Name = "btnSaveTrain";
            btnSaveTrain.Padding = new Padding(0, 7, 0, 7);
            btnSaveTrain.Size = new Size(472, 81);
            btnSaveTrain.TabIndex = 31;
            btnSaveTrain.Text = "Save Train Details";
            btnSaveTrain.TextAlign = ContentAlignment.BottomCenter;
            btnSaveTrain.UseVisualStyleBackColor = false;
            btnSaveTrain.Click += btnSaveTrain_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Controls.Add(lblTrainHeading);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 49);
            panel3.TabIndex = 1;
            // 
            // lblTrainHeading
            // 
            lblTrainHeading.AutoSize = true;
            lblTrainHeading.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrainHeading.ForeColor = SystemColors.ButtonFace;
            lblTrainHeading.Location = new Point(139, 7);
            lblTrainHeading.Margin = new Padding(3, 3, 3, 0);
            lblTrainHeading.Name = "lblTrainHeading";
            lblTrainHeading.Size = new Size(203, 32);
            lblTrainHeading.TabIndex = 0;
            lblTrainHeading.Text = "Train Information";
            // 
            // txtNoOfCoaches
            // 
            txtNoOfCoaches.BackColor = SystemColors.InactiveCaptionText;
            txtNoOfCoaches.BorderStyle = BorderStyle.FixedSingle;
            txtNoOfCoaches.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoOfCoaches.ForeColor = SystemColors.HighlightText;
            txtNoOfCoaches.Location = new Point(29, 213);
            txtNoOfCoaches.Multiline = true;
            txtNoOfCoaches.Name = "txtNoOfCoaches";
            txtNoOfCoaches.PlaceholderText = "No Of Coaches";
            txtNoOfCoaches.Size = new Size(206, 28);
            txtNoOfCoaches.TabIndex = 12;
            txtNoOfCoaches.WordWrap = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.InactiveCaptionText;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.ForeColor = SystemColors.HighlightText;
            txtDescription.Location = new Point(29, 115);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(433, 86);
            txtDescription.TabIndex = 11;
            // 
            // txtTrainName
            // 
            txtTrainName.BackColor = SystemColors.InactiveCaptionText;
            txtTrainName.BorderStyle = BorderStyle.FixedSingle;
            txtTrainName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTrainName.ForeColor = SystemColors.HighlightText;
            txtTrainName.Location = new Point(29, 75);
            txtTrainName.Multiline = true;
            txtTrainName.Name = "txtTrainName";
            txtTrainName.PlaceholderText = "Train Name";
            txtTrainName.Size = new Size(433, 28);
            txtTrainName.TabIndex = 11;
            txtTrainName.WordWrap = false;
            // 
            // pnlRouteForm
            // 
            pnlRouteForm.BackColor = SystemColors.ActiveCaptionText;
            pnlRouteForm.Controls.Add(cmbDestination);
            pnlRouteForm.Controls.Add(cmbDeparture);
            pnlRouteForm.Controls.Add(btnSaveRoute);
            pnlRouteForm.Controls.Add(pnlHeading);
            pnlRouteForm.Controls.Add(txtFare);
            pnlRouteForm.Controls.Add(txtTotalDistance);
            pnlRouteForm.Controls.Add(txtRouteName);
            pnlRouteForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlRouteForm.Location = new Point(23, 28);
            pnlRouteForm.Name = "pnlRouteForm";
            pnlRouteForm.Size = new Size(472, 289);
            pnlRouteForm.TabIndex = 1;
            pnlRouteForm.Visible = false;
            // 
            // cmbDestination
            // 
            cmbDestination.BackColor = SystemColors.ActiveCaptionText;
            cmbDestination.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDestination.ForeColor = SystemColors.HighlightText;
            cmbDestination.FormattingEnabled = true;
            cmbDestination.Location = new Point(256, 115);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(206, 28);
            cmbDestination.TabIndex = 32;
            cmbDestination.Text = "Select Destination";
            // 
            // cmbDeparture
            // 
            cmbDeparture.BackColor = SystemColors.ActiveCaptionText;
            cmbDeparture.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDeparture.ForeColor = SystemColors.HighlightText;
            cmbDeparture.FormattingEnabled = true;
            cmbDeparture.Location = new Point(29, 113);
            cmbDeparture.Name = "cmbDeparture";
            cmbDeparture.Size = new Size(206, 28);
            cmbDeparture.TabIndex = 32;
            cmbDeparture.Text = "Select Departure";
            // 
            // btnSaveRoute
            // 
            btnSaveRoute.BackColor = Color.FromArgb(34, 43, 65);
            btnSaveRoute.FlatAppearance.BorderSize = 0;
            btnSaveRoute.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSaveRoute.FlatStyle = FlatStyle.Flat;
            btnSaveRoute.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveRoute.ForeColor = SystemColors.Control;
            btnSaveRoute.Image = (Image)resources.GetObject("btnSaveRoute.Image");
            btnSaveRoute.ImageAlign = ContentAlignment.TopCenter;
            btnSaveRoute.Location = new Point(0, 209);
            btnSaveRoute.Name = "btnSaveRoute";
            btnSaveRoute.Padding = new Padding(0, 7, 0, 7);
            btnSaveRoute.Size = new Size(472, 81);
            btnSaveRoute.TabIndex = 31;
            btnSaveRoute.Text = "Save Route Details";
            btnSaveRoute.TextAlign = ContentAlignment.BottomCenter;
            btnSaveRoute.UseVisualStyleBackColor = false;
            btnSaveRoute.Click += btnSaveRoute_Click;
            // 
            // pnlHeading
            // 
            pnlHeading.BackColor = Color.FromArgb(24, 30, 54);
            pnlHeading.Controls.Add(lblHeading);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(472, 49);
            pnlHeading.TabIndex = 1;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = SystemColors.ButtonFace;
            lblHeading.Location = new Point(139, 7);
            lblHeading.Margin = new Padding(3, 3, 3, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(214, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Route Information";
            // 
            // txtFare
            // 
            txtFare.BackColor = SystemColors.InactiveCaptionText;
            txtFare.BorderStyle = BorderStyle.FixedSingle;
            txtFare.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFare.ForeColor = SystemColors.HighlightText;
            txtFare.Location = new Point(257, 156);
            txtFare.Multiline = true;
            txtFare.Name = "txtFare";
            txtFare.PlaceholderText = "Fare in Rs.";
            txtFare.Size = new Size(206, 28);
            txtFare.TabIndex = 12;
            txtFare.WordWrap = false;
            // 
            // txtTotalDistance
            // 
            txtTotalDistance.BackColor = SystemColors.InactiveCaptionText;
            txtTotalDistance.BorderStyle = BorderStyle.FixedSingle;
            txtTotalDistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalDistance.ForeColor = SystemColors.HighlightText;
            txtTotalDistance.Location = new Point(29, 156);
            txtTotalDistance.Multiline = true;
            txtTotalDistance.Name = "txtTotalDistance";
            txtTotalDistance.PlaceholderText = "Total Distance in KM";
            txtTotalDistance.Size = new Size(206, 28);
            txtTotalDistance.TabIndex = 12;
            txtTotalDistance.WordWrap = false;
            // 
            // txtRouteName
            // 
            txtRouteName.BackColor = SystemColors.InactiveCaptionText;
            txtRouteName.BorderStyle = BorderStyle.FixedSingle;
            txtRouteName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRouteName.ForeColor = SystemColors.HighlightText;
            txtRouteName.Location = new Point(29, 75);
            txtRouteName.Multiline = true;
            txtRouteName.Name = "txtRouteName";
            txtRouteName.PlaceholderText = "Route Name";
            txtRouteName.Size = new Size(433, 28);
            txtRouteName.TabIndex = 11;
            txtRouteName.WordWrap = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.GridColor = SystemColors.InactiveCaption;
            dataGridView.Location = new Point(537, 160);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(643, 622);
            dataGridView.TabIndex = 4;
            dataGridView.Visible = false;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            // 
            // pnlSeach
            // 
            pnlSeach.Controls.Add(btnGo);
            pnlSeach.Controls.Add(lblSearch);
            pnlSeach.Controls.Add(txtSearchText);
            pnlSeach.Location = new Point(531, 95);
            pnlSeach.Name = "pnlSeach";
            pnlSeach.Size = new Size(654, 51);
            pnlSeach.TabIndex = 5;
            pnlSeach.Visible = false;
            // 
            // btnGo
            // 
            btnGo.BackColor = Color.FromArgb(34, 43, 65);
            btnGo.FlatAppearance.BorderSize = 0;
            btnGo.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnGo.FlatStyle = FlatStyle.Flat;
            btnGo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGo.ForeColor = SystemColors.HighlightText;
            btnGo.Location = new Point(501, 12);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(40, 25);
            btnGo.TabIndex = 13;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSearch.ForeColor = SystemColors.HighlightText;
            lblSearch.Location = new Point(92, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(98, 17);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search Criteria:";
            // 
            // txtSearchText
            // 
            txtSearchText.BackColor = SystemColors.InactiveCaptionText;
            txtSearchText.BorderStyle = BorderStyle.FixedSingle;
            txtSearchText.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchText.ForeColor = SystemColors.HighlightText;
            txtSearchText.Location = new Point(199, 12);
            txtSearchText.Multiline = true;
            txtSearchText.Name = "txtSearchText";
            txtSearchText.PlaceholderText = "Search Criteria";
            txtSearchText.Size = new Size(314, 25);
            txtSearchText.TabIndex = 11;
            txtSearchText.WordWrap = false;
            // 
            // TicketBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1203, 834);
            Controls.Add(pnlSeach);
            Controls.Add(dataGridView);
            Controls.Add(pnlFormMain);
            Controls.Add(pnllTicketBookingToolbar);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Booking";
            Load += TicketBooking_Load;
            pnllTicketBookingToolbar.ResumeLayout(false);
            pnlFormMain.ResumeLayout(false);
            pnlFormMain.PerformLayout();
            pnlStationForm.ResumeLayout(false);
            pnlStationForm.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlTrainsForm.ResumeLayout(false);
            pnlTrainsForm.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlRouteForm.ResumeLayout(false);
            pnlRouteForm.PerformLayout();
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            pnlSeach.ResumeLayout(false);
            pnlSeach.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnllTicketBookingToolbar;
        private Button btnClose;
        private Button btnRoute;
        private Button btnStation;
        private Button btnFind;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private Panel pnlFormMain;
        private LinkLabel lblResetForm;
        private Panel pnlRouteForm;
        private Panel pnlHeading;
        private Label lblHeading;
        private TextBox txtTotalDistance;
        private TextBox txtRouteName;
        private Button btnSaveRoute;
        private Panel pnlStationForm;
        private Button btnSaveStation;
        private Panel panel2;
        private Label lnlHeadingStation;
        private TextBox txtCity;
        private TextBox txtStation;
        private ComboBox cmbDestination;
        private ComboBox cmbDeparture;
        private Button btnTrain;
        private Panel pnlTrainsForm;
        private ComboBox cmbRoute;
        private Button btnSaveTrain;
        private Panel panel3;
        private Label lblTrainHeading;
        private TextBox txtNoOfCoaches;
        private TextBox txtTrainName;
        private TextBox txtDescription;
        private DataGridView dataGridView;
        private Panel pnlSeach;
        private Button btnGo;
        private Label lblSearch;
        private TextBox txtSearchText;
        private TextBox txtFare;
    }
}