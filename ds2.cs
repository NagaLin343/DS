using System;
using System.Diagnostics;
class Program
{


    static void Main(string[] args)
    {
        Console.Clear();
        int[] array = new int[] { -3, 0, 2, 4, 5 };
        int k = 6;
        int[] result = Calc(array, k);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        result = Calc2(array, k);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }

    static int[] Calc(int[] array, int k)
    {
        var time1 = new Stopwatch();
        time1.Start();
        int[] all_valid = new int[20];
        for (int i = 0, s = 0; i <= array.Length - 2 && s < 1; i++)
            for (int j = i + 1; j <= array.Length - 1 && s < 1; j++)
            {
                if (array[i] + array[j] == k)
                {
                    all_valid[0] = array[i];
                    all_valid[1] = array[j];
                    s = 1;
                }
            }
        time1.Stop();
        Console.WriteLine(time1.Elapsed);
        return all_valid;
    }
    static int[] Calc2(int[] array, int k)
    {
        var time2 = new Stopwatch();
        int[] all_valid = new int[20];
        time2.Start();
        int lt = 0; //левый
        int rt = array.Length - 1; //правый
        while (lt != rt)
        {
            int cursum = array[lt] + array[rt];
            if (cursum < k)
                lt++;
            else if (cursum > k)
                rt--;
            else // if (cursum == sum)
            {
                all_valid[0] = array[lt];
                all_valid[1] = array[rt];
                time2.Stop();
                Console.WriteLine(time2.Elapsed);
                return all_valid;
            }
        }
        time2.Stop();
        Console.WriteLine(time2.Elapsed);
        Console.WriteLine("Таких элементов нет");
        return all_valid;
    }

}