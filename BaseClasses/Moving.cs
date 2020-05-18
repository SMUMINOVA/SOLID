namespace SOLID.BaseClasses
{
    public class Moving : IPlanetActions
    {
        public void Do(string planet)
        {
            System.Console.WriteLine($"{planet} is moving");;
        }
    }
}