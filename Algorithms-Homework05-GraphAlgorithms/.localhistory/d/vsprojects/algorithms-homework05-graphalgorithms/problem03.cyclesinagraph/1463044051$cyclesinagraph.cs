namespace Problem03.CyclesInAGraph
{
    using System;
    using System.Collections.Generic;

    class CyclesInAGraph
    {
        static void Main()
        {
            var inputList = new List<string>();
            string input = Console.ReadLine();
            while (input != "")
            {
                inputList.Add(input.Split());

                input = Console.ReadLine();
            }
        }
    }
}
