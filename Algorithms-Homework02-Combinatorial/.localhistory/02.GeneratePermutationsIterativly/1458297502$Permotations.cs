using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = 5;

        var list = Enumerable.Range(1, n).ToList();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < list.GetRange(i, n-1).Count; j++)
            {
                
            }       
        }
    }
}