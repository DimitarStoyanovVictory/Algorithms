using System;
using System.Collections;

public class Program
{
    static void Main()
    {
        var stack = new Stack();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine(stack.Peek());
    }
}
