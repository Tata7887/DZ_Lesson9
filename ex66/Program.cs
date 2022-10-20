// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Input integer number M:");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Input integer number N:");
int N = int.Parse(Console.ReadLine()!);

int rangeMin = Min(M, N);
int rangeMax = Max(M, N);

int sum = 0;
for (int i = rangeMin; i <= rangeMax; i++)
{
    sum = sum + i;
}

int Min(int a, int b)
{
    return a < b ? a : b;
}

int Max(int a, int b)
{
    return a > b ? a : b;
}

Console.WriteLine($"\nСумма натуральных элементов в промежутке от M до N равна: {sum}");