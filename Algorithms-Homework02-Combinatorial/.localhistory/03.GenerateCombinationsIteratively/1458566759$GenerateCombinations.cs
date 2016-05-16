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

            while (list[0] != n - k + 1)
            {
                Console.WriteLine(string.Join(",", list));

                for (int index = list.Count - 1; index > 0; index++)
                {
                    while (list[index] != )
                    {

                    };
                }
            }
        }
    }
}
