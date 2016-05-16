namespace Problem02.LongestZigzagSubsequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            int[] input = {8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 12, 19, 11};

            var zigzagSequance = new List<int>();
            zigzagSequance.Add(input.First());

            int index = 1;
            bool predicateNum = true;
            while (index < input.Length)
            {
                if (predicateNum && zigzagSequance[index - 1] > input[index])
                {
                    zigzagSequance.Add(input[index]);
                    predicateNum = false;
                }
                else if (!predicateNum && zigzagSequance[index - 1] < input[index])
                {
                    zigzagSequance.Add(input[index]);
                    predicateNum = true;
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", zigzagSequance));
        }
    }
}
