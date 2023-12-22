using System;

class Program
{
    static void Main()
    {
        string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp15 6.1\numsTask1.txt";
        string file = File.ReadAllText(filepath);
        string[] words = file.Split( ' ', '\n', '\t');
        int length = words.Length;
        
        for(int i = 0; i < length;i++)
        {
            if (words[i].Length % 2 != 0)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}