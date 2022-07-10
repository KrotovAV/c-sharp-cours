//  Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.WriteLine("Write a namber ");
string s_a = Console.ReadLine(); // пользователь должен ввести целое число и нажать enter
int a = int.Parse(s_a);

Console.WriteLine("    ");
Console.WriteLine("Result:");
Console.Write("Namber ");
Console.Write(a);

int b = a % 2;
if( b == 0 )
{
Console.WriteLine(" is an integer namber.");
}
else
{
Console.WriteLine(" is NOT an integer namber.");
}
Console.WriteLine("----------------------------");