namespace Test
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = 5;

            int num = GenereateFirstNum(n);
        }

        private static int GenereateFirstNum(int n)
        {
            string firstNumStr = "";

            for (int num = 0; num < n; num++)
            {
                firstNumStr += 1;
            }

            return Convert.ToInt32(firstNumStr);
        }
    }
}
