using Xunit;
using MyCSharpApp;

namespace MyCSharpApp.Tests
{
    public class ScoreManagerTests
    {
        [Fact]
        public void InitialScore_ShouldBeZero()
        {
            var manager = new ScoreManager();
            Assert.Equal(0, manager.Score);
        }

        [Fact]
        public void AddPoints_PositiveValue_IncreasesScore()
        {
            var manager = new ScoreManager();
            manager.AddPoints(15);
            Assert.Equal(15, manager.Score);
        }
    }
}