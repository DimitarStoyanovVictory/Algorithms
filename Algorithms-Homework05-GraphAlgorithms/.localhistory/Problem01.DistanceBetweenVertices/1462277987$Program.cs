namespace Problem01.DistanceBetweenVertices
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var graph = new List<List<int>>
            {
                new List<int>(), 
                new List<int> {4},
                new List<int> {4},
                new List<int> {4, 5},
                new List<int> {6},
                new List<int> {3, 7, 8},
                new List<int>(),
                new List<int> {8},
                new List<int>()
            };

            var distanceToFind = new List<List<int>>
            {
                new List<int>(),
                new List<int> {1, 6},
                new List<int> {1, 5},
                new List<int> {5, 6},
                new List<int> {5, 8}
            };

            for (int indexDistanceToFind = 1; indexDistanceToFind < distanceToFind.Count; indexDistanceToFind++)
            { 
                int count = 1;
                int currentElement = graph[distanceToFind[indexDistanceToFind][0]][0];
                int lastElement = distanceToFind[indexDistanceToFind][1];

                while (currentElement != lastElement)
                {
                    count++;

                    try
                    {
                        currentElement = graph[currentElement][0];
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        count = -1;
                        break;
                    }
                }

                Console.WriteLine("{" + $"{distanceToFind[indexDistanceToFind][0]}, {distanceToFind[indexDistanceToFind][1]}" + @"} -> " + $"{count}");
            }
        }
    }
}
