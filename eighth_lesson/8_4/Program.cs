//Задача 4: Задайтедвумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на
//пересечении которых расположен наименьший элемент
//массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Наименьший элемент - 1, на выходе получим
//следующий массив:
//9 4 2
//2 2 6
//3 4 7

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

int[,] FillArrayWithoutMinNamRowCol(int[,] arr)
{
    int min = arr[0,0];
    int minI = 0;
    int minJ = 0;
    for (int a = 0; a < arr.GetLength(0); a++)
    {
        for (int b = 0; b < arr.GetLength(1); b++)
        {
            if(arr[a, b] < min)
            {
                min = arr[a,b];
                minI = a;
                minJ = b;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine($"First min namber = {min} on i = {minI}, j = {minJ} position");

int[,] newArr = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];

for (int i = 0, m = 0; i < newArr.GetLength(0); i++, m++)
    {
        if(minI==i) m=m+1;
        for (int n = 0, j = 0; j < newArr.GetLength(1); j++, n++)
        {
            if(minJ==j) n=n+1;
            newArr[i, j] = arr[m, n];
        }
    }
    return newArr;
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

int[,] arr_2 = FillArrayWithoutMinNamRowCol(arr_1);

Console.WriteLine();

PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();
