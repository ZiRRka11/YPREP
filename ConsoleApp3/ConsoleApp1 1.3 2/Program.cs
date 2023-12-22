using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp1 1.3 2nums.txt";
        string[] numbers = File.ReadAllText(filepath).Split(' ');

        for (int i = 0; i < numbers.Length; i++)
        {
            int num;
            if (int.TryParse(numbers[i], out num))
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}