namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckResultOfAddPositiveGrade()
        {
            // arrange
            var emp1 = new Employee("Pawe³", "W", 29);
            emp1.AddGrade(5.0f);
            emp1.AddGrade(7.0f);
            emp1.AddGrade(9.5f);
            emp1.AddGrade(10);

            // act
            var stats1 = emp1.GetStatistics();

            // assert 
            Assert.AreEqual(10, stats1.Max);
            Assert.AreEqual(5, stats1.Min);
            Assert.AreEqual(7.875, stats1.Average);
        }

        [Test]
        public void CheckResultOfAddPositiveAndNegativeScore() 
        {
            // arrange
            var emp2 = new Employee("Kamil", "W", 29);
            emp2.AddGrade(-5);
            emp2.AddGrade(5.5f);
            emp2.AddGrade(10);
            emp2.AddGrade(9);
            emp2.AddGrade(-9);

            // act
            var stats2 = emp2.GetStatistics();

            // assert 
            Assert.AreEqual(10, stats2.Max);
            Assert.AreEqual(-9, stats2.Min);
            Assert.AreEqual(2.1f, stats2.Average);
        }

    }
}   