//7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.

int SecondDigit(int a)
{
    return (a % 10);
}

Console.WriteLine("Write a three digit number ");
string s_a = Console.ReadLine(); // пользователь должен ввести трехзначное целое число и нажать enter
int a = int.Parse(s_a);
if(a < 100)
Console.WriteLine("ERROR. The number is not three digit number!<");
if(a >= 1000)
Console.WriteLine("ERROR. The number is not three digit number!>");

Console.WriteLine(SecondDigit(a));
