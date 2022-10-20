// /Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8" */


Console.Write("Input integer number N:");
int N = int.Parse(Console.ReadLine()!);



Console.WriteLine(GetNaruralRow(N));


string GetNaruralRow(int n)
{
    if (n == 1)
        return "1";

    return n + ", " + GetNaruralRow(n - 1);

}
