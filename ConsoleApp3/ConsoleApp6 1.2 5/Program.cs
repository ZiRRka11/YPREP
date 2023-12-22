using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int[]> temperature = new Dictionary<string, int[]>();

        Random random = new Random();

        List<string> NameMonth = new List<string>()
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь",
            "Декабрь"
        };
        foreach (string month in NameMonth)
        {
            int[] dailyTemperatures = new int[30];
            for (int day = 0; day < 30; day++)
            {
                dailyTemperatures[day] = random.Next(-10, 40);
            }

            temperature[month] = dailyTemperatures;
        }

        Dictionary<string, double> averageTemperatures = averagetemp(temperature);

        foreach (var entry in averageTemperatures)
        {
            Console.WriteLine("Средняя температура в месяце {0}: {1:F2}°C", entry.Key, entry.Value);
        }
    }

    static Dictionary<string, double> averagetemp(Dictionary<string, int[]> temperature)
    {
        Dictionary<string, double> averagetemp = new Dictionary<string, double>();

        foreach (var entry in temperature)
        {
            string month = entry.Key;
            int[] dailyTemperatures = entry.Value;

            int sum = 0;
            foreach (int tempValue in dailyTemperatures)
            {
                sum += tempValue;
            }

            double averageTemp = (double)sum / dailyTemperatures.Length;

            averagetemp[month] = averageTemp;
        }

        return averagetemp;
    }
}