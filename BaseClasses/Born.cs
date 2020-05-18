using System;
namespace SOLID.BaseClasses
{
    public class Born : IPlanetActions
    {
        public void Do(string planet)
        {
            Console.WriteLine($"{planet} was born");
        }
    }
}