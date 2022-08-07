// Задача 3: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3, 7, 22, 2, 78] -> 76

//Random random = new Random();
//double value = random.NextDouble(1.23, 5.34);

double[] DialArray(int size, int from, int to)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        Random x = new Random();
        arr[i] = Convert.ToDouble(x.Next( from , to )/100.0);
        //Console.WriteLine(arr[i]);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

double FindMaxMinDiffer(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
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
    double diff = max - min;
    return diff;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 10;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = -1000;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 1000;

Console.WriteLine("----------------");
DialArray(n, f, t);

double[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
Console.Write("Differ max min: ");

Console.WriteLine(FindMaxMinDiffer(arr));
Console.WriteLine();