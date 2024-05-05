namespace RailwayReservationUI
{
    partial class Dashboard_backup
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_backup));
            pnlEmployee = new Panel();
            pnlEmployeeGridViewAndSearch = new Panel();
            pnlEmployeeGridView = new Panel();
            dataGridViewEmployee = new DataGridView();
            pnlSeachEmployee = new Panel();
            btnGo = new Button();
            lblSearch = new Label();
            txtSearchText = new TextBox();
            pnlEmployeeFormMain = new Panel();
            btnSave = new Button();
            lblResetForm = new LinkLabel();
            pnlEmployeeForm = new Panel();
            chkbSetPassword = new CheckBox();
            cmbDepartment = new ComboBox();
            cmbDesignation = new ComboBox();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            dateTimePicker = new DateTimePicker();
            pnlEmployeeHeading = new Panel();
            lblHeading = new Label();
            txtGender = new TextBox();
            txtLastName = new TextBox();
            txtDateOfBirth = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtPostalCode = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtContactNumbers = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtCNIC = new TextBox();
            txtFirstName = new TextBox();
            pnllEmployeeToolbar = new Panel();
            btnEmployeeClose = new Button();
            btnEmployeeDepartment = new Button();
            btnEmployeeDesignation = new Button();
            btnEmployeeSearch = new Button();
            btnEmployeeDelete = new Button();
            btnEmployeeUpdate = new Button();
            btnEmployeeAdd = new Button();
            pnlLeft = new Panel();
            btnExit = new Button();
            btnTicketBooking = new Button();
            btnRoute = new Button();
            btnTrains = new Button();
            btnEmployee = new Button();
            btnDashboard = new Button();
            pnlTop = new Panel();
            btnClose = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlEmployee.SuspendLayout();
            pnlEmployeeGridViewAndSearch.SuspendLayout();
            pnlEmployeeGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            pnlSeachEmployee.SuspendLayout();
            pnlEmployeeFormMain.SuspendLayout();
            pnlEmployeeForm.SuspendLayout();
            pnlEmployeeHeading.SuspendLayout();
            pnllEmployeeToolbar.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlEmployee
            // 
            pnlEmployee.BackColor = Color.FromArgb(24, 30, 54);
            pnlEmployee.Controls.Add(pnlEmployeeGridViewAndSearch);
            pnlEmployee.Controls.Add(pnlEmployeeFormMain);
            pnlEmployee.Controls.Add(pnllEmployeeToolbar);
            pnlEmployee.Dock = DockStyle.Left;
            pnlEmployee.Location = new Point(195, 40);
            pnlEmployee.Name = "pnlEmployee";
            pnlEmployee.Size = new Size(1201, 804);
            pnlEmployee.TabIndex = 5;
            // 
            // pnlEmployeeGridViewAndSearch
            // 
            pnlEmployeeGridViewAndSearch.Controls.Add(pnlEmployeeGridView);
            pnlEmployeeGridViewAndSearch.Controls.Add(pnlSeachEmployee);
            pnlEmployeeGridViewAndSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlEmployeeGridViewAndSearch.Location = new Point(526, 105);
            pnlEmployeeGridViewAndSearch.Margin = new Padding(3, 10, 3, 3);
            pnlEmployeeGridViewAndSearch.Name = "pnlEmployeeGridViewAndSearch";
            pnlEmployeeGridViewAndSearch.Size = new Size(654, 689);
            pnlEmployeeGridViewAndSearch.TabIndex = 3;
            // 
            // pnlEmployeeGridView
            // 
            pnlEmployeeGridView.Controls.Add(dataGridViewEmployee);
            pnlEmployeeGridView.Dock = DockStyle.Fill;
            pnlEmployeeGridView.Location = new Point(0, 49);
            pnlEmployeeGridView.Name = "pnlEmployeeGridView";
            pnlEmployeeGridView.Size = new Size(654, 640);
            pnlEmployeeGridView.TabIndex = 1;
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AllowUserToAddRows = false;
            dataGridViewEmployee.AllowUserToDeleteRows = false;
            dataGridViewEmployee.AllowUserToOrderColumns = true;
            dataGridViewEmployee.BackgroundColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(24, 30, 54);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.Padding = new Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewEmployee.GridColor = SystemColors.MenuBar;
            dataGridViewEmployee.Location = new Point(0, 6);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowTemplate.Height = 25;
            dataGridViewEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployee.Size = new Size(651, 574);
            dataGridViewEmployee.TabIndex = 0;
            // 
            // pnlSeachEmployee
            // 
            pnlSeachEmployee.Controls.Add(btnGo);
            pnlSeachEmployee.Controls.Add(lblSearch);
            pnlSeachEmployee.Controls.Add(txtSearchText);
            pnlSeachEmployee.Dock = DockStyle.Top;
            pnlSeachEmployee.Location = new Point(0, 0);
            pnlSeachEmployee.Name = "pnlSeachEmployee";
            pnlSeachEmployee.Size = new Size(654, 49);
            pnlSeachEmployee.TabIndex = 0;
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
            txtSearchText.PlaceholderText = "CNIC";
            txtSearchText.Size = new Size(314, 25);
            txtSearchText.TabIndex = 11;
            txtSearchText.WordWrap = false;
            // 
            // pnlEmployeeFormMain
            // 
            pnlEmployeeFormMain.Controls.Add(btnSave);
            pnlEmployeeFormMain.Controls.Add(lblResetForm);
            pnlEmployeeFormMain.Controls.Add(pnlEmployeeForm);
            pnlEmployeeFormMain.Dock = DockStyle.Left;
            pnlEmployeeFormMain.Location = new Point(0, 82);
            pnlEmployeeFormMain.Name = "pnlEmployeeFormMain";
            pnlEmployeeFormMain.Size = new Size(517, 722);
            pnlEmployeeFormMain.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 43, 65);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(21, 571);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(0, 7, 0, 7);
            btnSave.Size = new Size(472, 81);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save Employee Data";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lblResetForm
            // 
            lblResetForm.ActiveLinkColor = SystemColors.InactiveCaption;
            lblResetForm.AutoSize = true;
            lblResetForm.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetForm.ForeColor = SystemColors.ActiveCaption;
            lblResetForm.LinkColor = SystemColors.InactiveBorder;
            lblResetForm.Location = new Point(406, 674);
            lblResetForm.Name = "lblResetForm";
            lblResetForm.Size = new Size(77, 17);
            lblResetForm.TabIndex = 29;
            lblResetForm.TabStop = true;
            lblResetForm.Text = "Reset Form";
            // 
            // pnlEmployeeForm
            // 
            pnlEmployeeForm.BackColor = SystemColors.ActiveCaptionText;
            pnlEmployeeForm.Controls.Add(chkbSetPassword);
            pnlEmployeeForm.Controls.Add(cmbDepartment);
            pnlEmployeeForm.Controls.Add(cmbDesignation);
            pnlEmployeeForm.Controls.Add(radioButtonFemale);
            pnlEmployeeForm.Controls.Add(radioButtonMale);
            pnlEmployeeForm.Controls.Add(dateTimePicker);
            pnlEmployeeForm.Controls.Add(pnlEmployeeHeading);
            pnlEmployeeForm.Controls.Add(txtGender);
            pnlEmployeeForm.Controls.Add(txtLastName);
            pnlEmployeeForm.Controls.Add(txtDateOfBirth);
            pnlEmployeeForm.Controls.Add(txtCountry);
            pnlEmployeeForm.Controls.Add(txtCity);
            pnlEmployeeForm.Controls.Add(txtPostalCode);
            pnlEmployeeForm.Controls.Add(txtAddress);
            pnlEmployeeForm.Controls.Add(txtEmail);
            pnlEmployeeForm.Controls.Add(txtContactNumbers);
            pnlEmployeeForm.Controls.Add(txtConfirmPassword);
            pnlEmployeeForm.Controls.Add(txtPassword);
            pnlEmployeeForm.Controls.Add(txtCNIC);
            pnlEmployeeForm.Controls.Add(txtFirstName);
            pnlEmployeeForm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pnlEmployeeForm.Location = new Point(21, 23);
            pnlEmployeeForm.Name = "pnlEmployeeForm";
            pnlEmployeeForm.Size = new Size(472, 547);
            pnlEmployeeForm.TabIndex = 1;
            // 
            // chkbSetPassword
            // 
            chkbSetPassword.AutoSize = true;
            chkbSetPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chkbSetPassword.ForeColor = SystemColors.AppWorkspace;
            chkbSetPassword.Location = new Point(29, 422);
            chkbSetPassword.Name = "chkbSetPassword";
            chkbSetPassword.Size = new Size(145, 21);
            chkbSetPassword.TabIndex = 25;
            chkbSetPassword.Text = "Set Login Password";
            chkbSetPassword.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = SystemColors.InactiveCaptionText;
            cmbDepartment.FlatStyle = FlatStyle.Flat;
            cmbDepartment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDepartment.ForeColor = SystemColors.AppWorkspace;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.ItemHeight = 17;
            cmbDepartment.Items.AddRange(new object[] { "Select Department", "Accounts", "Administration", "HR", "Repairing Dept" });
            cmbDepartment.Location = new Point(248, 379);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(205, 25);
            cmbDepartment.TabIndex = 24;
            cmbDepartment.Text = "Select Department";
            // 
            // cmbDesignation
            // 
            cmbDesignation.BackColor = SystemColors.InactiveCaptionText;
            cmbDesignation.FlatStyle = FlatStyle.Flat;
            cmbDesignation.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbDesignation.ForeColor = SystemColors.AppWorkspace;
            cmbDesignation.FormattingEnabled = true;
            cmbDesignation.ItemHeight = 17;
            cmbDesignation.Items.AddRange(new object[] { "Select Designation", "Cashier", "Manager", "Operator" });
            cmbDesignation.Location = new Point(29, 379);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(205, 25);
            cmbDesignation.TabIndex = 23;
            cmbDesignation.Text = "Select Designation";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.ForeColor = SystemColors.AppWorkspace;
            radioButtonFemale.Location = new Point(101, 189);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(67, 21);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.ForeColor = SystemColors.AppWorkspace;
            radioButtonMale.Location = new Point(29, 189);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(55, 21);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            dateTimePicker.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dateTimePicker.CalendarTitleForeColor = SystemColors.HighlightText;
            dateTimePicker.Location = new Point(227, 151);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(14, 25);
            dateTimePicker.TabIndex = 12;
            // 
            // pnlEmployeeHeading
            // 
            pnlEmployeeHeading.BackColor = Color.FromArgb(24, 30, 54);
            pnlEmployeeHeading.Controls.Add(lblHeading);
            pnlEmployeeHeading.Dock = DockStyle.Top;
            pnlEmployeeHeading.Location = new Point(0, 0);
            pnlEmployeeHeading.Name = "pnlEmployeeHeading";
            pnlEmployeeHeading.Size = new Size(472, 49);
            pnlEmployeeHeading.TabIndex = 1;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.ForeColor = SystemColors.ButtonFace;
            lblHeading.Location = new Point(108, 7);
            lblHeading.Margin = new Padding(3, 3, 3, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(255, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Employee Information";
            // 
            // txtGender
            // 
            txtGender.BackColor = SystemColors.InactiveCaptionText;
            txtGender.BorderStyle = BorderStyle.FixedSingle;
            txtGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtGender.ForeColor = SystemColors.HighlightText;
            txtGender.Location = new Point(174, 189);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(65, 25);
            txtGender.TabIndex = 0;
            txtGender.Visible = false;
            txtGender.WordWrap = false;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.InactiveCaptionText;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = SystemColors.HighlightText;
            txtLastName.Location = new Point(248, 77);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(198, 25);
            txtLastName.TabIndex = 12;
            txtLastName.WordWrap = false;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = SystemColors.InactiveCaptionText;
            txtDateOfBirth.BorderStyle = BorderStyle.FixedSingle;
            txtDateOfBirth.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateOfBirth.ForeColor = SystemColors.HighlightText;
            txtDateOfBirth.Location = new Point(29, 151);
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.PlaceholderText = "Date of Birth";
            txtDateOfBirth.Size = new Size(205, 25);
            txtDateOfBirth.TabIndex = 14;
            txtDateOfBirth.WordWrap = false;
            // 
            // txtCountry
            // 
            txtCountry.BackColor = SystemColors.InactiveCaptionText;
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.ForeColor = SystemColors.HighlightText;
            txtCountry.Location = new Point(319, 265);
            txtCountry.Multiline = true;
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Country";
            txtCountry.Size = new Size(130, 25);
            txtCountry.TabIndex = 20;
            txtCountry.WordWrap = false;
            // 
            // txtCity
            // 
            txtCity.BackColor = SystemColors.InactiveCaptionText;
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCity.ForeColor = SystemColors.HighlightText;
            txtCity.Location = new Point(174, 265);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "City";
            txtCity.Size = new Size(130, 25);
            txtCity.TabIndex = 19;
            txtCity.WordWrap = false;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = SystemColors.InactiveCaptionText;
            txtPostalCode.BorderStyle = BorderStyle.FixedSingle;
            txtPostalCode.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPostalCode.ForeColor = SystemColors.HighlightText;
            txtPostalCode.Location = new Point(29, 265);
            txtPostalCode.Multiline = true;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PlaceholderText = "Postal Code";
            txtPostalCode.Size = new Size(130, 25);
            txtPostalCode.TabIndex = 18;
            txtPostalCode.WordWrap = false;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.InactiveCaptionText;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.ForeColor = SystemColors.HighlightText;
            txtAddress.Location = new Point(29, 227);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Complete address of an employee ";
            txtAddress.Size = new Size(417, 25);
            txtAddress.TabIndex = 17;
            txtAddress.WordWrap = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaptionText;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.HighlightText;
            txtEmail.Location = new Point(29, 303);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email Address";
            txtEmail.Size = new Size(424, 25);
            txtEmail.TabIndex = 21;
            txtEmail.WordWrap = false;
            // 
            // txtContactNumbers
            // 
            txtContactNumbers.BackColor = SystemColors.InactiveCaptionText;
            txtContactNumbers.BorderStyle = BorderStyle.FixedSingle;
            txtContactNumbers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactNumbers.ForeColor = SystemColors.HighlightText;
            txtContactNumbers.Location = new Point(29, 341);
            txtContactNumbers.Multiline = true;
            txtContactNumbers.Name = "txtContactNumbers";
            txtContactNumbers.PlaceholderText = "Contact Numbers";
            txtContactNumbers.Size = new Size(282, 25);
            txtContactNumbers.TabIndex = 22;
            txtContactNumbers.WordWrap = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = SystemColors.InactiveCaptionText;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.ForeColor = SystemColors.HighlightText;
            txtConfirmPassword.Location = new Point(29, 498);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(212, 25);
            txtConfirmPassword.TabIndex = 27;
            txtConfirmPassword.WordWrap = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaptionText;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.HighlightText;
            txtPassword.Location = new Point(29, 460);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(212, 25);
            txtPassword.TabIndex = 26;
            txtPassword.WordWrap = false;
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = SystemColors.InactiveCaptionText;
            txtCNIC.BorderStyle = BorderStyle.FixedSingle;
            txtCNIC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCNIC.ForeColor = SystemColors.HighlightText;
            txtCNIC.Location = new Point(29, 114);
            txtCNIC.Multiline = true;
            txtCNIC.Name = "txtCNIC";
            txtCNIC.PlaceholderText = "CNIC";
            txtCNIC.Size = new Size(212, 25);
            txtCNIC.TabIndex = 13;
            txtCNIC.WordWrap = false;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.InactiveCaptionText;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = SystemColors.HighlightText;
            txtFirstName.Location = new Point(29, 77);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(212, 25);
            txtFirstName.TabIndex = 11;
            txtFirstName.WordWrap = false;
            // 
            // pnllEmployeeToolbar
            // 
            pnllEmployeeToolbar.BackColor = Color.FromArgb(34, 43, 65);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeClose);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeDepartment);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeDesignation);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeSearch);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeDelete);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeUpdate);
            pnllEmployeeToolbar.Controls.Add(btnEmployeeAdd);
            pnllEmployeeToolbar.Dock = DockStyle.Top;
            pnllEmployeeToolbar.Location = new Point(0, 0);
            pnllEmployeeToolbar.Name = "pnllEmployeeToolbar";
            pnllEmployeeToolbar.Size = new Size(1201, 82);
            pnllEmployeeToolbar.TabIndex = 1;
            pnllEmployeeToolbar.Visible = false;
            // 
            // btnEmployeeClose
            // 
            btnEmployeeClose.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeClose.FlatAppearance.BorderSize = 0;
            btnEmployeeClose.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeClose.FlatStyle = FlatStyle.Flat;
            btnEmployeeClose.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeClose.ForeColor = SystemColors.Control;
            btnEmployeeClose.Image = (Image)resources.GetObject("btnEmployeeClose.Image");
            btnEmployeeClose.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeClose.Location = new Point(884, 1);
            btnEmployeeClose.Name = "btnEmployeeClose";
            btnEmployeeClose.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeClose.Size = new Size(140, 81);
            btnEmployeeClose.TabIndex = 1;
            btnEmployeeClose.Text = "Close";
            btnEmployeeClose.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeClose.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeDepartment
            // 
            btnEmployeeDepartment.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeDepartment.FlatAppearance.BorderSize = 0;
            btnEmployeeDepartment.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeDepartment.FlatStyle = FlatStyle.Flat;
            btnEmployeeDepartment.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeDepartment.ForeColor = SystemColors.Control;
            btnEmployeeDepartment.Image = (Image)resources.GetObject("btnEmployeeDepartment.Image");
            btnEmployeeDepartment.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeDepartment.Location = new Point(718, 1);
            btnEmployeeDepartment.Name = "btnEmployeeDepartment";
            btnEmployeeDepartment.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeDepartment.Size = new Size(140, 81);
            btnEmployeeDepartment.TabIndex = 1;
            btnEmployeeDepartment.Text = "Department";
            btnEmployeeDepartment.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeDepartment.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeDesignation
            // 
            btnEmployeeDesignation.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeDesignation.FlatAppearance.BorderSize = 0;
            btnEmployeeDesignation.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeDesignation.FlatStyle = FlatStyle.Flat;
            btnEmployeeDesignation.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeDesignation.ForeColor = SystemColors.Control;
            btnEmployeeDesignation.Image = (Image)resources.GetObject("btnEmployeeDesignation.Image");
            btnEmployeeDesignation.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeDesignation.Location = new Point(582, 1);
            btnEmployeeDesignation.Name = "btnEmployeeDesignation";
            btnEmployeeDesignation.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeDesignation.Size = new Size(140, 81);
            btnEmployeeDesignation.TabIndex = 1;
            btnEmployeeDesignation.Text = "Designation";
            btnEmployeeDesignation.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeDesignation.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeSearch
            // 
            btnEmployeeSearch.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeSearch.FlatAppearance.BorderSize = 0;
            btnEmployeeSearch.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeSearch.FlatStyle = FlatStyle.Flat;
            btnEmployeeSearch.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeSearch.ForeColor = SystemColors.Control;
            btnEmployeeSearch.Image = (Image)resources.GetObject("btnEmployeeSearch.Image");
            btnEmployeeSearch.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeSearch.Location = new Point(418, 1);
            btnEmployeeSearch.Name = "btnEmployeeSearch";
            btnEmployeeSearch.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeSearch.Size = new Size(140, 81);
            btnEmployeeSearch.TabIndex = 1;
            btnEmployeeSearch.Text = "Find";
            btnEmployeeSearch.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeSearch.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeDelete.FlatAppearance.BorderSize = 0;
            btnEmployeeDelete.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeDelete.FlatStyle = FlatStyle.Flat;
            btnEmployeeDelete.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeDelete.ForeColor = SystemColors.Control;
            btnEmployeeDelete.Image = (Image)resources.GetObject("btnEmployeeDelete.Image");
            btnEmployeeDelete.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeDelete.Location = new Point(279, 1);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeDelete.Size = new Size(140, 81);
            btnEmployeeDelete.TabIndex = 1;
            btnEmployeeDelete.Text = "Delete";
            btnEmployeeDelete.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeDelete.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeUpdate.FlatAppearance.BorderSize = 0;
            btnEmployeeUpdate.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeUpdate.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpdate.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeUpdate.ForeColor = SystemColors.Control;
            btnEmployeeUpdate.Image = (Image)resources.GetObject("btnEmployeeUpdate.Image");
            btnEmployeeUpdate.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeUpdate.Location = new Point(140, 1);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeUpdate.Size = new Size(140, 81);
            btnEmployeeUpdate.TabIndex = 1;
            btnEmployeeUpdate.Text = "Update";
            btnEmployeeUpdate.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeUpdate.UseVisualStyleBackColor = false;
            // 
            // btnEmployeeAdd
            // 
            btnEmployeeAdd.BackColor = Color.FromArgb(34, 43, 65);
            btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            btnEmployeeAdd.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployeeAdd.FlatStyle = FlatStyle.Flat;
            btnEmployeeAdd.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployeeAdd.ForeColor = SystemColors.Control;
            btnEmployeeAdd.Image = (Image)resources.GetObject("btnEmployeeAdd.Image");
            btnEmployeeAdd.ImageAlign = ContentAlignment.TopCenter;
            btnEmployeeAdd.Location = new Point(1, 1);
            btnEmployeeAdd.Name = "btnEmployeeAdd";
            btnEmployeeAdd.Padding = new Padding(0, 7, 0, 7);
            btnEmployeeAdd.Size = new Size(140, 81);
            btnEmployeeAdd.TabIndex = 1;
            btnEmployeeAdd.Text = "Add";
            btnEmployeeAdd.TextAlign = ContentAlignment.BottomCenter;
            btnEmployeeAdd.UseVisualStyleBackColor = false;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = SystemColors.ActiveCaptionText;
            pnlLeft.Controls.Add(btnExit);
            pnlLeft.Controls.Add(btnTicketBooking);
            pnlLeft.Controls.Add(btnRoute);
            pnlLeft.Controls.Add(btnTrains);
            pnlLeft.Controls.Add(btnEmployee);
            pnlLeft.Controls.Add(btnDashboard);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 40);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(195, 804);
            pnlLeft.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(3, 693);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 0, 0);
            btnExit.Size = new Size(191, 83);
            btnExit.TabIndex = 2;
            btnExit.Text = " &Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnTicketBooking
            // 
            btnTicketBooking.BackColor = Color.Transparent;
            btnTicketBooking.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnTicketBooking.FlatAppearance.BorderSize = 0;
            btnTicketBooking.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnTicketBooking.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnTicketBooking.FlatStyle = FlatStyle.Flat;
            btnTicketBooking.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicketBooking.ForeColor = SystemColors.Control;
            btnTicketBooking.Image = (Image)resources.GetObject("btnTicketBooking.Image");
            btnTicketBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnTicketBooking.Location = new Point(-1, 430);
            btnTicketBooking.Name = "btnTicketBooking";
            btnTicketBooking.Padding = new Padding(10, 0, 0, 0);
            btnTicketBooking.Size = new Size(194, 83);
            btnTicketBooking.TabIndex = 2;
            btnTicketBooking.Text = "   Ticket &Booking";
            btnTicketBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnTicketBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTicketBooking.UseVisualStyleBackColor = false;
            // 
            // btnRoute
            // 
            btnRoute.BackColor = Color.Transparent;
            btnRoute.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnRoute.FlatAppearance.BorderSize = 0;
            btnRoute.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnRoute.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnRoute.FlatStyle = FlatStyle.Flat;
            btnRoute.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoute.ForeColor = SystemColors.Control;
            btnRoute.Image = (Image)resources.GetObject("btnRoute.Image");
            btnRoute.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoute.Location = new Point(0, 344);
            btnRoute.Name = "btnRoute";
            btnRoute.Padding = new Padding(10, 0, 0, 0);
            btnRoute.Size = new Size(194, 83);
            btnRoute.TabIndex = 2;
            btnRoute.Text = "   &Route";
            btnRoute.TextAlign = ContentAlignment.MiddleLeft;
            btnRoute.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoute.UseVisualStyleBackColor = false;
            // 
            // btnTrains
            // 
            btnTrains.BackColor = Color.Transparent;
            btnTrains.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnTrains.FlatAppearance.BorderSize = 0;
            btnTrains.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnTrains.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnTrains.FlatStyle = FlatStyle.Flat;
            btnTrains.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrains.ForeColor = SystemColors.Control;
            btnTrains.Image = (Image)resources.GetObject("btnTrains.Image");
            btnTrains.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrains.Location = new Point(0, 257);
            btnTrains.Name = "btnTrains";
            btnTrains.Padding = new Padding(10, 0, 0, 0);
            btnTrains.Size = new Size(194, 83);
            btnTrains.TabIndex = 2;
            btnTrains.Text = "   &Trains";
            btnTrains.TextAlign = ContentAlignment.MiddleLeft;
            btnTrains.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrains.UseVisualStyleBackColor = false;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.Transparent;
            btnEmployee.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnEmployee.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.ForeColor = SystemColors.Control;
            btnEmployee.Image = (Image)resources.GetObject("btnEmployee.Image");
            btnEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployee.Location = new Point(-2, 170);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Padding = new Padding(10, 0, 0, 0);
            btnEmployee.Size = new Size(194, 83);
            btnEmployee.TabIndex = 2;
            btnEmployee.Text = "   Em&ployees";
            btnEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDashboard.ForeColor = SystemColors.Control;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-1, 83);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(194, 83);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "   &Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.MenuText;
            pnlTop.Controls.Add(btnClose);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1389, 40);
            pnlTop.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ActiveCaption;
            btnClose.Location = new Point(1366, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(43, 3);
            label1.Name = "label1";
            label1.Size = new Size(371, 25);
            label1.TabIndex = 2;
            label1.Text = "R a i l w a y  R e s e r v a t i o n  S y s t e m";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Dashboard_backup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 844);
            Controls.Add(pnlEmployee);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_backup";
            Text = "Dashboard_backup";
            pnlEmployee.ResumeLayout(false);
            pnlEmployeeGridViewAndSearch.ResumeLayout(false);
            pnlEmployeeGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            pnlSeachEmployee.ResumeLayout(false);
            pnlSeachEmployee.PerformLayout();
            pnlEmployeeFormMain.ResumeLayout(false);
            pnlEmployeeFormMain.PerformLayout();
            pnlEmployeeForm.ResumeLayout(false);
            pnlEmployeeForm.PerformLayout();
            pnlEmployeeHeading.ResumeLayout(false);
            pnlEmployeeHeading.PerformLayout();
            pnllEmployeeToolbar.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEmployee;
        private Panel pnlEmployeeGridViewAndSearch;
        private Panel pnlEmployeeGridView;
        private DataGridView dataGridViewEmployee;
        private Panel pnlSeachEmployee;
        private Button btnGo;
        private Label lblSearch;
        private TextBox txtSearchText;
        private Panel pnlEmployeeFormMain;
        private Button btnSave;
        private LinkLabel lblResetForm;
        private Panel pnlEmployeeForm;
        private CheckBox chkbSetPassword;
        private ComboBox cmbDepartment;
        private ComboBox cmbDesignation;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private DateTimePicker dateTimePicker;
        private Panel pnlEmployeeHeading;
        private Label lblHeading;
        private TextBox txtGender;
        private TextBox txtLastName;
        private TextBox txtDateOfBirth;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtPostalCode;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtContactNumbers;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtCNIC;
        private TextBox txtFirstName;
        private Panel pnllEmployeeToolbar;
        private Button btnEmployeeClose;
        private Button btnEmployeeDepartment;
        private Button btnEmployeeDesignation;
        private Button btnEmployeeSearch;
        private Button btnEmployeeDelete;
        private Button btnEmployeeUpdate;
        private Button btnEmployeeAdd;
        private Panel pnlLeft;
        private Button btnExit;
        private Button btnTicketBooking;
        private Button btnRoute;
        private Button btnTrains;
        private Button btnEmployee;
        private Button btnDashboard;
        private Panel pnlTop;
        private Button btnClose;
        private Label label1;
        private PictureBox pictureBox1;
    }
}