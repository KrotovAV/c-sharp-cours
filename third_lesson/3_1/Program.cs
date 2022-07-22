// Задача 1: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine();
Console.WriteLine("-------------");
Console.WriteLine("Write quarter from 1 to 4");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

void Quarter( int a )
{
    Console.WriteLine("---------------");
    if (a < 0 || a > 4)
    {
        Console.WriteLine("!!! Wrong quarter. Write quarter from 1 to 4!!!");
        Console.WriteLine();
        System.Environment.Exit(0);
    }
    else if (a == 1)  Console.WriteLine(" a > 0, b > 0");
    else if (a == 2)  Console.WriteLine(" a < 0, b > 0");
    else if (a == 3)  Console.WriteLine(" a < 0, b < 0");
    else if (a == 4)  Console.WriteLine(" a > 0, b < 0");

    Console.WriteLine();
}
Quarter(a);
