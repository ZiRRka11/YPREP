using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координату x (a):");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите координату y (b):");
        double y = Convert.ToDouble(Console.ReadLine());
        
        double x1 = 0, x2 = 2, x3 = -2;  
        double y1 = 2, y2 = -3, y3 = -3;
       
        double res1 = (x1 - x)*(y2-y1)-(x2-x1)*(y1-y);
        double res2 = (x2 - x)*(y3-y2)-(x3-x2)*(y2-y);   
        double res3 = (x3 - x)*(y1-y3)-(x1-x3)*(y3-y);

        if ((res1 >= 0 && res2 >= 0 && res3 >= 0) || (res1 <= 0 && res2 <= 0 && res3 <= 0))
        {
            Console.WriteLine("Данная точка("+ x + ';' + y +") принадлежит");
        }
        else
        {
            Console.WriteLine("Данная точка("+ x + ';' + y +") не принадлежит");
        }
    }
}