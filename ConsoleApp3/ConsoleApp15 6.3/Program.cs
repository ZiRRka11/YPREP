using System;

class Program
{
    static void Main()
    {
        int number = 47;
        bool Even = number % 2 == 0;
        bool Divisible = number % 10 == 0;

        if (Even && Divisible)
        {
            Console.WriteLine("Данное число является четным и кратны 10.");
        }
        else
        {
            Console.WriteLine("Данное число не является четным и кратным 10.");
        }
    }
}