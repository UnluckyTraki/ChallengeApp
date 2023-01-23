Console.WriteLine("Podaj liczbę:");
var number = Console.ReadLine();
char[] letters = number.ToArray();

List <char> digits = new List <char>();
digits.Add('0');
digits.Add('1');
digits.Add('2');
digits.Add('3');
digits.Add('4');
digits.Add('5');
digits.Add('6');
digits.Add('7');
digits.Add('8');
digits.Add('9');

foreach (char d in digits)
{
    var count = 0;
    foreach (char l in letters)
    {
       if (d == l) count++; 
    }
    Console.WriteLine($"Ilość {d} => {count}");
}



