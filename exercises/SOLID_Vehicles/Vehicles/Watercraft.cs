using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public class Watercraft : IVehicle
    {
        // Field
        private string _name;
        private int _wheels;
        private int _doors;
        private int _capacity;
        private bool _winged;
        private string _transmission;
        private double _engineVolume;
        private double _maxWaterSpeed;
        private double _maxLandSpeed;
        private double _maxAirSpeed;
        private bool _vehicleOn = false;

        // Properties
        public string Name { get => _name; set => _name = value; } //2
        public int Wheels { get => _wheels; set => _wheels = value; }  //0
        public int Doors { get => _doors; set => _doors = value; }
        public int PassengerCapacity { get => _capacity; set => _capacity = value; }
        public bool Winged { get => _winged; set => _winged = value; } //false
        public string TransmissionType { get => _transmission; set => _transmission = value; }  //"Manual"
        public double EngineVolume { get => _engineVolume; set => _engineVolume = value; } //1.3
        public double MaxWaterSpeed { get => _maxWaterSpeed; set => _maxWaterSpeed = value; }
        public double MaxLandSpeed { get => _maxLandSpeed; set => _maxLandSpeed = value; }  //160.4
        public double MaxAirSpeed { get => _maxAirSpeed; set => _maxAirSpeed = value; }

        public void Drive()
        {
            if (_vehicleOn == false)
            {
                Console.WriteLine($"The {Name} must be started before it can be driven.");
            } else 
            {
                Console.WriteLine($"The {Name} makes waves as it cuts through the water.");
            }
        }

        public void Fly()
        {
            Vehicle.NotImplementedException();
        }

        public void Start()
        {
            _vehicleOn = true;
            Console.WriteLine($"The {Name} has been started.");
        }

        public void Stop()
        {
            _vehicleOn = false;
           Console.WriteLine($"The {Name} has been turned off.");
        }

        // Constructor
        public Watercraft(string name, int wheels, int numDoors, int passengerCapacity, bool winged, string transType, double engVol, double maxWaterSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = numDoors;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            TransmissionType = transType;
            EngineVolume = engVol;
            MaxWaterSpeed = maxWaterSpeed;
        }
        // ToString() Method
        public override string ToString()
        {
            string vehicleDetails = $"Name: {Name}, Num of wheels: {Wheels}, Num of doors: {Doors}, Passenger capacity: {PassengerCapacity}, Winged: {Winged}, Transmission type: {TransmissionType}, Engine volume [L]: {EngineVolume}, Max water speed [nm/hr]: {MaxWaterSpeed}";
            return vehicleDetails;
        }

    }
}