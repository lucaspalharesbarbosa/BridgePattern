using Domain.Interfaces;
using System;

namespace Domain {
    public class TrainStation : IBuilding {
        public int NumberOfTrains { get; set; }
        public string Location { get; set; }
        public int NumberOfPassangers { get; set; }
        public string Director { get; set; }

        public void Print(IFormatter formatter) {
            Console.WriteLine(formatter.Format("Number of trains: ", NumberOfTrains.ToString()));
            Console.WriteLine(formatter.Format("Location: ", Location));
            Console.WriteLine(formatter.Format("Number of passangers:", NumberOfPassangers.ToString()));
            Console.WriteLine(formatter.Format("Director: ", Director));
        }
    }
}
