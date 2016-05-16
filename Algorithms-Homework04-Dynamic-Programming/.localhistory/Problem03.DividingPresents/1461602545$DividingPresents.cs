namespace Problem03.DividingPresents
{
    using System.Collections.Generic;

    class DividingPresents
    {
        static void Main()
        {
            var list = new List<int> { 3, 2, 3, 2, 2, 77, 89, 23, 90, 11 };
            var alan = new HashSet<List<int>>();
            var bob = new HashSet<List<int>>();

            for (int indexFirst = 0; indexFirst < list.Count; indexFirst++)
            {
                for (int indexSeocond = 1; indexSeocond < list.Count; indexSeocond++)
                {
                    alan.Add(list.GetRange(indexFirst, indexSeocond));
                    bob.Add(list.GetRange(indexSeocond, list.Count - indexSeocond));
                }
            }
        }
    }
}
