﻿namespace Problem01.DistanceBetweenVertices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            //var graph = new List<List<int>>
            //{
            //    new List<int>(),
            //    new List<int> {4},
            //    new List<int> {4},
            //    new List<int> {4, 5},
            //    new List<int> {6},
            //    new List<int> {3, 7, 8},
            //    new List<int>(),
            //    new List<int> {8},
            //    new List<int>()
            //};

            //var distanceToFind = new List<List<int>>
            //{
            //    new List<int>(),
            //    new List<int> {1, 6},
            //    new List<int> {1, 5},
            //    new List<int> {5, 6},
            //    new List<int> {5, 8}
            //};

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
                new List<int>(),
                new List<int>()
            };

            var distanceToFind = new List<List<int>>
            {
                new List<int>(),
                new List<int> {11, 7},
                new List<int> {11, 21},
                new List<int> {21, 4},
                new List<int> {19, 14},
                new List<int> {1, 4},
                new List<int> {1, 11},
                new List<int> {31, 21},
                new List<int> {11, 14}
            };

            bool[] visited = new bool[graph.Count];

            for (int indexDistanceToFind = 1; indexDistanceToFind < distanceToFind.Count; indexDistanceToFind++)
            { 
                int resultCount = 0;
                var results = new List<int>();
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
                        visited = new bool[graph.Count];
                        MakeSequance(graph, lastElement, visited, currentElement, count, ref results, ref resultCount);
                    }
                }

                if (results.Exists(x => x >= 0))
                {
                    resultCount = results.Where(x => x > 0).Min();
                }

                Console.WriteLine("{" + $"{distanceToFind[indexDistanceToFind][0]}, {distanceToFind[indexDistanceToFind][1]}" + @"} -> " + $"{resultCount}");
            }
        }

        private static void MakeSequance(List<List<int>> graph, int lastElement, bool[] visited, int currentElement, int count, ref List<int> results, ref int resultCount)
        {
            while (true)
            {
                if (currentElement == lastElement && count > 0 && resultCount > count && resultCount != 0)
                {
                    resultCount = count;
                    results.Add(resultCount);
                    return;
                }
                if (currentElement == lastElement && resultCount <= 0)
                {
                    resultCount = count;
                    results.Add(resultCount);
                    return;
                }
                if (count <= resultCount)
                {
                    return;
                }

                count++;

                if (graph[currentElement].Count == 0 && resultCount == 0)
                {
                    resultCount = -1;
                    results.Add(resultCount);
                    return;
                }
                if (graph[currentElement].Count == 0 || graph[currentElement][0] == currentElement)
                {
                    return;
                }

                if (graph[currentElement].Count > 1)
                {
                    foreach (var secondElement in graph[currentElement])
                    {
                        if (!visited[secondElement])
                        {
                            currentElement = secondElement;
                            visited[currentElement] = true;
                            MakeSequance(graph, lastElement, visited, currentElement, count, ref results, ref resultCount);
                            count--;
                        }
                    }
                }
            }
        }
    }
}
