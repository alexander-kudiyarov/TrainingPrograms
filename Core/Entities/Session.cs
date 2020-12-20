namespace Core.Entities
{
    public class Session
    {
        public int Day { get; init; }
        public Set[] Sets { get; init; }
        public bool IsProcessed { get; set; }
    }
}