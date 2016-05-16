namespace Problem01.DistanceBetweenVertices
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

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
                int resultCount = 1;
                if (graph[distanceToFind[indexDistanceToFind][0]].Count == 0)
                {
                    resultCount = -1;
                }
                else
                {
                    int currentElement = 0;
                    int lastElement = distanceToFind[indexDistanceToFind][1];

                    foreach (var element in graph[distanceToFind[indexDistanceToFind][0]])
                    {
                        currentElement = element;
                        while (currentElement != lastElement)
                        {
                            count++;
                            if (graph[currentElement].Count == 0)
                            {
                                resultCount = -1;
                                break;
                            }

                            currentElement = graph[currentElement][0];
                        }

                        if (count > 0 && count > resultCount)
                        {
                            resultCount = count;
                        }
                    }
                }

                Console.WriteLine("{" + $"{distanceToFind[indexDistanceToFind][0]}, {distanceToFind[indexDistanceToFind][1]}" + @"} -> " + $"{resultCount}");
            }
        }
    }
}
