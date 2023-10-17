// Convention de nommage
//  - variable  : camelCase
//  - méthode   : camelCase
//  - constante : UPPER_CASE
//  - classe    : PascalCase
using System.Text.RegularExpressions;

List<int> numbers = new List<int>();

// Permet à l'utilisateur d'encoder des valeurs
// Arrêt s'il encode "s" ou "Stop"
Console.WriteLine("Veuiller encoder des nombres entiers (\"Stop\", pour arrêter)");
bool encodingNumber = true;
do
{
    string userInput = Console.ReadLine()!;

//  if (userInput == "Stop")
//  if (Regex.IsMatch(userInput, "s(top)?", RegexOptions.IgnoreCase))
    if (userInput.Equals("stop", StringComparison.OrdinalIgnoreCase))
    {
        encodingNumber = false;
    }
    else if (int.TryParse(userInput, out int result))
    {
        numbers.Add(result);
    }
    else
    {
        Console.WriteLine("Boulet! Il faut encoder un nombre :o");
    }
} while (encodingNumber);


// Traitement
int sumNumber = 0;
for(int i = 0; i < numbers.Count; i++)
{
    int nb = numbers[i];
    sumNumber += nb;
}

//foreach (int nb in numbers)
//{
//    // Récuperation des elements de la liste en lecture !
//    // Modification de la liste (add, remove) interdit.
//    sumNumber += nb;
//}

double avgNumber =  (double)sumNumber / numbers.Count;

Console.WriteLine($"Le nombre de valeur encodée est de {numbers.Count}.");
Console.WriteLine($"La moyenne des valeurs est de {avgNumber}");