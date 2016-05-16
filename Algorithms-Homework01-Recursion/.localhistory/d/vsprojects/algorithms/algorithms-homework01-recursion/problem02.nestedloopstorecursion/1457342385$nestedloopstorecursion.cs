using System;

class NestedLoopsToRecursion
{
    static void Main()
    {
        Console.Write("Enter the number of the nested loops you want. n = ");
        int n = int.Parse(Console.ReadLine());

        NestedLoop(n);
    }

    private static void NestedLoop(int n, int number = 1)
    {
        int index = 1;

        if (index == n)
        {
            Console.Write(number);
            NestedLoop(n, number++);
        }

        Console.Write(number + " ");
        index++;
        NestedLoop(n);
    }
}
