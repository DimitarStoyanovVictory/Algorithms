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

            while (true)
            {
                PrintResult(_result);

                n--;
                if (n == 0)
                {
                    break;
                }

                i++;

                for (int index = 0; index < i; index++)
                {
                        
                }
            }
        }

        private static void PrintResult(List<char> result)
        {
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
