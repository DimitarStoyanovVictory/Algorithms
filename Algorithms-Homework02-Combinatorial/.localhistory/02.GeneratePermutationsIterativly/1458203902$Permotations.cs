﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            //Console.Write("Hello, pleace enter a positive integer number to calculate the combinations with repetiiton; n = ");
            int n = int.Parse(Console.ReadLine());

            var arrayOfNumbers = Enumerable.Range(1, n).ToArray();
            var arrayForSwap = arrayOfNumbers;

            int i = 0;

            while (i < n)
            {
                PrintResult(arrayForSwap);

                for (int index = n - 1; index > 0; index--)
                {
                    Swap(arrayForSwap[index], arrayForSwap[index - 1]);
                }
            }

            //Console.WriteLine($"Total permutations: {_countOfPermutations}");
            //_result.AppendLine($"Total permutations: {_countOfPermutations}");
            //sw.Write(_result);
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
            //_result.AppendLine(string.Join(", ", ints));
            //Console.WriteLine(string.Join(", ", ints));
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
