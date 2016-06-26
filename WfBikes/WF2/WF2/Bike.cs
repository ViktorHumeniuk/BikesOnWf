using System;

namespace WF2
{
    public class Bike
    {
        public readonly int Id;
        public string Name { get; set; }
        public float Price { get; set; }

        public Bike(int id)
        {
            Id = id;
        }
    }
}