// Задача 2: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

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

void FindNamberFromPosInArray(int[,] arr, int nr, int nc)
{
    Console.Write($"Namber in[{nr}] , [{nc}] position of array: ");
    Console.WriteLine(arr[nr-1 , nc-1]);
    Console.WriteLine();
}

Console.WriteLine();

//Console.WriteLine("Write namber row of array");
//string s_r = Console.ReadLine();
//int r = int.Parse(s_r);
int r = 5;

//Console.WriteLine("Write namber coloumn of array");
//string s_c = Console.ReadLine();
//int c = int.Parse(s_c);
int c = 6;

//Console.WriteLine("Write random from");
//string s_f = Console.ReadLine();
//int f = int.Parse(s_f);
int f = 1;

//Console.WriteLine("Write random to");
//string s_t = Console.ReadLine();
//int t = int.Parse(s_t);
int t = 20;

Console.WriteLine("Write row og find namber ");
string s_nr = Console.ReadLine();
int nr = int.Parse(s_nr);

Console.WriteLine("Write colomn og find namber ");
string s_nc = Console.ReadLine();
int nc = int.Parse(s_nc);

Console.WriteLine("-------------");
int[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);
Console.WriteLine();

if(nc > c || nr > r) 
    {
    Console.WriteLine($"Namber in row {nr}, colomn {nc} not found");
    Console.WriteLine("-------------");
    Console.WriteLine();
    Environment.Exit(0);
    }

FindNamberFromPosInArray(arr_1, nr, nc);

Console.WriteLine();

Console.WriteLine("-----------");
Console.WriteLine();


