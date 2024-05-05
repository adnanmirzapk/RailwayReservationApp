using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string RouteName { get; set; }
        public int DepartureStationId { get; set; }
        public int DestinationStationId { get; set; }
        public double Distance { get; set; }
        public int Fare { get; set; }        
    }
}
