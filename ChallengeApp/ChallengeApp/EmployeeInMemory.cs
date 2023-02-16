namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname, int age, string sex)
            : base(name, surname, age, sex)
        {

        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
