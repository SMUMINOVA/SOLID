using SOLID.BaseClasses;

namespace SOLID.Classes
{
    public class Star : IPlanet
    {
        public Star(string name,long weight, double diameter, double temp){
            Name = name;
            Weight = weight;
            Diameter = diameter;
            Temperature = temp;
            Action(new Born());
        }
        public Star(){}
        public string Name     { get ; set ; }
        public long Weight     { get ; set ; }
        public double Diameter { get ; set ; }
        public double Temperature{ get ; set ; }
        public void Action (IPlanetActions act)
        {
            act.Do(Name);
        }
        public void Detonate(Death die){  //взрыв звезды
            System.Console.WriteLine($"{Name} was detonated");
            die.Do(Name);
        }
    }
}