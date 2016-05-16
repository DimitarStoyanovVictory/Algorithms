namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;

    public class PathsBetweenCellsInMatrix
    {
        private static string pathFound;
        private static char[][] _matrix;
        private static string result;

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

            _matrix = new[]
            {
                new[] { 's', ' ', ' ', ' ' },
                new[] { ' ', '*', '*', ' ' },
                new[] { ' ', '*', '*', ' ' },
                new[] { ' ', '*', 'e', ' ' },
                new[] { ' ', ' ', ' ', ' ' } 
            };

            FindPath(_matrix);
        }

        private static void FindPath(int row = 0, int col = 0)
        {
            if (!InRange(row, col))
            {
                return;    
            }

            if (_matrix[row][col + 1] == 'e')
            {
                result += "R";
                PrintResult(result);
                return;
            }
            if (_matrix[row][col + 1] == ' ')
            {
                _matrix[row][col + 1] = '#';
                result += "R";
                FindPath(_matrix, row, col + 1, result);
            }
            
            if (_matrix[row - 1][col] == 'e')
            {
                result += "U";
                PrintResult(result);
                return;
            }
            if (_matrix[row - 1][col] == ' ')
            {
                _matrix[row - 1][col] = '#';
                result += "U";
                FindPath(_matrix, row, col - 1, result);
            }

            if (_matrix[row][col - 1] == 'e')
            {
                result += "L";
                PrintResult(result);
                return;
            }
            if (_matrix[row][col - 1] == ' ')
            {
                _matrix[row][col - 1] = '#';
                result += "L";
                FindPath(_matrix, row, col - 1, result);
            }

            if (_matrix[row + 1][col] == 'e')
            {
                result += "D";
                PrintResult(result);
            }
            else if (_matrix[row + 1][col] == ' ')
            {
                _matrix[row + 1][col] = '#';
                result += "D";
                FindPath(_matrix, row + 1, col, result);
            }
        }

        private static bool InRange(int row, int col)
        {

        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
