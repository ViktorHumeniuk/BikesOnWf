using System;

namespace WF2
{
    public class Cross : Bike
    {
        public float CrossDiametr;
        public float CrossWeight;

        public Cross(int id) : base(id)
        {
        }

       
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, Price, CrossDiametr, CrossWeight, BikeType.Cross);
        }
    }
}