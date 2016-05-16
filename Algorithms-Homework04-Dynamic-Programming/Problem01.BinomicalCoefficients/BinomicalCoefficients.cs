namespace Problem01.BinomicalCoefficients
{
    using System;

    class BinomicalCoefficients
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

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
