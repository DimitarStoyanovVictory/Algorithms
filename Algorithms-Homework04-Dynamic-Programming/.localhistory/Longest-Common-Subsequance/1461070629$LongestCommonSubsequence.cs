﻿namespace LongestCommonSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestCommonSubsequence
    {
        public static void Main()
        {
            var firstStr = "tree";
            var secondStr = "team";

            InitializeLCS();
            FindLongestCommonSubsequence(firstStr.Length - 1, secondStr.Length - 1);
            PrintLCS(firstStr.Length - 1, secondStr.Length - 1);
        }

        static void InitializeLCS()
        {
            for (int x = 0; x < firstStr.Length; x++)
            {
                for (int y = 0; y < secondStr.Length; y++)
                {
                    lcs[x, y] = -1;
                }
            }
        }

        public static int FindLongestCommonSubsequence(int x, int y)
        {
            string firstStr = "tree";
            string secondStr = "team";
            int[,] lcs = new int[firstStr.Length, secondStr.Length];

            if (x < 0 || y < 0)
            {
                return 0;
            }

            if (lcs[x, y] == -1)
            {
                int lcsFirstMinusOne = FindLongestCommonSubsequence(x - 1, y);
                int lcsSecondMinusOne = FindLongestCommonSubsequence(x, y - 1);
                lcs[x, y] = Math.Max(lcsFirstMinusOne, lcsSecondMinusOne);
                if (firstStr[x] == secondStr[y])
                {
                    int lcsBothMinusOne = 1 + FindLongestCommonSubsequence(x - 1, y - 1);
                    lcs[x, y] = Math.Max(lcs[x, y], lcsBothMinusOne);
                }
            }

            return lcs[x, y];
        }

        static void PrintLCS(int x, int y)
        {
            Console.WriteLine("LCS = " + FindLongestCommonSubsequence(x, y));

            List<char> lcsLetters = new List<char>();
            while (x >= 0 && y >= 0)
            {
                if ((firstStr[x] == secondStr[y]) &&
                    (FindLongestCommonSubsequence(x - 1, y - 1) + 1 == lcs[x, y]))
                {
                    lcsLetters.Add(firstStr[x]);
                    x--;
                    y--;
                }
                else if (FindLongestCommonSubsequence(x - 1, y) == lcs[x, y])
                {
                    x--;
                }
                else
                {
                    y--;
                }
            }

            lcsLetters.Reverse();
            string lcsStr = string.Join("", lcsLetters);
            Console.WriteLine(lcsStr);
        }
    }
}
