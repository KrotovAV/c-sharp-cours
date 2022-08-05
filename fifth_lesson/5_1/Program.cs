// Задача 1: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = arr[i] * -1;
    }
    return arr;
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

Console.Write("    Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
int[] newArr = ReversArray(arr);
Console.Write("New array : ");
PrintArray(newArr);
Console.WriteLine();
//Console.WriteLine("Hello, World!");



