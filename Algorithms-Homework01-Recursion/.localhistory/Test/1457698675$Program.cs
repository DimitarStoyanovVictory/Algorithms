using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var list = new SortedSet<int>();
        list.Add(1);
        list.Add(3);
        list.Add(2);
        list.Add(-1);

        foreach (var i in list)
        {
            Console.WriteLine(i);
        }
    }
}
