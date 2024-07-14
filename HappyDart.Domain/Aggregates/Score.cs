namespace HappyDart.Domain.Aggregates
{
    public class Score
    {
        public long Id { get; set; }
        public int Point { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
    }
}