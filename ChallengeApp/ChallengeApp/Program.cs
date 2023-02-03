using ChallengeApp;

var emp = new Employee("Wiktor", "P", 29);
emp.AddGrade("2");
emp.AddGrade("4000");
emp.AddGrade("Adam");
emp.AddGrade(2);
emp.AddGrade(6);
var statsDoWhile = emp.GetStatisticsWithDoWhile();
var statsWhile = emp.GetStatisticsWithWhile();
var statsForeach = emp.GetStatisticsWithForeach();
var statsFor = emp.GetStatisticsWithFor();

Console.WriteLine();
Console.WriteLine("Statistics using a loop Do While:");
Console.WriteLine($"Average: {statsDoWhile.Average:N2}");
Console.WriteLine($"Min: {statsDoWhile.Min}");
Console.WriteLine($"Max: {statsDoWhile.Max}");
Console.WriteLine();
Console.WriteLine("Statistics using a loop While:");
Console.WriteLine($"Average: {statsWhile.Average:N2}");
Console.WriteLine($"Min: {statsWhile.Min}");
Console.WriteLine($"Max: {statsWhile.Max}");
Console.WriteLine();
Console.WriteLine("Statistics using a loop Foreach:");
Console.WriteLine($"Average: {statsForeach.Average:N2}");
Console.WriteLine($"Min: {statsForeach.Min}");
Console.WriteLine($"Max: {statsForeach.Max}");
Console.WriteLine();
Console.WriteLine("Statistics using a loop For:");
Console.WriteLine($"Average: {statsFor.Average:N2}");
Console.WriteLine($"Min: {statsFor.Min}");
Console.WriteLine($"Max: {statsFor.Max}");

