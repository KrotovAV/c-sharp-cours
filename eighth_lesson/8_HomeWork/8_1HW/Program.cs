// Задача 1: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] MaxMinRowSort(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[m,j] > array[m,maxPosition])
                {
                maxPosition = j;
                }
            }
            int temporary = array[m,i];
            array[m, i] = array[m,maxPosition];
            array[m,maxPosition] = temporary;
        }
    }
    return array;
}

Console.WriteLine("Write namber row of array");
string s_r = Console.ReadLine();
int r = int.Parse(s_r);

Console.WriteLine("Write namber coloumn of array");
string s_c = Console.ReadLine();
int c = int.Parse(s_c);

//Console.WriteLine("Write random from");
//string s_f = Console.ReadLine();
//int f = int.Parse(s_f);
int f = 1;

//Console.WriteLine("Write random to");
//string s_t = Console.ReadLine();
//int t = int.Parse(s_t);
int t = 10;

Console.WriteLine("-------------");
int[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);

int[,] arr_2 = MaxMinRowSort(arr_1);

Console.WriteLine();

PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();
