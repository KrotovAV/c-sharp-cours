//Задача 3: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


int[] DialArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int FindСheckFromToNamber(int[] arr, int fFN, int fTN)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>fFN && arr[i] < fTN)
        {
            check = check + 1;
        }
    }
    return check;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 123;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = 0;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 150;

//Console.WriteLine("Write find from namber");
//int fFN = int.Parse(Console.ReadLine());
int fFN= 10;

//Console.WriteLine("Write find to namber");
//int fTN = int.Parse(Console.ReadLine());
int fTN= 100;

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
//FindСheckFromToNamber(arr, fFN, fTN);
Console.WriteLine(FindСheckFromToNamber(arr, fFN, fTN));
Console.WriteLine();

