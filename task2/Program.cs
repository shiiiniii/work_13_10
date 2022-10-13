// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Какое число будет наибольшим?");
Console.WriteLine("Введите первое число, которое хотите проверить ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, которое хотите проверить ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число, которое хотите проверить ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(numberB > max) 
{
    max = numberB;
}
if(numberC > max) 
{
    max = numberC;
}
if(numberA > max) 
{
    max = numberA;
}


Console.WriteLine($"Наибольшим будет число {max}");