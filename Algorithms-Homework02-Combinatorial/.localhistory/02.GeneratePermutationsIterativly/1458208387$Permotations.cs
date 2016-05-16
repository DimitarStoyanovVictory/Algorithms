namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            //Console.Write("Hello, pleace enter a positive integer number to calculate the combinations with repetiiton; n = ");
            int n = 3;

            var arrayOfNumbers = Enumerable.Range(1, n).ToArray();
            var arrayForSwap = arrayOfNumbers;
            int count = 0;
            int i = 1;
            int j = n - 1;

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < j; l++)
                {
                    for (int index = n - 1; index > 1; index--)
                    {
                        PrintResult(arrayForSwap);
                        Swap(ref arrayForSwap[index], ref arrayForSwap[index - 1]);
                        count++;
                    }
                }

                if (k + 1 != n)
                {
                    Swap(ref arrayForSwap[0], ref arrayForSwap[k + 1]);
                }
            }

            Console.WriteLine($"Total permutations: {count}");

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
            Console.WriteLine(string.Join(", ", ints));
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
