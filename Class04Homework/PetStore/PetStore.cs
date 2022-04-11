using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetStore
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Pets = new List<T>();

        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets()
        {
            foreach (T pet in Pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }
        public void Add(T pet)
        {

            Pets.Add(pet);
        }
        public void BuyPet(string name)
        {
            try
            {
                T pet = Pets.First(x => x.Name == name);
                Pets.Remove(pet);
                Console.WriteLine($"Pet {name} has been bought and removed from the store.");
            }
            catch (Exception)
            {
                Console.WriteLine($"Pet with name {name} does not exist.");
            }
        }
    }
}
