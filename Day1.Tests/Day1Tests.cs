using Xunit;
using Day1;

namespace Day1.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void PuzzleA_GivenTestInput_ReturnsFrequency()
        {
            string inputFilePath = @"PuzzleInput\testInput.txt";
            int actual = PuzzleA.GetFrequency(inputFilePath);

            int expected = 3;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PuzzleB_GivenTestInput_ReturnsFrequency()
        {
            string inputFilePath = @"PuzzleInput\testInput.txt";
            int actual = PuzzleB.GetFrequency(inputFilePath);

            int expected = 2;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PuzzleB_GivenAlternativeTestInput_ReturnsFrequency()
        {
            string inputFilePath = @"PuzzleInput\testInput2.txt";
            int actual = PuzzleB.GetFrequency(inputFilePath);

            int expected = 10;

            Assert.Equal(expected, actual);
        }
    }
}
