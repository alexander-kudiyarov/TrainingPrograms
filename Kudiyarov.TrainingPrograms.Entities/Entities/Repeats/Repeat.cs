namespace Kudiyarov.TrainingPrograms.Entities.Entities.Repeats
{
    public abstract class Repeat
    {
        public double? Percent { get; set; }
        public Intensity? Intensity { get; init; }
        public double? Weight { get; set; }
        public int Sets { get; init; } = 1;
    }
}