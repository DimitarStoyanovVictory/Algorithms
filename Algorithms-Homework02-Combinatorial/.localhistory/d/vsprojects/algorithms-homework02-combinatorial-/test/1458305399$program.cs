namespace Test
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 5;

            int firstNum = GenerateFirstNum(n);
            int lastNum = GenerateLastNum(n);

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
