using System;

namespace WF2
{
    public class HardTail : Bike
    {
        public HardTail(int id) : base(id)
        {

        }

        public float MaxSpeed;
        public float Old;
        
    
        public override string ToString()
        {
            return string.Format("{0};{1};{2};{3};{4};{5}", Id, Name, Price, MaxSpeed, Old, BikeType.HardTail);
        }
    }
}