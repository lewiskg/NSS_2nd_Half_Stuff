using System;
using System.Linq;
using System.Collections.Generic;
using SOLID_Vehicles.Vehicles;

public class Program
{

    public static void Main() {

        // Create two types of vehicles for each vehicle type
        Aircraft air01 = new Aircraft("Cessna 172", 3, 2, 4, true, "NA", 31.1, 163);
        Aircraft air02 = new Aircraft("Piper PA-28 Cherokee", 3, 2, 6, true, "NA", 30.5, 132);
        
        Groundcraft land01 = new Groundcraft("Dodge Challenger", 4, 2, 4, false, "manual 6-speed", 5.7, 155);
        Groundcraft land02 = new Groundcraft("Chevrolet Camaro SS", 4, 2, 4, false, "automatic 8-speed", 6.2, 165);

        Watercraft water01 = new Watercraft("See-Doo GTR X 230 Jetski", 0, 0, 2, false, "NA", 1.5, 52);
        Watercraft water02 = new Watercraft("See-Doo RXP X 300 Jetski", 0, 0, 2, false, "NA", 2.5, 84);

        // Consolidate vehicles into vehicle type collections
        List<Aircraft> aircraftList = new List<Aircraft> { air01, air02 };
        List<Groundcraft> groundcraftList = new List<Groundcraft> { land01, land02 };
        List<Watercraft> watercraftList = new List<Watercraft> { water01, water02 };


        // Fly the vehicles
        foreach( var v in aircraftList)
        {
            v.Start();
            v.Fly();
        }

        // Drive the vehicles on land
        foreach (var v in groundcraftList)
        {
            v.Start();
            v.Drive();
        }

        // Pilot the vehicles through the water
        foreach (var v in watercraftList)
        {
            v.Start();
            v.Drive();
        }

        // Console.WriteLine(air01.ToString());
        // Console.WriteLine(land01.ToString());
        // Console.WriteLine(water01.ToString());

    }

}

