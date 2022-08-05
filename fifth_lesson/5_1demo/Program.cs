//Задача 1: Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна -20.

int[] DialArray(int size, int from, int to)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to+1);
//        Console.Write(arr[i]);
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

void SumPosNeg(int[] arr)
{
    int pos = 0;
    int neg = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0)
            pos += arr[i];
        else
            neg += arr[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

Console.WriteLine();
Console.WriteLine("Write array size");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber from");
int f = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber to");
int t = int.Parse(Console.ReadLine());


Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
SumPosNeg(arr);

Console.WriteLine();
//Console.WriteLine("Hello, World!");
