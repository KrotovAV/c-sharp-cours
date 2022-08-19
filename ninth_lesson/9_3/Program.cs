//Задача 3: Напишите программу, которая будет принимать на вход число и
//возвращать сумму его цифр. Использовать рекурсию.
//453 -> 12
//45 -> 9

Console.WriteLine();

int n = 45;
int sum = 0;

Console.WriteLine(n);
Console.WriteLine();

int SumNatural(int nam)
{
if(nam ==0) return 0;
sum = nam%10;
sum = sum + SumNatural(nam/10);
return sum;
}

Console.WriteLine(SumNatural(n));
Console.WriteLine();