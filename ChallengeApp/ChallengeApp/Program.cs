using ChallengeApp;

var emp = new Employee("Wiktor", "P", 29);
emp.AddGrade(4.5f);
emp.AddGrade(3.5f);
var stats1 = emp.GetStatistics();

Console.WriteLine($"Average: {stats1.Average:N2}");
Console.WriteLine($"Min: {stats1.Min}");
Console.WriteLine($"Max: {stats1.Max}");