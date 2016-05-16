namespace PermutationsWithRepetition
{
    using System;
    using System.Collections.Generic;

    public class PermutationsWithRepetition
    {
        private static List<string> combinations = new List<string>();

        static void Main()
        {
            Console.WriteLine("Hello pleace enter the numbers separated by space in the array!");
            Console.WriteLine("Array numbers: ");
            int n = int.Parse(Console.ReadLine());

            var array = new[] { 1, 3, 5, 5 };
            Permute(array);
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                if (!CombinationExists(array))
                {
                    combinations.Add(string.Join(" ", array));
                    Console.WriteLine(string.Join(", ", array));
                }

                return;
            }

            for (int index = startIndex; index < array.Length; index++)
            {
                Swap(ref array[startIndex], ref array[index]);
                Permute(array, startIndex + 1);
                Swap(ref array[index], ref array[startIndex]);
            }
        }

        private static bool CombinationExists(int[] combination)
        {
            foreach (var comb in combinations)
            {
                if (string.Join(" ", combination) == string.Join(" ", comb))
                {
                    return true;
                }
            }

            return false;
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
