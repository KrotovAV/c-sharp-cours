﻿//3. Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли второе число
//кратным первому. Если число 2 не кратно числу 1, то
//программа выводит остаток от деление.

Console.WriteLine("Write first number ");
string s_a = Console.ReadLine(); 
int a = int.Parse(s_a);

Console.WriteLine("Write second number ");
string s_b = Console.ReadLine(); 
int b = int.Parse(s_b);


void Multiple(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine( );
        Console.WriteLine("the second number is a multiple of the first");
    }
    else 
    {
        Console.WriteLine( );
        Console.Write("The second number is not a multiple of the first. Remainder = ");
        Console.WriteLine( a % b);
    }
}

Multiple(a, b);