namespace Problem06.ConnectedAreasInMatrix
{
    using System.Collections.Generic;

    public class Area
    {
        private int _lastColPointIndex;

        public SortedSet<AreaPoint> AreaPoints { get; } = new SortedSet<AreaPoint>();

        public int LastColPointIndex
        {
            get
            {
                return _lastColPointIndex;
            }

            set { _lastColPointIndex = value; }
        }

    }
}
