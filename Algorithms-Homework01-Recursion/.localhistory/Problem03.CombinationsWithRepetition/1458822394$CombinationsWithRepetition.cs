using System;
using System.Diagnostics;
using System.Linq;

class CombinationsWithRepetition
{
    static void Main()
    {
        Console.Write("Hello pleace enter the number of elements in the loop. k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Pleace enter the maximum number of the loop. n = ");
        int n = int.Parse(Console.ReadLine());

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var currentLine = new int[k];
        NestedLoop(k - 1, n, currentLine);

        stopwatch.Stop();
        Console.WriteLine($"Time {stopwatch.Elapsed}");
    }

    private static void NestedLoop(int index, int n, int[] currentLine, int kIndex = 1)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        for (int currentNum = kIndex; currentNum <= n; currentNum++)
        {
            currentLine[index] = currentNum;
            NestedLoop(index - 1, n, currentLine, kIndex);
            kIndex++;
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(", ", currentLine.Reverse()));
    }
}
