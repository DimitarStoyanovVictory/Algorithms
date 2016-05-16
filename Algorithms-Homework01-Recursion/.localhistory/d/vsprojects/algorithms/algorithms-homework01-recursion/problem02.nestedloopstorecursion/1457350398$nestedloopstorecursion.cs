using System;

class NestedLoopsToRecursion
{
    static void Main()
    {
        Console.Write("Enter the number of the nested loops you want. n = ");
        int n = int.Parse(Console.ReadLine());
        NestedLoop(n);
    }

    private static void NestedLoop(int n, int IndexNumber = 1, int index = 1)
    {
        int number = 1;

        if (index < n)
        {
            Console.Write("{0} ", number);
            index++;
            NestedLoop(n, IndexNumber, index);
        }
        else
        {
            Console.WriteLine("{0}", IndexNumber);
            IndexNumber++;
            NestedLoop(n, IndexNumber);       
        }
    }
}
