namespace Problem03.DividingPresents
{
    using System;
    using System.Collections.Generic;

    class DividingPresents
    {
        static void Main()
        {
            var list = new List<int> { 3, 2, 3, 2, 2, 77, 89, 23, 90, 11 };
            var alan = new HashSet<List<int>>();
            var bob = new HashSet<List<int>>();
            int currentSum = 0;

            for (int indexFirst = 0; indexFirst < list.Count - 1; indexFirst++)
            {
                currentSum = 0;
                for (int indexSeocond = indexFirst + 1; indexSeocond < list.Count; indexSeocond++)
                {
                    list.GetRange(indexFirst, indexSeocond - indexFirst).ForEach(x => currentSum += x);
                    alan.Add(currentSum);
                    bob.Add(list.GetRange(indexSeocond, list.Count - indexSeocond));
                }
            }

            int smallestDifference = 0;
            int alanSum = 0;
            int bobSum = 0;
            int difference = 0;
            foreach (var collection in alan)
            {
                collection.ForEach(x => alanSum += x);
            }
        }
    }
}
