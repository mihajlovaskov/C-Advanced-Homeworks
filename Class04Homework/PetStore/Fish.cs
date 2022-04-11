using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int Size { get; set; }
        public Fish(string name, string type, int age, string color, int size)
            : base(name, type, age)
        {
            Color = color;
            Size = size;
        }
        public override string PrintInfo()
        {
            if (Size <= 20)
            {
                return $"Fish {Name} is a very small fish.";
            }
            else
            {
                return $"Fish {Name} is a big fish.";
            }
        }
    }
}
