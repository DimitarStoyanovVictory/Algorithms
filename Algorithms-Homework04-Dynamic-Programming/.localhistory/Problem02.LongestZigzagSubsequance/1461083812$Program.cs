﻿namespace Problem02.LongestZigzagSubsequance
{
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        static void Main()
        {
            var input =  new HashSet<int> {8, 3, 5, 7, 0, 8, 9, 10, 20, 20, 12, 19, 11};
            
            var zigzagSequance = new List<int>();
            zigzagSequance.Add(input.First());

            for (int index = 1; index < input.Count; index++)
            {
                if (input[index] > zigzagSequance[index - 1])
                {
                }
            }
        }
    }
}
