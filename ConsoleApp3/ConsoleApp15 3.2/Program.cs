using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string input = File.ReadAllText(@"C:\Users\gr624_hasal\nums.txt");

        int[] numbers = input.Split(new char[] {' ', ','}).Select(int.Parse).ToArray();

        // Фильтруем массив, оставляя только нечетные числа
        string[] oddNumbers = new String[numbers.Length];
        int c = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 1)
            {
                oddNumbers[c] = Convert.ToString(numbers[i]);
                c++;
            }
        }
        // Записываем новые значения в файл nums.txt
        File.WriteAllText(@"C:\Users\gr624_hasal\nums.txt", string.Join(" ", oddNumbers));
    }
}