using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public class Groundcraft : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; } = 160.4;
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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
        public Groundcraft ( string name, int wheels, int numDoors, int passengerCapacity, bool winged, string transType, double engVol, double maxAirSpeed)
        {

        }

    }
}