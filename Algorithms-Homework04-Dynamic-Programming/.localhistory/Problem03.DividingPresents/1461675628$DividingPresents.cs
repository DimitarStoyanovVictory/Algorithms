namespace Problem03.DividingPresents
{
    using System.Collections.Generic;
    using System.Linq;

    class DividingPresents
    {
        static void Main()
        {
            var list = new List<int> {3, 2, 3, 2, 2, 77, 89, 23, 90, 11};
            var alan = new HashSet<int>();
            var bob = new HashSet<int>();
            int currentSum = 0;

            for (int indexFirst = 0; indexFirst < list.Count - 1; indexFirst++)
            {
                currentSum = 0;
                for (int indexSeocond = indexFirst + 1; indexSeocond < list.Count; indexSeocond++)
                {
                    list.GetRange(indexSeocond, indexFirst).ForEach(x => currentSum += x);
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
