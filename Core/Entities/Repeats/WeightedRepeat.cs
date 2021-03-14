namespace Core.Entities.Repeats
{
    public abstract class WeightedRepeat : Repeat
    {
        public double? Percent { get; set; }
        public double? Weight { get; set; }
    }
}