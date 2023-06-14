Console.Clear();
Console.Write ("Введите число ");
string userInput = Console.ReadLine () ??"";
int number = int.Parse (userInput);

int result = number*number;

Console.WriteLine ($"!!!{number} -> {result}!!!");