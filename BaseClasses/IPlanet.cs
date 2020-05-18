namespace SOLID.BaseClasses
{
    public interface IPlanet
    {
        public string Name{get;set;}
        public long Weight{get;set;}
        public double Diameter{get;set;}
        public void Action (IPlanetActions act)
        {
            act.Do(Name);
        }
    }
}