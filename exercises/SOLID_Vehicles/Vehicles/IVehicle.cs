using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; }
        public bool Winged { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive();
        public void Fly();
        public void Start();
        public void Stop();

    }
}