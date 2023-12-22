// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое положительное число n: ");
        int n = int.Parse(Console.ReadLine());

        int product = 1;

        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }

        Console.WriteLine($"Произведение натуральных чисел, кратных 3 и не превыщающих {n}, равно {product}");
    }
}