namespace Problem03.CyclesInAGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CyclesInAGraph
    {
        static void Main()
        {
            var grapf = new List<List<char>>();
            var grapfValues = new List<char>();
            string input = Console.ReadLine();
            while (input != "")
            {
                if (!grapfValues.Contains(input[0]))
                {
                    grapfValues.Add(input[0]);
                }

                if (grapfValues.Contains(input[0]))
                {
                    grapf[grapfValues.FindIndex(x => x == input[0])].Add(input[4]);
                }
                else
                {
                    grapf.Add(new List<char> { input[4] });
                }

                input = Console.ReadLine();
            }
        }
    }
}
