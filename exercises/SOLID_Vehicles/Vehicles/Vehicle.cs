using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public class Vehicle : IVehicle
    {

        // Field
        private string _name;

        // Properties
        public string Name { get => _name; set => _name = value; }
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 113;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 309.0;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        // Constructor
        public Aircraft ( string name, int wheels, int numDoors, int passengerCapacity, bool winged, string transType, double engVol, double maxAirSpeed)
        {

        }
    }
}