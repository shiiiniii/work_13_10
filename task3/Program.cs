// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 2 без остатка).
Console.Clear();
Console.WriteLine("Является ли число чётным?");
Console.WriteLine("Введите число которое хотите проверить: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0)
    Console.WriteLine($"{number} - чётное");
else 
     Console.WriteLine($"{number} - нечётное");   