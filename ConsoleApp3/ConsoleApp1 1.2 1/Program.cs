using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> collection = new List<int>();
        for (int i = 100; i >= 1; i -= 3)
        {
            collection.Add(i);
        }

        foreach (int number in collection)
        {
            Console.Write(number + " ");
        }
    }
}