namespace Problem02.AreaInMatrix
{
    using System;

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

            //bool[,] visited = new bool[inputMatrix.ge];
            Console.WriteLine(inputMatrix.GetLength(1));
        }
    }
}
