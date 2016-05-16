namespace PermutationsWithRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PermutationsWithRepetition
    {
        private static List<string> combinations = new List<string>();

        static void Main()
        {
            int[] array = {1, 2, 3, 3};

            PermuteRepIteretive(array);
        }

        public static void PermuteRepIteretive(int[] array)
        {
            int n = array.Length;

            // indexes[i] = i+1;
            int[] indexes = new int[n];
            for (int num = 0; num < n - 1;)
            {
                indexes[num] = ++num;
            }

            PrintResult(array);
            for (int position = n - 2; position >= 0;)
            {
                while (indexes[position] < n && array[indexes[position]] == array[position])
                {
                    indexes[position]++;
                }

                // swap ps[i] <--> ps[indexes[i]
                if (indexes[position] < n)
                {
                    Swap(ref array, indexes, position);
                    PrintResult(array);
                }

                indexes[position]++;
                position = n - 2;

                while (position >= 0 && indexes[position] >= n)
                {
                    // Undo previous permutation from i+1
                    // Cyclical rotation to the left from i+1
                    // ps[k] = ps[k+1]
                    int tmp = array[position];
                    for (int k = position; k < n - 1;)
                    {
                        array[k] = array[++k];
                    }

                    array[n - 1] = tmp;

                    // indexes[i]=i+1;
                    // i--;
                    indexes[position] = position-- + 1;
                }
            }
        }

        private static void PrintResult(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }

        private static void Swap(ref int[] array, int[] indexes, int position)
        {
            int tmp = array[indexes[position]];
            array[indexes[position]] = array[position];
            array[position] = tmp;
        }
    }
}
