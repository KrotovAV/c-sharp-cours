// Задача 2: Напишите программу, которая принимает на
//вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


Console.WriteLine();
Console.WriteLine("Write a namber");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
int[] arr = s_a.Select(i => (int)i-48).ToArray();

int SumDigNum (int a)
{
    int l = arr.Length;
    int sum = 0;
    for (int i = 0; i < l; i++)
    {
        sum = sum + arr[i];
    }
return sum;
}

Console.WriteLine("----------------");
Console.Write("Sum digits of number ");
Console.WriteLine(SumDigNum (a));
Console.WriteLine();