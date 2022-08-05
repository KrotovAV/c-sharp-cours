//4. Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и
//23.

Console.WriteLine("Write a number ");
string s_a = Console.ReadLine(); 
int a = int.Parse(s_a);

void Multiple(int a)
{
    if (a % 7 == 0)
    {
        if (a % 23 == 0)
        {
        Console.WriteLine( );
        Console.WriteLine($"The number {a} is a multiple of the 7 and 23.");
        }
    }
    else 
    {
        Console.WriteLine( );
        Console.Write($"The number {a} is not a multiple of the 7 and 23.");
        Console.WriteLine( );
    }
}

Multiple(a);