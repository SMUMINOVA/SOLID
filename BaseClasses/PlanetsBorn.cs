using System;
namespace SOLID.BaseClasses
{
    public class PlanetsBorn : IPlanetActions
    {
        public void Do(string planet)
        {
            Console.WriteLine($"{planet} was born");
        }
    }
}