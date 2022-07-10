//  Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Write a first number ");
string s_a = Console.ReadLine(); // пользователь должен ввести первое число и нажать enter
int a = int.Parse(s_a);

Console.WriteLine("Write a second number ");
string s_b = Console.ReadLine(); // пользователь должен ввести второе число и нажать enter
int b = int.Parse(s_b);

Console.WriteLine("Write a third number ");
string s_c = Console.ReadLine(); // пользователь должен ввести третье число и нажать enter
int c = int.Parse(s_c);

int max = a;

if( b > max)
{
max = b;
}

if( c > max)
{
max = c;
}

Console.WriteLine("    ");
Console.WriteLine("Result:");
Console.Write("max = ");
Console.WriteLine(max);