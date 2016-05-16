namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;

    public class PathsBetweenCellsInMatrix
    {
        private static string pathFound;

        private static char[,] _matrix;

        private static string _result;

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
                {'s', ' ', ' ', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', '*', ' '},
                {' ', '*', 'e', ' '},
                {' ', ' ', ' ', ' '}
            };

            FindPath();
        }

        private static void FindPath(int row = 0, int col = 0, char direction = 's')
        {
            if (!InRange(row, col))
            {
                return;    
            }

            if (_matrix[row, col] == 'e')
            {
                PrintResult(_result);
                return;
            }

            if (_matrix[row, col] == ' ')
            {
                PrintResult(_result);
            }
            
            FindPath(row - 1, col, 'U');
            FindPath(row, col + 1, 'R');
            FindPath(row + 1, col, 'D');
            FindPath(row, col - 1, 'L');
        }

        private static bool InRange(int row, int col)
        {
            return row >= 0 && row < _matrix.GetLength(0) &&
                   col >= 0 && col < _matrix.GetLength(1);
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
