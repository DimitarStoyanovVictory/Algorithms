﻿namespace Exercises_QeenPuzle
{
    using System;
    using System.Collections.Generic;

    public class EigthQueens
    {
        const int Size = 8;
        private static int _solutionsFound;
        static bool[,] chessboard = new bool[Size, Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRigthDiagonals = new HashSet<int>();

        static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQeen(row, col))
                    {
                        MarkAllAttackedPosition(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Clear();
            attackedColumns.Clear();
            attackedLeftDiagonals.Clear();
            attackedRigthDiagonals.Clear();
            if (row != 7)
            {
                
            }

            PutQueens(0);
        }

        private static void MarkAllAttackedPosition(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRigthDiagonals.Add(col + row);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQeen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRigthDiagonals.Contains(row + col);

            return !positionOccupied;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row, col])
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            _solutionsFound++;
        }

        static void Main()
        {
            PutQueens(0);
        }
    }
}
