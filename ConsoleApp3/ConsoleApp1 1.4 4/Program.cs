using System;

class Program
{
    static void Main(string[] args)
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp1 1.4 40\numsTask4.txt";
        string[] numbers = File.ReadAllText(filepath).Split(' ');

        int count = 0;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int Number = int.Parse(numbers[i]);
            int number = int.Parse(numbers[i + 1]);
            
            if(Number == number)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество одинаковых чисел:{count}");
    }
}