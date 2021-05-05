using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Train.Models.Train
{
    public class TrainData
    {
        public int TrainNumber { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public int AvailableSeats { get; set; }
    }
}