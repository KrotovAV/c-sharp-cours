//Задача 2: Задайте значения M и N. Напишите программу, которая
//рекурсивно выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

int n = 4; 
int m = 8;

void WriteFrTo(int fr, int to)
{
if(fr == to+1) return;
WriteFrTo(fr, to - 1);
Console.Write($"{to}, ");
}
Console.WriteLine();

WriteFrTo(n, m);

Console.WriteLine();

