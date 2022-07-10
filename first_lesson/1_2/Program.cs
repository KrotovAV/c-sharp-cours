// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
//какое меньшее.

Console.WriteLine("Write a first number ");
string s_a = Console.ReadLine(); // пользователь должен ввести первое число и нажать enter
int a = int.Parse(s_a);
Console.WriteLine("Write a second number ");
string s_b = Console.ReadLine(); // пользователь должен ввести второе число и нажать enter
int b = int.Parse(s_b);
Console.WriteLine("    ");
Console.WriteLine("Result:");
if( a > b)
{
Console.Write("max = ");
Console.WriteLine(a);
Console.Write("min = ");
Console.WriteLine(b);
}
else
{
Console.Write("max = ");
Console.WriteLine(b);
Console.Write("min = ");
Console.WriteLine(a);
}