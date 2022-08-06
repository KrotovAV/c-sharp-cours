// Задача 2: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

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

int FindSumOddNam(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        sum= sum + arr[i];
    }
    return sum;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 4;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = 0;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 10;

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
Console.Write("Sum of odd nambers ");
//FindSumOddNam(arr);
Console.WriteLine(FindSumOddNam(arr));
Console.WriteLine();
