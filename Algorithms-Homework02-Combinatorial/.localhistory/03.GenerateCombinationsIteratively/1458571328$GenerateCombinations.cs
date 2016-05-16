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
                    while (list[index] != n + 1)
                    {
                        PrtintResult(list);
                        list[index]++;
                    };

                    for (int c = 1; c <= i; c++)
                    {
                        if (list[index - c] == n - c)
                        {
                            i++;
                            c--;
                        }

                        list[index - c]++;
                        list[index - c + 1] = list[index - c] + 1;
                    }

                    index++;
                }
            }
        }

        private static void PrtintResult(List<int> list)
        {
            Console.WriteLine(string.Join(",", list));
        }
    }
}
