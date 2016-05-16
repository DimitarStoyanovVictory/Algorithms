namespace Problem06.ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class Area : IComparable<Area>
    {
        public SortedSet<AreaPoint> AreaPoints { get; } = new SortedSet<AreaPoint>();

        public int CompareTo(Area other)
        {
            if (other == null)
            {
                return 1;
            }

            if (AreaPoints.)
            {
                
            }
        }
    }
}
