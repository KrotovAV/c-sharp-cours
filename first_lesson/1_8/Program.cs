//  Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.

Console.WriteLine(" ");
Console.WriteLine("---------------------------");
Console.WriteLine("Write a positive number ");
string s_a = Console.ReadLine(); // пользователь должен ввести целое число и нажать enter
int a = int.Parse(s_a);

Console.WriteLine("    ");
Console.WriteLine("Result:");

if( a < 0 )
{
Console.WriteLine("ERROR. Namber is not a positive number. Run programm and write a positive number");
}

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