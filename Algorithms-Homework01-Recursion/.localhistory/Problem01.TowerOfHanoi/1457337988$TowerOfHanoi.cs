using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private static int step;
    private static Stack<int> source; 
    private static readonly Stack<int> spare = new Stack<int>();
    private static readonly Stack<int> destination = new Stack<int>();

    public static void Main()
    {
        Console.Write("Pleace enter the number of dist of tower of Hanoi; n = ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintRods();
        MoveDisks(numberOfDisks, source, destination, spare);
    }

    private static void MoveDisks(int bottomDiskNumber, Stack<int> stack, Stack<int> destination, Stack<int> spare)
    {
        if (bottomDiskNumber == 1)
        {
            step++;
            destination.Push(spare.Pop());
            PrintRods(bottomDiskNumber, step);
        }
    }

    private static void PrintRods(int bottomDiskNumber = 0, int step = 0)
    {
        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
        Console.WriteLine();
    }
}
