
//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int n = 3; 
int m = 15;

void WriteFrTo(int fr, int to)
{
if(to < fr) return;
if(to%2 == 0)
    {
        WriteFrTo(fr, to - 2);
        Console.Write($"{to}, ");
    }
else
    {
        WriteFrTo(fr, to - 1);
    }
}
Console.WriteLine();

WriteFrTo(n, m);

Console.WriteLine();
Console.WriteLine();

