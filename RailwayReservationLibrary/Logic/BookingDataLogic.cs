using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;


namespace RailwayReservationLibrary.Logic
{
    public class BookingDataLogic
    {
        public List<Bookings> GetAll()
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                List<Bookings> bookings = new List<Bookings>();
                string sqlQuery = "Select * from Bookings";

                return bookings;
            }

        } 
    }
}
