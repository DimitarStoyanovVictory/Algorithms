﻿namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;
    using System.Data;
    using System.Security.Claims;

    public class PathsBetweenCellsInMatrix
    {
        private static string pathFound;
        
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

            var matrix = new[]
            {
                new[] { 's', ' ', ' ', ' ' },
                new[] { ' ', '*', '*', ' ' },
                new[] { ' ', '*', '*', ' ' },
                new[] { ' ', '*', 'e', ' ' },
                new[] { ' ', ' ', ' ', ' ' } 
            };

            FindPath(matrix);
        }

        private static void FindPath(char[][] matrix, int row = 0, int col = 0, string result = "")
        {
            if (row - 1 > 0)
            {
                if (matrix[row - 1][col] == 'e')
                {
                    PrintResult(result);
                    return;
                }
                else if (matrix[row - 1][col] == ' ')
                {
                    matrix[row - 1][col] = '#';
                    result += "U";
                    FindPath(matrix, row - 1, col, result);
                }
            }

            if (col + 1 < matrix[row].Length)
            {
                if (matrix[row][col + 1] == 'e')
                {
                    PrintResult(result);
                    return;
                }
                else if (matrix[row][col + 1] == ' ')
                {
                    matrix[row][col + 1] = '#';
                    result += "R";
                    FindPath(matrix, row, col + 1, result);
                }
            }

            if (row + 1 < matrix.Length)
            {
                if (matrix[row + 1][col] == 'e')
                {
                    PrintResult(result);
                    return;
                }
                else if (matrix[row + 1][col ] == ' ')
                {
                    matrix[row + 1][col] = '#';
                    result += "D";
                    FindPath(matrix, row + 1, col, result);
                }
            }

            if (col - 1 > 0)
            {
                if (matrix[row][col - 1] == 'e')
                {
                    PrintResult(result);
                    return;
                }
                else if (matrix[row ][col - 1] == ' ')
                {
                    matrix[row][col - 1] = '#';
                    result += "L";
                    FindPath(matrix, row, col - 1, result);
                }
            }
        }

        private static void PrintResult(string result)
        {
            Console.WriteLine(result);
        }
    }
}
