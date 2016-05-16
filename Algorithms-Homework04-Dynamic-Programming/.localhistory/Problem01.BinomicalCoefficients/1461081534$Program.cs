namespace Problem01.BinomicalCoefficients
{
    using System;

    class BinomicalCoefficients
    {
        static void Main()
        {
            int n = 10;
            int k = 5;

            int nFactorial = 1;
            int kFactorial = 1;
            int nMinusKFactorial = 1;

            for (int index = 1; index <= n; index++)
            {
                nFactorial *= index;
            }

            for (int index = 1; index <= k; index++)
            {
                kFactorial *= index;
            }

            for (int index = 1; index <= n - k; index++)
            {
                nMinusKFactorial *= index;
            }

            int binomicalCoeficient = nFactorial / (kFactorial * nMinusKFactorial);
            Console.WriteLine(binomicalCoeficient);
        }
    }
}
