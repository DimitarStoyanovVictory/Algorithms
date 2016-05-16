using System;
using System.IO;
using System.Linq;

public class Program
{
    static void Main()
    {
        CreateSampleFile();

        var JulyWeekends = from line in File.ReadLines(dataPath)
                           where (line.StartsWith("Saturday") ||
                           line.StartsWith("Sunday")) &
                           line.Contains("July")
                           select line;

        File.WriteAllLines(@"C:\temp\selectedDays.txt", JulyWeekends);

        var MarchMondays = from line in File.ReadLines(dataPath)
                           where line.StartsWith("Monday") &&
                           line.Contains("March")
                           select line;

        File.AppendAllLines(@"C:\temp\selectedDays.txt", MarchMondays);
    }
}
