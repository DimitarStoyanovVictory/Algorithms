﻿namespace PermutationsCombinationsInterativly
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            Console.Write("Enter the biggest number you want for the algorithm; n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of elements in the algorithm; k = ");
            int k = int.Parse(Console.ReadLine());

            var list = Enumerable.Range(1, k).ToList();
            int i = 0;
            int index = list.Count - 1;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            while (true)
            {
                while (list[index] <= n)
                {
                    PrtintResult(list);
                    list[index]++;
                }
                
                if (list[0] == n - i || k == n || k == 1)
                {
                    break;
                }

                if (list[index - i] >= n - i)
                {
                    i++;
                }

                if (index[k - i] == n - i)
                {
                    
                }

                NumberUp(ref list, index, i);
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
        }

        private static void NumberUp(ref List<int> list, int index, int i, int j)
        {
            list[index - i]++;

            for (int l = index - i + 1; l < list.Count; l++)
            {
                list[l] = list[l - 1] + 1;
            }
        }

        private static void PrtintResult(List<int> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
