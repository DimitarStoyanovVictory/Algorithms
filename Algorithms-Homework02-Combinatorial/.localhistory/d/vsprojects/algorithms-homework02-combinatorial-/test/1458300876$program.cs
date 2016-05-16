namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int fac(int n)
        {
            int address = 10; // Entry point for each each "call"
            int tempFac = n;
            var s = new Stack<int>();
            s.Push(30); // Initial return address
            s.Push(tempFac);
            while (s.Count != 0)
            {
                switch (address)
                {
                    case 10:
                        {
                            n = s.Pop();
                            if (n < 2)
                            { // The base case
                                address = s.Pop();
                                s.Push(1);
                            }
                            else
                            {
                                s.Push(n);
                                s.Push(20); // Where should I return?
                                s.Push(n - 1);
                                address = 10; // Make another "call"
                            }
                            break;
                        }
                    case 20:
                        { // Compute and return
                            tempFac = s.Pop();
                            n = s.Pop();
                            address = s.Pop();
                            tempFac = n * tempFac;
                            s.Push(tempFac);
                            break;
                        }
                    case 30:
                        // The final return value
                        tempFac = s.Pop();
                }
            }
            return tempFac;
        }
        static void Main()
        {
            Console.WriteLine(1 % 2);
        }
    }
}
