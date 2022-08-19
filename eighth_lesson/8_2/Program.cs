//Задача 2: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

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

void ArrayRowColomn(int[,] arr)
{
    if(arr.GetLength(0)!=arr.GetLength(1)) 
    {
    Console.WriteLine();
    Console.WriteLine($"!!! row {arr.GetLength(0)} =/= {arr.GetLength(1)} colomn !!!");
    Console.WriteLine("-------------");
    Console.WriteLine();
    Environment.Exit(0);
    }
}

int[,] ArrayTranspond(int[,] arr)
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int vrem = 0;
    for (int i = 0; i < row; i=i+1)
    {
        for (int j = i; j < col; j=j+1)
        {
        vrem = arr[i,j];
        arr[i,j] = arr[j,i];
        //arr[i,j] = 5;
        arr[j,i] = vrem;
        //(arr[i,j], arr[j, i]) = (arr[j,i], arr[i, j]); 
        }
    }
    return arr;
}

Console.WriteLine();

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

ArrayRowColomn(arr_1);

Console.WriteLine();

int[,] arr_2 = ArrayTranspond(arr_1);

PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();


