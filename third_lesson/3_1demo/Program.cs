// 1. Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится
//эта точка.
//      y
//   2  |  1
//______|______x
//      |  
//   3  |  4

Console.WriteLine();
Console.WriteLine("-------------");
Console.WriteLine("Write X coordinate");
string s_a = Console.ReadLine();
int a = int.Parse(s_a);

Console.WriteLine("Write Y coordinate");
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

void Coordinate( int a, int b)
{
    if (a == 0)
    {
        Console.WriteLine("---------------");
        Console.WriteLine("!!! Wrong X coordinate!!!");
        Console.WriteLine();
        System.Environment.Exit(0);
    }

    if (b == 0)
    {
        Console.WriteLine("---------------");
        Console.WriteLine("!!!Wrong Y coordinate!!!");
        Console.WriteLine();
        System.Environment.Exit(0);
    }

    Console.WriteLine();
    Console.Write($"Coordinates ( {a} : {b} )");

    if (a > 0)
        {
            if (b > 0) 
            {
                Console.WriteLine(" belong to 1 zone");
            }
            else
            {
                Console.WriteLine(" belong to 4 zone");
            }
        }
    else
        {
            if (b > 0) 
            {
                Console.WriteLine(" belong to 2 zone");
            }
            else
            {
                Console.WriteLine(" belong to 3 zone");
            } 
        }
    
Console.WriteLine("------------------");
Console.WriteLine();
}

Coordinate(a, b);
