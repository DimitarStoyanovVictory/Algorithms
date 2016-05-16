using System;
using System.Collections;
using System.Linq;

public class TowerOfHanoi
{
    public static void Main()
    {
        Console.Write("Pleace enter the number of dist of tower of Hanoi; n = ");
        int numberOfDisks = int.Parse(Console.ReadLine());
        var source = new Stack(Enumerable.Range(1, numberOfDisks));

    }
}
