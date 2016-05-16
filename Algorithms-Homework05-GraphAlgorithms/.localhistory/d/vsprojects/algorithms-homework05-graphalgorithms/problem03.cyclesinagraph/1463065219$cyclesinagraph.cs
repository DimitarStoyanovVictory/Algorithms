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
                grapf.Add(input[0]);
                if (grapf.Count > 0)
                {
                    if (grapf.Last().Contains(input[0]))
                    {
                        grapf.Last().Add(input[4]);
                        grapf.Add(new List<char>(input[4]));
                    }
                    else
                    {
                        grapf[grapf.FindIndex(x => x == grapf.Last())].Add(input[4]);
                        grapf.Add(new List<char> { input[4] });
                    }
                }
                else
                {
                    grapf.Add(new List<char> { input[0], input[4] });
                    grapf.Add(new List<char> { input[4], input[0] });
                }

                input = Console.ReadLine();
            }
        }
    }
}
