namespace ChallengeApp
{
    // co bedzie zaimplementowane
    internal interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        string Sex { get; }

        string FullInfo { get; }
        void AddGrade(float grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
