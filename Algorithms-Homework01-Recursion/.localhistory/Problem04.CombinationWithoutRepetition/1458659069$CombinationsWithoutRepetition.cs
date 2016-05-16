using System;
using System.Diagnostics;
using System.Linq;

class CombinationsWithoutRepetition
{
    static void Main()
    {
        Console.Write("Pleace enter the maximum number of the loop. n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Hello pleace enter the number of elements in the loop. k = ");
        int k = int.Parse(Console.ReadLine());
      
        var currentLine = new int[k];

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        NestedLoop(k - 1, n, currentLine);

        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }

    private static void NestedLoop(int index, int n, int[] currentLine, int num = 1)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        for (int currentNum = num; currentNum <= n; currentNum++)
        {
            currentLine[index] = currentNum;
            num++;
            NestedLoop(index - 1, n, currentLine, num);
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
