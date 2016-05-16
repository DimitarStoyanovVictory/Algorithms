using System;
using System.Security.Principal;

class NestedLoopsToRecursion
{
    static void Main()
    {
        Console.Write("Enter the number of the nested loops you want. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[n];
        NestedLoop(n, currentLine);
    }

    private static void NestedLoop(int index, int[] currentLine)
    {
        if (index < 0)
        {
            PrintCurrentLine(currentLine);
        }

        for (int currentNum = 0; currentNum < currentLine.Length; currentNum++)
        {   
            
        }
    }

    private static void PrintCurrentLine(int[] currentLine)
    {
        throw new NotImplementedException();
    }
}
