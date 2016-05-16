namespace PermutationsInterativly
{
    using System;

    class Permotations
    {
        static void Main()
        {
            int[] ps = { 1, 2, 3, 4, 5, 6 };
            PermuteRepIteretive(ps);
        }

        public static void PermuteRepIteretive(int[] ps)
        {
            int n = ps.Length;
            int tmp = 0;

            // indexes[i] = i+1;
            int[] indexes = new int[n];
            for (int i = 0; i < n - 1;)
            {
                indexes[i] = ++i;
            }

            for (int i = n - 2; i >= 0;)
            {
                while (indexes[i] < n && ps[indexes[i]] == ps[i])
                {
                    indexes[i]++;
                }

                // swap ps[i] <--> ps[indexes[i]
                if (indexes[i] < n)
                {
                    tmp = ps[indexes[i]];
                    ps[indexes[i]] = ps[i];
                    ps[i] = tmp;
                }

                indexes[i]++;

                i = n - 2;

                while (i >= 0 && indexes[i] >= n)
                {
                    // Undo previous permutation from i+1
                    // Cyclical rotation to the left from i+1
                    // ps[k] = ps[k+1]
                    tmp = ps[i];
                    for (int k = i; k < n - 1;)
                        ps[k] = ps[++k];
                    ps[n - 1] = tmp;

                    // indexes[i]=i+1;
                    // i--;
                    indexes[i] = i-- + 1;
                }

                Console.WriteLine(string.Join(", ", indexes));
            }
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