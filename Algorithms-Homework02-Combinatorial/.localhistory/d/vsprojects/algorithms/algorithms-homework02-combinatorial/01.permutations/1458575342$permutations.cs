namespace Permutations
{
    using System;
    using System.Linq;

    internal class Permutations
    {
        private static int _countOfPermutations = 0;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var array = Enumerable.Range(1, n).ToArray():
            Permute(array);

            Console.WriteLine($"Total permutations: {_countOfPermutations}");
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                Console.WriteLine(string.Join(", ", array));
                _countOfPermutations++;
                return;
            }

            for (int index = startIndex; index < array.Length; index++)
            {
                Swap(ref array[startIndex], ref array[index]);
                Permute(array, startIndex + 1);
                Swap(ref array[index], ref array[startIndex]);
            }
        }

        private static void Swap(ref int firstNumber, ref int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return;
            }

            firstNumber ^= secondNumber;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;
        }
    }
}

//int n = 3;
//var a = Enumerable.Range(1, n).ToArray();
//var p = Enumerable.Range(0, n + 1).ToArray();

//p[n] = n;
//PrintResult(a);

//int i = 1;
//int j = 0;
//int temp = 0;
//while (i < n)
//{
//    p[i]--;
//    if (i % 2 != 0)
//    {
//        j = p[i];
//    }
//    //Swap(a[j], a[i]);
//    temp = a[j];
//    a[j] = a[i];
//    a[i] = temp;

//    PrintResult(a);

//    while (p[i] == 0)
//    {
//        p[i] = 1;
//        i++;
//    }
//}
