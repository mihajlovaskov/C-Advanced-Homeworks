using System;

namespace PetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.Add(new Dog("Johnny", "labrador", 8, true,"cats"));
            dogStore.Add(new Dog("Jacky", "shepard", 5, false,"rats"));
            dogStore.PrintPets();

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.Add(new Cat("Kitty", "persian", 4, false, 5));
            catStore.Add(new Cat("Catty", "stray", 6, true, 4));
            catStore.PrintPets();

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.Add(new Fish("Nemo", "trout", 2, "grey", 5));
            fishStore.Add(new Fish("Dory", "salmon", 1, "yellow", 23));
            fishStore.PrintPets();

            dogStore.BuyPet("Johnny");
            catStore.BuyPet("InvalidName");
        }
    }
}
