namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = 5;

            var array = Enumerable.Range(1, n).ToArray();

            for (int index = 0; index < array.Length; index++)
            {
                if (index % 2 != 0)
                {
                    Swap(ref array[array.Length - index], ref array[array.Length - index - 1]);
                }

                Console.WriteLine(string.Join(", ", array));
            }
        }

        private static void Swap(ref int i, ref int i1)
        {
            if (i == i1)
            {
                return;
                ;
            }
        }
    }
}
