﻿namespace PermutationsInterativly
{
    using System;
    using System.Linq;
    using System.Reflection.Emit;

    class Permotations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Enumerable.Range(1, n).ToArray();

            PermuteRepIteretive(array);
        }

        public static void PermuteRepIteretive(int[] ps)
        {
            int n = ps.Length;

            // indexes[i] = i+1;
            int[] indexes = new int[n];
            for (int num = 0; num < n - 1;)
            {
                indexes[num] = ++num;
            }

            for (int position = n - 2; position >= 0;)
            {
                Console.WriteLine(string.Join(", ", ps));

                while (indexes[position] < n && ps[indexes[position]] == ps[position])
                {
                    indexes[position]++;
                }

                // swap ps[i] <--> ps[indexes[i]
                if (indexes[position] < n)
                {
                    Swap(ref ps, indexes, position);
                }

                indexes[position]++;
                position = n - 2;

                while (position >= 0 && indexes[position] >= n)
                {
                    // Undo previous permutation from i+1
                    // Cyclical rotation to the left from i+1
                    // ps[k] = ps[k+1]
                    tmp = ps[position];
                    for (int k = position; k < n - 1;)
                        ps[k] = ps[++k];
                    ps[n - 1] = tmp;

                    // indexes[i]=i+1;
                    // i--;
                    indexes[position] = position-- + 1;
                }
            }
        }

        private static void Swap(ref int[] ps, int[] indexes, int i)
        {
            int tmp = ps[indexes[i]];
            ps[indexes[i]] = ps[i];
            ps[i] = tmp;
        }
    }
}


//static void Main()
//{
//    //Console.Write("Hello, pleace enter a positive integer number to calculate the combinations with repetiiton; n = ");
//    int n = 6;

//    var arrayForSwap = Enumerable.Range(1, n).ToArray();
//    int count = 0;
//    int i = n;
//    int z = 1;
//    int p = 0;
//    if (n > 3)
//    {
//        i = 4;
//        p = 4;
//    }

//    int j = i - 1;
//    bool resetP = false;

//    while (p < n)
//    {
//        for (int k = 1; k <= i; k++)
//        {
//            for (int l = 0; l < j; l++)
//            {
//                for (int index = n - 1; index > n - i + 1; index--)
//                {
//                    PrintResult(arrayForSwap);
//                    Swap(ref arrayForSwap[index], ref arrayForSwap[index - 1]);
//                    count++;
//                }
//            }

//            if (k != i)
//            {
//                Swap(ref arrayForSwap[n - i], ref arrayForSwap[n - i + k]);
//            }
//        }

//        z++;

//        if (z == n)
//        {
//            p++;
//            if (z == arrayForSwap.ToList().FindIndex(x => x == z + 1))
//            {

//            }
//            z = 1;
//            resetP = true;
//        }

//        int swapIndex = arrayForSwap.ToList().FindIndex(x => x == z + 1);

//        if (p < n)
//        {
//            Swap(ref arrayForSwap[n - p - 1], ref arrayForSwap[swapIndex]);

//            if (resetP)
//            {
//                p--;
//                resetP = false;
//            }
//        }
//    }

//    Console.WriteLine($"Total permutations: {count}");
//    //Console.WriteLine($"Total permutations: {_countOfPermutations}");
//    //_result.AppendLine($"Total permutations: {_countOfPermutations}");
//    //sw.Write(_result);
//}

//private static void PrintResult(int[] ints)
//{
//    //_result.AppendLine(string.Join(", ", ints));
//    Console.WriteLine(string.Join(", ", ints));
//}

//private static void Swap(ref int numberOne, ref int numberTwo)
//{
//    if (numberOne == numberTwo)
//    {
//        return;
//    }

//    int tempNumber = numberOne;
//    numberOne = numberTwo;
//    numberTwo = tempNumber;
//}