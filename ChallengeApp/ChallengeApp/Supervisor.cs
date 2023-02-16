
namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, int age, string sex)
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

        public string FullInfo
        {
            get
            {
                return this.Name + " " + this.Surname + " " + this.Age + " " + this.Sex;
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong letter.");
            }
        }
        public void AddGrade(int grade)
        {
            var valueInInt = (float)grade;
            this.AddGrade(valueInInt);
        }
        public void AddGrade(string grade)
        {
            int signMath = 0;
            if (grade.Contains("+"))
            {
                signMath = 5;
            }
            else if (grade.Contains("-"))
            {
                signMath = -5;
            }

            char[] charsToTrim = { '+', '-' };
            grade = grade.Trim(charsToTrim);

            if (float.TryParse(grade, out float result))
            {
                switch (result)
                {
                    case 6:
                        this.grades.Add(100 + signMath);
                        break;
                    case 5:
                        this.grades.Add(80 + signMath);
                        break;
                    case 4:
                        this.grades.Add(60 + signMath);
                        break;
                    case 3:
                        this.grades.Add(40 + signMath);
                        break;
                    case 2:
                        this.grades.Add(20 + signMath);
                        break;
                    case 1:
                        this.grades.Add(0 + signMath);
                        break;
                    default:
                        throw new Exception("Something wrong.");
                }
            }
            else if (char.TryParse(grade, out char character))
            {
                this.AddGrade(character);
            }
            else
            {
                throw new Exception("String is not a float.");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 70 && average < 90:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 50 && average < 70:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 30 && average < 50:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 10 && average < 30:
                    statistics.AverageLetter = 'E';
                    break;
                case var average when average < 10:
                    statistics.AverageLetter = 'F';
                    break;
            }

            return statistics;
        }
    }
}
