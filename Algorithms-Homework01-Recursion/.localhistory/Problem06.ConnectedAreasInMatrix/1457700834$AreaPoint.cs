﻿namespace Problem06.ConnectedAreasInMatrix
{
    public class AreaPoint
    {
        private int _rowPoint;
        private int _colPoint;

        public AreaPoint(int rowPoint, int colPoint)
        {
            _rowPoint = rowPoint;
            _colPoint = colPoint;
        }

        public int RowPoint
        {
            get { return _rowPoint; }
            set;
        }
    }
}
