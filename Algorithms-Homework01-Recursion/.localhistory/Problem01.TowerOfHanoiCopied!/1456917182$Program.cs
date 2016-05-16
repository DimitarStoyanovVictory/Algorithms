using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private static int steps;
    private static Stack<int> source;
    private static readonly Stack<int> destination = new Stack<int>();
    private static readonly Stack<int> spare = new Stack<int>();

    public static void Main()
    {
        Console.Write("Please enter desired number of disks: ");
        int numberOfDisks = int.Parse(Console.ReadLine());

        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintRods();
        MoveDisks(numberOfDisks, source, destination, spare);
    }

    private static void MoveDisks(int bottomDisk, Stack<int> sourceRod, Stack<int> destinationRod, Stack<int> spareRod)
    {
        if (bottomDisk < 1)
        {
            return;
        }
        if (bottomDisk == 1)
        {
            steps++;
            destinationRod.Push(sourceRod.Pop());
            PrintRods(steps, bottomDisk);
            return;
        }
        else
        {
            MoveDisks(bottomDisk - 1, sourceRod, spareRod, destinationRod);
            steps++;
            destinationRod.Push(sourceRod.Pop());
            PrintRods(steps, bottomDisk);
            MoveDisks(bottomDisk - 1, spareRod, destinationRod, sourceRod);
        }
    }

    private static void PrintRods(int steps = 0, int bottomDisk = 0)
    {
        Console.WriteLine($"Step #{steps}: Moved disk {bottomDisk}");

        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
        Console.WriteLine();
    }
}
