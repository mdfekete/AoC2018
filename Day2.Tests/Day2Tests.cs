using System;
using Xunit;

namespace Day2.Tests
{
    public class Day2Tests
    {
        [Fact]
        public void PuzzleA_GivenTestInput_ReturnsChecksum()
        {
            string inputFilePath = @"PuzzleInput\testInput.txt";
            int actual = PuzzleA.GetChecksum(inputFilePath);

            int expected = 12;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PuzzleB_GivenTestInput_ReturnsCommonLetters()
        {
            string inputFilePath = @"PuzzleInput\testInput2.txt";
            string actual = PuzzleB.GetCommonLetters(inputFilePath);

            string expected = "fgij";

            Assert.Equal(expected, actual);
        }
    }
}
