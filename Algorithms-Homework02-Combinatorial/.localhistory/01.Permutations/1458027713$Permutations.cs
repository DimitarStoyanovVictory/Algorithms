namespace Permutations
{
    using System;
    using System.Linq;

    internal class Permutations
    {
        private static int countOfPermutations = 0;

        static void Main()
        {
            int n = 3;
            var array = Enumerable.Range(1, n).ToArray();

            Permute(array);

            Console.WriteLine($"Total permutations: {countOfPermutations}");
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                Console.WriteLine(string.Join(", ", array));
                countOfPermutations++;
            }

            for (int index = startIndex; index < array.Length; index++)
            {
                Swap(ref array[index], ref array[startIndex]);
                Permute(array, index + 1);
                Swap(ref array[startIndex], ref array[index]);
                Permute(array, index + 1);
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
