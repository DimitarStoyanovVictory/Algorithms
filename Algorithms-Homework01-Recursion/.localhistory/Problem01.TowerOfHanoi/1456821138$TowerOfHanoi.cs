using System;
using System.Collections.Generic;
using System.Linq;

public class TowerOfHanoi
{
    private static int stepsTaken = 0;

    private static Stack<int> source;
    private static Stack<int> destination = new Stack<int>();
    private static Stack<int> spare = new Stack<int>();

    private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
    {
        if (bottomDisk == 1)
        {
            stepsTaken++;
            destination.Push(source.Pop());
            PrintRods(stepsTaken, bottomDisk);
        }
        else
        {
            if (destination.Count != 0 || source.Peek() > destination.Peek() && source.Peek())
            {
                spare.Push(destination.Peek());
                stepsTaken++;
                PrintRods(stepsTaken, destination.Peek());
            }

            destination.Push(source.Pop());
            stepsTaken++;
            PrintRods(stepsTaken, destination.Peek());

            if (spare.Count == 0 || destination.Peek() < spare.Peek())
            {
                stepsTaken++;
                spare.Push(destination.Pop());
                PrintRods(stepsTaken, destination.Peek());
            }

        }
    }

    public static void PrintRods(int stepsTaken = 0, int currentDisk = 0)
    {
        if (stepsTaken != 0 && currentDisk != 0)
        {
            Console.WriteLine($"Step #{stepsTaken}: Moved disk {currentDisk}");
        }

        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
        Console.WriteLine();
    }

    public static void Main()
    {
        int numberOfDisks = 3;
        source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
        PrintRods();
        MoveDisks(numberOfDisks, source, destination, spare);
    }
}



