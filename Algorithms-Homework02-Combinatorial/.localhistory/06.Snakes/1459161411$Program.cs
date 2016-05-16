namespace Snakes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<char> _result = new List<char>();
        private static string printString = "";

        static void Main()
        {
            int n = 5;

            _result.Add('S');
            for (int index = 0; index < n - 1; index++)
            {
                _result.Add('R');
            }

            _result.ForEach(x => printString += x);

            DrawSnake(n);
        }

        private static void DrawSnake(int n)
        {
            int i = 1;
            PrintResult(_result);

            while (true)
            {
                if (i >= n)
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

            FindPath();
        }

        private static void FindPath(char direction = 'R')
        {
            if (_result.Count >= n)
            {
                
            }
        }

        private static void PrintResult(List<char> result)
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
