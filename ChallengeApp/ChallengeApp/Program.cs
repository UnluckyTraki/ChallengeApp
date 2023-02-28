using ChallengeApp;
using System.Diagnostics;
using System.Linq.Expressions;

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
bool success = int.TryParse(Console.ReadLine(), out int age);
Console.WriteLine();
Console.WriteLine("Płeć: ");
var sex = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Jeśli preferujesz zapis danych w pamięci wpisz: m lub M. Natomiast jeśli wolisz zapis do pliku wpisz: f lub F.");
var type = Console.ReadLine();
Console.WriteLine();

if (type == "m" || type == "M")
    {
        var empInM = new EmployeeInMemory(name, surname, age, sex);
        empInM.GradeAdded += EmpGradeAdded;
        while (true)
        {
            Console.WriteLine("Podaj ocenę pracownika od 0 do 100 (q - wynik): ");
            var input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            try
            {
                empInM.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
     var statistics = empInM.GetStatistics();
     Console.WriteLine($"Wyniki pracownika: {empInM.FullInfo}: ");
     PrintStatistics(statistics);
}
else if (type == "f" || type == "F")
{
    var empInF = new EmployeeInFile(name, surname, age, sex);
    empInF.GradeAdded += EmpGradeAdded;
    while (true)
    {
        Console.WriteLine("Podaj ocenę pracownika od 0 do 100 (q - wynik): ");
        var input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }
        try
        {
            empInF.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    var statistics = empInF.GetStatistics();
    Console.WriteLine($"Wyniki pracownika: {empInF.FullInfo}: ");
    PrintStatistics(statistics);
}
else
{
    throw new Exception("Niepoprawny wybór, wpisz m/M lub f/F");
}

void EmpGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

void PrintStatistics(Statistics statistics)
{
    Console.WriteLine($"Najniższa ocena: {statistics.Min}");
    Console.WriteLine($"Najwyższa ocena: {statistics.Max}");
    Console.WriteLine($"Średnia ocen: {statistics.Average}");
    Console.WriteLine($"Ocena końcowa: {statistics.AverageLetter}");
}


