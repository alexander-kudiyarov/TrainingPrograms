namespace Core.Entities
{
    public class Session
    {
        public int Day { get; set; }
        public Set[] Sets { get; set; }
        public bool IsProcessed { get; set; }
    }
}