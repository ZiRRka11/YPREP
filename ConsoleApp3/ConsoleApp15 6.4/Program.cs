using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите положительное число a:");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("Введено отрицательное число.");
            return;
        }
        Console.WriteLine("Введите положительное число:");
        int sum = 0;
        int inputNumber = 0;

        while (inputNumber >= 0)
        {
            inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber < 0)
            {
                break;
                
            }

            if (inputNumber % a == 0)
            {
                sum += inputNumber;
            }
        }
        Console.WriteLine($"Сумма чисел, делящихся на {a} на целое, равна {sum}.");
    }
}