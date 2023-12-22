// See https://aka.ms/new-console-template for more info
using System;

class Program
{
    static void Main()
    { 
        Console.WriteLine("Введите координату x (a): ");
       double a = Convert.ToDouble(Console.ReadLine());
       
       Console.WriteLine("Введите координату y (b):");
       double b = Convert.ToDouble(Console.ReadLine());

       double x = a;
       double y = b;


       if (-1 <= x && x <= 3 && -2 <= y && y <= 4)
       {
           Console.WriteLine("Данная точка("+ a + ';' + b + ") принадлежит");
       }
       else
       {
           Console.WriteLine("Данная точка("+ a + ';' + b + ")не принадлежит");
       }
    }
}
