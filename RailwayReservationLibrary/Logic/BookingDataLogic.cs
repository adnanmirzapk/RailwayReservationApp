using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;


namespace RailwayReservationLibrary.Logic
{
    public class BookingDataLogic
    {
        public List<Reservations> GetAll()
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                List<Reservations> bookings = new List<Reservations>();
                string sqlQuery = "Select * from Bookings";

                return bookings;
            }

        } 
    }
}
