string name = "Wiktor";
char sex = 'M';
int age = 28;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33.");
}
else if (age < 18 && sex == 'M')
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (name == "Wiktor" && sex == 'M' && age < 30)
{
    Console.WriteLine($"{name}, lat {age}, płeć: mężczyzna.");
}