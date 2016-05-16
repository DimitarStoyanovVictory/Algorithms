namespace Problem06.ConnectedAreasInMatrix
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
            Console.WriteLine("Hello, pleace create your matrix.");

            Console.Write("Enter the number of rows of the matrix. row = ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns of the matrix. col = ");
            int col = int.Parse(Console.ReadLine());
            _matrix = new char[row, col];

            Console.WriteLine("Now pleace enter all the elements of each line, notice that empty space is also an element");
            for (int indexRow = 0; indexRow < _matrix.GetLength(0); indexRow++)
            {
                Console.Write("line {0}: ", indexRow);
                string currentLine = Console.ReadLine();

                for (int indexCol = 0; indexCol < _matrix.GetLength(1); indexCol++)
                {
                    foreach (var charecter in currentLine)
                    {
                        _matrix[indexRow, indexCol] = charecter;
                    }
                }
            }

//            _matrix = new[,]
//            {
//                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
//                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
//                {' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
//                {' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' '},
//            };

            FindAreas();

            PrintAreas();
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
        }

        private static void PrintAreas()
        {
            Console.WriteLine("Total areas found: {0}", Areas.Count);
            Areas.Sort();

            for (int areaIndex = 0; areaIndex < Areas.Count; areaIndex++)
            {
                Console.WriteLine("Area #{0} at ({1}, {2}), size: {3}", areaIndex + 1, Areas[areaIndex].AreaPoints.First().RowPoint, Areas[areaIndex].AreaPoints.First().ColPoint, Areas[areaIndex].AreaPoints.Count);
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