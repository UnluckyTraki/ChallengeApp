namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count; 
            } 
        }

        public char AverageLetter 
        { 
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 90:
                        return 'A';
                    case var average when average >= 70 && average < 90:
                        return 'B';
                    case var average when average >= 50 && average < 70:
                        return 'C';
                    case var average when average >= 30 && average < 50:
                        return 'D';
                    case var average when average >= 10 && average < 30:
                        return 'E';
                    case var average when average < 10:
                    default:
                        return 'F';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);

        }
    }
}
