namespace Problem02.LongestZigzagSubsequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(',');

            int[] inputNum = new int[input.Length];
            for (int indexStr = 0; indexStr < input.Length; indexStr++)
            {
                inputNum[indexStr] = Convert.ToInt32(input[indexStr]);
            }

            var zigzagSequance = new List<int>();
            zigzagSequance.Add(inputNum.First());

            bool predicateNum = inputNum[1] < inputNum[0];

            int index = 1;
            while (index < inputNum.Length)
            {
                if (predicateNum && zigzagSequance.Last() > inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Add(inputNum[index]);
                    predicateNum = false;
                }
                else if (!predicateNum && zigzagSequance.Last() < inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Add(inputNum[index]);
                    predicateNum = true;
                }
                else if (predicateNum && zigzagSequance.Last() < inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Remove(zigzagSequance.Last());
                    zigzagSequance.Add(inputNum[index]);
                }
                else if (!predicateNum && zigzagSequance.Last() > inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Remove(zigzagSequance.Last());
                    zigzagSequance.Add(inputNum[index]);
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", zigzagSequance));
        }
    }
}
