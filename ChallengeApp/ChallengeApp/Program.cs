using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny pracowników.");
Console.WriteLine("=========================================");
Console.WriteLine();
Console.WriteLine("Proszę o wpisanie danych pracownika.");
Console.WriteLine("Imię: ");
var name = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Nazwisko: ");
var surname = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Wiek: ");
var age = int.Parse(Console.ReadLine());
Console.WriteLine();

var emp = new Employee(name, surname, age);

while (true) 
{
    Console.WriteLine("Podaj ocenę pracownika od 0 do 100 (q - wynik): ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    emp.AddGrade(input);
}

var stats = emp.GetStatistics();
Console.WriteLine($"Wyniki pracownika: {emp.FullInfo}: ");

Console.WriteLine($"Najniższa ocena: {stats.Min}");
Console.WriteLine($"Najwyższa ocena: {stats.Max}");
Console.WriteLine($"Średnia ocen: {stats.Average}");
Console.WriteLine($"Ocena końcowa: {stats.AverageLetter}");


