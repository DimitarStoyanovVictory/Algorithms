﻿namespace Problem06.ConnectedAreasInMatrix
{
    using System.Collections.Generic;
    using System.Drawing;

    public class ConnectedAreasInMatrix
    {
        private static int _areasFound;

        private static char[,] _matrix;

        private static List<Area> Areas { get; } = new List<Area>();

        public static int CurrentAreaIndex { get; private set; }

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

            Areas.Add(new Area());

            FindAreas();
        }

        private static void FindAreas(int row = 0, int cow = 0, bool startPosition)
        {
            for (int cowIndex = cow; cowIndex < _matrix.GetLength(1); cowIndex++)
            {
                if (_matrix[row, cow] == ' ')
                {
                    FindAreas(row, cow, true);
                }
            }
        }
    }
}

//private static void FindAreas(int row = 0, int col = 0, char direction = 'S')
//{
//    if (!IsInRanege(row, col) || _matrix[row, col] == '$')
//    {
//        return;
//    }

//    if (_matrix[row, col] == ' ')
//    {
//        _matrix[row, col] = '#';
//        Areas[CurrentAreaIndex].AreaPoints.Add(new AreaPoint(row, col));

//        FindAreas(row, col + 1, 'R');
//        FindAreas(row + 1, col, 'D');
//        FindAreas(row, col - 1, 'L');
//        FindAreas(row - 1, col, 'U');
//    }

//    if (_matrix[row, col] == '*')
//    {
//        _matrix[row, col] = '$';

//        FindAreas(row + 1, col, 'D');
//        FindAreas(row, col - 1, 'L');
//        FindAreas(row - 1, col, 'U');
//        FindAreas(row, col + 1, 'R');

//        CurrentAreaIndex++;
//        Areas.Add(new Area());
//    }
//}

//private static bool IsInRanege(int row, int col)
//{
//    return row >= 0 && row < _matrix.GetLength(0) &&
//           col >= 0 && col < _matrix.GetLength(1);
//}