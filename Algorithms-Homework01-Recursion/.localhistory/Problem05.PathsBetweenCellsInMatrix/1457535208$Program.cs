namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class PathsBetweenCellsInMatrix
    {
        private static string pathFound;

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
            //Console.WriteLine("Hello, pleace create your matrix.");

            //Console.Write("Enter the number of rows of the matrix. row = ");
            //int rowNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns of the matrix. col = ");
            //int col = int.Parse(Console.ReadLine());

            //var matrix = new char[rowNum][];

            //for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            //{
            //    matrix[rowIndex] = new char[col];
            //}

            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (col = 0; col < matrix[row].Length; col++)
            //    {
            //        Console.Write("Pleace enter all the symbols on row {0}, notice that space is also a char: ", row);
            //        matrix[row] = Console.ReadLine().ToCharArray();
            //    }
            //}

            _matrix = new[,]
            {
                {'S', ' ', ' ', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', 'e', ' '},
                {' ', ' ', ' ', ' '}
            };

            FindPath();
        }

        private static void FindPath(int row = 0, int col = 0, char direction = 'S')
        {
            if (!InRange(row, col) || _matrix[row, col] != '#')
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

            Console.WriteLine();
        }
    }
}
