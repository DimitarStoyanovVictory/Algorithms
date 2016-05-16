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
            int i = 0;
            int index = list.Count - 1;

            while (true)
            {
                while (list[index] <= n)
                {
                    PrtintResult(list);
                    list[index]++;
                };

                if (list[index - i] >= n - i)
                {
                    i++;
                }

                NumberUp(ref list, index, i);
            }
        }
             
        }

        private static void NumberUp(ref List<int> list, int index, int i)
        {
            list[index - i]++;

            for (int l = index - i + 1; l < list.Count; l++)
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
