//Задача 3: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры
//нет.


int SecondDigit(int a)
{
    return a % 10;
}

Console.WriteLine(" ");
Console.WriteLine("Write a three digit number ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("  ");
Console.WriteLine("---------------------");

if(a < 100) 
{
    Console.WriteLine("ERROR. The number is have not third digit!");
    Console.WriteLine(" ");
    System.Environment.Exit(0);
}
if(a >= 1000) 
{
    Console.WriteLine("ERROR. The number is not three digit number!");
    Console.WriteLine(" ");
    System.Environment.Exit(0);
}

Console.WriteLine(SecondDigit(a));