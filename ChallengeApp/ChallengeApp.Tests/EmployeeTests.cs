namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckResultOfAddPositiveScore()
        {
            // arrange
            var emp1 = new Employee("Pawe³", "W", 29);
            emp1.AddScore(5);
            emp1.AddScore(7);
            emp1.AddScore(10);
            emp1.AddScore(10);
           
            // act
            var result1 = emp1.Result;

            // assert 
            Assert.AreEqual(32, result1);
        }

        [Test]
        public void CheckResultOfAddPositiveAndNegativeScore() 
        {
            // arrange
            var emp2 = new Employee("Kamil", "W", 29);
            emp2.AddScore(-7);
            emp2.AddScore(10);
            emp2.AddScore(10);
            emp2.AddScore(-9);
            emp2.AddScore(-9);

            // act
            var result2 = emp2.Result;

            // assert 
            Assert.AreEqual(-5, result2);
        }

    }
}   