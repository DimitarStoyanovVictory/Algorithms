namespace PermutationsCombinationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 5;
            int k = 3;

            var array = Enumerable.Range(1, k).ToArray();

            while (array[0] != k - n + 1)
            {
                Console.WriteLine(string.Join(",", array));


            }
        }
    }
}
