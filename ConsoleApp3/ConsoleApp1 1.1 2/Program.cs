using System;
using System.Collections;

namespace Collectrions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Введите числа (для завершения введите 0)");

            int input;
            do
            {
                input = Convert.ToInt32(Console.ReadLine());
                numbers.Add(input);
            } while (input != 0);

            numbers.Remove(0);

            int sum = 0;
            int product = 1;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            double average = sum / numbers.Count;
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("product:" + product);
            Console.WriteLine("average:" + average);
        }
    }
}