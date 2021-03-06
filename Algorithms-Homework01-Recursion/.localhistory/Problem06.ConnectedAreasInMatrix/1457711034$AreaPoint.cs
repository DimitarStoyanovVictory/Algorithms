﻿namespace Problem06.ConnectedAreasInMatrix
{
    using System;
    public class AreaPoint : IComparable<AreaPoint>, IComparable
    {
        private int _rowPoint;
        private int _colPoint;
        private int _lastColPointIndex;

        public AreaPoint(int rowPoint, int colPoint)
        {
            _rowPoint = rowPoint;
            _colPoint = colPoint;
        }

        public int RowPoint
        {
            get { return _rowPoint; }

            set { _rowPoint = value; }
        }

        public int ColPoint
        {
            get { return _colPoint; }

            set { _colPoint = value; }
        }

        public int LastColPointIndex
        {
            get
            {
                return _lastColPointIndex;
            }

            set { _lastColPointIndex = value; }
        }

        public int CompareTo(AreaPoint other)
        {
            if (other == null)
            {
                return 1;
            }

            if (RowPoint > other.RowPoint)
            {
                return 1;
            }

            if (RowPoint == other.RowPoint && ColPoint > other.ColPoint)
            {
                return 1;
            }

            if (RowPoint < other.RowPoint)
            {
                return - 1;
            }

            if (RowPoint == other.RowPoint && ColPoint < other.ColPoint)
            {
                return - 1;
            }

            return 0;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is AreaPoint))
            {
                throw new ArgumentException("arugment must be AreaPoint");
            }

            return CompareTo(obj);
        }
    }
}
