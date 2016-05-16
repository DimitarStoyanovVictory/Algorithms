using System;
using System.Linq;

class NestedLoopsToRecursion
{
    static void Main()
    {
        Console.Write("Enter the degree of the nested loop you want. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[n];
        NestedLoop(n - 1, currentLine);
    }

    private static void NestedLoop(int index, int[] currentLine)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
            return;
        }

        for (int currentNum = 1; currentNum <= currentLine.Length; currentNum++)
        {
            currentLine[index] = currentNum;
            NestedLoop(index - 1, currentLine);
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        Console.WriteLine(string.Join(" ", currentLine.Reverse()));
    }
}
