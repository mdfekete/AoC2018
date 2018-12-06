using Helpers;
using System.IO;

namespace Day1
{
    public static class PuzzleA
    {
        public static int GetFrequency(string filePath)
        {
            int frequency = 0;

            foreach (string line in File.ReadAllLines(filePath.ToApplicationPath()))
            {
                int i;
                if (int.TryParse(line, out i))
                {
                    frequency += i;
                }
            }

            return frequency;
        }     
    }
}
