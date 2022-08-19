//Задача 1: Задайте значение N. Напишите программу, которая выведет
//все натуральные числа в промежутке от 1 до N при помощи рекурсии.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

int n = 5;

void Natural(int nam)
{
if(nam == 0) return;
Natural(nam - 1);
Console.Write($"{nam}, ");
}
Console.WriteLine();
Natural(n);

Console.WriteLine();
