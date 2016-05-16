namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        private static int _countOfPermutations;
        private static int _numberofPermutations;

        static void Main()
        {
            int n = 5;

            var a = Enumerable.Range(1, n).ToArray();

            decimal i = 0;
            int j = 0;
            int k = 0;

            _numberofPermutations = CalculateNumberOfPermtations(n);

            while (_numberofPermutations > 0)
            {
                if (((i - 1) / 6) % 2 == 0)
                {
                    Swap(ref a[j], ref a[j + k]);
                }

                if (i % 2 != 0)
                {
                    Swap(ref a[n - 1], ref a[n - 3]);
                }
                else if (i != 0)
                {
                    Swap(ref a[n - 1], ref a[n - 2]);
                }

                PrintResult(a);
            }

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static int CalculateNumberOfPermtations(int n)
        {
            int number = n;
            for (int index = 1; index <= n; index++)
            {
                number += number * (n - index);
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
