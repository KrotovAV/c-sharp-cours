// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine(" ");
Console.WriteLine("---------------------------");
Console.WriteLine("Write a namber ");
string s_a = Console.ReadLine(); // пользователь должен ввести целое число и нажать enter
int a = int.Parse(s_a);

if( a < 0 )
{
a = -a;
}

Console.WriteLine("    ");
Console.WriteLine("Result:");

int n = 2;

while(n <= a)
{
Console.Write(n);
Console.Write(", ");
n+=2;
}

Console.WriteLine(" ");
Console.WriteLine("----------------------------");
Console.WriteLine(" ");