using System;
using System.Linq;

class NestedLoopsToRecursion
{
    static void NestedLoops(int index, int[] vector)
    {
        if (index < 0)
        {
            Print(vector);
        }
        else
        {
            for (int i = 1; i <= vector.Length; i++) //3
            {
                vector[index] = i; // 1
                NestedLoops(index - 1, vector);
            }
        }
    }

    static void Print(int[] vector)
    {
        Console.WriteLine(string.Join(", ", vector.Reverse()));
    }

    static void Main()
    {
        Console.Write("Pleace chose number at whitch the loop ends; n = ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];

        NestedLoops(n - 1, vector);
    }
}
