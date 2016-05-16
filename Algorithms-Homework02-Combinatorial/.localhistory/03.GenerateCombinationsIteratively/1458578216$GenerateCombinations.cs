namespace PermutationsCombinationsInterativly
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 5;
            int k = 3;

            var list = Enumerable.Range(1, k).ToList();
            int i = 1;

            while (list[0] != n - k + 1)
            {
                for (int index = list.Count - 1; index > 0; index--)
                {
                    while (list[index] <= k + index)
                    {
                        PrtintResult(list);
                        list[index]++;
                    };

                    if (list[index - 1] == n - index + 1)
                    {
                        NumberUp(ref list, index);
                        continue;
                    }

                    list[index - 1]++;

                    NumberUp(ref list, index);

                    index++;
                }
            }
        }

        private static void NumberUp(ref List<int> list, int index)
        {
            for (int l = index; l < list.Count; l++)
            {
                list[index] = list[index - 1] + 1;
            }
        }

        private static void PrtintResult(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
