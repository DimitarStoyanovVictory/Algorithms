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
        NestedLoop(k - 1, n, currentLine, 1);
    }

    private static void NestedLoop(int index, int n, int[] currentLine, int kIndex)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        if (currentLine[0] == 5)
        {
            kIndex++;
        }

        for (int currentNum = kIndex; currentNum <= n; currentNum++)
        {
            currentLine[index] = currentNum;
            NestedLoop(index - 1, n, currentLine, kIndex);
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
