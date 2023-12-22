using System;
using System.Collections.Generic;

class Program
{
    static int[] RandomNumberList(int start, int end, int count)
    {
        Random random = new Random();
        int[] array = new int[count];
        for (int i = 0; i < count; i++)
        {
            array[i] = random.Next(start, end + 1);
        }

        return array;
    }

    static void Main()
    {
        Console.Write("Введите начало диапозона:");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("Введите конец диапозона:");
        int end = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество элементов:");
        int count = int.Parse(Console.ReadLine());

        int[] array = RandomNumberList(start, end, count);
        
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}