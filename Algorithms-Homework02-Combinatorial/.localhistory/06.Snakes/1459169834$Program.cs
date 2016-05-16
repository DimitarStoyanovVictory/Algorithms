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

            FindPath(n, i);
        }

        private static void FindPath(int n, int i, char direction = 'R')
        {
            if (_result.Last() == 'R' && direction == 'L')
            {
                return;
            }

            _result.Add(direction);
            _printString = "";
            _result.ForEach(x => _printString += x);

            if (_result.Count >= n && CombinationExists(_result))
            {
                PrintResult(_printString);
                for (int j = i; j >= 1; j++)
                {
                    _result.RemoveRange(_result.Count - j, j);
                    return;
                }
            }

            FindPath(n, i, 'R');
            FindPath(n, i, 'D');
            FindPath(n, i, 'L');
            FindPath(n, i, 'U');
        }

        private static bool CombinationExists(List<char> result)
        {
            throw new NotImplementedException();
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
