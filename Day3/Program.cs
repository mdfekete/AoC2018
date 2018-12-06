using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"PuzzleInput\input.txt";

            int overlapArea = PuzzleA.GetOverlapArea(inputFilePath);

            int claimId = PuzzleB.GetNonOverlappedClaim(inputFilePath);
        }
    }
}
