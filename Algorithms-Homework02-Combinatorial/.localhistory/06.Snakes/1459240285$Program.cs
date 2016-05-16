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
            int n = 5;

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
            }

            Console.WriteLine($"Snakes count = {_snakesCount}");
        }

        private static void DrawSnake(int n)
        {
            int i = 0;

            while (true)
            {
                i++;

                if (i >= n)
                {
                    break;
                }

                MovingCombinations(i, n);
            }
        }

        private static void MovingCombinations(int i, int n)
        {
            _result.RemoveRange(n - i - 1, i + 1);

            FindPath(n, i);
        }

        private static void FindPath(int n, int i, char direction = 'R')
        {
            if (_result[_result.Count - 1] == 'R' && direction == 'L')
            {
                _result.Add('R');
                return;
            }
            else if (_result[_result.Count - 1] == 'U' && (direction == 'D' || direction == 'U'))
            {
                _result.Add('R');
                return;
            }
            else if (_result[_result.Count - 1] == 'D' && direction == 'U')
            {
                _result.Add('R');
                return;
            }
            else if (_result[_result.Count - 1] == 'R' && direction == 'U')
            {
                _result.Add('R');
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
            else if (_result.Count >= n)
            {
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
            _snakesCount++;
            _combinations.Add(result);
            Console.WriteLine(result);
        }
    }
}
