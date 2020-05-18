namespace SOLID.BaseClasses
{
    public class PlanetsDeath : IPlanetActions
    {
        public void Do(string planet)
        {
            System.Console.WriteLine($"{planet} is dead");
        }
    }
}