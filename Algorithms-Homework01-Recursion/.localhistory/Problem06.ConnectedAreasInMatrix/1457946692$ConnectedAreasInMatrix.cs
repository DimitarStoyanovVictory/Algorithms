﻿namespace Problem06.ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConnectedAreasInMatrix
    {
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

            FindAreas();
        }

        private static void FindAreas()
        {
            for (int indexRow = 0; indexRow < _matrix.GetLength(0); indexRow++)
            {
                for (int indexCol = 0; indexCol < _matrix.GetLength(1); indexCol++)
                {
                    if (_matrix[indexRow, indexCol] == ' ')
                    {
                        Areas.Add(new Area());
                        MarkCell(indexRow, indexCol);
                        CurrentAreaIndex++;
                    }
                }
            }

            PrintAreas();
        }

        private static void PrintAreas()
        {
            Console.WriteLine("Total areas found: {0}", Areas.Count);

            for (int areaIndex = 0; areaIndex < Areas.Count; areaIndex++)
            {
                
                Console.WriteLine("Area #{0} at ({1}, {2}), size: {3}", areaIndex + 1, Areas[areaIndex].AreaPoints.First().RowPoint, Areas[areaIndex].AreaPoints.First().ColPoint());
            }
        }

        private static void MarkCell(int row, int col)
        {
            if (!IsInRanege(row, col) || _matrix[row, col] == '*' || _matrix[row, col] == '#')
            {
                return;
            }

            if (_matrix[row, col] == ' ')
            {
                _matrix[row, col] = '#';
                Areas[CurrentAreaIndex].AreaPoints.Add(new AreaPoint(row, col));

                MarkCell(row, col + 1); // R
                MarkCell(row + 1, col); // D
                MarkCell(row, col - 1); // U
                MarkCell(row - 1, col); // L
            }
        }

        private static bool IsInRanege(int row, int col)
        {
            return row >= 0 && row < _matrix.GetLength(0) &&
                   col >= 0 && col < _matrix.GetLength(1);
        }
    }
}

//private static void FindAreas(int row = 0, int col = 0, bool startPosition = false)
//{
//    for (int cowIndex = col; cowIndex < _matrix.GetLength(1); cowIndex++)
//    {
//        if (_matrix[row, col] == ' ' && startPosition)
//        {
//            Areas[CurrentAreaIndex].AreaPoints.Add(new AreaPoint(row, col));
//            FindAreas(row, col + 1, true);
//        }

//        if (_matrix[row, col] == '*' && startPosition)
//        {
//            Areas[CurrentAreaIndex].LastColPointIndex = col;
//            FindAreas(row + 1);
//        }

//        if (row >= 0 &&  )
//        {

//        }

//        if (_matrix[row, col] == ' ' && !startPosition)
//        {
//            Areas[CurrentAreaIndex].AreaPoints.Add(new AreaPoint(row, col));
//            FindAreas(row, col, true);
//        }
//    }
//}