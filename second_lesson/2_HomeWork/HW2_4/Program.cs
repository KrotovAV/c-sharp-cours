// Задача 4: Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.


void DayOW(int a)
{
    if (a <= 5)
    {
        Console.WriteLine( );
        Console.WriteLine("The day is not a holiday");
    }
    else 
    {
        Console.WriteLine( );
        Console.Write("The day is a holiday");
        Console.WriteLine( );
    }
}

Console.WriteLine("Write a namber - day of the week (from 1 to 7) ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("  ");
Console.WriteLine("---------------------");


if(a > 7) 
{
    Console.WriteLine("ERROR. The number is not namber - day of the week !");
    System.Environment.Exit(0);
}

DayOW(a);

Console.WriteLine("---------------------");
Console.WriteLine("  ");