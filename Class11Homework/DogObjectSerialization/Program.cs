using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace DogObjectSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> anyDogList=AskUserToInstanceDogObject();
            CreatingNewFileOrRewritingExistingFile(@"..\..\..\dogObjectsInJsonFormat.txt", "dogObjectsInJsonFormat");
            AppendAnyTextToTextFiles(@"..\..\..\dogObjectsInJsonFormat.txt", anyDogList);
            ReadsDeserailizesAndWrites(@"..\..\..\dogObjectsInJsonFormat.txt");
        }
        
        private static string AskUserForDogName()
        {
            Console.WriteLine("Enter valid name of a dog:");
            string nameDog = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(nameDog) || !Regex.IsMatch(nameDog, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine($"{nameDog} is not a valid name. Please try again!");
                nameDog = Console.ReadLine().Trim();
            }
            return nameDog;
        }
        private static string AskUserForDogColor()
        {
            Console.WriteLine("Enter valid color of a dog (the name of the color should be \"known\" to the system):");
            string colorDog = Console.ReadLine().Trim();
            List<string> listOfDrawingColours = new List<string>();
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                listOfDrawingColours.Add(color.ToString().ToUpper());
            }
            while (!listOfDrawingColours.Contains(colorDog.ToUpper()))
            {
                Console.WriteLine($"{colorDog} is not a color \"known\" to the system. Please try again!");
                colorDog = Console.ReadLine().Trim();
            }
            return colorDog;
        }
        private static int AskUserForDogAge()
        {
            Console.WriteLine("Enter valid age of a dog:");
            var inputNumber = Console.ReadLine().Trim();
            int dogAge;
            while (!int.TryParse(inputNumber, out dogAge) || dogAge <= 0)
            {
                Console.WriteLine($"{inputNumber} is not a valid age of a dog. Please try again!");
                inputNumber = Console.ReadLine();
            }
            return dogAge;
        }
        
        private static List<Dog> AskUserToInstanceDogObject()
        {
            List<Dog> dogList = new List<Dog>();
            Console.WriteLine("Would you like to instance a dog object (enter Y or N)?");
            string response = Console.ReadLine().Trim().ToUpper();
            while (response == "Y" || response == "N" || (response != "Y" && response != "N"))
            {
                if (response == "N")
                {
                    break;
                }
                else if (response != "Y" && response != "N")
                {
                    Console.WriteLine("Your entry is not valid! Enter Y or N!");
                    response = Console.ReadLine().Trim().ToUpper();
                }
                else if (response == "Y")
                {
                    Dog anyDog = new Dog(AskUserForDogName(), AskUserForDogAge(), AskUserForDogColor());
                    dogList.Add(anyDog);
                    Console.WriteLine("Would you like to instance another dog object (enter Y or N)?");
                    response = Console.ReadLine().Trim().ToUpper();
                }
            }
            return dogList;
        }
        private static void CreatingNewFileOrRewritingExistingFile(string fileRelativePath, string nameOfFile)
        {
            if (File.Exists(fileRelativePath))
            {
                File.Delete(fileRelativePath);
                File.Create(fileRelativePath).Close();
            }
            if (!File.Exists(fileRelativePath))
            {
                File.Create(fileRelativePath).Close();
            }
        }
        private static void AppendAnyTextToTextFiles(string fileRelativePath, List<Dog>dogList)
            {
            
            File.AppendAllText(fileRelativePath, JsonConvert.SerializeObject(dogList, Formatting.Indented));
        }
        public static void ReadsDeserailizesAndWrites(string fileRelativePath)
        {
            List<Dog>desearilizedDogsList;
            string serializedTxtContent = File.ReadAllText(fileRelativePath);
            desearilizedDogsList = JsonConvert.DeserializeObject<List<Dog>>(serializedTxtContent);
            Console.WriteLine("This is a deserialized list of your dogs:");
            foreach (Dog dog in desearilizedDogsList)
            {
                Console.WriteLine($"Dog name: {dog.Name}, dog age: {dog.Age}, dog color: {dog.Color}");
            }
            if (desearilizedDogsList.Count == 0)
            {
                Console.WriteLine("The list of your dog objects is empty.");
                File.Delete(fileRelativePath);
            }
        }
    }
}
