﻿namespace Problem02.LongestZigzagSubsequance
{
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            int[] input = {8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 12, 19, 11};

            var zigzagSequance = new List<int>();
            zigzagSequance.Add(input.First());

            bool evenElementsSmaller = input[0] > input[1];

            int index = 1;
            bool predicate;
            if (evenElementsSmaller)
            {
                predicate = input[index - 1] > input[index];
            }
            else
            {
                predicate = input[index - 1] < input[index];
            }

            bool predicateNum = true;
            while (index < zigzagSequance.Count - 1)
            {
                if (predicateNum && input[index - 1] > input[index])
                {
                    zigzagSequance.Add(input[index]);
                    predicateNum = false;
                }
                else if (!predicateNum && predicate)
                {
                    zigzagSequance.Add(index);
                    predicateNum = true;
                }

                index++;
            }
        }
    }
}
