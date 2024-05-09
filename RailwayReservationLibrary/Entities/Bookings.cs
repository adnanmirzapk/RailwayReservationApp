using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Bookings
    {
        public int Id { get; set; }
        public int TrainId { get; set; }
        public int FromStationId { get; set; }
        public int ToStationId { get; set; }
        public string Class { get; set; }
        public string BookedByPassengerName { get; set; }
        public string CNIC { get; set; }
        public int AdultPassengers { get; set; }
        public int ChildPassengers { get; set; }
        public int InfantPassengers { get; set; }
        public int EmployeeId { get; set; }
    }
}
