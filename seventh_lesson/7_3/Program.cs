// Задача 3: Задайте двумерный массив. Найдите сумму элементов
//главной диагонали.
//Например, задан массив:
//1 4 7
//5 9 2
//8 4 2
//Сумма элементов главной диагонали: 1+9+2 = 12

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

int FillArrayDiagonalSum(int[,] arr)
{
    //int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i = i + 1)
    {
        sum = sum + arr[i, i];
    }
    return sum;
}

Console.WriteLine("Write namber row of array");
string s_r = Console.ReadLine();
int r = int.Parse(s_r);

Console.WriteLine("Write namber coloumn of array");
string s_c = Console.ReadLine();
int c = int.Parse(s_c);

if(r != c) c = r;

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
int sum = FillArrayDiagonalSum(arr_1);
Console.Write("Diagonal sum = ");
Console.WriteLine(sum);

//Console.WriteLine();

Console.WriteLine("-----------");
Console.WriteLine();
