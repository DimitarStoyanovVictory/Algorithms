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

            while (n > 0)
            {
                if (((i - 1) / 6) % 2 == 0)
                {
                    Swap(ref a[j], ref a[j + k]);
                }

                if (i % 2 != 0)
                {
                    Swap(ref a[n - 1], ref a[n - 3]);
                }
                else
                {
                    Swap(ref a[n - 1], ref a[n - 2]);
                }

                PrintResut(a);
            }

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static int CalculateNumberOfPermtations(int n)
        {
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number += n * (n - 1);
            }
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
