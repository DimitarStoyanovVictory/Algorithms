namespace Exercises_QeenPuzle
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class EigthQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        private static int _solutionsFound;
        private static string dataPath = @"c:\temp\eigthQuees.txt";
        StreamWriter sw = new StreamWriter(dataPath);

        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRigthDiagonals = new HashSet<int>();

         static void PutQueens (int row)
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
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRigthDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPosition(int row, int col)
        {
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRigthDiagonals.Add(col + row);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQeen(int row, int col)
        {
            var positionOccupied =
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRigthDiagonals.Contains(row + col);

            return !positionOccupied;
        }

        private static void PrintSolution()
        {
            var outputResult = new StringBuilder();
            {
                for (int row = 0; row < Size; row++)
                {
                    for (int col = 0; col < Size; col++)
                    {
                        if (chessboard[row, col])
                        {
                            outputResult.Append('*');
                        }
                        else
                        {
                            outputResult.Append('-');
                        }
                    }

                    outputResult.AppendLine();
                }

                _solutionsFound++;
                outputResult.Append($"Solution number: {_solutionsFound}");
            }
        }

        static void Main()
        {
            PutQueens(0);
        }
    }
}
