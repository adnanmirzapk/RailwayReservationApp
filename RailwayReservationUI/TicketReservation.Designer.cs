namespace RailwayReservationUI
{
    partial class TicketReservation
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketReservation));
            pnlTicketReservationForm = new Panel();
            pnlPassengerInformation = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbTravelClass = new ComboBox();
            txtNoOfInfants = new TextBox();
            txtNoOfChildrens = new TextBox();
            txtNoOfAdults = new TextBox();
            txtPassengerCNIC = new TextBox();
            txtPassengerName = new TextBox();
            lblInfants = new Label();
            lblChildrens = new Label();
            lblInfantsFareInfo = new Label();
            lblChildrensFareInfo = new Label();
            lblAdultsFareInfo = new Label();
            lblAdults = new Label();
            pnlGridViewSearchedTrains = new Panel();
            dataGridViewSearchedTrains = new DataGridView();
            pnlSearchTrain = new Panel();
            dateTimePicker = new DateTimePicker();
            btnSearchTrain = new Button();
            txtDateOfDeparture = new TextBox();
            cmbTo = new ComboBox();
            cmbFrom = new ComboBox();
            pnlHeading = new Panel();
            lblHeading = new Label();
            pnlButtons = new Panel();
            btnNext = new Button();
            btnPrevious = new Button();
            pnlBookingInfoTrainInfo = new Panel();
            lblDescriptionValue = new TextBox();
            lblDepartureTimeValue = new Label();
            lblArrivalTimeValue = new Label();
            lblDistanceValue = new Label();
            lblDepartureTime = new Label();
            lblArrivalTime = new Label();
            lblDistance = new Label();
            lblFareAmount = new Label();
            lblCurrency = new Label();
            lblFare = new Label();
            lblOn = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            lblToStationName = new Label();
            lblFromStationName = new Label();
            lblBookingDate = new Label();
            lblTrainName = new Label();
            lblBookingHeading = new Label();
            pnlBookingInfoPassengerInfo = new Panel();
            lblPassengerCNICValue = new Label();
            label21 = new Label();
            lblGrandTotalAmount = new Label();
            lblInfantsTotalAmount = new Label();
            label10 = new Label();
            lblChildrensTotalAmount = new Label();
            lblInfantsFare = new Label();
            lblAdultsTotalAmount = new Label();
            lblChildrensFare = new Label();
            lblAdultsFare = new Label();
            label5 = new Label();
            label19 = new Label();
            label15 = new Label();
            label9 = new Label();
            label14 = new Label();
            lblInfantsValue = new Label();
            label8 = new Label();
            label13 = new Label();
            lblChildrensValue = new Label();
            label20 = new Label();
            label7 = new Label();
            label17 = new Label();
            lblAdultsValue = new Label();
            label12 = new Label();
            label16 = new Label();
            label18 = new Label();
            label6 = new Label();
            label11 = new Label();
            label4 = new Label();
            lblPassengerCNIC = new Label();
            lblClassValue = new Label();
            lblPassengerNameValue = new Label();
            label22 = new Label();
            lblPassengerName = new Label();
            txtStepCounter = new TextBox();
            pnlTermsAndBookButton = new Panel();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            btnConfirmBooking = new Button();
            pnlTicketReservationForm.SuspendLayout();
            pnlPassengerInformation.SuspendLayout();
            pnlGridViewSearchedTrains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchedTrains).BeginInit();
            pnlSearchTrain.SuspendLayout();
            pnlHeading.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlBookingInfoTrainInfo.SuspendLayout();
            pnlBookingInfoPassengerInfo.SuspendLayout();
            pnlTermsAndBookButton.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTicketReservationForm
            // 
            pnlTicketReservationForm.Controls.Add(pnlPassengerInformation);
            pnlTicketReservationForm.Controls.Add(pnlGridViewSearchedTrains);
            pnlTicketReservationForm.Controls.Add(pnlSearchTrain);
            pnlTicketReservationForm.Controls.Add(pnlHeading);
            pnlTicketReservationForm.Location = new Point(12, 12);
            pnlTicketReservationForm.Name = "pnlTicketReservationForm";
            pnlTicketReservationForm.Size = new Size(548, 659);
            pnlTicketReservationForm.TabIndex = 0;
            // 
            // pnlPassengerInformation
            // 
            pnlPassengerInformation.BackColor = SystemColors.ActiveCaptionText;
            pnlPassengerInformation.Controls.Add(label3);
            pnlPassengerInformation.Controls.Add(label2);
            pnlPassengerInformation.Controls.Add(label1);
            pnlPassengerInformation.Controls.Add(cmbTravelClass);
            pnlPassengerInformation.Controls.Add(txtNoOfInfants);
            pnlPassengerInformation.Controls.Add(txtNoOfChildrens);
            pnlPassengerInformation.Controls.Add(txtNoOfAdults);
            pnlPassengerInformation.Controls.Add(txtPassengerCNIC);
            pnlPassengerInformation.Controls.Add(txtPassengerName);
            pnlPassengerInformation.Controls.Add(lblInfants);
            pnlPassengerInformation.Controls.Add(lblChildrens);
            pnlPassengerInformation.Controls.Add(lblInfantsFareInfo);
            pnlPassengerInformation.Controls.Add(lblChildrensFareInfo);
            pnlPassengerInformation.Controls.Add(lblAdultsFareInfo);
            pnlPassengerInformation.Controls.Add(lblAdults);
            pnlPassengerInformation.Location = new Point(5, 263);
            pnlPassengerInformation.Name = "pnlPassengerInformation";
            pnlPassengerInformation.Size = new Size(527, 365);
            pnlPassengerInformation.TabIndex = 4;
            pnlPassengerInformation.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientActiveCaption;
            label3.Location = new Point(13, 217);
            label3.Name = "label3";
            label3.Size = new Size(485, 17);
            label3.TabIndex = 17;
            label3.Text = "* Extra cherges will be charged for any extra facility arranged for the passenger.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(13, 194);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 17;
            label2.Text = "* Infants are free.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(13, 171);
            label1.Name = "label1";
            label1.Size = new Size(296, 17);
            label1.TabIndex = 17;
            label1.Text = "* Children will be charged 50% of the adult fare.";
            // 
            // cmbTravelClass
            // 
            cmbTravelClass.BackColor = SystemColors.ActiveCaptionText;
            cmbTravelClass.FlatStyle = FlatStyle.Flat;
            cmbTravelClass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTravelClass.ForeColor = SystemColors.HighlightText;
            cmbTravelClass.FormattingEnabled = true;
            cmbTravelClass.Items.AddRange(new object[] { "Economy", "AC", "AC Parlour", "Business" });
            cmbTravelClass.Location = new Point(13, 119);
            cmbTravelClass.Name = "cmbTravelClass";
            cmbTravelClass.Size = new Size(250, 29);
            cmbTravelClass.TabIndex = 0;
            cmbTravelClass.Text = "Select Class";
            cmbTravelClass.SelectedIndexChanged += cmbTravelClass_SelectedIndexChanged;
            // 
            // txtNoOfInfants
            // 
            txtNoOfInfants.BackColor = SystemColors.InactiveCaptionText;
            txtNoOfInfants.BorderStyle = BorderStyle.FixedSingle;
            txtNoOfInfants.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoOfInfants.ForeColor = SystemColors.HighlightText;
            txtNoOfInfants.Location = new Point(354, 298);
            txtNoOfInfants.Multiline = true;
            txtNoOfInfants.Name = "txtNoOfInfants";
            txtNoOfInfants.PlaceholderText = "0";
            txtNoOfInfants.Size = new Size(127, 31);
            txtNoOfInfants.TabIndex = 16;
            txtNoOfInfants.WordWrap = false;
            // 
            // txtNoOfChildrens
            // 
            txtNoOfChildrens.BackColor = SystemColors.InactiveCaptionText;
            txtNoOfChildrens.BorderStyle = BorderStyle.FixedSingle;
            txtNoOfChildrens.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoOfChildrens.ForeColor = SystemColors.HighlightText;
            txtNoOfChildrens.Location = new Point(185, 298);
            txtNoOfChildrens.Multiline = true;
            txtNoOfChildrens.Name = "txtNoOfChildrens";
            txtNoOfChildrens.PlaceholderText = "0";
            txtNoOfChildrens.Size = new Size(127, 31);
            txtNoOfChildrens.TabIndex = 16;
            txtNoOfChildrens.WordWrap = false;
            // 
            // txtNoOfAdults
            // 
            txtNoOfAdults.BackColor = SystemColors.InactiveCaptionText;
            txtNoOfAdults.BorderStyle = BorderStyle.FixedSingle;
            txtNoOfAdults.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtNoOfAdults.ForeColor = SystemColors.HighlightText;
            txtNoOfAdults.Location = new Point(13, 298);
            txtNoOfAdults.Multiline = true;
            txtNoOfAdults.Name = "txtNoOfAdults";
            txtNoOfAdults.PlaceholderText = "0";
            txtNoOfAdults.Size = new Size(127, 31);
            txtNoOfAdults.TabIndex = 16;
            txtNoOfAdults.WordWrap = false;
            // 
            // txtPassengerCNIC
            // 
            txtPassengerCNIC.BackColor = SystemColors.InactiveCaptionText;
            txtPassengerCNIC.BorderStyle = BorderStyle.FixedSingle;
            txtPassengerCNIC.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassengerCNIC.ForeColor = SystemColors.HighlightText;
            txtPassengerCNIC.Location = new Point(13, 70);
            txtPassengerCNIC.Multiline = true;
            txtPassengerCNIC.Name = "txtPassengerCNIC";
            txtPassengerCNIC.PlaceholderText = "CNIC";
            txtPassengerCNIC.Size = new Size(250, 31);
            txtPassengerCNIC.TabIndex = 16;
            txtPassengerCNIC.WordWrap = false;
            // 
            // txtPassengerName
            // 
            txtPassengerName.BackColor = SystemColors.InactiveCaptionText;
            txtPassengerName.BorderStyle = BorderStyle.FixedSingle;
            txtPassengerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassengerName.ForeColor = SystemColors.HighlightText;
            txtPassengerName.Location = new Point(13, 24);
            txtPassengerName.Multiline = true;
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.PlaceholderText = "Passenger Name";
            txtPassengerName.Size = new Size(501, 31);
            txtPassengerName.TabIndex = 16;
            txtPassengerName.WordWrap = false;
            // 
            // lblInfants
            // 
            lblInfants.AutoSize = true;
            lblInfants.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfants.Location = new Point(348, 270);
            lblInfants.Name = "lblInfants";
            lblInfants.Size = new Size(52, 19);
            lblInfants.TabIndex = 1;
            lblInfants.Text = "Infants";
            // 
            // lblChildrens
            // 
            lblChildrens.AutoSize = true;
            lblChildrens.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildrens.Location = new Point(179, 270);
            lblChildrens.Name = "lblChildrens";
            lblChildrens.Size = new Size(68, 19);
            lblChildrens.TabIndex = 1;
            lblChildrens.Text = "Childrens";
            // 
            // lblInfantsFareInfo
            // 
            lblInfantsFareInfo.AutoSize = true;
            lblInfantsFareInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfantsFareInfo.Location = new Point(354, 332);
            lblInfantsFareInfo.Name = "lblInfantsFareInfo";
            lblInfantsFareInfo.Size = new Size(17, 19);
            lblInfantsFareInfo.TabIndex = 1;
            lblInfantsFareInfo.Text = "0";
            // 
            // lblChildrensFareInfo
            // 
            lblChildrensFareInfo.AutoSize = true;
            lblChildrensFareInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildrensFareInfo.Location = new Point(185, 332);
            lblChildrensFareInfo.Name = "lblChildrensFareInfo";
            lblChildrensFareInfo.Size = new Size(17, 19);
            lblChildrensFareInfo.TabIndex = 1;
            lblChildrensFareInfo.Text = "0";
            // 
            // lblAdultsFareInfo
            // 
            lblAdultsFareInfo.AutoSize = true;
            lblAdultsFareInfo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdultsFareInfo.Location = new Point(7, 332);
            lblAdultsFareInfo.Name = "lblAdultsFareInfo";
            lblAdultsFareInfo.Size = new Size(17, 19);
            lblAdultsFareInfo.TabIndex = 1;
            lblAdultsFareInfo.Text = "0";
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdults.Location = new Point(7, 270);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(49, 19);
            lblAdults.TabIndex = 1;
            lblAdults.Text = "Adults";
            // 
            // pnlGridViewSearchedTrains
            // 
            pnlGridViewSearchedTrains.Controls.Add(dataGridViewSearchedTrains);
            pnlGridViewSearchedTrains.Location = new Point(5, 273);
            pnlGridViewSearchedTrains.Name = "pnlGridViewSearchedTrains";
            pnlGridViewSearchedTrains.Size = new Size(533, 371);
            pnlGridViewSearchedTrains.TabIndex = 2;
            pnlGridViewSearchedTrains.Visible = false;
            // 
            // dataGridViewSearchedTrains
            // 
            dataGridViewSearchedTrains.AllowUserToAddRows = false;
            dataGridViewSearchedTrains.AllowUserToDeleteRows = false;
            dataGridViewSearchedTrains.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSearchedTrains.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridViewSearchedTrains.BorderStyle = BorderStyle.None;
            dataGridViewSearchedTrains.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSearchedTrains.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSearchedTrains.Location = new Point(3, 3);
            dataGridViewSearchedTrains.Name = "dataGridViewSearchedTrains";
            dataGridViewSearchedTrains.RowTemplate.Height = 25;
            dataGridViewSearchedTrains.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearchedTrains.Size = new Size(527, 365);
            dataGridViewSearchedTrains.TabIndex = 0;
            dataGridViewSearchedTrains.CellFormatting += dataGridViewSearchedTrains_CellFormatting;
            // 
            // pnlSearchTrain
            // 
            pnlSearchTrain.BackColor = SystemColors.ActiveCaptionText;
            pnlSearchTrain.Controls.Add(dateTimePicker);
            pnlSearchTrain.Controls.Add(btnSearchTrain);
            pnlSearchTrain.Controls.Add(txtDateOfDeparture);
            pnlSearchTrain.Controls.Add(cmbTo);
            pnlSearchTrain.Controls.Add(cmbFrom);
            pnlSearchTrain.Location = new Point(5, 94);
            pnlSearchTrain.Name = "pnlSearchTrain";
            pnlSearchTrain.Size = new Size(533, 163);
            pnlSearchTrain.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            dateTimePicker.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dateTimePicker.CalendarTitleForeColor = SystemColors.HighlightText;
            dateTimePicker.Location = new Point(225, 54);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(16, 23);
            dateTimePicker.TabIndex = 15;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // btnSearchTrain
            // 
            btnSearchTrain.BackColor = Color.FromArgb(34, 43, 65);
            btnSearchTrain.FlatAppearance.BorderSize = 0;
            btnSearchTrain.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSearchTrain.FlatStyle = FlatStyle.Flat;
            btnSearchTrain.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchTrain.ForeColor = SystemColors.GradientActiveCaption;
            btnSearchTrain.Image = (Image)resources.GetObject("btnSearchTrain.Image");
            btnSearchTrain.Location = new Point(0, 108);
            btnSearchTrain.Name = "btnSearchTrain";
            btnSearchTrain.Padding = new Padding(125, 0, 15, 0);
            btnSearchTrain.Size = new Size(533, 55);
            btnSearchTrain.TabIndex = 0;
            btnSearchTrain.Text = " Search Trains";
            btnSearchTrain.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearchTrain.UseVisualStyleBackColor = false;
            btnSearchTrain.Click += btnSearchTrain_Click;
            // 
            // txtDateOfDeparture
            // 
            txtDateOfDeparture.BackColor = SystemColors.InactiveCaptionText;
            txtDateOfDeparture.BorderStyle = BorderStyle.FixedSingle;
            txtDateOfDeparture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateOfDeparture.ForeColor = SystemColors.HighlightText;
            txtDateOfDeparture.Location = new Point(3, 54);
            txtDateOfDeparture.Multiline = true;
            txtDateOfDeparture.Name = "txtDateOfDeparture";
            txtDateOfDeparture.PlaceholderText = "Select Departure date";
            txtDateOfDeparture.Size = new Size(226, 23);
            txtDateOfDeparture.TabIndex = 16;
            txtDateOfDeparture.WordWrap = false;
            // 
            // cmbTo
            // 
            cmbTo.BackColor = SystemColors.ActiveCaptionText;
            cmbTo.FlatStyle = FlatStyle.Flat;
            cmbTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTo.ForeColor = SystemColors.HighlightText;
            cmbTo.FormattingEnabled = true;
            cmbTo.Location = new Point(291, 6);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(239, 29);
            cmbTo.TabIndex = 0;
            cmbTo.Text = "TO";
            // 
            // cmbFrom
            // 
            cmbFrom.BackColor = SystemColors.ActiveCaptionText;
            cmbFrom.FlatStyle = FlatStyle.Flat;
            cmbFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFrom.ForeColor = SystemColors.HighlightText;
            cmbFrom.FormattingEnabled = true;
            cmbFrom.Location = new Point(3, 6);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(239, 29);
            cmbFrom.TabIndex = 0;
            cmbFrom.Text = "FROM ";
            // 
            // pnlHeading
            // 
            pnlHeading.Controls.Add(lblHeading);
            pnlHeading.Dock = DockStyle.Top;
            pnlHeading.Location = new Point(0, 0);
            pnlHeading.Name = "pnlHeading";
            pnlHeading.Size = new Size(548, 71);
            pnlHeading.TabIndex = 0;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(83, 12);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(378, 45);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Ticket Reservation Form ";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnNext);
            pnlButtons.Controls.Add(btnPrevious);
            pnlButtons.Location = new Point(12, 677);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(548, 100);
            pnlButtons.TabIndex = 1;
            pnlButtons.Visible = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(34, 43, 65);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.GradientActiveCaption;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageAlign = ContentAlignment.MiddleRight;
            btnNext.Location = new Point(351, 16);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(32, 0, 32, 0);
            btnNext.Size = new Size(184, 68);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.TextAlign = ContentAlignment.MiddleLeft;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(34, 43, 65);
            btnPrevious.Enabled = false;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrevious.ForeColor = SystemColors.GradientActiveCaption;
            btnPrevious.Image = (Image)resources.GetObject("btnPrevious.Image");
            btnPrevious.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrevious.Location = new Point(5, 16);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Padding = new Padding(15, 0, 15, 0);
            btnPrevious.Size = new Size(184, 68);
            btnPrevious.TabIndex = 0;
            btnPrevious.Text = "Previous";
            btnPrevious.TextAlign = ContentAlignment.MiddleRight;
            btnPrevious.UseMnemonic = false;
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // pnlBookingInfoTrainInfo
            // 
            pnlBookingInfoTrainInfo.BackColor = Color.FromArgb(34, 43, 65);
            pnlBookingInfoTrainInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingInfoTrainInfo.Controls.Add(lblDescriptionValue);
            pnlBookingInfoTrainInfo.Controls.Add(lblDepartureTimeValue);
            pnlBookingInfoTrainInfo.Controls.Add(lblArrivalTimeValue);
            pnlBookingInfoTrainInfo.Controls.Add(lblDistanceValue);
            pnlBookingInfoTrainInfo.Controls.Add(lblDepartureTime);
            pnlBookingInfoTrainInfo.Controls.Add(lblArrivalTime);
            pnlBookingInfoTrainInfo.Controls.Add(lblDistance);
            pnlBookingInfoTrainInfo.Controls.Add(lblFareAmount);
            pnlBookingInfoTrainInfo.Controls.Add(lblCurrency);
            pnlBookingInfoTrainInfo.Controls.Add(lblFare);
            pnlBookingInfoTrainInfo.Controls.Add(lblOn);
            pnlBookingInfoTrainInfo.Controls.Add(lblTo);
            pnlBookingInfoTrainInfo.Controls.Add(lblFrom);
            pnlBookingInfoTrainInfo.Controls.Add(lblToStationName);
            pnlBookingInfoTrainInfo.Controls.Add(lblFromStationName);
            pnlBookingInfoTrainInfo.Controls.Add(lblBookingDate);
            pnlBookingInfoTrainInfo.Controls.Add(lblTrainName);
            pnlBookingInfoTrainInfo.Location = new Point(585, 69);
            pnlBookingInfoTrainInfo.Name = "pnlBookingInfoTrainInfo";
            pnlBookingInfoTrainInfo.Size = new Size(563, 243);
            pnlBookingInfoTrainInfo.TabIndex = 2;
            pnlBookingInfoTrainInfo.Visible = false;
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.BackColor = Color.FromArgb(34, 43, 65);
            lblDescriptionValue.BorderStyle = BorderStyle.None;
            lblDescriptionValue.ForeColor = SystemColors.GradientActiveCaption;
            lblDescriptionValue.Location = new Point(36, 44);
            lblDescriptionValue.Multiline = true;
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new Size(497, 45);
            lblDescriptionValue.TabIndex = 2;
            // 
            // lblDepartureTimeValue
            // 
            lblDepartureTimeValue.AutoSize = true;
            lblDepartureTimeValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartureTimeValue.ForeColor = SystemColors.GradientActiveCaption;
            lblDepartureTimeValue.Location = new Point(479, 96);
            lblDepartureTimeValue.Name = "lblDepartureTimeValue";
            lblDepartureTimeValue.Size = new Size(54, 21);
            lblDepartureTimeValue.TabIndex = 1;
            lblDepartureTimeValue.Text = " 07:00";
            // 
            // lblArrivalTimeValue
            // 
            lblArrivalTimeValue.AutoSize = true;
            lblArrivalTimeValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArrivalTimeValue.ForeColor = SystemColors.GradientActiveCaption;
            lblArrivalTimeValue.Location = new Point(479, 128);
            lblArrivalTimeValue.Name = "lblArrivalTimeValue";
            lblArrivalTimeValue.Size = new Size(54, 21);
            lblArrivalTimeValue.TabIndex = 1;
            lblArrivalTimeValue.Text = " 08:00";
            // 
            // lblDistanceValue
            // 
            lblDistanceValue.AutoSize = true;
            lblDistanceValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDistanceValue.ForeColor = SystemColors.GradientActiveCaption;
            lblDistanceValue.Location = new Point(495, 197);
            lblDistanceValue.Name = "lblDistanceValue";
            lblDistanceValue.Size = new Size(38, 21);
            lblDistanceValue.TabIndex = 1;
            lblDistanceValue.Text = " 100";
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepartureTime.Location = new Point(366, 96);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new Size(84, 21);
            lblDepartureTime.TabIndex = 1;
            lblDepartureTime.Text = "Dep. Time";
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblArrivalTime.Location = new Point(366, 128);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(97, 21);
            lblArrivalTime.TabIndex = 1;
            lblArrivalTime.Text = "Arrival Time";
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDistance.Location = new Point(366, 198);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(108, 21);
            lblDistance.TabIndex = 1;
            lblDistance.Text = "Distance (km)";
            // 
            // lblFareAmount
            // 
            lblFareAmount.AutoSize = true;
            lblFareAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFareAmount.ForeColor = SystemColors.GradientActiveCaption;
            lblFareAmount.Location = new Point(118, 197);
            lblFareAmount.Name = "lblFareAmount";
            lblFareAmount.Size = new Size(34, 21);
            lblFareAmount.TabIndex = 1;
            lblFareAmount.Text = "100";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrency.ForeColor = SystemColors.GradientActiveCaption;
            lblCurrency.Location = new Point(96, 197);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(31, 21);
            lblCurrency.TabIndex = 1;
            lblCurrency.Text = "Rs.";
            // 
            // lblFare
            // 
            lblFare.AutoSize = true;
            lblFare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFare.Location = new Point(35, 197);
            lblFare.Name = "lblFare";
            lblFare.Size = new Size(40, 21);
            lblFare.TabIndex = 1;
            lblFare.Text = "Fare";
            // 
            // lblOn
            // 
            lblOn.AutoSize = true;
            lblOn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOn.Location = new Point(35, 165);
            lblOn.Name = "lblOn";
            lblOn.Size = new Size(31, 21);
            lblOn.TabIndex = 1;
            lblOn.Text = "On";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTo.Location = new Point(35, 128);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(30, 21);
            lblTo.TabIndex = 1;
            lblTo.Text = "TO";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrom.Location = new Point(35, 96);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(55, 21);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "FROM";
            // 
            // lblToStationName
            // 
            lblToStationName.AutoSize = true;
            lblToStationName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblToStationName.ForeColor = SystemColors.GradientActiveCaption;
            lblToStationName.Location = new Point(96, 128);
            lblToStationName.Name = "lblToStationName";
            lblToStationName.Size = new Size(109, 21);
            lblToStationName.TabIndex = 0;
            lblToStationName.Text = "Station Name";
            // 
            // lblFromStationName
            // 
            lblFromStationName.AutoSize = true;
            lblFromStationName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFromStationName.ForeColor = SystemColors.GradientActiveCaption;
            lblFromStationName.Location = new Point(96, 96);
            lblFromStationName.Name = "lblFromStationName";
            lblFromStationName.Size = new Size(109, 21);
            lblFromStationName.TabIndex = 0;
            lblFromStationName.Text = "Station Name";
            // 
            // lblBookingDate
            // 
            lblBookingDate.AutoSize = true;
            lblBookingDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookingDate.ForeColor = SystemColors.GradientActiveCaption;
            lblBookingDate.Location = new Point(96, 165);
            lblBookingDate.Name = "lblBookingDate";
            lblBookingDate.Size = new Size(96, 21);
            lblBookingDate.TabIndex = 0;
            lblBookingDate.Text = "07/05/2024";
            // 
            // lblTrainName
            // 
            lblTrainName.AutoSize = true;
            lblTrainName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTrainName.ForeColor = SystemColors.GradientActiveCaption;
            lblTrainName.Location = new Point(35, 13);
            lblTrainName.Name = "lblTrainName";
            lblTrainName.Size = new Size(114, 25);
            lblTrainName.TabIndex = 0;
            lblTrainName.Text = "Train Name";
            // 
            // lblBookingHeading
            // 
            lblBookingHeading.AutoSize = true;
            lblBookingHeading.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblBookingHeading.Location = new Point(750, 32);
            lblBookingHeading.Name = "lblBookingHeading";
            lblBookingHeading.Size = new Size(220, 30);
            lblBookingHeading.TabIndex = 3;
            lblBookingHeading.Text = "Booking Information";
            lblBookingHeading.Visible = false;
            // 
            // pnlBookingInfoPassengerInfo
            // 
            pnlBookingInfoPassengerInfo.BackColor = Color.FromArgb(34, 43, 65);
            pnlBookingInfoPassengerInfo.BorderStyle = BorderStyle.FixedSingle;
            pnlBookingInfoPassengerInfo.Controls.Add(lblPassengerCNICValue);
            pnlBookingInfoPassengerInfo.Controls.Add(label21);
            pnlBookingInfoPassengerInfo.Controls.Add(lblGrandTotalAmount);
            pnlBookingInfoPassengerInfo.Controls.Add(lblInfantsTotalAmount);
            pnlBookingInfoPassengerInfo.Controls.Add(label10);
            pnlBookingInfoPassengerInfo.Controls.Add(lblChildrensTotalAmount);
            pnlBookingInfoPassengerInfo.Controls.Add(lblInfantsFare);
            pnlBookingInfoPassengerInfo.Controls.Add(lblAdultsTotalAmount);
            pnlBookingInfoPassengerInfo.Controls.Add(lblChildrensFare);
            pnlBookingInfoPassengerInfo.Controls.Add(lblAdultsFare);
            pnlBookingInfoPassengerInfo.Controls.Add(label5);
            pnlBookingInfoPassengerInfo.Controls.Add(label19);
            pnlBookingInfoPassengerInfo.Controls.Add(label15);
            pnlBookingInfoPassengerInfo.Controls.Add(label9);
            pnlBookingInfoPassengerInfo.Controls.Add(label14);
            pnlBookingInfoPassengerInfo.Controls.Add(lblInfantsValue);
            pnlBookingInfoPassengerInfo.Controls.Add(label8);
            pnlBookingInfoPassengerInfo.Controls.Add(label13);
            pnlBookingInfoPassengerInfo.Controls.Add(lblChildrensValue);
            pnlBookingInfoPassengerInfo.Controls.Add(label20);
            pnlBookingInfoPassengerInfo.Controls.Add(label7);
            pnlBookingInfoPassengerInfo.Controls.Add(label17);
            pnlBookingInfoPassengerInfo.Controls.Add(lblAdultsValue);
            pnlBookingInfoPassengerInfo.Controls.Add(label12);
            pnlBookingInfoPassengerInfo.Controls.Add(label16);
            pnlBookingInfoPassengerInfo.Controls.Add(label18);
            pnlBookingInfoPassengerInfo.Controls.Add(label6);
            pnlBookingInfoPassengerInfo.Controls.Add(label11);
            pnlBookingInfoPassengerInfo.Controls.Add(label4);
            pnlBookingInfoPassengerInfo.Controls.Add(lblPassengerCNIC);
            pnlBookingInfoPassengerInfo.Controls.Add(lblClassValue);
            pnlBookingInfoPassengerInfo.Controls.Add(lblPassengerNameValue);
            pnlBookingInfoPassengerInfo.Controls.Add(label22);
            pnlBookingInfoPassengerInfo.Controls.Add(lblPassengerName);
            pnlBookingInfoPassengerInfo.Location = new Point(585, 323);
            pnlBookingInfoPassengerInfo.Name = "pnlBookingInfoPassengerInfo";
            pnlBookingInfoPassengerInfo.Size = new Size(563, 247);
            pnlBookingInfoPassengerInfo.TabIndex = 4;
            pnlBookingInfoPassengerInfo.Visible = false;
            // 
            // lblPassengerCNICValue
            // 
            lblPassengerCNICValue.AutoSize = true;
            lblPassengerCNICValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassengerCNICValue.ForeColor = SystemColors.GradientActiveCaption;
            lblPassengerCNICValue.Location = new Point(413, 18);
            lblPassengerCNICValue.Name = "lblPassengerCNICValue";
            lblPassengerCNICValue.Size = new Size(47, 21);
            lblPassengerCNICValue.TabIndex = 0;
            lblPassengerCNICValue.Text = "CNIC";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(290, 95);
            label21.Name = "label21";
            label21.Size = new Size(31, 21);
            label21.TabIndex = 1;
            label21.Text = "Rs.";
            // 
            // lblGrandTotalAmount
            // 
            lblGrandTotalAmount.AutoSize = true;
            lblGrandTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGrandTotalAmount.Location = new Point(327, 208);
            lblGrandTotalAmount.Name = "lblGrandTotalAmount";
            lblGrandTotalAmount.Size = new Size(19, 21);
            lblGrandTotalAmount.TabIndex = 1;
            lblGrandTotalAmount.Text = "0";
            // 
            // lblInfantsTotalAmount
            // 
            lblInfantsTotalAmount.AutoSize = true;
            lblInfantsTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfantsTotalAmount.Location = new Point(327, 160);
            lblInfantsTotalAmount.Name = "lblInfantsTotalAmount";
            lblInfantsTotalAmount.Size = new Size(19, 21);
            lblInfantsTotalAmount.TabIndex = 1;
            lblInfantsTotalAmount.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(181, 95);
            label10.Name = "label10";
            label10.Size = new Size(31, 21);
            label10.TabIndex = 1;
            label10.Text = "Rs.";
            // 
            // lblChildrensTotalAmount
            // 
            lblChildrensTotalAmount.AutoSize = true;
            lblChildrensTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildrensTotalAmount.Location = new Point(327, 129);
            lblChildrensTotalAmount.Name = "lblChildrensTotalAmount";
            lblChildrensTotalAmount.Size = new Size(19, 21);
            lblChildrensTotalAmount.TabIndex = 1;
            lblChildrensTotalAmount.Text = "0";
            // 
            // lblInfantsFare
            // 
            lblInfantsFare.AutoSize = true;
            lblInfantsFare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfantsFare.Location = new Point(218, 160);
            lblInfantsFare.Name = "lblInfantsFare";
            lblInfantsFare.Size = new Size(19, 21);
            lblInfantsFare.TabIndex = 1;
            lblInfantsFare.Text = "0";
            // 
            // lblAdultsTotalAmount
            // 
            lblAdultsTotalAmount.AutoSize = true;
            lblAdultsTotalAmount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdultsTotalAmount.Location = new Point(327, 95);
            lblAdultsTotalAmount.Name = "lblAdultsTotalAmount";
            lblAdultsTotalAmount.Size = new Size(19, 21);
            lblAdultsTotalAmount.TabIndex = 1;
            lblAdultsTotalAmount.Text = "0";
            // 
            // lblChildrensFare
            // 
            lblChildrensFare.AutoSize = true;
            lblChildrensFare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildrensFare.Location = new Point(218, 129);
            lblChildrensFare.Name = "lblChildrensFare";
            lblChildrensFare.Size = new Size(19, 21);
            lblChildrensFare.TabIndex = 1;
            lblChildrensFare.Text = "0";
            // 
            // lblAdultsFare
            // 
            lblAdultsFare.AutoSize = true;
            lblAdultsFare.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdultsFare.Location = new Point(218, 95);
            lblAdultsFare.Name = "lblAdultsFare";
            lblAdultsFare.Size = new Size(19, 21);
            lblAdultsFare.TabIndex = 1;
            lblAdultsFare.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 95);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 1;
            label5.Text = "Adults";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(263, 208);
            label19.Name = "label19";
            label19.Size = new Size(21, 21);
            label19.TabIndex = 1;
            label19.Text = "=";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(263, 160);
            label15.Name = "label15";
            label15.Size = new Size(21, 21);
            label15.TabIndex = 1;
            label15.Text = "=";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(155, 160);
            label9.Name = "label9";
            label9.Size = new Size(20, 21);
            label9.TabIndex = 1;
            label9.Text = "X";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(263, 129);
            label14.Name = "label14";
            label14.Size = new Size(21, 21);
            label14.TabIndex = 1;
            label14.Text = "=";
            // 
            // lblInfantsValue
            // 
            lblInfantsValue.AutoSize = true;
            lblInfantsValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfantsValue.Location = new Point(118, 160);
            lblInfantsValue.Name = "lblInfantsValue";
            lblInfantsValue.Size = new Size(19, 21);
            lblInfantsValue.TabIndex = 1;
            lblInfantsValue.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(155, 129);
            label8.Name = "label8";
            label8.Size = new Size(20, 21);
            label8.TabIndex = 1;
            label8.Text = "X";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(263, 95);
            label13.Name = "label13";
            label13.Size = new Size(21, 21);
            label13.TabIndex = 1;
            label13.Text = "=";
            // 
            // lblChildrensValue
            // 
            lblChildrensValue.AutoSize = true;
            lblChildrensValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChildrensValue.Location = new Point(118, 129);
            lblChildrensValue.Name = "lblChildrensValue";
            lblChildrensValue.Size = new Size(19, 21);
            lblChildrensValue.TabIndex = 1;
            lblChildrensValue.Text = "0";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(290, 208);
            label20.Name = "label20";
            label20.Size = new Size(31, 21);
            label20.TabIndex = 1;
            label20.Text = "Rs.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(155, 95);
            label7.Name = "label7";
            label7.Size = new Size(20, 21);
            label7.TabIndex = 1;
            label7.Text = "X";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(290, 160);
            label17.Name = "label17";
            label17.Size = new Size(31, 21);
            label17.TabIndex = 1;
            label17.Text = "Rs.";
            // 
            // lblAdultsValue
            // 
            lblAdultsValue.AutoSize = true;
            lblAdultsValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdultsValue.Location = new Point(118, 95);
            lblAdultsValue.Name = "lblAdultsValue";
            lblAdultsValue.Size = new Size(19, 21);
            lblAdultsValue.TabIndex = 1;
            lblAdultsValue.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(181, 160);
            label12.Name = "label12";
            label12.Size = new Size(31, 21);
            label12.TabIndex = 1;
            label12.Text = "Rs.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(290, 129);
            label16.Name = "label16";
            label16.Size = new Size(31, 21);
            label16.TabIndex = 1;
            label16.Text = "Rs.";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(151, 208);
            label18.Name = "label18";
            label18.Size = new Size(108, 21);
            label18.TabIndex = 1;
            label18.Text = "Total Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 160);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 1;
            label6.Text = "Infants";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(181, 129);
            label11.Name = "label11";
            label11.Size = new Size(31, 21);
            label11.TabIndex = 1;
            label11.Text = "Rs.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 129);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 1;
            label4.Text = "Childrens";
            // 
            // lblPassengerCNIC
            // 
            lblPassengerCNIC.AutoSize = true;
            lblPassengerCNIC.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassengerCNIC.Location = new Point(366, 18);
            lblPassengerCNIC.Name = "lblPassengerCNIC";
            lblPassengerCNIC.Size = new Size(47, 21);
            lblPassengerCNIC.TabIndex = 1;
            lblPassengerCNIC.Text = "CNIC";
            // 
            // lblClassValue
            // 
            lblClassValue.AutoSize = true;
            lblClassValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClassValue.ForeColor = SystemColors.GradientActiveCaption;
            lblClassValue.Location = new Point(96, 57);
            lblClassValue.Name = "lblClassValue";
            lblClassValue.Size = new Size(93, 21);
            lblClassValue.TabIndex = 0;
            lblClassValue.Text = "Travel Class";
            // 
            // lblPassengerNameValue
            // 
            lblPassengerNameValue.AutoSize = true;
            lblPassengerNameValue.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassengerNameValue.ForeColor = SystemColors.GradientActiveCaption;
            lblPassengerNameValue.Location = new Point(96, 18);
            lblPassengerNameValue.Name = "lblPassengerNameValue";
            lblPassengerNameValue.Size = new Size(131, 21);
            lblPassengerNameValue.TabIndex = 0;
            lblPassengerNameValue.Text = "Passenger Name";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label22.Location = new Point(35, 57);
            label22.Name = "label22";
            label22.Size = new Size(46, 21);
            label22.TabIndex = 1;
            label22.Text = "Class";
            // 
            // lblPassengerName
            // 
            lblPassengerName.AutoSize = true;
            lblPassengerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassengerName.Location = new Point(35, 18);
            lblPassengerName.Name = "lblPassengerName";
            lblPassengerName.Size = new Size(53, 21);
            lblPassengerName.TabIndex = 1;
            lblPassengerName.Text = "Name";
            // 
            // txtStepCounter
            // 
            txtStepCounter.BackColor = Color.FromArgb(24, 30, 54);
            txtStepCounter.BorderStyle = BorderStyle.None;
            txtStepCounter.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtStepCounter.ForeColor = SystemColors.HighlightText;
            txtStepCounter.Location = new Point(30, 791);
            txtStepCounter.Multiline = true;
            txtStepCounter.Name = "txtStepCounter";
            txtStepCounter.Size = new Size(75, 31);
            txtStepCounter.TabIndex = 16;
            txtStepCounter.Visible = false;
            txtStepCounter.WordWrap = false;
            // 
            // pnlTermsAndBookButton
            // 
            pnlTermsAndBookButton.Controls.Add(btnConfirmBooking);
            pnlTermsAndBookButton.Controls.Add(label25);
            pnlTermsAndBookButton.Controls.Add(label24);
            pnlTermsAndBookButton.Controls.Add(label23);
            pnlTermsAndBookButton.Location = new Point(585, 582);
            pnlTermsAndBookButton.Name = "pnlTermsAndBookButton";
            pnlTermsAndBookButton.Size = new Size(563, 195);
            pnlTermsAndBookButton.TabIndex = 17;
            pnlTermsAndBookButton.Visible = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = SystemColors.GradientActiveCaption;
            label23.Location = new Point(14, 11);
            label23.Name = "label23";
            label23.Size = new Size(532, 20);
            label23.TabIndex = 0;
            label23.Text = "Please review the booking details carefully, then click on the below button to";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = SystemColors.GradientActiveCaption;
            label24.Location = new Point(14, 34);
            label24.Name = "label24";
            label24.Size = new Size(541, 20);
            label24.TabIndex = 0;
            label24.Text = "confirm the booking. Check the refund policy in case if there us any change in";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label25.ForeColor = SystemColors.GradientActiveCaption;
            label25.Location = new Point(14, 59);
            label25.Name = "label25";
            label25.Size = new Size(112, 20);
            label25.TabIndex = 0;
            label25.Text = "the travle plan.";
            // 
            // btnConfirmBooking
            // 
            btnConfirmBooking.BackColor = Color.FromArgb(34, 43, 65);
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmBooking.ForeColor = SystemColors.GradientActiveCaption;
            btnConfirmBooking.Image = (Image)resources.GetObject("btnConfirmBooking.Image");
            btnConfirmBooking.ImageAlign = ContentAlignment.MiddleRight;
            btnConfirmBooking.Location = new Point(14, 111);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Padding = new Padding(90, 0, 140, 0);
            btnConfirmBooking.Size = new Size(532, 68);
            btnConfirmBooking.TabIndex = 0;
            btnConfirmBooking.Text = "Click To Confirm Booking";
            btnConfirmBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnNext_Click;
            // 
            // TicketReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(1241, 834);
            Controls.Add(pnlTermsAndBookButton);
            Controls.Add(pnlBookingInfoPassengerInfo);
            Controls.Add(lblBookingHeading);
            Controls.Add(pnlBookingInfoTrainInfo);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTicketReservationForm);
            Controls.Add(txtStepCounter);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicketReservation";
            Load += TicketReservation_Load;
            pnlTicketReservationForm.ResumeLayout(false);
            pnlPassengerInformation.ResumeLayout(false);
            pnlPassengerInformation.PerformLayout();
            pnlGridViewSearchedTrains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchedTrains).EndInit();
            pnlSearchTrain.ResumeLayout(false);
            pnlSearchTrain.PerformLayout();
            pnlHeading.ResumeLayout(false);
            pnlHeading.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlBookingInfoTrainInfo.ResumeLayout(false);
            pnlBookingInfoTrainInfo.PerformLayout();
            pnlBookingInfoPassengerInfo.ResumeLayout(false);
            pnlBookingInfoPassengerInfo.PerformLayout();
            pnlTermsAndBookButton.ResumeLayout(false);
            pnlTermsAndBookButton.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTicketReservationForm;
        private Panel pnlHeading;
        private Label lblHeading;
        private Panel pnlButtons;
        private Button btnPrevious;
        private Button btnNext;
        private Panel pnlSearchTrain;
        private ComboBox cmbFrom;
        private ComboBox cmbTo;
        private DateTimePicker dateTimePicker;
        private TextBox txtDateOfDeparture;
        private Button btnSearchTrain;
        private Panel pnlGridViewSearchedTrains;
        private DataGridView dataGridViewSearchedTrains;
        private Panel pnlBookingInfoTrainInfo;
        private Label lblBookingHeading;
        private Label lblTrainName;
        private Label lblFrom;
        private Label lblFromStationName;
        private Label lblTo;
        private Label lblToStationName;
        private Label lblBookingDate;
        private Label lblCurrency;
        private Label lblOn;
        private Label lblFare;
        private Label lblDistanceValue;
        private Label lblDistance;
        private Label lblFareAmount;
        private Label lblDepartureTimeValue;
        private Label lblArrivalTimeValue;
        private Label lblDepartureTime;
        private Label lblArrivalTime;
        private TextBox lblDescriptionValue;
        private Panel pnlPassengerInformation;
        private ComboBox cmbTravelClass;
        private TextBox txtPassengerCNIC;
        private TextBox txtPassengerName;
        private TextBox txtNoOfAdults;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNoOfChildrens;
        private TextBox txtNoOfInfants;
        private Label lblChildrens;
        private Label lblAdults;
        private Label lblInfants;
        private Panel pnlBookingInfoPassengerInfo;
        private Label lblPassengerCNICValue;
        private Label label5;
        private Label label4;
        private Label lblPassengerCNIC;
        private Label lblPassengerNameValue;
        private Label lblPassengerName;
        private Label label9;
        private Label lblInfantsValue;
        private Label label8;
        private Label lblChildrensValue;
        private Label label7;
        private Label lblAdultsValue;
        private Label label6;
        private Label label10;
        private Label lblInfantsFare;
        private Label lblChildrensFare;
        private Label lblAdultsFare;
        private Label label12;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label21;
        private Label lblInfantsTotalAmount;
        private Label lblChildrensTotalAmount;
        private Label lblAdultsTotalAmount;
        private Label label17;
        private Label label16;
        private Label label18;
        private Label lblGrandTotalAmount;
        private Label label19;
        private Label label20;
        private Label lblClassValue;
        private Label label22;
        private Label lblInfantsFareInfo;
        private Label lblChildrensFareInfo;
        private Label lblAdultsFareInfo;
        private TextBox txtStepCounter;
        private Panel pnlTermsAndBookButton;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button btnConfirmBooking;
    }
}