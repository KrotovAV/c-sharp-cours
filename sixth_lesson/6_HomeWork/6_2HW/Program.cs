// Задача 2. Напишите программу, которая найдёт точку
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//0 = a1 * x + b1 * y + c1
//0 = a2 * x + b2 * y + c2

//значения b1, k1, b2 и k2 задаются
//пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine();
Console.WriteLine("1 straight line equation  0 = a1 * x + b1 * y + c1");
Console.WriteLine("2 straight line equation  0 = a2 * x + b2 * y + c2");

Console.WriteLine("--------------------");
//Console.WriteLine("Write coefficient a1");
//double a1 = double.Parse(Console.ReadLine());
double a1 = 4;//5

//Console.WriteLine("Write coefficient b1");
//double b1 = double.Parse(Console.ReadLine());
double b1 = 1;//-1

//Console.WriteLine("Write coefficient c1");
//double c1 = double.Parse(Console.ReadLine());
double c1 = 2;//2
Console.Write($"coefficient a1 = {a1}, ");
Console.Write($"coefficient b1 = {b1}, ");
Console.WriteLine($"coefficient c1 = {c1}.");

//Console.WriteLine("Write coefficient a2");
//double a2 = double.Parse(Console.ReadLine());
double a2 = 4;//9

//Console.WriteLine("Write coefficient b2");
//double b2 = double.Parse(Console.ReadLine());
double b2 = 1;//-1

//Console.WriteLine("Write coefficient c2");
//double c2 = double.Parse(Console.ReadLine());
double c2 = 2;//4

Console.Write($"coefficient a2 = {a2}, ");
Console.Write($"coefficient b2 = {b2}, ");
Console.WriteLine($"coefficient c2 = {c2}.");
Console.WriteLine($"-----------------");
if ((a1 * b2 - a2 * b1) == 0)
    {
        Console.WriteLine($"The lines are parallel - NO intersection point");
        Console.WriteLine("--------------------");
    }
return;

if (a1 * b2 == b1 * a2 && a1 * c2 == a2 * c1 && b1 * c2 == c1 * b2)
    {
        Console.WriteLine($"The two lines are the same line");
        Console.WriteLine("--------------------");
    }
return;

double x = (b1 * c2 - b2 * c1) / (a1 * b2 - a2 * b1);
double y = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

Console.WriteLine($"Coordinate X of intersection point: {x}.");
Console.WriteLine($"Coordinate Y of intersection point: {y}.");
Console.WriteLine("-------------------");
Console.WriteLine();
