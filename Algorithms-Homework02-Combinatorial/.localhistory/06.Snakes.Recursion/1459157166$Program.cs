﻿namespace Snakes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static string _result = "";
        private static List<string> snakes = new List<string>();

        static void Main()
        {
            int n = 5;

            _result += 'S';
            for (int index = 0; index < n - 2; index++)
            {
                _result += "R";
            }

            snakes.Add(_result);

            DrawSnake(n);
        }

        private static void DrawSnake(int n)
        {
            int i = 1;
            PrintResult(_result);

            while (true)
            {
                n--;
                if (n <= 1)
                {
                    break;
                }

                i++;
                MovingCombinations(i);
            }
        }

        private static void MovingCombinations(int i)
        {
            int listLength = _result.Count;
            _result.RemoveRange(_result.Count - i - 1, _result.Count - 1);

            char direction = ' ';
            if (i == 1)
            {
                direction = 'D';
            }

            _result.Add(direction);

            return;
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
