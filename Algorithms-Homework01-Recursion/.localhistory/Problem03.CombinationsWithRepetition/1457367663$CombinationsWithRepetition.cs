using System;
using System.Linq;

class CombinationsWithRepetition
{
     static void Main()
    {
        Console.Write("Enter the degree of the nested loop. k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter the maximum number of the nested loop. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[k];
        NestedLoop(k - 1, n, currentLine);
    }

    private static void NestedLoop(int index, int n, int[] currentLine)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        for (int kIndex = 0; kIndex < index; kIndex++)
        {
            for (int currentNum = 1; currentNum <= n; currentNum++)
            {
                currentLine[index] = currentNum;
                NestedLoop(index - 1, n, currentLine);
            }
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
