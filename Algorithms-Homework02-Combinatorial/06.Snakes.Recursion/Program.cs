namespace Snakes
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static List<char> _result = new List<char>();
        private static List<string> snakes = new List<string>();
        private static string currentString = "";

        static void Main()
        {
            int n = 5;

            _result.Add('S');
            for (int index = 0; index < n - 2; index++)
            {
                _result.Add('R');
            }

            _result.ForEach(x => currentString += x);
            snakes.Add(currentString);

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

        private static void PrintResult(List<char> result)
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
