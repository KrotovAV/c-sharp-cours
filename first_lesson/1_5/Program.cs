//5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.WriteLine("Write a namber ");
string s_a = Console.ReadLine(); // пользователь должен ввести целое число и нажать enter
int a = int.Parse(s_a);

if( a < 0 )
{
a = -a;
}

int n = -a;

while(n <= a)
{
Console.Write(n);
Console.Write(", ");
n+=1;
}
