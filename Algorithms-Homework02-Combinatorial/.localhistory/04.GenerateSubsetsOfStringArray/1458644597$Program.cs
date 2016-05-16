namespace GenerateSubsetsOfStringArray
{
    using System;

    static void Main()
    {
        Console.Write("Hello pleace enter the number of elements in the loop. k = ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Pleace enter the maximum number of the loop. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[k];
        NestedLoop(k - 1, n, currentLine);
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
