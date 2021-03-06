﻿namespace Problem01.DistanceBetweenVertices
{
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

            int count = 0;
            for (int indexDistanceToFind = 1; indexDistanceToFind < distanceToFind.Count; indexDistanceToFind++)
            {
                var currentElement = distanceToFind[indexDistanceToFind];
                foreach (var obj in graph)
                {
                    if (distanceToFind[indexDistanceToFind] == obj)
                    {
                        count++;
                    }
                }
                
            }
        }
    }
}
