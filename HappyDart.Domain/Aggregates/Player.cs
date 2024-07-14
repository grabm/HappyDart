namespace HappyDart.Domain.Aggregates
{
    public class Player
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}