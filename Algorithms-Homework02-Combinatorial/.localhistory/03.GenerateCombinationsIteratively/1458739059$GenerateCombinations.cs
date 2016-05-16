namespace PermutationsCombinationsInterativly 
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    class Permotations
    {
        private static string _dataPath = @"c:\temp\PermotationsWihdoutRepetitions.txt";
        static StreamWriter sw = new StreamWriter(_dataPath);
        private StringBuilder _result = new StringBuilder();

        static void Main()
        {
            int[] input = StartInput();

            if (input[1] > input[0])
            {
                Console.Clear();
                Console.Error.WriteLine("k can't be smaller than n pleace enter diffrent numbers for k and n");
                input = StartInput();
            }

            int n = input[0];
            int k = input[1];

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

        private static int[] StartInput()
        {
            Console.Write("Enter the biggest number you want for the algorithm; n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of elements in the algorithm; k = ");
            int k = int.Parse(Console.ReadLine());

            return new[] {n, k};
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
            //Console.WriteLine(string.Join(", ", list));

        }
    }
}
