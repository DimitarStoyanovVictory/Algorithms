﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        private static int _countOfPermutations;

        static void Main()
        {
            int n = 4;

            


            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static void PrintResut(int[] ints)
        {
            Console.WriteLine(string.Join(", ", ints));
            _countOfPermutations++;
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