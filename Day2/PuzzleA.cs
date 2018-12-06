using Helpers;
using System.IO;
using System.Linq;

namespace Day2
{
    public static class PuzzleA
    {
        public static int GetChecksum(string filePath)
        {
            int twoOfAny = 0;
            int threeOfAny = 0;

            foreach (string line in File.ReadAllLines(filePath.ToApplicationPath()))
            {
                if (line.ContainsExactlyTwoOfAny())
                    twoOfAny++;

                if (line.ContainsExactlyThreeOfAny())
                    threeOfAny++;
            }

            return twoOfAny * threeOfAny;
        }

        private static bool ContainsExactlyTwoOfAny(this string id)
        {
            foreach(char c in id)
            {
                if (id.Count(x => x == c) == 2)
                    return true;
            }

            return false;
        }

        private static bool ContainsExactlyThreeOfAny(this string id)
        {
            foreach (char c in id)
            {
                if (id.Count(x => x == c) == 3)
                    return true;
            }

            return false;
        }
    }
}
