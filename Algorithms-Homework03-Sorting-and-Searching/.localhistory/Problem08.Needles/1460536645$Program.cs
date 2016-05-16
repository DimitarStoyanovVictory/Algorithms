namespace Problem08.Needles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string inputCN = Console.ReadLine();
            string[] inputC = Console.ReadLine().Split(' ');
            string inputN = Console.ReadLine();

            int[] numbers = new int[inputC.Length];
            for (int index = 0; index < inputC.Length; index++)
            {
                numbers[index] = Convert.ToInt32(inputC[index]);
            }
        }
    }
}
