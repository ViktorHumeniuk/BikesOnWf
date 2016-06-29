using System;

namespace WF2
{
    public class Mountain : Bike
    {
        public Mountain(int id) : base(id)
        {
        }

        public string Material;
        public string CountryOfProduce;


      

        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, Price, Material, CountryOfProduce, BikeType.Mountain);
        }
    }
}