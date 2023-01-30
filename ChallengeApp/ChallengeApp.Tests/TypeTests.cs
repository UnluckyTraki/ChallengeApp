namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CheckIfValueTypesAreEqual()
        {
            // arrange
            int number1 = 10;
            int number2 = 20;

            float average1 = 5.12f;
            float average2 = 5.12f;

            string name1 = "Wiktor";
            string name2 = "Kamil";

            // act

            // assert 
            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(average1, average2);
            Assert.AreNotSame(name1, name2);
        }


        [Test]
        public void CheckIfReferenceTypeGetEmployeesAreEqual()
        {
            // arrange
            var emp1 = GetEmployee("Tomasz", "Król", 27);
            var emp2 = GetEmployee("Tomasz", "Krul", 27);

            // act

            // assert 
            Assert.AreNotEqual(emp1, emp2);
            Assert.AreSame(emp1.name, emp2.name);
            Assert.AreNotSame(emp1.surname, emp2.surname);
            Assert.AreEqual(emp1.age, emp2.age);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }
}
