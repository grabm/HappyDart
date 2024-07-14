namespace HappyDart.Domain.Aggregates.Games
{
    public class Game
    {
        //for EF
        private Game()
        {
            
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Player Player { get; set; }
    }
}