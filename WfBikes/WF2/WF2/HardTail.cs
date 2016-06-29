using System;

namespace WF2
{
    public class HardTail : Bike
    {
        public float Speed;
        public float Old;

        public HardTail(int id) : base(id)
        {

        }

       
        
    
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, Price, Speed, Old, BikeType.HardTail);
        }
    }
}