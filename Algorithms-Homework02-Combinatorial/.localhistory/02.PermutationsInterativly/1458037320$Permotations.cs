﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 4;

            var array = Enumerable.Range(1, n).ToArray();

            for (int indexRow = 0; indexRow < array.Length; indexRow++)
            {
                for (int indexCol = indexRow; indexCol < array.Length; indexCol++)
                {
                    Console.WriteLine(string.Join(",", array));
                }
            }
        }
    }
}
