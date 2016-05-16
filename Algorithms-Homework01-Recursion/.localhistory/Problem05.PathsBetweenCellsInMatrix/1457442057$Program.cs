namespace Problem05.PathsBetweenCellsInMatrix
{
    using System;

    public class PathsBetweenCellsInMatrix
    {
        private static string pathFound;
        
        static void Main()
        {
            Console.WriteLine("Hello, pleace create your matrix.");

            Console.Write("Enter the number of rows of the matrix. row = ");
            int rowNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns of the matrix. col = ");
            int col = int.Parse(Console.ReadLine());

            var matrix = new char[rowNum][];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                    
            }

            foreach (var row in matrix)
            {
                foreach (var cell in row)
                {
                    cell.
                }
            }
            
            FindPath(matrix);
        }

        private static void FindPath(char[][] matrix)
        {
            if ()
            {
                
            }
        }
    }
}
