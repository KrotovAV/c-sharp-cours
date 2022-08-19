//Задача 1: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.
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

int[,] FillArrayReversFirstEndRow(int[,] arr)
{
    int vrem = 0;
    for (int j = 0; j < arr.GetLength(1); j = j + 1)
    {
        vrem = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0)-1, j];
        arr[arr.GetLength(0)-1, j] = vrem;
    }
    Console.WriteLine();
    return arr;
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

int[,] arr_2 = FillArrayReversFirstEndRow(arr_1);

//Console.WriteLine();

PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();
