//Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.

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

int MinRowSumCheck(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        arr[i] = sum;
        //Console.WriteLine($"sum = {sum}");
    }

    int minRow = arr[0];
    int minRowCh = 1;
    for (int k = 0; k < arr.Length; k++)
    {
        if(arr[k] < minRow)
        {
        minRowCh = k+1;
        minRow = arr[k];
        }
    }
    return minRowCh;
}

Console.WriteLine("Write namber row of array");
string s_r = Console.ReadLine();
int r = int.Parse(s_r);

//Console.WriteLine("Write namber coloumn of array");
//string s_c = Console.ReadLine();
//int c = int.Parse(s_c);
int c = r;

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

int minRowSum = MinRowSumCheck(arr_1);

Console.WriteLine($"Min summ of row elements in array is [ {minRowSum} ] row.");

Console.WriteLine("-----------");
Console.WriteLine();