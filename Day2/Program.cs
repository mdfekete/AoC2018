﻿using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"PuzzleInput\input.txt";

            int checksumA = PuzzleA.GetChecksum(inputFilePath);

            string commonLetters = PuzzleB.GetCommonLetters(inputFilePath);
        }
    }
}
