﻿namespace Problem02.LongestZigzagSubsequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            int[] input = { 1, 3, 2 };

            var zigzagSequance = new List<int>();
            zigzagSequance.Add(input.First());

            bool predicateNum = true;
            if (input[1] > input[0])
            {
                predicateNum = false;
            }

            int index = 1;
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
