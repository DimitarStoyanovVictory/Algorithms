namespace Problem03.DividingPresents
{
    using System.Collections.Generic;

    class DividingPresents
    {
        static void Main()
        {
            int[] array = { 3, 2, 3, 2, 2, 77, 89, 23, 90, 11 };
            var alan = new HashSet<int>();
            var bob = new HashSet<int>();
            int currentSum;

            for (int indexFirst = 0; indexFirst < array.Length; indexFirst++)
            {
                currentSum = 0;
                for (int indexSeocond = 0; indexSeocond < array.Length; indexSeocond++)
                {
                    currentSum = array[indexSeocond];
                }
            }
        }
    }
}
