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
            Console.WriteLine("Hello, pleace enter the a positive integer to calculate the combinations with repetiiton; n = ");
            int n = int.Parse(Console.ReadLine());

            var arrayOfNumbers = Enumerable.Range(1, n).ToArray();

            decimal numberOfInteration = 1;

            _numberofPermutations = CalculateNumberOfPermutations(n);

            CalculatPermutatuions(arrayOfNumbers, n, numberOfInteration);
            
            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static void CalculatPermutatuions(int[] arrayOfNumbers, int n, decimal numberOfInteration)
        {
            while (_numberofPermutations > 0)
            {
                if (((numberOfInteration - 1)/6)%2 == 0 && numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[0]);
                }

                if (numberOfInteration%2 != 0 && numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 3]);
                }
                else if (numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 2]);
                }

                numberOfInteration++;

                PrintResult(a);
            }
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
