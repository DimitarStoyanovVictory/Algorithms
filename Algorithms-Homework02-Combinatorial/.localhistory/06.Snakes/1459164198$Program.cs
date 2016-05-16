namespace Snakes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static List<char> _result = new List<char>();
        private static string _printString = "";

        static void Main()
        {
            int n = 5;

            _result.Add('S');
            for (int index = 0; index < n - 1; index++)
            {
                _result.Add('R');
            }

            _result.ForEach(x => _printString += x);

            DrawSnake(n);
        }

        private static void DrawSnake(int n)
        {
            int i = 0;

            while (true)
            {
                if (i >= n)
                {
                    break;
                }

                i++;
                MovingCombinations(i, n);
            }
        }

        private static void MovingCombinations(int i, int n)
        {
            int listLength = _result.Count;
            _result.RemoveRange(_result.Count - i - 1, i + 1);

            FindPath(n);
        }

        private static void FindPath(int n, char direction = 'R')
        {
            if (_result.Last() == 'R' && direction == 'L')
            {
                return;
            }

            _result.Add(direction);
            _printString = "";
            _result.ForEach(x => _printString += x);

            if (_result.Count >= n)
            {
                PrintResult(_printString);
                _result.RemoveRange(_result.Count - 1, 1);
                return;
            }

            FindPath(n, 'R');
            FindPath(n, 'D');
            FindPath(n, 'L');
            FindPath(n, 'U');
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
