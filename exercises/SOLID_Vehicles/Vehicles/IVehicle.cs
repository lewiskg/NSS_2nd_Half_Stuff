using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        double MaxLandSpeed { get; set; }
        double MaxAirSpeed { get; set; }

        void Drive();
        void Fly();
        void Start();
        void Stop();
    }
}