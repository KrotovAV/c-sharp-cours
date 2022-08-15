//Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] FillArrayFromTo(int colomn, int row, int from, int to)
{
    double[,] matrix = new double[ row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            matrix[i,j] = Convert.ToDouble(new Random().Next(from, to  +1)/100.0);
        }
    }
    return matrix;
}

Console.WriteLine("Write namber row of array");
string s_r = Console.ReadLine();
int r = int.Parse(s_r);

Console.WriteLine("Write namber coloumn of array");
string s_c = Console.ReadLine();
int c = int.Parse(s_c);

Console.WriteLine("Write random from");
string s_f = Console.ReadLine();
int f = int.Parse(s_f);

Console.WriteLine("Write random to");
string s_t = Console.ReadLine();
int t = int.Parse(s_t);

Console.WriteLine("-------------");
double[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);

Console.WriteLine("-----------");
Console.WriteLine();
