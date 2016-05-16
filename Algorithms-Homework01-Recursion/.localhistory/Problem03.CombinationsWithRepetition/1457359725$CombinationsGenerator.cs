using System;
using System.Linq;

class CombinationsWithRepetition
{
    static void Main()
    {
        Console.Write("Hello pleace enter the number of elements; n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Hello pleace enter the number of selected elements; k = ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];
        GenCombs(arr, k - 1, n);
    }

    static void GenCombs(int[] arr, int index, int endNum)
    {
        if (index < 0)
        {
            Print(arr);
        }
        else
        {
            for (int i = 1; i <= endNum; i++)
            {
                arr[index] = i;
                GenCombs(arr, index - 1, endNum);
            }
        }
    }

    static void Print(int[] vector)
    {
        Console.WriteLine(string.Join(", ", vector.Reverse()));
    }
}
