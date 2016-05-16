﻿namespace PermutationsWithRepetition
{
    using System;
    using System.Collections.Generic;

    public class PermutationsWithRepetition
    {
        private static List<int[]> combinations = new List<int[]>();

        static void Main()
        {
            var array = new[] { 1, 3, 5, 5 };
            Permute(array);
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                CheckIfCombinationIsValid();
                combinations.Add(array);
                Console.WriteLine(string.Join(", ", array));
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