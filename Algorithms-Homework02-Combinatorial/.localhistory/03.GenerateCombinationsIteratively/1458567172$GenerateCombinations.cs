﻿namespace PermutationsCombinationsInterativly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 5;
            int k = 3;

            var list = Enumerable.Range(1, k).ToList();
            int i = 0;

            while (list[0] != n - k + 1)
            {

                for (int index = list.Count - 1; index > 0; index++)
                {
                    while (list[index] != n - i)
                    {
                        PrtintResult(list);
                    };

                    i++;
                }
            }
        }

        private static void PrtintResult(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
