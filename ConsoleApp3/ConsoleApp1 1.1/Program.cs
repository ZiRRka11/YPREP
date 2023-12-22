using System;
using System.Collections;

namespace Collectrions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> Collection = new List<int[]>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int[] array = new int[10];
                for (int j = 0; j < 10; j++)
                {
                    array[j] = random.Next();
                }

                Collection.Add(array);
            }


            int minElement = int.MaxValue;
            int minIndex = -1;
            for (int i = 0; i < Collection.Count; i++)
            {
                int[] array = Collection[i];
                for (int j = 0; j < array.Length; j++)
                {
                    int element = array[i];
                    if (element < minElement)
                    {
                        minElement = element;
                        minIndex = i;
                    }
                }
            }

            Console.WriteLine("Номер мин. элемента:" + minIndex);
        }
    }
}