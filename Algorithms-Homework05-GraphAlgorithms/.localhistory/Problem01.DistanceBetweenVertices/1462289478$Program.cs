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
                new List<int> {12, 21, 7},
                new List<int>(),
                new List<int>(),
                new List<int> {12, 1},
                new List<int>(),
                new List<int>(),
                new List<int> {21},
                new List<int>(),
                new List<int>(),
                new List<int>(),
                new List<int> {4},
                new List<int> {4, 19},
                new List<int>(),
                new List<int> {14},
                new List<int>(),
                new List<int>(),
                new List<int>(), 
                new List<int>(),
                new List<int> {1, 21},
                new List<int>(), 
                new List<int> {14, 31},
                new List<int>(),
                new List<int>(),
                new List<int>(), 
                new List<int>(), 
                new List<int>(), 
                new List<int>(),
                new List<int>(), 
                new List<int>(),
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
                int resultCount = 0;
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
                        int count = 1;
                        currentElement = element;
                        while (true)
                        {
                            if (currentElement == lastElement && count > 0 && resultCount > count && resultCount != 0)
                            {
                                resultCount = count;
                                break;
                            }

                            if (currentElement == lastElement && resultCount <= 0)
                            {
                                resultCount = count;
                                break;
                            }

                            count++;
                            if (graph[currentElement].Count == 0 && resultCount == 0)
                            {
                                resultCount = -1;
                                break;
                            }
                            if (graph[currentElement].Count == 0)
                            {
                                break;
                            }

                            currentElement = graph[currentElement][0];
                        }
                    }
                }

                Console.WriteLine("{" + $"{distanceToFind[indexDistanceToFind][0]}, {distanceToFind[indexDistanceToFind][1]}" + @"} -> " + $"{resultCount}");
            }
        }
    }
}
