// Задача 3: Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом
//столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого
//столбца: 4,6; 5,6; 3,6; 3.

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

void ArrayColomnAverage(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double aver = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            aver = aver + arr[i,j];
        }
        aver = aver / arr.GetLength(0);
        Console.Write($"{aver} ");
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

Console.WriteLine();

//Console.WriteLine("Write namber row of array");
//string s_r = Console.ReadLine();
//int r = int.Parse(s_r);
int r = 4;

//Console.WriteLine("Write namber coloumn of array");
//string s_c = Console.ReadLine();
//int c = int.Parse(s_c);
int c = 5;

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
Console.WriteLine();

ArrayColomnAverage(arr_1);

Console.WriteLine();

Console.WriteLine("-----------");
Console.WriteLine();

