namespace Problem03.DividingPresents
{
    using System.Collections.Generic;

    class DividingPresents
    {
        static void Main()
        {
            var list = new List<int> {3, 2, 3, 2, 2, 77, 89, 23, 90, 11};
            var alan = new HashSet<int>();
            var bob = new HashSet<int>();
            int currentSum = 0;

            for (int indexFirst = 1; indexFirst < list.Count - 1; indexFirst++)
            {
                currentSum = 0;
                for (int indexSecond = 0; indexSecond < list.Count; indexSecond++)
                {
                    list.GetRange(indexSecond, indexFirst).ForEach(x => currentSum += x);
                    alan.Add(currentSum);
                    currentSum = 0;
                    list.GetRange(0, indexSecond).ForEach(x => currentSum += x);
                    list.GetRange(indexSecond, list.Count - indexSecond).ForEach(x => currentSum += x);
                    bob.Add(currentSum);
                    currentSum = 0;
                }
            }

            int smallestDifference = 0;
            int difference = 0;

            foreach (var sumAlan in alan)
            {
                foreach (var sumBob in bob)
                {
                    difference = sumBob - sumAlan;

                    if (difference < smallestDifference && difference >= 0)
                    {
                        smallestDifference = difference;
                    }

                    difference = 0;
                }
            }
        }
    }
}
