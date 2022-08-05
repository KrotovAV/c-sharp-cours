//Задача 2: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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

void FindNamber(int[] arr, int fN)
{
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if(fN == arr[i])
        {
            Console.WriteLine($"Namber {fN} exist in [{i}] array position");
            c = c + i;
        }
    }
    if(c == 0)
        {
        Console.WriteLine($"Namber {fN} is not exist in array");
        }

}

Console.WriteLine();
Console.WriteLine("Write array size");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber from");
int f = int.Parse(Console.ReadLine());

Console.WriteLine("Write namber to");
int t = int.Parse(Console.ReadLine());

Console.WriteLine("Write find namber");
int fN = int.Parse(Console.ReadLine());

Console.WriteLine("----------------");
DialArray(n, f, t);

int[] arr = DialArray(n, f, t);

Console.Write("Array : ");
PrintArray(arr);

Console.WriteLine("----------------");
FindNamber(arr, fN);

Console.WriteLine();




