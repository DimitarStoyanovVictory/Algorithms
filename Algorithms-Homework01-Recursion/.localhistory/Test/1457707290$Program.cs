﻿using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(3);
        list.Add(2);
        list.Add(-1);
        list.Sort();

        Console.WriteLine(list[0]);
    }
}
