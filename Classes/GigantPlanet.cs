using SOLID.BaseClasses;

namespace SOLID.Classes
{
    public class GigantPlanet : IPlanet
    {
        public GigantPlanet(string name, long weight, double diameter, double temp){
            Name = name;
            Weight = weight;
            Diameter = diameter;
            Temperature = temp;
        }
        public double Temperature {get;set;}
        public string Name     { get ; set ; }
        public long Weight     { get ; set ; }
        public double Diameter { get ; set ; }
        public void Action (IPlanetActions act)
        {
            act.Do(Name);
        }
    }
}