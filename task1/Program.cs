//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее 
Console.Clear();
Console.WriteLine("Какое число является наибольшим, а какое наименьшим?");
Console.WriteLine("Введите первое число, которое хотите проверить ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, которое хотите проверить ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB )
{
Console.WriteLine($"Наибольшим будет число {numberA}, а наименьшим число {numberB}");
}
else
{
Console.WriteLine($"Наибольшим будет число {numberB}, а наименьшим число {numberA}");
}