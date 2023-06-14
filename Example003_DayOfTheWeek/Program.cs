Console.Clear();
Console.Write("День недели ");
string userInput1 = Console.ReadLine() ?? "";
int number1 = int.Parse(userInput1);

if (number1 == 1)
{
    Console.WriteLine($"{number1} -> Понедельник");
}
else
{
    if (number1 == 2)
    {
        Console.WriteLine($"{number1} -> Вторник");
    }
    else
    {
        if (number1 == 3)
            {
                Console.WriteLine($"{number1} -> Среда");
            }
    
         else 
            {
                if (number1 == 4)
                    {
                     Console.WriteLine($"{number1} -> Четверг");
                    }
                else
                    {
                        if (number1 == 5)
                            {
                                Console.WriteLine($"{number1} -> Пятница");
                            }
                        else
                            {
                                if (number1 == 6)
                                    {
                                        Console.WriteLine($"{number1} -> Суббота");
                                    }
                                else
                                        {
                                            if (number1 == 7)
                                                {
                                                        Console.WriteLine($"{number1} -> Воскресение");
                                                }
                                                    else
    
                                                        {
                                                            Console.WriteLine("Такого дня недели нет");
                                                         }
}
    
    }
                    }
            }
    }
}
