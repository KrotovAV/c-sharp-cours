//Задача 5: Вывести первые N строк треугольника
//Паскаля. Сделать вывод в виде равнобедренного
//треугольника

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

int[,] FillArrayPowerEvenPos(int[,] arr)
{
    //int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 1; i < arr.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < arr.GetLength(1); j = j + 2)
        {
            arr[i, j] = arr[i, j]*arr[i, j];
        }
        Console.WriteLine();
    }
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

int[,] arr_2 = FillArrayPowerEvenPos(arr_1);

//Console.WriteLine();

PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();



Console.WriteLine("Hello, World!");
