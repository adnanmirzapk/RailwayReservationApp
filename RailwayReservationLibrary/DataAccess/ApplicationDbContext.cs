using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RailwayReservationLibrary.DataAccess
{
    public class ApplicationDbContext
    {
        public static SqlConnection ConnectToDB()
        {
            try
            {
                string connectionString = "data source = ALPHA\\SQLEXPRESS; database = RailwayReservationDb; integrated security = SSPI;";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception exception)
            {   
                exception.ToString();
                return new SqlConnection();
            }                                     
        }
       
    }
}
