namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckResultOfAddGrade() 
        {
            // arrange
            var emp2 = new Employee("Kamil", "W", 29);
            emp2.AddGrade(5);
            emp2.AddGrade(5.5f);
            emp2.AddGrade(100);
            emp2.AddGrade(90);
            emp2.AddGrade(40);

            // act
            var stats2 = emp2.GetStatistics();

            // assert 
            Assert.AreEqual(100, stats2.Max);
            Assert.AreEqual(5, stats2.Min);
            Assert.AreEqual(48.1f, stats2.Average);
            Assert.AreEqual('D', stats2.AverageLetter);
        }

    }
}   