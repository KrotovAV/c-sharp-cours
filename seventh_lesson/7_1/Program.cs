// Задача 1: Задайте двумерный массив размера m на n, каждый
//элемент в массиве находится по формуле: Aₙₙ = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

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

int[,] FillArrayMNFromTo(int colomn, int row)
{
    int[,] matrix = new int[ row, colomn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            matrix[i,j] = i + j;
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

Console.WriteLine("-------------");
int[,] arr_1 = FillArrayMNFromTo(c, r);

PrintArray(arr_1);

Console.WriteLine("-----------");
Console.WriteLine();


