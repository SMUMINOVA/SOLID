using System.Collections.Generic;

namespace SOLID.Classes
{
    public class StarSystem
    {
        public StarSystem(Star s){
            s = SystemsStar;
        }
        public Star SystemsStar {get;set;}
        public List<EarthTypePlanet> EPlanets{get;set;}
        public List<GigantPlanet> GPlanets{get;set;}
    }
}