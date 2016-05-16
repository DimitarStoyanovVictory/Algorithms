namespace Sortable_Collection.Sorters
{
    using System.Collections.Generic;
    using Contracts;

    public class BucketSorter : ISorter<int>
    {
        public int Max { get; set; }

        public void Sort(List<int> collection)
        {
            var buckets = new List<int>[collection.Count];

            foreach (var element in collection)
            {
                int bucketIndex = (int) (element/this.Max*collection.Count);

                if (buckets[bucketIndex] == null)
                {
                    buckets[bucketIndex] = new List<int>();
                }

                buckets[bucketIndex].Add(element);
            }

            var sorter = new Quicksorter<int>();

            for (int buckectIndex = 0; buckectIndex < buckets.Length; buckectIndex++)
            {
                if (buckets[buckectIndex] == null)
                {
                    continue;
                }

                sorter.Sort(buckets[buckectIndex]);
            }

            int index = 0;
            foreach (var bucket in buckets)
            {
                if (bucket == null)
                {
                    continue;
                }

                foreach (var item in bucket)
                {
                    collection[index] = item;
                    index++;
                }
            }
        }
    }
}
