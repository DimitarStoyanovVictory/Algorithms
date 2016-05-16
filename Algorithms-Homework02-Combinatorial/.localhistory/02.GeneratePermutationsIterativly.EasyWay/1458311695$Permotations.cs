namespace PermutationsInterativly
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Numerics;
    using System.Text;

    class Permotations
    {
        static void Main()
        {
            Console.Write("Hello, pleace enter the a positive integer to calculate the combinations with repetiiton on a permutation; n = ");
            int n = int.Parse(Console.ReadLine());

            BigInteger firstNum = GenerateFirstNum(n);
            BigInteger lastNum = GenerateLastNum(n);

            CalculatePermutations(firstNum, lastNum, n);
        }

        private static void CalculatePermutations(BigInteger firstNum, BigInteger lastNum, int n)
        {
            var watch = new Stopwatch();
            watch.Start();

            BigInteger count = 0;
            var result = new StringBuilder();
            string dataPath = @"c:\temp\PermutationsCombinations.txt";
            StreamWriter sw = new StreamWriter(dataPath);

            for (BigInteger number = firstNum; number < lastNum; number++)
            {
                if (!IsAllowedNumber(number, n) || !CheckUnique(number.ToString()))
                {
                    continue;
                }

                Console.WriteLine(string.Join(", ", number.ToString().ToCharArray()));
                //result.AppendLine(string.Join(", ", number.ToString().ToCharArray()));
                count++;
            }

            watch.Stop();

            result.AppendLine($"Number of permutations: {count}");
            result.AppendLine($"Time calculated: {watch.Elapsed}");
            sw.Write(result);
        }

        private static bool IsAllowedNumber(BigInteger number, int n)
        {
            string digits = number.ToString();
            foreach (var digit in digits)
            {
                var x = Convert.ToInt32(digit.ToString());
                if (x < 1 || x > n)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckUnique(string number)
        {
            bool[] array = new bool[256];

            foreach (var charecter in number)
            {
                if (array[charecter])
                {
                    return false;
                }

                array[charecter] = true;
            }

            return true;
        }

        private static BigInteger GenerateLastNum(int n)
        {
            string lastNumStr = "";
            for (int count = 0; count < n; count++)
            {
                lastNumStr += n;
            }

            return BigInteger.Parse(lastNumStr);
        }

        private static BigInteger GenerateFirstNum(int n)
        {
            string firstNumStr = "";
            for (int count = 0; count < n; count++)
            {
                firstNumStr += 1;
            }

            return BigInteger.Parse(firstNumStr);
        }
    }
}