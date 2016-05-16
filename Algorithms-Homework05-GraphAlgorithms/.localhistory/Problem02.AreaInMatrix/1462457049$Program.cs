namespace Problem02.AreaInMatrix
{
    using System;
    using System.Collections.Generic;

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
            var areas = new List<>();

            for (int row = 0; row < inputMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < inputMatrix.GetLength(1); col++)
                {
                    if (inputMatrix[row, col] == inputMatrix[row, col + 1])
                    {
                        visited[row, col + 1] = true;
                    }
                }
            }
        }
    }
}
