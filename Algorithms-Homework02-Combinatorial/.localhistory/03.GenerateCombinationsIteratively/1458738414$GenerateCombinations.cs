namespace PermutationsCombinationsInterativly 
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            Console.Write("Enter the biggest number you want for the algorithm; n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of elements in the algorithm; k = ");
            int k = int.Parse(Console.ReadLine());

            if (k > n)
            {
                Console.Error.WriteLine("k can't be smaller than n pleace enter diffrent numbers for k and n");
            }

            var list = Enumerable.Range(1, k).ToList();
            int i = 0;
            int listLengthMinusOne = list.Count - 1;
            int priviousNum = 0;
            int j = 0;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            while (true)
            {
                while (list[listLengthMinusOne] <= n)
                {
                    PrtintResult(list);
                    list[listLengthMinusOne]++;
                }
                
                if (list[0] == n - i || k == n || k == 1)
                {
                    break;
                }

                if (list[listLengthMinusOne - i] >= n - i)
                {
                    i++;
                    priviousNum = list[listLengthMinusOne - i];
                }

                if (list[listLengthMinusOne - i] == priviousNum + 1 && i != 1)
                {
                    j++;
                    i = i - j;

                    if (i <= 0)
                    {
                        i = 1;
                        j = 1;
                    }
                }

                NumberUp(ref list, listLengthMinusOne, i);
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);
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
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
