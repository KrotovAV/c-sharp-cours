//Задача 2: Напишите программу, которая принимает на
//вход координаты двух точек и находит расстояние между
//ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


double LineAB(double ax, double ay, double az, double bx, double by, double bz)
{
    double ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax,2) + Math.Pow(by - ay,2) + Math.Pow(bz - az,2)),2);
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

Console.WriteLine("Write Z coordinate point A");
string s_az = Console.ReadLine();
double az = double.Parse(s_az);

Console.WriteLine("Write X coordinate point B");
string s_bx = Console.ReadLine();
double bx = double.Parse(s_bx);

Console.WriteLine("Write Y coordinate point B");
string s_by = Console.ReadLine();
double by = double.Parse(s_by);

Console.WriteLine("Write Z coordinate point B");
string s_bz = Console.ReadLine();
double bz = double.Parse(s_bz);

Console.WriteLine("-------");
Console.WriteLine($"Coordinate point A {ax} : {ay} : {az}");
Console.WriteLine($"Coordinate point B {bx} : {by} : {bz}");
Console.WriteLine();

Console.Write( "Distance from point A to point B ");
Console.WriteLine(LineAB( ax, ay, az, bx, by, bz));

Console.WriteLine("-------");
Console.WriteLine();

