namespace GenerateSubsetsOfStringArray
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Pleace enter the words separated by space in the loop. n = ");
            var strings = Console.ReadLine().Split(' ');
            Console.Write("Hello pleace enter the number of elements in the loop. k = ");
            int k = int.Parse(Console.ReadLine());
            var currentLine = new int[k];
            NestedLoop(k - 1, strings, currentLine);
        }

        private static void NestedLoop(int index, string[] strings, int[] currentLine, int num = 1)
        {
            if (index < 0)
            {
                PrintCurrentLine(currentLine);
                return;
            }

            for (int currentNum = num; currentNum <= strings.Length; currentNum++)
            {
                currentLine[index] = currentNum;
                num++;
                NestedLoop(index - 1, strings, currentLine, num);
            }
        }

        private static void PrintCurrentLine(int[] currentLine)
        {
            Console.WriteLine(string.Join(" ", currentLine.Reverse()));
        }
    }
}
