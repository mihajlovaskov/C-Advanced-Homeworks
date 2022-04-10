using System;

namespace DogShelter
{
    public class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public static bool IsDogValid(Dog dog)
        {
            if (dog.Id.GetType() != typeof(int) || 
                dog.Id < 0 || 
                dog.Name.GetType() != typeof(string) ||
                String.IsNullOrEmpty(dog.Name) ||
                dog.Name.Length < 2 ||
                dog.Color.GetType() != typeof(string)||
                String.IsNullOrEmpty(dog.Color) )
            { 
                return false;
            }
            return true;
        }
        public void Bark()
        {
            Console.WriteLine("Bark, Bark");
        }
    }
}
