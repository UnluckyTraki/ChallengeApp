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
            {
                if (grade >= 0 && grade <= 100)
                {
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(grade);
                    }

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
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        this.AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        this.AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        this.AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        this.AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        this.AddGrade(20);
                        break;
                    case 'F':
                    case 'f':
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong letter.");
                }
        }

        public override void AddGrade(string grade)
        {
            {
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
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
        }

        public override void AddGrade(int grade)
        {
                var valueInInt = (float)grade;
                this.AddGrade(valueInInt);
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = new Statistics();

            foreach (var grade in gradesFromFile)
            {
                statistics.AddGrade(grade);
            }

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
                        if (float.TryParse(line, out float number))
                        {
                            if (number >= 0 && number <= 100)
                            {
                                grades.Add(number);
                            }
                            else
                            {
                                throw new Exception($"Value of grade {number} from file {fileName} is not valid.");
                            }
                        }
                        else
                        {
                            throw new Exception("Invalid grade format in file {fileName}");
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }     
    }    
}
