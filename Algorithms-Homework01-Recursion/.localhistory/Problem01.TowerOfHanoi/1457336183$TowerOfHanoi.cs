using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class TowerOfHanoi
{
    private static Stack<int> source;

    public static void Main()
    {
        Console.Write("Pleace enter the number of dist of tower of Hanoi; n = ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintRods()

    }

    private static void PrintRods()
    {
        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse() ));
    }
}
