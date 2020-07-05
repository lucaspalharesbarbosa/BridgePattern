using Domain.Interfaces;
using System;

namespace Domain {
    public class House : IBuilding {
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }

        public void Print(IFormatter formatter) {
            Console.WriteLine(formatter.Format("Description: ", Description));
            Console.WriteLine(formatter.Format("Owner: ", Owner));
            Console.WriteLine(formatter.Format("Address: ", Address));
        }
    }
}
