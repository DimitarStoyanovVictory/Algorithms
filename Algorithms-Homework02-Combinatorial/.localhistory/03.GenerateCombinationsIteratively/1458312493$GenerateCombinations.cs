namespace PermutationsCombinationsInterativly
{
    using System;

    class Permotations
    {
        static void Main()
        {
            int n = 3;

            var root = new[] {'1', '2', '3'};

            buildStrings(root, n);
        }


        public static void buildStrings(char[] root, int length)
        {
            // allocate an int array to hold the counts:
            int[] pos = new int[length];
            // allocate a char array to hold the current combination:
            char[] combo = new char[length];
            // initialize to the first value:
            for (int i = 0; i < length; i++)
            {
                combo[i] = root[0];
            }

            while (true)
            {
                // output the current combination:
                Console.WriteLine(combo);

                // move on to the next combination:
                int place = length - 1;
                while (place >= 0)
                {
                    if (++pos[place] == root.length)
                    {
                        // overflow, reset to zero
                        pos[place] = 0;
                        combo[place] = root[0];
                        place--; // and carry across to the next value
                    }
                    else
                    {
                        // no overflow, just set the char value and we're done
                        combo[place] = root[pos[place]];
                        break;
                    }
                }
                if (place < 0)
                    break;  // overflowed the last position, no more combinations
            }
        }
    }
}
