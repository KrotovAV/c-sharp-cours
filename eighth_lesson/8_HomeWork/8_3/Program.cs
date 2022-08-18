//Задача 3: Составить частотный словарь элементов
//двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент
//входных данных. Значения элементов массива 0..9
//Набор данных Частотный массив
//{ 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза
//1, 2, 3
//4, 6, 1
//2, 1, 6
//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза

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

void CheckNamberInArray(int[,] arr, int from, int to)
{
        for (int k = from; k < to ; k++)
    {
        int check = 0;
        for (int i = 0; i < arr.GetLength(0); i ++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i, j] == k) check = check+1;
            }
                    }
        Console.WriteLine($"Namber {k} present in array {check} once");
    }
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
int t = 11;

Console.WriteLine("-------------");
int[,] arr_1 = FillArrayFromTo(c, r, f, t);

PrintArray(arr_1);
Console.WriteLine();

CheckNamberInArray(arr_1, f, t);

//PrintArray(arr_2);
Console.WriteLine("-----------");
Console.WriteLine();


