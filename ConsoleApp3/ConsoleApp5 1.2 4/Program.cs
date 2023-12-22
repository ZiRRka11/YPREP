using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] temperature = new int[12, 30];
        Random random = new Random();

        for (int month = 0; month < 12; month++)
        {
            for (int day = 0; day < 30; day++)
            {
                temperature[month, day] = random.Next(-10, 40);
            }
        }

        double[] averagetemp = CalculateAverageTemperature(temperature);
        
        Array.Sort(averagetemp);

        List<string> NameMonth = new List<string>()
        {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь",
            "Декабрь"
        };

        for (int month = 0; month < 12; month++)
        {
            Console.WriteLine("Средння температура в месяце{0}: {1:F2}°C", NameMonth[month], averagetemp[month]);
        }
    }

    
    static double[] CalculateAverageTemperature(int[,] temperature)
    {
        double[] averagetemp = new double [12];
        for (int month = 0; month < 12; month++)
        {
            int sum = 0;
            for (int day = 0; day < 30; day++)
            {
                sum += temperature[month, day];
            }

            averagetemp[month] = (double)sum / 30;
        }

        return averagetemp;
    }
}