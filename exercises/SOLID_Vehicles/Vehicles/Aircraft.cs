using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public class Aircraft : IVehicle
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
            Vehicle.NotImplementedException();
        }

        public void Fly()
        {
            if (_vehicleOn == false)
            {
                Console.WriteLine("The {0} must be started before it can be flown.", Name);
            }
            else
            {
                Console.WriteLine("The {0} effortlessly glides through the clouds like a gleaming god of the Sun.", Name);
            }
        }

        public void Start()
        {
            _vehicleOn = true;
            Console.WriteLine("The {0} has been started.", Name);
        }

        public void Stop()
        {
            _vehicleOn = false;
            Console.WriteLine("The {0} has been turned off.", Name);
        }

        // Constructor
        public Aircraft(string name, int wheels, int numDoors, int passengerCapacity, bool winged, string transType, double engVol, double maxAirSpeed)
        {
            Name = name;
            Wheels = wheels;
            Doors = numDoors;
            PassengerCapacity = passengerCapacity;
            Winged = winged;
            TransmissionType = transType;
            EngineVolume = engVol;
            MaxAirSpeed = maxAirSpeed;
        }
        // ToString() Method
        public override string ToString()
        {
            string vehicleDetails = $"Name: {Name}, Num of wheels: {Wheels}, Num of doors: {Doors}, Passenger capacity: {PassengerCapacity}, Winged: {Winged}, Transmission type: {TransmissionType}, Engine volume [L]: {EngineVolume}, Max air speed [knots/hr]: {MaxAirSpeed}";
            return vehicleDetails;
        }
    }
}