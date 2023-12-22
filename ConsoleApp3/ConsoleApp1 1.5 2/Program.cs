using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp1 1.5 2\numsTask2.txt";
        string outputFilepath = filepath;
        
        string[] inputLines = File.ReadAllLines(filepath);
        List<double> numbers = new List<double>();

        foreach (string lines in inputLines)
        {
            string[] numberStr = lines.Split(';');
            foreach (string numberstr in numberStr)
            {
                double number;
                if (double.TryParse(numberstr, out number))
                {
                    numbers.Add(number);
                }
            }
            
        }

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    double temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        File.AppendAllLines(outputFilepath, numbers.Select(number => number.ToString()));




    }
    
}