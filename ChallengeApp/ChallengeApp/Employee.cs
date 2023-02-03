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
        public void AddGrade(double grade)
        {
            var valueInDouble = (float)grade;
            this.AddGrade(valueInDouble);
        }
        public void AddGrade(long grade)
        {
            var valueInLong = (float)grade;
            this.AddGrade(valueInLong);
        }
        public void AddGrade(short grade)
        {
            var valueInShort = (float)grade;
            this.AddGrade(valueInShort);
        }
        public void AddGrade(int grade)
        {
            var valueInInt = (float)grade;
            this.AddGrade(valueInInt);
        }
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
        public string FullInfo
        {
            get
            {
                return this.name + " " + this.surname + " " + this.age;
            }
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statisticsDoWhile = new Statistics();
            statisticsDoWhile.Average = 0;
            statisticsDoWhile.Min = float.MaxValue;
            statisticsDoWhile.Max = float.MinValue;

            var index = 0;

            do
            {
                statisticsDoWhile.Max = Math.Max(statisticsDoWhile.Max, this.grades[index]);
                statisticsDoWhile.Min = Math.Min(statisticsDoWhile.Min, this.grades[index]);
                statisticsDoWhile.Average += this.grades[index];
                index++;
            }
            while (index < this.grades.Count);

            statisticsDoWhile.Average /= this.grades.Count;
            return statisticsDoWhile;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statisticsWhile = new Statistics();
            statisticsWhile.Average = 0;
            statisticsWhile.Min = float.MaxValue;
            statisticsWhile.Max = float.MinValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statisticsWhile.Max = Math.Max(statisticsWhile.Max, this.grades[index]);
                statisticsWhile.Min = Math.Min(statisticsWhile.Min, this.grades[index]);
                statisticsWhile.Average += this.grades[index];
                index++;
            }

            statisticsWhile.Average /= this.grades.Count;
            return statisticsWhile;
        }

        public Statistics GetStatisticsWithForeach()
        {
            var statisticsForeach = new Statistics();
            statisticsForeach.Average = 0;
            statisticsForeach.Min = float.MaxValue;
            statisticsForeach.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statisticsForeach.Max = Math.Max(statisticsForeach.Max, grade);
                statisticsForeach.Min = Math.Min(statisticsForeach.Min, grade);
                statisticsForeach.Average += grade;
            }

            statisticsForeach.Average /= this.grades.Count;
            return statisticsForeach;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statisticsFor = new Statistics();
            statisticsFor.Average = 0;
            statisticsFor.Min = float.MaxValue;
            statisticsFor.Max = float.MinValue;
                        
            for (var index = 0; index < this.grades.Count; index++)
            {
                statisticsFor.Max = Math.Max(statisticsFor.Max, this.grades[index]);
                statisticsFor.Min = Math.Min(statisticsFor.Min, this.grades[index]);
                statisticsFor.Average += this.grades[index];      
            }

            statisticsFor.Average /= this.grades.Count;
            return statisticsFor;
        }

    }
}
