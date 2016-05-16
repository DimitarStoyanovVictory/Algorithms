namespace Problem03.CyclesInAGraph
{
    using System;
    using System.Collections.Generic;

    class CyclesInAGraph
    {
        static void Main()
        {
            var grapf = new List<List<char>>();
            string input = Console.ReadLine();
            while (input != "")
            {
                grapf.Add(new List<char> { input[0], input[4] });
                grapf.Add(new List<char> { input[4], input[0]});

                input = Console.ReadLine();
            }


        }
    }
}
