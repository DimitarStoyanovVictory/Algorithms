using System;

class CombinationsWithoutRepetition
{
    static void Main()
    {
        Console.Write("Hello pleace enter the number of elements; n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Hello pleace enter the number of selected elements; k = ");
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];
        GenCombs(arr, 0, 1, n);
    }

    static void GenCombs(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            // A combination was found --> print it
            Console.WriteLine(String.Join(", ", arr));
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                arr[index] = i;
                GenCombs(arr, index + 1, i + 1, endNum);
            }
        }
    }
}
