//Задача 4: Задайте двумерный массив. Введите элемент, и найдите
//первое его вхождение, выведите позиции по горизонтали и
//вертикали, или напишите, что такого элемента нет.
//Например, такой массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Введенный элемент 2, результат: [1, 4]
//Введенный элемент 6, результат: такого элемента нет.

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

void FindNamberPosInArray(int[,] arr, int n)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i , j] == n)
            {
                
                Console.WriteLine($"[{i+1} , {j+1}]");
                Console.WriteLine();
                Environment.Exit(0);
                count = count + 1; 
            }
        }
    }
    if(count == 0) Console.Write($"Namber {n} not found in array.");
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

Console.WriteLine("Write namber to find ");
string s_n = Console.ReadLine();
int n = int.Parse(s_n);



Console.WriteLine("-------------");
int[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);
Console.WriteLine();

if(n< f || n > t) 
    {
    Console.WriteLine($"Namber {n} not found in array.");
    Console.WriteLine("-------------");
    Console.WriteLine();
    Environment.Exit(0);
    }

FindNamberPosInArray(arr_1, n);

Console.WriteLine();

Console.WriteLine("-----------");
Console.WriteLine();
