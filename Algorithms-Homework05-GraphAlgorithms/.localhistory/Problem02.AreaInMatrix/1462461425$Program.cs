namespace Problem02.AreaInMatrix
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

            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    if (IsValid(row, col + 1, inputMatrix) && inputMatrix[row, col] == inputMatrix[row, col + 1])
                    {
                        visited[row, col + 1] = true;
                        AddArea(ref areas, inputMatrix[row, col + 1]);
                        col++;
                    }
                    else if (IsValid(row - 1, col, inputMatrix) && inputMatrix[row, col] == inputMatrix[row - 1, col])
                    {
                        visited[row - 1, col] = true;
                        AddArea(ref areas, inputMatrix[row + 1, col]);
                        row--;
                    }
                    else if (IsValid(row, col - 1, inputMatrix) && inputMatrix[row, col] == inputMatrix[row, col - 1])
                    {
                        visited[row, col - 1] = true;
                        AddArea(ref areas, inputMatrix[row + 1, col]);
                        col--;
                    }
                    else if (IsValid(row + 1, col, inputMatrix) && inputMatrix[row, col] == inputMatrix[row + 1, col])
                    {
                        visited[row + 1, col] = true;
                        AddArea(ref areas, inputMatrix[row + 1, col]);
                        row++;
                        col--;
                    }
                    else
                    {
                        areas.Add(inputMatrix[row, col], 1);
                    }
                }
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

        private static void AddArea(ref Dictionary<char, int> areas, char letter)
        {
            if (areas.Keys.Contains(letter))
            {
                areas[letter]++;
            }
            else
            {
                areas.Add(letter, 1);
            }
        }
    }
}
