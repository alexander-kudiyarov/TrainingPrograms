namespace Core.Entities
{
    public class Repeat
    {
        public double? Weight { get; set; }
        public double? Percent { get; set; }
        public string Repeats { get; init; }
        public int Sets { get; set; } = 1;
    }
}