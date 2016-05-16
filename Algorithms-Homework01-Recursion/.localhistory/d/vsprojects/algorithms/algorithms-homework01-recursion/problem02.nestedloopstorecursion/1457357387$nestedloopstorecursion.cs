using System;

class NestedLoopsToRecursion
{
    static void Main()
    {
        Console.Write("Enter the number of the nested loops you want. n = ");
        int n = int.Parse(Console.ReadLine());
        var currentLine = new int[n];
        NestedLoop(n);
    }

    private static void NestedLoop(int n)
    {

    }
}
