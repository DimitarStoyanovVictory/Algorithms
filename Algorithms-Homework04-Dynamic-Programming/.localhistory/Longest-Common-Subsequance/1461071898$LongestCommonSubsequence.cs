﻿namespace LongestCommonSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    public class LongestCommonSubsequence
    {
        public static void Main()
        {
            FindLongestCommonSubsequence("tree", "team");
            PrintLCS("tree", "team");
        }

        static int[,] InitializeLCS(string firstStr, string secondStr, int[,] lcs)
        {
            for (int x = 0; x < firstStr.Length; x++)
            {
                for (int y = 0; y < secondStr.Length; y++)
                {
                    lcs[x, y] = -1;
                }
            }
        }

        public static int FindLongestCommonSubsequence(string firstStr, string secondStr)
        {
            int[,] lcs = new int[firstStr.Length, secondStr.Length];
            lcs = InitializeLCS(firstStr, secondStr, lcs);

            if (firstStr.Length < 0 || secondStr.Length < 0)
            {
                return 0;
            }

            CalcLCS(firstStr.Length, secondStr.Length, lcs, firstStr, secondStr);
        }

        private static int CalcLCS(int x, int y, int[,] lcs, string firstStr, string secondStr)
        {
            if (x < 0 || y < 0)
            {
                return 0;
            }

            if (lcs[x, y] == - 1)
            {
                int lcsFirstMinusOne = CalcLCS(x - 1, y, lcs, firstStr, secondStr);
                int lcsSecondMinusOne = CalcLCS(x - 1, y, lcs, firstStr, secondStr);
                lcs[x, y] = Math.Max(lcsFirstMinusOne, lcsSecondMinusOne);
                if (firstStr[x] == secondStr[y])
                {
                    int lcsBothMinusOne = 1 + CalcLCS(x - 1, y, lcs, firstStr, secondStr);
                    lcs[x, y] = Math.Max(lcs[x, y], lcsBothMinusOne);
                }
            }

            return lcs[x, y];
        }

        static void PrintLCS(string fristStr, string secondStr)
        {
            Console.WriteLine("LCS = " + FindLongestCommonSubsequence(fristStr.Length, secondStr.Length));

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
