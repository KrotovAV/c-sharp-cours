//Задача 3: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

void StrNamPow(int a)
{
    
    for (int i = 1; i <= a; i++)
    {
    
    Console.Write(Math.Pow(i, 2));
    Console.Write(", ");
    }
}

Console.WriteLine();
Console.WriteLine("------------");

Console.WriteLine("Write a namber ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

StrNamPow(a);

Console.WriteLine();
Console.WriteLine("----------------");
Console.WriteLine();