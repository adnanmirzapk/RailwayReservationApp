using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using RailwayReservationLibrary.Logic;
using System.Data;
using System.Data.SqlClient;

namespace RailwayReservationUI
{
    public partial class Employee : Form
    {
        EmployeeDataLogic employeeLogic = new EmployeeDataLogic();
        int employeeId;

        public Employee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            
            txtSearchText.Enabled = false;
            btnSave.Enabled = false;
            lblResetForm.Enabled = false;

            btnEmployeeDesignation.Enabled = false;
            btnEmployeeDepartment.Enabled = false;

            FillGridViewWithEmployeeData();
        }        

        private void btnEmployeeClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtDateOfBirth.Text = dateTimePicker.Value.ToString("dd-MM-yyyy");
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Female";
        }

        private void chkbSetPassword_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkbSetPassword.Checked)
            {
                txtPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
                txtPassword.Focus();
            }
            else
            {
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            pnlEmployeeFormMain.Visible = true;
            pnlEmployeeGridViewAndSearch.Visible = true;
            pnllEmployeeToolbar.Visible = true;
            pnlEmployeeForm.Enabled = true;
            btnSave.Enabled = true;
            lblResetForm.Enabled = true;
            txtFirstName.Focus();
        }

        private void lblResetForm_Click(object sender, EventArgs e)
        {
            ResetFormFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                RailwayReservationLibrary.Entities.Employee emp = new RailwayReservationLibrary.Entities.Employee
                {
                    Id = employeeId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    CNIC = txtCNIC.Text,
                    DOB = DateTime.Parse(txtDateOfBirth.Text),
                    Gender = txtGender.Text,
                    Address = txtAddress.Text,
                    PostalCode = txtPostalCode.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Contact = txtContactNumbers.Text,
                    Designation = Convert.ToString(cmbDesignation.SelectedItem),
                    Department = Convert.ToString(cmbDepartment.SelectedItem),
                    Password = txtPassword.Text
                };

                //Save the new employee in the database
                if (btnSave.Text == "Save Employee Data")
                {
                    int result = employeeLogic.CreateEmployee(emp);

                    if (result > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                        ResetFormFields();
                        FillGridViewWithEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Problem in saving data");
                    }
                }

                //update the existing employee details
                if (btnSave.Text == "Edit Employee Data")
                {
                    int result = employeeLogic.UpdateEmployee(emp);
                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                        ResetFormFields();
                        FillGridViewWithEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Problem in updating data");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee Form: Problem in saving or upating employee data \n" + ex.Message);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string searchQuery = "Select Id, FirstName, LastName, CNIC, DateOfBirth, City, Email, ContactNumber, Designation, Department from Employees Where CNIC = @CNIC";
            FillGridViewWithEmployeeData(searchQuery, "CNIC", txtSearchText.Text);
        }

        private void btnEmployeeSearch_Click(object sender, EventArgs e)
        {
            dataGridViewEmployee.Enabled = true;
            txtSearchText.Enabled = true;
            txtSearchText.Focus();
        }

        private void dataGridViewEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                pnlEmployeeFormMain.Enabled = true;
                pnlEmployeeForm.Enabled = true;
                btnSave.Enabled = true;
                lblResetForm.Enabled = true;

                btnSave.Text = "Edit Employee Data";

                RailwayReservationLibrary.Entities.Employee emp = employeeLogic.FindEmployee(dataGridViewEmployee.SelectedRows[0].Cells[3].Value.ToString());
                if (emp != null)
                {
                    employeeId = emp.Id;
                    txtFirstName.Text = emp.FirstName;
                    txtLastName.Text = emp.LastName;
                    txtCNIC.Text = emp.CNIC;
                    txtDateOfBirth.Text = emp.DOB.ToString("dd-MM-yyyy");
                    txtGender.Text = emp.Gender;

                    if (txtGender.Text == "Male")
                        radioButtonMale.Checked = true;
                    else
                        radioButtonFemale.Checked = true;

                    txtAddress.Text = emp.Address;
                    txtPostalCode.Text = emp.PostalCode;
                    txtCity.Text = emp.City;
                    txtCountry.Text = emp.Country;
                    txtEmail.Text = emp.Email;
                    txtContactNumbers.Text = emp.Contact;
                    cmbDesignation.SelectedItem = emp.Designation;
                    cmbDepartment.SelectedItem = emp.Department;
                }
                else
                {
                    MessageBox.Show("Employee is null and could not load the data");
                    pnlEmployeeFormMain.Enabled = false;
                    pnlEmployeeForm.Enabled = false;
                    btnSave.Enabled = false;
                    lblResetForm.Enabled = false;
                }


            }
        }

        //Private method to reset the employee data form.
        private void ResetFormFields()
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCNIC.Text = "";
            txtConfirmPassword.Text = "";
            txtContactNumbers.Text = "";
            txtCountry.Text = "";
            txtDateOfBirth.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtGender.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtPostalCode.Text = "";
            chkbSetPassword.Checked = false;
            cmbDepartment.SelectedIndex = 0;
            cmbDesignation.SelectedIndex = 0;
        }

        //Private method fill the GridView with the employees data
        private void FillGridViewWithEmployeeData()
        {
            try
            {
                string sqlQuery = "Select Id, FirstName, LastName, CNIC, DateOfBirth, City, Email, ContactNumber from Employees";

                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Employees"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridViewEmployee.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading data in the GridView\n" + ex.Message);
            }
        }

        private void FillGridViewWithEmployeeData(string sqlQuery, string parameterName, object value)
        {
            try
            {
                using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
                {
                    using (DataTable dataTable = new DataTable("Employees"))
                    {
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                        {
                            cmd.Parameters.AddWithValue(parameterName, value);
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            dataAdapter.Fill(dataTable);
                            dataGridViewEmployee.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem while loading searched data in the GridView\n" + ex.Message);
            }

        }

        private void dataGridViewEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnTicketBooking_Click(object sender, EventArgs e)
        {
           
        }
    }
}