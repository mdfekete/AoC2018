using System.Text.RegularExpressions;

namespace Day3
{
    public class Claim
    {
        public Claim(Match match)
        {
            Id = int.Parse(match.Groups["id"].Value);
            X = int.Parse(match.Groups["x"].Value);
            Y = int.Parse(match.Groups["y"].Value);
            Right = int.Parse(match.Groups["right"].Value);
            Down = int.Parse(match.Groups["down"].Value);
        }

        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Right { get; set; }
        public int Down { get; set; }
    }
}
