namespace PermutationsInterativly
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            //Console.Write("Hello, pleace enter a positive integer number to calculate the combinations with repetiiton; n = ");

            int n = 3;
            var a = Enumerable.Range(1, n).ToArray();
            var p = Enumerable.Range(0, n + 1).ToArray();

            p[n] = n;
            PrintResult(a);

            int i = 1;
            int j = 0;
            int temp = 0;
            while (i < n)
            {
                p[i]--;
                j = (i % 2) * p[i];
                //Swap(a[j], a[i]);
                temp = a[j];
                a[j] = a[i];
                a[i] = temp;

                PrintResult(a);

                while (p[i] == 0)
                {
                    p[i] = 1;
                    i++;
                }
            }
                
            //Console.WriteLine($"Total permutations: {}");
            //Console.WriteLine($"Total permutations: {_countOfPermutations}");
            //_result.AppendLine($"Total permutations: {_countOfPermutations}");
            //sw.Write(_result);
        }

        private static void PrintResult(int[] ints)
        {
            //_result.AppendLine(string.Join(", ", ints));
            Console.WriteLine(string.Join(", ", ints));
        }

        private static void Swap(int numberOne, int numberTwo)
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
