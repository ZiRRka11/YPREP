using System;

class Program
{
    static void Main()
    {
        int[] positivearray = {  2,  4,  6,  8,  10 };
        int[] negativearray = { -1, -3, -5, -7, -9 };
        int[] positivenumbers =  positivearray;
        int[] negativenumbers =  negativearray;

        int positiveIndex = 0;
        int negativeIndex = 0;

        for (int i = 0; i < positivearray.Length; i++)
        {
            if (positivearray[i] > 0)
            {
                positivenumbers[i] = positivearray[i];
            }
            else if (negativearray[i] < 0)
            {
                negativenumbers[i] = negativearray[i];
            }
        }
        Console.WriteLine("Positive elements:");
        Console.WriteLine(string.Join(", " ,positivenumbers));
        Console.WriteLine("Negative elements:");
        Console.WriteLine(string.Join(", " ,negativenumbers));
    }
}