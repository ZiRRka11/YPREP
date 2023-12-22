using System;

class Program
{
   static void Main()
   {
      string filepath = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp15 5.3\numsTask3.txt";
      string outputfilepath = filepath;

      string[] inputLines = File.ReadAllLines(filepath);
      List<int> numbers = new List<int>();

      foreach (string line in inputLines)
      {
         string[] numberStr = line.Split(';');
         foreach (string numberString in numberStr)
         {
            int number;
            if (int.TryParse(numberString, out number))
            {
               numbers.Add(number);
            }
         }
      }

      int minNumber = FindMin(numbers);
      List<int> numbersBeforeMin = FindNumberBeforeMin(numbers, minNumber);

      double average = CalculateAverage(numbersBeforeMin);


      string resultString = $"Среднее арифметическое элементов, расположенных до минимального элемента: {average}";
      File.AppendAllLines(filepath, new string[] {resultString});
   }

   static int FindMin(List<int> numbers)
   {
      int min = int.MaxValue;
      foreach (int number in numbers)
      {
         if (number < min)
         {
            min = number;
         }
      }

      return min;
   }

   static List<int> FindNumberBeforeMin(List<int> numbers, int minNumber)
   {
      List<int> result = new List<int>();
      foreach (int number in numbers)
      {
         if (number > minNumber)
         {
            result.Add(number);
         }
      }

      return result;
   }

   static double CalculateAverage(List<int> numbers)
   {
      int sum = 0;
      foreach (int number in numbers)
      {
         sum += number;
      }

      return (double)sum / numbers.Count;

   }
}