namespace PermutationsInterativly
{
    using System;
    using System.Linq;

    class Permotations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var array = Enumerable.Range(0, n).ToArray();

            for (int indexRow = 0; indexRow < array.Length; indexRow++)
            {
                for (int indexCol = 0; indexCol < array.Length; indexCol++)
                {
                    Console.WriteLine(string.Join(",", array));
                }
            }
        }
    }
}
