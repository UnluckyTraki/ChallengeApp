namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public string FullInfo
        {
            get 
            {
                return this.name + " " + this.surname + " " + this.age;
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
