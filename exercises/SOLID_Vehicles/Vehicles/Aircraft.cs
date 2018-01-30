using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public class Aircraft : IVehicle
    {

        // Field
        private string _name;
        private string _wheels;
        private string _doors;
        private string _capacity;
        private string _winged;
        private string _transmission;
        private string _engineVolume;
        private string _maxWaterSpeed;
        private string _maxLandSpeed;
        private string _maxAirSpeed;
        
        // Properties
        public string Name { get => _name; set => _name = value; }
        public int Wheels { get => _wheels; set => _wheels = value; }  //3
        public int Doors { get => _doors; set => _doors = value; }
        public int PassengerCapacity { get => _capacity; set => _capacity = value; } //113
        public bool Winged { get => _winged; set => _winged = value; } //true
        public string TransmissionType { get => _transmission; set => _transmission = value; }  //"None"
        public double EngineVolume { get => _engineVolume; set => _engineVolume = value; } //31.0
        public double MaxWaterSpeed { get => _maxWaterSpeed; set => _maxWaterSpeed = value; }  //0
        public double MaxLandSpeed { get => _maxLandSpeed; set => _maxLandSpeed = value; }  //0
        public double MaxAirSpeed { get => _maxAirSpeed; set => _maxAirSpeed = value; } //309.0

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