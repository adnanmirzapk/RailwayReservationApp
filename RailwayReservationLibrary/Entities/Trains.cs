using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationLibrary.Entities
{
    public class Trains
    {
        public int Id { get; set; }
        public string TrainName { get; set; }
        public string Description { get; set; }        
        public int NoOfCoaches { get; set; }
        public int RouteId { get; set; }    
    }
}
