//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

Console.WriteLine();
//Console.WriteLine("Write length of side AB ");
//int a = int.Parse(Console.ReadLine());
int ab = 8;

//Console.WriteLine("Write length of side BC ");
//int b = int.Parse(Console.ReadLine());
int bc = 2;

//Console.WriteLine("Write length of side CA ");
//int t = int.Parse(Console.ReadLine());
int ca = 8;

void Triangle (int a, int b, int c)
{
    if(a < b + c && b < c + a && c < a + b) 
        {
            Console.WriteLine("triangle YES!");
        }
    else
        {
            Console.WriteLine("triangle NO!");
        }
}

Triangle(ab, bc, ca);
