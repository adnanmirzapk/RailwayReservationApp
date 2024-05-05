
using RailwayReservationLibrary.DataAccess;
using System.Data.SqlClient;


namespace RailwayReservationUI
{
    public partial class Login : Form
    {
        MDIParent RailwayReservationApp = new MDIParent();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RailwayReservationApp.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                try
                {
                    string sqlQuery = "Select * From Users Where Email = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'";
                    //string sqlQuery = $"Select * from Users";
                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.HasRows)
                    {
                        RailwayReservationApp = new MDIParent();
                        RailwayReservationApp.Show();
                        //GetUserName = rdr["FirstName"].ToString() + " " + rdr["LastName"].ToString();
                        this.Hide();
                    }
                    else
                    {
                        txtUserName.Text = "";
                        txtUserName.Focus();
                        txtPassword.Text = "";
                        lblError.Text = "Invalid user name or password!!!";
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show("Problem while connection to the database in ****login form*****\n\n" + exception);
                }
            }
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}
