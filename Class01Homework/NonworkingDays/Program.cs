using System;

namespace NonworkingDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to check if a chosen date is non-working day in Macedonia - enter yes or no:");
            string ask = Console.ReadLine().Trim();
            while (ask.ToLower() != "yes" && ask.ToLower() != "no")
            {
                Console.WriteLine("Enter yes or no please!");
                ask = Console.ReadLine().Trim();
            }
            while (ask.ToLower() == "yes" || ask.ToLower() == "no")
            {
                if (ask.ToLower() == "no")
                {
                    Console.WriteLine("Thank you! The app will be closed.");
                    break;
                }

                Console.WriteLine("Enter any date in the following format mm/dd/yyyy (e.g. June 3, 2011 = 6/3/2011):");
                string yourDate = Console.ReadLine().Trim();
                while (!DateTime.TryParse(yourDate, out var value))
                {
                    Console.WriteLine("You've entered an invalid date! Please try again in the following format mm/dd/yyyy (e.g. June 3, 2011 = 6/3/2011)");
                    yourDate = Console.ReadLine().Trim();
                    if ((DateTime.TryParse(yourDate, out value)))
                    {
                        break;
                    }
                }
                DateTime parsedYourDate = DateTime.Parse(yourDate);
                if (parsedYourDate.DayOfWeek == DayOfWeek.Sunday
                    || parsedYourDate.DayOfWeek == DayOfWeek.Saturday
                    || (parsedYourDate.Month == 01 && parsedYourDate.Day == 01)
                    || (parsedYourDate.Month == 01 && parsedYourDate.Day == 07)
                    || (parsedYourDate.Month == 04 && parsedYourDate.Day == 20)
                    || (parsedYourDate.Month == 05 && parsedYourDate.Day == 01)
                    || (parsedYourDate.Month == 05 && parsedYourDate.Day == 25)
                    || (parsedYourDate.Month == 08 && parsedYourDate.Day == 03)
                    || (parsedYourDate.Month == 09 && parsedYourDate.Day == 08)
                    || (parsedYourDate.Month == 10 && parsedYourDate.Day == 12)
                    || (parsedYourDate.Month == 10 && parsedYourDate.Day == 23)
                    || (parsedYourDate.Month == 12 && parsedYourDate.Day == 08))
                {
                    Console.WriteLine($"{yourDate} is non-working day in Macedonia.");
                }
                else
                {
                    Console.WriteLine($"{yourDate} is working day in Macedonia.");
                }
                Console.WriteLine("Would you like to check if another chosen date is non-working day in Macedonia - enter yes or no:");
                ask = Console.ReadLine().Trim();
                while (ask.ToLower() != "yes" && ask.ToLower() != "no")
                {
                    Console.WriteLine("Enter yes or no please!");
                    ask = Console.ReadLine().Trim();
                }
            }
        }
    }
}
