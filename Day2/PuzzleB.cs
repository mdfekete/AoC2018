using Helpers;
using System.IO;

namespace Day2
{
    public static class PuzzleB
    {
        public static string GetCommonLetters(string filePath)
        {
            foreach (string line1 in File.ReadAllLines(filePath.ToApplicationPath()))
            {
                foreach (string line2 in File.ReadAllLines(filePath.ToApplicationPath()))
                {
                    if (line1 == line2)
                        continue;

                    for(int i = 0; i < line1.Length;i++)
                    {
                        if (line1.Remove(i, 1) == line2.Remove(i, 1))
                        {
                            return line1.Remove(i, 1);
                        }
                    }

                }
            }

            return null;
        }
    }
}
