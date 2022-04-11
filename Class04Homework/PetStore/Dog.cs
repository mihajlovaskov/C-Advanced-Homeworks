using System;
using System.Collections.Generic;
using System.Text;

namespace PetStore
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }

        public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age, bool goodboy, string favoritefood)
            : base(name, type, age)
        {
            GoodBoy = goodboy;
            FavoriteFood = favoritefood;
        }
        public override string PrintInfo()
        {
            if (GoodBoy)
            {
                return $"Dog {Name} eats his favorite food: {FavoriteFood}.";
            }
            else
            {
                return $"Dog {Name} doesn't eat his favorite food: {FavoriteFood}.";
            }
        }
    }
}
