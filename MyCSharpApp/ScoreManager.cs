namespace MyCSharpApp
{
    public class ScoreManager
    {
        public int Score { get; private set; } = 0;

        public void AddPoints(int points)
        {
            if (points > 0)
            {
                Score += points;
            }
        }

        public void Reset()
        {
            Score = 0;
        }
    }
}