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
            string[] inputN = Console.ReadLine().Split(' ');

            int[] numbersC = new int[inputC.Length];
            int[] numbersN = new int[inputN.Length];
            for (int index = 0; index < inputC.Length; index++)
            {
                numbersC[index] = Convert.ToInt32(inputC[index]);
            }

            for (int index = 0; index < inputN.Length; index++)
            {
                numbersN[index] = Convert.ToInt32(inputN[index]);
            }

            int[] output = new int[numbersN.Length];
            for (int index = 0; index < numbersN.Length; index++)
            {
                for (int i = 0; i < UPPER; i++)
                {
                    
                }
            }
        }
    }
}
