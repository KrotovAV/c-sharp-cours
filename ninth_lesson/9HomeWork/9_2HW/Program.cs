//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int n = 1; 
int m = 15;
int s =0;

int SumFrTo(int fr, int to)
{
if(fr == to+1) return 0;
s = to;
s = s + SumFrTo(fr, to - 1);
return s;
}
Console.WriteLine();

int sum = SumFrTo(n, m);

Console.WriteLine(sum);

Console.WriteLine("");
