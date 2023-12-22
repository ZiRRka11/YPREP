using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов m:");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m + 1];
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < m + 1; j++)
            {
                matrix[i, j] = random.Next(0, 2);
                if (matrix[i, j] == 1)
                    count++;
            }

            if (count %2 != 0)
            {
                matrix[i, m] = 1;
            }
            else
            {
                matrix[i, m] = 0;
            }
            Console.Write("{0}", string.Join(" ", matrix[i, n]));
            Console.WriteLine();
        }
        Console.WriteLine("Новая матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write($"{matrix[i, j],2}");
            }

            Console.WriteLine();
        }

    }
}