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

            var list = Enumerable.Range(1, k).ToList();
            int i = 0;
            int listLength = list.Count - 1;

            var stopWatch = new Stopwatch();
            stopWatch.Start();

            while (true)
            {
                while (list[listLength] <= n)
                {
                    PrtintResult(list);
                    list[listLength]++;
                }
                
                if (list[0] == n - i || k == n || k == 1)
                {
                    break;
                }

                if (list[listLength - i] >= n - i)
                {
                    i++;
                }

                //if (list[k - i - 1] == k - i + 1)
                //{
                //    i--;
                //}

                NumberUp(ref list, listLength, i);
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
