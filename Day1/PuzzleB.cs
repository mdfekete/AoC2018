using Helpers;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    public static class PuzzleB
    {
        public static int GetFrequency(string filePath)
        {
            int frequency = 0;
            List<int> reachedFrequencies = new List<int>();

            var lines = File.ReadAllLines(filePath.ToApplicationPath());

            int i = 0;
            while (true)
            {
                int f;
                if (int.TryParse(lines[i%lines.Length], out f))
                {
                    frequency += f;
                    if (reachedFrequencies.Contains(frequency))
                        break;

                    reachedFrequencies.Add(frequency);

                    i++;
                }
            }

            return frequency;
        }
    }
}
