// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Посмотреть все четные числа от 1 до заданного Вами числа");
Console.WriteLine("Введите число (1): ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите положительное число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
