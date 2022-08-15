//Демонстрация решения
//Задача 1: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]



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
    int vrem = 0;
    int n = arr.Length-1;
    
    for (int i = 0; i < arr.Length/2; i++)
    {
        vrem = arr[i];
        arr[i] = arr[n - i];
        arr[n-i] = vrem;

        //arr[i] = arr[i] + 1;
    }
    return arr;
}

Console.WriteLine();
//Console.WriteLine("Write array size");
//int n = int.Parse(Console.ReadLine());
int n = 7;

//Console.WriteLine("Write namber from");
//int f = int.Parse(Console.ReadLine());
int f = 0;

//Console.WriteLine("Write namber to");
//int t = int.Parse(Console.ReadLine());
int t = 1000;

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("       Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
int[] newArr = ReversArray(arr);
Console.Write("Revers array : ");
PrintArray(newArr);

Console.WriteLine();

