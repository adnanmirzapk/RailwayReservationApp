
using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;

namespace RailwayReservationLibrary.Logic
{
    public class EmployeeDataLogic
    {        
        public int CreateEmployee(Employee employee)
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string query = $"Insert into Employees (FirstName, LastName, CNIC, DateOfBirth, Gender, Address, PostalCode, City, Country, Email, ContactNumber, Designation, Department, Password) VALUES ('{employee.FirstName}', '{employee.LastName}', '{employee.CNIC}', '{employee.DOB}', '{employee.Gender}', '{employee.Address}', '{employee.PostalCode}', '{employee.City}', '{employee.Country}', '{employee.Email}', '{employee.Contact}', '{employee.Designation}', '{employee.Department}', '{employee.Password}');";

                SqlCommand cmd = new SqlCommand(query, connection);
                
                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateEmployee(Employee employee) 
        {
            string query = $"Update Employees Set FirstName = '{employee.FirstName}', LastName = '{employee.LastName}', CNIC = '{employee.CNIC}', DateOfBirth = '{employee.DOB}', Gender = '{employee.Gender}', Address = '{employee.Address}', PostalCode = '{employee.PostalCode}', City = '{employee.City}', Country = '{employee.Country}', Email = '{employee.Email}', ContactNumber = '{employee.Contact}', Designation = '{employee.Designation}', Department = '{employee.Department}' Where Id = @Id";

            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                SqlCommand cmd = new SqlCommand( query, connection);
                cmd.Parameters.AddWithValue("@Id", employee.Id);

                return cmd.ExecuteNonQuery();
            }            
        }    

        public Employee FindEmployee(string input) 
        {            
            Employee emp = new Employee();
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string query = "Select * from Employees where CNIC = @CNIC";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CNIC", input);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        emp.Id = (int)rdr["Id"];
                        emp.FirstName = Convert.ToString(rdr["FirstName"]);
                        emp.LastName = Convert.ToString(rdr["LastName"]);
                        emp.CNIC = input;
                        emp.DOB = DateTime.Parse(rdr["DateOfBirth"].ToString());
                        emp.Gender = Convert.ToString(rdr["Gender"]);
                        emp.Address = Convert.ToString(rdr["Address"]);
                        emp.PostalCode = Convert.ToString(rdr["PostalCode"]);
                        emp.City = Convert.ToString(rdr["City"]);
                        emp.Country = Convert.ToString(rdr["Country"]);
                        emp.Email = Convert.ToString(rdr["Email"]);
                        emp.Contact = Convert.ToString(rdr["ContactNumber"]);
                        emp.Designation = Convert.ToString(rdr["Designation"]);
                        emp.Department = Convert.ToString(rdr["Department"]);
                        emp.Password = Convert.ToString(rdr["Password"]);
                    }                    
                }                
            }
            return emp;            
        }
    }
}
