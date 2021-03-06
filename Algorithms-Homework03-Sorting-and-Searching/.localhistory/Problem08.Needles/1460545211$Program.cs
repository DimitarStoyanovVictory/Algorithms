﻿namespace Problem08.Needles
{
    using System;

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
            int j = 1;
            for (int indexN = 0; indexN < numbersN.Length; indexN++)
            {
                int currentNNum = numbersN[indexN];
                for (int indexC = 0; indexC < numbersC.Length; indexC++)
                {
                    int currentCNum = numbersC[indexC];
                    if (currentCNum >= currentNNum)
                    {
                        int i = 1;
                        while (true)
                        {
                            if (indexC != 0 && numbersC[indexC - i] == 0)
                            {
                                indexC--;
                            }
                            else
                            {
                                break;
                            }
                        }

                        output[indexN] = indexC;
                        break;
                    }
                    else if (indexC == numbersC.Length - 1)
                    {
                        output[indexN] = indexC + j;
                        j++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
