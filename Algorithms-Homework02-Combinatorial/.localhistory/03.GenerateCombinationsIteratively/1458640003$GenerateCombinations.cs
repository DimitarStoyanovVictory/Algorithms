namespace PermutationsCombinationsInterativly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 7;
            int k = 4;

            var list = Enumerable.Range(1, k).ToList();
            int i = 1;

            for (int index = list.Count - 1; list[0] <= n - k + 1; index--)
            {
                while (list[index] <= n)
                {
                    PrtintResult(list);
                    list[index]++;
                };

                i++;

                NumberUp(ref list, index, i);
            }
        }

        private static void NumberUp(ref List<int> list, int index, int i)
        {
            list[index - i]++;

            for (int l = index - i; l < list.Count; l++)
            {
                list[l] = list[l - 1] + 1;
            }
        }

        private static void PrtintResult(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
