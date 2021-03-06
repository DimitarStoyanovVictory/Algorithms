﻿namespace Problem02.LongestZigzagSubsequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            int[] input = { 24, 5, 31, 3, 3, 342, 51, 114, 52, 55, 56, 58 };

            var zigzagSequance = new List<int>();
            zigzagSequance.Add(input.First());

            int index = 1;
            bool predicateNum = true;
            while (index < input.Length)
            {
                if (predicateNum && zigzagSequance.Last() > input[index] && !zigzagSequance.Contains(input[index]))
                {
                    zigzagSequance.Add(input[index]);
                    predicateNum = false;
                }
                else if (!predicateNum && zigzagSequance.Last() < input[index] && !zigzagSequance.Contains(input[index]))
                {
                    zigzagSequance.Add(input[index]);
                    predicateNum = true;
                }
                else if (predicateNum && zigzagSequance.Last() < input[index] && !zigzagSequance.Contains(input[index]))
                {
                    zigzagSequance.Remove(zigzagSequance.Last());
                    zigzagSequance.Add(input[index]);
                }
                else if (!predicateNum && zigzagSequance.Last() > input[index] && !zigzagSequance.Contains(input[index]))
                {
                    zigzagSequance.Remove(zigzagSequance.Last());
                    zigzagSequance.Add(input[index]);
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", zigzagSequance));
        }
    }
}
