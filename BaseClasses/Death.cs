namespace SOLID.BaseClasses
{
    public class Death : IPlanetActions
    {
        public void Do(string planet)
        {
            System.Console.WriteLine($"{planet} is dead");
        }
    }
}