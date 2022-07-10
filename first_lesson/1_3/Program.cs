//3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

Console.WriteLine("Write a namer from 1 to 7: ");
string s_a = Console.ReadLine(); // пользователь должен ввести целое число от 1 до 7 и нажать enter
int a = int.Parse(s_a);

if(a == 1)
{
Console.Write("Monday");
}
if(a == 2)
{
Console.Write("Tuesday");
}

if(a == 3)
{
Console.Write("Wednesday");
}

if(a == 4)
{
Console.Write("Thursday");
}

if(a == 5)
{
Console.Write("Friday");
}

if(a == 6)
{
Console.Write("Saturday");
}

if(a == 7)
{
Console.Write("Sunday");
}

if(a > 7)
{
Console.WriteLine("ERROR. Write a namer from 1 to 7");
}

if(a < 1)
{
Console.WriteLine("ERROR. Write a namer from 1 to 7");
}