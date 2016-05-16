namespace Snakes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<char> _result = new List<char>();

        static void Main()
        {
            int n = 5;

            _result.Add('S');
            for (int index = 0; index < n - 1; index++)
            {
                _result.Add('R');
            }

            DrawSnake(n);
        }

        private static void DrawSnake(int n)
        {
            int i = 0;
            PrintResult(_result);

            while (true)
            {
                n--;
                if (n <= 1)
                {
                    break;
                }

                i++;
                bool calculatingCombinationsStop = false;
                while (!calculatingCombinationsStop)
                {
                    calculatingCombinationsStop = MovingCombinations(i);
                }
            }
        }

        private static bool MovingCombinations(int i)
        {
            int listLength = _result.Count;
            _result.RemoveRange(_result.Count - i - 1, _result.Count - 1);

            char direction = ' ';
         
            _result.Add(direction);

            return false;
        }

        private static void PrintResult(List<char> result)
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
