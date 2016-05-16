namespace PermutationsInterativly
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    class Permotations
    {
        private static int _countOfPermutations;
        private static int _numberofPermutations;
        //private static string _dataPath = @"c:\temp\PermutationsIterativly.txt";
        //private static StringBuilder _result = new StringBuilder();
        //static StreamWriter sw = new StreamWriter(_dataPath);

        static void Main()
        {
            Console.Write("Hello, pleace enter a positive integer number to calculate the combinations with repetiiton; n = ");
            int n = int.Parse(Console.ReadLine());

            var arrayOfNumbers = Enumerable.Range(1, n).ToArray();

            decimal numberOfInteration = 1;

            _numberofPermutations = CalculateNumberOfPermutations(n);

            CalculatPermutatuions(arrayOfNumbers, n, numberOfInteration);

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
            //_result.AppendLine($"Total permutations: {_countOfPermutations}");
            //sw.Write(_result);
        }

        private static void CalculatPermutatuions(int[] arrayOfNumbers, int n, decimal numberOfInteration)
        {
            int movingIndex = 4;
            int k = 0;

            while (_numberofPermutations > 0)
            {
                if (((numberOfInteration - 1) / 6) % 2 == 0 && numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 3], ref arrayOfNumbers[n - 2]);
                }

                if (numberOfInteration % 2 != 0 && numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 3]);
                }
                else if (numberOfInteration != 1)
                {
                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 2]);
                }

                numberOfInteration++;

                PrintResult(arrayOfNumbers);
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
            //_result.AppendLine(string.Join(", ", ints));
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
