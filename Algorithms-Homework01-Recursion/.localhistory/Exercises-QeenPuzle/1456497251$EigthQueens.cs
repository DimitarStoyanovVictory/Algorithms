namespace Exercises_QeenPuzle
{
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public class EigthQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumss = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRigthDiagonals = new HashSet<int>();

        static void Main()
        {

        }
    }
}
