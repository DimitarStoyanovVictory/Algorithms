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
                        bool stop = false;
                        while (!stop)
                        {
                            stop = GenerateSequace(ref graph, ref currentElement, lastElement, ref resultCount, ref count);

                            foreach (var secondElement in graph[currentElement])
                            {
                                if (secondElement == element)
                                {
                                    continue;
                                }

                                currentElement = secondElement;
                            }
                        }
                    }
                }

                Console.WriteLine("{" + $"{distanceToFind[indexDistanceToFind][0]}, {distanceToFind[indexDistanceToFind][1]}" + @"} -> " + $"{resultCount}");
            }
        }

        private static bool GenerateSequace(ref List<List<int>> graph, ref int currentElement, int lastElement, ref int resultCount, ref int count)
        {
            if (currentElement == lastElement && count > 0 && resultCount > count && resultCount != 0)
            {
                resultCount = count;
                return true;
            }

            if (currentElement == lastElement && resultCount <= 0)
            {
                resultCount = count;
                return true;
            }

            count++;
            if (graph[currentElement].Count == 0 && resultCount == 0)
            {
                resultCount = -1;
                return true;
            }
            if (graph[currentElement].Count == 0)
            {
                return true;
            }
        }
    }
}
