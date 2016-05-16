namespace Test
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = 5;

            int firstNum = GenerateFirstNum(n);
            int lastNum = GenerateLastNum(n);

            for (int number = firstNum; number < lastNum; number++)
            {
                if (CheckUnique(number.ToString()))
                {
                    Console.WriteLine(string.Join(", ", number));
                }
            }
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
