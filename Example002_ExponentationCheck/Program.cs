Console.Clear();
Console.Write ("Введите первое число ");
string userInput1 = Console.ReadLine () ??"";
int number1 = int.Parse (userInput1);
Console.Write ("Введите второе число ");
string userInput2 = Console.ReadLine () ??"";
int number2 = int.Parse (userInput2);

if (number1 == number2*number2)
    {
        Console.WriteLine ($"{number1},{number2} -> да");
    }
else 
{
    Console.WriteLine ($"{number1},{number2} -> нет");
}

