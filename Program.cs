using System;
using SOLID.Classes;
using SOLID.BaseClasses;

namespace SOLID_16_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var SolarSystem = new StarSystem(new Star("Solar", 5000000,600000,200));
            SolarSystem.EPlanets.Add(new EarthTypePlanet("Mars", 12000,30000));
            SolarSystem.EPlanets[0].Action(new Moving());
        }
    }
}
