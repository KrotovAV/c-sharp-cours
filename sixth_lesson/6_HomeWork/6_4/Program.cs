//Задача 4: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования. 

double[] DialArray(int size, int from, int to)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(from, to+1)/100.0);
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

double[] CopyArray(double[] arr)
{
    double[] newArr = new double[arr.Length];
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
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
int t = 100;

Console.WriteLine("----------------");
DialArray(n, f, t);

double[] arr = DialArray(n, f, t);

Console.Write("       Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
double[] newArr = CopyArray(arr);
Console.Write("Copied array : ");
PrintArray(newArr);

Console.WriteLine();
