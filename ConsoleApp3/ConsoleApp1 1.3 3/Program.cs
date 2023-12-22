string pathHeight = @"C:\Users\gr624_hasal\RiderProjects\ConsoleApp3\ConsoleApp1 1.3 3height.txt";
string [] file = File.ReadAllLines(pathHeight);
int [] height;
height = file[0].Split(' ').Select(int.Parse).ToArray();
int[] res = new int[9];
int maxRes = 0;
int index1 = 0;
int index2 = 0;
int height1 = 0;
int height2 = 0;
for (int i = 0; i < height.Length; i++)
{
    for (int j = 0; j < height.Length; j++)
    {
        if (i == j) continue;
        if (height[i] < height[j] && j > i)
        {
            res[j] = height[i] * Math.Abs(j - i);
            if (maxRes < res[j])
            {
                maxRes = res[j];
                index1 = i;
                index2 = j;
                height1 = height[i];
                height2 = height[j];

            }

        }
        else if (height[i] < height[j] && j < i)
        {
            res[j] = height[i] * Math.Abs(i - j);
            if (maxRes < res[j])
            {
                maxRes = res[j];
                index1 = i;
                index2 = j;
                height1 = height[i];
                height2 = height[j];

            }

        }
        else if (height[i] > height[j] && j > i)
        {
            res[j] = height[j] * Math.Abs(j - i);
            if (maxRes < res[j])
            {
                maxRes = res[j];
                index1 = i;
                index2 = j;
                height1 = height[i];
                height2 = height[j];

            }

        }
        else if (height[i] > height[j] && j < i)
        {
            res[j] = height[j] * Math.Abs(i - j);
            if (maxRes < res[j])
            {
                maxRes = res[j];
                index1 = i;
                index2 = j;
                height1 = height[i];
                height2 = height[j];

            }

        }

    }

    Console.WriteLine($"Первый столбец: {index1} \t\t Второй столбец: {index2} \nЗначение первого столбца: {height1} \t Значение второго столбца: {height2} \nОбъем, который они образуют: {maxRes}");
}