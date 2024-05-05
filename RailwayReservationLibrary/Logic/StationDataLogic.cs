using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;

namespace RailwayReservationLibrary.Logic
{
    public class StationDataLogic
    {
        public int CreateStation(Station station)
        {           
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string InsertStationQuery = $"Insert into Stations (StationName, City) Values ( '{station.StationName}', '{station.City}');";

                SqlCommand cmd = new SqlCommand(InsertStationQuery, connection);

                return cmd.ExecuteNonQuery();
            }                        
        }
        
        public Station Find(string stationName)
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                Station station = new Station();
                string sqlQuery = "Select * from Stations where StationName = @StationName";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                cmd.Parameters.AddWithValue("@StationName", stationName);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        station.Id = (int)rdr["Id"];
                        station.StationName = Convert.ToString(rdr["StationName"]);
                        station.City = Convert.ToString(rdr["City"]);
                    }
                }

                return station;
            }
        }

        public int UpdateStation(Station station)
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string sqlQuery = $"Update Stations Set StationName = '{station.StationName}', City = '{station.City}' Where Id = @Id";

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@Id", station.Id);
                return cmd.ExecuteNonQuery();
            }
        }


        public List<Station> GetAllStations()
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                List<Station> stations = new List<Station>();
                string sqlQuery = "Select * from Stations";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);                

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Station station = new Station
                        {
                            Id = (int)rdr["Id"],
                            StationName = Convert.ToString(rdr["StationName"]),
                            City = Convert.ToString(rdr["City"])
                        };
                        stations.Add(station);
                    }
                }
                return stations;
            }
        }
    }
}
