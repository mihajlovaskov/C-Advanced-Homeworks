using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }

        public int LifesLeft { get; set; }
        public Cat(string name, string type, int age, bool lazy, int lifesleft)
            : base(name, type, age)
        {
            Lazy = lazy;
            LifesLeft = lifesleft;
        }
        public override string PrintInfo()
        {
            if (Lazy)
            {
                return $"Cat {Name} is lazy.";
            }
            else
            {
                return $"Cat {Name} is not lazy.";
            }
        }
    }
}
