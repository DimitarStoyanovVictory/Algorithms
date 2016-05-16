namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        private static int _countOfPermutations;

        static void Main()
        {
            int n = 5;

            var a = Enumerable.Range(1, n).ToArray();

            decimal i = 0;
            while (n > 0)
            {
                if ((i - 1) % 6)
                {
                    
                }

                if (i % 2 != 0)
                {
                    Swap(ref a[n - 1], ref a[n - 3]);
                }  
            }

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
