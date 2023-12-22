using System;


class Program
{
    static void Main()
    {
        int[] array = new int[100];
        for (int i = 0, number = 1; i < array.Length; i ++, number +=2)
        {
            array[i] = number;
        }

        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}