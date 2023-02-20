namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname, int age, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string Sex { get; private set; }

        public string FullInfo {get; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(int grade);

        public abstract Statistics GetStatistics();
    }
}
