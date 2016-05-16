namespace Problem08.Needles
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
                numbersC[index] = int.Parse(inputC[index]);
            }

            for (int index = 0; index < inputN.Length; index++)
            {
                numbersN[index] = int.Parse(inputN[index]);
            }

            int[] output = new int[numbersN.Length];
            for (int indexN = 0; indexN < numbersN.Length; indexN++)
            {
                for (int indexC = 0; indexC < numbersC.Length; indexC++)
                {
                    if (numbersN[indexN] >= numbersC[indexC])
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
                        output[indexN] = indexC + 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
