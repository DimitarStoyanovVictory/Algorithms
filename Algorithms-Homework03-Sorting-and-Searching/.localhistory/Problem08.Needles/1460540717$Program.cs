namespace Problem08.Needles
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string inputCN = Console.ReadLine();
            string[] inputC = Console.ReadLine().Split(' ');
            string[] inputN = Console.ReadLine().Split(' ');

            var numbersC = new List<int>();
            var numbersN = new List<int>();
            for (int index = 0; index < inputC.Length; index++)
            {
                if (inputC[index] == "0")
                {
                    continue;
                }

                numbersC.Add(Convert.ToInt32(inputC[index]));
            }

            for (int index = 0; index < inputN.Length; index++)
            {
                if (inputN[index] == "0")
                {
                    continue;
                }

                numbersN.Add(Convert.ToInt32(inputN[index]));
            }

            int[] output = new int[numbersN.Count];
            for (int indexN = 0; indexN < numbersN.Count; indexN++)
            {
                int currentNNum = numbersN[indexN];
                for (int indexC = 0; indexC < numbersC.Count; indexC++)
                {
                    int currentCNum = numbersC[indexC];
                    if (currentCNum >= currentNNum)
                    {
                        output[indexN] = indexC;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
