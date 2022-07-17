//Задача 1: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

int SecondDigit(int a)
{
    return (a % 100 - a % 10)/10;
}

Console.WriteLine("Write a three digit number ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("  ");
Console.WriteLine("---------------------");

if(a < 100) 
{
    Console.WriteLine("ERROR. The number is not three digit number!");
    System.Environment.Exit(0);
}
if(a >= 1000) 
{
    Console.WriteLine("ERROR. The number is not three digit number!");
    System.Environment.Exit(0);
}
//int b = a % 100;
//int c = (a % 100 - a % 10)/10;
//Console.WriteLine((a % 100 - a % 10)/10);

Console.WriteLine(SecondDigit(a));
Console.WriteLine("---------------------");
Console.WriteLine("  ");