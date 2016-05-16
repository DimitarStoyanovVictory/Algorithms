namespace Sortable_Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public class SortableCollection<T> where T : IComparable<T>
    {
        public SortableCollection()
        {
            this.Items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.Items = new List<T>(items);
        }

        public SortableCollection(params T[] items)
            : this(items.AsEnumerable())
        {
        }

        public List<T> Items { get; } = new List<T>();

        public int Count => this.Items.Count;

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.Items);
        }

        public int BinarySearch(T item)
        {
            return this.BinarySearchProcedure(item, 0, Count - 1);
        }

        private int BinarySearchProcedure(T item, int startIndex, int endIndex)
        {
            //while (startIndex <= endIndex)
            //{
            //    int midpoint = startIndex + ((endIndex - startIndex) / 2);

            //    if (Items[midpoint].CompareTo(item) > 0)
            //    {
            //        endIndex = midpoint - 1;
            //    }
            //    else if (Items[midpoint].CompareTo(item) < 0)
            //    {
            //        startIndex = midpoint + 1;
            //    }
            //    else if (Items[midpoint].CompareTo(item) == 0)
            //    {
            //        return midpoint;
            //    }
            //}

            //return -1;

            if (endIndex < startIndex)
            {
                return -1;
            }

            int midpoint = startIndex + (endIndex - startIndex) / 2;

            if (this.Items[midpoint].CompareTo(item) > 0)
            {
                return BinarySearchProcedure(item, startIndex, midpoint - 1);
            }
            if (this.Items[midpoint].CompareTo(item) < 0)
            {
                return BinarySearchProcedure(item, midpoint + 1, endIndex);
            }

            return midpoint;
        }

        public int InterpolationSearch(T item)
        {
            throw new NotImplementedException();
        }

        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            return this.Items.ToArray();
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", this.Items)}]";
        }        
    }
}