using System;
using System.Collections;


namespace Collectrions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            Console.WriteLine("Введите элементы (для завершения введите пустую строку)");

            string input;
            do
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input)) 
                {
                    strings.Add(input);
                }
            } while (!string.IsNullOrEmpty(input));

            if (strings.Count > 0)
            {
                string shorts = strings[0];
                string longest = strings[0];

                foreach (string str in strings)
                {
                    if (str.Length < shorts.Length)
                    {
                        shorts = str;
                    }

                    if (str.Length > longest.Length)
                    {
                        longest = str;
                    }
                }
                Console.WriteLine("Самый длинный элемент:"+ longest);
                Console.WriteLine("Самый короткий элемент:"+ shorts);
            }
            
        }
    }
}