﻿namespace Problem06.ConnectedAreasInMatrix
{
    using System.Collections.Generic;

    public class ConnectedAreasInMatrix
    {
        private static int _areasFound;

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
            _matrix = new[,]
            {
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ' },
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ' },
                {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ' },
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ' },
                {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ' }
            };

            FindAreas();
        }

        private static void FindAreas(int row = 0, int col = 0, char direction = 'D')
        {
            if (!IsInRanege(row, col) && row != 0 && col != 0)
            {
                return;
            }

            if (_matrix[row, col] == '*')
            {
                FindAreas();
            }


        }

        private static bool IsInRanege(int row, int col)
        {
            return row > 0 && row <= _matrix.GetLength(0) &&
                   col > 0 && col <= _matrix.GetLength(1);
        }
    }
}
