using SOLID.BaseClasses;

namespace SOLID.Classes
{
    public class EarthTypePlanet : IPlanet
    {
        public EarthTypePlanet(string name, long weight, double diameter){
            Name = name;
            Weight = weight;
            Diameter = diameter;
            Action(new Born());
        }
        public EarthTypePlanet(){}
        public string Name     { get; set ; }
        public long Weight     { get; set ; }
        public double Diameter { get; set ; }
        public void Action (IPlanetActions act)
        {
            act.Do(Name);
        }
        public bool InhabitStatus{get;set;}
        public void GetInhabitStatus(){
            if(InhabitStatus){
                System.Console.WriteLine($"{Name} is inhabited");
            }        
            else{
                System.Console.WriteLine($"{Name} is'n inhabited" );
            }
        }
    }
}