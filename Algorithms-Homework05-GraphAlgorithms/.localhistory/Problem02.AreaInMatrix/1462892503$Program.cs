namespace Problem02.AreaInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Number of rows: ");
            int numberOfRows = int.Parse(Console.ReadLine());
            string matrixInputLine;
            char[,] inputMatrix = new char[0, 0];
            for (int indexRow = 0; indexRow < numberOfRows; indexRow++)
            {
                matrixInputLine = Console.ReadLine();
                if (indexRow == 0)
                {
                    inputMatrix = new char[numberOfRows, matrixInputLine.Length];
                }

                for (int indexCol = 0; indexCol < matrixInputLine.Length; indexCol++)
                {
                    inputMatrix[indexRow, indexCol] = matrixInputLine[indexCol];
                }
            }

            bool[,] visited = new bool[inputMatrix.GetLength(0), inputMatrix.GetLength(1)];
            var areas = new Dictionary<char, int>();
            int tempRow = 0;
            int tempCol = 0;

            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    tempRow = row;
                    tempCol = col;

                    while (true)
                    {
                        if (IsValid(tempRow - 1, tempCol, inputMatrix) && !visited[tempRow - 1, tempCol] && inputMatrix[tempRow, tempCol] == inputMatrix[tempRow - 1, tempCol])
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol);
                            visited[tempRow - 1, tempCol] = true;
                            visited[tempRow, tempCol] = true;
                            tempRow--;
                        }
                        else if (IsValid(tempRow + 1, tempCol, inputMatrix) && !visited[tempRow + 1, tempCol] && inputMatrix[tempRow, tempCol] == inputMatrix[tempRow + 1, tempCol])
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol);
                            visited[tempRow + 1, tempCol] = true;
                            visited[tempRow, tempCol] = true;
                            tempRow++;
                        }
                        else if (IsValid(tempRow, tempCol + 1, inputMatrix) && !visited[tempRow, tempCol + 1] && inputMatrix[tempRow, tempCol] == inputMatrix[tempRow, tempCol + 1])
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol);
                            visited[tempRow, tempCol + 1] = true;
                            visited[tempRow, tempCol] = true;
                            tempCol++;
                        }
                        else if (IsValid(tempRow, tempCol - 1, inputMatrix) && !visited[tempRow, tempCol - 1] && inputMatrix[tempRow, tempCol] == inputMatrix[tempRow, tempCol - 1])
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol);
                            visited[tempRow, tempCol - 1] = true;
                            visited[tempRow, tempCol] = true;
                            tempCol--;
                        }
                        else if (SingleElement(inputMatrix, tempRow, tempCol))
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            PrintResult(areas);
        }

        private static void PrintResult(Dictionary<char, int> areas)
        {
            Console.WriteLine($"Areas: {areas.Values.Count}");

            foreach (var area in areas.Keys.OrderBy(x => x).ToDictionary())
            {
                Console.WriteLine($"Letter '{area.Key}' -> {area.Value}");
            }
        }

        private static bool SingleElement(char[,] inputMatrix, int tempRow, int tempCol)
        {
            if (IsValid(tempRow - 1, tempCol, inputMatrix) && inputMatrix[tempRow - 1, tempCol] == inputMatrix[tempRow, tempCol])
            {
                return false;
            }
            if (IsValid(tempRow + 1, tempCol, inputMatrix) && inputMatrix[tempRow + 1, tempCol] == inputMatrix[tempRow, tempCol])
            {
                return false;
            }
            if (IsValid(tempRow, tempCol + 1, inputMatrix) && inputMatrix[tempRow, tempCol + 1] == inputMatrix[tempRow, tempCol])
            {
                return false;
            }
            if (IsValid(tempRow, tempCol - 1, inputMatrix) && inputMatrix[tempRow, tempCol - 1] == inputMatrix[tempRow, tempCol])
            {
                return false;
            }

            return true;
        }

        private static void AddArea(ref Dictionary<char, int> areas, bool[,] visited, char[,] inputMatrix, int tempRow, int tempCol)
        {
            if (!areas.Keys.Contains(inputMatrix[tempRow, tempCol]))
            {
                areas[inputMatrix[tempRow, tempCol]] = 1;
            }
            else if (!visited[tempRow, tempCol])
            {
                areas[inputMatrix[tempRow, tempCol]]++;
            }
        }

        private static bool IsValid(int row, int col, char[,] inputMatrix)
        {
            if (row >= 0 && row < inputMatrix.GetLength(0) && col >= 0 && col < inputMatrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
