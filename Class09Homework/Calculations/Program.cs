using System;
using System.IO;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatingNewDirectoryIfNotExisting(@"..\..\..\exercise\", "exercise");
            CreatingNewFileOrRewritingExistingFile(@"..\..\..\exercise\calculations.txt", "calculations");
            
            for (int i = 0; i < 3; i++)
            {
                var firstInteger = AskUserForIntegers();
                var secondInteger = AskUserForIntegers();
                int result = SumOfTwoIntegers(firstInteger, secondInteger);
                AppendAnyTextToTextFilesWithTimeStamp(@"..\..\..\exercise\calculations.txt", $"{firstInteger} + {secondInteger} = {result}");
            }
        }

        private static void CreatingNewDirectoryIfNotExisting(string directoryRelativePath, string nameOfDirectory)
        {
            if (!Directory.Exists(directoryRelativePath))
            {
                Directory.CreateDirectory(directoryRelativePath);
                Console.WriteLine($"Folder \"{nameOfDirectory}\" created.");
            }
        }
        private static void CreatingNewFileOrRewritingExistingFile(string fileRelativePath, string nameOfFile)
        {
            if (File.Exists(fileRelativePath))
            {
                File.Delete(fileRelativePath);
                File.Create(fileRelativePath).Close();
                Console.WriteLine($"File \"{nameOfFile}\" created.");
            }
            if (!File.Exists(fileRelativePath))
            {
                File.Create(fileRelativePath).Close();
                Console.WriteLine($"File \"{nameOfFile}\" created.");
            }
        }
        private static int AskUserForIntegers()
        {
            Console.WriteLine("Enter a valid integer:");
            var inputInteger = Console.ReadLine();
            int result;
            while (!int.TryParse(inputInteger, out result))
            {
                Console.WriteLine($"{inputInteger} is not a valid integer. Please try again!");
                inputInteger = Console.ReadLine();
            }
            return result; 
        }
        private static int SumOfTwoIntegers(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"The sum of the two integeres is: {sum}");
            return sum;
        }
        private static void AppendAnyTextToTextFilesWithTimeStamp(string fileRelativePath, string anyText) 
        {
            File.AppendAllText(fileRelativePath, $"{DateTime.Now.ToLongTimeString()}: {anyText} \n");
        }
    }
}
