using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp1 1.4 2\numsTask2.txt";
        string[] numbers = File.ReadAllText(filepath).Split(";");
        double sum = 0;

        foreach (string number in numbers)
        {
            
            double num = double.Parse(number);

            if (num == 0)
            {
                break;
            }

            if (num > 0)
            {
                sum += num;
            }


        }
        Console.WriteLine("Сумма положительных элементов:" + sum);
        
        
    }
}