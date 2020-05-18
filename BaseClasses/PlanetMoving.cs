namespace SOLID.BaseClasses
{
    public class PlanetMoving : IPlanetActions
    {
        public void Do(string planet)
        {
            System.Console.WriteLine($"{planet} is moving");;
        }
    }
}