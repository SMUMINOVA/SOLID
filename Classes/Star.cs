using SOLID.BaseClasses;

namespace SOLID.Classes
{
    public class Star : IPlanet
    {

        public string Name     { get ; set ; }
        public long Weight     { get ; set ; }
        public double Diameter { get ; set ; }
        public double Temperature{ get ; set ; }
        public void Action (IPlanetActions act)
        {
            act.Do(Name);
        }
        public void Detonate(PlanetsDeath die){  //взрыв звезды
            System.Console.WriteLine($"{Name} was detonated");
            die.Do(Name);
        }
    }
}