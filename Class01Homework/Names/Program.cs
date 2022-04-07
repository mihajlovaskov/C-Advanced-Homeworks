using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = new List<string>();
            Console.WriteLine("Please enter any name:");
            string name = Console.ReadLine().Trim();
            while (String.IsNullOrEmpty(name) || !Regex.IsMatch(name, @"^[a-zA-Z]+$"))//samo bukvi se dozvoleni
            {
                Console.WriteLine("You've entered an invalid name! Please try again!");
                name = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(name) && Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    break;
                }
            }
            listOfNames.Add(name);

            Console.WriteLine("Please enter another name or insert X:");
            string anotherName = Console.ReadLine().Trim();
            while (anotherName != "x" || anotherName != "X")
            {
                listOfNames.Add(anotherName);
                if (anotherName == "x" || anotherName == "X")
                {
                    break;
                }
                while (String.IsNullOrEmpty(anotherName) || !Regex.IsMatch(anotherName, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("You've entered an invalid name! Please try again!");
                    anotherName = Console.ReadLine().Trim();
                    listOfNames.Add(anotherName);
                }
                while ((!String.IsNullOrEmpty(anotherName) && Regex.IsMatch(anotherName, @"^[a-zA-Z]+$")))
                {
                    Console.WriteLine("Please enter another name or insert X:");
                    anotherName = Console.ReadLine().Trim();
                    listOfNames.Add(anotherName);
                    if (anotherName == "x" || anotherName == "X")
                    {
                        break;
                    }
                }
            }

            List<string> finalListOfNames = new List<string>();
            foreach (string item in listOfNames)
            {
                if (!String.IsNullOrEmpty(item) && Regex.IsMatch(item, @"^[a-zA-Z]+$")
                    && item != "x" && item != "X")
                {
                    finalListOfNames.Add(item);
                }
            }
            Console.WriteLine("The list of your names is the following:");
            foreach (string items in finalListOfNames)
            {
                Console.WriteLine(items);
            }

            Console.WriteLine("Enter any sentence:");
            string sentence = Console.ReadLine();
            while (String.IsNullOrEmpty(sentence))
            {
                Console.WriteLine("You've entered an empty sentence! Please try again!");
                sentence = Console.ReadLine();
                if (!String.IsNullOrEmpty(sentence))
                {
                    break;
                }
            }
            int counter = 0;
            string[] wordsInSentence = sentence.Split(' ');
            Console.WriteLine($"This is a list of words in your sentence:");
            foreach (string word in wordsInSentence)
            {
                Console.WriteLine(word);
            }

            foreach (string names in finalListOfNames)

            {
                foreach (string words in wordsInSentence)
                {
                    if (words.ToLower() == names.ToLower())
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"The name {names} is repeated {counter} time(s) in the sentence.");
                counter = 0;
            }

        }
    }
}
