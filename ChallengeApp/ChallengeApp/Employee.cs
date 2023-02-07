using System;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        public List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name { get; private set; }
        public string surname { get; private set; }
        public int age { get; private set; }

        public string FullInfo
        {
            get
            {
                return this.name + " " + this.surname + " " + this.age;
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
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade) 
            {
                case 'A' :
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
                    Console.WriteLine("Wrong Letter");
                    this.grades.Add(0);
                break;
            }
        }
    //public void AddGrade(double grade)
    //{
    //    var valueInDouble = (float)grade;
    //    this.AddGrade(valueInDouble);
    //}
    //public void AddGrade(long grade)
    //{
    //    var valueInLong = (float)grade;
    //    this.AddGrade(valueInLong);
    //}
    //public void AddGrade(short grade)
    //{
    //    var valueInShort = (float)grade;
    //    this.AddGrade(valueInShort);
    //}
    //public void AddGrade(int grade)
    //{
    //    var valueInInt = (float)grade;
    //    this.AddGrade(valueInInt);
    //}
    public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not a float.");
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

            switch(statistics.Average)
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
