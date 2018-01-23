using System;
using System.Collections.Generic;

namespace Random_Planets
{
    class Program
    {
        static void Main(string[] args)
        {
        /*///////////////*/
        // List Practice //
        /*///////////////*/
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> lastTwoPlanetsList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(lastTwoPlanetsList);
            planetList.Insert(1,"Venus");
            planetList.Insert(2,"Earth");
            planetList.Add("Pluto");

            printList(planetList);

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0,4);

            printList(rockyPlanets);

            planetList.Remove("Pluto");
            printList(planetList);

            


        /*/////////////////////*/
        // Dictionary Practice //
        /*/////////////////////*/
        Dictionary<string, string> satellites = new Dictionary<string, string>();
        satellites.Add("Mariner 10", "Mercury");
        satellites.Add("MESSENGER", "Mercury");
        // satellites.Add("BepiColombo", "Mercury");
        // satellites.Add("Mercury Planetary Orbiter", "Mercury");
        // satellites.Add("Mercury Magnetospheric Orbiter", "Mercury");
        // satellites.Add("Tyazhely Sputnik", "Venus");
        // satellites.Add("Venera 1", "Venus");
        // satellites.Add("Mariner 1", "Venus");
        // satellites.Add("Sputnik 19", "Venus");
        // satellites.Add("Sputnik 20", "Venus");
        // satellites.Add("Sputnik 21", "Venus");
        satellites.Add("Mariner 2", "Venus");
        // satellites.Add("Cosmos 21", "Venus");
        // satellites.Add("Venera 1964A", "Venus");
        // satellites.Add("Venera 1964B", "Venus");
        // satellites.Add("Cosmos 27", "Venus");
        // satellites.Add("Cosmos 96", "Venus");
        // satellites.Add("Venera 1965A", "Venus");
        // satellites.Add("Venera 2", "Venus");
        // satellites.Add("Venera 3", "Venus");
        // satellites.Add("Kosmos 167", "Venus");
        satellites.Add("Venera 4", "Venus");
        satellites.Add("Mariner 5", "Venus");
        satellites.Add("Venera 5", "Venus");
        satellites.Add("Venera 6", "Venus");

        // satellites.Add("Cosmos 359", "Venus");
        satellites.Add("Venera 7", "Venus");
        satellites.Add("Cosmos 482", "Venus");
        satellites.Add("Venera 8", "Venus");
        // satellites.Add("Mariner 10", "Venus");
        satellites.Add("Venera 9", "Venus");
        satellites.Add("Venera 10", "Venus");
        satellites.Add("Pioneer Venus Orbiter", "Venus");
        satellites.Add("Pioneer Venus Multiprobe", "Venus");
        satellites.Add("Venera 12", "Venus");
        satellites.Add("Venera 11", "Venus");
        satellites.Add("Venera 13", "Venus");
        satellites.Add("Venera 14", "Venus");
        satellites.Add("Venera 15", "Venus");
        satellites.Add("Venera 16", "Venus");
        satellites.Add("Vega 1", "Venus");
        satellites.Add("Vega 2", "Venus");
        satellites.Add("Galileo", "Venus");
        satellites.Add("Magellan", "Venus");
        // satellites.Add("Cassini", "Venus");
        satellites.Add("Venus Express", "Venus");
        // satellites.Add("MESSENGER", "Venus");
        satellites.Add("Akatsuki", "Venus");
        satellites.Add("IKAROS", "Venus");
        satellites.Add("Shin\'en", "Venus");
        // satellites.Add("Mars 1M No.1", "Mars");
        // satellites.Add("Mars 1M No.2", "Mars");
        // satellites.Add("Mars 1962A", "Mars");
        // satellites.Add("Mars 1962B", "Mars");
        // satellites.Add("Mars 1", "Mars");
        // satellites.Add("Mariner 3", "Mars");
        satellites.Add("Mariner 4", "Mars");
        // satellites.Add("Zond 2", "Mars");
        satellites.Add("Mariner 6", "Mars");
        satellites.Add("Mariner 7", "Mars");
        // satellites.Add("Mars 1969A", "Mars");
        // satellites.Add("Mars 1969B", "Mars");
        // satellites.Add("Mariner 8", "Mars");
        // satellites.Add("Kosmos 419", "Mars");
        satellites.Add("Mariner 9", "Mars");
        satellites.Add("Mars 2", "Mars");
        satellites.Add("Mars 3", "Mars");
        // satellites.Add("Mars 4", "Mars");
        satellites.Add("Mars 5", "Mars");
        satellites.Add("Mars 6", "Mars");
        satellites.Add("Mars 7", "Mars");
        satellites.Add("Viking 1 Orbiter", "Mars");
        satellites.Add("Viking 2 Orbiter", "Mars");
        // satellites.Add("Phobos 1", "Mars");
        satellites.Add("Phobos 2", "Mars");
        // satellites.Add("Mars Observer", "Mars");
        // satellites.Add("Mars 96", "Mars");
        satellites.Add("Mars Pathfinder", "Mars");
        satellites.Add("Mars Polar Lander", "Mars");
        // satellites.Add("Mars Climate Orbiter", "Mars");
        satellites.Add("2001 Mars Odyssey", "Mars");
        satellites.Add("Nozomi", "Mars");
        satellites.Add("Mars Express", "Mars");
        satellites.Add("MER-A \"Spirit\"", "Mars");
        satellites.Add("MER-B \"Opportunity\"", "Mars");
        satellites.Add("Mars Reconnaissance Orbiter", "Mars");
        satellites.Add("Rosetta", "Mars");
        satellites.Add("Phoenix", "Mars");
        satellites.Add("Dawn", "Mars");
        satellites.Add("Yinghuo-1", "Mars");
        satellites.Add("MSL Curiosity", "Mars");
        satellites.Add("Mangalyaan / Mars Orbiter Mission", "Mars");
        satellites.Add("MAVENExoMars Trace Gas Orbiter (ExoMars 2016)", "Mars");
        satellites.Add("MAVEN", "Mars");
        satellites.Add("Pioneer 10", "Jupiter");
        satellites.Add("Pioneer 11", "Jupiter");
        satellites.Add("Voyager 1", "Jupiter");
        // satellites.Add("Voyager 2", "Jupiter");
        satellites.Add("Ulysses", "Jupiter");
        satellites.Add("Galileo Orbiter", "Jupiter");
        // satellites.Add("Cassini", "Jupiter");
        // satellites.Add("New Horizons", "Jupiter");
        satellites.Add("Juno", "Jupiter");
        // satellites.Add("Pioneer 11", "Saturn");
        // satellites.Add("Voyager 1", "Saturn");
        // satellites.Add("Voyager 2", "Saturn");
        satellites.Add("Cassini", "Saturn");
        satellites.Add("Voyager 2", "Uranus");
        // satellites.Add("Voyager 2", "Neptune");
        satellites.Add("New Horizons", "Pluto");
        
        
        printSatellitesSent(planetList, satellites);


        /*//////////*/
        // Function //
        /*//////////*/
        
        void printList(List<string> listVector)
        {
            Console.WriteLine("\n");
            foreach (string item in listVector)
			{
				Console.WriteLine(item);
			}
        }

        void printSatellitesSent(List<string> listOfPlanets, Dictionary<string, string> listOfSatillites)
        {
            foreach (string planet in listOfPlanets)
            {
                Console.WriteLine("\nPlanet: {0}", planet);
                foreach (KeyValuePair<string, string> sat in listOfSatillites)
                {
                    if (planet == sat.Value)
                    {
                        Console.WriteLine("\t{0}", sat.Key);
                    }
                }
            }
        }

        }
    }
}
