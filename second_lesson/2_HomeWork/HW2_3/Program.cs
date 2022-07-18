//Задача 3: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает, что третьей цифры
//нет. 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine(" ");
Console.WriteLine("Write a number ");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);
Console.WriteLine("  ");
Console.WriteLine("--------------");

if(a < 100) 
{
    Console.WriteLine("ERROR. The number is have not third digit!");
    Console.WriteLine(" ");
    System.Environment.Exit(0);
}

int ThirdDigit(int a)
{
        do
        {
        a = (a- a % 10)/10;
        }
        while (a > 999);

    return (a % 10);
}

Console.WriteLine(ThirdDigit(a));
Console.WriteLine(" ");