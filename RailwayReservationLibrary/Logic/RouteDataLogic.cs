

using RailwayReservationLibrary.DataAccess;
using RailwayReservationLibrary.Entities;
using System.Data.SqlClient;

namespace RailwayReservationLibrary.Logic
{
    public class RouteDataLogic
    {
        public int CreateRoute(Route route)
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string InsertRouteQuery = $"Insert into Routes (RouteName, DepartureStationId, DestinationStationId, Distance, Fare) Values ( '{route.RouteName}', '{route.DepartureStationId}' , '{route.DestinationStationId}', '{route.Distance}', '{route.Fare}');";

                SqlCommand cmd = new SqlCommand(InsertRouteQuery, connection);

                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateRoute(Route route)
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                string UpdateRouteQuery = $"Update Routes SET RouteName = '{route.RouteName}', DepartureStationId = '{route.DepartureStationId}', DestinationStationId = '{route.DestinationStationId}', Distance = '{route.Distance}', Fare = '{route.Fare}' Where Id = @Id";

                SqlCommand cmd = new SqlCommand(UpdateRouteQuery, connection);
                cmd.Parameters.AddWithValue("@Id", route.Id);

                return cmd.ExecuteNonQuery();
            }
        }

        public Route Find(string routeName)
        {
            using(SqlConnection connection = ApplicationDbContext.ConnectToDB()) 
            {
                Route route = new Route();
                string sqlFind = "Select * from Routes where RouteName = @RouteName";

                SqlCommand cmd = new SqlCommand(sqlFind, connection);
                cmd.Parameters.AddWithValue("@RouteName", routeName);

                SqlDataReader rdr =  cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        route.Id = (int)rdr["Id"];
                        route.RouteName = rdr["RouteName"].ToString();
                        route.DepartureStationId = (int)rdr["DepartureStationId"];
                        route.DestinationStationId = (int)rdr["DestinationStationId"];
                        route.Distance = (int)rdr["Distance"];
                        route.Fare = (int)rdr["Fare"];
                    }                   
                }
                return route;
            }
        }

        public List<Route> GetAllRoutes()
        {
            using (SqlConnection connection = ApplicationDbContext.ConnectToDB())
            {
                List<Route> routes = new List<Route>();
                string sqlQuery = "Select * from Routes";

                SqlCommand cmd = new SqlCommand(sqlQuery, connection);                

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Route route = new Route();
                        route.Id = (int)rdr["Id"];
                        route.RouteName = rdr["RouteName"].ToString();
                        route.DepartureStationId = (int)rdr["DepartureStationId"];
                        route.DestinationStationId = (int)rdr["DestinationStationId"];
                        route.Distance = (int)rdr["Distance"];
                        route.Fare = (int)rdr["Fare"];

                        routes.Add(route);
                    }
                }
                return routes;
            }
        }

    }
}
