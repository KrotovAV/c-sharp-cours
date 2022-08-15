// Задача 1: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.
//[345, 897, 568, 234] -> 2



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

int FindСheckPositive(int[] arr)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0)
        {
            check = check + 1;
        }
    }
    return check;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 10;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = 0;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 1000;

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
Console.Write("Positive namber: ");
//FindСheckPositive(arr);
Console.WriteLine(FindСheckPositive(arr));
Console.WriteLine();
