namespace PermutationsInterativly
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 5;

            var a = Enumerable.Range(1, n).ToArray();
            var p = Enumerable.Range(0, n + 1).ToArray();

            int i = 1;
            int j = 0;
            while (i < n)
            {
                p[i]--;
                j = i % 2 * p[i];
                
            }

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
