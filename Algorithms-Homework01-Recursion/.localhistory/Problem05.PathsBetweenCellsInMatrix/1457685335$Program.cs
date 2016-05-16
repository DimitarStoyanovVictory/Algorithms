namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;
    using static System.Char;

    public class PathsBetweenCellsInMatrix
    {
        private static int _pathFound;

        private static char[,] _matrix;

        private static List<char> _result = new List<char>();

        public static List<char> Result
        {
            get
            {
                return _result;
            }

            set
            {
                _result = value;
            }
        }

        static void Main()
        {
            Console.WriteLine("Hello, pleace create your matrix.");

            Console.Write("Enter the number of rows of the matrix. row = ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns of the matrix. col = ");
            int col = int.Parse(Console.ReadLine());
            _matrix = new char[row, col];

            for (int indexRow = 0; indexRow < _matrix.GetLength(0); indexRow++)
            {
                Console.Write("Enter all the elemnts of line consequently {0}, notice that sapce is also a element; line: ", indexRow);
                string currentLine = Console.ReadLine();

                for (int indexCol = 0; indexCol < _matrix.GetLength(1); indexCol++)
                {
                    foreach (var charecter in currentLine)
                    {
                        _matrix[indexRow, indexCol] = charecter;
                    }
                }
            }

            FindPath();

            Console.WriteLine("Total paths found: {0}", _pathFound);
        }

        private static void FindPath(int row = 0, int col = 0, char direction = 'S')
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

                FindPath(row - 1, col, 'U');
                FindPath(row, col + 1, 'R');
                FindPath(row + 1, col, 'D');
                FindPath(row, col - 1, 'L');

                _matrix[row, col] = ' ';
            }

            Result.Remove(direction);
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

            _pathFound++;
            Console.WriteLine();
        }
    }
}
