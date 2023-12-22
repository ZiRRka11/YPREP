using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        int Wordcount = words.Length;

        string output = "Start";
        for (int i = 0; i < Wordcount; i++)
        {
            output += words[i] + " ";
        }

        output += "End";
        Console.WriteLine("Результат:" + output);
    }
}