using System;
using System.Collections.Generic;

namespace SOLID_Vehicles.Vehicles
{
    public static class Vehicle
    {
        public static void NotImplementedException() => throw new System.InvalidOperationException(message: "This operation is not defined for this type of vehicle.");
    }
}