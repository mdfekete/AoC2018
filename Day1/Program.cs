namespace Day1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"PuzzleInput\input.txt";

            var answerA = PuzzleA.GetFrequency(inputFilePath);

            var answerB = PuzzleB.GetFrequency(inputFilePath);
        }
    }
}
