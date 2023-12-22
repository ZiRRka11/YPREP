using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp15 5.4\numsTask4.txt";
        string file = File.ReadAllText(filepath);
        string[] numbers = file.Split(' ');

        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num > max)
            {
                max = num;
            }
            else if (num + 1 < max)
            {
                sum += num + 1;
            }
        }
        Console.WriteLine("Сумма элементов:" + sum);
    }
}