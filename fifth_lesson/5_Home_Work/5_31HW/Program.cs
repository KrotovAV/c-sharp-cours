// Задача 3: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3, 7, 22, 2, 78] -> 76

//Random random = new Random();
//double value = random.NextDouble(1.23, 5.34);

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

int FindMaxMinDiffer(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        if(arr[i] < min)
        {
            min = arr[i];
        }
    }
    int diff = max - min;
    return diff;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 10;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = -20;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 20;

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
Console.Write("Differ max min: ");

Console.WriteLine(FindMaxMinDiffer(arr));
Console.WriteLine();