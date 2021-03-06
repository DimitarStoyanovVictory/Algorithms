﻿namespace Problem02.AreaInMatrix
{
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[,] inputMatrix =  
            {
                { 'a', 's', 's', 's', 'a', 'a', 'd', 'a', 's' },
                { 'a', 'd', 's', 'd', 'a', 's', 'd', 'a', 'd' },
                { 's', 'd', 's', 'd', 'a', 'd', 's', 'a', 's' },
                { 's', 'd', 'a', 's', 'd', 's', 'd', 's', 'a' },
                { 's', 's', 's', 's', 'a', 's', 'd', 'd', 'd' }
            };

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
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol - 1);
                            visited[tempRow, tempCol - 1] = true;
                            visited[tempRow, tempCol] = true;
                            tempCol--;
                        }
                        else if (SingleElement(inputMatrix, tempRow, tempCol))
                        {
                            AddArea(ref areas, visited, inputMatrix, tempRow, tempCol - 1);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
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
            if (IsValid(tempRow + 1, tempCol, inputMatrix) && inputMatrix[tempRow + 1, tempCol] == inputMatrix[tempRow, tempCol])
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
