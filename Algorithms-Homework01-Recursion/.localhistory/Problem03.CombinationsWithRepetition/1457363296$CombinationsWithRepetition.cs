﻿using System;
using System.Linq;

class CombinationsWithRepetition
{
     static void Main()
    {
        Console.Write("Enter the degree of the nested loop. k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter the coefficient number of the nested loop. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[k];
        NestedLoop(n - 1, k, currentLine);
    }

    private static void NestedLoop(int index, int k, int[] currentLine)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        for (int kIndex = 1; kIndex <= k; kIndex++)
        {
            for (int currentNum = kIndex; currentNum <= currentLine.Length; currentNum++)
            {
                currentLine[index] = currentNum;
                NestedLoop(index - 1, k, currentLine);
            }
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
