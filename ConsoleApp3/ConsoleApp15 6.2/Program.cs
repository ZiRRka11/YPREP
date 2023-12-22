using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp15 6.2\numsTask2.txt";
        string[] words = File.ReadAllLines(filepath);
        string result = string.Join(" ", words);
        Console.WriteLine(result);
    }
}