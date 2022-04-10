using System;
using System.Collections.Generic;
using System.Text;

namespace DogShelter
{
    public static class DogShelterClass
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelterClass()
        {
            Dogs = new List<Dog>();
        }

        public static void PrintAll()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine($"Dog Id: {dog.Id}; Name: {dog.Name}; Color: {dog.Color}");
            }
        }
    }
}
