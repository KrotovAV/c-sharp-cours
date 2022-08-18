//Задача 3: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.


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

int[,] PowerArrays(int[,] arr1, int[,] arr2)
{
    //arr3[r,p], arr1[i,j], arr2[m,n]
    //r = i , p = n, j = m
    int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    int sum = 0;
    for (int r = 0, i = 0; r < arr3.GetLength(0); r++, i++)
    {
        for (int p = 0, n = 0; p < arr3.GetLength(1); p++, n++)
        {
            for (int m = 0, j = 0; j < arr1.GetLength(1); m++, j++)
            {
                sum = sum + arr1[i,j]*arr2[m,n];
                //Console.WriteLine($" r:{r} - p:{p} , i:{i} - j:{j} , m:{m} - n:{n} == {sum}");
            }
            arr3[r,p] = sum;
            sum = 0;
            //Console.WriteLine("----");
        }
    }
    return arr3;
}

Console.WriteLine("Write namber row of 1 array");
string s_r1 = Console.ReadLine();
int r1 = int.Parse(s_r1);

Console.WriteLine("Write namber coloumn of 1 array");
string s_c1 = Console.ReadLine();
int c1 = int.Parse(s_c1);

int r2 = c1;
Console.WriteLine($"Namber row of 2 array: {c1}");

int c2 = r1;
Console.WriteLine($"Namber coloumn of 2 array: {r1}");

//Console.WriteLine("Write random from");
//string s_f = Console.ReadLine();
//int f = int.Parse(s_f);
int f = 1;

//Console.WriteLine("Write random to");
//string s_t = Console.ReadLine();
//int t = int.Parse(s_t);
int t = 10;

Console.WriteLine("-------------");
int[,] arr_1 = FillArrayFromTo(c1, r1, f, t);
PrintArray(arr_1);

int[,] arr_2 = FillArrayFromTo(c2, r2, f, t);
Console.WriteLine();
PrintArray(arr_2);

Console.WriteLine();

int[,] arr_3 = PowerArrays(arr_1, arr_2);
Console.WriteLine();
PrintArray(arr_3);

Console.WriteLine("-----------");
Console.WriteLine();
