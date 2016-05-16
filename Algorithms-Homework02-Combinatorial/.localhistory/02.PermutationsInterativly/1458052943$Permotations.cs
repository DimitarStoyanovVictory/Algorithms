﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        private static int _countOfPermotations;

        static void Main()
        {
            int n = 5;

            var a = Enumerable.Range(1, n).ToArray();
            var p = Enumerable.Range(0, n + 1).ToArray();

            int i = 1;
            int j = 0;
            PrintResut(a);

            while (i < n)
            {
                p[i]--;
                j = i % 2 * p[i];
                Swap(ref a[j], ref a[i]);
                PrintResut(a);

                i = 1;
                while (p[i] == 0)
                {
                    p[i] = 1;
                    i++;
                }
            }

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static void PrintResut(int[] ints)
        {
            Console.WriteLine(string.Join(", ", ints));
            _countOfPermotations++;
        }

        private static void Swap(ref int numberOne, ref int numberTwo)
        {
            if (numberOne == numberTwo)
            {
                return;
            }

            int tempNumber = numberOne;
            numberOne = numberTwo;
            numberTwo = tempNumber;
        }
    }
}
