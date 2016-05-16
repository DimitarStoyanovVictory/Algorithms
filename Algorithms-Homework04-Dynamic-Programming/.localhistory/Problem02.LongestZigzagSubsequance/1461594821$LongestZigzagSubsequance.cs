namespace Problem02.LongestZigzagSubsequance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestZigzagSubsequance
    {
        // This task gives diffrent result but it's also the same!

        static void Main()
        {
            string[] input = Console.ReadLine().Split(',');

            int[] inputNum = new int[input.Length];
            for (int indexStr = 0; indexStr < input.Length; indexStr++)
            {
                inputNum[indexStr] = Convert.ToInt32(input[indexStr]);
            }

            var zigzagSequance = new List<int> { inputNum.First() };
            bool predicateNum = inputNum[1] < inputNum[0];

            int index = 1;
            int specialNum = 0;
            int specialSequanceLength = 0;
            bool specialNumAllowed = true;
            while (index < inputNum.Length)
            {
                if (predicateNum && zigzagSequance.Last() > inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Add(inputNum[index]);
                    predicateNum = false;
                }
                else if (!predicateNum && zigzagSequance.Last() < inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    zigzagSequance.Add(inputNum[index]);
                    predicateNum = true;
                }
                else if (predicateNum && zigzagSequance.Last() < inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    if (specialNumAllowed)
                    {
                        CheckForSpecialCase(ref specialNum, ref specialSequanceLength, ref specialNumAllowed,
                            zigzagSequance.Last(), zigzagSequance.Count);
                    }

                    AddItem(ref zigzagSequance, inputNum[index]);
                }
                else if (!predicateNum && zigzagSequance.Last() > inputNum[index] && !zigzagSequance.Contains(inputNum[index]))
                {
                    if (specialNumAllowed)
                    {
                        CheckForSpecialCase(ref specialNum, ref specialSequanceLength, ref specialNumAllowed,
                            zigzagSequance.Last(), zigzagSequance.Count);
                    }

                    AddItem(ref zigzagSequance, inputNum[index]);
                }

                if (specialSequanceLength == zigzagSequance.Count)
                {
                    if (index == input.Length - 1)
                    {
                        AddItem(ref zigzagSequance, specialNum);
                        specialNumAllowed = true;
                    }
                    else if (predicateNum && specialNum > inputNum[index + 1])
                    {
                        AddItem(ref zigzagSequance, specialNum);
                        specialNumAllowed = true;
                    }
                    else if (!predicateNum && specialNum < inputNum[index + 1])
                    {
                        AddItem(ref zigzagSequance, inputNum[index]);
                        specialNumAllowed = true;
                    }
                }

                index++;
            }

            Console.WriteLine(string.Join(" ", zigzagSequance));
        }

        private static void AddItem(ref List<int> zigzagSequance, int number)
        {
            zigzagSequance.Remove(zigzagSequance.Last());
            zigzagSequance.Add(number);
        }

        private static void CheckForSpecialCase(ref int specialNum, ref int specialSequanceLength, ref bool specialNumAllowed, int zigzagNum, int zigzagLength)
        {
            specialNum = zigzagNum;
            specialSequanceLength = zigzagLength;
            specialNumAllowed = false;
        }
    }
}
