using Helpers;
using System.IO;
using System.Text.RegularExpressions;

namespace Day3
{
    public static class PuzzleA
    {
        public static readonly string pattern = @"#(?<id>\d{1,4})\s@\s(?<x>\d{1,3}),(?<y>\d{1,3}):\s(?<right>\d{1,3})x(?<down>\d{1,3})";

        public static int GetOverlapArea(string filePath)
        {
            int[,] fabricArray = new int[1000,1000];

            foreach (string line in File.ReadAllLines(filePath.ToApplicationPath()))
            {
                var match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    int x = int.Parse(match.Groups["x"].Value);
                    int y = int.Parse(match.Groups["y"].Value);
                    int right = int.Parse(match.Groups["right"].Value);
                    int down = int.Parse(match.Groups["down"].Value);

                    for(int i = 0; i < right; i++)
                    {
                        for(int j=0;j<down;j++)
                        {
                            fabricArray[x + i, y + j] = fabricArray[x + i, y + j] + 1;
                        }
                    }
                }
            }

            int overlap = 0;
            foreach(var val in fabricArray)
            {
                if (val >= 2)
                    overlap++;
            }

            return overlap;
        }
    }
}
