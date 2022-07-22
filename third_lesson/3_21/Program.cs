// Задача 2: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21


double LineAB(double ax, double ay, double bx, double by)
{
    double ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax,2) + Math.Pow(by - ay,2)),2);
    return ab;
}

Console.WriteLine();
Console.WriteLine("------------");

Console.WriteLine("Write X coordinate point A");
string s_ax = Console.ReadLine();
double ax = double.Parse(s_ax);

Console.WriteLine("Write Y coordinate point A");
string s_ay = Console.ReadLine();
double ay = double.Parse(s_ay);

Console.WriteLine("Write X coordinate point B");
string s_bx = Console.ReadLine();
double bx = double.Parse(s_bx);

Console.WriteLine("Write Y coordinate point B");
string s_by = Console.ReadLine();
double by = double.Parse(s_by);

Console.WriteLine("-------");
Console.WriteLine($"Coordinate point A {ax} : {ay}");
Console.WriteLine($"Coordinate point B {bx} : {by}");
Console.WriteLine();

Console.Write( "Distance from A to B ");
Console.WriteLine(LineAB( ax, ay, bx, by));

Console.WriteLine("-------");
Console.WriteLine();