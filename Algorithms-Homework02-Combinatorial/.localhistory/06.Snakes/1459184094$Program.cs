namespace Snakes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<char> _result = new List<char>();
        private static string _printString = "";
        private static List<string> _combinations = new List<string>();
        private static int _snakesCount = 0;

        static void Main()
        {
            int n = 4;

            _result.Add('S');
            for (int index = 0; index < n - 1; index++)
            {
                _result.Add('R');
            }

            _result.ForEach(x => _printString += x);

            if (n > 2)
            {
                DrawSnake(n);
            }
            else
            {
                PrintResult(_printString);
                Console.WriteLine(_snakesCount);
            }
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
            if (_result[_result.Count - 1] == 'R' && direction == 'L')
            {
                return;
            }
            else if (_result[_result.Count - 1] == 'U' && (direction == 'D' || direction == 'U'))
            {
                return;
            }
            else if (_result[_result.Count - 1] == 'D' && direction == 'U')
            {
                return;
            }

            _result.Add(direction);
            _printString = "";
            _result.ForEach(x => _printString += x);

            if (_result.Count == n)
            {
                if (!CombinationExists(_printString))
                {
                    PrintResult(_printString);
                    _result.RemoveRange(_result.Count - 1, 1);
                    return;
                }

                _result.RemoveRange(_result.Count - i, i);
                return;
            }

            FindPath(n, i, 'R');
            FindPath(n, i, 'D');
            FindPath(n, i, 'L');
            FindPath(n, i, 'U');

        }

        private static bool CombinationExists(string printString)
        {
            return _combinations.Contains(printString);
        }

        private static void PrintResult(string result)
        {
            _combinations.Add(result);
            Console.WriteLine(result);
        }
    }
}
