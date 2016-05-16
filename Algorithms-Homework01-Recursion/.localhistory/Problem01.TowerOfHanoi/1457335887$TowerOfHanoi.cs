using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    public static void Main()
    {
        Console.Write("Pleace enter the number of dist of tower of Hanoi; n = ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        var source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintResult()

    }

    private static void PrintResult()
    {
    }
}
