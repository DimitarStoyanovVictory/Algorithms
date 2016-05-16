using System;
using System.IO;

public class Program
{
    static void Main()
    {
        int n = 5;
        int k = 3;

        // k == 3 => 3 nested for-loops
        for (int i1 = 1; i1 <= n; i1++)
        {
            for (int i2 = i1; i2 <= n; i2++)
            {
                for (int i3 = i2; i3 <= n; i3++)
                {
                    Console.WriteLine($"({i1} {i2} {i3})");
                }
            }
        }

    }
}
