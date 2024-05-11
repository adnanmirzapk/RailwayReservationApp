using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Reservations
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int RouteId { get; set; }   
        public string Class { get; set; }
        public string BookedByPassengerName { get; set; }
        public string CNIC { get; set; }
        public int AdultPassengers { get; set; }
        public int ChildPassengers { get; set; }
        public int InfantPassengers { get; set; }
        
    }
}
