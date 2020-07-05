using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace BridgePattern {
    class Program {
        static void Main(string[] args) {
            var formatter = new StandardFormatter();
            var buildings = new List<IBuilding>();

            var apartment = new Apartment();
            apartment.Description = "Nice apartment.";
            apartment.Rooms.Add("1/A", "Cozy little room");
            apartment.Rooms.Add("2/C", "To be renovated");
            buildings.Add(apartment);

            var house = new House();
            house.Address = "New Street";
            house.Description = "Large family home.";
            house.Owner = "Mr. Smith.";
            buildings.Add(house);

            var trainStation = new TrainStation();
            trainStation.Director = "Mr. Kovacs";
            trainStation.Location = "Budapest";
            trainStation.NumberOfPassangers = 100000;
            trainStation.NumberOfTrains = 100;
            buildings.Add(trainStation);

            foreach (var building in buildings) {
                building.Print(formatter);
            }

            Console.ReadKey();
        }
    }
}