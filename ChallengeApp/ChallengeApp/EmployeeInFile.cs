namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname, int age, string sex)
            : base(name, surname, age, sex)
        {
        }

        public string FullInfo
        {
            get
            {
                return this.Name + " " + this.Surname + " " + this.Age + " " + this.Sex;
            }
        }
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Invalid grade value");
                }
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                switch (grade)
                {
                    case 'A':
                        writer.WriteLine(100);
                        break;
                    case 'B':
                        writer.WriteLine(80);
                        break;
                    case 'C':
                        writer.WriteLine(60);
                        break;
                    case 'D':
                        writer.WriteLine(40);
                        break;
                    case 'E':
                        writer.WriteLine(20);
                        break;
                    case 'F':
                        writer.WriteLine(0);
                        break;
                    default:
                        throw new Exception("Wrong letter.");
                }
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (float.TryParse(grade, out float result))
                {
                    writer.WriteLine(result);
                }
                else if (char.TryParse(grade, out char character))
                {
                    writer.WriteLine(character);
                }
                else
                {
                    throw new Exception("String is not a float.");
                }
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                var valueInInt = (float)grade;
                writer.WriteLine(valueInInt);
            }
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = this.CountStatistics(gradesFromFile);
            return statistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();

            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                { 
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
        

            statistics.Average /= grades.Count;

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
