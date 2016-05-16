namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class PathsBetweenCellsInMatrix
    {
        private static int _pathsFound;

        private static char[,] _matrix;

        private static List<char> _result = new List<char>();

        public static List<char> Result => _result;

        static void Main()
        {
            Console.WriteLine("Hello, pleace create your matrix.");

            Console.Write("Enter the number of rows of the matrix. row = ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns of the matrix. col = ");
            int col = int.Parse(Console.ReadLine());
            _matrix = new char[row, col];

            Console.WriteLine("Now pleace enter all the elements of each line, notice that empty space is also an element");
            for (int indexRow = 0; indexRow < _matrix.GetLength(0); indexRow++)
            {
                Console.Write("line {0}: ", indexRow);
                string currentLine = Console.ReadLine();

                for (int indexCol = 0; indexCol < _matrix.GetLength(1); indexCol++)
                {
                    foreach (var charecter in currentLine)
                    {
                        _matrix[indexRow, indexCol] = charecter;
                    }
                }
            }

            //_matrix = new[,]
            //{
            //    {'S', ' ', ' ', ' ', ' ', ' ' },
            //    {' ', '*', '*', ' ', '*', ' ' },
            //    {' ', '*', '*', ' ', '*', ' ' },
            //    {' ', '*', 'e', ' ', ' ', ' ' },
            //    {' ', ' ', ' ', '*', ' ', ' ' }
            //};

            FindPaths();

            Console.WriteLine("Total paths found: {0}", _pathsFound);
        }

        private static void FindPaths(int row = 0, int col = 0, char direction = 'S')
        {
            if (!InRange(row, col) || _matrix[row, col] == '#' || _matrix[row, col] == '*')
            {
                return;    
            }

            Result.Add(direction);

            if (_matrix[row, col] == 'e')
            {
                PrintResult(Result);
            }

            if (_matrix[row, col] == ' ' || _matrix[row, col] == 'S')
            {
                _matrix[row, col] = '#';

                FindPaths(row - 1, col, 'U');
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');

                _matrix[row, col] = ' ';
            }

            Result.RemoveAt(Result.Count - 1);
        }

        private static bool InRange(int row, int col)
        {
            return row >= 0 && row < _matrix.GetLength(0) &&
                   col >= 0 && col < _matrix.GetLength(1);
        }

        private static void PrintResult(List<char> result)
        {
            foreach (var character in result)
            {
                Console.Write(character);
            }

            _pathsFound++;
            Console.WriteLine();
        }
    }
}
