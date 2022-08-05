// Задача 2: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine();
Console.WriteLine("Write a namber");
string s_a = Console.ReadLine();
int l = s_a.Length;
int a = int.Parse(s_a);

Console.WriteLine("-----------------");

int SumDigNum (int a)
{
    int sum = 0;
    for (int i = 0; i <= l; i++)
    {
       int b = a % 10;
       int c = ( a - b ) / 10;
       sum = sum + b;
       a = c;
    }
return sum;
}

Console.Write("Sum digits of number ");
Console.WriteLine(SumDigNum (a));

Console.WriteLine();
