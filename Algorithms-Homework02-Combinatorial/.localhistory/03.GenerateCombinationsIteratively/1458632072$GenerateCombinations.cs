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
                while (list[index] <= k + index)
                {
                    PrtintResult(list);
                    list[index]++;
                };

                if (list[index - 1] == n - index + 1)
                {
                    NumberUp(ref list, index - 1);
                    index++;
                    continue;
                }

                NumberUp(ref list, index);

                index++;
            }
        }

        private static void NumberUp(ref List<int> list, int index)
        {
            list[index - 1]++;

            for (int l = index; l < list.Count; l++)
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
