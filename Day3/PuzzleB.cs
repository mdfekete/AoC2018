using Helpers;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Day3
{
    public static class PuzzleB
    {
        public static readonly string pattern = @"#(?<id>\d{1,4})\s@\s(?<x>\d{1,3}),(?<y>\d{1,3}):\s(?<right>\d{1,3})x(?<down>\d{1,3})";

        public static int GetNonOverlappedClaim(string filePath)
        {
            int[,] fabricArray = new int[1000, 1000];
            List<Claim> claims = new List<Claim>();

            foreach (string line in File.ReadAllLines(filePath.ToApplicationPath()))
            {
                var match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    var claim = new Claim(match);
                    claims.Add(claim);

                    for (int i = 0; i < claim.Right; i++)
                    {
                        for (int j = 0; j < claim.Down; j++)
                        {
                            fabricArray[claim.X + i, claim.Y + j] += 1;
                        }
                    }
                }
            }

            foreach (var claim in claims)
            {
                bool isGoodClaim = true;

                for (int i = 0; i < claim.Right; i++)
                {
                    for (int j = 0; j < claim.Down; j++)
                    {
                        if(fabricArray[claim.X + i, claim.Y + j] != 1)
                        {
                            isGoodClaim = false;
                            break;
                        }
                    }
                }

                if (isGoodClaim)
                    return claim.Id;
            }

            return 0;
        }
    }
}
