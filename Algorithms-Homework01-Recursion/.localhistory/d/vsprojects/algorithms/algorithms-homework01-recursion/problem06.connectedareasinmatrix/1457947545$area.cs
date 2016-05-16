namespace Problem06.ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class Area : IComparable<AreaPoint>
    {
        public SortedSet<AreaPoint> AreaPoints { get; } = new SortedSet<AreaPoint>();

        public int CompareTo(AreaPoint other)
        {
            throw new NotImplementedException();
        }
    }
}
