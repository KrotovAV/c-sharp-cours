//Задача 1: Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

void PrintArray(int[,] matr)
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

//int[,] matrix = new int[3,4];
//void FillArray(int[,] matr)
//{
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//        for (int j = 0; j < matr.GetLength(1); j++)
//        {
//            matr[i,j] = new Random().Next(1,10);
//        }
//    }
//}

int[,] FillArrayFromTo(int colomn, int row, int from, int to)
{
    int[,] matrix = new int[ row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            matrix[i,j] = new Random().Next(from, to);
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
int[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);

Console.WriteLine("-----------");
Console.WriteLine();