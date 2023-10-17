// Objectif : Compter le nombre de présence de lettre dans une phrase

Console.Write("Veuillez encoder une phrase \n> ");
string text = Console.ReadLine()! ;

Dictionary<char, int> letterCounter = new Dictionary<char, int>();

foreach (char lettre in text.Replace(" ", "").ToUpper())
{
    if (letterCounter.ContainsKey(lettre))
    {
        letterCounter[lettre] += 1;
    }
    else
    {
        letterCounter.Add(lettre, 1);
    }
}

Console.WriteLine("Resultat :");
foreach(KeyValuePair<char, int> kvp in letterCounter)
{
    Console.WriteLine($" - {kvp.Key} : {kvp.Value}");
}
