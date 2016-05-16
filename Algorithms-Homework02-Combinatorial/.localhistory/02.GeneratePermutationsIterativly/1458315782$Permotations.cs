namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 4;
            var array = Enumerable.Range(1, n).ToArray();

            int index = 0;
            int startIndex = 0;
            while (startIndex < n)
            {
                startIndex++;
                if (index > array.Length - 1)
                {
                    Console.WriteLine(string.Join(", ", array));
                }


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