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
            var currentLine = new string[k];
            NestedLoop(k - 1, strings.Length, currentLine);
        }

        private static void NestedLoop(int index, string[] strings, string[] currentLine, int num = 1)
        {
            if (index < 0)
            {
                PrintCurrentLine(currentLine);
                return;
            }

            for (int currentNum = num; currentNum <= strings.Length; currentNum++)
            {
                currentLine[index] = strings[currentNum];
                num++;
                NestedLoop(index - 1, currentLine, num);
            }
        }

        private static void PrintCurrentLine(string[] strings)
        {
            Console.WriteLine(string.Join(" ", strings.Reverse()));
        }
    }
}
