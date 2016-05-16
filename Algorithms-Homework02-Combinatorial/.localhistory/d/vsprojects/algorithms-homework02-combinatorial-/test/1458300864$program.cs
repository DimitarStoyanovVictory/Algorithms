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
                            n = s.pop();
                            if (n < 2)
                            { // The base case
                                address = s.pop();
                                s.push(1);
                            }
                            else
                            {
                                s.push(n);
                                s.push(20); // Where should I return?
                                s.push(n - 1);
                                address = 10; // Make another "call"
                            }
                            break;
                        }
                    case 20:
                        { // Compute and return
                            tempFac = s.pop();
                            n = s.pop();
                            address = s.pop();
                            tempFac = n * tempFac;
                            s.push(tempFac);
                            break;
                        }
                    case 30:
                        // The final return value
                        tempFac = s.pop();
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
