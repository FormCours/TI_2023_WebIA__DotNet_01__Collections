// Objectif : Detecter la présence de lettre dans une phrase

Console.Write("Veuillez encoder une phrase \n> ");
string text = Console.ReadLine()!;

HashSet<char> letters = new HashSet<char>();

foreach (char lettre in text.Replace(" ", "").ToUpper())
{
    letters.Add(lettre);
}

Console.WriteLine("Resultat :");
foreach (char letter in letters)
{
    Console.WriteLine($" - {letter}");
}
