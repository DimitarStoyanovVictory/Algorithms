namespace PermutationsInterativly
{
    using System;
    using System.IO;
    using System.Text;

    class Permotations
    {
        private static int _countOfPermutations;
        private static int _numberofPermutations;

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
            string dataPath = @"c:\temp\eigthQuees.txt";
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
            sw
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

//namespace PermutationsInterativly
//{
//    using System;
//    using System.Linq;

//    class Permotations
//    {
//        private static int _countOfPermutations;
//        private static int _numberofPermutations;

//        static void Main()
//        {
//            Console.Write("Hello, pleace enter the a positive integer to calculate the combinations with repetiiton; n = ");
//            int n = int.Parse(Console.ReadLine());

//            var arrayOfNumbers = Enumerable.Range(1, n).ToArray();

//            decimal numberOfInteration = 1;

//            _numberofPermutations = CalculateNumberOfPermutations(n);

//            CalculatPermutatuions(arrayOfNumbers, n, numberOfInteration);

//            Console.WriteLine($"Total permutations: {_countOfPermutations}");
//        }

//        private static void CalculatPermutatuions(int[] arrayOfNumbers, int n, decimal numberOfInteration)
//        {
//            while (_numberofPermutations > 0)
//            {
//                if (((numberOfInteration - 1) / 6) % 2 == 0 && numberOfInteration != 1)
//                {
//                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[0]);
//                }

//                if (numberOfInteration % 2 != 0 && numberOfInteration != 1)
//                {
//                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 3]);
//                }
//                else if (numberOfInteration != 1)
//                {
//                    Swap(ref arrayOfNumbers[n - 1], ref arrayOfNumbers[n - 2]);
//                }

//                numberOfInteration++;

//                PrintResult(arrayOfNumbers);
//            }
//        }

//        private static int CalculateNumberOfPermutations(int n)
//        {
//            int number = 1;
//            for (int index = 1; index <= n; index++)
//            {
//                number *= index;
//            }

//            return number;
//        }

//        private static void PrintResult(int[] ints)
//        {
//            Console.WriteLine(string.Join(", ", ints));
//            _countOfPermutations++;
//            _numberofPermutations--;
//        }

//        private static void Swap(ref int numberOne, ref int numberTwo)
//        {
//            if (numberOne == numberTwo)
//            {
//                return;
//            }

//            int tempNumber = numberOne;
//            numberOne = numberTwo;
//            numberTwo = tempNumber;
//        }
//    }
//}

