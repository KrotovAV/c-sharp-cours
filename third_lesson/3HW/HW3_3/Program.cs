// Задача 3: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125


void StrNamPow3(int a)
{
    
    for (int i = 1; i <= a; i++)
    {
    
    Console.Write(Math.Pow(i, 3));
    Console.Write(", ");
    }
}

Console.WriteLine();
Console.WriteLine("------------");

Console.WriteLine("Write a namber ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

StrNamPow3(a);

Console.WriteLine();
Console.WriteLine("----------------");
Console.WriteLine();

