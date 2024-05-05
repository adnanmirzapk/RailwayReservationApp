
using RailwayReservationLibrary.DataAccess;
using System.Data.SqlClient;

namespace RailwayReservationLibrary.Entities
{
    public class TrainDataLogic
    {
        public int CreateTrain(Trains train)
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string sqlInsertQuery = $"Insert into Trains (TrainName, Description, NoOfCoaches, RouteId) Values ('{train.TrainName}', '{train.Description}', '{train.NoOfCoaches}', '{train.RouteId}');";

                SqlCommand cmd = new SqlCommand(sqlInsertQuery, connection);
                return cmd.ExecuteNonQuery();
            }            
        }


        public int UpdateTrain(Trains train) 
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string sqlUpdateQuery = $"Update Trains Set TrainName = '{train.TrainName}', Description = '{train.Description}', NoOfCoaches = '{train.NoOfCoaches}', RouteId = '{train.RouteId}' where Id = '{train.Id}'";

                SqlCommand cmd = new SqlCommand(sqlUpdateQuery, connection);
                return cmd.ExecuteNonQuery();
            }
        }

        public Trains Find(string trainName)
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                Trains train = new Trains();
                string sqlFindQuery = $"Select * from trains where TrainName = @TrainName";

                SqlCommand cmd = new SqlCommand(sqlFindQuery, connection);
                cmd.Parameters.AddWithValue("@TrainName", trainName);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        train.Id = (int)rdr["Id"];
                        train.TrainName = rdr["TrainName"].ToString();
                        train.Description = rdr["Description"].ToString();
                        train.NoOfCoaches = (int)rdr["NoOfCoaches"];
                        train.RouteId = (int)rdr["RouteId"];
                    }
                }

                return train;
            }
        }

        public List<Trains> GetAllTrains()
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                List<Trains> trains = new List<Trains>();
                string sqlSelectAll = "Select * from Trains";

                SqlCommand cmd = new SqlCommand(sqlSelectAll, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        trains.Add(new Trains()
                        {
                            Id = (int)rdr["Id"],
                            TrainName = rdr["TrainName"].ToString(),
                            Description = rdr["Description"].ToString(),
                            NoOfCoaches = (int)rdr["NoOfCoaches"],
                            RouteId = (int)rdr["RouteId"]
                        });
                    }
                }

                return trains;
            }            
        }
    }
}
