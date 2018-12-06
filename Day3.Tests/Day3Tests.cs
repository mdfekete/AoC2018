using Xunit;

namespace Day3.Tests
{
    public class Day3Tests
    {
        [Fact]
        public void PuzzleA_GivenTestInput_ReturnsOverlapArea()
        {
            string inputFilePath = @"PuzzleInput\testInput.txt";
            int actual = PuzzleA.GetOverlapArea(inputFilePath);

            int expected = 4;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PuzzleB_GivenTestInput_ReturnsClaimId()
        {
            string inputFilePath = @"PuzzleInput\testInput.txt";
            int actual = PuzzleB.GetNonOverlappedClaim(inputFilePath);

            int expected = 3;

            Assert.Equal(expected, actual);
        }
    }
}
