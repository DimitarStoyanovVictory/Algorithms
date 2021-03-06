﻿namespace PermutationsInterativly
{
    using System;
    using System.IO;
    using System.Text;

    class Permotations
    {
        static void Main()
        {
            Console.Write("Hello, pleace enter the a positive integer to calculate the combinations with repetiiton; n = ");
            int n = int.Parse(Console.ReadLine());

            int firstNum = GenerateFirstNum(n);
            int lastNum = GenerateLastNum(n);

            CalculatePermutations(firstNum, lastNum, n);
        }

        private static void CalculatePermutations(int firstNum, int lastNum, int n)
        {
            int count = 0;
            var result = new StringBuilder();
            string dataPath = @"c:\temp\PermutationsCombinations.txt";
            StreamWriter sw = new StreamWriter(dataPath);

            for (int number = firstNum; number < lastNum; number++)
            {
                if (!IsAllowedNumber(number, n) || !CheckUnique(number.ToString()))
                {
                    continue;
                }

                result.AppendLine(string.Join(", ", number.ToString().ToCharArray()));
                count++;
            }

            result.AppendLine($"Number of permutations: {count}");
            sw.Write(result);
        }

        private static bool IsAllowedNumber(int number, int n)
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

        private static int GenerateLastNum(int n)
        {
            string lastNumStr = "";
            for (int count = 0; count < n; count++)
            {
                lastNumStr += n;
            }

            return Convert.ToInt32(lastNumStr);
        }

        private static int GenerateFirstNum(int n)
        {
            string firstNumStr = "";
            for (int count = 0; count < n; count++)
            {
                firstNumStr += 1;
            }

            return Convert.ToInt32(firstNumStr);
        }
    }
}