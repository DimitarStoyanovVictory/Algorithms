using System;

public class Program
{
    static void Main()
    {
        var matrix = new[]
           {
                new[] { 's', ' ', ' ', ' ' },
                new[] { ' ', '*', '*', ' ' },
                new[] { ' ', ' ', ' ', ' ' }
            };

        Console.WriteLine(matrix.GetLength());
    }
}
