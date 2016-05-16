namespace Problem03.DividingPresents
{
    using System.Collections.Generic;

    class DividingPresents
    {
        static void Main()
        {
            var list = new List<int> {3, 2, 3, 2, 2, 77, 89, 23, 90, 11};
            int alanSum = 0;
            int bobSum = 0;
            int smallestDifference = 0;
            int difference = 0;

            for (int indexFirst = 1; indexFirst < list.Count - 1; indexFirst++)
            {
                for (int indexSecond = 0; indexSecond < list.Count - indexFirst; indexSecond++)
                {
                    list.GetRange(indexSecond, indexFirst).ForEach(x => alanSum += x);
                    list.GetRange(0, indexSecond).ForEach(x => bobSum += x);
                    list.GetRange(indexSecond + indexFirst, list.Count - indexFirst - indexSecond).ForEach(x => bobSum += x);

                    if (bobSum > alanSum)
                    {
                        difference = bobSum - alanSum;
                        if (difference < smallestDifference && difference > 0)
                        {
                            smallestDifference = difference;
                        }
                    }

                    alanSum = 0;
                    bobSum = 0;
                }
            }
        }
    }
}
