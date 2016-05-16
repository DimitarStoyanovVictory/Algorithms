using System;
using System.Linq;

class CombinationsWithoutRepetition
{
    static void Main()
    {
        Console.Write("Hello pleace enter the number of elements in the loop. k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Pleace enter the maximum number of the loop. n = ");
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

        for (int currentNum = kIndex; currentNum <= n; currentNum++)
        {
            currentLine[index] = currentNum + 1;
            NestedLoop(index - 1, n, currentLine, kIndex);
            kIndex++;
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
