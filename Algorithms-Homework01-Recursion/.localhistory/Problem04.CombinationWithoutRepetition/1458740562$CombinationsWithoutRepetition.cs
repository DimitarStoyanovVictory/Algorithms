using System;
using System.Diagnostics;
using System.Linq;

class CombinationsWithoutRepetition
{
    //private static string _dataPath = @"c:\temp\PermotationsWihdoutRepetitionsRecrusion.txt";
    //static StreamWriter sw = new StreamWriter(_dataPath);
    //private static StringBuilder _result = new StringBuilder();

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

        //Console.WriteLine(stopwatch.Elapsed);
        //_result.AppendLine($"Time: {stopwatch.Elapsed.Seconds}");
        //sw.Write(_result.ToString());
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
        //_result.AppendLine(string.Join(", ", currentLine.Reverse()));
        Console.WriteLine(string.Join(", ", currentLine.Reverse()));
    }
}
