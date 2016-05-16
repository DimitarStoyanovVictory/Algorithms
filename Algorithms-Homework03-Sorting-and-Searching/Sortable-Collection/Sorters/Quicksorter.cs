namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            this.Quicksort(collection, 0, collection.Count - 1);
        }

        private void Quicksort(List<T> collection, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            T pivot = collection[start];
            int storeIndex = start + 1;

            for (int index = start + 1; index <= end; index++)
            {
                if (collection[index].CompareTo(pivot) < 0)
                {
                    SwapElements(ref collection, storeIndex, index);
                    storeIndex++;
                }
            }

            storeIndex--;
            SwapElements(ref collection, start, storeIndex);

            Quicksort(collection, start, storeIndex);
            Quicksort(collection, storeIndex + 1, end);
        }

        private void SwapElements(ref List<T> collection, int firstElement, int secondElement)
        {
            T temp = collection[firstElement];
            collection[firstElement] = collection[secondElement];
            collection[secondElement] = temp;
        }
    }
}
