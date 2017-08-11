using System;

namespace CollectionsNLists2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public float Speed { get; set; }

        public override string ToString()
        {
            return Name + " " + Model + " " + Speed;
        }
    }
}
