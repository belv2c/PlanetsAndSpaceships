using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetList = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(lastPlanetList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            List<string> rockyPlanetsList = planetList.GetRange(0, 4).ToList();

            planetList.Remove("Pluto");


            Dictionary<string, string> probeDictionary = new Dictionary<string, string>()
            {
                { "Mariner 10", "Mercury" },
                { "Messenger", "Murcury" },
                { "Mariner 2", "Venus" },
                { "Venera 4", "Venus" },
                { "Mariner 5", "Venus" },
                { "Mariner 4", "Earth" },
                { "Mariner 6", "Earth" },
                { "Mariner 7", "Earth" },
                { "Pioneer 10", "Jupiter" },
                { "Pioneer 11", "Jupiter" },
                { "Voyager 4", "Jupiter" },
                { "Cassini", "Saturn" },
                { "Voyager 2", "Neptune" },
                { "Voyager 1", "Jupiter" }

            };


            foreach(var planet in planetList)
            {
                Console.Write($"{planet}:");
                foreach(var probe in probeDictionary)
                {
                    if (probe.Value == planet)
                    {
                        Console.Write($"{probe.Key}");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
