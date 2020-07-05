using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Domain {
    public class Apartment : IBuilding {
        public Apartment() {
            Rooms = new Dictionary<string, string>();
        }

        public string Description { get; set; }
        public Dictionary<string, string> Rooms { get; set; }

        public void Print(IFormatter formatter) {
            Console.WriteLine(formatter.Format("Description: ", Description));

            foreach (var room in Rooms) {
                Console.WriteLine(string.Concat(formatter.Format("Room: ", room.Key),
                    formatter.Format(", room description: ", room.Value)));
            }
        }
    }
}
