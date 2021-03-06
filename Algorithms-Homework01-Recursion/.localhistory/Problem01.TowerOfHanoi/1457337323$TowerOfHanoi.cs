﻿using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private static readonly Stack<int> source; 
    private static readonly Stack<int> spare = new Stack<int>();
    private static readonly Stack<int>  destination = new Stack<int>();

    public static void Main()
    {
        Console.Write("Pleace enter the number of dist of tower of Hanoi; n = ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintRods()

    }

    private static void PrintRods()
    {
        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
    }
}
