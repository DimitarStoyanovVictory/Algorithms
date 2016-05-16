namespace PermutationsWithRepetition
{
    using System;

    public class PermutationsWithRepetition
    {
        static void Main()
        {
            var array = new int[] { 1, 3, 5, 5 };
            Permute(array);
        }

        private static void Permute(int[] array, int startIndex = 0)
        {
            if (startIndex >= array.Length - 1)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }

            for (int index = startIndex; index < array.Length; index++)
            {
                if (!CheckIfNumAreEqual(array[startIndex], array[index]))
                {
                    Swap(ref array[startIndex], ref array[index]);
                }

                Permute(array, startIndex + 1);
                if (!CheckIfNumAreEqual(array[startIndex], array[index]))
                {
                    Swap(ref array[index], ref array[startIndex]);
                }
            }
        }

        private static bool CheckIfNumAreEqual(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return true;
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
