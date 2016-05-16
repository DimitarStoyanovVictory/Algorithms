namespace GenerateSubsetsOfStringArray
{
    using System;
    using System.Linq;

    class GenerateSubsetsOfStringArray
    {
        static void Main()
        {
            Console.Write("Pleace enter the words separated by space in the loop: ");
            var strings = Console.ReadLine().Split(' ');
            Console.Write("Hello pleace enter the number of elements in the loop. k = ");
            int k = int.Parse(Console.ReadLine());
            var currentLine = new int[k];
            NestedLoop(k - 1, strings);
        }

        private static void NestedLoop(int index, string[] strings, int num = 1)
        {
            if (index < 0)
            {
                PrintCurrentLine(strings);
                return;
            }

            for (int currentNum = num; currentNum <= strings.Length; currentNum++)
            {
                strings[index] = currentNum;
                num++;
                NestedLoop(index - 1, strings, strings, num);
            }
        }

        private static void PrintCurrentLine(string[] currentLine)
        {
            Console.WriteLine(string.Join(" ", strings.Reverse()));
        }
    }
}
