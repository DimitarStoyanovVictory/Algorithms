﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;
    using System.Threading;

    class Permotations
    {
        static void Main()
        {
            //int n = 4;

            //var array = Enumerable.Range(1, n).ToArray();

            //for (int indexRow = 1; indexRow < array.Length; indexRow++)
            //{
            //    for (int indexCol = indexRow; indexCol < array.Length; indexCol++)
            //    {
            //        Console.WriteLine();
            //    }
            //}

            var a = new[] {1, 2, 3};

            var p = new[] {0, 1, 2, 3};

            int i = 1;

            while (i < a.Length)
            {
                int j = 0;
                if (i % 2 != 0)
                {
                    j = p[i];
                    Swap(a[j], a[i]);
                }
            }
        }

        private static void Swap(int i, int i1)
        {
            
        }
    }
}
