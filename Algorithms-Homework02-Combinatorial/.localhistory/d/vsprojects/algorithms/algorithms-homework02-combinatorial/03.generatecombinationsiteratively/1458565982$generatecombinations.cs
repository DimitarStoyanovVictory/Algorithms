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

            var list = Enumerable.Range(1, k).ToList();

            while (list[0] != k - n + 1)
            {
                Console.WriteLine(string.Join(",", list));

                foreach (var element in list)
                {

                }
            }
        }
    }
}
