using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 9;
        int product = 1;

        for (int i = 3; i <= n; i += 3)
        {
            product *= i;
        }
          Console.WriteLine("Произведение натуральных чисел, кратных трем:" + product);
    }
}