//1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

Console.WriteLine("Write a namer a: ");
string s_a = Console.ReadLine();// пользователь должен ввести целое число a и нажать enter
Console.WriteLine("Write a namer b: ");
string s_b = Console.ReadLine();// пользователь должен ввести целое число b и нажать enter
int a = int.Parse(s_a);
int b = int.Parse(s_b);

if(b * b == a)
{
Console.Write("The number ");
Console.Write(a);
Console.Write(" is really the number ");
Console.Write(b);
Console.WriteLine(" raised to the power of 2 "); // The number a is really the number b raised to the power of 2
}
else
{
Console.Write("The number ");
Console.Write(a);
Console.Write(" is not really the number ");
Console.Write(b);
Console.WriteLine(" raised to the power of 2 "); // The number a is not really the number b raised to the power of 2
}