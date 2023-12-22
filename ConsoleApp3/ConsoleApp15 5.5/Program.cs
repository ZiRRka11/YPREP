using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp15 5.5\numsTask5.txt";
        string file = File.ReadAllText(filepath);
        string[] numbers = file.Split(' ');

        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int num = int.Parse(numbers[i]);
            if (num < min)
            {
                min = num;
            }
            else if (num > max)
            {
                max = num;
            }
            else if (num > min && num < max)
            {
                sum += num;
                count++;
            }
        }

        double average = (double)sum / count;
        Console.WriteLine("Среднее арифметическое элементов:" + average );
    }
}