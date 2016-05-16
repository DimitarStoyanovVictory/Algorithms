namespace Snakes
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Program
    {
        private static List<char> _result = new List<char>();

        static void Main()
        {
            int n = 5;

            var startPoint = new Point(1, 1);

            DrawSnake(n, startPoint);
        }

        private static void DrawSnake(int n, Point currentPoint, char direction = 'S')
        {
            _result.Add(direction);

            while (n < (currentPoint.X + currentPoint.Y) - 1)
            {
                    
            }
        }
    }
}
