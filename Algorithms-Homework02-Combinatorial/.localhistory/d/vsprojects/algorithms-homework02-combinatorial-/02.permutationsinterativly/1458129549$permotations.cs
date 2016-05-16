﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        private static int _countOfPermutations;
        private static int _numberofPermutations;

        static void Main()
        {
            int n = 6;

            var a = Enumerable.Range(1, n).ToArray();

            decimal numberOfInteration = 1;

            _numberofPermutations = CalculateNumberOfPermutations(n);

            CalculatPermutatuions(n, numberOfInteration)
            while (_numberofPermutations > 0)
            {
                if (((numberOfInteration - 1) / 6) % 2 == 0 && numberOfInteration != 1)
                {
                    Swap(ref a[n - 1], ref a[0]);
                }

                if (numberOfInteration % 2 != 0 && numberOfInteration != 1)
                {
                    Swap(ref a[n - 1], ref a[n - 3]);
                }
                else if (numberOfInteration != 1)
                {
                    Swap(ref a[n - 1], ref a[n - 2]);
                }

                numberOfInteration++;

                PrintResult(a);
            }

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static int CalculateNumberOfPermutations(int n)
        {
            int number = 1;
            for (int index = 1; index <= n; index++)
            {
                number *= index;
            }

            return number;
        }

        private static void PrintResult(int[] ints)
        {
            Console.WriteLine(string.Join(", ", ints));
            _countOfPermutations++;
            _numberofPermutations--;
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
