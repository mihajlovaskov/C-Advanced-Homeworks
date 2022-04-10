using System;
using System.Collections.Generic;

namespace DogShelter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog() {Id= 1, Name= "Johnny", Color= "black"};
            Dog dog2 = new Dog() {Id = 2, Name = "Jacky", Color = "white"};
            Dog dog3 = new Dog() {Id = 3, Name = "Butch", Color = "brown"};
            Dog invalidDog = new Dog() {Id = 4, Name= "L", Color = "red"};
            
            Console.WriteLine($"The properties of the dog object are valid (true/false): {Dog.IsDogValid(dog1)}");
            Console.WriteLine($"The properties of the dog object are valid (true/false): {Dog.IsDogValid(dog2)}");
            Console.WriteLine($"The properties of the dog object are valid (true/false): {Dog.IsDogValid(dog3)}");
            Console.WriteLine($"The properties of the dog object are valid (true/false): {Dog.IsDogValid(invalidDog)}");

            DogShelterClass.Dogs.Add(dog1);
            DogShelterClass.Dogs.Add(dog2);
            DogShelterClass.Dogs.Add(dog3);
            DogShelterClass.PrintAll();
        }
    }
}
