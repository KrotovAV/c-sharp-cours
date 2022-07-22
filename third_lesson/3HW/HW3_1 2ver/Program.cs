//Задача 1: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.


void Polindrome(string text)
{
    if(text[0] == text[4] || text[1] == text[3])
    {
        Console.WriteLine("The nfmber is Polindrome");
    }
    else
    {
        Console.WriteLine("The nfmber is NOT Polindrome");
    }

}

Console.WriteLine();
Console.WriteLine("------------");

Console.WriteLine("Write a five digit namber ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
if (a <= 9999 || a > 99999 )
{
    Console.WriteLine("!!! A namer is not a five digit namber !!!");
    Console.WriteLine();
    System.Environment.Exit(0);
}

Console.WriteLine();
Console.WriteLine("----------------");

Polindrome(s_a);

Console.WriteLine("----------------");
Console.WriteLine();